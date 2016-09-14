﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.Toolkit.Uwp.UI.Controls
{
    /// <summary>
    /// Represents the control that redistributes space between columns or rows of a Grid control.
    /// </summary>
    public partial class GridSplitter
    {
        /// <summary>
        /// Identifies the <see cref="Element"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ElementProperty
            = DependencyProperty.Register(
                nameof(Element),
                typeof(UIElement),
                typeof(GridSplitter),
                new PropertyMetadata(default(UIElement)));

        /// <summary>
        /// Identifies the <see cref="ResizeDirection"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ResizeDirectionProperty
            = DependencyProperty.Register(
                nameof(ResizeDirection),
                typeof(GridResizeDirection),
                typeof(GridSplitter),
                new PropertyMetadata(GridResizeDirection.Auto));

        /// <summary>
        /// Identifies the <see cref="ResizeBehavior"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ResizeBehaviorProperty
            = DependencyProperty.Register(
                nameof(ResizeBehavior),
                typeof(GridResizeBehavior),
                typeof(GridSplitter),
                new PropertyMetadata(GridResizeBehavior.BasedOnAlignment));

        /// <summary>
        /// Identifies the <see cref="GripForeground"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty GripperForegroundProperty
            = DependencyProperty.Register(
                nameof(GripperForeground),
                typeof(Brush),
                typeof(GridSplitter),
                new PropertyMetadata(default(Brush), OnGripperForegroundPropertyChanged));

        /// <summary>
        /// Identifies the <see cref="ParentLevel"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ParentLevelProperty
            = DependencyProperty.Register(
                nameof(ParentLevel),
                typeof(int),
                typeof(GridSplitter),
                new PropertyMetadata(default(int)));

        /// <summary>
        /// Gets or sets the visual content of this Grid Splitter
        /// </summary>
        public UIElement Element
        {
            get { return (UIElement)GetValue(ElementProperty); }
            set { SetValue(ElementProperty, value); }
        }

        /// <summary>
        /// Gets or sets whether the Splitter resizes the Columns, Rows, or Both.
        /// </summary>
        public GridResizeDirection ResizeDirection
        {
            get { return (GridResizeDirection)GetValue(ResizeDirectionProperty); }

            set { SetValue(ResizeDirectionProperty, value); }
        }

        /// <summary>
        /// Gets or sets which Columns or Rows the Splitter resizes.
        /// </summary>
        public GridResizeBehavior ResizeBehavior
        {
            get { return (GridResizeBehavior)GetValue(ResizeBehaviorProperty); }

            set { SetValue(ResizeBehaviorProperty, value); }
        }

        /// <summary>
        /// Gets or sets the foreground color of grid splitter grip
        /// </summary>
        public Brush GripperForeground
        {
            get { return (Brush)GetValue(GripperForegroundProperty); }

            set { SetValue(GripperForegroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the level of the parent grid to resize
        /// </summary>
        public int ParentLevel
        {
            get { return (int)GetValue(ParentLevelProperty); }

            set { SetValue(ParentLevelProperty, value); }
        }

        private static void OnGripperForegroundPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var gridSplitter = (GridSplitter)d;
            var grip = gridSplitter.Element as GridSplitterGripper;
            if (grip != null)
            {
                grip.GripperForeground = gridSplitter.GripperForeground;
            }
        }
    }
}