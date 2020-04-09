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
            //student.Moving  = Show;
            student.Moving += Student_Moving;

            student.Move(7);

        }

        private static void Student_Moving(object sender, Student.MovimgEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        static void Show(string message)
        {
            Console.WriteLine(message);
        }

        public delegate void ShowMessage(string message);
        


        public class Student
        {
            public void Move(int distance)
            {
                for (int i = 0; i <= distance; i++)
                {
                    Thread.Sleep(1000);
                    if (Moving != null)
                        Moving(this, new MovimgEventArgs(string.Format("Идеи перемещение... Пройдено километров {0}", i)));
                }
            }
            public event EventHandler<MovimgEventArgs> Moving;

            public class MovimgEventArgs : EventArgs
            {
                public MovimgEventArgs(string message)
                {
                    Message = message;
                }
                public string Message { get; private set; }
            }
           }
    }
}       
