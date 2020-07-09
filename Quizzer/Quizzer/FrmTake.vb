Public Class FrmTake
    Private questions As QuestionHandler = New QuestionHandler()
    Private quizFinished As Boolean = False

    Private Sub FrmTake_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("All current answers will be erased!" + Environment.NewLine + "Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            FrmMain.Show()
            Return
        End If
        e.Cancel = True
    End Sub

    Public Sub InitializeQuiz(fileName As String)
        'Gets the file name from the main form and imports the questions from it, then loads the first question
        questions.ImportQuestions(fileName)
        LoadQuestion()
    End Sub

    Private Sub SaveAnswer()
        'Saves the answer selected. Could be refactored, but it's so short it doesn't really matter much
        Dim question As Question = questions.GetQuestion()

        question.SelectedAnswer = 1
        If RdoAnswer2.Checked Then
            question.SelectedAnswer = 2
        ElseIf RdoAnswer3.Checked Then
            question.SelectedAnswer = 3
        ElseIf RdoAnswer4.Checked Then
            question.SelectedAnswer = 4
        End If
    End Sub

    Private Sub LoadQuestion()
        'Loads currently selected question and update the on-screen view
        LblQuestionNum.Text = "Question " + questions.SelectedQuestion.ToString() + " of " + questions.GetNumQuestions().ToString()
        Dim question As Question = questions.GetQuestion()
        LblQuestion.Text = question(0)
        RdoAnswer1.Text = question(1)
        RdoAnswer2.Text = question(2)
        RdoAnswer3.Text = question(3)
        RdoAnswer4.Text = question(4)

        Select Case question.SelectedAnswer
            Case 1
                RdoAnswer1.Checked = True
            Case 2
                RdoAnswer2.Checked = True
            Case 3
                RdoAnswer3.Checked = True
            Case 4
                RdoAnswer4.Checked = True
        End Select

        If quizFinished And question.CorrectAnswer = question.SelectedAnswer Then
            LblIncorrect.Hide()
            LblCorrect.Show()
        ElseIf quizFinished Then
            LblCorrect.Hide()
            LblIncorrect.Show()
        End If

        If questions.SelectedQuestion = questions.GetNumQuestions() And Not quizFinished Then
            BtnResults.Enabled = True
        Else
            BtnResults.Enabled = False
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        'Moves to the next question
        SaveAnswer()
        questions.SelectNext()
        LoadQuestion()
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        'Moves to the previous question
        SaveAnswer()
        questions.SelectPrevious()
        LoadQuestion()
    End Sub

    Private Sub BtnResults_Click(sender As Object, e As EventArgs) Handles BtnResults.Click
        'Process the results of the quiz
        If MessageBox.Show("You will no longer be able to change your answers!" + Environment.NewLine + "Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            SaveAnswer()
            quizFinished = True
            RdoAnswer1.Enabled = False
            RdoAnswer2.Enabled = False
            RdoAnswer3.Enabled = False
            RdoAnswer4.Enabled = False

            Dim sum As Integer = 0
            For Each question As Question In questions.GetAllQuestions()
                If question.CorrectAnswer = question.SelectedAnswer Then
                    sum += 1
                End If
            Next

            LblScore.Text = "Score: " + (sum / questions.GetNumQuestions() * 100).ToString("N") + "%"
            LblScore.Show()

            questions.SelectedQuestion = 1
            LoadQuestion()
        End If
    End Sub
End Class