using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace CustomControlBinding
{
    /// <summary>
    /// Interaction logic for CustomTextBox.xaml
    /// </summary>
    public partial class CustomTextBox : UserControl
    {
        public CustomTextBox()
        {
            InitializeComponent();
            //RootElement.DataContext = this;
        }

        public static DependencyProperty TextContentProperty = DependencyProperty.Register("TextContent", typeof(string), typeof(CustomTextBox),
            new UIPropertyMetadata(String.Empty, TextContentPropertyChanged));

        private static void TextContentPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomTextBox x = (CustomTextBox)d;
            x.textBox.Text = e.NewValue as string;
        }

        public string TextContent
        {
            get { return (string)GetValue(TextContentProperty); }
            set { SetValue(TextContentProperty, value); }
        }
    }
}
