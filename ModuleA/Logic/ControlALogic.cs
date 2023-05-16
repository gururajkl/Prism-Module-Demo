using Prism.Mvvm;

namespace ModuleA.Logic
{
    public class ControlALogic : BindableBase
    {
        private string text = "Custom viewModel and View";
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }
    }
}
