using System;
class MainClass
{
    public static void Main(string[] args)
    {
        var department = GetCurrentDepartment();
    }

    static Department GetCurrentDepartment()
    {
        Company company = new Company();
        Department department = new Department();

        if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
        {
            Console.WriteLine($"У банка {department?.Company?.Name ?? "Неизвестная компания"} есть отделение в Санкт-Петербурге");
        }
        
        return department;
    }
}

class Company
{
    public string Type;
    public string Name;
}

class Department
{
    public Company Company;
    public City City;
}

class City
{
    public string Name;
}