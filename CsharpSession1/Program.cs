namespace CsharpSession1;

class Program
{
    static void Main(string[] args)
    {
        /* //Printing for the user and providing an output  using different data types + using convert
        Console.Write("Please enter your name: ");
        string UserName = Console.ReadLine();
        
        Console.Write("Please enter your age: ");
        int UserAge = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter your Salary: ");
        float UserSalary = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Hello  " + UserName + "  welcome to Spark To Code"); */
        
        //operations 
        //arithmatic   
         Console.WriteLine("enter the first number: "); 
        float FirstNumner  = float.Parse(Console.ReadLine());
        
        Console.WriteLine("enter the second number: ");
        float SecondNumner  = float.Parse(Console.ReadLine());
        
        float addtionresult = FirstNumner + SecondNumner;
        float subresult = FirstNumner - SecondNumner;
        float multiplicationresult = FirstNumner * SecondNumner;
        float divisionresult = FirstNumner / SecondNumner;
        float modlutionresult = FirstNumner % SecondNumner;
        //logical 
        bool compasionResult = FirstNumner == SecondNumner;
        
        Console.WriteLine("Addtion result: " + addtionresult);
        Console.WriteLine("Subtraction result: " + subresult);
        Console.WriteLine("Multiplication result: " + multiplicationresult);
        Console.WriteLine("Division result: " + divisionresult);
        Console.WriteLine("Modulution result: " + modlutionresult);
        Console.WriteLine("Comparsion result : " + compasionResult);

        
        


    }
}