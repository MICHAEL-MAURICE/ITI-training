using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public abstract class Questions 
    {
        public int id { get; set; }
        public string body { get; set; }
        public int mark { get; set; }
         
      public  Questions(int id,string body, int mark)
        {
            this.id = id;
            this.body = body;
                this.mark = mark;

        }
        public virtual void show()
        {
            Console.WriteLine( $"id= {id} \n body= {body} \n Mark = {mark}");
        }

    }


    public  class mcq:Questions
    {
        string[] answers = new string[5];
       

       

        public mcq(int id, string body, int mark, string[] answers) :base(id,body,mark)
        {
            this.answers= answers;
        }
        public override void show()
        {
            base.show();
            string txt = "Answers = ";
            for(int i = 0; i < answers.Length; i++)
            {
               txt+=answers[i]+"\t";
            }
            Console.WriteLine( txt);
            

        }


    }
    public class Trueorfalse : Questions
    {
        public bool isTrue { get; private set; }
        public bool isFalse { get; private set; }

        public Trueorfalse(int id, string body, int mark, bool isTrue,bool isFalse) : base(id, body, mark)
        {
            this. isTrue = isTrue;   
            this.isFalse = isFalse; 

        }
        public override void show()
        {
            base.show();
            string txt = $"Answers = {isTrue}/ {isFalse} ";



            Console.WriteLine( txt);


        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] answers = new string[5]
        {
            "Aaa","Bbb","Ccc","Ddd","Eee"
        };
            Questions q1 = new Trueorfalse(1, "hello", 50,true,false);
            q1.show();

            Questions q2 = new mcq(2, "hello", 50,answers);
            q2.show();

            Console.WriteLine("Please Enter the number of mcq questions : ");

            mcq []arr =new mcq[int.Parse(Console.ReadLine())];

            Console.WriteLine("PLEASE Enter \n  1-body Of Question \n 2- mark");
            for (int i = 0;i < arr.Length; i++)
            {
                Console.WriteLine($"PLEASE Enter Question {i + 1} = ");
                arr[i]= new mcq(i+1,Console.ReadLine(),int.Parse(Console.ReadLine()),answers);
            }
            for (int i = 0; i < arr.Length; i++)
            { 
            arr[i].show();
            
            }
                Console.ReadKey();
        }
    }
}
