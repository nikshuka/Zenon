Public Class Form2
    Dim m As Double
    Dim r As Double
    Dim n As Double
    Dim nod As Double



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then
            m = CInt(TextBox1.Text)
            n = CInt(TextBox2.Text)
            r = 1
            If m >= n And n <> 0 Then
                Do While r <> 0
                    r = (m Mod n)
                    If r = 0 Then
                        nod = n

                    Else
                        m = n
                        n = r
                    End If
                Loop
            Else
                Do While r <> 0
                    r = n Mod m
                    If r = 0 Then
                        nod = m
                    Else
                        n = m And m = r
                    End If
                Loop
            End If

            TextBox3.Text = "НОД:" & nod.ToString


        Else

            MsgBox("Не надо")
        End If









    End Sub
End Class