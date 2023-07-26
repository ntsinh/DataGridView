using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView
{
    public class NhanVien
    {
        private string idNv;
        private string tenNv;
        private DateOnly ngaySinh;
        private string diaChi;

        public string TenNv { get => tenNv; set => tenNv = value; }
        public DateOnly NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string IdNv { get => idNv; set => idNv = value; }

        public NhanVien(string idNv, string tenNv, DateOnly ngaySinh, string diaChi)
        {
            IdNv = idNv;
            TenNv = tenNv;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
        }
        
    }
    
}
