<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKaraoke
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKaraoke))
        Me.lblMain = New System.Windows.Forms.Label()
        Me.comboBoxMain = New System.Windows.Forms.ComboBox()
        Me.lblRoomRate = New System.Windows.Forms.Label()
        Me.txtBoxQnty = New System.Windows.Forms.TextBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.picBoxMain = New System.Windows.Forms.PictureBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.picBoxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(509, 21)
        Me.lblMain.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(382, 42)
        Me.lblMain.TabIndex = 0
        Me.lblMain.Text = "Karaoke Music Night"
        '
        'comboBoxMain
        '
        Me.comboBoxMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxMain.FormattingEnabled = True
        Me.comboBoxMain.Items.AddRange(New Object() {"Number of Songs ($2.99 per song)", "Hours in Private Karaoke Booth ($8.99 per hour)"})
        Me.comboBoxMain.Location = New System.Drawing.Point(461, 94)
        Me.comboBoxMain.Name = "comboBoxMain"
        Me.comboBoxMain.Size = New System.Drawing.Size(476, 28)
        Me.comboBoxMain.TabIndex = 1
        '
        'lblRoomRate
        '
        Me.lblRoomRate.AutoSize = True
        Me.lblRoomRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomRate.Location = New System.Drawing.Point(523, 150)
        Me.lblRoomRate.Name = "lblRoomRate"
        Me.lblRoomRate.Size = New System.Drawing.Size(350, 25)
        Me.lblRoomRate.TabIndex = 2
        Me.lblRoomRate.Text = "Hourly Rental of Karaoke Room:"
        '
        'txtBoxQnty
        '
        Me.txtBoxQnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxQnty.Location = New System.Drawing.Point(674, 210)
        Me.txtBoxQnty.Name = "txtBoxQnty"
        Me.txtBoxQnty.Size = New System.Drawing.Size(58, 35)
        Me.txtBoxQnty.TabIndex = 3
        '
        'btnTotal
        '
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTotal.Location = New System.Drawing.Point(461, 296)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(204, 49)
        Me.btnTotal.TabIndex = 4
        Me.btnTotal.Text = "Total Cost"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(733, 296)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(204, 49)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'picBoxMain
        '
        Me.picBoxMain.Image = CType(resources.GetObject("picBoxMain.Image"), System.Drawing.Image)
        Me.picBoxMain.InitialImage = CType(resources.GetObject("picBoxMain.InitialImage"), System.Drawing.Image)
        Me.picBoxMain.Location = New System.Drawing.Point(-3, -2)
        Me.picBoxMain.Name = "picBoxMain"
        Me.picBoxMain.Size = New System.Drawing.Size(414, 629)
        Me.picBoxMain.TabIndex = 6
        Me.picBoxMain.TabStop = False
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(494, 415)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(397, 25)
        Me.lblTotalCost.TabIndex = 7
        Me.lblTotalCost.Text = "Total Cost of Karaoke Night - $00.00"
        '
        'frmKaraoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(977, 495)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.picBoxMain)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.txtBoxQnty)
        Me.Controls.Add(Me.lblRoomRate)
        Me.Controls.Add(Me.comboBoxMain)
        Me.Controls.Add(Me.lblMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "frmKaraoke"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karaoke Music Night"
        CType(Me.picBoxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMain As Label
    Friend WithEvents comboBoxMain As ComboBox
    Friend WithEvents lblRoomRate As Label
    Friend WithEvents txtBoxQnty As TextBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents picBoxMain As PictureBox
    Friend WithEvents lblTotalCost As Label
End Class
