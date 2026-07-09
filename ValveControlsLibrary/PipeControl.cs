using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ValveControlsLibrary;

namespace ScadaControlsLibrary
{
    public partial class PipeControl : UserControl
    {
        private bool _isOpen = false;

        public PipeControl()
        {
            InitializeComponent();
            RefreshPipe();
        }

        public bool IsOpen
        {
            get { return _isOpen; }
            set
            {
                _isOpen = value;
                RefreshPipe();
            }
        }

        private void RefreshPipe()
        {
            if (_isOpen)
            {
                picturePipe.Image = Resources.Pipe_Open;
            }
            else
            {
                picturePipe.Image = Resources.Pipe_Close;
            }
        }
    }
}