using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity.Session
{
    public class QuizQuestions
    {
        public string SessID { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; }
        public List<string> Option { get; set; }
        public string SelectedOption { get; set; }
    }
    public class SessionList
    {
        public string SessionID { get; set; }        public string Title { get; set; }

    }
    public class EditQuizQuestions
    {
        public int QuestionID { get; set; }        public string QuestionText { get; set; }        public string QuestionType { get; set; }        //public int ChapterID { get; set; }        //public int SubChapterID { get; set; }        public string PlayDuration { get; set; }        public string VideoURL { get; set; }        public List<SelectedQuizAnswerAndOption> Options { get; set; }        public int QuestionCount { get; set; }        public int QuestionAssign { get; set; }    }
    public class QuizDetail
    {
        public int QuizID { get; set; }        public string SessID { get; set; }        public string QuestionList { get; set; }        public int QuestionAssign { get; set; }        public int TotalQuestion { get; set; }        public int QuizCount { get; set; }        public string QuizTitle { get; set; }    }
    public class SelectedQuizAnswerAndOption
    {
        public bool selected { get; set; }        public string option { get; set; }
    }
    public class QuizSeenDetail
    {
        public int AccessInfoID { get; set; }
        public int CompanyID { get; set; }
        public string SessionID { get; set; }
        public string ContactID { get; set; }
        public int QuizID { get; set; }
        public string QuizDate { get; set; }
        public string QuestionAnswerSet { get; set; }
        public string QuizResult { get; set; }
        public string AnswerFlag { get; set; }
        public QuizSeenUserDetail QuizUser { get; set; }
    }
    public class QuizSeenQuestion
    {
        public int    QuestionID { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string SelectedOption { get; set; }
    }
    public class QuizSeenUserDetail
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string IPAddress { get; set; }
    }
    public class PlayerChapterList
    {
        public string ChapterName { get; set; }
        public int ChapterID { get; set; }
        public double Ordinal { get; set; }
        public int Parameter { get; set; }
        public string ChapterStage { get; set; }

    }
}
