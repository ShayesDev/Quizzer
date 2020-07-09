Public Class FrmCreate
    Private questions As QuestionHandler = New QuestionHandler()
    Private Sub FrmCreate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Confirms if the user wants to leave the creator mode, and if so loads the main form
        If MessageBox.Show("All unsaved data will be erased!" + Environment.NewLine + "Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            FrmMain.Show()
            Return
        End If
        e.Cancel = True
    End Sub

    Private Sub FrmCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads the current question when the form loads
        LoadQuestion()
    End Sub

    Private Function CreateQuestion() As Question
        'Creates a question 
        Return New Question(TxtQuestion.Text, TxtAnswer1.Text, TxtAnswer2.Text, TxtAnswer3.Text, TxtAnswer4.Text, CboCorrect.Text)
    End Function

    Private Sub SaveQuestion()
        'Saves the current question
        questions.SetQuestion(CreateQuestion())
    End Sub

    Private Sub LoadQuestion()
        'Loads currently selected question and update the on-screen view
        LblQuestionNum.Text = "Question " + questions.SelectedQuestion.ToString() + " of " + questions.GetNumQuestions().ToString()
        Dim question As Question = questions.GetQuestion()
        TxtQuestion.Text = question(0)
        TxtAnswer1.Text = question(1)
        TxtAnswer2.Text = question(2)
        TxtAnswer3.Text = question(3)
        TxtAnswer4.Text = question(4)
        CboCorrect.SelectedIndex = Convert.ToInt32(question(5)) - 1
    End Sub

    Private Sub TsbLoad_Click(sender As Object, e As EventArgs) Handles TsbLoad.Click
        'Loads a quiz file to be edited (.qz extension)
        If OfdCreator.ShowDialog() = DialogResult.OK Then
            If MessageBox.Show("All unsaved data will be erased!" + Environment.NewLine + "Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                questions.ImportQuestions(OfdCreator.FileName)
                LoadQuestion()
            End If
        End If
    End Sub

    Private Sub TsbSave_Click(sender As Object, e As EventArgs) Handles TsbSave.Click
        'Saves a quiz file for later editing or adminstering of test (.qz extension)
        If SfdCreator.ShowDialog() = DialogResult.OK Then
            SaveQuestion()
            questions.SelectedQuestion = 1
            LoadQuestion()

            For x = 1 To questions.GetNumQuestions()
                SaveQuestion()
                questions.SelectNext()
                LoadQuestion()
            Next
            questions.ExportQuestions(SfdCreator.FileName)
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        'Moves to the next question
        SaveQuestion()
        questions.SelectNext()
        LoadQuestion()
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        'Moves to the previous question
        SaveQuestion()
        questions.SelectPrevious()
        LoadQuestion()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        'Adds a new question
        SaveQuestion()
        questions.AddQuestion(QuestionHandler.EMPTYQUESTION)
        questions.SelectNext()
        LoadQuestion()
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        'Inserts a new question
        SaveQuestion()
        questions.InsertQuestion(QuestionHandler.EMPTYQUESTION)
        questions.SelectNext()
        LoadQuestion()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'Deletes the current question
        Dim result As DialogResult = MessageBox.Show("This question and its data will be deleted!" + Environment.NewLine + "Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            questions.RemoveQuestion()
            If questions.GetNumQuestions() = 0 Then
                questions.AddQuestion(QuestionHandler.EMPTYQUESTION)
            End If
            LoadQuestion()
        End If
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TxtQuestion.TextChanged, TxtAnswer4.TextChanged, TxtAnswer3.TextChanged, TxtAnswer2.TextChanged, TxtAnswer1.TextChanged
        'Makes sure the user cannot enter the "pipe" character in order to prevent data corruption
        Dim textBox As TextBox = sender
        textBox.Text = sender.Text.Replace("|", "")
    End Sub
End Class
