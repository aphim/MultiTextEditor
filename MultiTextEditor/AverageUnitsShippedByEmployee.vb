Option Strict On
'**********************************************************************************************************************************
'Program:           Average Units Shipped By Employee
'Created by:        Jacky Yuan, 100520106
'Date Created:      02/23/2020
'Purpose:           This program will recieve the daily number of shipped unit for 3 employee and calculate the daily average after each employee
'                   inputs a week of shipments. The program will then calculate the overall daily average of the 3 employees.
'                   The program will Then allow the user To reset the program and recalculate or Exit.
'
'Changes:           N/A
'
'**********************************************************************************************************************************
Public Class frmAverageUnitsByEmployee
    'Declare and initialize variables; currentDay and CurrentEmployee
    Dim currentDay As Integer = 0
    Dim currentEmployee As Integer = 0

    'Declare variables; employeeTotals, employeeAverage, overallTotal, and overallAverage
    Dim employeeTotals As Integer
    Dim employeeAverage As Double
    Dim overallTotal As Integer
    Dim overallAverage As Double

    'Declare 2D array averageUnitsShippedArray, and 1D arrays; inputTextboxArray and outputLabelArray
    Dim averageUnitsShippedArray(2, 6) As Integer
    Dim inputTextboxArray() As TextBox
    Dim outputLabelArray() As Label

    ''' <summary>
    ''' On load of the program, the arrays are initialized and employee 1 is emphasized.
    ''' </summary
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAverageUnitsByEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initialize inputTextBox and outputLabelArray
        inputTextboxArray = {txtEmployee1Units, txtEmployee2Units, txtEmployee3Units}
        outputLabelArray = {lblEmployee1Average, lblEmployee2Average, lblEmployee3Average}

        'Set lblEmployee1 to bold
        lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
    End Sub

    ''' <summary>
    ''' Closes the program.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Calls the function ResetForm on click of the reset button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    ''' <summary>
    ''' Enters current input into the list of units shipped for the employee and date emphasized. Upon completion of a week by an employee, their average is
    ''' displayed. Upon completion of 3 employees, the overall average per day is also displayed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'Declare constants DayMax, EmployeeMax, MinUnitsShipped, and MaxUnitsShipped
        Const DayMax As Integer = 7
        Const EmployeeMax As Integer = 3
        Const MinUnitsShipped As Integer = 0
        Const MaxUnitsShipped As Integer = 5000

        'Check to see if the current input is a whole number
        If Integer.TryParse(txtInputBox.Text, averageUnitsShippedArray(currentEmployee, currentDay)) Then

            'Check to see if the current entry is within the accepted bounds
            If averageUnitsShippedArray(currentEmployee, currentDay) >= MinUnitsShipped And averageUnitsShippedArray(currentEmployee, currentDay) <= MaxUnitsShipped Then

                'Adds current input to the inputTextboxArray followed by a newline
                inputTextboxArray(currentEmployee).Text &= averageUnitsShippedArray(currentEmployee, currentDay) & vbCrLf

                'increases day count by 1
                currentDay += 1
                'Updates the displayed day counter
                lblDay.Text = "Day " & (currentDay + 1)
                'Empties the input textbox
                txtInputBox.Text = ""

                'Checks if the current day is equal to the end of the week
                If currentDay = DayMax Then
                    'resets employeeTotals for current employee
                    employeeTotals = 0
                    'Iterates through the current week and adds each entry to the current employee's total
                    For count As Integer = 0 To DayMax - 1
                        employeeTotals += averageUnitsShippedArray(currentEmployee, count)
                    Next

                    'Calculates the average for the employee using the formula average = sumtotal / number of entries
                    employeeAverage = employeeTotals / DayMax
                    'Displays the employee's average rounded to 2 decimal plays on the employee's average label
                    outputLabelArray(currentEmployee).Text = "Average:" & Math.Round(employeeAverage, 2)

                    'Resets the day counter for the next employee
                    currentDay = 0
                    'Applies changes to the form
                    lblDay.Text = "Day " & (currentDay + 1)
                    'Changes to next employee
                    currentEmployee += 1
                    'Checks which employee it is on current iteration and emphasizes the corresponding employee
                    If currentEmployee = 1 Then
                        lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
                        lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Bold)
                    ElseIf currentEmployee = 2 Then
                        lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Regular)
                        lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Bold)
                        'Checks if check if current employee is the last employee
                    ElseIf currentEmployee = EmployeeMax Then
                        'Goes through each entry in the 2D array and sums it into an overall total.
                        For Each currentDay In averageUnitsShippedArray
                            overallTotal += currentDay
                        Next

                        'Calculates the overall average using thr formula overall average = overall sum total / overall length of the 2D array
                        overallAverage = overallTotal / averageUnitsShippedArray.Length
                        'Displays the overall average in the overall average label rounded to 2 decimal places
                        lblOverallAverage.Text = "Average per day: " & Math.Round(overallAverage, 2)

                        'Removes emphasis from employee 3
                        lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Regular)

                        'Disables further inputs by disabling the input textbox, and enter button
                        txtInputBox.Enabled = False
                        btnEnter.Enabled = False

                        'Sets focus to the reset button
                        btnReset.Focus()
                        'Sets day label to "Done"
                        lblDay.Text = "Done"

                    End If

                End If
                'If the entry is out of bounds
            Else
                'Creates messagebox displaying "Units shipped must be between 0 and 5000 inclusive.")
                MessageBox.Show("Units shipped must be between 0 and 5000 inclusive")
                'sets focus and selects the input in the input textbox
                txtInputBox.SelectAll()
                txtInputBox.Focus()
            End If

            'if the entry is non-numeric or not a whole number
        Else
            'Creates messagebox displaying "Units shipped must be a whole number.")
            MessageBox.Show("Units shipped must be a whole number.")
            'sets focus and selects the input in the input textbox
            txtInputBox.SelectAll()
            txtInputBox.Focus()
        End If
    End Sub

    ''' <summary>
    ''' Sub-function what resets the form to its default state.
    ''' </summary>
    Sub ResetForm()
        'Sets the output textboxes to empty
        txtEmployee1Units.Text = ""
        txtEmployee2Units.Text = ""
        txtEmployee3Units.Text = ""

        'Sets the input textbox to empty
        txtInputBox.Text = ""

        'Sets output labels to empty
        lblEmployee1Average.Text = ""
        lblEmployee2Average.Text = ""
        lblEmployee3Average.Text = ""
        lblOverallAverage.Text = ""

        'Re-enable input textbox and enter button
        txtInputBox.Enabled = True
        btnEnter.Enabled = True

        'Reset currentDay, currentEmployee, employeeTotals, overallTotals, employeeAverage, and overallAverage
        currentDay = 0
        currentEmployee = 0
        employeeTotals = 0
        overallTotal = 0
        employeeAverage = 0
        overallAverage = 0

        'Reset the day output label
        lblDay.Text = "Day " & (currentDay + 1)

        'Resets emphasis back onto employee 1
        lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
        lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Regular)
        lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Regular)

        'Sets focus to input textbox
        txtInputBox.Focus()
    End Sub

End Class
