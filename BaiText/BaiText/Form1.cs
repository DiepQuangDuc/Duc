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
using System.Data;
namespace BaiText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1GLDICO\SQLEXPRESS;Initial Catalog=NguoiDung;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "Select *from NguoiDung where TaiKhoan='"+tk+"'and MatKhau='"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read()== true)
                {
                    MessageBox.Show("Bạn đăng nhập thành công !");
                }
                else
                {
                    MessageBox.Show("Bạn đăng nhập thất bại !");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
