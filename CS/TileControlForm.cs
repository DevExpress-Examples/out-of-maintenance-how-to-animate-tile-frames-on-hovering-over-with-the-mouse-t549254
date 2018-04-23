using DevExpress.XtraEditors;
using System;
using System.Linq;

namespace dxExample
{
    public partial class TileControlForm : XtraForm
    {
        public TileControlForm() {
            InitializeComponent();
            new FrameHoverHelper(tileControl1);
        }
    }
}
