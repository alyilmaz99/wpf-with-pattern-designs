// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Globalization;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace DragDropThumbOps
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>

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
    public partial class Pane : Canvas
    {
        Context context;
        
        private void OnDragDelta(object sender, DragDeltaEventArgs e)
        {

            //Move the Thumb to the mouse position during the drag operation
            var yadjust = myCanvasStretch.Height + e.VerticalChange;
            var xadjust = myCanvasStretch.Width + e.HorizontalChange;
            if ((xadjust >= 0) && (yadjust >= 0))
            {
                myCanvasStretch.Width = xadjust;
                myCanvasStretch.Height = yadjust;
                SetLeft(myThumb, GetLeft(myThumb) +
                                 e.HorizontalChange);
                SetTop(myThumb, GetTop(myThumb) +
                                e.VerticalChange);
                changes.Text = "Size: " +
                               myCanvasStretch.Width.ToString(CultureInfo.InvariantCulture) +
                               ", " +
                               myCanvasStretch.Height.ToString(CultureInfo.InvariantCulture);
            }
        }
        
        private void OnDragStarted(object sender, DragStartedEventArgs e)
        {
            context = new Context(myThumb);
            context.setColorChanges(new Orange());
            context.DragColorChanges();
           /* myThumb.Background = Brushes.Orange;*/
        }

        private void OnDragCompleted(object sender, DragCompletedEventArgs e)
        {
            /*myThumb.Background = Brushes.Blue;*/
            context = new Context(myThumb);
            context.setColorChanges(new Blue());
            context.DragColorChanges();
        }
    }
}