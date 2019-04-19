using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalIS.Core.Models;
using HospitalIS.DataContexts;

namespace HospitalIS.Core.DataContexts
{
    public abstract class DataContext : IDataContext
    {
        public Pacients Pacients { get; set; }
        public abstract void Load();
        public abstract void Save();
    }
}
