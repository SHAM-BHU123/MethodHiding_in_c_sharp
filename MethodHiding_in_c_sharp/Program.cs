using System;
/*
1)Method Hiding can be achieve using "new keyword".
2)When the method is been declared with the "new" keyword then it will  automatically hide the 
    existing method of a parent class(base class)
*/
namespace MethodHiding_in_c_sharp
{


  class Class1{
    public void display()
    {
        Console.WriteLine("Super class display method");
        }
    }

    class Class2 : Class1 {
        public new void display()
        {
            Console.WriteLine("sub class display method");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class2 two = new Class2();
            two.display();
            Console.ReadKey();
        }
        /*Conclusion sub class method hide the method of base class method */
    }
}
