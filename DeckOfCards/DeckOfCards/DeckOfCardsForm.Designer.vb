<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeckViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeckViewer))
        Me.btnViewDeck = New System.Windows.Forms.Button()
        Me.btnShuffle = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.ttpDeckViewerTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.lstCardList = New System.Windows.Forms.ListBox()
        Me.btnDeal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnViewDeck
        '
        Me.btnViewDeck.Location = New System.Drawing.Point(12, 9)
        Me.btnViewDeck.Name = "btnViewDeck"
        Me.btnViewDeck.Size = New System.Drawing.Size(75, 23)
        Me.btnViewDeck.TabIndex = 0
        Me.btnViewDeck.Text = "&View Deck"
        Me.ttpDeckViewerTips.SetToolTip(Me.btnViewDeck, "Click to view the deck in its current order")
        Me.btnViewDeck.UseVisualStyleBackColor = True
        '
        'btnShuffle
        '
        Me.btnShuffle.Location = New System.Drawing.Point(13, 39)
        Me.btnShuffle.Name = "btnShuffle"
        Me.btnShuffle.Size = New System.Drawing.Size(75, 23)
        Me.btnShuffle.TabIndex = 1
        Me.btnShuffle.Text = "&Shuffle"
        Me.ttpDeckViewerTips.SetToolTip(Me.btnShuffle, "Click the shuffle the deck")
        Me.btnShuffle.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(12, 127)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.ttpDeckViewerTips.SetToolTip(Me.btnExit, "Click to close the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(13, 69)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.ttpDeckViewerTips.SetToolTip(Me.btnReset, "Click to reset the deck to a sorted order")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lstCardList
        '
        Me.lstCardList.FormattingEnabled = True
        Me.lstCardList.Location = New System.Drawing.Point(93, 9)
        Me.lstCardList.Name = "lstCardList"
        Me.lstCardList.Size = New System.Drawing.Size(279, 134)
        Me.lstCardList.TabIndex = 4
        Me.ttpDeckViewerTips.SetToolTip(Me.lstCardList, "Displays the list of cards when View Deck is used")
        '
        'btnDeal
        '
        Me.btnDeal.Location = New System.Drawing.Point(13, 98)
        Me.btnDeal.Name = "btnDeal"
        Me.btnDeal.Size = New System.Drawing.Size(75, 23)
        Me.btnDeal.TabIndex = 5
        Me.btnDeal.Text = "&Deal"
        Me.ttpDeckViewerTips.SetToolTip(Me.btnDeal, "Click to deal one card, removing it from the deck")
        Me.btnDeal.UseVisualStyleBackColor = True
        '
        'frmDeckViewer
        '
        Me.AcceptButton = Me.btnViewDeck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(384, 162)
        Me.Controls.Add(Me.btnDeal)
        Me.Controls.Add(Me.lstCardList)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShuffle)
        Me.Controls.Add(Me.btnViewDeck)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDeckViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deck Viewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnViewDeck As System.Windows.Forms.Button
    Friend WithEvents btnShuffle As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents ttpDeckViewerTips As System.Windows.Forms.ToolTip
    Friend WithEvents lstCardList As System.Windows.Forms.ListBox
    Friend WithEvents btnDeal As System.Windows.Forms.Button

End Class
