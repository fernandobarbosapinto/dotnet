using System;
using System.IO;

namespace CourseExampleFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\Temp\file1.txt";
            string targetPath = @"c:\Temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
