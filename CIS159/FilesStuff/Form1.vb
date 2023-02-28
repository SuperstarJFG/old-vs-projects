Public Class Form1
    Dim index As Integer
    Dim count As Integer
    Dim peopleArray(100) As Person

    Structure Person
        Public Name As String
        Public Email As String
        Public IsStudent As Boolean
        Public picture As String
    End Structure

    Public Sub show(i As Integer)
        If i >= 0 And i < count Then
            NameTextBox.Text = peopleArray(i).Name
            emailTextBox.Text = peopleArray(i).Email
            StudentCheckBox.Checked = peopleArray(i).IsStudent
            If IO.File.Exists(peopleArray(i).picture) Then
                studentPictureBox.Load(peopleArray(i).picture)
            Else
                studentPictureBox.Image = Nothing
            End If
        End If
    End Sub
    Public Sub clear()
        NameTextBox.Text = ""
        emailTextBox.Text = ""
        StudentCheckBox.Checked = False
        studentPictureBox.Image = Nothing
        NameTextBox.Focus()
    End Sub
    Private Sub FirstButton_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        index = 0
        show(index)
    End Sub

    Private Sub LastButton_Click(sender As Object, e As EventArgs) Handles LastButton.Click
        index = count - 1
        show(index)
    End Sub

    Private Sub PrevButton_Click(sender As Object, e As EventArgs) Handles PrevButton.Click
        If index > 0 Then
            index = index - 1
            show(index)
        End If
    End Sub
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If index < count - 1 Then
            index = index + 1
            show(index)
        End If
    End Sub


    Private Sub UpdateData(i As Integer)
        Dim p As Person
        p.Name = NameTextBox.Text
        p.Email = emailTextBox.Text
        p.IsStudent = StudentCheckBox.Checked
        p.picture = studentPictureBox.ImageLocation
        peopleArray(i) = p
        Save()
    End Sub
    Sub Save()
        Dim outFile As IO.StreamWriter
        outFile = IO.File.CreateText("people.txt")

        For idx = 0 To count - 1
            outFile.Write(peopleArray(idx).Name)
            outFile.Write(",")
            outFile.Write(peopleArray(idx).Email)
            outFile.Write(",")
            outFile.Write(peopleArray(idx).IsStudent)
            outFile.Write(",")
            outFile.Write(peopleArray(idx).picture)
            outFile.WriteLine()
        Next
        outFile.Close()
        ReadFile()
    End Sub
    Sub ReadFile()
        Dim inFile As IO.StreamReader
        inFile = IO.File.OpenText("people.txt")
        fileTextBox.Text = inFile.ReadToEnd
        inFile.Close()
    End Sub

    Sub ReadData()
        If IO.File.Exists("people.txt") Then
            Dim inFile As IO.StreamReader
            inFile = IO.File.OpenText("people.txt")
            Dim line As String
            Dim data() As String

            index = 0
            count = 0
            Do While inFile.Peek <> -1
                Dim p As New Person

                line = inFile.ReadLine
                data = line.Split(",")

                'Put the data from the file into the structure
                'Check the length to not try to read more than was in the file
                If data.Length > 0 Then p.Name = data(0)
                If data.Length > 1 Then p.Email = data(1)
                If data.Length > 2 Then Boolean.TryParse(data(2), p.IsStudent)
                If data.Length > 3 Then p.picture = data(3)

                peopleArray(count) = p
                count = count + 1

            Loop
            inFile.Close()
        End If
        index = 0
        show(index)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ReadData()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        'If they hit cancel and the new button was picked then we didn't add one, so subtract the count
        If Not NewButton.Enabled Then
            count = count - 1
            index = count - 1
        End If
        EnableDisableControls(False)

        show(index)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        UpdateData(index)
        EnableDisableControls(False)

    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        clear()
        count = count + 1
        index = count - 1
        EnableDisableControls(True)
    End Sub
    Sub EnableDisableControls(b As Boolean)
        NameTextBox.Enabled = b
        emailTextBox.Enabled = b
        StudentCheckBox.Enabled = b
        FirstButton.Enabled = Not b
        NextButton.Enabled = Not b
        LastButton.Enabled = Not b
        PrevButton.Enabled = Not b
        NewButton.Enabled = Not b
        updateButton.Enabled = Not b

        SaveButton.Visible = b
        CancelButton.Visible = b
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadData()
        EnableDisableControls(False)
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        EnableDisableControls(True)
        UpdateData(index)
    End Sub

    Private Sub studentPictureBox_Click(sender As Object, e As EventArgs) Handles studentPictureBox.Click
        'only let picture be set if the user hit update
        If updateButton.Enabled = False Then
            OpenFileDialog1.ShowDialog()
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        studentPictureBox.Load(OpenFileDialog1.FileName)
        UpdateData(index)
    End Sub
End Class
