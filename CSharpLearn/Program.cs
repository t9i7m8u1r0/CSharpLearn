using System;
using System.IO;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //задание 8.4.2

            const string filePath = @"C:\Users\t9i7m\Downloads\BinaryFile.bin";

            if (File.Exists(filePath))
            {
                FileStream fileStreamWrite = File.OpenWrite(filePath);
                BinaryWriter binaryWriter = new BinaryWriter(fileStreamWrite);

                binaryWriter.Write("Файл изменен 28.11 на Windows 11");

                fileStreamWrite.Close();
                binaryWriter.Close();

                FileStream fileStreamRead = File.OpenRead(filePath);
                BinaryReader binaryReader = new BinaryReader(fileStreamRead);

                string strValue = binaryReader.ReadString();
                Console.WriteLine(strValue);

                fileStreamRead.Close();
                binaryReader.Close();
            }

            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}