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
    public class DanhSachStudentAccess:DataAccessDAL
    {
        List<Student> dssv = new List<Student>();

        public List<Student> laytoanbosinhvien()
        {
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM DSSINHVIEN ORDER BY StudentID";
                command.Connection = connect;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
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
                        Student student = new Student
                        {
                            id = StudentID,
                            Name = StudentName,
                            Enroll = Enrollment,
                            Major = Major,
                            Semester = semester,
                            Contact = contact,
                            Email = email,
                            imgPath = imgPath,
                            Role=role
                        };
                        dssv.Add(student);
                    }
                }
            }
            return dssv;
        }


        public void addStudent(Student newStudent)
        {
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                //SET IDENTITY_INSERT DSSINHVIEN ON;
                command.CommandText = " INSERT INTO DSSINHVIEN " +
                    "(StudentID,StudentName, Enrollment, Major, Semester, Contact, Email, imgPath,Role) VALUES " +
                    "(@id,@Name, @Enroll, @Major, @Semester, @Contact, @Email, @ImgPath,@Role)";
                command.Connection = connect;
                command.Parameters.AddWithValue("@id", newStudent.id);
                command.Parameters.AddWithValue("@Name", newStudent.Name);
                command.Parameters.AddWithValue("@Enroll", newStudent.Enroll);
                command.Parameters.AddWithValue("@Major", newStudent.Major);
                command.Parameters.AddWithValue("@Semester", newStudent.Semester);
                command.Parameters.AddWithValue("@Contact", newStudent.Contact);
                command.Parameters.AddWithValue("@Email", newStudent.Email);
                command.Parameters.AddWithValue("@ImgPath", newStudent.imgPath);
                command.Parameters.AddWithValue("@Role", "Stu");
                command.ExecuteNonQuery();
            }
            Dongketnoi();
        }

        public bool DoesStudentExistAdd(string id)
        {
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT COUNT(*) FROM DSSINHVIEN WHERE StudentID = @id";
                command.Connection = connect;

                command.Parameters.AddWithValue("@id", id);
                int count = (int)command.ExecuteScalar();
                Dongketnoi();
                return count > 0;
            }
        }
        public List<Student> searchStudent(string id)
        {
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM DSSINHVIEN WHERE StudentID like @id";
                command.Connection = connect;
                //command.Parameters.AddWithValue("@id", "%" + id + "%");
                command.Parameters.AddWithValue("@id",id + "%");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
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
                        Student student = new Student
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
                        dssv.Add(student);
                    }
                }
            }
            return dssv;
        }
    }
}
