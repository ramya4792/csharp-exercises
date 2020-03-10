using System;

namespace Quiz
{
    public class TrueOrFalse : Question
    {
        internal override string Answer { get; set; }
        public TrueOrFalse(string questionText, string answer) : base(questionText)
        {
            Answer = answer;
        }
        public override void Display()
        {
            Console.WriteLine("True/False Question: Enter true/false.");
            Console.WriteLine(QuestionNumber + "." + QuestionText);
            string input = Console.ReadLine();
            UserInput = input;
        }
    }
        
}