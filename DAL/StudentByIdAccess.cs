using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class StudentByIdAccess:DataAccessDAL
    {
        public Student GetStudentById(int id)
        {
            Student student = null;
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM DSSINHVIEN WHERE StudentID = @Id";
                command.Connection = connect;
                command.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int StudentID = reader.GetInt32(0);
                        string StudentName = reader.GetString(1);
                        string Enrollment = reader.GetString(2);
                        string Major = reader.GetString(3);
                        int semester = reader.GetInt32(4);
                        int contact = reader.GetInt32(5);
                        string email = reader.GetString(6);
                        string imgPath = reader.GetString(7);
                        string role = reader.GetString(8);

                        student = new Student
                        {
                            id = StudentID,
                            Name = StudentName,
                            Enroll = Enrollment,
                            Major = Major,
                            Semester = semester,
                            Contact = contact,
                            Email = email,
                            imgPath = imgPath,
                            Role = role
                        };
                    }
                }
            }
            Dongketnoi();
            return student;
        }


        public void updateStudent(int id, Student student)
        {
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE DSSINHVIEN SET StudentName = @Name, Enrollment = @Enroll, Major = @Major, Semester = @Semester, Contact = @Contact, Email = @Email, imgPath = @ImgPath WHERE StudentID = @Id";
                command.Connection = connect;

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Enroll", student.Enroll);
                command.Parameters.AddWithValue("@Major", student.Major);
                command.Parameters.AddWithValue("@Semester", student.Semester);
                command.Parameters.AddWithValue("@Contact", student.Contact);
                command.Parameters.AddWithValue("@Email", student.Email);
                command.Parameters.AddWithValue("@ImgPath", student.imgPath);

                command.ExecuteNonQuery();
            }

            Dongketnoi();
        }
        public void deleteStudent(int id)
        {
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM DSSINHVIEN WHERE StudentID = @id";
                command.Connection = connect;
                // Add parameter to prevent SQL injection
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            Dongketnoi();
        }
    }
}
