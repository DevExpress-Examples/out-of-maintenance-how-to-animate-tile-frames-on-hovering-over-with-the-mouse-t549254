namespace dxExample
{
    partial class WindowsUIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame5 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame6 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame1 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame2 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.tileContainer1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.document2Tile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.document2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.document1Tile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2Tile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1Tile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.windowsUIView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView1});
            // 
            // windowsUIView1
            // 
            this.windowsUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.tileContainer1});
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.document1,
            this.document2});
            this.windowsUIView1.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.document1Tile,
            this.document2Tile});
            // 
            // tileContainer1
            // 
            this.tileContainer1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Show TileControl Form", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton)});
            this.tileContainer1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.document2Tile,
            this.document1Tile});
            this.tileContainer1.Name = "tileContainer1";
            this.tileContainer1.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.tileContainer1_ButtonClick);
            // 
            // document2Tile
            // 
            this.document2Tile.Document = this.document2;
            tileItemFrame5.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollDown;
            tileItemFrame5.BackgroundImage = global::dxExample.Properties.Resources.top;
            tileItemElement8.AnimateTransition = DevExpress.Utils.DefaultBoolean.False;
            tileItemElement8.Appearance.Normal.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement8.Appearance.Normal.Options.UseFont = true;
            tileItemElement8.Text = "This is like icebergs...";
            tileItemElement9.Appearance.Normal.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement9.Appearance.Normal.Options.UseFont = true;
            tileItemElement9.Text = "Outcome";
            tileItemFrame5.Elements.Add(tileItemElement8);
            tileItemFrame5.Elements.Add(tileItemElement9);
            tileItemFrame6.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollTop;
            tileItemFrame6.BackgroundImage = global::dxExample.Properties.Resources.bottom;
            tileItemElement10.AnimateTransition = DevExpress.Utils.DefaultBoolean.False;
            tileItemElement10.Appearance.Normal.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement10.Appearance.Normal.Options.UseFont = true;
            tileItemElement10.Text = "This is like icebergs...";
            tileItemElement11.Appearance.Normal.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement11.Appearance.Normal.Options.UseFont = true;
            tileItemElement11.Text = "Effort";
            tileItemFrame6.Elements.Add(tileItemElement10);
            tileItemFrame6.Elements.Add(tileItemElement11);
            this.document2Tile.Frames.Add(tileItemFrame5);
            this.document2Tile.Frames.Add(tileItemFrame6);
            this.tileContainer1.SetID(this.document2Tile, 1);
            this.document2Tile.Name = "document2Tile";
            // 
            // document2
            // 
            this.document2.Caption = "document2";
            this.document2.ControlName = "document2";
            // 
            // document1Tile
            // 
            this.document1Tile.Document = this.document1;
            tileItemFrame1.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollDown;
            tileItemElement1.Text = "Short Description";
            tileItemFrame1.Elements.Add(tileItemElement1);
            tileItemFrame2.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollTop;
            tileItemElement2.Text = "Long description";
            tileItemElement3.Text = "This is a long description to better understand what it is.";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemFrame2.Elements.Add(tileItemElement2);
            tileItemFrame2.Elements.Add(tileItemElement3);
            this.document1Tile.Frames.Add(tileItemFrame1);
            this.document1Tile.Frames.Add(tileItemFrame2);
            this.tileContainer1.SetID(this.document1Tile, 1);
            this.document1Tile.Name = "document1Tile";
            // 
            // document1
            // 
            this.document1.Caption = "document1";
            this.document1.ControlName = "document1";
            // 
            // WindowsUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 551);
            this.Name = "WindowsUIForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2Tile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1Tile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile document1Tile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document document1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document document2;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile document2Tile;
    }
}

