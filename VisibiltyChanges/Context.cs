using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace VisibiltyChanges
{

    public interface IGorunurluk
    {
        public void VisibleOzellik(TextBlock textBlock, TextBox textBox);
    }
    public class Context
    {
        TextBox _textBox;
        TextBlock _textBlock;
        IGorunurluk _gorunurluk;

        public Context(TextBlock textBlock,TextBox textBox) 
        {
            _textBlock = textBlock;
            _textBox = textBox;
        }

        public void setgorunuluk(IGorunurluk gorunurluk)
        {
            _gorunurluk = gorunurluk;
        }

        public void gorunurlukdegistir()
        {
            _gorunurluk.VisibleOzellik(_textBlock, _textBox);
        }
       

    }

    public class Visible : IGorunurluk
    {
        public void VisibleOzellik(TextBlock textBlock, TextBox textBox)
        {
            textBox.Visibility = Visibility.Visible;
            textBlock.Text = "Visibility is now set to Visible.";
        }

    }
    public class Hidden : IGorunurluk
    {
        public void VisibleOzellik(TextBlock textBlock, TextBox textBox)
        {
            textBox.Visibility = Visibility.Hidden;
            textBlock.Text = "Visibility is now set to Hidden. Notice that the TextBox still occupies layout space.";
        }

    }
    public class Collapse : IGorunurluk
    {
        public void VisibleOzellik(TextBlock textBlock, TextBox textBox)
        {
            textBox.Visibility = Visibility.Collapsed;
            textBlock.Text = "Visibility is now set to Collapsed. Notice that the TextBox no longer occupies layout space.";
        }

    }


}
