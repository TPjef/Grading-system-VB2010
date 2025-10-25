Public Class student

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Lname.Click

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTok_Click(sender As System.Object, e As System.EventArgs) Handles BTok.Click
        MessageBox.Show("ชื่อ : " + " " + txtname.Text & vbNewLine &
                        "นามสกุล : " + " " + txtlastname.Text & vbNewLine &
                        "ชั้น : " + " " + txtclass.Text & vbNewLine &
                        "เลขที่ : " + " " + txtid.Text & vbNewLine &
                        "ครูที่ปรึกษา : " + " " + txtch.Text)
    End Sub

    Private Sub txtname_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub BTshow_Click(sender As System.Object, e As System.EventArgs) Handles BTshow.Click
        nameshow.Text = txtname.Text
        lastnameshow.Text = txtlastname.Text
        classshow.Text = txtclass.Text
        idshow.Text = txtid.Text
        techarshow.Text = txtch.Text

        txtname.Text = ""
        txtlastname.Text = ""
        txtclass.Text = ""
        txtid.Text = ""
        txtch.Text = ""

    End Sub
End Class
