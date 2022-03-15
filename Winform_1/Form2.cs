using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_1.ConnectSqlNamespace;
using Syncfusion.XlsIO;
using System.IO;

namespace Winform_1
{
    public partial class Form2 : Form
    {
        private ConnectSql connectSql = new ConnectSql();

        private string msv;
        private string hoTen;
        private string que;
        private string lop;
        private double hocPhi;
        private string ngaySinh;
        private string khoa;
        private double diem;
        private string gioiTinh = "nữ";
        private string msvDelete;
        private string searchname;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectSql.OpenConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connectSql.CloseConnection();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlsvDataSet.SV' table. You can move, or remove it, as needed.
            // this.sVTableAdapter.Fill(this.qlsvDataSet.SV);
            connectSql.OpenConnection();
            connectSql.GetAllAndRender(dataGridView1);
            dataGridView1.Refresh();
            connectSql.CloseConnection();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
        }

        private void msvInp_TextChanged(object sender, EventArgs e)
        {
            if (msvInp.Text != "")
            {
                msv = msvInp.Text;
            }
        }

        private void hotenInp_TextChanged(object sender, EventArgs e)
        {
            if (hotenInp.Text != "")
            {
                hoTen = hotenInp.Text;
            }
        }

        private void queInp_TextChanged(object sender, EventArgs e)
        {
            if (queInp.Text != "")
            {
                que = queInp.Text;
            }
        }

        private void lopInp_TextChanged(object sender, EventArgs e)
        {
            if (lopInp.Text != "")
            {
                lop = lopInp.Text;
            }
        }

        private void hocphiInp_ValueChanged(object sender, EventArgs e)
        {
            hocPhi = Convert.ToDouble(hocphiInp.Value);
        }

        private void khoaInp_TextChanged(object sender, EventArgs e)
        {
            if (khoaInp.Text != "")
            {
                khoa = khoaInp.Text;
            }
        }

        private void ngaysinhDatePick_ValueChanged(object sender, EventArgs e)
        {
            if (ngaysinhDatePick.Value != null)
            {
                ngaySinh = ngaysinhDatePick.Value.ToString("yyyy-MM-dd");
            }
        }

        private void diemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (diemComboBox.SelectedIndex != -1)
            {
                string d = diemComboBox.Items[diemComboBox.SelectedIndex].ToString();
                diem = Convert.ToDouble(d);
                //MessageBox.Show(d);
            }
        }

        private void gtNamRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (gtNamRadBtn.Checked)
            {
                gioiTinh = "nam";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            /*string test = string.Format("{0,10} {1,10},{2,10},{3,10},{4,10},{5,10},{6,10},{7,10} {8,10}\n" +
            "{9,10},{10,10},{11,10},{12,10},{13,10},{14,10},{15,10},{16,10},{17,10}",
            "msv", "hoTen", "que", "lop", "hocPhi", "ngaySinh", "khoa", "diem", "gioiTinh",
            msv, hoTen, que, lop, hocPhi, ngaySinh, khoa, diem, gioiTinh);
            MessageBox.Show(test);*/
            connectSql.OpenConnection();
            connectSql.InSert(msv, hoTen, ngaySinh, gioiTinh, que, lop, khoa, diem, hocPhi);
            connectSql.GetAllAndRender(dataGridView1);
            connectSql.CloseConnection();
        }

        private void gtNuRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (gtNuRadBtn.Checked)
            {
                gioiTinh = "nữ";
            }
        }

        private void msvInpDelete_TextChanged(object sender, EventArgs e)
        {
            if (msvInpDelete.Text != "")
            {
                msvDelete = msvInpDelete.Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            connectSql.OpenConnection();
            connectSql.Delete(msvDelete);
            connectSql.GetAllAndRender(dataGridView1);
            connectSql.CloseConnection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //kiem tra o nhan vao co phai tieu de hay k
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                {
                    string msv_id = dataGridView1.CurrentCell.Value.ToString();
                    connectSql.OpenConnection();
                    List<string> listInfo = connectSql.GetInfoByIdAndRender(msv_id);
                    if (listInfo.Any())
                    {
                        msvInp.Text = listInfo[0].Trim();
                        hotenInp.Text = listInfo[1].Trim();
                        if (listInfo[2] != "")
                        {
                            ngaysinhDatePick.Value = DateTime.Parse(listInfo[2]);
                        }
                        gtNamRadBtn.Checked = (listInfo[3] == "nam");
                        gtNuRadBtn.Checked = (listInfo[3] != "nam");
                        queInp.Text = listInfo[4].Trim();
                        lopInp.Text = listInfo[5].Trim();
                        khoaInp.Text = listInfo[6].Trim();
                        diemComboBox.Text = listInfo[7];
                        hocphiInp.Value = decimal.Parse(listInfo[8]);
                    }

                    connectSql.CloseConnection();
                    //MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            connectSql.OpenConnection();
            connectSql.Update(msv, hoTen, ngaySinh, gioiTinh, que, lop, khoa, diem, hocPhi);
            connectSql.GetAllAndRender(dataGridView1);
            connectSql.CloseConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connectSql.OpenConnection();
            connectSql.total();
            connectSql.CloseConnection();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            connectSql.OpenConnection();
            connectSql.timkiem(searchname, dataGridView2);
            connectSql.CloseConnection();
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (timInp.Text != "")
            {
                searchname = timInp.Text;
            }
        }

        private void exportExcelBtn_Click(object sender, EventArgs e)
        {
            connectSql.OpenConnection();
            connectSql.exportExcel();
            connectSql.CloseConnection();
        }

        
    }
}