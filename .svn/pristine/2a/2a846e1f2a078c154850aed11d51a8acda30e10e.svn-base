using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NagarroSoftware.DotNet.Training.Week1Assignment2Question1
{
    class Program
    {       
        /// <summary>
        /// Shows whether file is present or not in the specified folder or its subdirectories
        /// </summary>
        /// <param name="args">default command line arguements</param>
        public static void Main(string[] args)
        {
            bool fileExist = false ;
            string fileName;
            string folderPath;
            List<string> fileNames;

            InputFileInfo(out fileName,out folderPath);

            fileExist = IsFileExist(fileName,folderPath,out fileNames);
        
            if (fileExist)
            {
                Console.WriteLine("File is present");
            }
            
            else
            {
                Console.WriteLine("File is not present");
            }
            
            Console.ReadLine();
        }

        /// <summary>
        /// This method takes the file name and folder path as input from the user through console.
        /// </summary>
        /// <param name="fileName">This is the name of the file which is to be searched for existence.</param>
        /// <param name="folderPath">This is the base folder in which the file has to be searched.</param>
        private static void InputFileInfo(out string fileName, out string folderPath)
        {
            Console.WriteLine("Enter file name to be checked:-");
            fileName = Console.ReadLine();

            Console.WriteLine("Enter folder path where file have to be checked:-");
            folderPath = Console.ReadLine();
        }

        /// <summary>
        /// This method returns true if the file is present in the given folder or its subdirectories.
        /// </summary>
        /// <param name="fileName">This is the name of the file which is to be searched for existence.</param>
        /// <param name="folderPath">This is the base folder in which the file has to be searched.</param>
        /// <returns>Returns true if file is present, false otherwise</returns>
        public static bool IsFileExist(string fileName, string folderPath, out List<string> fileNames)
        {
            bool result = false;
            DirectoryInfo directory = new DirectoryInfo(@folderPath);
            string fileExtension = Path.GetExtension(fileName);
            string fileNameWithoutExtension = Path.GetFileName(fileName);
            string searchPattern = "*" + fileExtension;
            List<string> alternateFileNames = new List<string>();
            fileNames = null;
            try
            {
                FileInfo[] files = directory.GetFiles(searchPattern, SearchOption.AllDirectories);
                foreach (FileInfo file in files)
                {
                    if (file.Name.CompareTo(fileName) == 0)
                    {
                        result = true;
                    }
                }
                if(!result)
                {
                    FileInfo[] alternateFiles = directory.GetFiles(fileNameWithoutExtension, SearchOption.AllDirectories);
                    foreach (FileInfo file in files)
                    {
                        alternateFileNames.Add(file.Name);
                    }
                    fileNames = alternateFileNames;

                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("!! Invalid Directory address has been entered !!");         
                
            }
            catch (Exception)
            {
                Console.WriteLine("!! Invalid Directory address or File Name has been entered !!");
            }

            return result;

        }
    }
}
