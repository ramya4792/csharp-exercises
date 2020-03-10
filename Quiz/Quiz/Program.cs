using System;
using System.Collections.Generic;
using System.Linq;
namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz();
            Question q1 = new MultipleChoice("What is 1+1?", new List<string> { "1", "2", "3", "4" }, "2");            
            quiz.Add(q1);
            Question q2 = new TrueOrFalse("Is 1+1 is 2?","true");
            quiz.Add(q2);
            Question q3 = new Checkbox("What is 1+1?", new List<string> { "1", "2", "Two", "3" }, new List<string> { "2", "3" });
            quiz.Add(q3);
            quiz.Run();
            quiz.Grade();

            /*string option;

            do
            {
                Console.WriteLine("It's Quiz time.What do you want(Press ENTER to quit)?\n1.Add Question\n2.Run the Quiz\n3.Grade the Quiz");

                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Which type of question you want to enter?\n1.Multiple Choice\n2.True/false\n3.Checkbox.");
                        string questionType = Console.ReadLine();
                        Console.WriteLine("Enter the QuestionText to add.");
                        string questionText = Console.ReadLine();
                        switch (questionType)
                        {
                            case "1":
                                Console.WriteLine("Enter 4 options seperated by comma");
                                List<string> options = Console.ReadLine().Split(",").ToList();
                                for (int i = 0; i < 4; i++)
                                    Console.WriteLine("{0}.{1}", i + 1, options[i]);
                                Console.WriteLine("Choose the correct answer option");
                                string answer = Console.ReadLine();
                                Question q = new MultipleChoice(questionText, options, answer);
                                quiz.Add(q);
                                break;
                            case "2":
                                Console.WriteLine("enter true/false.");
                                break;
                            case "3":
                                break;
                        }

                        break;
                    case "2":
                        quiz.Run();
                        break;
                    case "3":
                        quiz.Grade();
                        break;
                    default:
                        Console.WriteLine("Choose a valid option.");
                        break;

                }
            } while (option != "");*/

        }
    }
}

