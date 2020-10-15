using System;
using System.Linq;
using System.IO;
/*
 Write a program to count the number of files with similar extension and group them using LINQ. 
 Use lambda expressions to form the query.
 */

namespace Week10Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a List of files with different extensions
            string[] fileList = { "aaa.txt", "bbb.TXT", "xyzabc.pdf", "hello.PDF", "abc.xml", "ccc.txt", "zzz.txt" };

            // Create a Lambda expression for selection of file extension
            var egrp = fileList.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())

                     .GroupBy(x => x, (ext, extCnt) => new

                     {

                         Extension = ext,

                         Count = extCnt.Count()

                     });

            // Count each extension type and display the result. Use foreach
            foreach (var v in egrp)

                Console.WriteLine("{0} File(s) with {1} Extension ", v.Count, v.Extension);

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
