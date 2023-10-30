using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using DTO;
using DAL;

namespace BLL
{
    public class SachBLL
    {
        DanhSachSachAccess sac = new DanhSachSachAccess();
        SachByIdAccess sachById = new SachByIdAccess();
        public List<Sach> laytoanbosach()
        {
            return sac.laytoanbosach();
        }

        public Sach LaySachTheoId(int id)
        {
            return sachById.GetSachById(id);
        }

        public void xoasach(int id)
        {
            sachById.xoasach(id);
        }

        public int isValidBookAdd(string id, string Name,string Author,string Public,string Price,string Quantity,string imagePath )
        {
            if (!int.TryParse(id.ToString(), out int Id) || Id <= 0)
            {
                return 1;
            }
            if (string.IsNullOrEmpty(Name))
            {
                   return 2; 
            }

            if (string.IsNullOrWhiteSpace(Author))
            {
                return 3; 
            }

            if (string.IsNullOrWhiteSpace(Public))
            {              
                return 4; 
            }

            if (!int.TryParse(Price.ToString(), out int price) || price <= 0)
            {                
                return 5; 
            }

            if (!int.TryParse(Quantity.ToString(), out int quantity) || quantity <= 0)
            {                
                return 6; 
            }
            if (Name.Any(char.IsDigit))
            {
                return 7;
            }
            if (Author.Any(char.IsDigit))
            {
                return 8;
            }
            if (Public.Any(char.IsDigit))
            {
                return 9;
            }
            if (string.IsNullOrEmpty(imagePath))
            {
                return 10;
            }
         
            return 0;
        }

        public int isValidBookUpdate( string Name, string Author, string Public, string Price, string Quantity, string imagePath)
        {
            if (string.IsNullOrEmpty(Name))
            {
                return 1;
            }

            if (string.IsNullOrWhiteSpace(Author))
            {
                return 2;
            }

            if (string.IsNullOrWhiteSpace(Public))
            {
                return 3;
            }

            if (!int.TryParse(Price.ToString(), out int price) || price <= 0)
            {
                return 4;
            }

            if (!int.TryParse(Quantity.ToString(), out int quantity) || quantity <= 0)
            {
                return 5;
            }
            if (Name.Any(char.IsDigit))
            {
                return 6;
            }
            if (Author.Any(char.IsDigit))
            {
                return 7;
            }
            if (Public.Any(char.IsDigit))
            {
                return 8;
            }
            if (string.IsNullOrEmpty(imagePath))
            {
                return 9;
            }
          
            return 0;
        }

        public void updateBook(int id, Sach newSach)
        {
            sachById.updateBook(id,newSach);
        }

        public void addBook(Sach newSach)
        {
            sac.addBook(newSach);
        }
        public List<Sach> searchBook(string Name)
        {
            return sac.searchBook(Name);
        }
        public bool AreEqual(Sach sach1, Sach sach2)
        {
            return sach1.Name == sach2.Name &&
                   sach1.Author == sach2.Author &&
                   sach1.Publication == sach2.Publication &&
                   sach1.bDate == sach2.bDate &&
                   sach1.Price == sach2.Price &&
                   sach1.Quantity == sach2.Quantity &&
                   sach1.imgPath == sach2.imgPath;
        }

        public bool DoesBookExistAdd(string id,string Name,string Author)
        {
            return sac.DoesBookExistAdd(id,Name,Author);
        }

        public bool DoesBookExistUpdate(string name, string author)
        {
            return sac.DoesBookExistUpdate(name, author);
        }
        public List<string> GetBookNames()
        {
            return sac.GetBookNames();
        }
    }
}
