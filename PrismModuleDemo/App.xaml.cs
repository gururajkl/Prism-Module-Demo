using ModuleA;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using PrismModuleDemo.Pages;
using PrismModuleDemo.PagesLogic;
using PrismModuleDemo.Views;
using System.Windows;

namespace PrismModuleDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<PageOne, PageOneLogic>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleAModule>();
        }
    }
}
