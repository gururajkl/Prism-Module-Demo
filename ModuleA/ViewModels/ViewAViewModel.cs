using Prism.Mvvm;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string title = "Hello from ViewA ViewModel";
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
    }
}
