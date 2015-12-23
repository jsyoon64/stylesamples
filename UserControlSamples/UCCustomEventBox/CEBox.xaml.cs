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

namespace UCCustomEventBox
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class CustomEventTextBox : UserControl
    {
        #region Dependancy Property
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(CustomEventTextBox), new PropertyMetadata(""));


        // Blink Color Dependancy property
        public string BlinkColor
        {
            get { return (string)GetValue(BlinkColorProperty); }
            set { SetValue(BlinkColorProperty, value);}
        }

        // Using a DependencyProperty as the backing store for BlinkColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BlinkColorProperty =
            DependencyProperty.Register("BlinkColor", typeof(string), typeof(CustomEventTextBox), 
            new PropertyMetadata("",new PropertyChangedCallback(OnBlinkColorChanged)));

        static void OnBlinkColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomEventTextBox es = d as CustomEventTextBox;
        }
        #endregion

        public CustomEventTextBox()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void CustomReoutedTextBox_BlueBlink(object sender, RoutedEventArgs e)
        {

        }

        private void CustomReoutedTextBox_RedBlink(object sender, RoutedEventArgs e)
        {

        }
    }
}
