using System;

namespace Quiz
{
    public abstract class Question
    {
        private static int questionNumber = 1;
        internal int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        internal  virtual string Answer { get; set; }
        internal virtual string UserInput { get; set; }

        public Question(string quesionText)
        {
            QuestionNumber = questionNumber++;
            QuestionText = quesionText;
            
        }
        public virtual void Display()
        {
            Console.WriteLine(QuestionNumber +"."+QuestionText);
            string input = Console.ReadLine();
            UserInput = input;
        }
        public virtual bool IsCorrect()
        {
            if (UserInput== Answer)
                return true;
            else
                return false;
        }

    }
}