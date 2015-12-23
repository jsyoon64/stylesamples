using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace StyleExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region for Validation TextBox
        private int _errors = 0;
        private Employee _employee = new Employee();
        #endregion

        #region for MVVM Blink type
        private BlinkType btype = new BlinkType();
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            #region for Validation TextBox
            TextValidationCheckPanel.DataContext = _employee;
            #endregion

            #region for MVVM Blink type
            BlinkWrapPanel.DataContext = btype;
            #endregion
        }

        #region for Validation TextBox
        private void Confirm_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _errors == 0;
            e.Handled = true;
        }

        private void Confirm_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            e.Handled = true;
        }

        private void TextBox_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added) 
            { 
                _errors++;
            }
            else 
            { 
                _errors--; 
            }
        }
    }

    public class Employee:IDataErrorInfo
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Error
        {
            get { throw new NotImplementedException(); }
        }
        public string this[string columnName]
        {
            get
            {
                string result = null;
                if(columnName == "Name")
                {
                    if (string.IsNullOrEmpty(Name) || Name.Length < 3)
                        result = "Please enter a Name";
                }
                if (columnName == "Salary")
                {
                    if (Salary <= 1000 || Salary >= 50000)
                        result = "Please enter a valid salary amount. 1000보다크고 50000보다 작은값";
                }
                return result;
            }
        }
        #endregion
    }

    #region for MVVM Blink type
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
    #endregion

    //class IsEnableConverter : IMultiValueConverter
    //{

    //    public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    //    {
    //        double width = (double)values[0];
    //        double height = (double)values[1];
    //        return new Rect(0, 0, width, height);
    //    }
    //    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //class IsEnableConverter : IValueConverter
    //{
    //    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    //    {
    //        byte lsbdp = (byte)((byte)value & 1);
    //        if (value is byte && lsbdp == 0)
    //        {
    //            return false;
    //        }
    //        return true;
    //    }

    //    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
