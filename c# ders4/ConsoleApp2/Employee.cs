using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        private string BankCode { get; set; }

        public string GetFullName()
        {
            return $"{Name} {SurName}";
        }

        private void BankCartOperation(int bankNumber)
        {
            Console.WriteLine($"Payment successfully to {bankNumber}...");
        }
    }
}
