Imports System.Random
Imports System.IO.Directory
Imports System.Drawing.Size
Imports System

Public Class Form1
    Dim Alea As New Random()
    Dim ITab(5) As Image
    Dim ITab1(5) As Image
    Dim Nbrlancer As Integer = 5
    Dim Score As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        GetCurrentDirectory()
        For i As Integer = 0 To 5
            ITab(i) = Image.FromFile(GetCurrentDirectory() & "\..\..\images\de" & i & ".png")
            ITab1(i) = Image.FromFile(GetCurrentDirectory() & "\..\..\images\de" & i & ".png")
        Next
        Me.de.Text = vbCr & vbCr & "Le dé apparaitra ici"
        Me.de1.Text = vbCr & vbCr & "Le dé apparaitra ici"
        de.Cursor = Cursors.Hand
        de1.Cursor = Cursors.Hand
        Lancer.Cursor = Cursors.Hand
        Reinit.Cursor = Cursors.Hand
        Reinit.Enabled = False
        

    End Sub
    Private Sub Reinit_Click(sender As Object, e As EventArgs) Handles Reinit.Click
        Nbrlancer = 5
        Lancer.Enabled = True
        Score = 0
        Me.ScoreInt.Text = Score
        Me.LRInt.Text = Nbrlancer
        Reinit.Enabled = False
        de.Enabled = True
        de1.Enabled = True
        de.Left = 46
        de.Top = 30
        de1.Left = 228
        de1.Top = 30
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lancer.Click
        Me.de.Text = ""
        Me.de1.Text = ""
        Reinit.Enabled = False
        Do
            Nbrlancer -= 1
        Loop Until (Nbrlancer > -1)
        If Nbrlancer < 1 Then
            Lancer.Enabled = False
            Reinit.Enabled = True
            de.Enabled = False
            de1.Enabled = False

        End If
        For i = 0 To GenAlea2()
            de.Image = ITab(GenAlea())
            de.Refresh()
            System.Threading.Thread.Sleep(Alea.Next(100, 120))
            de1.Image = ITab1(GenAlea1())
            de1.Refresh()
            System.Threading.Thread.Sleep(Alea.Next(100, 120))
            de.Left += Alea.Next(-10, 10)
            de.Top += Alea.Next(-10, 10)
            de1.Left += Alea.Next(-10, 10)
            de1.Top -= Alea.Next(-10, 10)
            If de.Location.Y < 2 Or de.Location.X < 2 Then
                de.Top += 5
                de.Left += 5
            End If
            If de1.Location.Y < 2 Or de1.Location.X < 2 Then
                de1.Top += 5
                de1.Left += 5
            End If
        Next

        Me.de.Image = ITab(GenAlea())
        Me.de1.Image = ITab1(GenAlea1())
        Score = Score + (GenAlea() + GenAlea1() + 2)
        Me.LRInt.Text = Nbrlancer & ""
        Me.ScoreInt.Text = Score & ""
    End Sub



    Private Function GenAlea()
        Dim OAlea As New Random()
        Dim NbrAlea As Integer = OAlea.Next(0, 6)
        Return NbrAlea
    End Function

    Private Function GenAlea1()
        Dim OAlea1 As New Random()
        Dim NbrAlea1 As Integer
        For i = 0 To 4
            NbrAlea1 = OAlea1.Next(0, 6)
        Next
        Return NbrAlea1
    End Function

    Private Function GenAlea2()
        Dim OAlea2 As New Random()
        Dim NbrAlea2 As Integer = OAlea2.Next(10, 25)
        Return NbrAlea2
    End Function

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles de.Click
        Me.de.Text = ""
        Me.de1.Text = ""
        Do
            Nbrlancer -= 1
        Loop Until (Nbrlancer > -1)
        If Nbrlancer < 1 Then
            Lancer.Enabled = False
            Reinit.Enabled = True
            de.Enabled = False
            de1.Enabled = False

        End If
        For i = 0 To 5
            de.Image = ITab(GenAlea())
            de.Refresh()
            System.Threading.Thread.Sleep(Alea.Next(80, 100))
            de1.Image = ITab1(GenAlea1())
            de1.Refresh()
            System.Threading.Thread.Sleep(Alea.Next(80, 100))
            de.Left += Alea.Next(-3, 3)
            de.Top += Alea.Next(-3, 3)
            de1.Left += Alea.Next(-3, 3)
            de1.Top -= Alea.Next(-3, 3)
        Next

        Me.de.Image = ITab(GenAlea())
        Me.de1.Image = ITab1(GenAlea1())
        Score = Score + (GenAlea() + GenAlea1() + 2)
        Me.LRInt.Text = Nbrlancer & ""
        Me.ScoreInt.Text = Score & ""
    End Sub


    Private Sub de1_Click(sender As Object, e As EventArgs) Handles de1.Click
        Me.de.Text = ""
        Me.de1.Text = ""
        Do
            Nbrlancer -= 1
        Loop Until (Nbrlancer > -1)
        If Nbrlancer < 1 Then
            Lancer.Enabled = False
            Reinit.Enabled = True
            de.Enabled = False
            de1.Enabled = False

        End If
        For i = 0 To 5
            de.Image = ITab(GenAlea())
            de.Refresh()
            System.Threading.Thread.Sleep(Alea.Next(80, 100))
            de1.Image = ITab1(GenAlea1())
            de1.Refresh()
            System.Threading.Thread.Sleep(Alea.Next(80, 100))
            de.Left += Alea.Next(-3, 3)
            de.Top += Alea.Next(-3, 3)
            de1.Left += Alea.Next(-3, 3)
            de1.Top -= Alea.Next(-3, 3)
        Next

        Me.de.Image = ITab(GenAlea())
        Me.de1.Image = ITab1(GenAlea1())
        Score = Score + (GenAlea() + GenAlea1() + 2)
        Me.LRInt.Text = Nbrlancer & ""
        Me.ScoreInt.Text = Score & ""
    End Sub
End Class
