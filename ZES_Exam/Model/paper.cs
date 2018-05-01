using System;
using System.Collections.Generic;
using System.Text;

namespace ZES_Exam
{
    public class Paper
    {
        public string paperName { get; set; }
        public List<Question> questions { get; set; }

        public Paper()
        {
            paperName = "";
            questions = new List<Question>();
        }
    }
}
