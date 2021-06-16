using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_Aplikacija.Models
{
    public class Posjecenost : IComparable<Posjecenost>
    {
        public String Venue { get; set; }
        public long Attendance { get; set; }
        public String Home_team_country { get; set; }
        public String Away_team_country { get; set; }
        public int CompareTo(Posjecenost obj)
        {
            return -this.Attendance.CompareTo(obj.Attendance);
        }
        public override string ToString()
        {
            return $"{Home_team_country} vs {Away_team_country}";
        }
    }
}
