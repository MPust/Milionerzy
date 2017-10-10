using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// ToDo
/// -Przerwac gre po błednej odpowiedzi 
/// - wyjsc z gracja :)
/// </summary>

namespace Milionerzy
{
    class Program
    {
        //Zmienne
        static QuestionRepository questionRepository = new QuestionRepository();
        static List<int> usedQuestionIds = new List<int>();

        static void Main(string[] args)
        {

         

            for (int questionNumber = 1; questionNumber <= 4; questionNumber++)
            {
                Question question = GetNextQuestion();

                WriteQuestion(questionNumber, question);

                char answer = GetuserAnswer();

                if (question.IsCorrectAnswer(answer))
                    Console.WriteLine("Gratulacje - przechodzisz dalej!");
                else
                {
                    Console.WriteLine($"Przykro mi - zła odpowiedź. Prawidłowa odpowiedź to {question.Answer}");
                    Environment.Exit(0);
                }
            }




        }

        private static char GetuserAnswer()
        {
            char answer = Console.ReadLine().FirstOrDefault();

            return answer;
        }

        private static Question GetNextQuestion()
        {


            Question question = null;

            do
            {
                question = questionRepository.GetNextQuestion();

            }
            while (usedQuestionIds.Any(id => id == question.ID));

            usedQuestionIds.Add(question.ID);

            return question;

        }
        private static void WriteQuestion(int questionNumber, Question question)
        {
            Console.WriteLine($"Pytanie numer {questionNumber}:");

            Console.WriteLine(question.Text);
            Console.WriteLine($"A:{question.AnswerA}");
            Console.WriteLine($"B:{question.AnswerB}");
            Console.WriteLine($"C:{question.AnswerC}");
            Console.WriteLine($"D:{question.AnswerD}");
        }
    }
}
