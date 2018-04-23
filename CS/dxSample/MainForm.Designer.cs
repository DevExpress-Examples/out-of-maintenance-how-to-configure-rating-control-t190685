namespace dxSample {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ratingControl1 = new DevExpress.XtraEditors.RatingControl();
            this.spinEditItemCount = new DevExpress.XtraEditors.SpinEdit();
            this.comboBoxOrientation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditItemCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxOrientation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.checkEdit1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.ratingControl1);
            this.layoutControl1.Controls.Add(this.spinEditItemCount);
            this.layoutControl1.Controls.Add(this.comboBoxOrientation);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 22);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(767, 396);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 142);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(743, 242);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ratingControl1
            // 
            this.ratingControl1.Location = new System.Drawing.Point(24, 110);
            this.ratingControl1.Name = "ratingControl1";
            this.ratingControl1.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.ratingControl1.Rating = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ratingControl1.Size = new System.Drawing.Size(87, 16);
            this.ratingControl1.StyleController = this.layoutControl1;
            this.ratingControl1.TabIndex = 4;
            this.ratingControl1.Text = "ratingControl1";
            // 
            // spinEditItemCount
            // 
            this.spinEditItemCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditItemCount.Location = new System.Drawing.Point(179, 43);
            this.spinEditItemCount.Name = "spinEditItemCount";
            this.spinEditItemCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditItemCount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.spinEditItemCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spinEditItemCount.Size = new System.Drawing.Size(251, 20);
            this.spinEditItemCount.StyleController = this.layoutControl1;
            this.spinEditItemCount.TabIndex = 1;
            this.spinEditItemCount.EditValueChanged += new System.EventHandler(this.spinEdit_EditValueChanged);
            this.spinEditItemCount.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.spinEditItemCount_EditValueChanging);
            // 
            // comboBoxOrientation
            // 
            this.comboBoxOrientation.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.comboBoxOrientation.Location = new System.Drawing.Point(491, 43);
            this.comboBoxOrientation.Name = "comboBoxOrientation";
            this.comboBoxOrientation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxOrientation.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.comboBoxOrientation.Size = new System.Drawing.Size(252, 20);
            this.comboBoxOrientation.StyleController = this.layoutControl1;
            this.comboBoxOrientation.TabIndex = 6;
            this.comboBoxOrientation.EditValueChanged += new System.EventHandler(this.comboBoxOrientation_EditValueChanged);
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlGroup1,
            this.layoutControlGroup2});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(767, 396);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 130);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(747, 246);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Rating Control settings";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(747, 67);
            this.layoutControlGroup1.Text = "Rating Control settings";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spinEditItemCount;
            this.layoutControlItem3.CustomizationFormText = "Rating";
            this.layoutControlItem3.Location = new System.Drawing.Point(98, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(312, 24);
            this.layoutControlItem3.Text = "Item Count";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.comboBoxOrientation;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(410, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(313, 24);
            this.layoutControlItem4.Text = "Orientation";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Sample";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 67);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(747, 63);
            this.layoutControlGroup2.Text = "Sample";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ratingControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(723, 20);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Skins";
            this.skinBarSubItem1.Id = 0;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(767, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 418);
            this.barDockControlBottom.Size = new System.Drawing.Size(767, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 396);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(767, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 396);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(24, 43);
            this.checkEdit1.MenuManager = this.barManager1;
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Custom images";
            this.checkEdit1.Size = new System.Drawing.Size(94, 19);
            this.checkEdit1.StyleController = this.layoutControl1;
            this.checkEdit1.TabIndex = 7;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.checkEdit1;
            this.layoutControlItem5.CustomizationFormText = "Custom images";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(98, 24);
            this.layoutControlItem5.Text = "Custom images";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 418);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditItemCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxOrientation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.RatingControl ratingControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SpinEdit spinEditItemCount;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxOrientation;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;

    }
}