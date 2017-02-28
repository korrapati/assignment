using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assigment.Interface;
using Assigment.Repository;
using StructureMap;
using StructureMap.Graph;
namespace Assigment.Web.DependencyResolution
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            ObjectFactory.Initialize(x =>
            {
                x.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });
                x.For<IFolksService>().Use<FolksRepository>();
            });
            return ObjectFactory.Container;
        }
    }
}