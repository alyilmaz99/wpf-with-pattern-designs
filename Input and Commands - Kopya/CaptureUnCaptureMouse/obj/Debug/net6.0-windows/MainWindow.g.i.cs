﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33A775F48068A80599ACA29E614B97C94018092E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using CaptureUnCaptureMouse;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CaptureUnCaptureMouse {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 102 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button1;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button2;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button3;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button4;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblHasMouseCapture;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMouseClick;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLastMouseDown;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLastMouseUp;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CaptureUnCaptureMouse;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 7 "..\..\..\MainWindow.xaml"
            ((CaptureUnCaptureMouse.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 42 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).AddHandler(System.Windows.Controls.Primitives.ToggleButton.CheckedEvent, new System.Windows.RoutedEventHandler(this.OnRadioButtonSelected));
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 56 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).AddHandler(System.Windows.Controls.Primitives.ToggleButton.CheckedEvent, new System.Windows.RoutedEventHandler(this.OnRadioButtonSelected));
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 64 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.MouseOverChecked);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.MouseOverUnChecked);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 68 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.MouseWheelChecked);
            
            #line default
            #line hidden
            
            #line 69 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.MouseWheelUnChecked);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 76 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnCaptureMouseRequest);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 82 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnUnCaptureMouseRequest);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 93 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.ButtonGotMouseCapture);
            
            #line default
            #line hidden
            
            #line 94 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).LostMouseCapture += new System.Windows.Input.MouseEventHandler(this.ButtonLostMouseCapture);
            
            #line default
            #line hidden
            
            #line 95 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.ButtonMouseClick));
            
            #line default
            #line hidden
            
            #line 96 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ButtonPreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 97 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ButtonPreviewMouseUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Button1 = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\MainWindow.xaml"
            this.Button1.MouseEnter += new System.Windows.Input.MouseEventHandler(this.OnButtonMouseEnter);
            
            #line default
            #line hidden
            
            #line 104 "..\..\..\MainWindow.xaml"
            this.Button1.MouseLeave += new System.Windows.Input.MouseEventHandler(this.OnButtonMouseLeave);
            
            #line default
            #line hidden
            
            #line 105 "..\..\..\MainWindow.xaml"
            this.Button1.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.OnButtonMouseWheel);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Button2 = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\..\MainWindow.xaml"
            this.Button2.MouseEnter += new System.Windows.Input.MouseEventHandler(this.OnButtonMouseEnter);
            
            #line default
            #line hidden
            
            #line 114 "..\..\..\MainWindow.xaml"
            this.Button2.MouseLeave += new System.Windows.Input.MouseEventHandler(this.OnButtonMouseLeave);
            
            #line default
            #line hidden
            
            #line 115 "..\..\..\MainWindow.xaml"
            this.Button2.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.OnButtonMouseWheel);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Button3 = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\..\MainWindow.xaml"
            this.Button3.MouseEnter += new System.Windows.Input.MouseEventHandler(this.OnButtonMouseEnter);
            
            #line default
            #line hidden
            
            #line 124 "..\..\..\MainWindow.xaml"
            this.Button3.MouseLeave += new System.Windows.Input.MouseEventHandler(this.OnButtonMouseLeave);
            
            #line default
            #line hidden
            
            #line 125 "..\..\..\MainWindow.xaml"
            this.Button3.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.OnButtonMouseWheel);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Button4 = ((System.Windows.Controls.Button)(target));
            
            #line 133 "..\..\..\MainWindow.xaml"
            this.Button4.MouseEnter += new System.Windows.Input.MouseEventHandler(this.OnButtonMouseEnter);
            
            #line default
            #line hidden
            
            #line 134 "..\..\..\MainWindow.xaml"
            this.Button4.MouseLeave += new System.Windows.Input.MouseEventHandler(this.OnButtonMouseLeave);
            
            #line default
            #line hidden
            
            #line 135 "..\..\..\MainWindow.xaml"
            this.Button4.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.OnButtonMouseWheel);
            
            #line default
            #line hidden
            return;
            case 13:
            this.lblHasMouseCapture = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.lblMouseClick = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            this.lblLastMouseDown = ((System.Windows.Controls.Label)(target));
            return;
            case 16:
            this.lblLastMouseUp = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

