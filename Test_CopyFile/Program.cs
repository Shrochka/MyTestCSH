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
              //  string fullPath;
                string OriginalFile = Path.GetFullPath(@"..\..\..\Test_res\source\99.txt");
                string FileToReplace = Path.GetFullPath(@"..\..\..\Test_res\archive\99.txt");


              //  fullPath = Path.GetFullPath(OriginalFile);

               // Console.WriteLine("GetFullPath('{0}') returns '{1}'",  path1, fullPath);

                Console.WriteLine("Copy file " + OriginalFile + " into " + FileToReplace + ", delete " + OriginalFile + ".");

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
