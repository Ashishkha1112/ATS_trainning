// See https://aka.ms/new-console-template for more information
using System.Data.SqlTypes;

Console.WriteLine($"Name \t Rollnumber \t Date Of Birth  \t Resume \t Gender");
Student student = new();
 student.name = "Ashish";
student.rollNumber = 1;
student.dateOfBirth=new DateTime(1998,05,22);
student.resume = "BCA";
student.gender = 'M';
student.AllDetails();

Student student1 = new();
 student1.name = "Ram";
student1.rollNumber = 2;
student1.dateOfBirth=new DateTime(2000,11,15);
student1.resume = "BE";
student1.gender = 'M';
student1.AllDetails();


Student student3 = new();
 student3.name = "Sagar";
student3.rollNumber = 3;
student3.dateOfBirth=new DateTime(1999,05,02);
student3.resume = "BBA";
student3.gender = 'M';
student3.AllDetails();
