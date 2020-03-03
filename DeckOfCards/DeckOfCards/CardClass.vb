' Originally Created: March 2014
' Last Modified: Feruary 18, 2020
' Author: Kyle Chapman
' Description:
' This file includes a class of Cards with properties and constructors.
' These Cards simply have a Suit and a Value, which are stored as Strings.

Module CardClass

    ' The Card class is very simple; it has a Suit and a Value.

    Friend Class Card

#Region "Properties"

        Private cardSuit As String ' holds the card's suit
        Private cardValue As String ' holds the card's value

#End Region

#Region "Constructors"

        ''' <summary>
        ''' Default (blank) constructor for instantiation and inheritance.
        ''' </summary>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' Parametrized constructor assigns a Suit and a Value for each new Card.
        ''' </summary>
        ''' <param name="assignedSuit">Suit for the card</param>
        ''' <param name="assignedValue">Value for the card</param>
        Public Sub New(ByVal assignedSuit As String, ByVal assignedValue As String)
            cardSuit = assignedSuit
            cardValue = assignedValue
        End Sub

#End Region

#Region "Property Procedures"

        ''' <summary>
        ''' Property procedure for Suit - allows to get or set the card's suit
        ''' </summary>
        ''' <returns>Card's suit as a string</returns>
        Protected Friend Property Suit() As String
            Get
                Return cardSuit
            End Get
            Set(assignedSuit As String)
                cardSuit = assignedSuit
            End Set
        End Property

        ''' <summary>
        ''' Property procedure for Value - allows to get or set the card's face value
        ''' </summary>
        ''' <returns>Card's value as a string</returns>
        Protected Friend Property Value() As String
            Get
                Return cardValue
            End Get
            Set(assignedValue As String)
                cardValue = assignedValue
            End Set
        End Property

#End Region

#Region "Overriding Method"

        ''' <summary>
        ''' Overriding ToString so that Card objects display their value and suit in a natural reading order
        ''' </summary>
        ''' <returns>String describing the card</returns>
        Public Overrides Function ToString() As String

            Dim cardString ' declare a variable to contain the string describing each card
            cardString = Me.Value & " of " & Me.Suit ' concatenates the value and suit of the card together to be read naturally
            Return cardString ' return this string

        End Function

#End Region

    End Class

End Module
