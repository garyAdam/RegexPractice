using System;
using System.IO;
using System.Text;

namespace EncodingConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("../../../../../.gitignore"))
            {
                using(FileStream fs = new FileStream("../../../../../.gitignore_utf7.txt",FileMode.Create, FileAccess.Write))
                {
                    using(StreamWriter sw = new StreamWriter(fs,Encoding.UTF7))
                    {
                        string content = sr.ReadToEnd();
                        sw.Write(content);
                    }
                }
            }
        }
    }
}
