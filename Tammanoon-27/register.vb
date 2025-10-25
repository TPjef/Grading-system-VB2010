Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class register
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Tammanoon-27.accdb;")
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim ds As New DataSet
    Public sqlCommand As New OleDbCommand
    Private Sub register_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Closed Then
            con.Open()
            MsgBox("open")
        End If
        showtable()
    End Sub
    Private Sub showtable()
        Dim sqlQuery As String
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet
        sqlQuery = "select * from std"
        da = New OleDbDataAdapter(sqlQuery, con)
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns.Item(0).HeaderText() = "รหัสนักเรียน" 'การเปลี่ยนชื่อในหัวตาราง DataGridView ให้เป็นภาษาไทย
        DataGridView1.Columns.Item(1).HeaderText() = "ชื่อ"
        DataGridView1.Columns.Item(2).HeaderText() = "สกุล"
        DataGridView1.Columns.Item(3).HeaderText() = "เพศ"
        DataGridView1.Columns.Item(4).HeaderText() = "สาขาวิชา"
    End Sub
    Private Function checkdata()
        Dim result As Boolean 'ฟังก์ชันการเช็คข้อมูลก่อนบันทึก
        If txt_id.Text = "" Or txt_name.Text = "" Or txt_lname.Text = "" Or txt_gender.Text = "" Or txt_sub.Text = "" Then
            MessageBox.Show("กรุณาฝส่ข้อมูลให้ครบ")
            result = False
        Else
            result = True
        End If
        Return result
    End Function
    Private Sub DataGridview_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txt_id.Text = DataGridView1.Item(0, i).Value
        txt_name.Text = DataGridView1.Item(1, i).Value
        txt_lname.Text = DataGridView1.Item(2, i).Value
        txt_gender.Text = DataGridView1.Item(3, i).Value
        txt_sub.Text = DataGridView1.Item(4, i).Value
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles BT_clear.Click
        txt_id.Clear()
        txt_name.Clear()
        txt_lname.Clear()
        txt_gender.Clear()
        txt_sub.Clear()
    End Sub
    Private Sub BT_save_Click(sender As System.Object, e As System.EventArgs) Handles BT_save.Click
        Dim sqlQuery As String
        Dim result As Boolean 'กำหนดตัวแปร  result ให้เป็นชนิด Boolean เพื่อใช้ในการเปรียบเทียบ
        result = checkdata() 'ทำการเปรียบเทียบ ตัวแปร result ให้เป็นฟังก์ชั่น checkdata
        If result = True Then 'ถ้า result เท่ากับ checkdata จริงให้โปรแกรทำการบันทึกข้อมูลลงฐานข้อมูล
            Try
                sqlQuery = "INSERT INTO std(std_id,std_name,std_lname,std_gender,std_subj) VALUES ('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_lname.Text & "','" & txt_gender.Text & "','" & txt_sub.Text & "')"
                With sqlCommand
                    .CommandText = sqlQuery
                    .Connection = con
                    .ExecuteNonQuery()
                End With
                MsgBox("บันทึกข้อมูลสำเร็จ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        showtable() 'จะนั้นทำการแสดงข้อมูลที่บันทึก
    End Sub

    Private Sub BT_edit_Click(sender As System.Object, e As System.EventArgs) Handles BT_edit.Click
        Dim sqlQuery As String
        Dim result As Boolean 'กำหนดตัวแปร  result ให้เป็นชนิด Boolean เพื่อใช้ในการเปรียบเทียบ
        result = checkdata() 'ทำการเปรียบเทียบ ตัวแปร result ให้เป็นฟังก์ชั่น checkdata
        If result = True Then 'ถ้า result เท่ากับ checkdata จริงให้โปรแกรทำการบันทึกข้อมูลลงฐานข้อมูล
            If txt_id.Text = "" Then
                MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการแก้ไข")
            Else
                Try
                    sqlQuery = "UPDATE std SET std_id = '" & txt_id.Text & "',std_name = '" & txt_name.Text & "',std_lname = '" & txt_lname.Text & "',std_gender = '" & txt_gender.Text & "',std_subj = '" & txt_sub.Text & "'Where std_id Like '" & txt_id.Text & "'"
                    With sqlCommand
                        .CommandText = sqlQuery
                        .Connection = con
                        .ExecuteNonQuery()
                    End With
                    MsgBox("แก้ไขข้อมูลสำเร็จ", vbInformation)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If
        showtable() 'จะนั้นทำการแสดงข้อมูลที่บันทึก
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles BT_delete.Click
        Dim sqlQuery As String
        Dim result As Boolean 'กำหนดตัวแปร  result ให้เป็นชนิด Boolean เพื่อใช้ในการเปรียบเทียบ
        result = checkdata() 'ทำการเปรียบเทียบ ตัวแปร result ให้เป็นฟังก์ชั่น checkdata
        If result = True Then 'ถ้า result เท่ากับ checkdata จริงให้โปรแกรทำการบันทึกข้อมูลลงฐานข้อมูล
            Try
                sqlQuery = "DELETE FROM std WHERE std_id = '" & txt_id.Text & "'"
                With sqlCommand
                    .CommandText = sqlQuery
                    .Connection = con
                    .ExecuteNonQuery()
                End With
                MsgBox("ลบข้อมูลสำเร็จ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        showtable() 'จะนั้นทำการแสดงข้อมูลที่บันทึก
    End Sub
End Class

