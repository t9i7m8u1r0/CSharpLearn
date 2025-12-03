using System;
using System.IO;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //задание 8.4.3

            Contact contact = new Contact("John Doe", 1234567890, "john.doe@example.com");

            // Сериализация объекта в бинарный файл
            using (FileStream fileStream = new FileStream("contact.bin", FileMode.Create))
            using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
            {
                contact.Serialize(binaryWriter);
            }

            // Десериализация объекта из бинарного файла
            Contact deserializedContact;
            using (FileStream fileStream = new FileStream("contact.bin", FileMode.Open))
            using (BinaryReader binaryReader = new BinaryReader(fileStream))
            {
                deserializedContact = Contact.Deserialize(binaryReader);
            }

            // Вывод десериализованных данных
            Console.WriteLine($"Name: {deserializedContact.Name}, Phone: {deserializedContact.PhoneNumber}, Email: {deserializedContact.Email}");
        }
    }
}