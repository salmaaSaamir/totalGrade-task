using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totalGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
           finalGrade();
           Console.ReadLine();
        }



        static int[] getSubjects() {
            
            Console.WriteLine("enter your number of sublect:");
            string numOfSubject = Console.ReadLine();
            int[] arr = new int[short.Parse(numOfSubject)];
            for (int i = 0;i<short.Parse(numOfSubject);i++)
            {
                Console.WriteLine("enter your subject number  "+ (i+1) +" :");
                int subject = short.Parse(Console.ReadLine());
                arr[i] = subject;
            }
            return arr;
        }
        static double calcTheGrade()
        {
            double sum = 0;
            int[] subjects = getSubjects();
            for(int i = 0; i < subjects.Length; i++)
            {
                sum += subjects[i];
                
            }
            double result = ((subjects.Length * 100) - sum) /(subjects.Length);
            return result;
        }
        static void finalGrade()
        {
            double grade = (100 -calcTheGrade());
            string x  = String.Format("{0:0.00}", grade);
            if (Convert.ToDouble(x)>85)
            {
                Console.WriteLine("your total grade is A (" + x + ")");
            }
            else if (grade > 50 && grade<60)
            {
                Console.WriteLine("your total grade is D (" + x + ")");
            }
            else if (grade > 60 && grade < 75)
            {
                Console.WriteLine("your total grade is C (" + x + ")");
            }
            else if (grade > 75 && grade < 85) { 
            
                Console.WriteLine("your total grade is B (" + x + ")");
            }
            else
            {
                Console.WriteLine("sorry your total grade is F (" + x + ")");
            } 

        }

    }
}
