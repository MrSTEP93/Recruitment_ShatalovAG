using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Models.People
{
    /// <summary>
    /// Абстрактный класс с описанием общих полей для каждого человека
    ///     
    /// Основной конструктор использовать здесь не стал, потому что лично мне проще 
    /// воспринимать перегруженные конструкторы, описанные в одном стиле.
    /// </summary>
    public abstract class AbstractPerson
    {
        protected AbstractPerson(string name, string email) : this(name, string.Empty, email, string.Empty) { }

        protected AbstractPerson(string name, string lastName, string email, string phoneNumber)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
