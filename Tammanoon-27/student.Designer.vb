<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student
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
        Me.Lname = New System.Windows.Forms.Label()
        Me.Llastname = New System.Windows.Forms.Label()
        Me.Lclass = New System.Windows.Forms.Label()
        Me.Lid = New System.Windows.Forms.Label()
        Me.Ltecher = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtch = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtclass = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.BTok = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.techarshow = New System.Windows.Forms.Label()
        Me.idshow = New System.Windows.Forms.Label()
        Me.classshow = New System.Windows.Forms.Label()
        Me.lastnameshow = New System.Windows.Forms.Label()
        Me.nameshow = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTshow = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lname
        '
        Me.Lname.AutoSize = True
        Me.Lname.Location = New System.Drawing.Point(25, 23)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(26, 13)
        Me.Lname.TabIndex = 0
        Me.Lname.Text = "ชื่อ :"
        '
        'Llastname
        '
        Me.Llastname.AutoSize = True
        Me.Llastname.Location = New System.Drawing.Point(174, 23)
        Me.Llastname.Name = "Llastname"
        Me.Llastname.Size = New System.Drawing.Size(52, 13)
        Me.Llastname.TabIndex = 1
        Me.Llastname.Text = "นามสกุล :"
        '
        'Lclass
        '
        Me.Lclass.AutoSize = True
        Me.Lclass.Location = New System.Drawing.Point(25, 82)
        Me.Lclass.Name = "Lclass"
        Me.Lclass.Size = New System.Drawing.Size(28, 13)
        Me.Lclass.TabIndex = 2
        Me.Lclass.Text = "ชั้น :"
        '
        'Lid
        '
        Me.Lid.AutoSize = True
        Me.Lid.Location = New System.Drawing.Point(189, 82)
        Me.Lid.Name = "Lid"
        Me.Lid.Size = New System.Drawing.Size(37, 13)
        Me.Lid.TabIndex = 3
        Me.Lid.Text = "เลขที่ :"
        '
        'Ltecher
        '
        Me.Ltecher.AutoSize = True
        Me.Ltecher.Location = New System.Drawing.Point(81, 136)
        Me.Ltecher.Name = "Ltecher"
        Me.Ltecher.Size = New System.Drawing.Size(66, 13)
        Me.Ltecher.TabIndex = 4
        Me.Ltecher.Text = "ครูที่ปรึกษา :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtch)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.txtclass)
        Me.GroupBox1.Controls.Add(Me.txtlastname)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Lname)
        Me.GroupBox1.Controls.Add(Me.Ltecher)
        Me.GroupBox1.Controls.Add(Me.Llastname)
        Me.GroupBox1.Controls.Add(Me.Lid)
        Me.GroupBox1.Controls.Add(Me.Lclass)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 206)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลนักเรียน"
        '
        'txtch
        '
        Me.txtch.Location = New System.Drawing.Point(153, 133)
        Me.txtch.Name = "txtch"
        Me.txtch.Size = New System.Drawing.Size(100, 20)
        Me.txtch.TabIndex = 9
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(232, 81)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 8
        '
        'txtclass
        '
        Me.txtclass.Location = New System.Drawing.Point(60, 82)
        Me.txtclass.Name = "txtclass"
        Me.txtclass.Size = New System.Drawing.Size(100, 20)
        Me.txtclass.TabIndex = 7
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(232, 23)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(100, 20)
        Me.txtlastname.TabIndex = 6
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(57, 23)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 5
        '
        'BTok
        '
        Me.BTok.Location = New System.Drawing.Point(214, 274)
        Me.BTok.Name = "BTok"
        Me.BTok.Size = New System.Drawing.Size(75, 23)
        Me.BTok.TabIndex = 6
        Me.BTok.Text = "ตกลง"
        Me.BTok.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.techarshow)
        Me.GroupBox2.Controls.Add(Me.idshow)
        Me.GroupBox2.Controls.Add(Me.classshow)
        Me.GroupBox2.Controls.Add(Me.lastnameshow)
        Me.GroupBox2.Controls.Add(Me.nameshow)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(534, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(193, 206)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "แสดงผล"
        '
        'techarshow
        '
        Me.techarshow.AutoSize = True
        Me.techarshow.Location = New System.Drawing.Point(100, 164)
        Me.techarshow.Name = "techarshow"
        Me.techarshow.Size = New System.Drawing.Size(52, 13)
        Me.techarshow.TabIndex = 9
        Me.techarshow.Text = "..............."
        '
        'idshow
        '
        Me.idshow.AutoSize = True
        Me.idshow.Location = New System.Drawing.Point(100, 134)
        Me.idshow.Name = "idshow"
        Me.idshow.Size = New System.Drawing.Size(52, 13)
        Me.idshow.TabIndex = 8
        Me.idshow.Text = "..............."
        '
        'classshow
        '
        Me.classshow.AutoSize = True
        Me.classshow.Location = New System.Drawing.Point(100, 101)
        Me.classshow.Name = "classshow"
        Me.classshow.Size = New System.Drawing.Size(52, 13)
        Me.classshow.TabIndex = 7
        Me.classshow.Text = "..............."
        '
        'lastnameshow
        '
        Me.lastnameshow.AutoSize = True
        Me.lastnameshow.Location = New System.Drawing.Point(100, 68)
        Me.lastnameshow.Name = "lastnameshow"
        Me.lastnameshow.Size = New System.Drawing.Size(52, 13)
        Me.lastnameshow.TabIndex = 6
        Me.lastnameshow.Text = "..............."
        '
        'nameshow
        '
        Me.nameshow.AutoSize = True
        Me.nameshow.Location = New System.Drawing.Point(100, 33)
        Me.nameshow.Name = "nameshow"
        Me.nameshow.Size = New System.Drawing.Size(52, 13)
        Me.nameshow.TabIndex = 5
        Me.nameshow.Text = "..............."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ครูที่ปรึกษา :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "เลขที่ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ชั้น :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "นามสกุล :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อ :"
        '
        'BTshow
        '
        Me.BTshow.Location = New System.Drawing.Point(588, 274)
        Me.BTshow.Name = "BTshow"
        Me.BTshow.Size = New System.Drawing.Size(75, 23)
        Me.BTshow.TabIndex = 8
        Me.BTshow.Text = "แสดงผล"
        Me.BTshow.UseVisualStyleBackColor = True
        '
        'student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 339)
        Me.Controls.Add(Me.BTshow)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BTok)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "student"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lname As System.Windows.Forms.Label
    Friend WithEvents Llastname As System.Windows.Forms.Label
    Friend WithEvents Lclass As System.Windows.Forms.Label
    Friend WithEvents Lid As System.Windows.Forms.Label
    Friend WithEvents Ltecher As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtch As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtclass As System.Windows.Forms.TextBox
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents BTok As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents techarshow As System.Windows.Forms.Label
    Friend WithEvents idshow As System.Windows.Forms.Label
    Friend WithEvents classshow As System.Windows.Forms.Label
    Friend WithEvents lastnameshow As System.Windows.Forms.Label
    Friend WithEvents nameshow As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTshow As System.Windows.Forms.Button

End Class
