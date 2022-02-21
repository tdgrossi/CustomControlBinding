using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControlBinding
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string m_inputBindingText;

        public string InputBindingText
        {
            get { return m_inputBindingText; }
            set { SetProperty(ref m_inputBindingText, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
