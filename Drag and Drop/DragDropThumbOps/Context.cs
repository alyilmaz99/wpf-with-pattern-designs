/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows;

namespace DragDropThumbOps
{
    public interface IColorChange
    {
        public void ColorChanges(Thumb thumb);
    }

    class Context
    {
        Thumb _thumb;
        IColorChange _colorchange;

        public Context(Thumb thumb)
        {
            _thumb = thumb;

        }
        public void setColorChanges(IColorChange colorChange)
        {
            _colorchange = colorChange;
        }
        public void DragColorChanges()
        {
            _colorchange.ColorChanges(_thumb);
        }
    }

    public class Orange : IColorChange
    {
        public void ColorChanges(Thumb thumb)
        {
            thumb.Background = Brushes.Orange;
        }
    }
    public class Blue : IColorChange
    {
        public void ColorChanges(Thumb thumb)
        {
            thumb.Background = Brushes.Blue;
        }
    }
}
*/