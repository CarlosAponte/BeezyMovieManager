using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BeezyServices;
using BeezyServices.Models;
using BeezyServices.Interfaces;

namespace BeezyApiManager.App_Start
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Movie>().As<IMovie>();
            builder.RegisterType<TvShow>().As<ITvShow>();

            return builder.Build();


        }
    }
}