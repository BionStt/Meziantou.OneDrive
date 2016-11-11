using System;

namespace Meziantou.OneDrive
{
    public class CancelEventArgs : EventArgs
    {
        public CancelEventArgs() : this(false)
        {
        }

        public CancelEventArgs(bool cancel)
        {
            this.Cancel = cancel;
        }

        public bool Cancel { get; set; }
    }
}