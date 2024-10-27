using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Models.Company
{
    /// <summary>
    /// Описание грейдов (ролей) сотрудников внутри отдела
    /// (например, стажер, джун, мидл, сеньор, тимлид)
    /// </summary>
    /// <param name="name">Название уровня градации</param>
    public class Grade(string name)
    {
        public int Id { get; set; }
        public string Name { get; set; } = name;
    }
}
