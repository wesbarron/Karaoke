'Program Name: Karaoke - Wesley Barron

Option Strict On
Public Class frmKaraoke
    Private _decSong As Decimal = 2.99D
    Private _decHourlyRate As Decimal = 8.99D
    Private Sub frmKaraoke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Splash Screen - Sleep for splash screen
        Threading.Thread.Sleep(3000)
        ClearForm()
    End Sub

    Private Function ValidateInput() As Boolean
        'Fx that validates the input
        Dim intNumber As Integer
        Dim blnValid As Boolean = False
        Try
            intNumber = Convert.ToInt32(txtBoxQnty.Text)
            If intNumber > 0D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please enter a number greater than 0", , "Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter a valid amount", , "Error")
        Catch Exception As OverflowException
            MsgBox("Please enter a reasonable amount", , "Error")
        Catch Exception As SystemException
            MsgBox("Entry invalid. Please enter a valid number representing the number in your party", , "Error")
        End Try
        ' Focus on text box
        txtBoxQnty.Focus()
        txtBoxQnty.Clear()
        Return blnValid
    End Function

    Private Function ComputeSongCost(ByVal intPass As Integer) As Decimal
        Dim decPassCost As Decimal
        decPassCost = intPass * _decSong
        Return decPassCost
    End Function

    Private Function ComputeRoomCost(ByVal intPass As Integer) As Decimal
        Dim decTicketCost As Decimal
        decTicketCost = intPass * _decHourlyRate
        Return decTicketCost
    End Function

    Private Sub ClearForm()
        'Clear the form
        comboBoxMain.SelectedIndex = -1
        lblTotalCost.Visible = False
        lblRoomRate.Visible = False
        txtBoxQnty.Visible = False
        btnClear.Visible = False
        btnTotal.Visible = False
        txtBoxQnty.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim blnAmountIsValid As Boolean = False
        Dim intValue As Integer
        Dim decTotal As Decimal
        ' Validate function called
        blnAmountIsValid = ValidateInput()
        If blnAmountIsValid = True Then
            ' Assign 
            intValue = Convert.ToInt32(txtBoxQnty.Text)
            If comboBoxMain.SelectedIndex = 0 Then
                decTotal = ComputeSongCost(intValue)
            Else
                decTotal = ComputeRoomCost(intValue)
            End If
        End If
        lblTotalCost.Visible = True
        lblTotalCost.Text = "Total Cost of Karaoke Night - " & decTotal.ToString("C")
    End Sub

    Private Sub comboBoxMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxMain.SelectedIndexChanged
        If comboBoxMain.SelectedIndex = 0 Then
            lblRoomRate.Text = "Number of Karaoke Songs"
            lblRoomRate.Visible = True
            txtBoxQnty.Visible = True
            btnTotal.Visible = True
            btnClear.Visible = True
            txtBoxQnty.Focus()
        End If
        If comboBoxMain.SelectedIndex = 1 Then
            lblRoomRate.Text = "Hourly Rental of Karaoke Room:"
            lblRoomRate.Visible = True
            txtBoxQnty.Visible = True
            btnTotal.Visible = True
            btnClear.Visible = True
            txtBoxQnty.Focus()
        End If
    End Sub
End Class
