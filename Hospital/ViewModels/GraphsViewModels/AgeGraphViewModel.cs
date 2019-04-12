using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalIS.Models;

namespace HospitalIS.ViewModels.GraphsViewModels
{
    public class AgeGraphViewModel : BaseGraphViewModel
    {
        public AgeGraphViewModel()
        {
            XAxisTitle = "Age range";

            _ranges = new int[6];

            for (int i = 0; i < labelCount; i++)
            {
                if (i != 0)
                    _ranges[i] = (i * 10) + 10;
                else
                    _ranges[i] = 10;
            }
        }

        public override void GetValues()
        {
            ColumnValues.Clear();

            for (int i = 0; i < _ranges.Length; i++)
            {
                var lowBound = _ranges[i];
                int highBound = 0;
                int count = 0;
                string title = "";


                if (i != _ranges.Length - 1)
                    highBound = _ranges[i + 1];


                if (i == 0)
                {
                    count = (from x in LoadedPacients.Pacients where x.Age <= lowBound select x).ToList().Count;
                    title = $"less then {lowBound}";
                }

                else if (i == _ranges.Length - 1)
                {
                    count = (from x in LoadedPacients.Pacients where x.Age >= lowBound select x).ToList().Count;
                    title = $"more then {lowBound}";
                }
                else
                {
                    count = (from x in LoadedPacients.Pacients
                        where x.Age >= lowBound
                        where x.Age <= highBound
                        select x).ToList().Count;
                    title = $"{lowBound} - {highBound}";
                }


                ColumnValues.Add(count);
                ColumnLabels[i] = title;
            }
        }
    }
}
