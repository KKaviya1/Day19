using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

//Task:1 create a custom attribute

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class CustomInfoAttribute : Attribute
{
    public string ClassName { get; }
    public int VersionNumber { get; }
    public string AdditionalInfo { get; }
    public CustomInfoAttribute(string classname, int versionNumber, string additionalInfo)
    {
        ClassName = classname;
        VersionNumber = versionNumber;
        AdditionalInfo = additionalInfo;
    }
}

//Task 2: Reflection on custom Attribute
[CustomInfo("Myclass",1,"this is a custom attribute example.")]
public class MyClass
{
    public void MyMethod()
    {
        Console.WriteLine("welcome to my Method");
    }
}

// Task 3: Dynamic method invocation
public class Calculator
{
    public int Add(int a, int b) { return a + b; }  
    public int Subtract(int a, int b) { return a - b; }  
    public int Multiply(int a, int b) { return a * b; }  
}
    public class Program
    {
        static void Main(string[] args)
        {
        Type myClassType = typeof(MyClass);
        var customAttribute = myClassType.GetCustomAttribute<CustomInfoAttribute>();

        Console.WriteLine("Task2: refelection on custom attribute");
        Console.WriteLine($"Class Name:{customAttribute.ClassName}");
        Console.WriteLine($"version number:{ customAttribute.VersionNumber}");
        Console.WriteLine($"Additional Info:{ customAttribute.AdditionalInfo}");

        // Task 3: Dynamic method invocation
        var calculator = new Calculator();
        Console.WriteLine("\nTask 3: Dynamic method invocation");
        Console.WriteLine("Available methods: Add, Subtract, Multiply");
        Console.WriteLine("enter method name:");
        string methodName = Console.ReadLine();

        MethodInfo method = typeof(Calculator).GetMethod(methodName);  
        if(method != null)
        {
            Console.WriteLine("enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            int result = (int)method.Invoke(calculator, new object[] { num1, num2 });
            Console.WriteLine($"result: {result}");
        }
        else
        {
            Console.WriteLine("invalid method name");
        }


        Console.ReadKey();  
 }
    }

