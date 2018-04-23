using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;

namespace dxExample
{
    public class FrameHoverHelper
    {
        ITileControl tileControl;
        public FrameHoverHelper(ITileControl tileHolder) {
            tileControl = tileHolder;
            foreach (TileGroup group in tileControl.Groups)
                foreach (TileItem item in group.Items)
                    item.AllowAnimation = false;
            tileControl.Control.MouseMove += control_MouseMove;
        }

        private void control_MouseMove(object sender, MouseEventArgs e) {
            TileControlHitInfo tileHi = tileControl.CalcHitInfo(e.Location);
            if (tileHi.InItem)
                HoveredItem = tileHi.ItemInfo.Item;
            else
                HoveredItem = null;
        }

        TileItem _HoveredItem;
        TileItem HoveredItem {
            get {
                return _HoveredItem;
            }
            set {
                if (_HoveredItem != value) {
                    if (value != null && IsTileValidForAnimation(value))
                        value.SetContent(value.Frames[1], true);
                    if (_HoveredItem != null && IsTileValidForAnimation(_HoveredItem))
                        _HoveredItem.SetContent(_HoveredItem.Frames[0], true);
                    _HoveredItem = value;
                }
            }
        }
        bool IsTileValidForAnimation(TileItem tile) {
            return tile.Frames.Count >= 2;
        }
    }
}
