<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsByEmployee
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
        Me.components = New System.ComponentModel.Container()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtInputBox = New System.Windows.Forms.TextBox()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.txtEmployee1Units = New System.Windows.Forms.TextBox()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.lblEmployee1Average = New System.Windows.Forms.Label()
        Me.txtEmployee2Units = New System.Windows.Forms.TextBox()
        Me.txtEmployee3Units = New System.Windows.Forms.TextBox()
        Me.lblEmployee2Average = New System.Windows.Forms.Label()
        Me.lblEmployee3Average = New System.Windows.Forms.Label()
        Me.lblOverallAverage = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.AverageUnitsShippedToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(22, 21)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(50, 18)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = " Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.Location = New System.Drawing.Point(26, 52)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(46, 18)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInputBox
        '
        Me.txtInputBox.Location = New System.Drawing.Point(78, 52)
        Me.txtInputBox.Multiline = True
        Me.txtInputBox.Name = "txtInputBox"
        Me.txtInputBox.Size = New System.Drawing.Size(59, 22)
        Me.txtInputBox.TabIndex = 2
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.txtInputBox, "Textbox used for adding shipment entries for each employee.")
        '
        'lblEmployee1
        '
        Me.lblEmployee1.AutoSize = True
        Me.lblEmployee1.Location = New System.Drawing.Point(26, 92)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee 1"
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmployee1Units
        '
        Me.txtEmployee1Units.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmployee1Units.Location = New System.Drawing.Point(12, 112)
        Me.txtEmployee1Units.Multiline = True
        Me.txtEmployee1Units.Name = "txtEmployee1Units"
        Me.txtEmployee1Units.ReadOnly = True
        Me.txtEmployee1Units.Size = New System.Drawing.Size(125, 144)
        Me.txtEmployee1Units.TabIndex = 4
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.txtEmployee1Units, "List of shipment entries for employee 1.")
        '
        'lblEmployee2
        '
        Me.lblEmployee2.AutoSize = True
        Me.lblEmployee2.Location = New System.Drawing.Point(173, 92)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee2.TabIndex = 6
        Me.lblEmployee2.Text = "Employee 2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee3
        '
        Me.lblEmployee3.AutoSize = True
        Me.lblEmployee3.Location = New System.Drawing.Point(316, 92)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee3.TabIndex = 9
        Me.lblEmployee3.Text = "Employee 3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee1Average
        '
        Me.lblEmployee1Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee1Average.Location = New System.Drawing.Point(12, 260)
        Me.lblEmployee1Average.Name = "lblEmployee1Average"
        Me.lblEmployee1Average.Size = New System.Drawing.Size(125, 23)
        Me.lblEmployee1Average.TabIndex = 5
        Me.lblEmployee1Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lblEmployee1Average, "Average Units shipped for employee 1.")
        '
        'txtEmployee2Units
        '
        Me.txtEmployee2Units.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmployee2Units.Location = New System.Drawing.Point(153, 112)
        Me.txtEmployee2Units.Multiline = True
        Me.txtEmployee2Units.Name = "txtEmployee2Units"
        Me.txtEmployee2Units.ReadOnly = True
        Me.txtEmployee2Units.Size = New System.Drawing.Size(125, 144)
        Me.txtEmployee2Units.TabIndex = 7
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.txtEmployee2Units, "List of shipment entries for employee 2.")
        '
        'txtEmployee3Units
        '
        Me.txtEmployee3Units.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmployee3Units.Location = New System.Drawing.Point(294, 112)
        Me.txtEmployee3Units.Multiline = True
        Me.txtEmployee3Units.Name = "txtEmployee3Units"
        Me.txtEmployee3Units.ReadOnly = True
        Me.txtEmployee3Units.Size = New System.Drawing.Size(124, 144)
        Me.txtEmployee3Units.TabIndex = 10
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.txtEmployee3Units, "List of shipment entries for employee 3.")
        '
        'lblEmployee2Average
        '
        Me.lblEmployee2Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee2Average.Location = New System.Drawing.Point(153, 260)
        Me.lblEmployee2Average.Name = "lblEmployee2Average"
        Me.lblEmployee2Average.Size = New System.Drawing.Size(125, 23)
        Me.lblEmployee2Average.TabIndex = 8
        Me.lblEmployee2Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lblEmployee2Average, "Average Units shipped for employee 2.")
        '
        'lblEmployee3Average
        '
        Me.lblEmployee3Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee3Average.Location = New System.Drawing.Point(295, 260)
        Me.lblEmployee3Average.Name = "lblEmployee3Average"
        Me.lblEmployee3Average.Size = New System.Drawing.Size(123, 23)
        Me.lblEmployee3Average.TabIndex = 11
        Me.lblEmployee3Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lblEmployee3Average, "Average Units shipped for employee 3.")
        '
        'lblOverallAverage
        '
        Me.lblOverallAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverallAverage.Location = New System.Drawing.Point(12, 295)
        Me.lblOverallAverage.Name = "lblOverallAverage"
        Me.lblOverallAverage.Size = New System.Drawing.Size(406, 23)
        Me.lblOverallAverage.TabIndex = 12
        Me.lblOverallAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lblOverallAverage, "overall average daily units shipped.")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 335)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(125, 23)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnEnter, "Enters input for current employee.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(153, 335)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(125, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnReset, "Clears application.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(295, 335)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnExit, "Exits application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(430, 372)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblOverallAverage)
        Me.Controls.Add(Me.lblEmployee3Average)
        Me.Controls.Add(Me.lblEmployee2Average)
        Me.Controls.Add(Me.txtEmployee3Units)
        Me.Controls.Add(Me.txtEmployee2Units)
        Me.Controls.Add(Me.lblEmployee1Average)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.txtEmployee1Units)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.txtInputBox)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDay As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtInputBox As TextBox
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents txtEmployee1Units As TextBox
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents lblEmployee1Average As Label
    Friend WithEvents txtEmployee2Units As TextBox
    Friend WithEvents txtEmployee3Units As TextBox
    Friend WithEvents lblEmployee2Average As Label
    Friend WithEvents lblEmployee3Average As Label
    Friend WithEvents lblOverallAverage As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents AverageUnitsShippedToolTip As ToolTip
End Class
