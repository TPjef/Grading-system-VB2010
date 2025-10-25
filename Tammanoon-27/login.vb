Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class login
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Tammanoon-27.accdb;")
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim ds As New DataSet
    Public Function chek()
        con.Open()
        dt = New DataTable
        ds = New DataSet
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("select * from login", con)
        da.Fill(dt)

        For Each DataRow In dt.Rows
            If TextBox1.Text = DataRow(0) And TextBox2.Text = DataRow(1) Then
                con.Close()
                Return True
            End If
        Next
        con.Close()
        Return False

    End Function

    Private Sub bt_login_Click(sender As System.Object, e As System.EventArgs) Handles bt_login.Click
        If chek() = True Then
            Me.Hide()
            MessageBox.Show("เข้าสู่ระบบสำเร็จ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            main.Show()
        Else
            MessageBox.Show("กรุณาตรวจสอบ username และ password ให้ถูกต้อง", "ล็อคอินผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Clear()
            TextBox2.Clear()
        End If
    End Sub
End Class