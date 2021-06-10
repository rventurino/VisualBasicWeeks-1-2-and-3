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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.gbTicketsSold = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTicket_c_qty = New System.Windows.Forms.TextBox()
        Me.txtTicket_b_qty = New System.Windows.Forms.TextBox()
        Me.txtTicket_a_qty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbRevenue = New System.Windows.Forms.GroupBox()
        Me.curRevTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.curRevC = New System.Windows.Forms.TextBox()
        Me.curRevB = New System.Windows.Forms.TextBox()
        Me.curRevA = New System.Windows.Forms.TextBox()
        Me.btnCalcRevenue = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbTicketsSold.SuspendLayout()
        Me.gbRevenue.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTicketsSold
        '
        Me.gbTicketsSold.BackColor = System.Drawing.Color.Turquoise
        Me.gbTicketsSold.Controls.Add(Me.Label4)
        Me.gbTicketsSold.Controls.Add(Me.Label3)
        Me.gbTicketsSold.Controls.Add(Me.Label2)
        Me.gbTicketsSold.Controls.Add(Me.txtTicket_c_qty)
        Me.gbTicketsSold.Controls.Add(Me.txtTicket_b_qty)
        Me.gbTicketsSold.Controls.Add(Me.txtTicket_a_qty)
        Me.gbTicketsSold.Controls.Add(Me.Label1)
        Me.gbTicketsSold.Location = New System.Drawing.Point(12, 44)
        Me.gbTicketsSold.Name = "gbTicketsSold"
        Me.gbTicketsSold.Size = New System.Drawing.Size(375, 302)
        Me.gbTicketsSold.TabIndex = 0
        Me.gbTicketsSold.TabStop = False
        Me.gbTicketsSold.Text = "Tickets Sold"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Class C"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Class B"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Class A"
        '
        'txtTicket_c_qty
        '
        Me.txtTicket_c_qty.Location = New System.Drawing.Point(147, 238)
        Me.txtTicket_c_qty.Name = "txtTicket_c_qty"
        Me.txtTicket_c_qty.Size = New System.Drawing.Size(100, 23)
        Me.txtTicket_c_qty.TabIndex = 3
        '
        'txtTicket_b_qty
        '
        Me.txtTicket_b_qty.Location = New System.Drawing.Point(147, 165)
        Me.txtTicket_b_qty.Name = "txtTicket_b_qty"
        Me.txtTicket_b_qty.Size = New System.Drawing.Size(100, 23)
        Me.txtTicket_b_qty.TabIndex = 2
        '
        'txtTicket_a_qty
        '
        Me.txtTicket_a_qty.Location = New System.Drawing.Point(147, 92)
        Me.txtTicket_a_qty.Name = "txtTicket_a_qty"
        Me.txtTicket_a_qty.Size = New System.Drawing.Size(100, 23)
        Me.txtTicket_a_qty.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the number of tickets sold for each class pls"
        '
        'gbRevenue
        '
        Me.gbRevenue.BackColor = System.Drawing.Color.Fuchsia
        Me.gbRevenue.Controls.Add(Me.curRevTotal)
        Me.gbRevenue.Controls.Add(Me.Label9)
        Me.gbRevenue.Controls.Add(Me.Label6)
        Me.gbRevenue.Controls.Add(Me.Label7)
        Me.gbRevenue.Controls.Add(Me.Label5)
        Me.gbRevenue.Controls.Add(Me.curRevC)
        Me.gbRevenue.Controls.Add(Me.curRevB)
        Me.gbRevenue.Controls.Add(Me.curRevA)
        Me.gbRevenue.Location = New System.Drawing.Point(443, 44)
        Me.gbRevenue.Name = "gbRevenue"
        Me.gbRevenue.Size = New System.Drawing.Size(301, 302)
        Me.gbRevenue.TabIndex = 1
        Me.gbRevenue.TabStop = False
        Me.gbRevenue.Text = "Revenue Generated"
        '
        'curRevTotal
        '
        Me.curRevTotal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.curRevTotal.Location = New System.Drawing.Point(147, 250)
        Me.curRevTotal.Name = "curRevTotal"
        Me.curRevTotal.Size = New System.Drawing.Size(100, 23)
        Me.curRevTotal.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 15)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Total Revenue"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Class C"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Class B"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Class A"
        '
        'curRevC
        '
        Me.curRevC.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.curRevC.Location = New System.Drawing.Point(147, 211)
        Me.curRevC.Name = "curRevC"
        Me.curRevC.Size = New System.Drawing.Size(100, 23)
        Me.curRevC.TabIndex = 3
        '
        'curRevB
        '
        Me.curRevB.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.curRevB.Location = New System.Drawing.Point(147, 165)
        Me.curRevB.Name = "curRevB"
        Me.curRevB.Size = New System.Drawing.Size(100, 23)
        Me.curRevB.TabIndex = 2
        '
        'curRevA
        '
        Me.curRevA.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.curRevA.Location = New System.Drawing.Point(147, 92)
        Me.curRevA.Name = "curRevA"
        Me.curRevA.Size = New System.Drawing.Size(100, 23)
        Me.curRevA.TabIndex = 1
        '
        'btnCalcRevenue
        '
        Me.btnCalcRevenue.BackColor = System.Drawing.Color.Green
        Me.btnCalcRevenue.Location = New System.Drawing.Point(12, 352)
        Me.btnCalcRevenue.Name = "btnCalcRevenue"
        Me.btnCalcRevenue.Size = New System.Drawing.Size(304, 53)
        Me.btnCalcRevenue.TabIndex = 2
        Me.btnCalcRevenue.Text = "Calculate Revenue"
        Me.btnCalcRevenue.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Maroon
        Me.btnClear.Location = New System.Drawing.Point(322, 352)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(182, 53)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnExit.Location = New System.Drawing.Point(510, 352)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(234, 53)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbRevenue)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcRevenue)
        Me.Controls.Add(Me.gbTicketsSold)
        Me.Name = "Form1"
        Me.Text = "Stadium Seating"
        Me.gbTicketsSold.ResumeLayout(False)
        Me.gbTicketsSold.PerformLayout()
        Me.gbRevenue.ResumeLayout(False)
        Me.gbRevenue.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbTicketsSold As GroupBox
    Friend WithEvents txtTicket_c_qty As TextBox
    Friend WithEvents txtTicket_b_qty As TextBox
    Friend WithEvents txtTicket_a_qty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gbRevenue As GroupBox
    Friend WithEvents curRevTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents curRevC As TextBox
    Friend WithEvents curRevB As TextBox
    Friend WithEvents curRevA As TextBox
    Friend WithEvents btnCalcRevenue As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
