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
        /* Console.WriteLine("enter the first number: "); 
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
        */
        
        //conditional statements 
        //Console.WriteLine("enter your degree  ");
        //float degree = float.Parse(Console.ReadLine());

        /*if (degree < 50)
        {
            Console.WriteLine(" you failed ");
            
        }
        else
        {
             Console.WriteLine("you passed ");
        }
        */
        
        /* if (degree >= 0 && degree < 50)
        {
            Console.WriteLine(" you failed ");
            
        }
        else if (degree >= 50 && degree <= 60 )
        {
            Console.WriteLine("you passed with grade D ");
        }
        else if (degree >= 60 && degree <= 70)
        {
            Console.WriteLine("you passed with grade C ");
        }
        else if (degree >= 70 && degree <= 80)
            {
            Console.WriteLine("you passed with grade B ");
            }
        else if (degree >= 80)
        {
            Console.WriteLine("you passed with grade A ");
        }
        else
        {
            Console.WriteLine("you entered wrong number  ");
        } */
            
        //using switch = choice = options 

        Console.WriteLine("welcome to main menu :  ");
        Console.WriteLine("1.Deposit");
        Console.WriteLine("2.withdraw");
        Console.WriteLine("3.balance check");
        
        Console.WriteLine("please choose an option:  ");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1: 
                Console.WriteLine("Deposit successful");
                break;  
            case 2:
                Console.WriteLine("Withdraw successful");
                break;
            case 3:
                Console.WriteLine("Balance check successful");
                break;
            default: 
                Console.WriteLine("Invalid option");
                break;
        }








    }
}