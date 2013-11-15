Imports StudentList.AppShared

Public Class frmEdit

    Public Info As StudentInfo

    Private Sub frmEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Info Is Nothing Then Info = New StudentInfo
        txtName.Text = Info.Name
        txtICNo.Text = Info.ICNo
        Select Case Info.Gender
            Case Gender.Male
                rdoMale.Checked = True
            Case Gender.Female
                rdoFemale.Checked = True
        End Select
        With txtName
            .Select()
            .SelectAll()
        End With
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If txtName.Text = "" Then
            MessageBox.Show("Sorry, StudentList doesn't support student without name.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtName.Select()
        Else
            Dim InfoNoConflict As Boolean = GetInfo(txtName.Text) Is Nothing
            Dim EditMode As Boolean = Infos.Contains(Info)
            If InfoNoConflict Or EditMode Then
                Info.Name = txtName.Text
                Info.ICNo = txtICNo.Text
                Select Case True
                    Case rdoFemale.Checked
                        Info.Gender = Gender.Female
                    Case rdoMale.Checked
                        Info.Gender = Gender.Male
                End Select
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("A student info with the same name is already exist! Try enter another name.", "Conflict...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub frmEdit_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                SelectNextControl(ActiveControl, True, True, True, False)
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub textboxSilencer(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown, txtICNo.KeyDown
        If e.KeyCode = Keys.Enter Then e.SuppressKeyPress = True
    End Sub

End Class