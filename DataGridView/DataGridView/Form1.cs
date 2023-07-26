using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lay thong tintu cac textbox tao thanh 1 nhan vien

            //add nhan vien do vao list

            //gan lai data cho gridview
            
            themNv();
            
            //MessageBox.Show("da them: " + txtTen.Text + DateOnly.Parse(txtDate.Text) + txtDiachi.Text);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvNv.DataSource = Dsnv.Instance.ListNv;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvNv.Rows[e.RowIndex];
            string id = row.Cells[3].Value.ToString();
            string ten = row.Cells[0].Value.ToString();
            DateOnly ngay = DateOnly.Parse(row.Cells[1].Value.ToString());
            string diachi = row.Cells[2].Value.ToString();
            txtId.Text = id;
            txtTen.Text = ten;
            txtDate.Text = ngay.ToString();
            txtDiachi.Text = diachi;
        }
        public void themNv()
        {
            string idnv = txtId.Text;
            string tennv = txtTen.Text;
            DateOnly ngaysinh =DateOnly.Parse(txtDate.Text);
            string diachinv = txtDiachi.Text;
            NhanVien nv = new NhanVien(idnv,tennv,ngaysinh,diachinv);
            Dsnv.Instance.addNv(nv);
            //dgvNv.DataSource = Dsnv.Instance.Dsnvv;
           
        }
        
    }
}