Public Class cutgrade
    Dim id As Integer
    Dim score1 As Integer
    Dim score2 As Integer
    Dim score3 As Integer
    Dim mid As Integer
    Dim final As Integer
    Private Property totalScore As Integer

    Private Sub txt_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_id.TextChanged
        If (IsNumeric(txt_id.Text)) Then
            id = txt_id.Text
        Else
            If txt_id.Text <> "" Then
                MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข")
            End If
        End If
    End Sub

    Private Sub txt_score1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_score1.TextChanged
        If IsNumeric(txt_score1.Text) Then
            If Val(txt_score1.Text) > 20 Then
                txt_score1.Clear()
            Else
                score1 = Val(txt_score1.Text)
            End If
        Else
            txt_score1.Clear()
            MessageBox.Show("คุณกรอกข้อมูลเกิน20คะแนน")
        End If
    End Sub
    Private Sub txt_score2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_score2.TextChanged
        If IsNumeric(txt_score2.Text) Then
            If Val(txt_score2.Text) > 20 Then
                txt_score2.Clear()
            Else
                score2 = Val(txt_score2.Text)
            End If
        Else
            txt_score2.Clear()
            MessageBox.Show("คุณกรอกข้อมูลเกิน20คะแนน")
        End If
    End Sub
    Private Sub txt_score3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_score3.TextChanged
        If IsNumeric(txt_score3.Text) Then
            If Val(txt_score3.Text) > 20 Then
                txt_score3.Clear()
            Else
                score3 = Val(txt_score3.Text)
            End If
        Else
            txt_score3.Clear()
            MessageBox.Show("คุณกรอกข้อมูลเกิน20คะแนน")
        End If
    End Sub
    Private Sub txt_mid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_mid.TextChanged
        If IsNumeric(txt_mid.Text) Then
            If Val(txt_mid.Text) > 20 Then
                txt_mid.Clear()
            Else
                mid = Val(txt_mid.Text)
            End If
        Else
            txt_mid.Clear()
            MessageBox.Show("คุณกรอกข้อมูลเกิน20คะแนน")
        End If
    End Sub
    Private Sub txt_final_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_final.TextChanged
        If IsNumeric(txt_final.Text) Then
            If Val(txt_final.Text) > 20 Then
                txt_final.Clear()
            Else
                final = Val(txt_final.Text)
            End If
        Else
            txt_final.Clear()
            MessageBox.Show("คุณกรอกข้อมูลเกิน20คะแนน")
        End If
    End Sub

    Private Sub bt_sum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_sum.Click
        If IsNumeric(txt_score1.Text) Then
            score1 = txt_score1.Text
        End If

        If IsNumeric(txt_score2.Text) Then
            score2 = txt_score2.Text
        End If

        If IsNumeric(txt_score3.Text) Then
            score3 = txt_score3.Text
        End If

        If IsNumeric(txt_mid.Text) Then
            mid = txt_mid.Text
        End If

        If IsNumeric(txt_final.Text) Then
            final = txt_final.Text
        End If

        totalScore = score1 + score2 + score3 + mid + final

        txt_sum.Text = "" & totalScore
    End Sub

    Private Sub bt_cut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cut.Click

        Dim score As Double = Val(txt_sum.Text)

        Dim grade As String
        If score >= 80 Then
            grade = "4"
        ElseIf score >= 75 Then
            grade = "3.5"
        ElseIf score >= 70 Then
            grade = "3"
        ElseIf score >= 65 Then
            grade = "2.5"
        ElseIf score >= 60 Then
            grade = "2"
        ElseIf score >= 55 Then
            grade = "1.5"
        ElseIf score >= 50 Then
            grade = "1"
        Else
            grade = "0"
        End If

        txt_sum.Text = "" & totalScore
        nameshow.Text = txt_name.Text
        roomshow.Text = txt_room.Text
        idshow.Text = txt_id.Text
        codeshow.Text = cb_code.Text
        subshow.Text = cb_sub.Text
        gradeshow.Text = grade

        txt_name.Text = ""
        txt_room.Text = ""
        txt_id.Text = ""
        cb_code.Text = ""
        cb_sub.Text = ""
    End Sub
End Class
