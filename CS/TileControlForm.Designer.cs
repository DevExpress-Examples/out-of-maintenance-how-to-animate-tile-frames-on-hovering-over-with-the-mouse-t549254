namespace dxExample
{
    partial class TileControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraEditors.TileItemFrame tileItemFrame1 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame2 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame3 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame4 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.MaxId = 3;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(847, 551);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Items.Add(this.tileItem2);
            this.tileGroup2.Items.Add(this.tileItem3);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItem1
            // 
            tileItemFrame1.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollDown;
            tileItemFrame1.Appearance.BackColor = System.Drawing.Color.Maroon;
            tileItemFrame1.Appearance.BackColor2 = System.Drawing.Color.Red;
            tileItemFrame1.Appearance.BorderColor = System.Drawing.Color.Red;
            tileItemFrame1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tileItemFrame1.Appearance.Options.UseBackColor = true;
            tileItemFrame1.Appearance.Options.UseBorderColor = true;
            tileItemFrame2.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollTop;
            tileItemFrame2.Appearance.BackColor = System.Drawing.Color.Red;
            tileItemFrame2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            tileItemFrame2.Appearance.BorderColor = System.Drawing.Color.Red;
            tileItemFrame2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tileItemFrame2.Appearance.Options.UseBackColor = true;
            tileItemFrame2.Appearance.Options.UseBorderColor = true;
            this.tileItem1.Frames.Add(tileItemFrame1);
            this.tileItem1.Frames.Add(tileItemFrame2);
            this.tileItem1.Id = 0;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem1.Name = "tileItem1";
            // 
            // tileItem2
            // 
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Text = "Customers";
            this.tileItem2.Elements.Add(tileItemElement1);
            tileItemFrame3.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollDown;
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.Text = "Customers";
            tileItemFrame3.Elements.Add(tileItemElement2);
            tileItemFrame4.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollTop;
            tileItemElement3.Text = "Bart Anraz";
            tileItemElement4.Text = "Billy Zimmer";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement4.TextLocation = new System.Drawing.Point(0, 20);
            tileItemElement5.Text = "Terry Bradley";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement5.TextLocation = new System.Drawing.Point(0, 40);
            tileItemElement6.Text = "Greta Sims";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement6.TextLocation = new System.Drawing.Point(0, 60);
            tileItemElement7.Text = "Brett Wade";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement7.TextLocation = new System.Drawing.Point(0, 80);
            tileItemFrame4.Elements.Add(tileItemElement3);
            tileItemFrame4.Elements.Add(tileItemElement4);
            tileItemFrame4.Elements.Add(tileItemElement5);
            tileItemFrame4.Elements.Add(tileItemElement6);
            tileItemFrame4.Elements.Add(tileItemElement7);
            this.tileItem2.Frames.Add(tileItemFrame3);
            this.tileItem2.Frames.Add(tileItemFrame4);
            this.tileItem2.Id = 1;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem2.Name = "tileItem2";
            // 
            // tileItem3
            // 
            tileItemElement8.Text = "Tile without frames";
            this.tileItem3.Elements.Add(tileItemElement8);
            this.tileItem3.Id = 2;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem3.Name = "tileItem3";
            // 
            // TileControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 551);
            this.Controls.Add(this.tileControl1);
            this.Name = "TileControlForm";
            this.Text = "TileControlForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem3;
    }
}