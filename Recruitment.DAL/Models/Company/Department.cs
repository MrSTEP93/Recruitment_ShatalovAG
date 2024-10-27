using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Models.Company
{
    /// <summary>
    /// Отделы внутри компании
    /// </summary>
    /// <param name="name">Название отдела</param>
    public class Department(string name)
    {
        public int Id { get; set; }
        public string Name { get; set; } = name;
    }
}
