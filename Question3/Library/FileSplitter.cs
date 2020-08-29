using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3.Library
{
    public class FileSplitter
    {
        public void SplitMainFile(string dirParameter)
        {
            int fileCount = 0;
            StreamWriter writer = null;
            try
            {
                using (StreamReader inputfile = new StreamReader(Path.Combine(dirParameter, "MainFile.txt")))
                {
                    int count = 0;
                    string line;
                    while ((line = inputfile.ReadLine()) != null)
                    {
                        if (writer == null || count >= 99999)
                        {
                            if (writer != null)
                            {
                                writer.Close();
                                writer = null;
                            }
                            string fileName = fileCount.ToString() + "FileSplit.txt";
                            DeleteFile deleteFile = new DeleteFile();
                            deleteFile.Delete(dirParameter, fileName);
                            writer = new System.IO.StreamWriter(dirParameter + fileName, true);
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
