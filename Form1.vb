Public Class Form1

    'current symbol position reel is at
    Dim reelIndex1 As Integer = 0
    Dim reelIndex2 As Integer = 0
    Dim reelIndex3 As Integer = 0

    'new symbol position reel needs to spin to
    Dim newReelIndex1 As Integer = 0
    Dim newReelIndex2 As Integer = 0
    Dim newReelIndex3 As Integer = 0

    'symbol values
    Dim currentSymbol1 As Integer = 0
    Dim currentSymbol2 As Integer = 0
    Dim currentSymbol3 As Integer = 0

    'reel arrays with symbol values
    Dim reelOne = {1, 2, 3, 4, 5, 6}
    Dim reelTwo = {3, 2, 1, 6, 5, 4}
    Dim reelThree = {1, 4, 5, 6, 2, 3}

    'payment list for each symbol
    Dim paymentList = {20, 9, 6, 3, 2, 1}

    'bank and credit information
    Dim bankAmount As Decimal = 5
    Dim creditAmount As Decimal = 0

    'number of nudges and holds generated
    Dim nudgeAmount As Integer = 0
    Dim holdAmount As Integer = 0

    'if nudges or holds active
    Dim nudgeActive As Boolean = False
    Dim holdActive As Boolean = False

    'win state (0 if no win, 1 if 2 matching symbols, 
    'and 2 if 3 matching symbols)
    Dim winState As Integer = 0

    'state in which hold buttons are in (true if held)
    Dim holdState1 As Boolean = False
    Dim holdState2 As Boolean = False
    Dim holdState3 As Boolean = False

    'amount of times reel has to move to next symbol
    Dim threshOne As Integer = 16
    Dim threshTwo As Integer = 32
    Dim threshThree As Integer = 48

    'number of times symbol on each reel has changed
    Dim changeCount1 As Integer = 0
    Dim changeCount2 As Integer = 0
    Dim changeCount3 As Integer = 0

    'difference between current symbol position
    'and new symbol position
    Dim slotDifference1 As Integer = 0
    Dim slotDifference2 As Integer = 0
    Dim slotDifference3 As Integer = 0

    'indicates if reels have finished spinning
    Dim reel1Finished As Boolean = False
    Dim reel2Finished As Boolean = False
    Dim reel3Finished As Boolean = False

    'keeps position on bonus counter (e.g. 1 = first square)
    Dim bonusCounter As Integer = 1


    Private Sub Spin()

        If creditAmount >= 0.1 Then 'if 10p or more is in credits

            'reset winCheck variable to False
            winState = 0

            'reset reel counter variables
            changeCount1 = 0
            changeCount2 = 0
            changeCount3 = 0

            reel1Finished = False
            reel2Finished = False
            reel3Finished = False

            'Reset Button colors And variables
            buttonReset()

            'reset bonus board
            BonusBox1.Image = My.Resources.ResourceManager.GetObject("bon")
            bonusCounter = 0

            'take 0.1 (10p) away, from credits
            creditAmount -= 0.1
            updateValues()

            Randomize()

            'if hold button for reel isn't held, generate new position
            If holdState1 = False Then
                newReelIndex1 = Math.Ceiling(6 * Rnd()) - 1
            End If
            If holdState2 = False Then
                newReelIndex2 = Math.Ceiling(6 * Rnd()) - 1
            End If
            If holdState3 = False Then
                newReelIndex3 = Math.Ceiling(6 * Rnd()) - 1
            End If

            'find difference between current reel index and new reel index
            slotDifference1 = reelIndex1 - newReelIndex1
            slotDifference2 = reelIndex2 - newReelIndex2
            slotDifference3 = reelIndex3 - newReelIndex3

            Timer1.Enabled = True 'enabled counter spin timer

        Else
            If bankAmount >= 0.1 Then 'if no credits left but money in bank
                MsgBox("Sorry, no credits left! Please add more.")
            Else 'if no credits an no money in bank
                MsgBox("Sorry, you have no credit or money left. Thanks for playing!")
                Me.Close() 'close program
            End If
        End If

    End Sub

    Private Sub Nudge(nudgeNum)

        nudgeActive = True
        nudgeAmount = nudgeNum 'sets amount of nudges to nudgeNum

        'changes colors of buttons
        nudgeButton1.BackColor = Color.Yellow
        nudgeButton2.BackColor = Color.Yellow
        nudgeButton3.BackColor = Color.Yellow

    End Sub

    Private Sub Hold(holdNum)

        holdActive = True
        holdAmount = holdNum 'sets amount of holds to holdNum 

        'change colors of buttons
        holdButton1.BackColor = Color.Yellow
        holdButton2.BackColor = Color.Yellow
        holdButton3.BackColor = Color.Yellow

    End Sub

    Private Sub genHolds()

        'generate hold chance of using holds
        Dim holdChance As Integer = Math.Ceiling(Rnd() * 3)

        'If HoldChance is 5 (1 in 3 chance)
        If holdChance = 3 Then
            holdAmount = Math.Ceiling(Rnd() * 3) 'set hold amount to random number
            Hold(holdAmount) 'set certain amount of holds
        End If

        updateValues() 'update values

    End Sub

    Private Sub genNudges()

        'generate chance of using nudges
        Dim nudgeChance As Integer = Math.Ceiling(Rnd() * 3)

        'if nudgeChance is 5 (1 in 3 chance)
        If nudgeChance = 3 Then
            nudgeAmount = Math.Ceiling(Rnd() * 3) 'set nudge amount to random number
            Nudge(nudgeAmount) 'set certain amount of nudges
        End If

        updateValues() 'update values

    End Sub

    Private Sub genBonusBoard()

        'generate possible use of bonus board (1 in 5 chance)
        Dim bonusChance As Integer = Math.Ceiling(Rnd() * 5)

        If bonusChance = 5 Then 'if allowed use of bonus board
            Timer2.Enabled = True 'enable bonus board
        End If

    End Sub

    Private Function checkWin()

        If currentSymbol1 = currentSymbol2 Then 'if first two symbols match

            If currentSymbol3 = currentSymbol2 Then 'if three matching symbols
                Return 2
            Else 'if only 2 matching symbols
                Return 1
            End If

        ElseIf currentSymbol1 = currentSymbol3 Then 'if 2 matching symbols
            Return 1
        End If

        Return 0 'returns 0 if no matching symbols
    End Function

    Private Sub winAction(winState) '

        If winState = 2 Then 'if three matching symbols

            'for loop that adds winnings 
            For i As Integer = 0 To 5
                If i = reelIndex1 Then 'if i is current reel index
                    bankAmount += paymentList(i) 'add appropriate amount
                    MsgBox("You won - £" & paymentList(i)) 'display message
                End If
            Next

            updateValues() 'update text
            buttonReset() 'reset hold and nudge buttons

        ElseIf winState = 1 'if player got 2 identical symbols

            Dim actionChoice As Integer = Math.Ceiling(Rnd() * 3) 'decides if hold, nudge, or bonus board is awarded

            If actionChoice = 1 Then
                genHolds() 'generate possible hold (1 in 5 chance)
            ElseIf actionChoice = 2 Then
                genNudges() 'generate possible nudges (1 in 5 chance)
            Else
                genBonusBoard() 'generate possible use of bonus board (1 in 5 chance)
            End If

        ElseIf winState = 0 Then 'if player got no matching symbols
            genBonusBoard() 'generate use of bonus board (1 in 5 chance)
        End If

    End Sub

    Private Sub updateValues()

        'update bank and credit in form
        bankLabel.Text = "Bank balance - " & bankAmount
        creditLabel.Text = "Credit balance - " & creditAmount

        'Update nudge amount image
        If nudgeAmount > 0 Then
            nudgeImage.Image = My.Resources.ResourceManager.GetObject("nudge" & nudgeAmount)
        Else
            nudgeImage.Image = My.Resources.ResourceManager.GetObject("nudge")
        End If

        'update nudge amount image
        If holdAmount > 0 Then
            holdImage.Image = My.Resources.ResourceManager.GetObject("nudge" & holdAmount)
        Else
            holdImage.Image = My.Resources.ResourceManager.GetObject("nudge")
        End If

    End Sub

    Private Sub updateReels()

        'find current symbol values
        currentSymbol1 = reelOne(reelIndex1) 'index 0-5
        currentSymbol2 = reelTwo(reelIndex2)
        currentSymbol3 = reelThree(reelIndex3)

        'update reel images
        reelImage1.Image = My.Resources.ResourceManager.GetObject(currentSymbol1)
        reelImage2.Image = My.Resources.ResourceManager.GetObject(currentSymbol2)
        reelImage3.Image = My.Resources.ResourceManager.GetObject(currentSymbol3)

        'update top reel images
        If reelIndex1 > 0 Then
            reelImageTop1.Image = My.Resources.ResourceManager.GetObject(reelOne(reelIndex1 - 1))
        Else
            reelImageTop1.Image = My.Resources.ResourceManager.GetObject(reelOne(5))
        End If
        If reelIndex2 > 0 Then
            reelImageTop2.Image = My.Resources.ResourceManager.GetObject(reelTwo(reelIndex2 - 1))
        Else
            reelImageTop2.Image = My.Resources.ResourceManager.GetObject(reelTwo(5))
        End If
        If reelIndex3 > 0 Then
            reelImageTop3.Image = My.Resources.ResourceManager.GetObject(reelThree(reelIndex3 - 1))
        Else
            reelImageTop3.Image = My.Resources.ResourceManager.GetObject(reelThree(5))
        End If

        'update bottom images
        If reelIndex1 < 5 Then
            reelImageLow1.Image = My.Resources.ResourceManager.GetObject(reelOne(reelIndex1 + 1))
        Else
            reelImageLow1.Image = My.Resources.ResourceManager.GetObject(reelOne(0))
        End If
        If reelIndex2 < 5 Then
            reelImageLow2.Image = My.Resources.ResourceManager.GetObject(reelTwo(reelIndex2 + 1))
        Else
            reelImageLow2.Image = My.Resources.ResourceManager.GetObject(reelTwo(0))
        End If
        If reelIndex3 < 5 Then
            reelImageLow3.Image = My.Resources.ResourceManager.GetObject(reelThree(reelIndex3 + 1))
        Else
            reelImageLow3.Image = My.Resources.ResourceManager.GetObject(reelThree(0))
        End If

    End Sub

    Private Sub buttonReset()

        'reset amount of nudges/holds rewarded to player
        nudgeAmount = 0
        holdAmount = 0

        'reset nudge/hold active variables
        nudgeActive = False
        holdActive = False

        'update visuals
        updateValues()

        'reset button colors
        holdButton1.BackColor = Color.FromArgb(192, 255, 255)
        holdButton2.BackColor = Color.FromArgb(192, 255, 255)
        holdButton3.BackColor = Color.FromArgb(192, 255, 255)

        nudgeButton1.BackColor = Color.FromArgb(192, 255, 255)
        nudgeButton2.BackColor = Color.FromArgb(192, 255, 255)
        nudgeButton3.BackColor = Color.FromArgb(192, 255, 255)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'spin reel one
        If holdState1 = False Then 'if reel not held
            If changeCount1 < threshOne + slotDifference1 Then 'if amount of times changed is less than threshold plus slot difference
                If reelIndex1 < 5 Then 'if not last symbol on reel
                    reelIndex1 += 1 'go to next reel
                Else
                    reelIndex1 = 0 'else go to start of reel
                End If
                changeCount1 += 1 'add 1 to times changed variable
            Else
                reel1Finished = True
            End If
        Else
            reel1Finished = True
        End If

        'spin reel two
        If holdState2 = False Then
            If changeCount2 < threshTwo + slotDifference2 Then
                If reelIndex2 < 5 Then
                    reelIndex2 += 1
                Else
                    reelIndex2 = 0
                End If
                changeCount2 += 1
            Else
                reel2Finished = True
            End If
        Else
            reel2Finished = True
        End If

        'spin reel three
        If holdState3 = False Then
            If changeCount3 < threshThree + slotDifference3 Then
                If reelIndex3 < 5 Then
                    reelIndex3 += 1
                Else
                    reelIndex3 = 0
                End If
                changeCount3 += 1
            Else
                reel3Finished = True
            End If
        Else
            reel3Finished = True
        End If

        updateReels()

        'if all reels are finished
        If reel1Finished And reel2Finished And reel3Finished = True Then

            Timer1.Enabled = False 'disable reel spin timer

            'reset state of hold buttons
            holdState1 = False
            holdState2 = False
            holdState3 = False

            winState = checkWin() 'check if player won (returns value)
            winAction(winState) 'do appropriate action if symbol match

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If bonusCounter < 12 Then 'if current square on bonus board isn't 12
            bonusCounter += 1 'go to next square
        Else
            bonusCounter = 1 'else go back to beginning of board
        End If

        BonusBox1.Image = My.Resources.ResourceManager.GetObject("bon" & bonusCounter) 'update bonus board

    End Sub

    Private Sub spinButton_Click(sender As Object, e As EventArgs) Handles spinButton.Click

        If Timer1.Enabled = False Then 'if reels no longer spinning
            If Timer2.Enabled = False Then 'if bonus board isn't active
                Spin() 'spin reels
            Else
                MsgBox("Please stop the bonus board first!")
            End If
        End If

    End Sub

    Private Sub nudgeButton1_Click(sender As Object, e As EventArgs) Handles nudgeButton1.Click

        If nudgeActive = True Then 'if nudge generated
            If nudgeAmount > 0 Then 'if allowed nudges more than 0

                If reelIndex1 < 5 Then 'if not on last symbol in reel
                    reelIndex1 += 1 'go to next symbol
                Else
                    reelIndex1 = 0 'else go back to beginning
                End If

                nudgeAmount -= 1 'take 1 away from allowed nudges

                updateValues() 'update values
                updateReels() 'update reels

                winState = checkWin() 'check if player won (returns value 0, 1 or 2)

                If winState = 2 Then 'if player has 3 matching symbols
                    winAction(winState) 'do appropriate action
                End If

            End If
        End If
    End Sub

    Private Sub nudgeButton2_Click(sender As Object, e As EventArgs) Handles nudgeButton2.Click

        If nudgeActive = True Then
            If nudgeAmount > 0 Then

                If reelIndex2 < 5 Then
                    reelIndex2 += 1
                Else
                    reelIndex2 = 0
                End If

                nudgeAmount -= 1

                updateValues()
                updateReels()

                winState = checkWin()

                If winState = 2 Then
                    winAction(winState)
                End If

            End If
        End If
    End Sub

    Private Sub nudgeButton3_Click(sender As Object, e As EventArgs) Handles nudgeButton3.Click

        If nudgeActive = True Then
            If nudgeAmount > 0 Then

                If reelIndex3 < 5 Then
                    reelIndex3 += 1
                Else
                    reelIndex3 = 0
                End If

                nudgeAmount -= 1

                updateValues()
                updateReels()

                winState = checkWin()

                If winState = 2 Then
                    winAction(winState)
                End If

            End If
        End If
    End Sub

    Private Sub holdButton1_Click(sender As Object, e As EventArgs) Handles holdButton1.Click

        If holdActive = True Then 'if holdChance 1 in 9
            If holdState1 = False Then 'if hold already False
                If holdAmount > 0 Then 'if allowed holds is more than 0
                    holdState1 = True 'set held state to 'true'
                    holdButton1.BackColor = Color.Orange 'change button color to orange
                    holdAmount -= 1 'take 1 away from allowed holds
                    updateValues() 'update values
                End If
            End If
        End If
    End Sub

    Private Sub holdButton2_Click(sender As Object, e As EventArgs) Handles holdButton2.Click

        If holdActive = True Then
            If holdState2 = False Then
                If holdAmount > 0 Then
                    holdState2 = True
                    holdButton2.BackColor = Color.Orange
                    holdAmount -= 1
                    updateValues()
                End If
            End If
        End If
    End Sub

    Private Sub holdButton3_Click(sender As Object, e As EventArgs) Handles holdButton3.Click

        If holdActive = True Then
            If holdState3 = False Then
                If holdAmount > 0 Then
                    holdState3 = True
                    holdButton3.BackColor = Color.Orange
                    holdAmount -= 1
                    updateValues()
                End If
            End If
        End If
    End Sub

    Private Sub creditsButton_Click(sender As Object, e As EventArgs) Handles creditsButton.Click
        'add credits to machine (10p)
        If bankAmount >= 0.1 Then
            bankAmount -= 0.1
            creditAmount += 0.1
            updateValues()
        End If
    End Sub

    Private Sub creditsButton2_Click(sender As Object, e As EventArgs) Handles creditsButton2.Click
        'add credits to machine (£1)
        If bankAmount >= 1 Then
            bankAmount -= 1
            creditAmount += 1
            updateValues()
        End If
    End Sub

    Private Sub stopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click

        If Timer2.Enabled = True Then 'if bonus board is active
            Timer2.Enabled = False 'stop bonus board

            If bonusCounter = 1 Then 'if landed on 3rd square
                Nudge(1) 'allow one nudge
            ElseIf bonusCounter = 2 Then 'if landed on 2nd square
                Nudge(2) 'allow two nudges
            ElseIf bonusCounter = 3 Then 'if landed on 3rd square
                Nudge(3) 'allow three nudges
            ElseIf bonusCounter = 4 Then 'if landed on 4th square
                creditAmount = creditAmount * 2 'double credits
            ElseIf bonusCounter = 6 Then 'if landed on 6th square
                bankAmount += 2 'add £2 to bank
            ElseIf bonusCounter = 8 Then 'if landed on 8th square
                creditAmount = creditAmount * 3 'triple credits
            ElseIf bonusCounter = 10 Then 'if landed on 10th square
                bankAmount += 20 'add £20 to bank
            ElseIf bonusCounter = 12 Then 'if landed on 12th square
                bankAmount += 10 'add £10 to bank
            End If

            updateValues()
        End If
    End Sub
End Class
