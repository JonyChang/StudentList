' Just a typical listview with no flickering.

Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class ListView2
    Inherits ListView
    ' API Declaration
    Private Declare Unicode Function SetWindowTheme Lib "uxtheme.dll" (ByVal hWnd As IntPtr, ByVal pszSubAppName As String, ByVal pszSubIdList As String) As Integer
    ' API Structure
    <StructLayout(LayoutKind.Sequential)> _
    Private Structure NMHDR
        Public hwndFrom As IntPtr
        Public idFrom As Integer
        Public code As Integer
    End Structure
    ' Const Var
    Private Const NM_CUSTOMDRAW As Integer = -12
    ' Var
    Private _UseVistaStyle As Boolean
    ' Property
    <Description("Enable to use Vista nice-looking listview style. Changing UseVistaSelection in runtime would not work.")> _
    Public Property UseVistaStyle As Boolean
        Get
            Return _UseVistaStyle
        End Get
        Set(value As Boolean)
            _UseVistaStyle = value
        End Set
    End Property

    Public Sub New()
        'This kills flickering the most
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        'This make the drawing speed FASTER
        'But you will CANNOT CUSTOM DRAW anything, including custom backcolor of a listviewitem!
        If m.Msg = &H204E Then
            Dim hdr As NMHDR = CType(m.GetLParam(GetType(NMHDR)), NMHDR)
            If hdr.code = NM_CUSTOMDRAW Then
                m.Result = IntPtr.Zero
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    Protected Overrides Sub OnHandleCreated(e As System.EventArgs)
        If _UseVistaStyle Then SetWindowTheme(Me.Handle, "explorer", Nothing)
        MyBase.OnHandleCreated(e)
    End Sub


End Class
