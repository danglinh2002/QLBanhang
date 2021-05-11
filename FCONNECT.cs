using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE4QLHANGHOA_ADO
{
    public partial class FCONNECT : Form
    {
        public static string ckn;
        public FCONNECT()
        {
            InitializeComponent();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            if (txtTenMay.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên máy");
                txtTenMay.Focus();
                return;
            }
            if (txtTenCsdl.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên csdl");
                txtTenCsdl.Focus();
                return;
            }
            if (txtTenMay.Text != "" && txtTenCsdl.Text != "" 
                && txtUser.Text == "" && txtPassword.Text == "")
            {
                if (txtTenMay.Text == "." && txtTenCsdl.Text == ".")
                {
                    txtTenMay.Text = @"DESKTOP-2BIAERK\SQLSERVER2012";
                    txtTenCsdl.Text = "DE4QLHANGHOA";
                }
                ckn = "Data Source=" + txtTenMay.Text + 
                    ";Initial Catalog=" + txtTenCsdl.Text + 
                    ";Integrated Security=True";
                string ckn1 = @"Data Source=DESKTOP-2BIAERK\SQLSERVER2012;" +
                    "Initial Catalog=DE4QLHANGHOA;" +
                    "Integrated Security=True";
                if (String.Compare(ckn, ckn1, true) == 0)   
                    //true: so sánh 2 chuỗi ko phân biệt hoa thường
                {
                    FMATHANG f_mh = new FMATHANG();
                    f_mh.Show();
                }
                else MessageBox.Show("Kết nối không thành công " +
                    "do Tên máy/Tên csdl không đúng");
            }
            if (txtTenMay.Text != "" && txtTenCsdl.Text != "" &&
                txtUser.Text != "" && txtPassword.Text != "")
            {
                if (txtTenMay.Text == "." && txtTenCsdl.Text == ".")
                {
                    txtTenMay.Text = @"DESKTOP-2BIAERK\SQLSERVER2012";
                    txtTenCsdl.Text = "DE4QLHANGHOA";
                }

                ckn = @"Data Source=" + txtTenMay.Text + ";" +
                    "Initial Catalog=" + txtTenCsdl.Text +
                    ";UserId=" + txtUser.Text +
                    ";Password=" + txtPassword.Text + 
                    ";MultipleActiveResultSets=true";
                string ckn2 = @"Data Source=DESKTOP-2BIAERK\SQLSERVER2012;" +
                    "Initial Catalog=DE4QLHANGHOA;" +
                    "Integrated Security=True;UserId=sa;" +
                    "Password=;MultipleActiveResultSets=true";
                if (string.Compare(ckn, ckn2, true) == 0)
                {
                    FMATHANG f_mh = new FMATHANG();
                    f_mh.Show();
                }
                else MessageBox.Show("Kết nối không thành công ");               
            }
            

        }
    }
}
