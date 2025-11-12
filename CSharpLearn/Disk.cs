using System;

namespace CSharpLearn
{
    internal class Disk
    {
        public string DiskName { get; set; }
        public double DiskCapacity { get; set; }
        public double DiskFreeSpace { get; set; }

        public Disk(string diskName, double diskCapacity, double diskFreeSpace)
        {
            DiskName = diskName;
            DiskCapacity = diskCapacity;
            DiskFreeSpace = diskFreeSpace;
        }

        Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

        public void CreateFolder(string name)
        {
            Folders.Add(name, new Folder());
        }
    }
}