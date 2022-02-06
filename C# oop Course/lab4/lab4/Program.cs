using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{


    public class Question
    {
        public int num { get; set; }
        public String body { get; set; }
        public int mark { get; set; }

        public Question()
        {

        }
        public Question(int _num,string _body,int _mark)
        {
            num = _num;
            body = _body;   
            mark = _mark;
        }
        public string printQuestion()
        {
            return $"\nnumber of Question: {num}\n body of Question: {body}\n Mark : {mark}";
        }
    }


    public class Exam
    {
        public int id { get; set; }
        DateTime time =new DateTime();
         
  
        
        public Question[] questions { get; set; }

        public Exam() { }
        public Exam( int _id,DateTime _time ,Question[] _questions)
        {
            
               id = _id;
               time = _time;
            questions = _questions; 

        }

        public string print()
        {
            string idtime = $"id = {id} ,time = {time}";
            for(int i = 0; i < questions.Length; i++)
            {
                
                idtime+=questions[i].printQuestion();
            }
            return idtime;
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pleade Enter Number of Questions ");
            Question[] arrOfQuestions = new Question[int.Parse(Console.ReadLine())];
            for(int i = 0; i < arrOfQuestions.Length; i++)
            {
                
                Console.WriteLine("Please Enter\n 1-number oF Questions \n 2- body of Question" +
                    " \n 3- mark odf this Question");
                arrOfQuestions[i] = new Question(int.Parse(Console.ReadLine())
                    ,Console.ReadLine()
                    ,int.Parse(Console.ReadLine()));

            }

            Console.WriteLine("Please Enter 1-Exam Id \n 2-Time of this Exam");
            Exam exam =new Exam(int.Parse(Console.ReadLine()),
                Convert.ToDateTime(Console.ReadLine()),arrOfQuestions);


            Console.WriteLine(  exam.print());

            Console.ReadKey();
        }
    }
}
