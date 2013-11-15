<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDelAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSortAsc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortAscName = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortAscGender = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortAscICNo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuMoveUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoveDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortDsc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortDscName = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortDscGender = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortDscICNo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListView1 = New StudentList.ListView2()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(0, 0)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(684, 25)
        Me.txtSearch.TabIndex = 1
        '
        'mnuAdd
        '
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuAdd.Size = New System.Drawing.Size(242, 22)
        Me.mnuAdd.Text = "Add"
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuEdit.Size = New System.Drawing.Size(242, 22)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuDel
        '
        Me.mnuDel.Name = "mnuDel"
        Me.mnuDel.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.mnuDel.Size = New System.Drawing.Size(242, 22)
        Me.mnuDel.Text = "Delete"
        '
        'mnuSeparator
        '
        Me.mnuSeparator.Name = "mnuSeparator"
        Me.mnuSeparator.Size = New System.Drawing.Size(239, 6)
        '
        'mnuDelAll
        '
        Me.mnuDelAll.Name = "mnuDelAll"
        Me.mnuDelAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.mnuDelAll.Size = New System.Drawing.Size(242, 22)
        Me.mnuDelAll.Text = "Delete All"
        '
        'mnuSeparator2
        '
        Me.mnuSeparator2.Name = "mnuSeparator2"
        Me.mnuSeparator2.Size = New System.Drawing.Size(239, 6)
        '
        'mnuSortAsc
        '
        Me.mnuSortAsc.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSortAscName, Me.mnuSortAscGender, Me.mnuSortAscICNo})
        Me.mnuSortAsc.Name = "mnuSortAsc"
        Me.mnuSortAsc.ShortcutKeyDisplayString = "                    "
        Me.mnuSortAsc.Size = New System.Drawing.Size(242, 22)
        Me.mnuSortAsc.Text = "Sort ascending by"
        '
        'mnuSortAscName
        '
        Me.mnuSortAscName.Name = "mnuSortAscName"
        Me.mnuSortAscName.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.mnuSortAscName.Size = New System.Drawing.Size(152, 22)
        Me.mnuSortAscName.Text = "Name"
        '
        'mnuSortAscGender
        '
        Me.mnuSortAscGender.Name = "mnuSortAscGender"
        Me.mnuSortAscGender.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.mnuSortAscGender.Size = New System.Drawing.Size(152, 22)
        Me.mnuSortAscGender.Text = "Gender"
        '
        'mnuSortAscICNo
        '
        Me.mnuSortAscICNo.Name = "mnuSortAscICNo"
        Me.mnuSortAscICNo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.mnuSortAscICNo.Size = New System.Drawing.Size(152, 22)
        Me.mnuSortAscICNo.Text = "I/C No"
        '
        'mnuRefresh
        '
        Me.mnuRefresh.Name = "mnuRefresh"
        Me.mnuRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnuRefresh.Size = New System.Drawing.Size(242, 22)
        Me.mnuRefresh.Text = "Refresh"
        '
        'mnuSeparator3
        '
        Me.mnuSeparator3.Name = "mnuSeparator3"
        Me.mnuSeparator3.Size = New System.Drawing.Size(239, 6)
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpen.Size = New System.Drawing.Size(242, 22)
        Me.mnuOpen.Text = "Open..."
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(242, 22)
        Me.mnuSave.Text = "Save..."
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.mnuSaveAs.Size = New System.Drawing.Size(242, 22)
        Me.mnuSaveAs.Text = "Save as..."
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDel, Me.mnuSeparator, Me.mnuDelAll, Me.mnuSeparator2, Me.mnuMoveUp, Me.mnuMoveDown, Me.mnuSortAsc, Me.mnuSortDsc, Me.mnuSeparator3, Me.mnuRefresh, Me.mnuSeparator4, Me.mnuOpen, Me.mnuSave, Me.mnuSaveAs, Me.mnuSeparator5, Me.mnuAbout})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(243, 320)
        '
        'mnuMoveUp
        '
        Me.mnuMoveUp.Name = "mnuMoveUp"
        Me.mnuMoveUp.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.mnuMoveUp.Size = New System.Drawing.Size(242, 22)
        Me.mnuMoveUp.Text = "Move up"
        '
        'mnuMoveDown
        '
        Me.mnuMoveDown.Name = "mnuMoveDown"
        Me.mnuMoveDown.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.mnuMoveDown.Size = New System.Drawing.Size(242, 22)
        Me.mnuMoveDown.Text = "Move down"
        '
        'mnuSortDsc
        '
        Me.mnuSortDsc.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSortDscName, Me.mnuSortDscGender, Me.mnuSortDscICNo})
        Me.mnuSortDsc.Name = "mnuSortDsc"
        Me.mnuSortDsc.ShortcutKeyDisplayString = "                    "
        Me.mnuSortDsc.Size = New System.Drawing.Size(242, 22)
        Me.mnuSortDsc.Text = "Sort descending by"
        '
        'mnuSortDscName
        '
        Me.mnuSortDscName.Name = "mnuSortDscName"
        Me.mnuSortDscName.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.mnuSortDscName.Size = New System.Drawing.Size(184, 22)
        Me.mnuSortDscName.Text = "Name"
        '
        'mnuSortDscGender
        '
        Me.mnuSortDscGender.Name = "mnuSortDscGender"
        Me.mnuSortDscGender.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.mnuSortDscGender.Size = New System.Drawing.Size(184, 22)
        Me.mnuSortDscGender.Text = "Gender"
        '
        'mnuSortDscICNo
        '
        Me.mnuSortDscICNo.Name = "mnuSortDscICNo"
        Me.mnuSortDscICNo.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.mnuSortDscICNo.Size = New System.Drawing.Size(184, 22)
        Me.mnuSortDscICNo.Text = "I/C No"
        '
        'mnuSeparator4
        '
        Me.mnuSeparator4.Name = "mnuSeparator4"
        Me.mnuSeparator4.Size = New System.Drawing.Size(239, 6)
        '
        'mnuSeparator5
        '
        Me.mnuSeparator5.Name = "mnuSeparator5"
        Me.mnuSeparator5.Size = New System.Drawing.Size(239, 6)
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(242, 22)
        Me.mnuAbout.Text = "About StudentList..."
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader2})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 25)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(684, 436)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.UseVistaStyle = True
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 355
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Gender"
        Me.ColumnHeader3.Width = 76
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "I/C No"
        Me.ColumnHeader2.Width = 232
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtSearch)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(700, 500)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student List"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As ListView2
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuDelAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSortAsc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSortAscName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSortAscGender As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSortAscICNo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSortDsc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSortDscName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSortDscGender As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSortDscICNo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoveUp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoveDown As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem

End Class
