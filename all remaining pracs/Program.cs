// Employee pre defined
using System;

class Employee
{
    public string name;
    public int age;
    public int salary;
}

class Program
{
    static void Main()
    {
        Employee e1 = new Employee();
        e1.name = "A";
        e1.age = 55;
        e1.salary = 70000;

        Employee e2 = new Employee();
        e2.name = "B";
        e2.age = 30;
        e2.salary = 50000;

        if (e1.salary > 60000)
            Console.WriteLine(e1.name);

        if (e1.age > 50)
            Console.WriteLine(e1.name);

        int max = e1.salary;

        if (e2.salary > max)
            max = e2.salary;

        Console.WriteLine("Maximum = " + max);
    }
}

// employee user defined
/* using System.ComponentModel.DataAnnotations;
 * using System.Globalization;  
 * namespace DataStructure {     
 * class emp     {         
 * public int eno;         
 * public string name;         
 * public int age;         
 * public int salary;          
 * public emp(int eno, string name, int age, int salary)         {            
 * this.eno = eno;            
 * this.name = name;            
 * this.age = age;             
 * this.salary = salary;         }     }     
 * internal class Program     {         
 * static void Main(string[] args)         {             
 * emp[] s = new emp[5];             
 * int eno;             
 * string name;             
 * int age;             
 * int salary;              
 * for (int i = 0; i < s.Length; i++)             {                   
 * Console.WriteLine("Enter Record of Employee :" + (i + 1));                 
 * Console.WriteLine("Enter Employee Id  : ");                
 * eno = Convert.ToInt32(Console.ReadLine());                  
 * Console.WriteLine("Enter Name : ");                 
 * name = Console.ReadLine();                  
 * Console.WriteLine("Enter Age : ");                 
 * age = Convert.ToInt32(Console.ReadLine());                 
 * Console.WriteLine("Enter Salary : ");                 
 * salary = Convert.ToInt32(Console.ReadLine());                  
 * s[i] = new emp(eno, name, age, salary); 
 *             }          
 *             //Display name and age of employee whose salary > 60000             
 *             for (int i = 0; i < s.Length; i++)             {                 
 *             if (s[i].salary > 60000)                 {                     
 *             Console.WriteLine("Name : " + s[i].name);                     
 *             Console.WriteLine("Age : " + s[i].age);                 }              }              
 *             //Display the age of emp who all are > 50             
 *             for (int i = 0; i < s.Length; i++)             {                 
 *             if (s[i].age > 50)                 {                    
 *             Console.WriteLine("Name : " + s[i].name);                     
 *             Console.WriteLine("Age : " + s[i].age);                 }             }              
 *             //Display the age of emp who has max salary             
 *             int max = 0;            
 *             string max_namo = null;             
 *             for (int i = 0; i < s.Length; i++)             {                 
 *             if (s[i].salary > max)                 {                    
 *             max = s[i].salary;                   
 *             
 *             max_namo = s[i].name;                 }             }            
 *             Console.WriteLine("MAX SALARY BY : " + max_namo + " " + max);            }     } } 