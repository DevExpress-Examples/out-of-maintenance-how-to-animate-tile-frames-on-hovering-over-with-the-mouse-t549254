using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;

namespace dxExample
{
    public partial class WindowsUIForm : XtraForm {
        public WindowsUIForm() {
            InitializeComponent(); 
        }
        private void Form1_Shown(object sender, EventArgs e) {
            new FrameHoverHelper(tileContainer1.Info as ITileControl);
        }
        private void WindowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e) {
            e.Control = new Control();
        }
        private void tileContainer1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e) {
            TileControlForm tcForm = new TileControlForm();
            tcForm.Show();
        }
    }
}
