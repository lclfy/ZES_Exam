using System;
using System.Collections.Generic;
using System.Text;

namespace ZES_Exam
{
    public class Question
    {
        public int questionID { get; set; }
        public string questionCategory { get; set; }
        public string questionName { get; set; }
        public string rightAnswer { get; set; }
        public string answers { get; set; }
        public string gradeForEachQuestion { get; set; }
    }
}
