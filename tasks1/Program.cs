namespace tasks1;

class Program
{
    static void Main(string[] args)
    {
       //task1 
        /*
        string name = ("Sara");
        Console.Write("Name: " + name);

        int age = 21;
        Console.Write("  Age: " + age);

        double hight = 1.65;
        Console.Write("  Hight: " + hight);

        bool student = true; 
        Console.Write("  student: " + student);
        */ 
        
        ///////////////////////////////////////////////////////
        
        //task2 
        Console.Write(" enter the Rectangle length:  ");
        float length =  float.Parse(Console.ReadLine());
        
        Console.Write(" enter the Rectangle Width:  ");
        float width =  float.Parse(Console.ReadLine());
        
        float area = length * width;
        float Perimeter = 2* (length + width);

        Console.WriteLine(" The result of Area is :  " + area);
        Console.WriteLine(" The Perimeter is :  " + Perimeter);







    }
}