<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtICNo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(252, 111)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(80, 28)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "I/C No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Gender:"
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Location = New System.Drawing.Point(81, 74)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(55, 21)
        Me.rdoMale.TabIndex = 2
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "Male"
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Location = New System.Drawing.Point(142, 74)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(67, 21)
        Me.rdoFemale.TabIndex = 3
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(81, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(251, 25)
        Me.txtName.TabIndex = 0
        '
        'txtICNo
        '
        Me.txtICNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtICNo.Location = New System.Drawing.Point(81, 43)
        Me.txtICNo.Name = "txtICNo"
        Me.txtICNo.Size = New System.Drawing.Size(251, 25)
        Me.txtICNo.TabIndex = 1
        '
        'frmEdit
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(344, 151)
        Me.Controls.Add(Me.txtICNo)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.rdoFemale)
        Me.Controls.Add(Me.rdoMale)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOK)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEdit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdoMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFemale As System.Windows.Forms.RadioButton
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtICNo As System.Windows.Forms.TextBox
End Class
