Imports FontAwesome.Sharp
Module Viewer
    Private currentBtn As IconButton
    Private currentBtn_Top As IconButton
    Private currentChildForm As Form
    Public Sub ActivateButton(senderBtn As Object)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.ForeColor = Color.FromArgb(255, 255, 50)
            currentBtn.IconColor = Color.FromArgb(255, 255, 50)
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
        End If
    End Sub
    Public Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(53, 69, 92) '53, 69, 92 '30; 30; 60
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Public Sub ActivateButton_Top(senderBtn As Object)
        If senderBtn IsNot Nothing Then
            DisableButton_Top()
            currentBtn_Top = CType(senderBtn, IconButton)
            currentBtn_Top.BackColor = Color.FromArgb(68, 89, 117)
        End If
    End Sub
    Public Sub DisableButton_Top()
        If currentBtn_Top IsNot Nothing Then
            currentBtn_Top.BackColor = Color.FromArgb(30, 30, 60) '53, 69, 92 '30; 30; 60
        End If
    End Sub
    Public Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        My.Forms.FormMenu.DashBoard.Controls.Add(childForm)
        My.Forms.FormMenu.DashBoard.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        My.Forms.FormMenu.lblFormTitle.Text = childForm.Text
    End Sub
End Module
