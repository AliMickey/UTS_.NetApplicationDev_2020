using System;
using System.Linq;
using System.IO;
/*
 Write a program to count the number of files with similar extension and group them using LINQ. 
 Use lambda expressions to form the query.

Hint:
Trim and  ToLower method can be useful
 */

namespace Week10Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileList = { "aaa.txt", "bbb.TXT", "xyzabc.pdf", "hello.PDF", "abc.xml", "ccc.txt", "zzz.txt" };

            // Create a Lambda expression for selection of file extension
            var egrp = fileList.Select()
             
                     egrp.GroupBy(, (/* Write code here */) => new

                     {

                         Extension = /* Write code here */,

                         Count =/* Write code here */

                     });

            // Count each extension type and display the result. Use foreach
            foreach (/* Write code here */)

                Console.WriteLine(/* Write code here */);

            Console.ReadLine();

        }
    }

}


/*
Test case: Expected output 

4 File(s) with txt Extension
2 File(s) with pdf Extension
1 File(s) with xml Extension

    */
