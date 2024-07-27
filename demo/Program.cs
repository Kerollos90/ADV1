using demo;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        int  index =Helper<int>.SearchArray(num, 55);
        Console.WriteLine($"{index}");


        Employee employee = new Employee() {Id=5 , Name ="test " , Salary=12};
        Employee employee01 = new Employee() {Id=9 , Name ="test " , Salary=12};
        if (employee == employee01)
            Console.WriteLine("true");
        else
            Console.WriteLine("false");



        if (employee.Equals( employee01))
            Console.WriteLine(true);









    }
}