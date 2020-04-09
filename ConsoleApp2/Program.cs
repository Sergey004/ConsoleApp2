using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            ShowMessage method = Show;


            student.Move(7, method);

        }
        static void Show(string message)
        {
            Console.WriteLine(message);
        }

        public delegate void ShowMessage(string message);
        


        public class Student
        {
            public void Move(int distance, ShowMessage method)
            {
                for (int i = 0; i <= distance; i++)
                {
                    Thread.Sleep(1000);
                    method(string.Format("Идеи перемещение... Пройдено километров {0}", i));
                }
            }

        }
    }
}       
