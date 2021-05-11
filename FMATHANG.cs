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
    public partial class FMATHANG : Form
    {
        public static string maMatHang, hang, loai;
        public FMATHANG()
        {
            InitializeComponent();
            LoadHang();
        }
        //hàm kết nối đến csdl và thực thi câu query rồi lưu dữ liệu vào datatable dt
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
                MessageBox.Show("Kết nối thất bại");              
            }
            return dt;
        }

        //lấy dữ liệu từ DataTable dt rồi đổ vào combobox cbHang
        public void LoadHang()
        {
            DataTable dt = new DataTable();
            dt = Connect("select * from hang");
            foreach (DataRow i in dt.Rows)
            {
                Hang hang = new Hang()
                {
                    mahangsx = i["mahangsx"].ToString(),
                    tenhangsx = i["tenhangsx"].ToString()
                };
                cbHang.Items.Add(hang);
            }
        }

        //lấy loại hàng từ 1 DataTable đổ vào combobox cbLoai
        public void LoadLoai(DataTable dt)
        {
            foreach (DataRow i in dt.Rows)
            {
                Loai loai = new Loai()
                {
                    maloai = Convert.ToInt16(i["maloai"]),
                    tenloai = i["tenloai"].ToString(),
                    mahangsx = i["mahangsx"].ToString()
                };
                cbLoai.Items.Add(loai);
            }
        }

        //khi chọn Hãng trong cbHang thì đổ loại ra cbLoai
        private void cbHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLoai.Items.Clear();
            DataTable dt = new DataTable();
            string selectedmahangsx = ((Hang)(cbHang.SelectedItem)).mahangsx;
            dt = Connect("select * from loai where mahangsx="+selectedmahangsx);
            LoadLoai(dt);
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string selectedmaloai = ((Loai)(cbLoai.SelectedItem)).maloai.ToString();
            dt = Connect("select * from mathang where maloai="+selectedmaloai);
            dgvMathang.DataSource = dt;
            //thêm cột stt vào datagridview
            int j = 1;
            foreach (DataGridViewRow i in dgvMathang.Rows)
            {
                if (i != null)
                {
                    i.Cells[0].Value = j;
                    j++;
                }
            }
        }

        private void xóaMặtHàngĐangChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa?", "Xác nhận", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
                //kết nối csdl áp dụng đối với các lệnh: insert,update,delete
                string selectedMaMatHang;
                SqlConnection con = new SqlConnection(FCONNECT.ckn);
                con.Open();
                selectedMaMatHang = dgvMathang.SelectedRows[0].Cells["mahanghoa"].Value.ToString();
                string query = "delete from mathang where mahanghoa='" + selectedMaMatHang+"'";
                SqlCommand com = new SqlCommand(query, con);
                int sodong = com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(sodong + " affected");
                //Load mặt hàng xuống datagridview
                cbLoai_SelectedIndexChanged(sender, e);
            }
            else
            {
                //Load mặt hàng xuống datagridview
                cbLoai_SelectedIndexChanged(sender, e);
            }
        }
        //khi click chuột lên 1 ô của datagridview dgvMathang thì chọn luôn 1 dòng
        private void dgvMathang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                dgvMathang.CurrentRow.Selected = true;
            }
            catch { }
        }

        private void dgvMathang_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                //lấy thông tin hit là số dòng, số cột tại tọa độ e.X,e.Y
                var hit = dgvMathang.HitTest(e.X, e.Y);

                //clear dòng được chọn trước đó để mỗi lần kích phải chuột chỉ chọn 1 dòng
                dgvMathang.ClearSelection();

                //khi nhấn phải chuột trên dòng nào thì dòng đó được chọn
                dgvMathang.Rows[hit.RowIndex].Selected = true;

                //show menu context tại tọa độ đư kích phải chuột
                cmsMatHang.Show(dgvMathang, new Point(e.X, e.Y));
            }
        }

        private void hiểnThịThôngTinChiTiếtMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lấy về thông tin mặt hàng được chọn; mamathang là name của cột trong dgvMatHang
            maMatHang = dgvMathang.SelectedRows[0].Cells["mahanghoa"].Value.ToString();
            hang = cbHang.Text;
            loai = cbLoai.Text;
            F_CHITIETHANG f_CHITIETHANG = new F_CHITIETHANG();
            f_CHITIETHANG.Show();

        }
    }
}
