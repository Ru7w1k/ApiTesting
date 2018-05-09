using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel()
        {
        }

        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; Notify(); }
        }
    }
}
