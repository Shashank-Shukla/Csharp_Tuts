using System;
using System.Collections.Generic;
using System.Linq;

public class Circle
{
    public float r;
    public float pi=3.14159F;

  public Circle(float r){
    this.r = r;
  }

  private float getRadius(){
    return r;
  }

  private void setRadius(float r){
    this.r = r;
  }

  private float calcDiameter(){
    return r*2;
  }

  public float calcArea(){
    return pi*r*r;
  }
}

public class Question1{
    public static void Main()
  {
    float r;
    Console.WriteLine("Enter Radius of the circle!!");
    r = int.Parse(Console.ReadLine());
    Circle ob1 = new Circle(r);
    Console.WriteLine($"Area of circle with radius {r} = {ob1.calcArea()}");
  }
}

