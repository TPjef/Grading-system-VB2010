<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cutgrade
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bt_cut = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gradeshow = New System.Windows.Forms.Label()
        Me.subshow = New System.Windows.Forms.Label()
        Me.codeshow = New System.Windows.Forms.Label()
        Me.idshow = New System.Windows.Forms.Label()
        Me.roomshow = New System.Windows.Forms.Label()
        Me.nameshow = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.bt_sum = New System.Windows.Forms.Button()
        Me.txt_sum = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_final = New System.Windows.Forms.TextBox()
        Me.txt_mid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_score3 = New System.Windows.Forms.TextBox()
        Me.txt_score2 = New System.Windows.Forms.TextBox()
        Me.txt_score1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_room = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.cb_sub = New System.Windows.Forms.ComboBox()
        Me.cb_code = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bt_cut)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.bt_sum)
        Me.GroupBox1.Controls.Add(Me.txt_sum)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_room)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.cb_sub)
        Me.GroupBox1.Controls.Add(Me.cb_code)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1020, 433)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ตัดเกรดรายวิชา"
        '
        'bt_cut
        '
        Me.bt_cut.Location = New System.Drawing.Point(617, 386)
        Me.bt_cut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_cut.Name = "bt_cut"
        Me.bt_cut.Size = New System.Drawing.Size(100, 28)
        Me.bt_cut.TabIndex = 16
        Me.bt_cut.Text = "ตัดเกรด"
        Me.bt_cut.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.gradeshow)
        Me.GroupBox4.Controls.Add(Me.subshow)
        Me.GroupBox4.Controls.Add(Me.codeshow)
        Me.GroupBox4.Controls.Add(Me.idshow)
        Me.GroupBox4.Controls.Add(Me.roomshow)
        Me.GroupBox4.Controls.Add(Me.nameshow)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(529, 107)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(267, 260)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "แสดงเกรดที่ได้"
        '
        'gradeshow
        '
        Me.gradeshow.AutoSize = True
        Me.gradeshow.Location = New System.Drawing.Point(143, 231)
        Me.gradeshow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.gradeshow.Name = "gradeshow"
        Me.gradeshow.Size = New System.Drawing.Size(68, 17)
        Me.gradeshow.TabIndex = 11
        Me.gradeshow.Text = "..............."
        '
        'subshow
        '
        Me.subshow.AutoSize = True
        Me.subshow.Location = New System.Drawing.Point(143, 188)
        Me.subshow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.subshow.Name = "subshow"
        Me.subshow.Size = New System.Drawing.Size(68, 17)
        Me.subshow.TabIndex = 10
        Me.subshow.Text = "..............."
        '
        'codeshow
        '
        Me.codeshow.AutoSize = True
        Me.codeshow.Location = New System.Drawing.Point(143, 145)
        Me.codeshow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.codeshow.Name = "codeshow"
        Me.codeshow.Size = New System.Drawing.Size(68, 17)
        Me.codeshow.TabIndex = 9
        Me.codeshow.Text = "..............."
        '
        'idshow
        '
        Me.idshow.AutoSize = True
        Me.idshow.Location = New System.Drawing.Point(143, 103)
        Me.idshow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.idshow.Name = "idshow"
        Me.idshow.Size = New System.Drawing.Size(68, 17)
        Me.idshow.TabIndex = 8
        Me.idshow.Text = "..............."
        '
        'roomshow
        '
        Me.roomshow.AutoSize = True
        Me.roomshow.Location = New System.Drawing.Point(143, 70)
        Me.roomshow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.roomshow.Name = "roomshow"
        Me.roomshow.Size = New System.Drawing.Size(68, 17)
        Me.roomshow.TabIndex = 7
        Me.roomshow.Text = "..............."
        '
        'nameshow
        '
        Me.nameshow.AutoSize = True
        Me.nameshow.Location = New System.Drawing.Point(143, 30)
        Me.nameshow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nameshow.Name = "nameshow"
        Me.nameshow.Size = New System.Drawing.Size(68, 17)
        Me.nameshow.TabIndex = 6
        Me.nameshow.Text = "..............."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(57, 231)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 17)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "เกรดที่ได้ :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(75, 188)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 17)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "ชื่อวิชา :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(67, 145)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 17)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "รหัสวิชา :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(84, 103)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 17)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "เลขที่ :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 70)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 17)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "มัธยมศึกษาปีที่ : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(69, 30)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "ชื่อ-สกุล :"
        '
        'bt_sum
        '
        Me.bt_sum.Location = New System.Drawing.Point(319, 386)
        Me.bt_sum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_sum.Name = "bt_sum"
        Me.bt_sum.Size = New System.Drawing.Size(100, 28)
        Me.bt_sum.TabIndex = 14
        Me.bt_sum.Text = "รวมคะแนน"
        Me.bt_sum.UseVisualStyleBackColor = True
        '
        'txt_sum
        '
        Me.txt_sum.Location = New System.Drawing.Point(392, 350)
        Me.txt_sum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_sum.Name = "txt_sum"
        Me.txt_sum.ReadOnly = True
        Me.txt_sum.Size = New System.Drawing.Size(57, 22)
        Me.txt_sum.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(292, 353)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 17)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "คะแนนรวม : "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_final)
        Me.GroupBox3.Controls.Add(Me.txt_mid)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(288, 229)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(188, 114)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "คะแนนสอบ"
        '
        'txt_final
        '
        Me.txt_final.Location = New System.Drawing.Point(104, 74)
        Me.txt_final.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_final.Name = "txt_final"
        Me.txt_final.Size = New System.Drawing.Size(55, 22)
        Me.txt_final.TabIndex = 3
        '
        'txt_mid
        '
        Me.txt_mid.Location = New System.Drawing.Point(104, 30)
        Me.txt_mid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_mid.Name = "txt_mid"
        Me.txt_mid.Size = New System.Drawing.Size(55, 22)
        Me.txt_mid.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 78)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "ปลายภาค : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 33)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "กลางภาค : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_score3)
        Me.GroupBox2.Controls.Add(Me.txt_score2)
        Me.GroupBox2.Controls.Add(Me.txt_score1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 229)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(205, 162)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "คะแนนเก็บรายจุดประสงค์"
        '
        'txt_score3
        '
        Me.txt_score3.Location = New System.Drawing.Point(88, 113)
        Me.txt_score3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_score3.Name = "txt_score3"
        Me.txt_score3.Size = New System.Drawing.Size(85, 22)
        Me.txt_score3.TabIndex = 5
        '
        'txt_score2
        '
        Me.txt_score2.Location = New System.Drawing.Point(88, 70)
        Me.txt_score2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_score2.Name = "txt_score2"
        Me.txt_score2.Size = New System.Drawing.Size(85, 22)
        Me.txt_score2.TabIndex = 4
        '
        'txt_score1
        '
        Me.txt_score1.Location = New System.Drawing.Point(88, 30)
        Me.txt_score1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_score1.Name = "txt_score1"
        Me.txt_score1.Size = New System.Drawing.Size(85, 22)
        Me.txt_score1.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 117)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "หน่วยที่ 3 :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 74)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "หน่วยที่ 2 :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 33)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "หน่วยที่ 1 :"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(341, 164)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(41, 22)
        Me.txt_id.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(284, 167)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "เลขที่ :"
        '
        'txt_room
        '
        Me.txt_room.Location = New System.Drawing.Point(201, 164)
        Me.txt_room.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_room.Name = "txt_room"
        Me.txt_room.Size = New System.Drawing.Size(52, 22)
        Me.txt_room.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 167)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ระดับชั้นมัธยมศึกษาปีที่ :"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(172, 103)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(245, 22)
        Me.txt_name.TabIndex = 5
        '
        'cb_sub
        '
        Me.cb_sub.FormattingEnabled = True
        Me.cb_sub.Items.AddRange(New Object() {"เขียนแบบเบื้องต้น", "ฐานข้อมูลและมัลติมิเดีย"})
        Me.cb_sub.Location = New System.Drawing.Point(452, 32)
        Me.cb_sub.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_sub.Name = "cb_sub"
        Me.cb_sub.Size = New System.Drawing.Size(143, 24)
        Me.cb_sub.TabIndex = 4
        Me.cb_sub.Text = "กรุณาเลือกชื่อวิชา"
        '
        'cb_code
        '
        Me.cb_code.FormattingEnabled = True
        Me.cb_code.Items.AddRange(New Object() {"ว30293", "ว30288"})
        Me.cb_code.Location = New System.Drawing.Point(172, 32)
        Me.cb_code.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_code.Name = "cb_code"
        Me.cb_code.Size = New System.Drawing.Size(137, 24)
        Me.cb_code.TabIndex = 3
        Me.cb_code.Text = "กรุณาเลือกวิชา"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ชื่อ-สกุล (นักเรียน) : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(381, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อวิชา : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสวิชา : "
        '
        'cutgrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 465)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "cutgrade"
        Me.Text = "cutgrade"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_score3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_score2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_score1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_room As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents cb_sub As System.Windows.Forms.ComboBox
    Friend WithEvents cb_code As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents bt_sum As System.Windows.Forms.Button
    Friend WithEvents txt_sum As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_final As System.Windows.Forms.TextBox
    Friend WithEvents txt_mid As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents bt_cut As System.Windows.Forms.Button
    Friend WithEvents gradeshow As System.Windows.Forms.Label
    Friend WithEvents subshow As System.Windows.Forms.Label
    Friend WithEvents codeshow As System.Windows.Forms.Label
    Friend WithEvents idshow As System.Windows.Forms.Label
    Friend WithEvents roomshow As System.Windows.Forms.Label
    Friend WithEvents nameshow As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
