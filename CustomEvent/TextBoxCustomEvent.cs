using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace QAIMS4901.Resources
{
    class TextBoxCustomEvent : TextBox
    {
        // Create a custom routed event by first registering a RoutedEventID
        // This event uses the bubbling routing strategy
        public static readonly RoutedEvent TxtChangedEvent = EventManager.RegisterRoutedEvent(
            "TxtChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TextBoxCustomEvent));

        // Provide CLR accessors for the event
        public event RoutedEventHandler TxtChanged
        {
            add { AddHandler(TxtChangedEvent, value); }
            remove { RemoveHandler(TxtChangedEvent, value); }
        }

        // This method raises the TxtChanged event
        void RaiseTxtChangedEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(TextBoxCustomEvent.TxtChangedEvent);
            RaiseEvent(newEventArgs);
        }

        // For demonstration purposes we raise the event when the MyButtonSimple is clicked
        public void TxtChangedClick()
        {
            RaiseTxtChangedEvent();
        }
    }
}
