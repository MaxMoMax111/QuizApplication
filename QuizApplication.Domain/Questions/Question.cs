namespace QuizApplication.Domain.Questions;

public class Question
{
    public string? QuestionText;
    public string? OptionA;
    public string? OptionB;
    public string? OptionC;
    public string? OptionD;
    public char? CorrectAnswerLetter;
    private static char _defaultCorrectAnswerLetter = 'X';

    public Question()
    {
        QuestionText = null;
        OptionA = null;
        OptionB = null;
        OptionC = null;
        OptionD = null;
        CorrectAnswerLetter = _defaultCorrectAnswerLetter;
    }

    public Question(string questionText)
    {
        QuestionText = questionText;
        OptionA = null;
        OptionB = null;
        OptionC = null;
        OptionD = null;
        CorrectAnswerLetter = _defaultCorrectAnswerLetter;
    }

    public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
    {
        QuestionText = questionText;
        OptionA = optionA;
        OptionB = optionB;
        OptionC = optionC;
        OptionD = optionD;

        if (correctAnswerLetter is 'A' or 'B' or 'C' or 'D')
        {
            CorrectAnswerLetter = correctAnswerLetter;
        }
        else
        {
            CorrectAnswerLetter = _defaultCorrectAnswerLetter;
        }
    }

    public bool AreOptionsValid()
    {
        var validOptions = 0;

        if (OptionA != null)
        {
            validOptions += 1;
        }

        if (OptionB != null)
        {
            validOptions += 1;
        }

        if (OptionC != null)
        {
            validOptions += 1;
        }

        if (OptionC != null)
        {
            validOptions += 1;
        }

        return validOptions >= 2;
    }
}