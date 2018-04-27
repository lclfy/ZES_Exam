using System;
using System.Collections.Generic;
using System.Text;

namespace ZES_Exam
{
    public class DataLogModel
    {
        public string time { get; set; }
        public bool rightOrWrong { get; set; }
        public string studentName { get; set; }
        public string className { get; set; }
        public string studentFile { get; set; }
        public string testName { get; set; }
        public string testFile { get; set; }
        public string questionName { get; set; }
        public string rightAnswer { get; set; }
    }
}
