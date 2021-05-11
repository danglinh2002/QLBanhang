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

namespace DE4QLHANGHOA_ADO
{
    public partial class F_CHITIETHANG : Form
    {
        public F_CHITIETHANG()
        {
            InitializeComponent();
            LoadChiTiet();
        }
        public DataTable Connect(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = new SqlConnection(FCONNECT.ckn);
                SqlCommand com = new SqlCommand(query, con);
                com.CommandType = CommandType.Text;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(com);
                //tạo 1kho ảo để lưu dl về
                //là lớp con của DataSet
                da.Fill(dt);
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return dt;
        }
        public void LoadChiTiet()
        {
            //DataTable dtMatHang = new DataTable();
            //string query = "select a.tenhanghoa,a.dongia,a.ghichu," +
            //    "b.tenhangsx,a.maloai from mathang a,hang b,loai c " +
            //    "where mahanghoa='" + FMATHANG.maMatHang + 
            //    "' and a.maloai=c.maloai and c.mahangsx=b.mahangsx";
            //dtMatHang = Connect(query);
            ////dataGridView1.DataSource = dtMatHang;
            //DataRow dr = dtMatHang.Rows[0];
            //txtTenhang.Text = dr[0].ToString();
            //txtDongia.Text = dr[1].ToString();
            //txtGhichu.Text = dr[2].ToString();
            //txtHangsx.Text = dr[3].ToString();
            //txtLoaihang.Text = dr[4].ToString();
            DataTable dtMatHang = new DataTable();
            string query = "Select * from MATHANG where mahanghoa='" + FMATHANG.maMatHang+"'";
            MessageBox.Show(FMATHANG.maMatHang);
            dtMatHang = Connect(query);
            DataRow dr = dtMatHang.Rows[0];
            txtTenhang.Text = dr[1].ToString();
            txtDongia.Text = dr[2].ToString();
            txtGhichu.Text = dr[3].ToString();
            txtHangsx.Text =FMATHANG.hang;
            txtLoaihang.Text = FMATHANG.loai;
                    }
    }
}
