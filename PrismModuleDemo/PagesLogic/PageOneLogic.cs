using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismModuleDemo.PagesLogic
{
    public class PageOneLogic : BindableBase
    {
        private string text = "Page logic view model";
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }
    }
}
