using System;
using System.Collections.Generic;
using System.Text;

namespace ZES_Exam
{
    class RemoveSameObject : IEqualityComparer<Question>
    {
        public bool Equals(Question x, Question y)
        {
            return x.questionID.Equals(y.questionID);//可以自定义去重规则
        }
        public int GetHashCode(Question obj)
        {
            return obj.questionID.GetHashCode();
        }
    }
}
