using ModuleA.Logic;
using ModuleA.Pages;
using ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;

namespace ModuleA
{
    public class ModuleAModule : IModule
    {
        private readonly IRegionManager regionManager;

        public ModuleAModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            //regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ControlA));
            //IRegion region = regionManager.Regions["ContentRegion"];
            //var viewA = containerProvider.Resolve<ViewA>(); 
            //region.Add(viewA);
            //region.Activate(viewA);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // syk super.
            ViewModelLocationProvider.Register<ControlA>(() => new ControlALogic()
            {
                Text = "Hello from factory"
            });
        }
    }
}
