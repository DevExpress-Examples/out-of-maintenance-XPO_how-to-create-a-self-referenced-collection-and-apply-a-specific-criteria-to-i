Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication13
	Partial Public Class Form1
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
			Me.xpCollection1 = New DevExpress.Xpo.XPCollection()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.dataGridView2 = New System.Windows.Forms.DataGridView()
			Me.button1 = New System.Windows.Forms.Button()
			CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xpCollection1
			' 
			Me.xpCollection1.DisplayableProperties = "This;PSCID;FORMERLYWAS!;FORMERLYWAS!Key;FORMERLYWAS;PSCNAME;BLOCKCODE;RelatedObje" & "cts"
			Me.xpCollection1.ObjectType = GetType(WindowsFormsApplication13.MyObject)
			' 
			' dataGridView1
			' 
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top
			Me.dataGridView1.Location = New System.Drawing.Point(0, 0)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(671, 192)
			Me.dataGridView1.TabIndex = 0
			' 
			' dataGridView2
			' 
			Me.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.dataGridView2.Location = New System.Drawing.Point(0, 290)
			Me.dataGridView2.Name = "dataGridView2"
			Me.dataGridView2.Size = New System.Drawing.Size(671, 243)
			Me.dataGridView2.TabIndex = 1
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(300, 230)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 23)
			Me.button1.TabIndex = 2
			Me.button1.Text = "button1"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(671, 533)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.dataGridView2)
			Me.Controls.Add(Me.dataGridView1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private xpCollection1 As DevExpress.Xpo.XPCollection
		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private dataGridView2 As System.Windows.Forms.DataGridView
		Private WithEvents button1 As System.Windows.Forms.Button

	End Class
End Namespace

