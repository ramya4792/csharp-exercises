using System;
using System.Collections.Generic;


namespace Quiz
{
    public class MultipleChoice : Question
    {
        internal List<string> Options { get; set; }

        internal override string Answer { get; set; }
        public MultipleChoice(string questionText, List<string> options, string answer) : base(questionText)
        {
            Options = options;
            Answer = answer;
        }
        public override void Display()
        {
            Console.WriteLine("Multiple choice Question: Enter the correct option.");
            Console.WriteLine(QuestionNumber + "." + QuestionText);
            for (int i = 0; i < 4; i++)
                Console.WriteLine(i+1 + "." +Options[i]);
            string input = Console.ReadLine();
            UserInput = input;
        }
    }
}