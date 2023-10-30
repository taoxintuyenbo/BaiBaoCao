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
    public class SachByIdAccess : DataAccessDAL
    {
        public Sach GetSachById(int id)
        {
            Sach sach = null;
            Moketnoi();

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM DSSACH WHERE id = @Id";
                command.Connection = connect;
                command.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int bookId = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string author = reader.GetString(2);
                        string publication = reader.GetString(3);
                        DateTime bDate = reader.GetDateTime(4);
                        int price = reader.GetInt32(5);
                        int quantity = reader.GetInt32(6);
                        string imgPath = reader.GetString(7);
             
                        sach = new Sach
                        {
                            id = bookId,
                            Name = name,
                            Author = author,
                            Publication = publication,
                            bDate = bDate,
                            Price = price,
                            Quantity = quantity,
                            imgPath = imgPath
                    
                        };
                    }
                }
            }
            Dongketnoi();
            return sach;
        }

        public void xoasach(int id)
        { 
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM DSSACH WHERE id = @id";
                command.Connection = connect;
                // Add parameter to prevent SQL injection
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            Dongketnoi();
        }

        public void updateBook(int id,Sach sach)
        {
            Moketnoi();
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE DSSACH SET Name = @Name, Author = @Author, Publication = @Publication, bDate = @BDate, Price = @Price, Quantity = @Quantity, imgPath = @ImgPath WHERE id = @Id";
                command.Connection = connect;

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", sach.Name);
                command.Parameters.AddWithValue("@Author", sach.Author);
                command.Parameters.AddWithValue("@Publication", sach.Publication);
                command.Parameters.AddWithValue("@BDate", sach.bDate);
                command.Parameters.AddWithValue("@Price", sach.Price);
                command.Parameters.AddWithValue("@Quantity", sach.Quantity);
                command.Parameters.AddWithValue("@ImgPath", sach.imgPath);

                command.ExecuteNonQuery();
            }
            Dongketnoi();
        }
    }
}
