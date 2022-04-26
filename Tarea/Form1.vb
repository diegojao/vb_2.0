Public Class Form1
    Sub limpiartextbox()
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Clear()
        TextBox1.Focus()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiartextbox()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim longitud As Integer
        longitud = ListBox1.Items.Count()
        For i = 0 To longitud - 1 Step 1
            MessageBox.Show(ListBox1.Items.Item(i))
        Next

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            limpiartextbox()
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim longitud As Integer
        longitud = ListBox1.Items.Count()
        ListBox1.Items.Remove(TextBox1.Text)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox1.Text = ListBox1.SelectedItem
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim longitud As Integer
        longitud = ListBox1.Items.Count()
        For i = 0 To longitud - 1 Step 1
            ListBox2.Items.Add(ListBox1.Items.Item(i))
        Next
        ListBox2.Sorted = True
        For i = longitud - 1 To 0 Step -1
            ListBox3.Items.Add(ListBox1.Items.Item(i))
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class
