using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using HospitalIS.DataContexts;

namespace HospitalIS.Core.IoC
{
    public static class IoC
    {
        public static IContainer Container { get; set; }
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<XmlContext>().As<IDataContext>();

            Container =  builder.Build();
        }
    }
}
