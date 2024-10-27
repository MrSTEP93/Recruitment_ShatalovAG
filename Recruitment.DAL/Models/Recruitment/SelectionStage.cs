using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Models.Recruitment
{
    /// <summary>
    /// Справочник стадий отбора каждого кандидата 
    /// (например, скрининг, интервью, техническое задание, оффер)
    /// </summary>
    /// <param name="name"></param>
    public class SelectionStage(string name)
    {
        public int Id { get; set; }
        public string Name { get; set; } = name;
        public string Description { get; set; } = string.Empty;

    }
}
