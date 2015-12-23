using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace UCCustomEventBox
{
    public class CustomReoutedTextBox :TextBox
    {
        #region Dependancy Property  Blink Color Dependancy property
        public string BlinkColor
        {
            get { return (string)GetValue(BlinkColorProperty); }
            set { SetValue(BlinkColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BlinkColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BlinkColorProperty =
            DependencyProperty.Register("BlinkColor", typeof(string), typeof(CustomReoutedTextBox),
            new PropertyMetadata("", new PropertyChangedCallback(OnBlinkColorChanged)));

        static void OnBlinkColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomReoutedTextBox es = d as CustomReoutedTextBox;
            if (es != null)
            {
                if (e.NewValue.ToString() == "Red")
                {
                    es.RaiseRedBlinkEvent();
                }
                else if (e.NewValue.ToString() == "Blue")
                {
                    es.RaiseBlueBlinkEvent();
                }
            }
        }
        #endregion

        #region Custom Routed Event
        // Create a custom routed event by first registering a RoutedEventID
        // This event uses the bubbling routing strategy
        public static readonly RoutedEvent RedBlinkEvent = EventManager.RegisterRoutedEvent(
            "RedBlink", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CustomReoutedTextBox));

        public static readonly RoutedEvent BlueBlinkEvent = EventManager.RegisterRoutedEvent(
            "BlueBlink", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CustomReoutedTextBox));

        // Provide CLR accessors for the event
        public event RoutedEventHandler RedBlink
        {
            add { AddHandler(RedBlinkEvent, value); }
            remove { RemoveHandler(RedBlinkEvent, value); }
        }
        public event RoutedEventHandler BlueBlink
        {
            add { AddHandler(BlueBlinkEvent, value); }
            remove { RemoveHandler(BlueBlinkEvent, value); }
        }

        // This method raises the RedBlink event
        public void RaiseRedBlinkEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(CustomReoutedTextBox.RedBlinkEvent);
            RaiseEvent(newEventArgs);
        }
        // This method raises the BlueBlink event
        public void RaiseBlueBlinkEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(CustomReoutedTextBox.BlueBlinkEvent);
            RaiseEvent(newEventArgs);
        }
        #endregion

    }
}
