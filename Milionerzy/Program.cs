using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy
{
    class Program
    {

        static void Main(string[] args)
        {
            QuestionRepository questionRepository = new QuestionRepository();

            List<int> usedQuestionIds = new List<int>();

            for (int questionNumber=1; questionNumber<= 4; questionNumber++)
            {
                Question question = null;

                do
                {
                    question = questionRepository.GetNextQuestion();

                } while (usedQuestionIds.Any(id  => id == question.ID));

                WriteQuestion(questionNumber, question);

                usedQuestionIds.Add(question.ID);

                Console.ReadLine();

            }
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
