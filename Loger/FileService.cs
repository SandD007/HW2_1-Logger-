using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class FileService
    {
        public void SaveFile(string[] message)
        {
            this.CreateFolder();
            int count = new Random().Next(1, 100);
            string[] fileInfo = Directory.GetFiles("Log");
            int countFile = fileInfo.Length;
            string fileName = "log" + count + ".txt";
            FileInfo[] fileInFolder = new FileInfo[countFile];

            if (countFile >= 3)
            {
                for (int i = 0; i < fileInfo.Length; i++)
                {
                    fileInFolder[i] = new FileInfo(fileInfo[i]);
                }

                var deletetFile = fileInFolder.MinBy(x => x.CreationTime);
                File.Delete(deletetFile.FullName);
            }

            File.WriteAllText("Log/" + fileName, string.Join(Environment.NewLine, message));
        }

        private void CreateFolder()
        {
            string directoryName = "Log";

            if (Directory.Exists(directoryName))
            {
                Directory.Delete(directoryName, true);
                Directory.CreateDirectory(directoryName);
            }
            else
            {
                Directory.CreateDirectory(directoryName);
            }
        }
    }
}
