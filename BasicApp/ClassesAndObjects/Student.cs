class Student 
{
    public string name;
    public int rollNumber;
    public DateTime dateOfBirth;
    public string resume;
     public char gender;
   
    public void StudentDetails(){
         Console.WriteLine(name);
        //  Console.WriteLine(rollNumber);
        //  Console.WriteLine(dateOfBirth);
        //  Console.WriteLine(gender);
    }
    public void AllDetails(){
        var message =  $"{name} \t {rollNumber} \t\t {dateOfBirth.ToShortDateString()}\t\t {resume}\t\t {gender}";
        
        Console.WriteLine(message);
    }

}