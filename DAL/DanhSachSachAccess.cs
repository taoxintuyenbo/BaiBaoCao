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
    public class DanhSachSachAccess : DataAccessDAL
    {
        List<Sach> dss = new List<Sach>();
        public List<Sach> laytoanbosach()
        {
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM DSSACH ORDER BY id";
                command.Connection = connect;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string author = reader.GetString(2);
                        string publication = reader.GetString(3);
                        DateTime bDate = reader.GetDateTime(4);
                        int price = reader.GetInt32(5);
                        int quantity = reader.GetInt32(6);
                        string imgPath = reader.GetString(7);
                        Sach sach = new Sach
                        {
                            id = id,
                            Name = name,
                            Author = author,
                            Publication = publication,
                            bDate = bDate,
                            Price = price,
                            Quantity = quantity,
                            imgPath = imgPath
                        };
                        dss.Add(sach);
                    }
                }
            }
            return dss;
        }
        public List<Sach> searchBook(string Name)
        {
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM DSSACH WHERE Name like @Name";
                command.Connection = connect;
                command.Parameters.AddWithValue("@Name", "%" + Name + "%");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string author = reader.GetString(2);
                        string publication = reader.GetString(3);
                        DateTime bDate = reader.GetDateTime(4);
                        int price = reader.GetInt32(5);
                        int quantity = reader.GetInt32(6);
                        string imgPath = reader.GetString(7);
                        Sach sach = new Sach
                        {
                            id = id,
                            Name = name,
                            Author = author,
                            Publication = publication,
                            bDate = bDate,
                            Price = price,
                            Quantity = quantity,
                            imgPath = imgPath
                        };
                        dss.Add(sach);
                    }
                }
            }
            return dss;
        }
        public void addBook(Sach newSach)
        {
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SET IDENTITY_INSERT DSSACH ON; INSERT INTO DSSACH (id,Name, Author, Publication, bDate, Price, Quantity, imgPath) VALUES (@id,@Name, @Author, @Publication, @BDate, @Price, @Quantity, @ImgPath)";
                command.Connection = connect;
                command.Parameters.AddWithValue("@id", newSach.id);
                command.Parameters.AddWithValue("@Name", newSach.Name);
                command.Parameters.AddWithValue("@Author", newSach.Author);
                command.Parameters.AddWithValue("@Publication", newSach.Publication);
                command.Parameters.AddWithValue("@BDate", newSach.bDate);
                command.Parameters.AddWithValue("@Price", newSach.Price);
                command.Parameters.AddWithValue("@Quantity", newSach.Quantity);
                command.Parameters.AddWithValue("@ImgPath", newSach.imgPath);

                command.ExecuteNonQuery();
            }
            Dongketnoi();
        }
        public bool DoesBookExistAdd(string id, string Name, string Author)
        {
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT COUNT(*) FROM DSSACH WHERE id = @id";
                command.Connection = connect;

                command.Parameters.AddWithValue("@id", id);
                int count1 = (int)command.ExecuteScalar();

                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT COUNT(*) FROM DSSACH WHERE Name COLLATE SQL_Latin1_General_CP1_CS_AS = @Name AND Author COLLATE SQL_Latin1_General_CP1_CS_AS = @Author";
                command.Connection = connect;

                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Author", Author);
                int count2 = (int)command.ExecuteScalar();

                int count = count1 > count2 ? count1 : count2;

                return count > 0;
            }
        }

        public bool DoesBookExistUpdate(string name, string author)
        {
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT COUNT(*) FROM DSSACH WHERE Name COLLATE SQL_Latin1_General_CP1_CS_AS = @Name ";
                command.Connection = connect;

                command.Parameters.AddWithValue("@Name", name);
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public List<string> GetBookNames()
        {
            Moketnoi();
            List<string> bookNames = new List<string>();

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Name FROM DSSACH"; 
                command.Connection = connect;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string bookName = reader.GetString(0);
                        bookNames.Add(bookName);
                    }
                }
            }
            Dongketnoi();
            return bookNames;
        }
    }
}
