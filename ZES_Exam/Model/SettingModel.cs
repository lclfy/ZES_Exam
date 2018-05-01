using System;
using System.Collections.Generic;
using System.Text;

namespace ZES_Exam.Model
{
    public class SettingModel
    {
        public bool rankModeEnabled { get; set; }
        public int originalScore { get; set; }
        public int singleQuestionScore { get; set; }
        //错了是否扣分
        public bool scoreNoDeduction { get; set; }
        //计分清零（不保存）
        public bool clearData { get; set; }
        //有新的初始分数（不保存）
        public bool hasNewOriginalScore { get; set; }
        //进入过计分模式（不保存）
        public bool haveRankModeData { get; set; }
        public int countingTime { get; set; }
        //计时器是否开启
        public bool timerStarted { get; set; }
        public int selectQuestionMode { get; set; }
        public List<QuestionCategory> questionCategory { get; set; }
        
        //进入时选择的文件也保存一下
        public string nameFile { get; set; }
        public string testFile { get; set; }


    }
}
