﻿class MainClass
{
    public static void Main(string[] args)
    {
        
    }
}

class Employee
{
    public string Name;
    public int Age;
    public int Salary;
}

class ProjectManager : Employee
{
    public string ProjectName;
}

class Developer : Employee
{
    public string ProgrammingLanguage;
}