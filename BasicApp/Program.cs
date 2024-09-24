// See https://aka.ms/new-console-template for more information
using System.Data.SqlTypes;
Student.PrintHeader();

var student = new Student("Ashish",1,new DateTime(1998,05,22),"BCA",'M');
student.AllDetails();

var student1 = new Student("Ram",2,new DateTime(2000,11,15),"BCA",'M');
student1.AllDetails();
var student3 = new Student("Shyam",2,new DateTime(2001,11,15),"BBA",'M');
student3.AllDetails();


var methods = new Methods();
methods.SayHello();
methods.SayHello("Good Morning!");
string message=methods.SayHello("Hello","Good Morning!");

Console.WriteLine(message);


var g =  new Generics();

g.Print(56);
g.Print("hello");
