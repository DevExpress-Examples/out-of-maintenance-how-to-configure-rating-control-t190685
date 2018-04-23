Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository

Namespace dxSample
    Partial Public Class MainForm
        Inherits DevExpress.XtraEditors.XtraForm

        Private ReadOnly Property RatingCtrl() As RatingControl
            Get
                Return ratingControl1
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
            InitRatingControl()
            InitGrid()
            InitSettingsEditors()
        End Sub
        Private Sub InitSettingsEditors()
            InitItemCountEditor()
            InitRatingOrinentationEditor()
        End Sub
        Private Sub InitRatingOrinentationEditor()
            comboBoxOrientation.Properties.Items.AddRange(System.Enum.GetValues(GetType(Orientation)))
            comboBoxOrientation.EditValue = RatingCtrl.Properties.RatingOrientation
        End Sub
        Private Sub InitItemCountEditor()
            spinEditItemCount.EditValue = RatingCtrl.Properties.ItemCount
        End Sub
        Private Sub InitRatingControl()
            RatingCtrl.Properties.FillPrecision = RatingItemFillPrecision.Full
            RatingCtrl.Properties.ItemCount = 10
            RatingCtrl.Rating = 5.8D
        End Sub
        Private Sub InitGrid()
            InitDataSource()
            InitColumns()
        End Sub
        Private Sub InitDataSource()
            gridControl1.DataSource = DataHelper.GetData()
            gridView1.OptionsView.RowAutoHeight = False
            gridView1.RowHeight = 30
        End Sub
        Private Sub InitColumns()
            gridView1.Columns.Clear()
            InitAdressColumn()
            InitYearBuilt()
            InitCostColumn()
            InitMarkCol()
        End Sub

        Private Sub InitYearBuilt()
            gridView1.Columns.AddVisible("Year built")
        End Sub
        Private Sub InitAdressColumn()
            Dim markCol As DevExpress.XtraGrid.Columns.GridColumn = gridView1.Columns.AddVisible("Adress")
            Dim riMemoEdit As RepositoryItemMemoEdit = TryCast(gridControl1.RepositoryItems.Add("MemoEdit"), RepositoryItemMemoEdit)
            markCol.ColumnEdit = riMemoEdit
        End Sub
        Private Sub InitMarkCol()
            Dim markCol As DevExpress.XtraGrid.Columns.GridColumn = gridView1.Columns.AddVisible("Mark")
            Dim riRatingCtrl As RepositoryItemRatingControl = TryCast(gridControl1.RepositoryItems.Add("RatingControl"), RepositoryItemRatingControl)
            riRatingCtrl.Name = "riRatingControl"
            AssignSettings()
            markCol.ColumnEdit = riRatingCtrl
        End Sub

        Private Sub InitCostColumn()
            Dim costCol As DevExpress.XtraGrid.Columns.GridColumn = gridView1.Columns.AddVisible("Cost")
            Dim riTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit = TryCast(gridControl1.RepositoryItems.Add("TextEdit"), RepositoryItemTextEdit)
            riTextEdit.Name = "riTextEdit"
            costCol.ColumnEdit = riTextEdit
            gridControl1.RepositoryItems.Add(riTextEdit)
            riTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            riTextEdit.Mask.EditMask = "c"
            riTextEdit.Mask.UseMaskAsDisplayFormat = True
            AddHandler riTextEdit.CustomDisplayText, AddressOf riTextEdit_CustomDisplayText
        End Sub

        Private Sub riTextEdit_CustomDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs)
            Dim val As Integer = Nothing
            Int32.TryParse(e.Value.ToString(), val)
            If val < 0 Then
                e.DisplayText = "Sold"
            End If
        End Sub
        Private Sub spinEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinEditItemCount.EditValueChanged
            Dim editor As BaseEdit = TryCast(sender, BaseEdit)
            RatingCtrl.Properties.ItemCount = Convert.ToInt32(editor.EditValue)
            AssignSettings()
        End Sub
        Private Sub comboBoxOrientation_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxOrientation.EditValueChanged
            RatingCtrl.Properties.RatingOrientation = CType(comboBoxOrientation.EditValue, Orientation)
            AssignSettings()
        End Sub
        Private Sub AssignSettings()
            Dim name As String = "riRatingControl"
            Dim item As RepositoryItem = gridControl1.RepositoryItems(name)
            If item IsNot Nothing Then
                item.Assign(RatingCtrl.Properties)
                item.Name = name
            End If
        End Sub

        Private Sub spinEditItemCount_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles spinEditItemCount.EditValueChanging
            e.Cancel = (Convert.ToInt32(e.NewValue) > 10) OrElse Convert.ToInt32(e.NewValue) < 3
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
            Dim checkEditor As CheckEdit = TryCast(sender, CheckEdit)
            If checkEditor.Checked Then
                SetCustomImages()
            Else
                ResetGlyph()
            End If
            AssignSettings()
        End Sub
        Private Sub SetCustomImages()
            RatingCtrl.Properties.Glyph = GetGlyph()
            RatingCtrl.Properties.HoverGlyph = GetHoverGlyph()
            RatingCtrl.Properties.CheckedGlyph = GetCheckedGlyph()
        End Sub
        Private Sub ResetGlyph()
            RatingCtrl.Properties.CheckedGlyph = Nothing
            RatingCtrl.Properties.HoverGlyph = RatingCtrl.Properties.CheckedGlyph
            RatingCtrl.Properties.Glyph = RatingCtrl.Properties.HoverGlyph
        End Sub
        Private Function GetGlyph() As System.Drawing.Image
            Return My.Resources.Glyph
        End Function
        Private Function GetCheckedGlyph() As System.Drawing.Image
            Return My.Resources.CheckedGlyph
        End Function
        Private Function GetHoverGlyph() As System.Drawing.Image
            Return My.Resources.HoverGlyph
        End Function
    End Class
End Namespace
