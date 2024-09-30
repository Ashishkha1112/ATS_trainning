//Language Integrated Query
//used for querying collection

using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class LINQ
{
    int[] marks = [23,10,11,4,5,78,18,98,45];
    List<Student> students= [("Sita Bond", 68, new DateTime(1990, 1, 11), 'F'),];
  
  
    public void Test()
    {

        //Get List of pass marks
        List<int> passMark = [];
        foreach(var mark in marks){
            if (mark>=40)
            {
                passMark.Add(mark);
            }
        }
        // //Get List of pass marks
            var pMark = marks.Where(mark=>mark>=40); 
            //sum of pass marks
            var sumOfPM = marks.Where(mark=>mark>=40).Sum(); 

            //marks out of 10
            var marks10 =  marks.Select(mark=> (double)mark/10);
            // pass marks out of  10
            var pMarks10 =  marks.Where(mark=> mark>=40).Select(mark=> (double)mark/10);
            var pmarks10s = from mark in marks where>=40
            select (double)mark/10;




            var  sname =students.Where(s => (DateTime.Now -s.dateOfBirth).TotalDays/365>18)
            .Select(s => s.name);
    }
}