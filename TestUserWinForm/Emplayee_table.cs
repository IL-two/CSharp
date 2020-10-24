using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace TestUserWinForm
{
    [Table(Name = "Emplayee_table")]
    class Emplayee_table
    {
        [Column(Name = "Emp_id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Emp_lastName")]
        public string LastName { get; set; }

        [Column(Name = "Emp_firstName")]
        public string FirstName { get; set; }

        [Column(Name = "Emp_ptronymic")]
        public string Ptronymic { get; set; }

        [Column(Name = "Emp_salary")]
        public decimal Salary { get; set; }

    }
}
