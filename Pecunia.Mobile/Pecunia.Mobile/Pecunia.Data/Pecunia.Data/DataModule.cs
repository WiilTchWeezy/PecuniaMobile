using Prism.Ioc;
using Prism.Modularity;
using Pecunia.Data.Views;
using Pecunia.Data.ViewModels;

namespace Pecunia.Data
{
    public class DataModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
    }
}
