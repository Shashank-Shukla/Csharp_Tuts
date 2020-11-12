/*
Write a program that allows you to create an integer array of 
18 elements with the following values: 
int A[]={3,2,4,5,6,4,5,7,3,2,3,4,7,1,2,0,0,0}. 
The program computes the sum of element 0 to 14 and stores it at 
element 15, computes the average and stores it at element 16 and 
identifies the smallest value from the array and stores it at element 17.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfArray{
   public static void main(){
      int []A = {3,2,4,5,6,4,5,7,3,2,3,4,7,1,2,0,0,0};
      int sum = 0, i, min = A[0];
      for(i=0; i<15; i++){
          sum += i;
          if(A[i]<=min)
            min=A[i];
      }
      A[15] = sum;
      A[16] = sum/15;
      A[17] = min;
      Console.WriteLine("The array is:");
      for(i=0; i<A.Length;i++)
        Console.Write(A[i] + ", ");
   }
}

