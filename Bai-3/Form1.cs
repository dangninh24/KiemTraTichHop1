using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Bai_3
{
    public partial class Form1 : Form
    {
        DataUtil dataUtil = new DataUtil();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void DeleteContent()
        {
            tboxID.Text = "";
            tboxTacgia.Text = "";
            tboxSoTrang.Text = "";
            tboxGiaTien.Text = "";
            tboxTenSach.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(tboxTenSach.Text.Length == 0 || tboxTacgia.Text.Length == 0)
                {
                    MessageBox.Show("Thông tin điền thiếu", "Thông báo");
                    return;
                }

                string tensach = tboxTenSach.Text.ToString();
                string tacgia = tboxTacgia.Text.ToString();
                int sotrang = int.Parse(tboxSoTrang.Text);
                float giatien = float.Parse(tboxGiaTien.Text.ToString());
                int id = int.Parse(tboxID.Text);

                CuonSach cuonSach = new CuonSach(id,tensach, sotrang, tacgia, giatien);
                if(dataUtil.AddXml(cuonSach))
                {
                    LoadData();
                    DeleteContent();
                    MessageBox.Show("Thêm thành công.", "Thông báo");
                } else
                {
                    MessageBox.Show("Thêm thất bại vì trùng ID.", "Thông báo");
                }

            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message, "Thông báo");
            }
        }

        private void LoadData()
        {
            gviewSach.DataSource = dataUtil.getListCuonSach();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string tensach = tboxTenSach.Text.ToString();
            string tacgia = tboxTacgia.Text.ToString();
            int sotrang = int.Parse(tboxSoTrang.Text);
            float giatien = float.Parse(tboxGiaTien.Text.ToString());
            int id = int.Parse(tboxID.Text);

            CuonSach cuonsach = new CuonSach(id, tensach, sotrang, tacgia, giatien);

            if (dataUtil.EditXml(cuonsach))
            {
                LoadData();
                DeleteContent();
                MessageBox.Show("Sửa thành công.", "Thông báo");
            } else
            {
                MessageBox.Show("Sửa không thành công.", "Thông báo");
            }
            
        }

        private void gviewSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CuonSach cuonSach = (CuonSach)gviewSach.CurrentRow.DataBoundItem;
            tboxGiaTien.Text = cuonSach.GiaTien.ToString();
            tboxID.Text = cuonSach.ID.ToString();
            tboxSoTrang.Text = cuonSach.SoTrang.ToString();
            tboxTenSach.Text = cuonSach.TenSach;
            tboxTacgia.Text = cuonSach.TacGia;            
        }

        private void tbnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if(dialog == DialogResult.Yes)
            {
                string id = tboxID.Text.ToString();
                bool delete = dataUtil.DeleteXml(id);

                if (delete)
                {
                    LoadData();
                    DeleteContent();
                    MessageBox.Show("Xóa thành công.", "Thông báo");
                } else
                {
                    MessageBox.Show("Xóa thất bại.", "Thông báo");

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = tboxID.Text.ToString();
            List<CuonSach> list = new List<CuonSach>();
            CuonSach cuonsach = dataUtil.SearchXml(id);

            if(cuonsach != null)
            {
                list.Add(cuonsach);
                gviewSach.DataSource = list;                
            }
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            LoadData();
            DeleteContent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
