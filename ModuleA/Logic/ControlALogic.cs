using Prism.Commands;
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

        private bool canCheck = false;
        public bool CanCheck
        {
            get { return canCheck; }
            set
            {
                SetProperty(ref canCheck, value);
            }
        }

        public ControlALogic()
        {
            Click = new DelegateCommand(Execute)
                .ObservesCanExecute(() => CanCheck);
        }

        public void Execute()
        {
            Text = "Button was clicked";
        }

        public DelegateCommand Click { get; private set; }
    }
}
