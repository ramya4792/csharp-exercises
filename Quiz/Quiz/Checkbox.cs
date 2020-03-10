using System;
using System.Collections.Generic;
using System.Linq;


namespace Quiz
{
    public class Checkbox : Question
    {
        internal List<string> Options { get; set; }
        
        internal new List<string> Answer { get; set; }
        internal new List<string> UserInput { get; set; }
        public Checkbox(string questionText, List<string> options, List<string> answers) : base(questionText)
        {
            Options = options;
            Answer = answers;
        }
        public override void Display()
        {
            Console.WriteLine("Checkbox Question:Enter all correct options seperated by ','");
            Console.WriteLine(QuestionNumber +"."+ QuestionText);
            for (int i = 0; i < 4; i++)
                Console.WriteLine(i+1 + "." +Options[i]);
            List<string> input = Console.ReadLine().Split(",").ToList();
            UserInput = input;
        }
        public override bool IsCorrect()
        { 
            if (Answer.SequenceEqual(UserInput))
                return true;
            else
                return false;
        }
    }
}