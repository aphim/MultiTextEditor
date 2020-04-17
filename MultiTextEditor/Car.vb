'Program:         Car
'Author:          Jacky Yuan
'Date:            March 12, 2020
'Description:     This is for creating a car object and defining its properties.


Option Strict On
Public Class Car
    'This class contains properties and stuff related to cars

#Region "Variable Declarations"
    Private Shared carCount As Integer = 0
    Private carIdentificationNumber As String = ""
    Private carMake As String = ""
    Private carModel As String = ""
    Private carYear As Integer = 0
    Private carPrice As Decimal = 0.0D
    Private carNewStatus As Boolean = True
#End Region
    ''' <summary>
    ''' Default constructor for the car class maintains a class count variable
    ''' </summary>
#Region "Constructors"
    Friend Sub New()
        carCount += 1
        carIdentificationNumber = carCount.ToString

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="makeValue"></param>
    ''' <param name="modelValue"></param>
    ''' <param name="yearValue"></param>
    ''' <param name="priceValue"></param>
    ''' <param name="statusValue"></param>
    Friend Sub New(makeValue As String, modelValue As String, yearValue As Integer, priceValue As Decimal, statusValue As Boolean)
        Me.New()
        carMake = makeValue
        carModel = modelValue
        carYear = yearValue
        carPrice = priceValue
        carNewStatus = statusValue

    End Sub
#End Region
#Region "Properties"
    ''' <summary>
    ''' Returns the number of car Objects
    ''' </summary>
    ''' <returns></returns>
    Friend Shared ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get

    End Property
    ''' <summary>
    ''' Gets a cars ID number
    ''' </summary>
    ''' <returns>A cars identification number</returns>
    Friend ReadOnly Property Id() As String
        Get
            Return carIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' Gets and sets a car objects manufacturer
    ''' </summary>
    ''' <returns>A cars manufacturer as a string</returns>
    Friend Property Make() As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property
#End Region
    ''' <summary>
    ''' Gets and sets a car objects model
    ''' </summary>
    ''' <returns></returns>
    Friend Property Model() As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets a car objects year of production
    ''' </summary>
    ''' <returns>A cars Year as a string</returns>
    Friend Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets a car objects Price
    ''' </summary>
    ''' <returns>A cars Price as a Decimal</returns>
    Friend Property Price() As Decimal
        Get
            Return carPrice
        End Get
        Set(value As Decimal)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets a car objects manufacturer
    ''' </summary>
    ''' <returns>A cars manufacturer as a string</returns>
    Friend Property IsNew() As Boolean
        Get
            Return carNewStatus
        End Get
        Set(value As Boolean)
            carNewStatus = value
        End Set
    End Property

#Region "Methods"
    ''' <summary>
    ''' Method used to get the car statuses from the database.
    ''' </summary>
    ''' <returns></returns>
    Friend Function GetCarData() As String
        ''Method 1
        ''Return IIf(carNewStatus, "New", "Used").ToString & " " & carYear.ToString() & " " & carMake & " " & carModel & " for " & carPrice.ToString("c")

        ''Method 2
        If carNewStatus = True Then
            Return "New " & carYear.ToString() & " " & carMake & " " & carModel & " for " & carPrice.ToString("c")
        Else
            Return "Used " & carYear.ToString() & " " & carMake & " " & carModel & " for " & carPrice.ToString("c")
        End If
    End Function
#End Region
End Class

