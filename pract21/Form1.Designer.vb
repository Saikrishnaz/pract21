<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txt_name = New TextBox()
        txt_amin_no = New TextBox()
        Button1 = New Button()
        Names = New ListBox()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Subheading", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(129, 157)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 23)
        Label1.TabIndex = 0
        Label1.Text = "Enter your name : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Subheading", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(105, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(181, 23)
        Label2.TabIndex = 1
        Label2.Text = "Enter your phone no  : "
        ' 
        ' txt_name
        ' 
        txt_name.Font = New Font("Sitka Subheading", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_name.Location = New Point(309, 157)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(181, 28)
        txt_name.TabIndex = 2
        ' 
        ' txt_amin_no
        ' 
        txt_amin_no.Font = New Font("Sitka Subheading", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_amin_no.Location = New Point(309, 190)
        txt_amin_no.Name = "txt_amin_no"
        txt_amin_no.Size = New Size(181, 28)
        txt_amin_no.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Sitka Subheading", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(121, 243)
        Button1.Name = "Button1"
        Button1.Size = New Size(346, 34)
        Button1.TabIndex = 4
        Button1.Text = "Add Me"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Names
        ' 
        Names.Font = New Font("Sitka Subheading", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Names.FormattingEnabled = True
        Names.ItemHeight = 23
        Names.Location = New Point(137, 326)
        Names.Name = "Names"
        Names.Size = New Size(133, 23)
        Names.TabIndex = 5
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Sitka Subheading", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(309, 326)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(158, 31)
        ComboBox1.TabIndex = 6
        ComboBox1.Text = "Phone  number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Subheading", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(177, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(290, 42)
        Label3.TabIndex = 7
        Label3.Text = "Add Yourself To List"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(645, 477)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(Names)
        Controls.Add(Button1)
        Controls.Add(txt_amin_no)
        Controls.Add(txt_name)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_amin_no As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Names As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
End Class
