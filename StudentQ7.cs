using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class StudentQ7
    {
        static void Main(string[] args)
        {
            int RollNo = 10;
            string name = "Rohan";
            double MarksInScince = 50;
            double MarksinMaths = 60;
            double MarksinEng = 40;

            double totalMarks = MarksinEng + MarksinMaths + MarksInScince;
            

            double maxMarksPerSubject = 100;
            double percentage=((totalMarks)/(maxMarksPerSubject*3))*100;
            Console.WriteLine("RollNo:"+RollNo);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("totalmarks:\t"+totalMarks);
            Console.WriteLine("percentage:\t"+percentage+"%");
        }
    }
}
