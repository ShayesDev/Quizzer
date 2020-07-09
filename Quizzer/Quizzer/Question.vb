Public Class Question
    Public Shared ReadOnly EMPTY As String() = {"", "", "", "", "", "1"}
    Private question As String()
    Private _selectedAnswer As Integer = 1
    Private _correctAnswer As Integer

    Property SelectedAnswer() As Integer
        Get
            Return _selectedAnswer
        End Get
        Set(value As Integer)
            If value > 4 Then
                value = 4
            ElseIf value < 1 Then
                value = 1
            End If

            _selectedAnswer = value
        End Set
    End Property

    Property CorrectAnswer() As Integer
        Get
            Return _correctAnswer
        End Get
        Set(value As Integer)
            If value > 4 Then
                value = 4
            ElseIf value < 1 Then
                value = 1
            End If

            _correctAnswer = value
        End Set
    End Property

    Default Property QuestionIndex(ByVal index As Integer) As String
        Get
            Return question(index)
        End Get
        Set(ByVal value As String)
            question(index) = value
        End Set
    End Property

    Public Sub New()
        'Creates a new Question that is empty
        question = EMPTY
        CorrectAnswer = Convert.ToInt32(question(question.Length - 1))
    End Sub

    Public Sub New(q As String, a1 As String, a2 As String, a3 As String, a4 As String, c As String)
        'Creates a new question with the given arguments
        Me.New()
        question = {q, a1, a2, a3, a4, c}
    End Sub

    Public Sub New(questionString As String)
        'Creates a new question with the given arguments as a String, values separated by the "pipe" character
        question = questionString.Split("|".ToCharArray())
        CorrectAnswer = Convert.ToInt32(question(question.Length - 1))
    End Sub

    Public Sub New(questionArray As String())
        'Creates a new question with the given arguments as an Array
        question = questionArray
        CorrectAnswer = Convert.ToInt32(question(question.Length - 1))
    End Sub

    Public Function ToArray() As String()
        'Returns the question as an Array. Question is stored as an Array by default
        Return question
    End Function

    Public Overrides Function ToString() As String
        'Returns the question as a String, values separated by the "pipe" character
        Return String.Join("|", question)
    End Function
End Class
