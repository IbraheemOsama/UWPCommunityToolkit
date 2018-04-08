﻿namespace Microsoft.Toolkit.Uwp.UI.Controls
{
    internal class InfiniteCanvasUpdateTextCommand : IInfiniteCanvasCommand
    {
        private readonly string _oldText;
        private readonly string _newText;
        private readonly TextDrawable _drawable;

        public InfiniteCanvasUpdateTextCommand(TextDrawable drawable, string oldText, string newText)
        {
            _oldText = oldText;
            _newText = newText;
            _drawable = drawable;
        }

        public void Execute()
        {
            _drawable.Text = _newText;
        }

        public void UnExecute()
        {
            _drawable.Text = _oldText;
        }
    }
}