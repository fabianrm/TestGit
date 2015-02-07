Public Class Form1

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        MessageBox.Show("Hola " + TextEdit1.Text)
        MessageBox.Show("Gracias por venir")
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit1.EditValueChanged
        Me.TextEdit1.Text = TextEdit2.Text
    End Sub
End Class
