using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperation
{
    class StudentResult
    {
        public void DisplayStudentResult(string studentID)
        {
            try
            {
                ExamDataStore examData = new ExamDataStore();
                string result = examData.GetExamResult(studentID);

                //if(result=="Pass")
                if (result.Equals("Pass"))  
                {
                    Console.WriteLine("Rejoice! Your child has passed!");
                }
                else
                {
                    Console.WriteLine("Shame! Your child has failed!");
                }
            }
            catch (Exception e)
            {
                Log(e);
                Console.WriteLine("Sorry, we cant fetch the reults right now. Retry later.");
            }
        }

        public static void Log(Exception e)
        {

        }
    }
}
