'**********************************************************************************************************************************
'Program:           Text Editor
'Created by:        Jacky Yuan, 100520106
'Date Created:      03/31/2020
'Purpose:           This program will function as a simple text editor, allowing the user to make a new document, edit an existing
'                   text file, same the text file, save under a different name or to close and discard the changes.
'
'Changes:           N/A
'
'**********************************************************************************************************************************
Option Strict On
Imports System.IO
Public Class frmTextEditor
    'creates a global variable that will be used to store the name of the current file
    Dim fileName As String
    'creates a flag to store if changes were made in the file
    Dim fileEdited As Boolean = False

    ''' <summary>
    ''' Functions that run on load of the program. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmTextEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sets the program title to "Text Editor Select a File to Open"
        Me.Text = "Text Editor Select a File to Open"
    End Sub
    ''' <summary>
    ''' Sets the flag to true if changes were made in the textfield.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtTextField_TextChanged(sender As Object, e As EventArgs) Handles txtTextField.TextChanged
        fileEdited = True
        Me.Text = "Text Editor "
    End Sub

    ''' <summary>
    ''' calls the filenew function
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuNew_Click(sender As Object, e As EventArgs)
        FileNew()
    End Sub
    ''' <summary>
    ''' Function for the menu button "New"; creates a new blank document, clearing the existing data in the program and loses any changes not saved.
    ''' </summary>
    Friend Sub FileNew()
        'calls the ConfirmClose function
        ConfirmClose()
        'checks if the fileEdited flag is false
        If fileEdited = False Then
            'sets the file name to blank
            fileName = String.Empty
            'sets the text field back to blank
            txtTextField.Text = String.Empty
            'removes the file path from the title of the program
            Me.Text = "Text Editor "
            'enables the textfield if it has been disabled
            txtTextField.Enabled = True
            'sets fileEdited flag to false
            fileEdited = False
        End If
    End Sub

    ''' <summary>
    ''' calls the fileopen function
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuOpen_Click(sender As Object, e As EventArgs)
        FileOpen()
    End Sub
    ''' <summary>
    ''' Function for the menu button "Open"; opens a selection menu that allows the user to select a text file to open for editing.
    ''' </summary>
    Friend Sub FileOpen()
        'calls the ConfirmClose function
        ConfirmClose()
        'checks if the fileEdited flag is false
        If fileEdited = False Then
            'declare variables for the file name and openfile process
            Dim openFile As New OpenFileDialog
            Dim fileLocation As String
            'enables the textfield if it has been disabled
            txtTextField.Enabled = True
            'Opens the file selection box
            openFile.ShowDialog()
            'saves the selected file into the file name variable
            fileLocation = openFile.FileName

            'checks if a file name has been selected or has been made
            If Not fileLocation = String.Empty Then
                'reads the selected file and outputs the data into the program textfield
                Dim reader As New StreamReader(fileLocation)
                txtTextField.Text = reader.ReadToEnd()
                reader.Close()
            End If
            'saves the selected file name into the global file name variable
            fileName = fileLocation
            'add the file path to the program title
            Me.Text = "Text Editor " & fileName
            'sets fileEdited flag to false
            fileEdited = False
        End If
    End Sub

    ''' <summary>
    ''' calls the filesave function
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuSave_Click(sender As Object, e As EventArgs)
        FileSave()
    End Sub
    ''' <summary>
    ''' Function for the menu button "Save"; saves the current data in the current file name. If a file name doesn't currently exist, it will prompt the user
    ''' to save under an existing file name or create new file name similar to the save as function.
    ''' </summary>
    Friend Sub FileSave()
        'declare variables for the file name and savefile process
        Dim saveAsFile As New SaveFileDialog
        saveAsFile.Filter = "Text|.txt|All|.*"
        Dim saveFileName As String
        'checks if the current file has a file name
        If Not fileName = String.Empty Then
            'If the file name exists, the current data is saved under its current file name
            Dim writer As New StreamWriter(fileName)
            writer.Write(txtTextField.Text)
            writer.Close()
        Else
            'displays the save as selection window
            saveAsFile.ShowDialog()
            saveFileName = saveAsFile.FileName
            'checks if a file name is selected or created
            If Not saveFileName = String.Empty Then
                'saves the data under the selected or created file name
                Dim writer As New StreamWriter(saveFileName)
                writer.Write(txtTextField.Text)
                writer.Close()
            End If
            'sets the global file name to be the selected or created file name
            fileName = saveFileName
            'adds the current file path to program title
            Me.Text = "Text Editor " & fileName
        End If
        fileEdited = False

    End Sub

    ''' <summary>
    ''' calls the file save as function
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs)
        FileSaveAs()
    End Sub
    ''' <summary>
    ''' Function for the menu button "Save As"; opens a new window allowing the user to select an existing file or create a new file to save the current data in.
    ''' </summary>
    Friend Sub FileSaveAs()
        'declare variables for the file name and savefile process
        Dim saveAsFile As New SaveFileDialog
        Dim saveFileName As String
        'displays the save as selection window
        saveAsFile.ShowDialog()
        saveFileName = saveAsFile.FileName
        'checks if a file has been selected or created
        If Not saveFileName = String.Empty Then
            'writes current data into the selected file name
            Dim writer As New StreamWriter(saveFileName)
            writer.Write(txtTextField.Text)
            writer.Close()
        End If
        'sets the global file name to be the selected or created file name
        fileName = saveFileName
        'adds the current file path to program title
        Me.Text = "Text Editor " & fileName
        fileEdited = False
    End Sub

    ''' <summary>
    ''' Function for the menu button "Close"; empties the textfield, filename, and disables the current textfield textbox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuClose_Click(sender As Object, e As EventArgs)
        'calls the ConfirmClose function
        ConfirmClose()
        'checks if the fileEdited flag is false
        If fileEdited = False Then
            'empties file name and textfield
            fileName = String.Empty
            txtTextField.Text = String.Empty
            'updates the program title
            Me.Text = "Text Editor Select a File to Open"
            'disables the textfield
            txtTextField.Enabled = False
            'sets fileEdited flag to false
            fileEdited = False
        End If
    End Sub

    ''' <summary>
    ''' calls the fileexit function
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuExit_Click(sender As Object, e As EventArgs)
        FileExit()
    End Sub
    ''' <summary>
    ''' Function for the menu button "Exit"; exits the program.
    ''' </summary>
    Friend Sub FileExit()
        'calls the ConfirmClose function
        ConfirmClose()
        'checks if the fileEdited flag is false
        If fileEdited = False Then
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' calls the editcopy function
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuCopy_Click(sender As Object, e As EventArgs)
        EditCopy()
    End Sub
    ''' <summary>
    ''' Function for the menu button "Copy"; copies the selected text into clipboard.
    ''' </summary>
    Friend Sub EditCopy()
        'clears current clipboard
        Clipboard.Clear()
        If Not txtTextField.SelectedText = "" Then
            'places selected field into clipboard
            My.Computer.Clipboard.SetText(txtTextField.SelectedText)
        End If
    End Sub

    ''' <summary>
    ''' calls the editcut function
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuCut_Click(sender As Object, e As EventArgs)
        EditCut()
    End Sub
    ''' <summary>
    ''' Function for the menu button "Cut"; cuts the selected text into clipboard.
    ''' </summary>
    Friend Sub EditCut()
        'clears current clipboard
        Clipboard.Clear()
        If Not txtTextField.SelectedText = "" Then
            'places selected field into clipboard
            My.Computer.Clipboard.SetText(txtTextField.SelectedText)
            'removes selected field from the textfield
            txtTextField.SelectedText = String.Empty
        End If
    End Sub

    ''' <summary>
    ''' calls the editpaste function
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuPaste_Click(sender As Object, e As EventArgs)
        EditPaste()
    End Sub
    ''' <summary>
    ''' Function for the menu button "Paste"; pastes selections in the current clipboard into the textfield.
    ''' </summary>
    Friend Sub EditPaste()
        'places content from clipboard into selected field
        txtTextField.SelectedText = My.Computer.Clipboard.GetText()
    End Sub


    ''' <summary>
    ''' Function for the menu button "About"; creates a messagebox to appear with information regarding the program.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs)
        MessageBox.Show("NETD 2202" & vbCrLf & vbCrLf & "Lab #5" & vbCrLf & vbCrLf & "J. Yuan", "About")
    End Sub

    ''' <summary>
    ''' Function that checks if the page has been edited. If there are unsaved changes, messagebo appears for confirmation to leave the page.
    ''' </summary>
    Sub ConfirmClose()
        'check for changes in the page
        If fileEdited = True Then
            'displays messagebox for confirmation to leave
            If MsgBox("You have unsaved changes. Are you sure want to leave the page?", MsgBoxStyle.YesNo, "Text Editor") = MsgBoxResult.Yes Then
                'sets fileEdited flag to false if user picks yes
                fileEdited = False
            Else
                'else keeps flag as true
                fileEdited = True
            End If
        Else
            'keeps flag as false if page has not been edited
            fileEdited = False
        End If
    End Sub

End Class
