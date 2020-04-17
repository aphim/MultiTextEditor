'**********************************************************************************************************************************
'Program:           Multi Text Editor
'Created by:        Jacky Yuan, 100520106
'Date Created:      04/16/2020
'Purpose:           This program will function as a MDI text editor, allowing to open multiple textfiles as well as opening
'                   a car inventory and average units shipped program.
'
'Changes:           N/A
'
'**********************************************************************************************************************************


Option Strict On
Imports System.IO
Public Class frmMainForm
    ''' <summary>
    ''' Cascades the opened child windows
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowsCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowsCascade.Click

        Me.LayoutMdi(MdiLayout.Cascade)

    End Sub
    ''' <summary>
    ''' Aligns the open child windows vertically
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowsTileVertical_Click(sender As Object, e As EventArgs) Handles mnuWindowsTileVertical.Click

        Me.LayoutMdi(MdiLayout.TileVertical)

    End Sub
    ''' <summary>
    ''' Aligns the open child windows horizontally
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowsTileHorizontal_Click(sender As Object, e As EventArgs) Handles mnuWindowsTileHorizontal.Click

        Me.LayoutMdi(MdiLayout.TileHorizontal)

    End Sub
    ''' <summary>
    ''' Calls the copying function from the texteditor file. Will not work if the activechild is not a texteditor.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        'checks if it is a texteditor active and then calls the editcopy function
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).EditCopy()
        Else
            MessageBox.Show("Cannot copy from the current selected window")
        End If

    End Sub
    ''' <summary>
    ''' Calls the cut function from the texteditor file. Will not work if the activechild is not a texteditor.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        'checks if it is a texteditor active and then calls the editcut function
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).EditCut()
        Else
            MessageBox.Show("Cannot cut from the current selected window")
        End If
    End Sub
    ''' <summary>
    ''' Calls the paste function from the texteditor file. Will not work if the activechild is not a texteditor.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        'checks if it is a texteditor active and then calls the editpaste function
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).EditPaste()
        Else
            MessageBox.Show("Cannot paste into the current selected window")
        End If
    End Sub
    ''' <summary>
    ''' Calls the save function from the texteditor file. Will not work if the activechild is not a texteditor.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        'checks if it is a texteditor active and then calls the filesave function
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).FileSave()
        Else
            MessageBox.Show("Cannot save the current selected window")
        End If

    End Sub
    ''' <summary>
    ''' Calls the save as function from the texteditor file. Will not work if the activechild is not a texteditor.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        'checks if it is a texteditor active and then calls the filesaveas function
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).FileSaveAs()
        Else
            MessageBox.Show("Cannot save the current selected window")
        End If
    End Sub
    ''' <summary>
    ''' Closes the current activechild form. If the activechild is a texteditor, it will call the exit function to check for edits.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        'checks if there are mdichildren open
        If MdiChildren.Count > 0 Then
            'if it is a texteditor, call its fileExit function
            If TypeOf (ActiveMdiChild) Is frmTextEditor Then
                CType(ActiveMdiChild, frmTextEditor).FileExit()
            Else
                'otherwise close the window
                ActiveMdiChild.Close()
            End If
        Else
            MessageBox.Show("There is no window to close")
        End If
    End Sub
    ''' <summary>
    ''' Exits the program. Checks to see if there are open pages and will ask the user for confirmation if pages are open.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'checks if there are child forms open
        If MdiChildren.Count > 0 Then
            'gives message box for confirmation if there are forms still open
            If MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo) =
                DialogResult.Yes Then

                Me.Close()
            End If
        Else
            'closes application
            Me.Close()
        End If
    End Sub
    ''' <summary>
    ''' Creates an new instance of a textfile.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        Dim myTextEditor As New frmTextEditor
        myTextEditor.MdiParent = Me
        myTextEditor.Show()
    End Sub
    ''' <summary>
    ''' Displays messagebox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("NETD 2202" & vbCrLf & vbCrLf & "Lab #6" & vbCrLf & vbCrLf & "J. Yuan", "About")
    End Sub
    ''' <summary>
    ''' Opens an existing textfile for use in a new testeditor instance.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        Dim openFile As New OpenFileDialog
        Dim fileLocation As String

        'Opens the file selection box
        openFile.ShowDialog()
        'saves the selected file into the file name variable
        fileLocation = openFile.FileName

        'checks if a file name has been selected or has been made
        If Not fileLocation = String.Empty Then
            'reads the selected file and outputs the data into the program textfield
            Dim reader As New StreamReader(fileLocation)
            Dim myTextEditor As New frmTextEditor
            'sets the text field as the read text
            myTextEditor.txtTextField.Text = reader.ReadToEnd()
            reader.Close()
            myTextEditor.MdiParent = Me
            myTextEditor.Show()
            'modify the editor's title
            myTextEditor.Text = "Text Editor " & fileLocation
        End If

    End Sub
    ''' <summary>
    ''' Creates an new instance of a textfile.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnToolStripNew_Click(sender As Object, e As EventArgs) Handles btnToolStripNew.Click
        Dim myTextEditor As New frmTextEditor
        myTextEditor.MdiParent = Me
        myTextEditor.Show()
    End Sub
    ''' <summary>
    ''' Opens an existing textfile for use in a new testeditor instance.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnToolStripOpen_Click(sender As Object, e As EventArgs) Handles btnToolStripOpen.Click
        Dim openFile As New OpenFileDialog
        openFile.Filter = "Text|.txt|All|.*"
        Dim fileLocation As String

        'Opens the file selection box
        openFile.ShowDialog()
        'saves the selected file into the file name variable
        fileLocation = openFile.FileName

        'checks if a file name has been selected or has been made
        If Not fileLocation = String.Empty Then
            'reads the selected file and outputs the data into the program textfield
            Dim reader As New StreamReader(fileLocation)
            Dim myTextEditor As New frmTextEditor
            'sets the text field as the read text
            myTextEditor.txtTextField.Text = reader.ReadToEnd()
            reader.Close()
            myTextEditor.MdiParent = Me
            myTextEditor.Show()
            'modify the editor's title
            myTextEditor.Text = "Text Editor " & fileLocation
        End If
    End Sub
    ''' <summary>
    ''' Calls the save function from the texteditor file. Will not work if the activechild is not a texteditor.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnToolStripSave_Click(sender As Object, e As EventArgs) Handles btnToolStripSave.Click
        'checks if it is a texteditor active and then calls the filesavefunction
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).FileSave()
        Else
            MessageBox.Show("Cannot save the current selected window")
        End If
    End Sub
    ''' <summary>
    ''' Opens an instance of the program Car Inventory in new window.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowsOpenCarList_Click(sender As Object, e As EventArgs) Handles mnuWindowsOpenCarList.Click

        Dim myCarInventory As New frmCarInventory
            myCarInventory.MdiParent = Me
        myCarInventory.Show()
    End Sub
    ''' <summary>
    ''' Opens an instance of the program Average Units by Employee in new window.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowsAverageUnits_Click(sender As Object, e As EventArgs) Handles mnuWindowsAverageUnits.Click

        Dim myAverageUnits As New frmAverageUnitsByEmployee
        myAverageUnits.MdiParent = Me
        myAverageUnits.Show()

    End Sub
    ''' <summary>
    ''' Opens an instance of the program Average Units by Employee in new window.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnToolStripAverageUnits_Click(sender As Object, e As EventArgs) Handles btnToolStripAverageUnits.Click
        Dim myAverageUnits As New frmAverageUnitsByEmployee
        myAverageUnits.MdiParent = Me
        myAverageUnits.Show()
    End Sub
    ''' <summary>
    ''' Opens an instance of the program Car Inventory in new window.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnToolStripCarList_Click(sender As Object, e As EventArgs) Handles btnToolStripCarList.Click

        Dim myCarInventory As New frmCarInventory
            myCarInventory.MdiParent = Me
            myCarInventory.Show()

    End Sub
End Class
