class Myclass
{
    enum Grade { pass=60,Distinction=85};

    public static void Main()
    { 
int empid;
int mark;

 Console.WriteLine("whats your empid?");
empid = int.Parse(Console.ReadLine());
Console.WriteLine("hello world!");
Console.WriteLine($"thanks for giving emp id {empid}");

Console.WriteLine("enter the tsql marks");
mark = Convert.ToInt32(Console.ReadLine());
if (mark >=(int) Grade.Distinction)
{
    Console.WriteLine("you are Distinction");
}
else if (mark >=(int) Grade.pass)
{
    Console.WriteLine("you are pass ");
}
else
{
    Console.WriteLine("you are fail");
}
}
}
