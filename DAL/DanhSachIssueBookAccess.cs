using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DanhSachIssueBookAccess:DataAccessDAL
    {
        
        public bool DoesExceed3Books(string id)
        {
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT COUNT(*) FROM ISSUEBOOK WHERE StudentID = @id";
                command.Connection = connect;

                command.Parameters.AddWithValue("@id", id);
                int count = (int)command.ExecuteScalar();
                Dongketnoi();
                if (count >=3)
                    return false;
                return true;
            }
        }
        public bool BookHaveAlreadyIssued(string id, string name)
        {
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT COUNT(*) FROM ISSUEBOOK WHERE StudentID = @id and BookName=@Name";
                command.Connection = connect;

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@Name", name);
                int count = (int)command.ExecuteScalar();
                Dongketnoi();
                if (count > 0)
                    return false;
                return true;
            }
        }

        public void IssueBook(Issue newIssue)
        {
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO ISSUEBOOK " +
                                      "(StudentID, StudentName, Enrollment, Major, Semestor, Contact, Email, BookName, IssueDate) " +
                                      "VALUES " +
                                      "(@StudentID, @StudentName, @Enrollment, @Major, @Semestor, @Contact, @Email, @BookName, @IssueDate)";
                command.Connection = connect;

                command.Parameters.AddWithValue("@StudentID", newIssue.StudentID);
                command.Parameters.AddWithValue("@StudentName", newIssue.StudentName);
                command.Parameters.AddWithValue("@Enrollment", newIssue.Enrollment);
                command.Parameters.AddWithValue("@Major", newIssue.Major);
                command.Parameters.AddWithValue("@Semestor", newIssue.Semestor);
                command.Parameters.AddWithValue("@Contact", newIssue.Contact);
                command.Parameters.AddWithValue("@Email", newIssue.Email);
                command.Parameters.AddWithValue("@BookName", newIssue.BookName);
                command.Parameters.AddWithValue("@IssueDate", newIssue.IssueDate);

                command.ExecuteNonQuery();
                Dongketnoi();
            }
        }

        public List<Issue> studentIssue(int id)
        {
            List<Issue> dsis = new List<Issue>();
            Issue issue = null;
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM ISSUEBOOK WHERE StudentID = @id and ReturnDate is null";
                command.Connection = connect;
                command.Parameters.AddWithValue("@id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int studentID = reader.GetInt32(0);
                        string studentName = reader.GetString(1);
                        string enrollment = reader.GetString(2);
                        string major = reader.GetString(3);
                        int semester = reader.GetInt32(4);
                        int contact = reader.GetInt32(5);
                        string email = reader.GetString(6);
                        string bookname = reader.GetString(7);
                        DateTime issueDate = reader.GetDateTime(8);
                        //DateTime returnDate = reader.GetDateTime(9);
                        issue = new Issue
                        {
                            StudentID = studentID,
                            StudentName = studentName,
                            Enrollment = enrollment,
                            Major = major,
                            Semestor = semester,
                            Contact = contact,
                            Email = email,
                            BookName=bookname,
                            IssueDate = issueDate,
                            //ReturnDate = returnDate
                        };
                        dsis.Add(issue);
                    }
                }
            }
            return dsis;
        }
        public Issue BookIssueById(int id,string name)
        {
            Issue issue = null;
            Moketnoi();

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM ISSUEBOOK WHERE StudentID = @Id and BookName=@Name";
                command.Connection = connect;
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int studentID = reader.GetInt32(0);
                        string studentName = reader.GetString(1);
                        string enrollment = reader.GetString(2);
                        string major = reader.GetString(3);
                        int semester = reader.GetInt32(4);
                        int contact = reader.GetInt32(5);
                        string email = reader.GetString(6);
                        string bookname = reader.GetString(7);
                        DateTime issueDate = reader.GetDateTime(8);
                        //DateTime returnDate = reader.GetDateTime(9);
                        issue = new Issue
                        {
                            StudentID = studentID,
                            StudentName = studentName,
                            Enrollment = enrollment,
                            Major = major,
                            Semestor = semester,
                            Contact = contact,
                            Email = email,
                            BookName = bookname,
                            IssueDate = issueDate,
                            //ReturnDate = returnDate
                        };
                    }
                }
            }
            Dongketnoi();
            return issue;
        }
        public void ReturnBook(int id, string name, DateTime returnDate)
        {
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "Update ISSUEBOOK set ReturnDate=@returndate WHERE StudentID = @id and BookName=@Name";
                command.Connection = connect;

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@returndate", returnDate);
                command.ExecuteNonQuery();
            }
            Dongketnoi();
        }
    }
}
