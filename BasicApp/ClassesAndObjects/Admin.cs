class Admin : Person
{
    public string permission = "";


    public Admin (string n, string p, DateTime d, char g) : base(n, d, g)
    {   
        permission = p;  
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"\t\t{permission}");
    }

    // Static member
    public static void PrintHeader()
    {
        var header = $"Name\t\tDate Of Birth\t\tGender\t\tPermission";
        Console.WriteLine(header);
    }
}