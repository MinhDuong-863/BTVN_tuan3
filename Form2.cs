using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTVNtuan3
{
    public partial class Form2 : Form
    {
        GiaoVienDAO gvd = new GiaoVienDAO();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        public bool CheckDT()
        {
            if (txtMGV.Text == "" || txtTen.Text == "" || txtEmail.Text == "" || txtQue.Text == "" || txtSDT.Text == "" || txtCMND.Text == "")
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
            this.gvGV.DataSource = gvd.LayDanhSachGiaoVien();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (CheckDT())
            {
                GiaoVien giaoVien =
                new GiaoVien(txtMGV.Text, txtTen.Text, txtQue.Text, dtp_DOB.Value, txtCMND.Text, txtEmail.Text, txtSDT.Text);
                gvd.Them(giaoVien);

                HienThiDanhSach();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (CheckDT())
            {
                GiaoVien giaoVien =
                new GiaoVien(txtMGV.Text, txtTen.Text, txtQue.Text, dtp_DOB.Value, txtCMND.Text, txtEmail.Text, txtSDT.Text);
                gvd.Xoa(giaoVien);

                HienThiDanhSach();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (CheckDT())
            {
                GiaoVien giaoVien =
                new GiaoVien(txtMGV.Text, txtTen.Text, txtQue.Text, dtp_DOB.Value, txtCMND.Text, txtEmail.Text, txtSDT.Text);
                gvd.Sua(giaoVien);

                HienThiDanhSach();
            }
        }

        private void btn_FHS_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gvGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvGV.CurrentRow.Index;

            txtMGV.Text = gvGV.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = gvGV.Rows[i].Cells[1].Value.ToString();
            txtQue.Text = gvGV.Rows[i].Cells[2].Value.ToString();
            dtp_DOB.Text = gvGV.Rows[i].Cells[3].Value.ToString();
            txtCMND.Text = gvGV.Rows[i].Cells[4].Value.ToString();
            txtEmail.Text = gvGV.Rows[i].Cells[5].Value.ToString();
            txtSDT.Text = gvGV.Rows[i].Cells[6].Value.ToString();
        }

        
    }
}

