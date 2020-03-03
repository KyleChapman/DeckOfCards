' Originally Created: March 2014
' Last Modified: Feruary 18, 2020
' Author: Kyle Chapman
' Description:
'    A demonstration of lists, also using a card class and card objects.
'    A Card class is defined in another file, but it's super simple.
'    Here we manipulate list of Cards (which I call a Deck), utilize a function that returns a shuffled Deck,
'    and there's a simple form that goes along with it too.

Public Class frmDeckViewer

    ' For the entire form we'll be referencing a deck of cards and we only ever want to keep one at a time.
    ' A deck of cards is a List(Of Card), where the Card class is defined in a separate class file.
    ' Here we declare the List, which I may call a "Deck".
    Private DeckInPlay As List(Of Card)

#Region "Functions"

    ''' <summary>
    ''' Function BuildDeck() takes no parameters and returns a List of Cards (which I may call "a deck"). The deck is standard and includes four suits and 13 face values.
    ''' </summary>
    ''' <returns>A List(Of Card) aka a Deck</returns>
    Friend Function buildDeck() As List(Of Card)

        ' DECLARATIONS

        ' suits is an array containing the four standard suits as strings
        Dim suits As String() = {"Hearts", "Clubs", "Diamonds", "Spades"}
        ' values is an array containing the thirteen common face values as strings
        Dim values As String() = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"}

        ' declares Deck as a List of Card
        Dim Deck As New List(Of Card)

        ' PROCESSING

        ' This for loop will create all of the cards using this logic:
        ' for each suit (4 times),
        '   for each value (13 times)
        '     make a new card with this suit and value and add it to the deck
        For suitIndex As Integer = 0 To suits.Length() - 1
            For valueIndex As Integer = 0 To values.Length() - 1
                Deck.Add(New Card(suits(suitIndex), values(valueIndex)))
            Next
        Next

        ' Returns Deck (comment-worthy? questionable!)
        Return Deck
    End Function

    ''' <summary>
    ''' Takes a deck of cards as input, returns a deck of cards in a different, randomized order.
    ''' </summary>
    ''' <param name="Deck"></param>
    ''' <returns>A List(Of Card) aka a Deck</returns>
    Friend Function shuffle(ByVal Deck As List(Of Card))

        'DECLARATIONS

        Dim cardCounter = 0 ' This keeps an index during iteration for the cards in the Deck
        Dim random = New Random() ' Setting up randomization for later

        ' The ShuffledDeck is the return of this function, so that we don't modify the source Deck.

        Dim ShuffledDeck As New List(Of Card)

        'PROCESSING

        ' This for loop will iterate through each card in the Deck.
        ' In each iteration, it will produce a random index number from 0 to the total number of cards in the ShuffledDeck.
        ' The card at the current iteration index, indicated by cardCounter, will be viewed from the Deck,
        ' and inserted in the ShuffledDeck at the randomized index.
        ' This should result in reasonable randomization; the first ard will go to index 0, then index 0 or 1, and so on
        ' so the first shuffled cards will not necessarily appear near the beginning or end.

        For Each drawnCard As Card In Deck

            Dim shuffleIndex = random.Next(ShuffledDeck.Count) ' This value will fluctuate between 0 and the number of cards in the ShuffledDeck

            ' Insert the next card from the original Deck at the random location in the ShuffledDeck
            ShuffledDeck.Insert(shuffleIndex, Deck(cardCounter))

            cardCounter += 1 ' Increment the index for use with the Deck

        Next

        'RETURN

        Return (ShuffledDeck) ' Returns a shuffled list of Cards

    End Function

#End Region

#Region "Event Handlers"

    ''' <summary>
    ''' When this form loads, let's make a deck. Focus is (somewhat arbitrarily) set to the "View Deck" button.
    ''' </summary>
    Private Sub frmDeckViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DeckInPlay = buildDeck() ' builds a List of Card
        btnViewDeck.Focus() ' sets focus to View Deck

    End Sub

    ''' <summary>
    ''' The card list is cleared, since we will be populating it from scratch. It will iterate through every card in the list using "For Each". The lstCardList will be appended with a concatentated string describing each card in a natural speaking manner; e.g. "The Ace of Spades". Focus is (somewhat arbitrarily) set to the "Shuffle" button.
    ''' </summary>
    Private Sub btnViewDeck_Click(sender As Object, e As EventArgs) Handles btnViewDeck.Click

        lstCardList.Items.Clear() ' clears the listbox


        ' iterate through each card in the List
        For Each Card In DeckInPlay

            ' Each card will have a string printed to the listbox based on the 
            ' Card class' overridden ToString method.
            ' Properties of the card are concatenated with some string elements
            ' in order to produce a natural-sounding reading style
            lstCardList.Items.Add(Card)
        Next

        btnShuffle.Focus() ' sets focus to Shuffle

    End Sub

    ''' <summary>
    ''' Since we created a function method, this handler is really simple. DeckInPlay is shuffled by calling the shuffle function, passing itself. The card list is cleared, since its information is now invalid/incorrect after the shuffle. Focus is (somewhat arbitrarily) set to the "View Deck" button.
    ''' </summary>
    Private Sub btnShuffle_Click(sender As Object, e As EventArgs) Handles btnShuffle.Click

        DeckInPlay = shuffle(DeckInPlay) ' sets DeckInPlay to a shuffled DeckInPlay
        lstCardList.Items.Clear() ' clears the listbox
        btnViewDeck.Focus() ' sets focus to View Deck

    End Sub

    ''' <summary>
    ''' Since we created a function method, this handler is really simple. DeckInPlay is assigned a List of Card by calling the buildDeck() function again. The card list is cleared, since its information may now be invalid/incorrect. Focus is (somewhat arbitrarily) set to the "View Deck" button.
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        DeckInPlay = buildDeck() ' sets DeckInPlay to a sorted deck using the buildDeck function
        lstCardList.Items.Clear() ' clears the listbox
        btnViewDeck.Focus() ' sets focus to View Deck

    End Sub

    ''' <summary>
    ''' Deals a single card; removes index 0 from the deck and does nothing with it.
    ''' </summary>
    Private Sub btnDeal_Click(sender As Object, e As EventArgs) Handles btnDeal.Click

        DeckInPlay.RemoveAt(0) ' remove the first card in the deck
        lstCardList.Items.Clear() ' clears the listbox

    End Sub

    ''' <summary>
    ''' Exits the program
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

#End Region

End Class
