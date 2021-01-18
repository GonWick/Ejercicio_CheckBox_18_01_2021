Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Text = ""
        If CheckBox1.Checked = True Then
            Text = Text + "(Inglés)"
        End If
        If CheckBox2.Checked = True Then
            Text = Text + "(Francés)"
        End If
        If CheckBox3.Checked = True Then
            Text = Text + "(Alemán)"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Text = "Boton 2: "
        If CheckBox1.Checked = True Then
            Text = Text & "(" & CheckBox1.Text & ")"
        End If
        If CheckBox2.Checked = True Then
            Text = Text & "(" & CheckBox2.Text & ")"
        End If
        If CheckBox3.Checked = True Then
            Text = Text & "(" & CheckBox3.Text & ")"
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
