class Student 
{
    public string name;
    public int rollNumber;
    public DateTime dateOfBirth;
    public string resume;
     public char gender;
   public Student(string n , int r, DateTime d, string re, char g){
    name=n;
    rollNumber=r;
    dateOfBirth=d;
    resume=re;
    gender=g;
   }
  
    public void AllDetails(){
        var message =  $"{name} \t {rollNumber} \t\t {dateOfBirth.ToShortDateString()}\t\t {resume}\t\t {gender}";
        
        Console.WriteLine(message);
    }
    public static void PrintHeader(){
        Console.WriteLine($"Name \t Rollnumber \t Date Of Birth  \t Resume \t Gender");

    }

}