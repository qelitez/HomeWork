using System;
using Models;

namespace PracticeWithTypes
{
    public class Program
    {
        public void NewContact(Employee newEmployee)
        {
            newEmployee.Contract = Console.ReadLine();            
        }
    }
}