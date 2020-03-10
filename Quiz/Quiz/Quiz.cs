using System;
using System.Collections.Generic;


namespace Quiz
{
    public class Quiz
    {
        private List<Question> questions = new List<Question>();
        public void Add(Question questionText)
        {
           questions.Add(questionText);
        }
        public void Run()
        {
            Console.WriteLine("It's QuizTime..");
            foreach (Question q in questions)
                q.Display();
        }
        public void Grade()
        {
            int correct = 0;
            foreach (Question q in questions)
                if (q.IsCorrect())
                    correct++;

            double grade =(Convert.ToDouble(correct)/Convert.ToDouble(questions.Count)) * 100;
            Console.WriteLine(correct + "Correct Answers and obtain " +grade+ "%");
            
        }
    }
}