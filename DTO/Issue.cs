using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Issue
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string Enrollment { get; set; }
        public string Major { get; set; }
        public int Semestor { get; set; }
        public int Contact { get; set; }
        public string Email { get; set; }
        public string BookName { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
