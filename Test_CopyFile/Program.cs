using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string OriginalFile = "C:/Project/Test_CopyFile/Test_CopyFile/Test_res/source/3.txt";
                string FileToReplace = "C:/Project/Test_CopyFile/Test_CopyFile/Test_res/archive/3.txt";
                //string BackUpOfFileToReplace = "test2.xml.bac";

                Console.WriteLine("Move the contents of " + OriginalFile + " into " + FileToReplace + ", delete " + OriginalFile +
                                   ", and create a backup of " + FileToReplace + ".");

                // Replace the file.
                ReplaceFile(OriginalFile, FileToReplace);

                Console.WriteLine("Done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();

        }

        // Move a file into another file, delete the original, and create a backup of the replaced file.
        public static void ReplaceFile(string FileToMoveAndDelete, string FileToReplace)
        {
            ///File.Replace(FileToMoveAndDelete, FileToReplace, null);
            File.Copy(FileToMoveAndDelete, FileToReplace, true);
            File.Delete(FileToMoveAndDelete);

        }
    }
}
