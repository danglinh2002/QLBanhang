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
    public partial class FNHAPMATHANG : Form
    {
        public FNHAPMATHANG()
        {
            InitializeComponent();
            LoadLoai();
            
        }

        public DataTable Connect(string query)
        {
            DataTable dt = new DataTable();
            try
            {             
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2BIAERK\SQLSERVER2012;Initial Catalog=DE4QLHANGHOA;Integrated Security=True");
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                con.Close();
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại");
            }
            return dt;
        }
        //hàm load Loại xuống combobox
        public void LoadLoai()
        {
            DataTable dt = new DataTable();
            dt = Connect("select * from loai");
            foreach(DataRow i in dt.Rows)
            {
                Loai loai = new Loai()
                {
                    maloai = Convert.ToInt16(i["maloai"]),
                    tenloai = i["tenloai"].ToString(),
                    mahangsx=i["mahangsx"].ToString()
                };
                cboLoai.Items.Add(loai);
            }
        }

        //hàm thực thi đối với các câu lệnh:insert,delete,update
        public void ExecQuery(string query)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2BIAERK\SQLSERVER2012;Initial Catalog=DE4QLHANGHOA;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            con.Close();
        }
        //hàm load mặt hàng xuống datagridview
        public void LoadMatHang()
        {
            DataTable dt = new DataTable();
            dt = Connect("select * from mathang");
            dgvMathang.DataSource = dt;
            int j = 1;
            foreach(DataGridViewRow i in dgvMathang.Rows)
            {
                if (i != null)
                {
                    i.Cells[0].Value = j;
                    j++;
                }
            }
        }
       
        //nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Khi nhấn nút Thêm thì giá trị thuộc tính Text chuyển thành "Lưu"
            //và xóa trống các điều khiển
            if (btnThem.Text == "THÊM")
            {
                ClearControl();
                btnThem.Text = "LƯU";
            }
            else
                if (txtMaMatHang.Text != "")
                {
                    try
                    {
                        string mahh = txtMaMatHang.Text;
                        string tenhh = txtTenMatHang.Text;
                        double dongia = Convert.ToDouble(txtDonGia.Text);
                        string ghichu = txtGhiChu.Text;
                        int maloai = Convert.ToInt16(((Loai)cboLoai.SelectedItem).maloai);
                        // Query string - vì maloai là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                        string query = 
                        string.Format("INSERT INTO MATHANG(MAHANGHOA,TENHANGHOA,DONGIA,GHICHU,MALOAI) " +
                        "VALUES ('{0}',N'{1}',{2},N'{3}',{4})", mahh, tenhh, dongia, ghichu, maloai);
                        ExecQuery(query);
                        LoadMatHang();
                        btnThem.Text = "THÊM";
                    }
                    catch { MessageBox.Show("Lỗi nhập dữ liệu"); }
                }
                
        }
        //phương thức ClearControl để xóa trống các điều khiển và đặt focus vào txtMaMatHang
        public void ClearControl()
        {
            txtMaMatHang.Clear();
            txtTenMatHang.Clear();
            txtDonGia.Clear();
            txtGhiChu.Clear();
            cboLoai.Text = "";
            txtMaMatHang.Focus();
        }
        //nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnThem.Text = "THÊM";
            string mahh = dgvMathang.SelectedRows[0].Cells[1].Value.ToString(); //Cells[1]: ô mã hàng hóa
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
                string query = "delete from mathang where mahanghoa='" + mahh + "'";
                ExecQuery(query);
                LoadMatHang();
                ClearControl();
            }

        }

        //load tên loại lên combobox khi biết mã loại
        public void LoadTenLoai(string maloai)
        {
            DataTable dtLoai = new DataTable();
            dtLoai = Connect("select * from loai where maloai="+maloai);
            DataRow dr = dtLoai.Rows[0];
            cboLoai.Text = dr[1].ToString(); //hiển thị tên loại là cột thứ 2 trong dr lên combobox
        }

        //khi nhấn chuột chọn đầu dòng thì đưa thông tin mặt hàng được chọn lên các điều khiển
        private void dgvMathang_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string mahh = dgvMathang.SelectedRows[0].Cells[1].Value.ToString(); //cells[1]:ô thứ 2 là mã hàng hóa
            DataTable dt = new DataTable();
            dt = Connect("select * from mathang where mahanghoa = '" + mahh + "'");
            foreach (DataRow i in dt.Rows)
            {
                txtMaMatHang.Text = i["mahanghoa"].ToString();
                txtTenMatHang.Text = i["tenhanghoa"].ToString();
                txtDonGia.Text = i["dongia"].ToString();
                txtGhiChu.Text = i["ghichu"].ToString();
                string maloai = i["maloai"].ToString();
                LoadTenLoai(maloai);
            }
        }

        //nút Sửa: chỉ sửa được thông tin tenhanghoa,dongia,ghichu
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Text = "THÊM";
            if (txtMaMatHang.Text != "")
            {
                string mahh = dgvMathang.SelectedRows[0].Cells[1].Value.ToString(); //cells[1]:ô thứ 2 là mã hàng hóa
                string tenhh = txtTenMatHang.Text;
                double dongia = Convert.ToDouble(txtDonGia.Text);
                string ghichu = txtGhiChu.Text;
                string query = "update mathang set tenhanghoa=N'" + tenhh + "',dongia=" + "dongia" + ",ghichu=N'" + ghichu + "' where mahanghoa='" + mahh + "'";
                ExecQuery(query);
                //load lại dữ liệu mới xuống datagridview
                LoadMatHang();
            }
        }

        private void FNHAPMATHANG_Load(object sender, EventArgs e)
        {
            LoadMatHang();
        }
    }//đóng class
}//đóng namespace
