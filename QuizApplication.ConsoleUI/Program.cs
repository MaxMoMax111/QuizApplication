using QuizApplication.Domain.Questions;

var question1 = new Question();
var question2 = new Question("What is the capital of the UK?");
var question3 = new Question("What is the capital of the USA?", "London", "New York", "Washington, D.C.", "San Diego", 'C');
var question4 = new Question
{
    QuestionText = "What is the capital of the Ukraine?", OptionA = "Kyiv", OptionB = "Odesa", OptionC = "Lviv",
    OptionD = "Dnepr", CorrectAnswerLetter = 'A'
};

var f = question4.AreOptionsValid();
var e = question1.AreOptionsValid();
Console.WriteLine();