﻿/**
    Write a program that tells wheter a number is prime
    or not.

    A prime number is a positive integer that has exactly
    two positive integer factors, 1 and itself. 

    Another way of saying this is that a prime number is a
    positive integer that is not the product of two smaller positive integers.

    For example:
    Given: number = 2
    Returns: true

    Given: number = 15
    Returns: false

    Given: number = -1 (or any negative)
    Returns: false

    Method signature:     isPrime(int number)
    Return value:         bool
    Access modifier:      public static
 */

using System;

namespace Ex9
{
    public class Program
    {
        public static bool ENABLED = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

        public static bool isPrime(int number) {
         bool answ = false;
         int divisores=0;
            if (number<=0)
            {
                answ=false;
            }

            else
              {
                 for(int i=1; i<=number;i++)
                 {
                    if (number%i==0)
                    {
                        divisores++;
                    }
                 }
                 if(divisores==2)
                 {
                     answ=true;
                 }
              }

            return answ;
        }
    }
}
