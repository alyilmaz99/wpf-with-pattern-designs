// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ThicknessConverter
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
   
    
    interface IComponent
    {
        public void Operation(object sender, SelectionChangedEventArgs args);
    }

    class Component : IComponent
    {
        TextBlock _textblock;
        Border _border;
        
        public Component(TextBlock textblock, Border border)
        {
            _textblock = textblock;
            _border = border;
           
        }


        public void Operation(object sender, SelectionChangedEventArgs args)
        {
            
            var li = ((sender as ListBox).SelectedItem as ListBoxItem);
            var myThicknessConverter = new System.Windows.ThicknessConverter();
            var th1 = (Thickness)myThicknessConverter.ConvertFromString(li.Content.ToString());
            _border.BorderThickness = th1;
            _textblock.Text = "Border.BorderThickness =" + li.Content;
            
        }

        
    }
    class DecoratorBorder : IComponent
    {
        IComponent _component;
        Border _border;
        TextBlock _textblock;
        
        public DecoratorBorder(IComponent component, Border border, TextBlock textblock)
        {
            _component = component;
            _border = border;
            _textblock = textblock;
           
        }
        public void Operation(object sender, SelectionChangedEventArgs args)
        {
            _component.Operation(sender,args);
        }
    }

    class DecoratorColor : IComponent
    {
        IComponent _component;
        Border _border;
        TextBlock _textblock;
        public DecoratorColor(IComponent component, Border border, TextBlock textblock)
        {
            _component = component;
            _border = border;
            _textblock = textblock;
        }
        public void Operation(object sender, SelectionChangedEventArgs args)
        {
            _component.Operation(sender, args);
        }
    }
    

    public partial class MainWindow : Window
    {
       
       
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void ChangeThickness(object sender, SelectionChangedEventArgs args)
        {
            IComponent component = new Component(bThickness, border1);
            DecoratorBorder decoratorBorder = new DecoratorBorder(component,border1,bThickness);
            decoratorBorder.Operation(sender,args);
            /*
            var li = ((sender as ListBox).SelectedItem as ListBoxItem);
            var myThicknessConverter = new System.Windows.ThicknessConverter();
            var th1 = (Thickness) myThicknessConverter.ConvertFromString(li.Content.ToString());
            border1.BorderThickness = th1;
            bThickness.Text = "Border.BorderThickness =" + li.Content;
            */

        }

        private void ChangeColor(object sender, SelectionChangedEventArgs args)
        {
            /*
            IComponent component = new Component(bThickness, border1,bColor);
            DecoratorColor decoratorColor = new DecoratorColor(component, border1, bColor);
            decoratorColor.Operation(sender,args);
            */
            
            var li2 = ((sender as ListBox).SelectedItem as ListBoxItem);
            var myBrushConverter = new BrushConverter();
            border1.BorderBrush = (Brush) myBrushConverter.ConvertFromString((string) li2.Content);
            bColor.Text = "Border.Borderbrush =" + li2.Content;
            
        }
    }
}