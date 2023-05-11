Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.X509Certificates

'Owen V and Eric T

Public Class Form1
    'Variables
    Dim intvalue As Integer = 0
    Dim Randomvalue As Integer
    Dim joecounter As Integer = 0
    Dim spinvalue As Integer
    Dim tinterval As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRandomize.Click
        'Randomize Button and Activate Timer 
        lblwinmoney.Text = "You win : "
        Randomvalue = Int((25 * Rnd()) + 1) * 3
        lblrnadomizednumeral.Text = Randomvalue.ToString
        Timer1.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Close Project 
        Me.Close()
    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Colors 
        intvalue += 1
        If intvalue = 1 Then
            box1.BackColor = Color.Yellow
            box25.BackColor = Color.White
            picbox2.Image = My.Resources.y_1
            JoeTimer()
        ElseIf intvalue = 2 Then
            box2.BackColor = Color.Yellow
            box1.BackColor = Color.White
            picbox2.Image = My.Resources.y_2
            JoeTimer()
        ElseIf intvalue = 3 Then
            box3.BackColor = Color.Yellow
            box2.BackColor = Color.White
            picbox2.Image = My.Resources.y_3
            JoeTimer()
        ElseIf intvalue = 4 Then
            box4.BackColor = Color.Yellow
            box3.BackColor = Color.White
            picbox2.Image = My.Resources.y_4
            JoeTimer()
        ElseIf intvalue = 5 Then
            box5.BackColor = Color.Yellow
            box4.BackColor = Color.White
            picbox2.Image = My.Resources.y_5
            JoeTimer()
        ElseIf intvalue = 6 Then
            box6.BackColor = Color.Yellow
            box5.BackColor = Color.White
            picbox2.Image = My.Resources.y_6
            JoeTimer()
        ElseIf intvalue = 7 Then
            box7.BackColor = Color.Yellow
            box6.BackColor = Color.White
            picbox2.Image = My.Resources.y_7
            JoeTimer()
        ElseIf intvalue = 8 Then
            box8.BackColor = Color.Yellow
            box7.BackColor = Color.White
            picbox2.Image = My.Resources.y_8
            JoeTimer()
        ElseIf intvalue = 9 Then
            box9.BackColor = Color.Yellow
            box8.BackColor = Color.White
            picbox2.Image = My.Resources.y_9
            JoeTimer()
        ElseIf intvalue = 10 Then
            box10.BackColor = Color.Yellow
            box9.BackColor = Color.White
            picbox2.Image = My.Resources.y_10
            JoeTimer()
        ElseIf intvalue = 11 Then
            box11.BackColor = Color.Yellow
            box10.BackColor = Color.White
            picbox2.Image = My.Resources.y_11
            JoeTimer()
        ElseIf intvalue = 12 Then
            box12.BackColor = Color.Yellow
            box11.BackColor = Color.White
            picbox2.Image = My.Resources.y_12
            JoeTimer()
        ElseIf intvalue = 13 Then
            box13.BackColor = Color.Yellow
            box12.BackColor = Color.White
            picbox2.Image = My.Resources.y_13
            JoeTimer()
        ElseIf intvalue = 14 Then
            box14.BackColor = Color.Yellow
            box13.BackColor = Color.White
            picbox2.Image = My.Resources.y_14
            JoeTimer()
        ElseIf intvalue = 15 Then
            box15.BackColor = Color.Yellow
            box14.BackColor = Color.White
            picbox2.Image = My.Resources.y_15
            JoeTimer()
        ElseIf intvalue = 16 Then
            box16.BackColor = Color.Yellow
            box15.BackColor = Color.White
            picbox2.Image = My.Resources.y_16
            JoeTimer()
        ElseIf intvalue = 17 Then
            box17.BackColor = Color.Yellow
            box16.BackColor = Color.White
            picbox2.Image = My.Resources.y_17
            JoeTimer()
        ElseIf intvalue = 18 Then
            box18.BackColor = Color.Yellow
            box17.BackColor = Color.White
            picbox2.Image = My.Resources.y_18
            JoeTimer()
        ElseIf intvalue = 19 Then
            box19.BackColor = Color.Yellow
            box18.BackColor = Color.White
            picbox2.Image = My.Resources.y_19
            JoeTimer()
        ElseIf intvalue = 20 Then
            box20.BackColor = Color.Yellow
            box19.BackColor = Color.White
            picbox2.Image = My.Resources.y_20
            JoeTimer()
        ElseIf intvalue = 21 Then
            box21.BackColor = Color.Yellow
            box20.BackColor = Color.White
            picbox2.Image = My.Resources.y_21
            JoeTimer()
        ElseIf intvalue = 22 Then
            box22.BackColor = Color.Yellow
            box21.BackColor = Color.White
            picbox2.Image = My.Resources.y_22
            JoeTimer()
        ElseIf intvalue = 23 Then
            box23.BackColor = Color.Yellow
            box22.BackColor = Color.White
            picbox2.Image = My.Resources.y_23
            JoeTimer()
        ElseIf intvalue = 24 Then
            box24.BackColor = Color.Yellow
            box23.BackColor = Color.White
            picbox2.Image = My.Resources.y_24
            JoeTimer()
        ElseIf intvalue = 25 Then
            box25.BackColor = Color.Yellow
            box24.BackColor = Color.White
            picbox2.Image = My.Resources.y_25
            intvalue = 0
            JoeTimer()
        End If

    End Sub

    Public Sub JoeTimer()
        'Reactivate timer and Check for matching values 
        joecounter += 1
        If Randomvalue - joecounter > 5 Then

            Timer1.Interval = joecounter * 2
        Else

            Timer1.Interval = joecounter * 6
        End If



        If joecounter = Randomvalue Then
            Timer1.Enabled = False
            joecounter = 0

            If box1.BackColor = Color.Yellow Then
                box1.BackColor = Color.Red
                spinvalue = 1000
                picbox2.Image = My.Resources.r_1
            End If

            If box2.BackColor = Color.Yellow Then
                box2.BackColor = Color.Red
                spinvalue = 5000
                picbox2.Image = My.Resources.r_2
            End If

            If box3.BackColor = Color.Yellow Then
                box3.BackColor = Color.Red
                spinvalue = 1000
                picbox2.Image = My.Resources.r_3
            End If

            If box4.BackColor = Color.Yellow Then
                box4.BackColor = Color.Red
                'Brankrupt
                spinvalue = 0
                picbox2.Image = My.Resources.r_4
            End If

            If box5.BackColor = Color.Yellow Then
                box5.BackColor = Color.Red
                'Skip
                spinvalue = 0
                picbox2.Image = My.Resources.r_5
            End If

            If box6.BackColor = Color.Yellow Then
                box6.BackColor = Color.Red
                spinvalue = 1000
                picbox2.Image = My.Resources.r_6
            End If

            If box7.BackColor = Color.Yellow Then
                box7.BackColor = Color.Red
                spinvalue = 1000
                picbox2.Image = My.Resources.r_7
            End If

            If box8.BackColor = Color.Yellow Then
                box8.BackColor = Color.Red
                spinvalue = 2000
                picbox2.Image = My.Resources.r_8
            End If

            If box9.BackColor = Color.Yellow Then
                box9.BackColor = Color.Red
                spinvalue = 1000
                picbox2.Image = My.Resources.r_9
            End If

            If box10.BackColor = Color.Yellow Then
                box10.BackColor = Color.Red
                spinvalue = 2000
                picbox2.Image = My.Resources.r_10
            End If

            If box11.BackColor = Color.Yellow Then
                box11.BackColor = Color.Red
                spinvalue = 5000
                picbox2.Image = My.Resources.r_11
            End If

            If box12.BackColor = Color.Yellow Then
                box12.BackColor = Color.Red
                'Skip
                spinvalue = 0
                picbox2.Image = My.Resources.r_12
            End If

            If box13.BackColor = Color.Yellow Then
                box13.BackColor = Color.Red
                spinvalue = 1000
                picbox2.Image = My.Resources.r_13
            End If

            If box14.BackColor = Color.Yellow Then
                box14.BackColor = Color.Red
                spinvalue = 1000
                picbox2.Image = My.Resources.r_14
            End If

            If box15.BackColor = Color.Yellow Then
                box15.BackColor = Color.Red
                spinvalue = 2000
                picbox2.Image = My.Resources.r_15
            End If

            If box16.BackColor = Color.Yellow Then
                box16.BackColor = Color.Red
                spinvalue = 1000
                picbox2.Image = My.Resources.r_16
            End If

            If box17.BackColor = Color.Yellow Then
                box17.BackColor = Color.Red
                spinvalue = 2000
                picbox2.Image = My.Resources.r_17
            End If

            If box18.BackColor = Color.Yellow Then
                box18.BackColor = Color.Red
                spinvalue = 10000
                picbox2.Image = My.Resources.r_18
            End If

            If box19.BackColor = Color.Yellow Then
                box19.BackColor = Color.Red
                'Bankrupt
                spinvalue = 0
                picbox2.Image = My.Resources.r_19
            End If

            If box20.BackColor = Color.Yellow Then
                box20.BackColor = Color.Red
                spinvalue = 2000
                picbox2.Image = My.Resources.r_20
            End If

            If box21.BackColor = Color.Yellow Then
                box21.BackColor = Color.Red
                spinvalue = 1000
                picbox2.Image = My.Resources.r_21
            End If

            If box22.BackColor = Color.Yellow Then
                box22.BackColor = Color.Red
                spinvalue = 5000
                picbox2.Image = My.Resources.r_22
            End If

            If box23.BackColor = Color.Yellow Then
                box23.BackColor = Color.Red
                'Skip
                spinvalue = 0
                picbox2.Image = My.Resources.r_23
            End If

            If box24.BackColor = Color.Yellow Then
                box24.BackColor = Color.Red
                spinvalue = 2000
                picbox2.Image = My.Resources.r_24
            End If

            If box25.BackColor = Color.Yellow Then
                box25.BackColor = Color.Red
                spinvalue = 1000
                picbox2.Image = My.Resources.r_25
            End If


            lblwinmoney.Text = "You win : " + spinvalue.ToString + " dollars"

        Else
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub picbox2_Click(sender As Object, e As EventArgs) Handles picbox2.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        guessword.Show()
        Me.Hide()

    End Sub
End Class
