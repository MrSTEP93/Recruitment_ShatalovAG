using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Models.Company
{
    /// <summary>
    /// Должность внутри отдела
    /// </summary>
    /// <param name="name">Название должности</param>
    public class Position(string name)
    {
        public int Id { get; set; }
        public string Name { get; set; } = name;
    }
}
