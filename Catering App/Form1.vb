Option Strict On
Option Explicit On


Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'What events happen when user uses the calculate button.

        Dim decPoints As Decimal
        Dim decPrice As Decimal
        Dim decFinalCost As Decimal
        Dim cdecDiscount As Decimal = 5D
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strPoints As String = ""
        Dim intPoints As Integer

        If IsNumeric(txtbxenterpoints.Text) Then
            intPoints = Convert.ToInt32(txtbxenterpoints.Text)
            strPoints = "after discount of " & intPoints.ToString() & "Loyalty Points."
            MsgBox(intPoints)



            If radbtnGourmetCheese.Checked Then
                decPrice = 49.99D
                strOrder = "Cheese"
            ElseIf radbtnPinwheelWraps.Checked Then
                decPrice = 59.99D
                strOrder = "Wrap"
            ElseIf radbtnVeggie.Checked Then
                decPrice = 29.99D
                strOrder = "Veggie"
            ElseIf radbtnSausageandCheese.Checked Then
                decPrice = 49.99D
                strOrder = "Sausage and Cheese"
            ElseIf radbtnFruit.Checked Then
                decPrice = 29.99D
                strOrder = "Fruit"
            End If
            If radbtnPrePay.Checked Then
                strPay = "Pre-Pay Selected"
            ElseIf radbtnPayuponPickup.Checked Then
                strPay = "Pay Upon Pickup Selected"
            End If

            intPoints = Convert.ToInt32(intPoints / 10I)
            MsgBox(decPoints)

            decPoints = (intPoints * cdecDiscount) / 100
            MsgBox(decPoints)
            If decPoints > 1 Then
                decPoints = 1

            End If

            MsgBox(decPoints)

            decFinalCost = decPrice * (1 - decPoints)
            MsgBox(decFinalCost)

            lblDisplayPrice.Text = "Your order" & strOrder & "platter costs" & decFinalCost.ToString("C") & strPay & strPoints
        Else
            MsgBox("Error! ",, "Valid Number Of Points Needed!")
            Me.btnClear.PerformClick()

        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        txtbxenterpoints.Text = ""
        txtbxenterpoints.Focus()
        lblDisplayPrice.Text = ""
        radbtnFruit.Checked = False
        radbtnGourmetCheese.Checked = True
        radbtnPayuponPickup.Checked = False
        radbtnPinwheelWraps.Checked = False
        radbtnPrePay.Checked = True
        radbtnSausageandCheese.Checked = False
        radbtnVeggie.Checked = False

    End Sub
End Class
