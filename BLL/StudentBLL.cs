using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class StudentBLL
    {
        DanhSachStudentAccess dssa = new DanhSachStudentAccess();
        StudentByIdAccess stdById = new StudentByIdAccess();
        public List<Student> laytoanbosinhvien()
        {
            return dssa.laytoanbosinhvien();
        }
        public void addStudent(Student newStudent)
        {
            dssa.addStudent(newStudent);
        }
        public int isValidStudentAdd(string id, string Name, string Enroll,string Semestor, string Major, string Contact, string Email, string imgPath)
        {
            if ((id.Length!=10)||!int.TryParse(id.ToString(), out int Id) || Id <= 0)
            {
                return 1;
            }
            if (string.IsNullOrEmpty(Name))
            {
                return 2; // Invalid Name
            }
            if (Name.Any(char.IsDigit))
            {
                return 8;
            }
           
            if (string.IsNullOrWhiteSpace(Enroll))
            {
                return 3; // Invalid Enrollment
            }
            
            if (string.IsNullOrWhiteSpace(Major))
            {
                return 4; // Invalid Major
            }
            if (string.IsNullOrWhiteSpace(Semestor))
            {
                return 12; // Invalid Enrollment
            }

            if (Major.Any(char.IsDigit))
            {
                return 9;
            }
            if ((Contact.Length > 11)||(!int.TryParse(Contact.ToString(), out int contact)) || (contact <= 0))
            {
                return 5;
            }
            
            if (string.IsNullOrWhiteSpace(Email))
            {
                return 6; 
            }
            if (!Email.Contains("@"))
                return 11;
            if (string.IsNullOrEmpty(imgPath))
            {
                return 7; 
            }
            return 0; 
        }

        public int isValidStudentUpdate( string Name, string Enroll, string Semestor, string Major, string Contact, string Email, string imgPath)
        {
            if (string.IsNullOrEmpty(Name))
            {
                return 2; // Invalid Name
            }
            if (Name.Any(char.IsDigit))
            {
                return 8;
            }

            if (string.IsNullOrWhiteSpace(Enroll))
            {
                return 3; // Invalid Enrollment
            }

            if (string.IsNullOrWhiteSpace(Major))
            {
                return 4; // Invalid Major
            }
            if (string.IsNullOrWhiteSpace(Semestor))
            {
                return 12; // Invalid Enrollment
            }

            if (Major.Any(char.IsDigit))
            {
                return 9;
            }
            if ((Contact.Length > 11) || (!int.TryParse(Contact.ToString(), out int contact)) || (contact <= 0))
            {
                return 5;
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                return 6;
            }
            if (!Email.Contains("@"))
                return 11;
            if (string.IsNullOrEmpty(imgPath))
            {
                return 7;
            }
            return 0;
        }
        
        public int validationStudentID(string id)
        {
            if(!int.TryParse(id.ToString(), out int Id) || Id <= 0)
            {
                return 1;
            }
            //if (id.Length != 10 )
            //{
            //    return 2;
            //}
            return 0;
        }
        public bool DoesStudentExistAdd(string id)
        {
            return dssa.DoesStudentExistAdd(id);
        }
        public Student GetStudentById(int id)
        {
            return stdById.GetStudentById(id);
        }
        public bool AreEqual(Student student1, Student student2)
        {
            return student1.Name == student2.Name &&
                   student1.Enroll == student2.Enroll &&
                   student1.Major == student2.Major &&
                   student1.Semester == student2.Semester &&
                   student1.Contact == student2.Contact &&
                   student1.Email == student2.Email &&
                   student1.imgPath == student2.imgPath;
        }

        public void updateStudent(int id,Student newStudent)
        {
            stdById.updateStudent(id, newStudent);
        }

        public void deleteStudent(int id)
        {
            stdById.deleteStudent(id);
        }
        public List<Student> searchStudent(string id)
        {
            return dssa.searchStudent(id);
        }

    
    }
}
