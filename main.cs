using System;

class MainClass {
  public static void Main (string[] args) {
    
 Console.WriteLine("Lab2b");
    
    int firstnum;
    int secondnum;
    int sum;
    int product;
    int difference;
    int quotient; 
    int remainder;

        Console.Write("Enter number : ");
        firstnum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number : ");
        secondnum = Convert.ToInt32(Console.ReadLine());

        sum = firstnum + secondnum;
        product = firstnum * secondnum;
        difference = firstnum - secondnum;
        quotient = firstnum / secondnum;
        remainder = firstnum % secondnum;

        Console.Write(" Sum = " + sum);
        
        Console.Write(" Product = " + product);
       
        Console.Write(" Difference = " + difference);
        
        Console.Write(" Quotient = " + quotient);
       
        Console.Write(" Remainder = " + remainder);

  }
}