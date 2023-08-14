Public Class Form1
    'Design an application that accepts the item name from the user and add it to a list box and
    'combo box.

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Names.Items.Add(txt_name.Text)
        ComboBox1.Items.Add(txt_amin_no.Text)
        txt_amin_no.Text = ""
        txt_name.Text = ""
    End Sub
End Class
