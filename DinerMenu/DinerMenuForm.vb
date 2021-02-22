Option Strict On
Option Explicit On
'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Diner Menu Program
'https://github.com/AftaAnfi/DinerMenu.git

Public Class DinerMenuForm

    'event when exit button is pressed -> close program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'sub to change the DisplaySpecialLabel showing information about selected dish
    Sub ChangeSpecialLabel(ByVal labelString As String)
        DisplaySpecialLabel.Text = labelString
    End Sub

    'SoupButton event to change DisplaySpecialLabel and enable other buttons while disabling soup
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click

        ChangeSpecialLabel($"~Soup of the day~ {vbNewLine} {vbNewLine} A delicious soup made " &
                           "of soup based ingredients such as water and salt.")
        SoupButton.Enabled = False
        SaladButton.Enabled = True
        FishButton.Enabled = True
    End Sub

    'SaladButton event has been pressed, changes DisplaySpecialLabel and disables 
    'SaladButton while enabling other option buttons
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        ChangeSpecialLabel($"~Doug's Special Salad~ {vbNewLine} {vbNewLine} " &
                            $"A bowl with lettuce and house dressing{vbNewLine}{vbNewLine} Optional: Cheese")
        SoupButton.Enabled = True
        SaladButton.Enabled = False
        FishButton.Enabled = True
    End Sub

    'FishButton has been pressed, changes DisplaySpecialLabel to fish and
    'disables the FishButton but enables other special buttons
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        ChangeSpecialLabel($"~Fallout Tuna~ {vbNewLine} {vbNewLine} " &
                            $"An opened can of tuna from the 50's served with a lemon. {vbNewLine}{vbNewLine}It's still fresh!")
        SoupButton.Enabled = True
        SaladButton.Enabled = True
        FishButton.Enabled = False
    End Sub



End Class
