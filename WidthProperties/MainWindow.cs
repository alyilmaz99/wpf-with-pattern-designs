// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WidthProperties
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public interface IObserver
    {
        void Update(ISubject subject);
    }
    public interface ISubject
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
        

    }

    public class Subject : ISubject
    {
        Canvas _canvas;
        TextBlock _textblock;
        
        
        private List<IObserver> _observers = new List<IObserver>();
        
        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
            

        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            
            
        }
        public void Notify()
        {
            foreach(var observer in _observers)
            {
                observer.Update(this);
            }
            
        }
        
        public void SomeBusinessLogic(Canvas canvas,TextBlock textblock)
        {
            _canvas = canvas;
            _textblock = textblock;
            _textblock.Text = "Canvas.ClipToBounds is set to" + _canvas.ClipToBounds;
            this.Notify();

        }
    }

    class ClipTrueObserver : IObserver
    {
        Canvas _canvas;
        TextBlock _textblock;
        
        public ClipTrueObserver(Canvas canvas,TextBlock textblock)
        {
            _canvas = canvas;
            _textblock = textblock;
        }
        public void Update(ISubject subject)
        {
            _canvas.ClipToBounds = true;
           // _textblock.Text = "Canvas.ClipToBounds is set to" + _canvas.ClipToBounds;
        }

    }
    class ClipFalseObserver : IObserver
    {
        Canvas _canvas;
        TextBlock _textBlock;

        public ClipFalseObserver(Canvas canvas,TextBlock textblock)
        {
            _canvas = canvas;
            _textBlock = textblock;
        }
        public void Update(ISubject subject)
        {
            _canvas.ClipToBounds = false;
            //_textBlock.Text = "Canvas.ClipToBounds is set to" + _canvas.ClipToBounds;
        }
    }


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            subject = new Subject();
            
            
            
        }
        Subject subject;
        ClipFalseObserver clipFalseObserver;
        ClipTrueObserver clipTrueObserver;

        private void ChangeWidth(object sender, SelectionChangedEventArgs args)
        {
            var li = ((sender as ListBox).SelectedItem as ListBoxItem);
            var sz1 = double.Parse(li.Content.ToString());
            rect1.Width = sz1;
            rect1.UpdateLayout();
            txt1.Text = "ActualWidth is set to " + rect1.ActualWidth;
            txt2.Text = "Width is set to " + rect1.Width;
            txt3.Text = "MinWidth is set to " + rect1.MinWidth;
            txt4.Text = "MaxWidth is set to " + rect1.MaxWidth;
        }

        private void ChangeMinWidth(object sender, SelectionChangedEventArgs args)
        {
            var li = ((sender as ListBox).SelectedItem as ListBoxItem);
            var sz1 = double.Parse(li.Content.ToString());
            rect1.MinWidth = sz1;
            rect1.UpdateLayout();
            txt1.Text = "ActualWidth is set to " + rect1.ActualWidth;
            txt2.Text = "Width is set to " + rect1.Width;
            txt3.Text = "MinWidth is set to " + rect1.MinWidth;
            txt4.Text = "MaxWidth is set to " + rect1.MaxWidth;
        }

        private void ChangeMaxWidth(object sender, SelectionChangedEventArgs args)
        {
            var li = ((sender as ListBox).SelectedItem as ListBoxItem);
            var sz1 = double.Parse(li.Content.ToString());
            rect1.MaxWidth = sz1;
            rect1.UpdateLayout();
            txt1.Text = "ActualWidth is set to " + rect1.ActualWidth;
            txt2.Text = "Width is set to " + rect1.Width;
            txt3.Text = "MinWidth is set to " + rect1.MinWidth;
            txt4.Text = "MaxWidth is set to " + rect1.MaxWidth;
        }

        private void ClipRect(object sender, RoutedEventArgs args)
        {
            clipTrueObserver = new ClipTrueObserver(myCanvas, txt5);
            subject.Attach(clipTrueObserver);
            subject.SomeBusinessLogic(myCanvas,txt5);
           
        }
        
        public void UnclipRect(object sender, RoutedEventArgs args)
        {
            clipFalseObserver = new ClipFalseObserver(myCanvas, txt5);
            subject.Attach(clipFalseObserver);
            subject.SomeBusinessLogic(myCanvas,txt5);
            
            
        }
       
        public  void DetachFalse(object sender, RoutedEventArgs args)
        {
            
            subject.Detach(clipFalseObserver);
            subject.SomeBusinessLogic(myCanvas, txt5);
            
        }
        public void DetachTrue(object sender, RoutedEventArgs args)
        {
            
            subject.Detach(clipTrueObserver);
            subject.SomeBusinessLogic(myCanvas, txt5);
           
        }
    }
}