Imports System.IO
Imports System.Windows.Forms.LinkLabel
Imports System.Xml.Schema

Public Class guessword

    Dim THEWORDO As String
    Dim fileL As String
    Dim hiddenwordo As String
    Dim randomnumba As New Integer
    Dim counter As Integer = 0
    Dim getridofspaces As Integer
    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click


        'Opening and Selecting file

        Dim openfile As New OpenFileDialog()

        If openfile.ShowDialog() = DialogResult.OK Then

            Dim fileP As String = openfile.FileName
            'Reading Line
            Using reader As New System.IO.StreamReader(fileP)

                Dim line As String = reader.ReadLine()

                While line IsNot Nothing 'Checking for when the line variable reaches the end 

                    invisdisplay.Items.Add(line) 'adding it onto the invisible listbox

                    line = reader.ReadLine() 'Reassigning line variable to the next line of the notepad 

                End While

            End Using

        End If

        randomnumba = (Rnd() * 4) + 1

        THEWORDO = invisdisplay.Items(randomnumba)

        lblrandomizedsentence.Text = THEWORDO
        lblword.Text = THEWORDO

        ' THEWORDO = THEWORDO.Replace(" ", "")

        For Each x In THEWORDO
            If x <> " " Then
                hiddenwordo += "-"
            Else
                hiddenwordo += " "
            End If
        Next

        'While counter < THEWORDO.Length
        'hiddenwordo += "-"
        ' hiddenwordo += " "
        '   counter += 1
        ' End While



        lblword.Text = hiddenwordo

        MsgBox(hiddenwordo & " " & THEWORDO)

        counter = 0

        THEWORDO.ToUpper()

        funck(" ")
    End Sub




    Sub funck(Letor)

        'Removig and replacing 
        If THEWORDO.Contains(Letor) Then
            For lettercounter As Integer = 0 To THEWORDO.Length - 1
                If THEWORDO(lettercounter) = Letor Then
                    hiddenwordo = hiddenwordo.Remove(lettercounter, 1)
                    hiddenwordo = hiddenwordo.Insert(lettercounter & " ", Letor)
                    lblword.Text = hiddenwordo
                End If
            Next
        End If
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnA.Click
        'Chaging color 
        If THEWORDO.Contains("A") = True Then
            btnA.BackColor = Color.Green
        Else btnA.BackColor = Color.Red
        End If
        'Passing letter to function/sub
        funck("A")
        btnA.Enabled = False



    End Sub


    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        'Chaging color 
        If THEWORDO.Contains("B") = True Then
            btnB.BackColor = Color.Green
        Else btnB.BackColor = Color.Red
        End If
        'Passing letter to function/sub
        funck("B")
        btnB.Enabled = False

    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        'Chaging color 
        If THEWORDO.Contains("C") = True Then
            btnC.BackColor = Color.Green
        Else btnC.BackColor = Color.Red
        End If
        'Passing letter to function/sub
        funck("C")
        btnC.Enabled = False
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click

        'Chaging color 
        If THEWORDO.Contains("D") = True Then
            btnD.BackColor = Color.Green
        Else btnD.BackColor = Color.Red
        End If
        'Passing letter to function/sub
        funck("D")
        btnD.Enabled = False
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        'Chaging color 
        If THEWORDO.Contains("E") = True Then
            btnE.BackColor = Color.Green
        Else btnE.BackColor = Color.Red
        End If
        'Passing letter to function/sub
        funck("E")
        btnE.Enabled = False
    End Sub
End Class