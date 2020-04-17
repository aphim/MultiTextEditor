<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextEditor
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
        Me.mnuSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.mnuOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.txtTextField = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'mnuSaveFileDialog
        '
        Me.mnuSaveFileDialog.DefaultExt = "txt"
        Me.mnuSaveFileDialog.Title = "Save"
        '
        'mnuOpenFileDialog
        '
        Me.mnuOpenFileDialog.DefaultExt = "txt"
        Me.mnuOpenFileDialog.FileName = "OpenFileDialog"
        Me.mnuOpenFileDialog.Title = "Open"
        '
        'txtTextField
        '
        Me.txtTextField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTextField.Location = New System.Drawing.Point(0, 0)
        Me.txtTextField.Name = "txtTextField"
        Me.txtTextField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtTextField.Size = New System.Drawing.Size(892, 479)
        Me.txtTextField.TabIndex = 1
        Me.txtTextField.Text = ""
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(892, 479)
        Me.Controls.Add(Me.txtTextField)
        Me.Name = "frmTextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mnuSaveFileDialog As SaveFileDialog
    Friend WithEvents mnuOpenFileDialog As OpenFileDialog
    Friend WithEvents txtTextField As RichTextBox
End Class
