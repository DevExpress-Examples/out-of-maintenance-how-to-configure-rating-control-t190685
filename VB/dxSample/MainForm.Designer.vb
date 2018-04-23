Namespace dxSample
    Partial Public Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.ratingControl1 = New DevExpress.XtraEditors.RatingControl()
            Me.spinEditItemCount = New DevExpress.XtraEditors.SpinEdit()
            Me.comboBoxOrientation = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.skinBarSubItem1 = New DevExpress.XtraBars.SkinBarSubItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ratingControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.spinEditItemCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.comboBoxOrientation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.checkEdit1)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Controls.Add(Me.ratingControl1)
            Me.layoutControl1.Controls.Add(Me.spinEditItemCount)
            Me.layoutControl1.Controls.Add(Me.comboBoxOrientation)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 22)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = New System.Drawing.Font("Tahoma", 10.25F)
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(767, 396)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Location = New System.Drawing.Point(12, 142)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(743, 242)
            Me.gridControl1.TabIndex = 5
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' ratingControl1
            ' 
            Me.ratingControl1.Location = New System.Drawing.Point(24, 110)
            Me.ratingControl1.Name = "ratingControl1"
            Me.ratingControl1.Properties.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
            Me.ratingControl1.Rating = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.ratingControl1.Size = New System.Drawing.Size(87, 16)
            Me.ratingControl1.StyleController = Me.layoutControl1
            Me.ratingControl1.TabIndex = 4
            Me.ratingControl1.Text = "ratingControl1"
            ' 
            ' spinEditItemCount
            ' 
            Me.spinEditItemCount.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.spinEditItemCount.Location = New System.Drawing.Point(179, 43)
            Me.spinEditItemCount.Name = "spinEditItemCount"
            Me.spinEditItemCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditItemCount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.spinEditItemCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinEditItemCount.Size = New System.Drawing.Size(251, 20)
            Me.spinEditItemCount.StyleController = Me.layoutControl1
            Me.spinEditItemCount.TabIndex = 1
            ' 
            ' comboBoxOrientation
            ' 
            Me.comboBoxOrientation.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.comboBoxOrientation.Location = New System.Drawing.Point(491, 43)
            Me.comboBoxOrientation.Name = "comboBoxOrientation"
            Me.comboBoxOrientation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxOrientation.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
            Me.comboBoxOrientation.Size = New System.Drawing.Size(252, 20)
            Me.comboBoxOrientation.StyleController = Me.layoutControl1
            Me.comboBoxOrientation.TabIndex = 6
            ' 
            ' Root
            ' 
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlGroup1, Me.layoutControlGroup2})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(767, 396)
            Me.Root.Text = "Root"
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.gridControl1
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 130)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(747, 246)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "Rating Control settings"
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(747, 67)
            Me.layoutControlGroup1.Text = "Rating Control settings"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.spinEditItemCount
            Me.layoutControlItem3.CustomizationFormText = "Rating"
            Me.layoutControlItem3.Location = New System.Drawing.Point(98, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(312, 24)
            Me.layoutControlItem3.Text = "Item Count"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(54, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.comboBoxOrientation
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(410, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(313, 24)
            Me.layoutControlItem4.Text = "Orientation"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(54, 13)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.CustomizationFormText = "Sample"
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 67)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(747, 63)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ratingControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(723, 20)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar2})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.skinBarSubItem1})
            Me.barManager1.MainMenu = Me.bar2
            Me.barManager1.MaxItemId = 1
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.skinBarSubItem1)})
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "Main menu"
            ' 
            ' skinBarSubItem1
            ' 
            Me.skinBarSubItem1.Caption = "Skins"
            Me.skinBarSubItem1.Id = 0
            Me.skinBarSubItem1.Name = "skinBarSubItem1"
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(767, 22)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 418)
            Me.barDockControlBottom.Size = New System.Drawing.Size(767, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 396)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(767, 22)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 396)
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.Location = New System.Drawing.Point(24, 43)
            Me.checkEdit1.MenuManager = Me.barManager1
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Custom images"
            Me.checkEdit1.Size = New System.Drawing.Size(94, 19)
            Me.checkEdit1.StyleController = Me.layoutControl1
            Me.checkEdit1.TabIndex = 7
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.checkEdit1
            Me.layoutControlItem5.CustomizationFormText = "Custom images"
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(98, 24)
            Me.layoutControlItem5.Text = "Custom images"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(767, 418)
            Me.Controls.Add(Me.layoutControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "MainForm"
            Me.Text = "MainForm"
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ratingControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.spinEditItemCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.comboBoxOrientation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private Root As DevExpress.XtraLayout.LayoutControlGroup
        Private ratingControl1 As DevExpress.XtraEditors.RatingControl
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents spinEditItemCount As DevExpress.XtraEditors.SpinEdit
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents comboBoxOrientation As DevExpress.XtraEditors.ComboBoxEdit
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private bar2 As DevExpress.XtraBars.Bar
        Private skinBarSubItem1 As DevExpress.XtraBars.SkinBarSubItem
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

    End Class
End Namespace