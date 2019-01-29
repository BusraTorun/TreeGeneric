using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tree.UI;
using TreeGeneric.BussinessLogic;
using TreeGeneric.Data;
using TreeGeneric.Model;

namespace TreeGeneric.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Autofac = IoC (Inversion-of-Control) Provider'ıdır. Bununla dependency injection işlemi kolaylaşır.
            var builder = new ContainerBuilder();
            builder.RegisterType<ApplicationDbContext>().As<ApplicationDbContext>();            

            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));

            builder.RegisterType<RegionService>().As<IRegionService>();
            builder.RegisterType<PlantingService>().As<IPlantingService>();
            builder.RegisterType<TreeTypeService>().As<ITreeTypeService>();
            

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new FrmSplash(scope));
            }
        }
    }
}
