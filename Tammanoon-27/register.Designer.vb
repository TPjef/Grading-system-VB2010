<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Me.BT_clear = New System.Windows.Forms.Button()
        Me.BT_edit = New System.Windows.Forms.Button()
        Me.BT_delete = New System.Windows.Forms.Button()
        Me.BT_save = New System.Windows.Forms.Button()
        Me.txt_sub = New System.Windows.Forms.TextBox()
        Me.txt_gender = New System.Windows.Forms.TextBox()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BT_clear)
        Me.GroupBox1.Controls.Add(Me.BT_edit)
        Me.GroupBox1.Controls.Add(Me.BT_delete)
        Me.GroupBox1.Controls.Add(Me.BT_save)
        Me.GroupBox1.Controls.Add(Me.txt_sub)
        Me.GroupBox1.Controls.Add(Me.txt_gender)
        Me.GroupBox1.Controls.Add(Me.txt_lname)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 250)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ลงทะเบียนเรียน"
        '
        'BT_clear
        '
        Me.BT_clear.Location = New System.Drawing.Point(239, 167)
        Me.BT_clear.Name = "BT_clear"
        Me.BT_clear.Size = New System.Drawing.Size(75, 23)
        Me.BT_clear.TabIndex = 13
        Me.BT_clear.Text = "ล้างข้อมูล"
        Me.BT_clear.UseVisualStyleBackColor = True
        '
        'BT_edit
        '
        Me.BT_edit.Location = New System.Drawing.Point(239, 133)
        Me.BT_edit.Name = "BT_edit"
        Me.BT_edit.Size = New System.Drawing.Size(75, 23)
        Me.BT_edit.TabIndex = 12
        Me.BT_edit.Text = "แก้ไข"
        Me.BT_edit.UseVisualStyleBackColor = True
        '
        'BT_delete
        '
        Me.BT_delete.Location = New System.Drawing.Point(239, 95)
        Me.BT_delete.Name = "BT_delete"
        Me.BT_delete.Size = New System.Drawing.Size(75, 23)
        Me.BT_delete.TabIndex = 11
        Me.BT_delete.Text = "ลบข้อมูล"
        Me.BT_delete.UseVisualStyleBackColor = True
        '
        'BT_save
        '
        Me.BT_save.Location = New System.Drawing.Point(239, 57)
        Me.BT_save.Name = "BT_save"
        Me.BT_save.Size = New System.Drawing.Size(75, 23)
        Me.BT_save.TabIndex = 10
        Me.BT_save.Text = "บันทึก"
        Me.BT_save.UseVisualStyleBackColor = True
        '
        'txt_sub
        '
        Me.txt_sub.Location = New System.Drawing.Point(106, 187)
        Me.txt_sub.Name = "txt_sub"
        Me.txt_sub.Size = New System.Drawing.Size(100, 20)
        Me.txt_sub.TabIndex = 9
        '
        'txt_gender
        '
        Me.txt_gender.Location = New System.Drawing.Point(106, 153)
        Me.txt_gender.Name = "txt_gender"
        Me.txt_gender.Size = New System.Drawing.Size(100, 20)
        Me.txt_gender.TabIndex = 8
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(105, 114)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(100, 20)
        Me.txt_lname.TabIndex = 7
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(105, 78)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 6
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(106, 40)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ชื่อวิชา  : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "เพศ  : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "สกุล  : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อ  : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสนักเรียน : "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(424, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(310, 225)
        Me.DataGridView1.TabIndex = 1
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 314)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "register"
        Me.Text = "register"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BT_clear As System.Windows.Forms.Button
    Friend WithEvents BT_edit As System.Windows.Forms.Button
    Friend WithEvents BT_delete As System.Windows.Forms.Button
    Friend WithEvents BT_save As System.Windows.Forms.Button
    Friend WithEvents txt_sub As System.Windows.Forms.TextBox
    Friend WithEvents txt_gender As System.Windows.Forms.TextBox
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
