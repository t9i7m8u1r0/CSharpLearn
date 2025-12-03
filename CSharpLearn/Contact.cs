using System;
using System.IO;

namespace CSharpLearn
{
    [Serializable]
    public class Contact
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        // Метод для сериализации объекта в бинарный формат
        public void Serialize(BinaryWriter writer)
        {
            writer.Write(Name);
            writer.Write(PhoneNumber);
            writer.Write(Email);
        }

        // Метод для десериализации объекта из бинарного формата
        public static Contact Deserialize(BinaryReader reader)
        {
            string name = reader.ReadString();
            long phoneNumber = reader.ReadInt64();
            string email = reader.ReadString();

            return new Contact(name, phoneNumber, email);
        }
    }
}