using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recruitment.DAL.Models.Company;

namespace Recruitment.DAL.Models.People
{
    /// <summary>
    /// Класс с описанием полей, специфичнных для действующего сотрудника фирмы.
    /// 
    /// Основной конструктор использовать здесь не стал, потому что лично мне проще 
    /// воспринимать перегруженные конструкторы, описанные в одном стиле.
    /// </summary>
    public class Employee : AbstractPerson
    {
        public Employee(string name, string email) : this(name, string.Empty, email, string.Empty) { }

        public Employee(string name, string lastName, string email, string phone) : base(name, lastName, email, phone)
        {
        }

        public Department? Department { get; set; }
        public Position? Position { get; set; }
        public Grade? Grade { get; set; }
    }
}
