'Program:         Car Inventory 
'Author:          Jacky Yuan
'Date:            March 12, 2020
'Description:     This program will allow you to enter and create a list of cars. Entries will take in its make
'                 model, price, year and whether it is new or not.

Option Strict On
Public Class frmCarInventory

    'Declare a car class object
    Dim currentCar As Car
    'Declare global variables
    Dim carSelected As Boolean = False
    Dim addToList As Boolean = False
    'Declare a list of car objects
    Dim carList As New List(Of Car)


    ''' <summary>
    ''' Exits the program on click of the exit button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Calls function SetDefaults to reset the entry fields of the program.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()

    End Sub

    ''' <summary>
    ''' Accepts the inputted data and validates it. If the values are good, it is then saved and added the the output list.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'if inputs are valid upon calling the ValidInput function
        If ValidInput() = True Then

            'if no cars are selected from the listbox
            If Not carSelected Then

                'Create a new car object using the current inputs
                currentCar = New Car(cmbMake.Text, txtModel.Text.Trim, Convert.ToInt32(cmbYear.Text), Decimal.Parse(txtPrice.Text.Trim), chkNew.Checked)
                'Add the new car object to the list of car objects
                carList.Add(currentCar)

                'if the current car exits
            ElseIf currentCar.Id.Trim.Length > 0 Then

                'sets the car object's information to the current inputs
                currentCar.Make = cmbMake.Text
                currentCar.Model = txtModel.Text
                Integer.TryParse(cmbYear.Text, currentCar.Year)
                Decimal.TryParse(txtPrice.Text, currentCar.Price)
                currentCar.IsNew = chkNew.Checked

            End If

            'calls function GenerateList to create the list in the listbox
            GenerateList()
            'calls function ResetForm to reset the input boxes in the form
            ResetForm()
            'Displays "It worked! message in output display
            lblOutput.Text = "It worked!"
        End If
    End Sub

    ''' <summary>
    ''' Function SetDefault resets the entry fields of the program
    ''' </summary>
    Private Sub ResetForm()

        'clears the textboxes
        txtModel.Clear()
        txtPrice.Clear()
        'unchecks the isNew checkbox
        chkNew.Checked = False
        'clears output label
        lblOutput.Text = ""
        'clears selections in combobox
        cmbMake.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        'sets carSelected back to false
        carSelected = False
        'Sets focus to the top
        cmbMake.Focus()

    End Sub

    ''' <summary>
    ''' Function check to see if all the required inputs are present. If information is missing, an error message is displayed.
    ''' </summary>
    ''' <returns></returns>
    Private Function ValidInput() As Boolean

        'Declare variable validFlag set to true
        Dim validFlag As Boolean = True
        'Declare variable errorMessage that stores any error messages set to an empty string
        Dim errorMessage As String = ""
        'Declare variable isNumeric
        Dim isNumeric As Double

        'Checks to see if the car make combobox is empty and adds an error if so.
        If cmbMake.Text = "" Then
            errorMessage += "Please select the car's make." & vbCrLf
            validFlag = False
        End If

        'Checks to see if the car model textbox is empty and adds an error if so. 
        If txtModel.Text.Trim = "" Then
            errorMessage += "Please enter the car's model." & vbCrLf
            validFlag = False
        End If

        'Checks to see if the car year combobox is empty and adds an error if so.
        If cmbYear.Text = "" Then
            errorMessage += "Please select the car's year." & vbCrLf
            validFlag = False
        End If

        'Checks to see if the car price is empty and adds an error if so.
        If txtPrice.Text.Trim = "" Then
            errorMessage += "Please enter the car's price." & vbCrLf
            validFlag = False

            'Checks to see if the car's price is numeric and adds and error if not numeric.
        ElseIf Double.TryParse(txtPrice.Text.Trim, isNumeric) = False Then
            errorMessage += "Please enter a numeric value for the car's price." & vbCrLf
            validFlag = False

            'Checks to see if the car's price is greater than zero and adds an error if it is less than zero.
        ElseIf isNumeric < 0 Then
            errorMessage += "Please enter a positive value for the car's price." & vbCrLf
            validFlag = False
        End If

        'If errors are present, they are displayed in the output label.
        If validFlag = False Then
            lblOutput.Text = "ERRORS:" & vbCrLf & errorMessage
        End If

        'returns the validFlag
        Return validFlag

    End Function

    ''' <summary>
    ''' If a car is selected from the list box, its information will be pulled to the input boxes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCars.SelectedIndexChanged

        'if a car is selected from the list
        If lvwCars.SelectedIndices.Count = 1 Then
            currentCar = carList(lvwCars.SelectedIndices(0))
            'sets carSelected to true
            carSelected = True

            'set the input boxes equal to the information of the car in the list
            cmbMake.Text = currentCar.Make
            txtModel.Text = currentCar.Model
            cmbYear.Text = currentCar.Year.ToString
            txtPrice.Text = currentCar.Price.ToString
            chkNew.Checked = currentCar.IsNew

        Else
            'set carSelected to false
            carSelected = False
        End If

    End Sub

    ''' <summary>
    ''' Prevents accidental modifications of the list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCharacters_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCars.ItemCheck

        'If addToList is not true, changes are reverted to current values.
        If Not addToList Then

            e.NewValue = e.CurrentValue

        End If

    End Sub
    ''' <summary>
    ''' Function used to create the list in the listbox
    ''' </summary>
    Sub GenerateList()

        'clears current items in the listbox
        lvwCars.Items.Clear()

        'iterates throught the list of car objects
        For index As Integer = 0 To carList.Count - 1

            'creates new entry for the object
            Dim vehicle As New ListViewItem()

            'Sets the entries to equal the inputed data
            vehicle.SubItems.Add(carList(index).Id)
            vehicle.SubItems.Add(carList(index).Make)
            vehicle.SubItems.Add(carList(index).Model)
            vehicle.SubItems.Add(carList(index).Year.ToString())
            vehicle.SubItems.Add(carList(index).Price.ToString("c"))
            vehicle.Checked = carList(index).IsNew

            'sets addToList to true and adds the item to the list before returning addToList back to false
            addToList = True
            lvwCars.Items.Add(vehicle)
            addToList = False
        Next

    End Sub

End Class
