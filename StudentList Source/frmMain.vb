' Written by Raymai97 in 2013.
'
' I'm trying to find a nice and easy way for implementing stuff like this.
' Because I don't wanna waste time for messing stuff like these in the future, anymore.
' I will reference to this project code for my future project. :D
'
' Max user experience + Least dirty code = Goal of this project
'
' This program used ListView2.vb, which is a bit better than typical ListView, it supports Vista selection, flicker-free UI...

Imports StudentList.AppShared

Public Class frmMain
    Private Editor As New frmEdit
    Private OpenedFile As String

    Private Sub AddInfo()
        Editor.Info = New StudentInfo
        If Editor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Infos.Add(Editor.Info)
            RefreshList2()
            SelectItem(ListView1.Items.Count - 1)
        End If
    End Sub

    Private Sub EditInfo()
        If ListView1.SelectedItems.Count <> 1 Then Return
        Dim i As ListViewItem = ListView1.SelectedItems(0)
        Editor.Info = GetInfo(i.Text)
        If Editor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With Editor.Info
                i.Text = .Name
                i.SubItems(1).Text = .Gender.ToString
                i.SubItems(2).Text = .ICNo
            End With
            RefreshList()
        End If
    End Sub

    Private Sub DelInfo()
        If ListView1.SelectedItems.Count <> 1 Then Return
        Select Case MessageBox.Show("Really want to delete?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
                Dim i As ListViewItem = ListView1.SelectedItems(0)
                Infos.Remove(GetInfo(i.Text))
                RefreshList()
            Case Windows.Forms.DialogResult.No
        End Select
    End Sub

    Private Sub DelAllInfo()
        Select Case MessageBox.Show("Are you sure you want to delete all?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            Case Windows.Forms.DialogResult.Yes
                Infos.Clear()
                RefreshList()
            Case Windows.Forms.DialogResult.No
        End Select
    End Sub

    Private Sub MoveUp()
        If ListView1.SelectedItems.Count <> 1 Then Return
        Dim Info As StudentInfo = GetInfo(ListView1.SelectedItems(0).Text)
        Dim Index As Integer = Infos.IndexOf(Info)
        Dim Index2 As Integer = Index - 1
        ReorderInfo(Index, Index2)
        RefreshList2()
        SelectItem(Index2)
    End Sub

    Private Sub MoveDown()
        If ListView1.SelectedItems.Count <> 1 Then Return
        Dim i As ListViewItem = ListView1.SelectedItems(0)
        Dim Info As StudentInfo = GetInfo(i.Text)
        Dim Index As Integer = Infos.IndexOf(Info)
        Dim Index2 As Integer = Index + 1
        ReorderInfo(Index, Index2)
        RefreshList2()
        SelectItem(Index2)
    End Sub

    Private Sub OpenFile()
        Dim ofd As New OpenFileDialog
        ofd.Filter = "StudentList XML|*.xml"
        ofd.Multiselect = False
        ofd.FileName = ""
        ofd.ShowDialog()
        If ofd.FileName <> "" Then
            Dim ex As Exception = XMLHelper.Load(Infos, ofd.FileName)
            If ex Is Nothing Then
                OpenedFile = ofd.FileName
                RefreshFrmText()
                RefreshList()
                'MessageBox.Show("File loaded!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to load file." & vbCrLf & ofd.FileName & vbCrLf & vbCrLf & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub SaveFile(Optional AlwaySaveAs As Boolean = False)
        If AlwaySaveAs Or OpenedFile = "" Then
            Dim sfd As New SaveFileDialog
            sfd.Filter = "StudentList XML|*.xml"
            sfd.FileName = ""
            sfd.ShowDialog()
            If sfd.FileName <> "" Then
                SaveFile2(sfd.FileName)
            End If
        Else
            SaveFile2(OpenedFile)
        End If
    End Sub

    Private Sub SaveFile2(FilePath As String)
        Dim ex As Exception = XMLHelper.Save(Infos, FilePath)
        If ex Is Nothing Then
            OpenedFile = FilePath
            RefreshFrmText()
            MessageBox.Show("File saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to save file." & vbCrLf & FilePath & vbCrLf & vbCrLf & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SelectItem(Index As Integer)
        With ListView1.Items
            If .Count = 0 Then Return
            If Index < 0 Then
                Index = 0
            ElseIf Index > .Count - 1 Then
                Index = .Count - 1
            End If
            .Item(Index).Selected = True
            ListView1.FocusedItem = .Item(Index)
            ListView1.EnsureVisible(Index)
        End With
    End Sub

    Private Sub SortInfoBy(Type As SortType, Descending As Boolean)
        Infos.Sort(New StudentInfoComparer(Type, Descending))
        RefreshList()
    End Sub

    Private Sub RefreshList()
        With ListView1
            ' Remember the selected item index
            Dim LastSelectedIndex As Integer
            If ListView1.SelectedItems.Count = 1 Then LastSelectedIndex = ListView1.SelectedIndices(0)
            ' Refresh list
            RefreshList2()
            ' Try to reselect the last selected item index
            SelectItem(LastSelectedIndex)
        End With
    End Sub

    Private Sub RefreshList2()
        ListView1.BeginUpdate()
        With ListView1.Items
            .Clear()
            For Each Info As StudentInfo In Infos
                ' Non case-sensitive filter detection code
                ' Add item into list, if no search term given or it contains the search term.
                Dim SearchTerm As String = txtSearch.Text
                If SearchTerm = "" Or (SearchTerm <> "" AndAlso Info.Name.ToUpper.Contains(SearchTerm.ToUpper)) Then
                    Dim i As New ListViewItem
                    With Info
                        i.Text = .Name
                        i.SubItems.Add(.Gender.ToString)
                        i.SubItems.Add(.ICNo)
                    End With
                    .Add(i)
                End If
            Next
        End With
        ListView1.EndUpdate()
    End Sub

    Private Sub RefreshFrmText()
        If OpenedFile <> "" Then
            Me.Text = "Student List - " & IO.Path.GetFileName(OpenedFile)
        Else
            Me.Text = "Student List"
        End If
    End Sub

    Private Sub frmMain_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F6
                With txtSearch
                    .Select()
                    .SelectAll()
                End With
        End Select
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As System.EventArgs) Handles txtSearch.TextChanged
        RefreshList()
    End Sub

    Private Sub ListView1_ColumnClick(sender As System.Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView1.ColumnClick
        Static Toggle As Boolean
        Select Case e.Column
            Case 0
                SortInfoBy(SortType.Name, Toggle)
            Case 1
                SortInfoBy(SortType.Gender, Toggle)
            Case 2
                SortInfoBy(SortType.ICNo, Toggle)
        End Select
        Toggle = Not Toggle
    End Sub

    Private Sub ListView1_ItemActivate(sender As System.Object, e As System.EventArgs) Handles ListView1.ItemActivate
        EditInfo()
    End Sub

    Private Sub ContextMenuStrip1_Closing(sender As Object, e As System.Windows.Forms.ToolStripDropDownClosingEventArgs) Handles ContextMenuStrip1.Closing
        ' Gonna make sure all items are enabled
        ' Because Enabled property only update during context menu show up
        ' Without enabling back all items, shortcut key might not work in some situation
        For Each i As ToolStripItem In ContextMenuStrip1.Items
            i.Enabled = True
        Next
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If ListView1.SelectedItems.Count = 1 Then
            mnuEdit.Enabled = True
            mnuDel.Enabled = True
            mnuMoveUp.Enabled = True
            mnuMoveDown.Enabled = True
        Else
            mnuEdit.Enabled = False
            mnuDel.Enabled = False
            mnuMoveUp.Enabled = False
            mnuMoveDown.Enabled = False
        End If
        If ListView1.Items.Count = 0 Then
            mnuDelAll.Enabled = False
            mnuSortAsc.Enabled = False
            mnuSortDsc.Enabled = False
        Else
            mnuDelAll.Enabled = True
            mnuSortAsc.Enabled = True
            mnuSortDsc.Enabled = True
        End If
    End Sub

    Private Sub mnuAdd_Click(sender As System.Object, e As System.EventArgs) Handles mnuAdd.Click
        AddInfo()
    End Sub

    Private Sub mnuEdit_Click(sender As System.Object, e As System.EventArgs) Handles mnuEdit.Click
        EditInfo()
    End Sub

    Private Sub mnuDel_Click(sender As System.Object, e As System.EventArgs) Handles mnuDel.Click
        DelInfo()
    End Sub

    Private Sub mnuDelAll_Click(sender As System.Object, e As System.EventArgs) Handles mnuDelAll.Click
        DelAllInfo()
    End Sub

    Private Sub mnuRefresh_Click(sender As System.Object, e As System.EventArgs) Handles mnuRefresh.Click
        RefreshList()
    End Sub

    Private Sub mnuMoveUp_Click(sender As System.Object, e As System.EventArgs) Handles mnuMoveUp.Click
        MoveUp()
    End Sub

    Private Sub mnuMoveDown_Click(sender As System.Object, e As System.EventArgs) Handles mnuMoveDown.Click
        MoveDown()
    End Sub

    Private Sub mnuSortAscName_Click(sender As System.Object, e As System.EventArgs) Handles mnuSortAscName.Click
        SortInfoBy(SortType.Name, False)
    End Sub

    Private Sub mnuSortAscGender_Click(sender As System.Object, e As System.EventArgs) Handles mnuSortAscGender.Click
        SortInfoBy(SortType.Gender, False)
    End Sub

    Private Sub mnuSortAscICNo_Click(sender As System.Object, e As System.EventArgs) Handles mnuSortAscICNo.Click
        SortInfoBy(SortType.ICNo, False)
    End Sub

    Private Sub mnuSortDscName_Click(sender As System.Object, e As System.EventArgs) Handles mnuSortDscName.Click
        SortInfoBy(SortType.Name, True)
    End Sub

    Private Sub mnuSortDscGender_Click(sender As System.Object, e As System.EventArgs) Handles mnuSortDscGender.Click
        SortInfoBy(SortType.Gender, True)
    End Sub

    Private Sub mnuSortDscICNo_Click(sender As System.Object, e As System.EventArgs) Handles mnuSortDscICNo.Click
        SortInfoBy(SortType.ICNo, True)
    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As System.EventArgs) Handles mnuOpen.Click
        OpenFile()
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As System.EventArgs) Handles mnuSave.Click
        SaveFile()
    End Sub

    Private Sub mnuSaveAs_Click(sender As System.Object, e As System.EventArgs) Handles mnuSaveAs.Click
        SaveFile(True)
    End Sub

    Private Sub mnuAbout_Click(sender As System.Object, e As System.EventArgs) Handles mnuAbout.Click
        MessageBox.Show("Written by Raymai97 (MaiSoft leader) in 2013." & vbCrLf & vbCrLf & "This software are just intended for testing purpose. Use it at your own risk." & vbCrLf & vbCrLf & "This software is open-source. Check it out by visiting raymai97.github.com", "About StudentList", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
