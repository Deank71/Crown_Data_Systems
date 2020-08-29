using Question3.Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CDS.MainApplication.Library.ReadFile
{
    public class CreateFile
    {
        //Question 3
        public string GenerateMainDocument(string targetPath)
        {
            string result;
            try
            {
                CreateDirectory(targetPath);
                CreateNewFile(targetPath);
                //   saveFiles(targetPath);
                result = "success";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        private static void CreateDirectory(string targetPath)
        {
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }
        }

        private static string CreateNewFile(string docPath)
        {
            string text = "Line1";
            string TempTest = "";
            for (int i = 1; i < 10001; i++)
                text += Environment.NewLine + "Line" + (i+1) ;

            for (int i = 0; i < 100; i++)
                TempTest += i + text + Environment.NewLine;
            DeleteFile deleteFile = new DeleteFile();
            deleteFile.Delete(docPath, "MainFile.txt");
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "MainFile.txt")))
            {
                    outputFile.Write(TempTest);
            }
            return TempTest;
        }
    }
}
