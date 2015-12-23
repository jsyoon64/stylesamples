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

namespace UserControlSamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BlinkType btype = new BlinkType();
        public BlinkType BType
        {
            get { return btype; }
            set { btype = value; }
        }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void RedRB_Click(object sender, RoutedEventArgs e)
        {
            CETBox.BlinkColor = "Red";
        }

        private void BlueRB_Click(object sender, RoutedEventArgs e)
        {
            CETBox.BlinkColor = "Blue";
        }

    }

    public class BlinkType : ViewModelBase
    {
        private Boolean isblink;

        public Boolean IsBlink
        {
            get
            {
                return isblink;
            }
            set
            {
                isblink = value;
                OnPropertyChanged("IsBlink");
            }
        }
    }
}
