using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Расписание_занятий
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; } // Например: ИВТ-31
        public int CourseNumber { get; set; }
        public string FacultyName { get; set; }
    }
}
