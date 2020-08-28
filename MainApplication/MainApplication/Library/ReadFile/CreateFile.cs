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
        public string CreateFiles(string targetPath)
        {
            string result;
            try
            {           
               CreateNewFile(targetPath);
               saveFiles(targetPath);
                result = "success";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        private static string CreateNewFile(string docPath)
        {
            string text = "";
            string TempTest = "";
            for (int i = 0; i < 10001; i++)
                text += "Line" + i + Environment.NewLine;

            for (int i = 0; i < 101; i++)
                TempTest += text + Environment.NewLine;

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
            {
                    outputFile.Write(TempTest);
            }
            return TempTest;
        }

        public void saveFiles(string dirParameter)
        {
            int fileCount = 0;
            StreamWriter writer = null;
            try
            {
                    using (StreamReader inputfile = new StreamReader(Path.Combine(dirParameter, "WriteLines.txt")))
                {
                    int count = 0;
                    string line;
                    while ((line = inputfile.ReadLine()) != null)
                    {
                        if (writer == null || count > 100000)
                        {
                            if (writer != null)
                            {
                                writer.Close();
                                writer = null;
                            }
                            writer = new System.IO.StreamWriter(dirParameter + fileCount.ToString() + ".txt", true);
                            fileCount += 1;
                            count = 0;
                        }
                        writer.WriteLine(line);
                        ++count;
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}
