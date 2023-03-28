<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCatering = New System.Windows.Forms.Label()
        Me.lblStarMarket = New System.Windows.Forms.Label()
        Me.GrpBxSelection = New System.Windows.Forms.GroupBox()
        Me.radbtnGourmetCheese = New System.Windows.Forms.RadioButton()
        Me.radbtnPinwheelWraps = New System.Windows.Forms.RadioButton()
        Me.radbtnVeggie = New System.Windows.Forms.RadioButton()
        Me.radbtnSausageandCheese = New System.Windows.Forms.RadioButton()
        Me.radbtnFruit = New System.Windows.Forms.RadioButton()
        Me.GrpbxPaymentSelection = New System.Windows.Forms.GroupBox()
        Me.radbtnPrePay = New System.Windows.Forms.RadioButton()
        Me.radbtnPayuponPickup = New System.Windows.Forms.RadioButton()
        Me.lblPleasePay = New System.Windows.Forms.Label()
        Me.lblLoyaltyPoints = New System.Windows.Forms.Label()
        Me.txtbxenterpoints = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblDisplayPrice = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBxSelection.SuspendLayout()
        Me.GrpbxPaymentSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Catering_App.My.Resources.Resources.platter
        Me.PictureBox1.Location = New System.Drawing.Point(425, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(571, 337)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblCatering
        '
        Me.lblCatering.AutoSize = True
        Me.lblCatering.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatering.Location = New System.Drawing.Point(55, 18)
        Me.lblCatering.Name = "lblCatering"
        Me.lblCatering.Size = New System.Drawing.Size(128, 29)
        Me.lblCatering.TabIndex = 1
        Me.lblCatering.Text = "Catering"
        '
        'lblStarMarket
        '
        Me.lblStarMarket.AutoSize = True
        Me.lblStarMarket.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStarMarket.Location = New System.Drawing.Point(53, 64)
        Me.lblStarMarket.Name = "lblStarMarket"
        Me.lblStarMarket.Size = New System.Drawing.Size(145, 24)
        Me.lblStarMarket.TabIndex = 2
        Me.lblStarMarket.Text = "Star Market"
        '
        'GrpBxSelection
        '
        Me.GrpBxSelection.BackColor = System.Drawing.Color.FloralWhite
        Me.GrpBxSelection.Controls.Add(Me.radbtnFruit)
        Me.GrpBxSelection.Controls.Add(Me.radbtnSausageandCheese)
        Me.GrpBxSelection.Controls.Add(Me.radbtnVeggie)
        Me.GrpBxSelection.Controls.Add(Me.radbtnPinwheelWraps)
        Me.GrpBxSelection.Controls.Add(Me.radbtnGourmetCheese)
        Me.GrpBxSelection.Location = New System.Drawing.Point(4, 194)
        Me.GrpBxSelection.Name = "GrpBxSelection"
        Me.GrpBxSelection.Size = New System.Drawing.Size(400, 245)
        Me.GrpBxSelection.TabIndex = 3
        Me.GrpBxSelection.TabStop = False
        '
        'radbtnGourmetCheese
        '
        Me.radbtnGourmetCheese.AutoSize = True
        Me.radbtnGourmetCheese.Location = New System.Drawing.Point(14, 25)
        Me.radbtnGourmetCheese.Name = "radbtnGourmetCheese"
        Me.radbtnGourmetCheese.Size = New System.Drawing.Size(244, 23)
        Me.radbtnGourmetCheese.TabIndex = 0
        Me.radbtnGourmetCheese.TabStop = True
        Me.radbtnGourmetCheese.Text = "Gourmet Cheese $49.99"
        Me.radbtnGourmetCheese.UseVisualStyleBackColor = True
        '
        'radbtnPinwheelWraps
        '
        Me.radbtnPinwheelWraps.AutoSize = True
        Me.radbtnPinwheelWraps.Location = New System.Drawing.Point(14, 69)
        Me.radbtnPinwheelWraps.Name = "radbtnPinwheelWraps"
        Me.radbtnPinwheelWraps.Size = New System.Drawing.Size(245, 23)
        Me.radbtnPinwheelWraps.TabIndex = 1
        Me.radbtnPinwheelWraps.TabStop = True
        Me.radbtnPinwheelWraps.Text = "Pinwheel Wraps $59.99"
        Me.radbtnPinwheelWraps.UseVisualStyleBackColor = True
        '
        'radbtnVeggie
        '
        Me.radbtnVeggie.AutoSize = True
        Me.radbtnVeggie.Location = New System.Drawing.Point(14, 114)
        Me.radbtnVeggie.Name = "radbtnVeggie"
        Me.radbtnVeggie.Size = New System.Drawing.Size(155, 23)
        Me.radbtnVeggie.TabIndex = 2
        Me.radbtnVeggie.TabStop = True
        Me.radbtnVeggie.Text = "Veggie $29.99"
        Me.radbtnVeggie.UseVisualStyleBackColor = True
        '
        'radbtnSausageandCheese
        '
        Me.radbtnSausageandCheese.AutoSize = True
        Me.radbtnSausageandCheese.Location = New System.Drawing.Point(14, 163)
        Me.radbtnSausageandCheese.Name = "radbtnSausageandCheese"
        Me.radbtnSausageandCheese.Size = New System.Drawing.Size(277, 23)
        Me.radbtnSausageandCheese.TabIndex = 3
        Me.radbtnSausageandCheese.TabStop = True
        Me.radbtnSausageandCheese.Text = "Sausage and Cheese $49.99"
        Me.radbtnSausageandCheese.UseVisualStyleBackColor = True
        '
        'radbtnFruit
        '
        Me.radbtnFruit.AutoSize = True
        Me.radbtnFruit.Location = New System.Drawing.Point(14, 202)
        Me.radbtnFruit.Name = "radbtnFruit"
        Me.radbtnFruit.Size = New System.Drawing.Size(86, 23)
        Me.radbtnFruit.TabIndex = 4
        Me.radbtnFruit.TabStop = True
        Me.radbtnFruit.Text = "Fruit"
        Me.radbtnFruit.UseVisualStyleBackColor = True
        '
        'GrpbxPaymentSelection
        '
        Me.GrpbxPaymentSelection.BackColor = System.Drawing.Color.FloralWhite
        Me.GrpbxPaymentSelection.Controls.Add(Me.radbtnPayuponPickup)
        Me.GrpbxPaymentSelection.Controls.Add(Me.radbtnPrePay)
        Me.GrpbxPaymentSelection.Location = New System.Drawing.Point(125, 481)
        Me.GrpbxPaymentSelection.Name = "GrpbxPaymentSelection"
        Me.GrpbxPaymentSelection.Size = New System.Drawing.Size(229, 110)
        Me.GrpbxPaymentSelection.TabIndex = 4
        Me.GrpbxPaymentSelection.TabStop = False
        '
        'radbtnPrePay
        '
        Me.radbtnPrePay.AutoSize = True
        Me.radbtnPrePay.Location = New System.Drawing.Point(13, 25)
        Me.radbtnPrePay.Name = "radbtnPrePay"
        Me.radbtnPrePay.Size = New System.Drawing.Size(105, 23)
        Me.radbtnPrePay.TabIndex = 0
        Me.radbtnPrePay.TabStop = True
        Me.radbtnPrePay.Text = "Pre-Pay"
        Me.radbtnPrePay.UseVisualStyleBackColor = True
        '
        'radbtnPayuponPickup
        '
        Me.radbtnPayuponPickup.AutoSize = True
        Me.radbtnPayuponPickup.Location = New System.Drawing.Point(13, 71)
        Me.radbtnPayuponPickup.Name = "radbtnPayuponPickup"
        Me.radbtnPayuponPickup.Size = New System.Drawing.Size(187, 23)
        Me.radbtnPayuponPickup.TabIndex = 1
        Me.radbtnPayuponPickup.TabStop = True
        Me.radbtnPayuponPickup.Text = "Pay upon Pickup"
        Me.radbtnPayuponPickup.UseVisualStyleBackColor = True
        '
        'lblPleasePay
        '
        Me.lblPleasePay.AutoSize = True
        Me.lblPleasePay.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleasePay.Location = New System.Drawing.Point(131, 633)
        Me.lblPleasePay.Name = "lblPleasePay"
        Me.lblPleasePay.Size = New System.Drawing.Size(140, 24)
        Me.lblPleasePay.TabIndex = 5
        Me.lblPleasePay.Text = "Please Pay:"
        '
        'lblLoyaltyPoints
        '
        Me.lblLoyaltyPoints.AutoSize = True
        Me.lblLoyaltyPoints.Location = New System.Drawing.Point(540, 428)
        Me.lblLoyaltyPoints.Name = "lblLoyaltyPoints"
        Me.lblLoyaltyPoints.Size = New System.Drawing.Size(151, 19)
        Me.lblLoyaltyPoints.TabIndex = 6
        Me.lblLoyaltyPoints.Text = "Loyalty Points"
        '
        'txtbxenterpoints
        '
        Me.txtbxenterpoints.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtbxenterpoints.Location = New System.Drawing.Point(799, 428)
        Me.txtbxenterpoints.Name = "txtbxenterpoints"
        Me.txtbxenterpoints.Size = New System.Drawing.Size(66, 26)
        Me.txtbxenterpoints.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCalculate.Location = New System.Drawing.Point(521, 552)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(131, 39)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(779, 552)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(131, 39)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblDisplayPrice
        '
        Me.lblDisplayPrice.AutoSize = True
        Me.lblDisplayPrice.Location = New System.Drawing.Point(411, 638)
        Me.lblDisplayPrice.Name = "lblDisplayPrice"
        Me.lblDisplayPrice.Size = New System.Drawing.Size(162, 19)
        Me.lblDisplayPrice.TabIndex = 10
        Me.lblDisplayPrice.Text = "lblDisplayPrice"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(1008, 691)
        Me.Controls.Add(Me.lblDisplayPrice)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtbxenterpoints)
        Me.Controls.Add(Me.lblLoyaltyPoints)
        Me.Controls.Add(Me.lblPleasePay)
        Me.Controls.Add(Me.GrpbxPaymentSelection)
        Me.Controls.Add(Me.GrpBxSelection)
        Me.Controls.Add(Me.lblStarMarket)
        Me.Controls.Add(Me.lblCatering)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Stencil", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catering"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBxSelection.ResumeLayout(False)
        Me.GrpBxSelection.PerformLayout()
        Me.GrpbxPaymentSelection.ResumeLayout(False)
        Me.GrpbxPaymentSelection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCatering As Label
    Friend WithEvents lblStarMarket As Label
    Friend WithEvents GrpBxSelection As GroupBox
    Friend WithEvents radbtnFruit As RadioButton
    Friend WithEvents radbtnSausageandCheese As RadioButton
    Friend WithEvents radbtnVeggie As RadioButton
    Friend WithEvents radbtnPinwheelWraps As RadioButton
    Friend WithEvents radbtnGourmetCheese As RadioButton
    Friend WithEvents GrpbxPaymentSelection As GroupBox
    Friend WithEvents radbtnPayuponPickup As RadioButton
    Friend WithEvents radbtnPrePay As RadioButton
    Friend WithEvents lblPleasePay As Label
    Friend WithEvents lblLoyaltyPoints As Label
    Friend WithEvents txtbxenterpoints As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblDisplayPrice As Label
End Class
