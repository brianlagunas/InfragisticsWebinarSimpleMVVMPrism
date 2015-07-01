using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Unity;
using PrismDemo.Views;

namespace PrismDemo
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            //Container.RegisterType(typeof(object), typeof(ViewA), "ViewA");
            //Container.RegisterType(typeof(object), typeof(ViewB), "ViewB");

            Container.RegisterTypeForNavigation<ViewA>("ViewA");
            Container.RegisterTypeForNavigation<ViewB>("ViewB");
        }
    }

    public static class UnityExtensions
    {
        public static void RegisterTypeForNavigation<T>(this IUnityContainer container, string name)
        {
            container.RegisterType(typeof (object), typeof (T), name);
        }
    }

    
}
