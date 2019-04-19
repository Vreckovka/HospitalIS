using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using HospitalIS.Models;

namespace HospitalIS.Other
{
    public class PacientGenerator
    {
        private Random _random = new Random();
        private List<string> _names = new List<string>();
        private TriangularDistribution _heightDistribution;
        private TriangularDistribution _weightDistribution;

        public PacientGenerator()
        {

            _heightDistribution = new TriangularDistribution(_random.Next(), 160, 200, 180);
            _weightDistribution = new TriangularDistribution(_random.Next(), 50, 130, 85);
            LoadNames();
        }

        private void LoadNames()
        {
            using (StreamReader reader = new StreamReader("..\\..\\names.txt"))
            {
                while (!reader.EndOfStream)
                {
                    _names.Add(reader.ReadLine());
                }
            }
        }

        public Pacients CreatePacients(int count)
        {
            Pacients pacients = new Pacients();
         
            var startDate = new DateTime(1950, 1, 1);
            var endDate = new DateTime(2019, 12, 31);

            TriangularDistribution triangularDistribution = new TriangularDistribution(_random.Next(), 0,(int)(endDate - startDate).TotalMinutes, (int)(endDate - startDate).TotalMinutes /2);
            for (int i = 0; i < count; i++)
            {
                DateTime dateTime = RandomDate(startDate,triangularDistribution);
                string date = "";

                if (_random.Next(0, 100) < 50)
                {
                    date = dateTime.ToString("yy") + (dateTime.Month + 50) + dateTime.ToString("dd") + "0000";
                }
                else
                {
                    date = dateTime.ToString("yyMMdd") + "0000";
                }

                long pid = Convert.ToInt64(date) + i;
                long b = pid % 11;

                pid += 11 - b;

                Pacient pacient = new Pacient()
                {
                    PID = pid.ToString("######/####"),
                    FirstName = GetRandomName(),
                    LastName = GetRandomName(),
                    BirthDate = dateTime,
                    Height = _heightDistribution.GetNext(),
                    Weight = _weightDistribution.GetNext(),
                };

                pacients.Add(pacient);
            }

            return pacients;
        }

        private DateTime RandomDate(DateTime startDate,TriangularDistribution triangularDistribution)
        {
            TimeSpan newSpan = new TimeSpan(0, (int)triangularDistribution.GetNext(), 0);
            DateTime newDate = startDate + newSpan;
            return newDate.Date;

        }

        private string GetRandomName()
        {
            return _names[_random.Next(0, _names.Count)];
        }

        public void SerializePacients(string path, Pacients pacients)
        {
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pacients));
                xmlSerializer.Serialize(stream, pacients);
            }
        }
    }

    public class TriangularDistribution
    {
        private int a;
        private int b;
        private int c;
        private Random _random;

        public TriangularDistribution(int seed, int min, int max, int modus)
        {
            a = min;
            b = max;
            c = modus;
            _random = new Random(seed);
        }

        public double GetNext()
        {
            double F = (double)(c - a) / (b - a);
            double rand = _random.NextDouble();

            if (rand < F)
            {
                return a + Math.Sqrt(rand * (b - a) * (c - a));
            }
            else
            {
                return b - Math.Sqrt((1 - rand) * (b - a) * (b - c));
            }
        }
    }
}
