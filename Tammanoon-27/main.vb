Public Class main

    Private Sub BTsd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTsd.Click
        Dim std As New student
        Panel1.Controls.Clear()
        std.TopLevel = False
        Panel1.Controls.Add(std)
        std.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        std.Dock = DockStyle.Fill
        std.Show()

    End Sub
    Private Sub closeSD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeSD.Click
        Panel1.Controls.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim std As New cutgrade
        Panel1.Controls.Clear()
        std.TopLevel = False
        Panel1.Controls.Add(std)
        std.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        std.Dock = DockStyle.Fill
        std.Show()

    End Sub
    Private Sub บนทกขอมลนกเรยนToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles บนทกขอมลนกเรยนToolStripMenuItem.Click
        Dim std As New student
        Panel1.Controls.Clear()
        std.TopLevel = False
        Panel1.Controls.Add(std)
        std.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        std.Dock = DockStyle.Fill
        std.Show()
    End Sub
    Private Sub ตัดเกรดToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ตัดเกรดToolStripMenuItem1.Click
        Dim cg As New cutgrade
        Panel1.Controls.Clear()
        cg.TopLevel = False
        Panel1.Controls.Add(cg)
        cg.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        cg.Dock = DockStyle.Fill
        cg.Show()
    End Sub
    Private Sub ประวตผจดทำToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ประวตผจดทำToolStripMenuItem.Click
        Dim pr As New profile
        Panel1.Controls.Clear()
        pr.TopLevel = False
        Panel1.Controls.Add(pr)
        pr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        pr.Dock = DockStyle.Fill
        pr.Show()
    End Sub

    Private Sub เข้าสู่ระบบToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles เข้าสู่ระบบToolStripMenuItem2.Click
        Dim li As New login
        Panel1.Controls.Clear()
        li.TopLevel = False
        Panel1.Controls.Add(li)
        li.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        li.Dock = DockStyle.Fill
        li.Show()
    End Sub

    Private Sub สมัครสมาชิกToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles สมัครสมาชิกToolStripMenuItem.Click
        Dim rgt As New register
        Panel1.Controls.Clear()
        rgt.TopLevel = False
        Panel1.Controls.Add(rgt)
        rgt.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        rgt.Dock = DockStyle.Fill
        rgt.Show()
    End Sub
End Class