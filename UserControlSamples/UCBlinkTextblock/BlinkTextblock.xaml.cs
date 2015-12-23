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

namespace UCBlinkTextblock
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class BlinkTextblock : UserControl
    {
        #region BlinkTextbox DP
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(BlinkTextblock), new PropertyMetadata(""));



        public Boolean IsBlink
        {
            get { return (Boolean)GetValue(IsBlinkProperty); }
            set { SetValue(IsBlinkProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Trigger.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsBlinkProperty =
            DependencyProperty.Register("IsBlink", typeof(Boolean), typeof(BlinkTextblock), new PropertyMetadata(false));

        
        #endregion

        public BlinkTextblock()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
