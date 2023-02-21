using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace BTVNtuan3
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        HocSinhDAO hsd = new HocSinhDAO(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        public bool CheckDT()
        {
            if (txtMHS.Text == "" || txtTen.Text == "" || txtEmail.Text == "" || txtQue.Text == "" || txtSDT.Text == "" || txtCMND.Text == "")
            {
                MessageBox.Show("Thiếu dữ liệu");
                return false;
            }
            if (dtp_DOB.Value.Year > 2005)
            {
                MessageBox.Show("Chưa đủ 18 tuổi");
                return false;
            }
            return true;
        }
        private void HienThiDanhSach()
        {
            this.gvHS.DataSource = hsd.LayDanhSachSinhVien();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(CheckDT())
            {
                HocSinh hs =
                new HocSinh(txtMHS.Text, txtTen.Text, txtQue.Text, dtp_DOB.Value, txtCMND.Text, txtEmail.Text, txtSDT.Text);
                hsd.Them(hs);

                HienThiDanhSach();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(CheckDT())
            {
                HocSinh hs =
                new HocSinh(txtMHS.Text, txtTen.Text, txtQue.Text, dtp_DOB.Value, txtCMND.Text, txtEmail.Text, txtSDT.Text);
                hsd.Xoa(hs);

                HienThiDanhSach();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {           
            if(CheckDT())
            {
                HocSinh hocSinh =
                new HocSinh(txtMHS.Text, txtTen.Text, txtQue.Text, dtp_DOB.Value, txtCMND.Text, txtEmail.Text, txtSDT.Text);
                hsd.Sua(hocSinh);

                HienThiDanhSach();
            }
        }

        private void btn_FGV_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void gvHS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvHS.CurrentRow.Index;

            txtMHS.Text = gvHS.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = gvHS.Rows[i].Cells[1].Value.ToString();
            txtQue.Text = gvHS.Rows[i].Cells[2].Value.ToString();
            dtp_DOB.Text = gvHS.Rows[i].Cells[3].Value.ToString();
            txtCMND.Text = gvHS.Rows[i].Cells[4].Value.ToString();
            txtEmail.Text= gvHS.Rows[i].Cells[5].Value.ToString();
            txtSDT.Text= gvHS.Rows[i].Cells[6].Value.ToString();
        }
    }
}
