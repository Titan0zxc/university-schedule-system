using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Расписание_занятий
{
    public class ScheduleEntry
    {
        public int ScheduleId { get; set; }
        public int SubjectId { get; set; }
        public int LessonTypeId { get; set; }
        public int TeacherId { get; set; }
        public int AuditoriumId { get; set; }
        public int GroupId { get; set; }

        public string DayOfWeek { get; set; }
        public int PairNumber { get; set; } // Номер пары
        public bool Numerator { get; set; } // Числитель = true, знаменатель = false
        public bool IsHalfGroup { get; set; }
    }
}
