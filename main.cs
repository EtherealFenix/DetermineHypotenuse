using System;

class MainClass {
  public static double DetermineHypotenuse(double side1,double side2){
    double Hypotenuse = Math.Sqrt(side1*side1+side2*side2);
    return Hypotenuse;
  }
  public static void Main (string[] args) {
      Console.WriteLine ("Input Side 1 length");
    double side1 = Convert.ToDouble(Console.ReadLine());
  
    Console.WriteLine ("Input Side 2 length");
    double side2 = Convert.ToDouble(Console.ReadLine());
    double Hypotenuse = DetermineHypotenuse(side1, side2);
    Console.WriteLine("Hypotenuse length = "+ Hypotenuse);
  }
  
}