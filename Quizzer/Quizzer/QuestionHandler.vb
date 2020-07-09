Public Class QuestionHandler
    Public Shared ReadOnly EMPTYQUESTION = New Question("", "", "", "", "", "1")
    Private questions As New List(Of Question)
    Private selectedIndex As Integer = 0
    Property SelectedQuestion() As Integer
        Get
            Return selectedIndex + 1
        End Get
        Set(value As Integer)
            selectedIndex = value - 1
            If value > questions.Count Then
                selectedIndex = questions.Count - 1
            ElseIf value < 1 Then
                selectedIndex = 0
            End If
        End Set
    End Property

    Public Sub New()
        'Creates a new QuestionHandler with one empty question
        questions.Add(EMPTYQUESTION)
    End Sub

    Public Sub SelectNext()
        'Selects the next question
        SelectedQuestion += 1
    End Sub

    Public Sub SelectPrevious()
        'Selects the previous question
        SelectedQuestion -= 1
    End Sub

    Public Sub AddQuestion(question As Question)
        'Adds question to list of questions
        questions.Add(question)
    End Sub

    Public Sub SetQuestion(question As Question)
        'Replaces the current question with the given question
        questions(selectedIndex) = question
    End Sub

    Public Sub SetQuestion(questionNumber As Integer, question As Question)
        'Replaces the question specified with the given question
        questions(questionNumber - 1) = question
    End Sub

    Public Sub InsertQuestion(question As Question)
        'Inserts question into list of questions
        questions.Insert(SelectedQuestion, question)
    End Sub

    Public Sub InsertQuestion(questionNumber As Integer, question As Question)
        'Inserts question into list of questions
        questions.Insert(questionNumber, question)
    End Sub

    Public Sub RemoveQuestion()
        'Removes currently selected question from list
        RemoveQuestion(SelectedQuestion)
    End Sub

    Public Sub RemoveQuestion(questionNumber As Integer)
        'Removes question from list by question number
        questions.RemoveAt(questionNumber - 1)
        SelectedQuestion = questionNumber
    End Sub

    Public Function GetQuestion() As Question
        'Returns the currently selected question
        Return questions.Item(selectedIndex)
    End Function

    Public Function GetAllQuestions() As List(Of Question)
        Return questions
    End Function

    Public Function GetNumQuestions() As Integer
        'Gets the total number of questions
        Return questions.Count()
    End Function

    Public Sub ImportQuestions(fileName As String)
        'Imports questions from a file
        Dim questionStrings As String()
        questions = New List(Of Question)
        If IO.File.Exists(fileName) Then
            questionStrings = IO.File.ReadAllLines(fileName)
        Else
            Console.WriteLine("Question file doesn't exist!")
            Return
        End If

        For Each questionString As String In questionStrings
            questions.Add(New Question(questionString))
        Next
    End Sub

    Public Sub ExportQuestions(fileName As String)
        'Exports questions to a file
        Dim questionStrings As New List(Of String)
        For Each question As Question In questions
            questionStrings.Add(question.ToString())
        Next

        IO.File.WriteAllLines(fileName, questionStrings)
    End Sub
End Class
