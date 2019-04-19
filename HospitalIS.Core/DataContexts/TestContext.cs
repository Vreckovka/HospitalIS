using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalIS.Core.DataContexts
{
    public class TestContext : DataContext
    {
        public override void Load()
        {
            Pacients = new Models.Pacients()
            {
                new Models.Pacient()
                {
                    PID = "1",
                    FirstName = "Roman",
                    LastName = "Pecho"
                },
                new Models.Pacient()
                {
                    PID = "3",
                    FirstName = "Jozko",
                    LastName = "Pecho"
                },
                new Models.Pacient()
                {
                    PID = "2",
                    FirstName = "Ferko",
                    LastName = "Pecho"
                }
            };
        }

        public override void Save()
        {
        }
    }
}
