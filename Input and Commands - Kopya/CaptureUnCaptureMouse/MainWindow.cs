// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace CaptureUnCaptureMouse
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    class Context
    {
        private State _state = null;

        public Context(State state)
        {
            this.TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            this._state = state;
            this._state.SetContext(this);
        }

        public void Request1()
        {
            this._state.Handle1();
        }
        public void Request2()
        {
            this._state.Handle2();
        }
    }
    abstract class State : MainWindow
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }
        public abstract void Handle1();

        public abstract void Handle2();
    }

    class ConcreteStateA : State
    {
        IInputElement _elementToCapture;

        public ConcreteStateA(IInputElement elementToCapture)
        {
            this._elementToCapture = elementToCapture;
        }

        public override void Handle1()
        {
            this._context.TransitionTo(new ConcreteStateB());
        }
        public override void Handle2()
        {
            Mouse.Capture(_elementToCapture);
        }
    }
    class ConcreteStateB : State
    {
        public override void Handle1()
        {
            Mouse.Capture(null);
        }
        public override void Handle2()
        {
            this._context.TransitionTo(new ConcreteStateA(null));
        }
    }

    public partial class MainWindow : Window
    {
        private bool _changeColorOnMouseWheel;
        private IInputElement _elementToCapture;
        //private fields
        private bool _enlargeOnMouseOver;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            // Set button1 as the first element to get Mouse Capture,
            // if the user does not specifiy a different Button.
            _elementToCapture = Button1;
        }
        
        private void OnCaptureMouseRequest(object sender, RoutedEventArgs e)
        {
           var context = new Context(new ConcreteStateA(_elementToCapture));
            context.Request2();
           // Mouse.Capture(_elementToCapture);
        }

        private void OnUnCaptureMouseRequest(object sender, RoutedEventArgs e)
        {
            // To release mouse capture, pass null to Mouse.Capture.
            //Mouse.Capture(null);
            var context = new Context(new ConcreteStateA(_elementToCapture));
            context.Request1();
        }

        // GotMouseCapture event handler
        // MouseEventArgs.source is the element that has mouse capture
        private void ButtonGotMouseCapture(object sender, MouseEventArgs e)
        {
            var source = e.Source as Button;

            if (source != null)
            {
                // Update the Label that displays the sample results.
                lblHasMouseCapture.Content = source.Name;
            }
            // Another way to get the element with Mouse Capture
            // is to use the static Mouse.Captured property.
            else
            {
                // Mouse.Capture returns an IInputElement.
                IInputElement captureElement;

                captureElement = Mouse.Captured;

                // Update the Label that displays the element with mouse capture.
                lblHasMouseCapture.Content = captureElement.ToString();
            }
        }

        private void ButtonLostMouseCapture(object sender, MouseEventArgs e)
        {
            var source = e.Source as Button;

            if (source != null)
            {
                lblHasMouseCapture.Content = "";
            }
        }

        //***********************************************************
        //The rest of these methods are event handlers and methods  
        //used by the sample to process sample information.
        //***********************************************************
        private void OnButtonMouseEnter(object sender, RoutedEventArgs e)
        {
            var source = e.Source as Button;

            if (_enlargeOnMouseOver)
            {
                if (source != null)
                {
                    source.Height += 15;
                    source.Width += 15;
                }
            }
        }

        private void ButtonMouseClick(object sender, RoutedEventArgs e)
        {
            var source = e.Source as Button;

            if (source != null)
            {
                lblMouseClick.Content = source.Name;
            }
        }

        private void ButtonPreviewMouseDown(object sender, MouseEventArgs e)
        {
            var source = e.Source as Button;

            if (source != null)
            {
                lblLastMouseDown.Content = source.Name;
            }
        }

        private void ButtonPreviewMouseUp(object sender, MouseEventArgs e)
        {
            var source = e.Source as Button;

            if (source != null)
            {
                lblLastMouseUp.Content = source.Name;
            }
        }

        private void OnButtonMouseLeave(object sender, RoutedEventArgs e)
        {
            var source = e.Source as Button;

            if (_enlargeOnMouseOver)
            {
                if (source != null)
                {
                    source.Height -= 15;
                    source.Width -= 15;
                }
            }
        }

        private void OnButtonMouseWheel(object sender, MouseWheelEventArgs e)
        {
            var source = e.Source as Button;

            if (_changeColorOnMouseWheel)
            {
                if (source != null)
                {
                    source.Background = source.Background == Brushes.AliceBlue ? Brushes.Gold : Brushes.AliceBlue;
                }
            }
        }

        private void OnRadioButtonSelected(object sender, RoutedEventArgs e)
        {
            var source = e.Source as RadioButton;

            if (source != null)
            {
                switch (source.Content.ToString())
                {
                    case "1":
                        _elementToCapture = Button1;
                        break;
                    case "2":
                        _elementToCapture = Button2;
                        break;
                    case "3":
                        _elementToCapture = Button3;
                        break;
                    case "4":
                        _elementToCapture = Button4;
                        break;
                }
            }
        }

        private void MouseOverChecked(object sender, RoutedEventArgs e)
        {
            _enlargeOnMouseOver = true;
        }

        private void MouseOverUnChecked(object sender, RoutedEventArgs e)
        {
            _enlargeOnMouseOver = false;
        }

        private void MouseWheelChecked(object sender, RoutedEventArgs e)
        {
            _changeColorOnMouseWheel = true;
        }

        private void MouseWheelUnChecked(object sender, RoutedEventArgs e)
        {
            _changeColorOnMouseWheel = false;
        }
    }
}