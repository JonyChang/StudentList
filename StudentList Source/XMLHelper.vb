Imports System.IO
Imports System.Xml
Imports StudentList.AppShared

Public Class XMLHelper

    Public Shared Function Save(Infos As List(Of StudentInfo), FilePath As String) As Exception
        Try
            Using Writer As New StreamWriter(FilePath, False, System.Text.Encoding.UTF8)
                Dim XMLDoc As New XmlDocument
                Dim RootNode As XmlNode = XMLDoc.CreateElement("StudentList")
                For Each Info As StudentInfo In Infos
                    Dim Item As XmlElement = XMLDoc.CreateElement("Info")
                    Item.SetAttribute("Name", Info.Name)
                    Item.SetAttribute("ICNo", Info.ICNo)
                    Item.SetAttribute("Gender", Info.Gender.ToString)
                    RootNode.AppendChild(Item)
                Next
                XMLDoc.AppendChild(RootNode)
                XMLDoc.Save(Writer)
            End Using
        Catch ex As Exception
            Return ex
        End Try
        Return Nothing
    End Function

    Public Shared Function Load(ByRef Infos As List(Of StudentInfo), FilePath As String) As Exception
        Try
            Using Reader As New StreamReader(FilePath, System.Text.Encoding.UTF8, True)
                Dim XMLDoc As New XmlDocument
                XMLDoc.Load(FilePath)
                Dim RootNode As XmlNode = XMLDoc.SelectSingleNode("StudentList")
                Infos = New List(Of StudentInfo)
                For Each Item As XmlElement In RootNode.SelectNodes("Info")
                    Dim Info As New StudentInfo
                    Info.Name = Item.GetAttribute("Name")
                    Info.ICNo = Item.GetAttribute("ICNo")
                    Select Case Item.GetAttribute("Gender")
                        Case "Male"
                            Info.Gender = Gender.Male
                        Case "Female"
                            Info.Gender = Gender.Female
                    End Select
                    Infos.Add(Info)
                Next
            End Using
        Catch ex As Exception
            Return ex
        End Try
        Return Nothing
    End Function

End Class
