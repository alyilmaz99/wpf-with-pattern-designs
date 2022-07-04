// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace DragDropTextOps
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
        public void SomeBusinessLogic()
        {
            this.Notify();
        }
    }

    class TextSelection : IObserver
    {
        TextBox _textbox1;
        TextBox _textbox2;
        public TextSelection(TextBox textbox1, TextBox textbox2)
        {
            _textbox1 = textbox1;
            _textbox2 = textbox2;
        }
        public void Update(ISubject subject)
        {
            // Create a new data object using one of the overloaded constructors.  This particular
            // overload accepts a string specifying the data format (provided by the DataFormats class),
            // and an Object (in this case a string) that represents the data to be stored in the data object.
            var dataObject = new DataObject(DataFormats.Text, _textbox1.SelectedText);

            _textbox2.Clear();

            // Get and display the native data formats (filtering out auto-convertable data formats).
            _textbox2.Text = "\nNative data formats present:\n";
            foreach (var format in dataObject.GetFormats(false /*autoconvert*/))
                _textbox2.Text += format + "\n";

            // Display the data in the data object.
            _textbox2.Text += "\nData contents:\n";
            _textbox2.Text += dataObject.GetData(DataFormats.Text, false /*autoconvert*/).ToString();
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
        TextSelection textSelection;

        private void TextSelectionToDataObject(object sender, RoutedEventArgs e)
        {
            textSelection = new TextSelection(sourceTextBox, dataObjectInfoTextBox);
            subject.Attach(textSelection);
            subject.SomeBusinessLogic();
            /*
            // Create a new data object using one of the overloaded constructors.  This particular
            // overload accepts a string specifying the data format (provided by the DataFormats class),
            // and an Object (in this case a string) that represents the data to be stored in the data object.
            var dataObject = new DataObject(DataFormats.Text, sourceTextBox.SelectedText);

            dataObjectInfoTextBox.Clear();

            // Get and display the native data formats (filtering out auto-convertable data formats).
            dataObjectInfoTextBox.Text = "\nNative data formats present:\n";
            foreach (var format in dataObject.GetFormats(false /*autoconvert))
                dataObjectInfoTextBox.Text += format + "\n";

            // Display the data in the data object.
            dataObjectInfoTextBox.Text += "\nData contents:\n";
            dataObjectInfoTextBox.Text += dataObject.GetData(DataFormats.Text, false /*autoconvert).ToString();
            */
        }
    }
}