﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using Microsoft.SqlServer.Server;
using Microsoft.Win32;


namespace datatypes
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // create a method  called  JoinStrings which takes in two strings then output the result to the console and
            //return a string of these stings joined with a space  between them make sure it is public
            // call JoinStrings with your first and last name

            var firstName = "Matthew";
            var lastNane = "Docherty";
            var fullName = JoinStrings(firstName, lastNane);

            // create a method  called  Arthimetic which takes in two  numbers and returns a result  of a  mathematical
            //function which is also sent a a single character the result sould be  printed  to the console
            // call  arithmetic with an example of each type of calculation

            //Create a method called WriteStringArray which writes the contents of an array to the colsole.
            // call WriteStringArray with an array containign 3 strings



        }
        public static int Arithmetic(int num1, int num2, char oper)
        {
            int myNum = 0;
            if (oper == "+")
            {
                return num1 + num2;
            }
            else if (oper == "-")
            {
                return num1 - num2;
            }
            else if (oper == "/")
            {
                return num1 / num2;
            }
            else if (oper == "*")
            {
               return (num1 * num2);
            }
                Console.WriteLine(myNum);
            return myNum;
        }
















        public static string JoinStrings(string firstNane, string lastNane)
        {
           var myString = firstNane +" "+ lastNane;
            Console.WriteLine(myString);
            return myString;
        }
    }
}

