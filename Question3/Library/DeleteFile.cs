using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3.Library
{
    class DeleteFile
    {
        public void Delete(string rootFolder, string fileName)
        {
            try
            {
                // Check if file exists with its full path    
                if (File.Exists(Path.Combine(rootFolder, fileName)))
                {
                    // If file found, delete it    
                    File.Delete(Path.Combine(rootFolder, fileName));
                    Console.WriteLine("File deleted.");
                }
                else Console.WriteLine("File not found");
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }
        }
    }
}
