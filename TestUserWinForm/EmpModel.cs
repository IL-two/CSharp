using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUserWinForm
{
    public class EmpModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastNmae { get; set; }
        public string Patronymic { get; set; }
        public decimal Salary { get; set; }

        public EmpModel()
        {
            Id = -1;
            Name = "";
            LastNmae = "";
            Patronymic = "";
            Salary = 0.0M;
        }
        public EmpModel (int id ,string name, string lastName, string patronymic, decimal salary)
        {
            Id = id;
            Name = name;
            LastNmae = lastName;
            Patronymic = patronymic;
            Salary = salary;
        }

        public override string ToString()
        {
            return Name + "\n" +
                LastNmae + "\n" +
                Patronymic + "\n" +
                Salary;
        }
    }
}
