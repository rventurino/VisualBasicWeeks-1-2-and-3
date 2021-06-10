<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtPrompt1 = New System.Windows.Forms.Label()
        Me.txtPrompt2 = New System.Windows.Forms.Label()
        Me.btnCalcSale = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.Location = New System.Drawing.Point(67, 72)
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.Size = New System.Drawing.Size(100, 23)
        Me.txtRetailPrice.TabIndex = 0
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(313, 72)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(80, 15)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "Totalgoeshere"
        '
        'txtPrompt1
        '
        Me.txtPrompt1.AutoSize = True
        Me.txtPrompt1.Location = New System.Drawing.Point(67, 41)
        Me.txtPrompt1.Name = "txtPrompt1"
        Me.txtPrompt1.Size = New System.Drawing.Size(68, 15)
        Me.txtPrompt1.TabIndex = 2
        Me.txtPrompt1.Text = "Retail Price:"
        '
        'txtPrompt2
        '
        Me.txtPrompt2.AutoSize = True
        Me.txtPrompt2.Location = New System.Drawing.Point(313, 40)
        Me.txtPrompt2.Name = "txtPrompt2"
        Me.txtPrompt2.Size = New System.Drawing.Size(67, 15)
        Me.txtPrompt2.TabIndex = 3
        Me.txtPrompt2.Text = "Final Price: "
        '
        'btnCalcSale
        '
        Me.btnCalcSale.Location = New System.Drawing.Point(210, 143)
        Me.btnCalcSale.Name = "btnCalcSale"
        Me.btnCalcSale.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcSale.TabIndex = 4
        Me.btnCalcSale.Text = "Calculate total"
        Me.btnCalcSale.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 291)
        Me.Controls.Add(Me.btnCalcSale)
        Me.Controls.Add(Me.txtPrompt2)
        Me.Controls.Add(Me.txtPrompt1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtRetailPrice)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRetailPrice As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtPrompt1 As Label
    Friend WithEvents txtPrompt2 As Label
    Friend WithEvents btnCalcSale As Button
End Class
