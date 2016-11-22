using System;

    class StringsAndObjects
{ 
        static void Main()
        {
    string firstString = "Hello";
    string secondString = "World";
    object concatenation = firstString + " " + secondString;
    string objectvariable = (string)concatenation;
    Console.WriteLine(objectvariable);
        }
    }
