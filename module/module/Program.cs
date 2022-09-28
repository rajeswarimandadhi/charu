using System;

namespace module
{
    // C# program to demonstrate the 
    // String.Substring Method (startIndex)
    using System;
    class Geeks
    {
        
            
        // Main Method
        public static void Main6()
        {

            // define string stringOne
            String str  = "novelvistavitsa" ; 
             
            Console.WriteLine("String    : " + str);

            // retrieve the substring from index 5
            Console.WriteLine("Sub String1: " + str.Substring(5));

         

            // define string stringTwo
            String stringname = "capgeminicap";

            Console.WriteLine("String    : " +stringname);

            // retrieve the substring from index 0-3
            Console.WriteLine("Sub String2: " +stringname.Substring(9));

         
         
        }
    }
}



