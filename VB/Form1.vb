Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace WindowsFormsApplication13
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			If xpCollection1.Count = 0 Then
				Dim r As New Random()
				For i As Integer = 0 To 9
					Dim b As New MyObject()
					b.BLOCKCODE = r.Next(10000).ToString()
					If i Mod 2 <> 0 Then
						b.FORMERLYWAS = TryCast(xpCollection1(r.Next(xpCollection1.Count)), MyObject)
					End If
					b.Save()
					xpCollection1.Add(b)
				Next i
			End If
			dataGridView1.DataSource = xpCollection1
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim c As XPCollection(Of MyObject) = New XPCollection(Of MyObject)(CriteriaOperator.Parse("not RelatedObjects[].Exists()"), Nothing)
			dataGridView2.DataSource = c
		End Sub
	End Class

	Public Class MyObject
		Inherits XPBaseObject
		'PSCID,PSCNAME,BLOCKCODE,FORMERLYWAS from PSCBLOCK
		<Key(True)> _
		Public PSCID As Integer

		<Association("ID_FORMERLYWAS")> _
		Public FORMERLYWAS As MyObject

		<Association("ID_FORMERLYWAS", GetType(MyObject))> _
		Public ReadOnly Property RelatedObjects() As XPCollection(Of MyObject)
			Get
				Return GetCollection(Of MyObject)("RelatedObjects")
			End Get
		End Property
		Public PSCNAME As String
		Public BLOCKCODE As String

	End Class
End Namespace
