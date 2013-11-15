Public Class AppShared
    Public Shared Infos As New List(Of StudentInfo)

    Public Shared Function GetInfo(Name As String) As StudentInfo
        For Each Info As StudentInfo In Infos
            If Info.Name = Name Then Return Info
        Next
        Return Nothing
    End Function

    Public Shared Function isBadIndex(index As Integer) As Boolean
        Return (index < 0 Or index > Infos.Count - 1)
    End Function

    Public Shared Sub ReorderInfo(oldIndex As Integer, newIndex As Integer)
        If isBadIndex(oldIndex) Or isBadIndex(newIndex) Then Return
        Dim Info As StudentInfo = Infos(oldIndex)
        Infos.RemoveAt(oldIndex)
        Infos.Insert(newIndex, Info)
    End Sub

    ' Classes

    Public Class StudentInfo
        Public Name, ICNo As String
        Public Gender As Gender = Gender.Male

    End Class

    Public Class StudentInfoComparer
        Implements IComparer(Of StudentInfo)

        Private Type As SortType
        Private Descending As Boolean

        Public Sub New(Type As SortType, Descending As Boolean)
            Me.Type = Type
            Me.Descending = Descending
        End Sub

        Public Function Compare(x As StudentInfo, y As StudentInfo) As Integer Implements System.Collections.Generic.IComparer(Of StudentInfo).Compare
            Dim result As Integer
            Select Case Type
                Case SortType.Name
                    result = x.Name.CompareTo(y.Name)
                Case SortType.ICNo
                    result = x.ICNo.CompareTo(y.ICNo)
                Case SortType.Gender
                    result = x.Gender.ToString.CompareTo(y.Gender.ToString)
            End Select
            If Descending Then
                ' toggle the sign of result (1 to -1, -1 to 1, 0 to 0)
                result *= -1
            End If
            Return result
        End Function
    End Class

    ' Enums

    Public Enum Gender
        Male
        Female
    End Enum

    Public Enum SortType
        Name
        Gender
        ICNo
    End Enum

End Class

