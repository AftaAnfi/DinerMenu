Option Strict On
Option Explicit On
'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Diner Menu Program
'https://github.com/AftaAnfi/DinerMenu.git

Public Class DinerMenuForm



    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


    Sub ChangeSpecialLabel(ByVal labelString As String)

        DisplaySpecialLabel.Text = labelString

    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click

        ChangeSpecialLabel($"~Soup of the day~ {vbNewLine} {vbNewLine} A delicious soup made " &
                           "of soup based ingredients such as water and salt.")

    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        ChangeSpecialLabel($"~Doug's Special Salad~ {vbNewLine} {vbNewLine} " &
                            $"A bowl with lettuce and house dressing{vbNewLine}{vbNewLine} Optional: Cheese")

    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        ChangeSpecialLabel($"~Fallout Tuna~ {vbNewLine} {vbNewLine} " &
                            $"An opened can of tuna from the 50's served with a lemon. {vbNewLine}{vbNewLine}It's still fresh!")

    End Sub
End Class
