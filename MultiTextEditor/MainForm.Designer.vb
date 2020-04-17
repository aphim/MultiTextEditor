<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainForm))
        Me.mnuTopMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsTileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsOpenCarList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsAverageUnits = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttMultiTextEditor = New System.Windows.Forms.ToolTip(Me.components)
        Me.tsTool = New System.Windows.Forms.ToolStrip()
        Me.btnToolStripNew = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripOpen = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripSave = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripCarList = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripAverageUnits = New System.Windows.Forms.ToolStripButton()
        Me.mnuTopMenu.SuspendLayout()
        Me.tsTool.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuTopMenu
        '
        Me.mnuTopMenu.BackColor = System.Drawing.SystemColors.MenuBar
        Me.mnuTopMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuTopMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuWindows, Me.mnuHelp})
        Me.mnuTopMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuTopMenu.Name = "mnuTopMenu"
        Me.mnuTopMenu.Size = New System.Drawing.Size(850, 28)
        Me.mnuTopMenu.TabIndex = 5
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuFileClose, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(46, 24)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Image = CType(resources.GetObject("mnuFileNew.Image"), System.Drawing.Image)
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileNew.Text = "&New"
        Me.mnuFileNew.ToolTipText = "Create a new text file." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Image = CType(resources.GetObject("mnuFileOpen.Image"), System.Drawing.Image)
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileOpen.Text = "&Open"
        Me.mnuFileOpen.ToolTipText = "Open an existing text file."
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Image = CType(resources.GetObject("mnuFileSave.Image"), System.Drawing.Image)
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileSave.Text = "&Save"
        Me.mnuFileSave.ToolTipText = "Save the current text file under its current file name."
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileSaveAs.Text = "Save &As"
        Me.mnuFileSaveAs.ToolTipText = "Save the current text under new file name."
        '
        'mnuFileClose
        '
        Me.mnuFileClose.Name = "mnuFileClose"
        Me.mnuFileClose.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileClose.Text = "Close"
        Me.mnuFileClose.ToolTipText = "Closes the current text file."
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileExit.Text = "E&xit"
        Me.mnuFileExit.ToolTipText = "Exits the program."
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCopy, Me.mnuEditCut, Me.mnuEditPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(49, 24)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(177, 26)
        Me.mnuEditCopy.Text = "&Copy"
        Me.mnuEditCopy.ToolTipText = "Copy the selected text to clipboard."
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEditCut.Size = New System.Drawing.Size(177, 26)
        Me.mnuEditCut.Text = "Cu&t"
        Me.mnuEditCut.ToolTipText = "Cut the selected text to clipboard."
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(177, 26)
        Me.mnuEditPaste.Text = "&Paste"
        Me.mnuEditPaste.ToolTipText = "Paste the text in current clipboard."
        '
        'mnuWindows
        '
        Me.mnuWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWindowsCascade, Me.mnuWindowsTileVertical, Me.mnuWindowsTileHorizontal, Me.mnuWindowsOpenCarList, Me.mnuWindowsAverageUnits})
        Me.mnuWindows.Name = "mnuWindows"
        Me.mnuWindows.Size = New System.Drawing.Size(84, 24)
        Me.mnuWindows.Text = "&Windows"
        '
        'mnuWindowsCascade
        '
        Me.mnuWindowsCascade.Name = "mnuWindowsCascade"
        Me.mnuWindowsCascade.Size = New System.Drawing.Size(224, 26)
        Me.mnuWindowsCascade.Text = "Cascade"
        Me.mnuWindowsCascade.ToolTipText = "Cascade the open windows."
        '
        'mnuWindowsTileVertical
        '
        Me.mnuWindowsTileVertical.Name = "mnuWindowsTileVertical"
        Me.mnuWindowsTileVertical.Size = New System.Drawing.Size(224, 26)
        Me.mnuWindowsTileVertical.Text = "Tile Vertical"
        Me.mnuWindowsTileVertical.ToolTipText = "Align the open windows vertically."
        '
        'mnuWindowsTileHorizontal
        '
        Me.mnuWindowsTileHorizontal.Name = "mnuWindowsTileHorizontal"
        Me.mnuWindowsTileHorizontal.Size = New System.Drawing.Size(224, 26)
        Me.mnuWindowsTileHorizontal.Text = "Tile Horizontal"
        Me.mnuWindowsTileHorizontal.ToolTipText = "Align the open windows horizontally."
        '
        'mnuWindowsOpenCarList
        '
        Me.mnuWindowsOpenCarList.Image = CType(resources.GetObject("mnuWindowsOpenCarList.Image"), System.Drawing.Image)
        Me.mnuWindowsOpenCarList.Name = "mnuWindowsOpenCarList"
        Me.mnuWindowsOpenCarList.Size = New System.Drawing.Size(224, 26)
        Me.mnuWindowsOpenCarList.Text = "Open Car &List"
        Me.mnuWindowsOpenCarList.ToolTipText = "Opens a Car Inventory list window."
        '
        'mnuWindowsAverageUnits
        '
        Me.mnuWindowsAverageUnits.Image = CType(resources.GetObject("mnuWindowsAverageUnits.Image"), System.Drawing.Image)
        Me.mnuWindowsAverageUnits.Name = "mnuWindowsAverageUnits"
        Me.mnuWindowsAverageUnits.Size = New System.Drawing.Size(224, 26)
        Me.mnuWindowsAverageUnits.Text = "Open Average Units"
        Me.mnuWindowsAverageUnits.ToolTipText = "Opens a widow for the Average Units shipped by employees program."
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(55, 24)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(133, 26)
        Me.mnuHelpAbout.Text = "A&bout"
        '
        'tsTool
        '
        Me.tsTool.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnToolStripNew, Me.btnToolStripOpen, Me.btnToolStripSave, Me.btnToolStripCarList, Me.btnToolStripAverageUnits})
        Me.tsTool.Location = New System.Drawing.Point(0, 28)
        Me.tsTool.Name = "tsTool"
        Me.tsTool.Size = New System.Drawing.Size(850, 27)
        Me.tsTool.TabIndex = 7
        '
        'btnToolStripNew
        '
        Me.btnToolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripNew.Image = CType(resources.GetObject("btnToolStripNew.Image"), System.Drawing.Image)
        Me.btnToolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripNew.Name = "btnToolStripNew"
        Me.btnToolStripNew.Size = New System.Drawing.Size(29, 24)
        Me.btnToolStripNew.Text = "New"
        Me.btnToolStripNew.ToolTipText = "Create a new text file."
        '
        'btnToolStripOpen
        '
        Me.btnToolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripOpen.Image = CType(resources.GetObject("btnToolStripOpen.Image"), System.Drawing.Image)
        Me.btnToolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripOpen.Name = "btnToolStripOpen"
        Me.btnToolStripOpen.Size = New System.Drawing.Size(29, 24)
        Me.btnToolStripOpen.Text = "Open"
        Me.btnToolStripOpen.ToolTipText = "Open an existing text file."
        '
        'btnToolStripSave
        '
        Me.btnToolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripSave.Image = CType(resources.GetObject("btnToolStripSave.Image"), System.Drawing.Image)
        Me.btnToolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripSave.Name = "btnToolStripSave"
        Me.btnToolStripSave.Size = New System.Drawing.Size(29, 24)
        Me.btnToolStripSave.Text = "Save"
        Me.btnToolStripSave.ToolTipText = "SaveSave the current text file under its current file name."
        '
        'btnToolStripCarList
        '
        Me.btnToolStripCarList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripCarList.Image = CType(resources.GetObject("btnToolStripCarList.Image"), System.Drawing.Image)
        Me.btnToolStripCarList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripCarList.Name = "btnToolStripCarList"
        Me.btnToolStripCarList.Size = New System.Drawing.Size(29, 24)
        Me.btnToolStripCarList.Text = "Car List"
        Me.btnToolStripCarList.ToolTipText = "Opens a Car Inventory list window."
        '
        'btnToolStripAverageUnits
        '
        Me.btnToolStripAverageUnits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripAverageUnits.Image = CType(resources.GetObject("btnToolStripAverageUnits.Image"), System.Drawing.Image)
        Me.btnToolStripAverageUnits.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripAverageUnits.Name = "btnToolStripAverageUnits"
        Me.btnToolStripAverageUnits.Size = New System.Drawing.Size(29, 24)
        Me.btnToolStripAverageUnits.Text = "Average Units"
        Me.btnToolStripAverageUnits.ToolTipText = "Opens a widow for the Average Units shipped by employees program."
        '
        'frmMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 536)
        Me.Controls.Add(Me.tsTool)
        Me.Controls.Add(Me.mnuTopMenu)
        Me.IsMdiContainer = True
        Me.Name = "frmMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multi Text Editor"
        Me.mnuTopMenu.ResumeLayout(False)
        Me.mnuTopMenu.PerformLayout()
        Me.tsTool.ResumeLayout(False)
        Me.tsTool.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuTopMenu As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuFileClose As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuEditCut As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents mnuWindows As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents mnuWindowsCascade As ToolStripMenuItem
    Friend WithEvents mnuWindowsTileVertical As ToolStripMenuItem
    Friend WithEvents mnuWindowsTileHorizontal As ToolStripMenuItem
    Friend WithEvents mnuWindowsOpenCarList As ToolStripMenuItem
    Friend WithEvents ttMultiTextEditor As ToolTip
    Friend WithEvents tsTool As ToolStrip
    Friend WithEvents btnToolStripNew As ToolStripButton
    Friend WithEvents btnToolStripOpen As ToolStripButton
    Friend WithEvents btnToolStripSave As ToolStripButton
    Friend WithEvents mnuWindowsAverageUnits As ToolStripMenuItem
    Friend WithEvents btnToolStripCarList As ToolStripButton
    Friend WithEvents btnToolStripAverageUnits As ToolStripButton
End Class
