Public Class FormMenu
    Private Sub IconButton12_Click(sender As Object, e As EventArgs) Handles IconButton12.Click
        ShowSubmenu(Painel_Financeiro)
        ActivateButton_Top(sender)
    End Sub
    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        ShowSubmenu(Painel_Produtos)
        ActivateButton_Top(sender)
    End Sub
    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles IconButton1.Click
        ShowSubmenu(Painel_Clientes)
        ActivateButton_Top(sender)
    End Sub
    Private Sub IconButton9_Click_1(sender As Object, e As EventArgs) Handles IconButton9.Click
        ShowSubmenu(Painel_Caixa)
        ActivateButton_Top(sender)
    End Sub
    Private Sub ShowSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            Esconder_paineis()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub
    Private Sub Esconder_paineis()
        Painel_Clientes.Visible = False
        Painel_Produtos.Visible = False
        Painel_Caixa.Visible = False
        Painel_Financeiro.Visible = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Esconder_paineis()
    End Sub
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        ActivateButton(sender)
        OpenChildForm(New Form1)
    End Sub
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        ActivateButton(sender)
    End Sub
    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        ActivateButton(sender)
    End Sub
    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        ActivateButton(sender)
    End Sub
    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        ActivateButton(sender)
    End Sub
    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        ActivateButton(sender)
    End Sub
    Private Sub IconButton11_Click(sender As Object, e As EventArgs) Handles IconButton11.Click
        ActivateButton(sender)
    End Sub

    Private Sub IconButton10_Click(sender As Object, e As EventArgs) Handles IconButton10.Click
        ActivateButton(sender)
    End Sub

    Private Sub IconButton13_Click(sender As Object, e As EventArgs) Handles IconButton13.Click
        ActivateButton(sender)
    End Sub
End Class
