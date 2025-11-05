using System;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //задание 8.1.4
        }
    }

    class Disk
    {
        public Disk(string diskName, double diskCapacity, double diskFreeSpace)
        {
            DiskName = diskName;
            DiskCapacity = diskCapacity;
            DiskFreeSpace = diskFreeSpace;
        }

        public string DiskName { get; set; }
        public double DiskCapacity { get; set; }
        public double DiskFreeSpace { get; set; }
    }
}