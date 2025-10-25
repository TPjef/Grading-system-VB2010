<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTsd = New System.Windows.Forms.Button()
        Me.closeSD = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.เมนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ขอมลนกเรยนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.บนทกขอมลนกเรยนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ลงทะเบยนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.เข้าสู่ระบบToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.สมัครสมาชิกToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ผลการเรยนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ตัดเกรดToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ขอมลผจดทำToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ประวตผจดทำToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(355, 45)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1052, 435)
        Me.Panel1.TabIndex = 0
        '
        'BTsd
        '
        Me.BTsd.Location = New System.Drawing.Point(95, 30)
        Me.BTsd.Margin = New System.Windows.Forms.Padding(4)
        Me.BTsd.Name = "BTsd"
        Me.BTsd.Size = New System.Drawing.Size(113, 28)
        Me.BTsd.TabIndex = 1
        Me.BTsd.Text = "ข้อมูลนักเรียน"
        Me.BTsd.UseVisualStyleBackColor = True
        '
        'closeSD
        '
        Me.closeSD.Location = New System.Drawing.Point(104, 439)
        Me.closeSD.Margin = New System.Windows.Forms.Padding(4)
        Me.closeSD.Name = "closeSD"
        Me.closeSD.Size = New System.Drawing.Size(100, 28)
        Me.closeSD.TabIndex = 2
        Me.closeSD.Text = "ปิด"
        Me.closeSD.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 86)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ตัดเกรด"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'เมนToolStripMenuItem
        '
        Me.เมนToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.เมนToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ขอมลนกเรยนToolStripMenuItem, Me.ผลการเรยนToolStripMenuItem})
        Me.เมนToolStripMenuItem.Name = "เมนToolStripMenuItem"
        Me.เมนToolStripMenuItem.Size = New System.Drawing.Size(42, 24)
        Me.เมนToolStripMenuItem.Text = "เมนู"
        '
        'ขอมลนกเรยนToolStripMenuItem
        '
        Me.ขอมลนกเรยนToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.บนทกขอมลนกเรยนToolStripMenuItem, Me.ลงทะเบยนToolStripMenuItem})
        Me.ขอมลนกเรยนToolStripMenuItem.Name = "ขอมลนกเรยนToolStripMenuItem"
        Me.ขอมลนกเรยนToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.ขอมลนกเรยนToolStripMenuItem.Text = "1.ข้อมูลนักเรียน"
        '
        'บนทกขอมลนกเรยนToolStripMenuItem
        '
        Me.บนทกขอมลนกเรยนToolStripMenuItem.Name = "บนทกขอมลนกเรยนToolStripMenuItem"
        Me.บนทกขอมลนกเรยนToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.บนทกขอมลนกเรยนToolStripMenuItem.Text = "บันทึกข้อมูลนักเรียน"
        '
        'ลงทะเบยนToolStripMenuItem
        '
        Me.ลงทะเบยนToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.เข้าสู่ระบบToolStripMenuItem2, Me.สมัครสมาชิกToolStripMenuItem})
        Me.ลงทะเบยนToolStripMenuItem.Name = "ลงทะเบยนToolStripMenuItem"
        Me.ลงทะเบยนToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.ลงทะเบยนToolStripMenuItem.Text = "ระบบสมาชิก"
        '
        'เข้าสู่ระบบToolStripMenuItem2
        '
        Me.เข้าสู่ระบบToolStripMenuItem2.Name = "เข้าสู่ระบบToolStripMenuItem2"
        Me.เข้าสู่ระบบToolStripMenuItem2.Size = New System.Drawing.Size(161, 24)
        Me.เข้าสู่ระบบToolStripMenuItem2.Text = "1.เข้าสู่ระบบ"
        '
        'สมัครสมาชิกToolStripMenuItem
        '
        Me.สมัครสมาชิกToolStripMenuItem.Name = "สมัครสมาชิกToolStripMenuItem"
        Me.สมัครสมาชิกToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.สมัครสมาชิกToolStripMenuItem.Text = "2.สมัครสมาชิก"
        '
        'ผลการเรยนToolStripMenuItem
        '
        Me.ผลการเรยนToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ตัดเกรดToolStripMenuItem1})
        Me.ผลการเรยนToolStripMenuItem.Name = "ผลการเรยนToolStripMenuItem"
        Me.ผลการเรยนToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.ผลการเรยนToolStripMenuItem.Text = "2.ผลการเรียน"
        '
        'ตัดเกรดToolStripMenuItem1
        '
        Me.ตัดเกรดToolStripMenuItem1.Name = "ตัดเกรดToolStripMenuItem1"
        Me.ตัดเกรดToolStripMenuItem1.Size = New System.Drawing.Size(124, 24)
        Me.ตัดเกรดToolStripMenuItem1.Text = "ตัดเกรด"
        '
        'ขอมลผจดทำToolStripMenuItem
        '
        Me.ขอมลผจดทำToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ขอมลผจดทำToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ประวตผจดทำToolStripMenuItem})
        Me.ขอมลผจดทำToolStripMenuItem.Name = "ขอมลผจดทำToolStripMenuItem"
        Me.ขอมลผจดทำToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.ขอมลผจดทำToolStripMenuItem.Text = "ข้อมูลผู้จัดทำ"
        '
        'ประวตผจดทำToolStripMenuItem
        '
        Me.ประวตผจดทำToolStripMenuItem.Name = "ประวตผจดทำToolStripMenuItem"
        Me.ประวตผจดทำToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.ประวตผจดทำToolStripMenuItem.Text = "ประวัติผู้จัดทำ"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.เมนToolStripMenuItem, Me.ขอมลผจดทำToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1425, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1425, 495)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.closeSD)
        Me.Controls.Add(Me.BTsd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "main"
        Me.Text = "main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BTsd As System.Windows.Forms.Button
    Friend WithEvents closeSD As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents เมนToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ขอมลนกเรยนToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents บนทกขอมลนกเรยนToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ผลการเรยนToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ตัดเกรดToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ขอมลผจดทำToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ประวตผจดทำToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ลงทะเบยนToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents เข้าสู่ระบบToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents สมัครสมาชิกToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
