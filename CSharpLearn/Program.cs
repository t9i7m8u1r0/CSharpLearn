using System;
using System.IO;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //задание 8.4.1

            const string filePath = @"C:\Users\t9i7m\Downloads\BinaryFile.bin";

            if (File.Exists(filePath))
            {
                FileStream fileStream = File.OpenRead(filePath);

                BinaryReader binaryReader = new BinaryReader(fileStream);

                string strValue = binaryReader.ReadString();

                Console.WriteLine(strValue);

                binaryReader.Close();
                fileStream.Close();
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}