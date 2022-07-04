// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;

namespace VisibiltyChanges
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    /*   public interface IGorunurluk
       {
           public void vsozellik();
       }

       public class Visible : MainWindow, IGorunurluk
       {
           public void vsozellik()
           {
               tb1.Visibility = Visibility.Visible;
               txt1.Text = "Visibility is now set to Visible.";
           }
       }
       public class Hidden : MainWindow, IGorunurluk
       {
           public void vsozellik()
           {
               tb1.Visibility = Visibility.Hidden;
               txt1.Text = "Visibility is now set to Hidden. Notice that the TextBox still occupies layout space.";
           }
       }
       public class Collapsed : MainWindow , IGorunurluk
       {
           public void vsozellik()
           {
               tb1.Visibility = Visibility.Collapsed;
               txt1.Text = "Visibility is now set to Collapsed. Notice that the TextBox no longer occupies layout space.";
           }
       }

      public class Context
       {
           private IGorunurluk gorunurluk;
           public void setGorunurluk(IGorunurluk gorunurluk)
           {
               this.gorunurluk = gorunurluk;

           }
           public void AGorunurluk()
           {
               gorunurluk.vsozellik();
           }
       } */

    

    public partial class MainWindow : Window 
    {

        Context context;
        public MainWindow()
        {
            InitializeComponent();
            context = new Context(txt1, tb1);
            
         /*   Context contextHidden = new Context();
            contextHidden.setGorunurluk(new Hidden());
            Context contextCollapsed = new Context();
            contextCollapsed.setGorunurluk(new Collapsed());
         */ 

        }
       

        
        
       
        private void ContentVis(object sender, RoutedEventArgs e)
        {

            context.setgorunuluk(new Visible());
            context.gorunurlukdegistir();

            /*
            tb1.Visibility = Visibility.Visible;
            txt1.Text = "Visibility is now set to Visible.";
            */
        }
        
        
        
        private void ContentHid(object sender, RoutedEventArgs e)
        {
            context.setgorunuluk(new Hidden());
            context.gorunurlukdegistir();
            /*
            tb1.Visibility = Visibility.Hidden;
            txt1.Text = "Visibility is now set to Hidden. Notice that the TextBox still occupies layout space.";
            */
        }
        
        
        private void ContentCol(object sender, RoutedEventArgs e)
        {
            context.setgorunuluk(new Collapse());
            context.gorunurlukdegistir();
            /*
            tb1.Visibility = Visibility.Collapsed;
            txt1.Text = "Visibility is now set to Collapsed. Notice that the TextBox no longer occupies layout space.";
            */
        }
        
    }
}