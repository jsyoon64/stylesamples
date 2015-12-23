using System;
using System.Collections.Generic;
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

namespace UCBlinkTextbox
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class BlinkTextbox : UserControl
    {

        //public SolidColorBrush Color
        //{
        //    get { return (SolidColorBrush)GetValue(ColorProperty); }
        //    set { SetValue(ColorProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for Color.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty ColorProperty =
        //    DependencyProperty.Register("Color", typeof(SolidColorBrush), typeof(BlinkTextbox), new PropertyMetadata(Brushes.Black));


        public Boolean IsBlink
        {
            get { return (Boolean)GetValue(IsBlinkProperty); }
            set { SetValue(IsBlinkProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsBlink.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsBlinkProperty =
            DependencyProperty.Register("IsBlink", typeof(Boolean), typeof(BlinkTextbox), new PropertyMetadata(false));



        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(BlinkTextbox), new PropertyMetadata(""));

        
        public BlinkTextbox()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
