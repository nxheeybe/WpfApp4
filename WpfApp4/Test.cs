using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    public class Test
    {
        public enum Answers
        {
            First,
            Second,
            Third
        }
        public Test(string name, string description, string firstAnswer, string secondAnswer, string thirdAnswer)
        {
            Name = name;
            Description = description;
            FirstAnswer = firstAnswer;
            SecondAnswer = secondAnswer;
            ThirdAnswer = thirdAnswer;

        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string FirstAnswer { get; set; }
        public string SecondAnswer { get; set; }
        public string ThirdAnswer { get; set; }
        public Answers RightAnswer { get; set; }
    }
}