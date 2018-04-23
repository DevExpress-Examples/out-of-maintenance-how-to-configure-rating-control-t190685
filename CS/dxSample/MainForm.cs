using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace dxSample {
    public partial class MainForm : DevExpress.XtraEditors.XtraForm {
        private RatingControl RatingCtrl {
            get {
                return ratingControl1;
            }
        }
        public MainForm() {
            InitializeComponent();
            InitRatingControl();
            InitGrid();
            InitSettingsEditors();
        }
        private void InitSettingsEditors() {
            InitItemCountEditor();
            InitRatingOrinentationEditor();
        }
        private void InitRatingOrinentationEditor() {
            comboBoxOrientation.Properties.Items.AddRange(Enum.GetValues(typeof(Orientation)));
            comboBoxOrientation.EditValue = RatingCtrl.Properties.RatingOrientation;
        }
        private void InitItemCountEditor() {
            spinEditItemCount.EditValue = RatingCtrl.Properties.ItemCount;
        }
        private void InitRatingControl() {
            RatingCtrl.Properties.FillPrecision = DevExpress.XtraEditors.Repository.RatingItemFillPrecision.Full;
            RatingCtrl.Properties.ItemCount = 10;
            RatingCtrl.Rating = 5.8M;
        }
        private void InitGrid() {
            InitDataSource();
            InitColumns();
        }
        private void InitDataSource() {
            gridControl1.DataSource = DataHelper.GetData();
            gridView1.OptionsView.RowAutoHeight = false;
            gridView1.RowHeight = 30;
        }
        private void InitColumns() {
            gridView1.Columns.Clear();
            InitAdressColumn();
            InitYearBuilt();
            InitCostColumn();
            InitMarkCol();
        }

        private void InitYearBuilt() {
            gridView1.Columns.AddVisible("Year built");
        }
        private void InitAdressColumn() {
            DevExpress.XtraGrid.Columns.GridColumn markCol = gridView1.Columns.AddVisible("Adress");
            RepositoryItemMemoEdit riMemoEdit = gridControl1.RepositoryItems.Add("MemoEdit") as RepositoryItemMemoEdit;
            markCol.ColumnEdit = riMemoEdit;
        }
        private void InitMarkCol() {
            DevExpress.XtraGrid.Columns.GridColumn markCol = gridView1.Columns.AddVisible("Mark");
            RepositoryItemRatingControl riRatingCtrl = gridControl1.RepositoryItems.Add("RatingControl") as RepositoryItemRatingControl;
            riRatingCtrl.Name = "riRatingControl";
            AssignSettings();
            markCol.ColumnEdit = riRatingCtrl;
        }

        private void InitCostColumn() {
            DevExpress.XtraGrid.Columns.GridColumn costCol = gridView1.Columns.AddVisible("Cost");
            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riTextEdit = gridControl1.RepositoryItems.Add("TextEdit") as RepositoryItemTextEdit;
            riTextEdit.Name = "riTextEdit";
            costCol.ColumnEdit = riTextEdit;
            gridControl1.RepositoryItems.Add(riTextEdit);
            riTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            riTextEdit.Mask.EditMask = "c";
            riTextEdit.Mask.UseMaskAsDisplayFormat = true;
            riTextEdit.CustomDisplayText += riTextEdit_CustomDisplayText;
        }

        private void riTextEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e) {
            int val;
            Int32.TryParse(e.Value.ToString(), out val);
            if (val < 0) {
                e.DisplayText = "Sold";
            }
        }
        private void spinEdit_EditValueChanged(object sender, EventArgs e) {
            BaseEdit editor = sender as BaseEdit;
            RatingCtrl.Properties.ItemCount = Convert.ToInt32(editor.EditValue);
            AssignSettings();
        }
        private void comboBoxOrientation_EditValueChanged(object sender, EventArgs e) {
            RatingCtrl.Properties.RatingOrientation = (Orientation)comboBoxOrientation.EditValue;
            AssignSettings();
        }
        private void AssignSettings() {
            string name = "riRatingControl";
            RepositoryItem item = gridControl1.RepositoryItems[name];
            if (item != null) {
                item.Assign(RatingCtrl.Properties);
                item.Name = name;
            }
        }

        private void spinEditItemCount_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e) {
            e.Cancel = (Convert.ToInt32(e.NewValue) > 10) || Convert.ToInt32(e.NewValue) < 3;
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            CheckEdit checkEditor = sender as CheckEdit;
            if (checkEditor.Checked) {
                SetCustomImages();
            }            else {
                ResetGlyph();
            }
            AssignSettings();
        }
        private void SetCustomImages() {
            RatingCtrl.Properties.Glyph = GetGlyph();
            RatingCtrl.Properties.HoverGlyph = GetHoverGlyph();
            RatingCtrl.Properties.CheckedGlyph = GetCheckedGlyph();
        }
        private void ResetGlyph() {
            RatingCtrl.Properties.Glyph = RatingCtrl.Properties.HoverGlyph = RatingCtrl.Properties.CheckedGlyph = null;
        }
        private System.Drawing.Image GetGlyph() {
            return dxSample.Properties.Resources.Glyph;
        }
        private System.Drawing.Image GetCheckedGlyph() {
            return dxSample.Properties.Resources.CheckedGlyph;
        }
        private System.Drawing.Image GetHoverGlyph() {
            return dxSample.Properties.Resources.HoverGlyph;
        }
    }
}
