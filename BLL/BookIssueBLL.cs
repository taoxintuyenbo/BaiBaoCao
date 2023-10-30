using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BookIssueBLL
    {
        DanhSachIssueBookAccess bookIssue = new DanhSachIssueBookAccess();
        public bool DoesExceed3Books(string id )
        {
            return bookIssue.DoesExceed3Books(id);
        }
        public bool DoesExceed3Books(string id, string bookName)
        {
            return bookIssue.BookHaveAlreadyIssued(id, bookName);
        }
        public int validationBookIssue(string id, string bookName)
        {
            if (!bookIssue.DoesExceed3Books(id))
                return 1;
            if (bookName == null || bookName == "")
                return 2;
            if (!bookIssue.BookHaveAlreadyIssued(id,bookName))
                return 3;
            return 0;
        }
        public void issueBook(Issue newIssue)
        {
            bookIssue.IssueBook(newIssue);
        }

        public List<Issue> studentIssue(int id)
        {
            return bookIssue.studentIssue(id);
        }
        public Issue BookIssueById(int id, string name)
        {
            return bookIssue.BookIssueById(id, name);
        }

        public void ReturnBook(int id, string name,DateTime returnDate)
        {
            bookIssue.ReturnBook(id, name, returnDate);
        }
    }
}
