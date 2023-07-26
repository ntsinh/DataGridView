using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView
{
    public class Dsnv
    {
        private static Dsnv instance;
        public static Dsnv Instance {
            get {
                if (instance==null)
                {
                    instance= new Dsnv();
                }
                return instance; }
            set => instance = value;
        }

        List<NhanVien> listNv;
        public List<NhanVien> ListNv { get => listNv; set => listNv = value; }

        private Dsnv()
        {
            listNv = new List<NhanVien>();
            listNv.Add(new NhanVien("01", "sinh", new DateOnly(1996,1,1),"daklak"));
            listNv.Add(new NhanVien("02", "hung", new DateOnly(1997, 1, 23), "saigon"));
            listNv.Add(new NhanVien("03", "dao", new DateOnly(1998, 11, 1), "govap"));
        }
        public void addNv(NhanVien nv)
        {
            listNv.Add(nv);
            MessageBox.Show("da them");
        }
    }
}
