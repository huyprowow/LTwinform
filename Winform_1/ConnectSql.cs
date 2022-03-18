using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using Syncfusion.XlsIO;
using System.Reflection;
using Syroot.Windows.IO;

namespace Winform_1.ConnectSqlNamespace
{
    internal class ConnectSql
    {
        private string connectString = "Data Source=IA\\SQLEXPRESS;Initial Catalog=qlsv;Integrated Security=True";

        //private string data;//dlieu
        private SqlConnection connection;//ket noi duy tri

        public ConnectSql()
        {
            Initialize();
        }

        private void Initialize()
        {
            try
            {
                connection = new SqlConnection(connectString);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("sai chuoi ket noi " + ex.Message);
                MessageBox.Show("sai chuoi ket noi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void OpenConnection()
        {
            try
            {
                connection.Open();
                //    MessageBox.Show("open connect success");
            }
            catch (Exception ex)
            {
                /*switch (ex.ErrorCode)
                {
                    case 0:
                        break;
                }*/

                MessageBox.Show(ex.Message);
            }
        }

        internal void CloseConnection()
        {
            try
            {
                connection.Close();
                //   MessageBox.Show("close connect success");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void GetAllAndRender(DataGridView dataGridView1)
        {
            try
            {
                string query = "select sv.msv,hoten,ngaysinh,gioitinh,que,lop,khoa,diem,hocphi from SV sv " +
                               "inner join DIEM d " +
                               "on d.msv = sv.msv";

                SqlCommand cmd = new SqlCommand(query, connection);
                //cmd.CommandType = CommandType.Text;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "result");
                dataGridView1.DataSource = dataSet.Tables["result"];

                dataGridView1.Columns[0].HeaderText = "Mã SV";
                dataGridView1.Columns[1].HeaderText = "Họ Tên";
                dataGridView1.Columns[2].HeaderText = "Ngày Sinh";
                dataGridView1.Columns[3].HeaderText = "Giới Tính";
                dataGridView1.Columns[4].HeaderText = "Quê Quán";
                dataGridView1.Columns[5].HeaderText = "Lớp";
                dataGridView1.Columns[6].HeaderText = "Khoa";
                dataGridView1.Columns[7].HeaderText = "Điểm";
                dataGridView1.Columns[8].HeaderText = "Học Phí";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void InSert(SV sv)
        {
            try
            {
                string query = "insert into SV values(@msv,@hoTen,@ngaySinh,@gioiTinh,@que,@lop,@khoa,@hocPhi);" +
                               "insert into DIEM values(@msv,@diem)";
                SqlCommand cmd = new SqlCommand(query, connection);

                /////parameter nao truyen vao k co => dat la null tru msv (khoa chinh)
                if (!string.IsNullOrEmpty(sv.msv))
                {
                    if (sv.msv.Length > 5)
                    {
                        throw new Exception("ma sinh vien khong qua 5 ki tu");
                    }
                    bool isMsvExit = isExit(sv.msv);
                    if (isMsvExit)
                    {
                        throw new Exception("ma sinh vien da co");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@msv", sv.msv);
                    }
                }
                else
                {
                    throw new Exception("ma sinh vien k the de trong");
                }

                cmd.Parameters.Add(new SqlParameter("@hoTen", SqlDbType.NVarChar)).Value =
                    !string.IsNullOrEmpty(sv.hoTen) ? sv.hoTen : (object)DBNull.Value;

                cmd.Parameters.Add(new SqlParameter("@ngaySinh", SqlDbType.Date)).Value =
                 !string.IsNullOrEmpty(sv.ngaySinh) ? sv.ngaySinh : (object)DBNull.Value;

                cmd.Parameters.Add(new SqlParameter("@gioiTinh", SqlDbType.NVarChar)).Value = sv.gioiTinh;

                cmd.Parameters.Add(new SqlParameter("@que", SqlDbType.NVarChar)).Value =
                    !string.IsNullOrEmpty(sv.que) ? sv.que : (object)DBNull.Value;

                cmd.Parameters.Add(new SqlParameter("@lop", SqlDbType.VarChar)).Value =
                    !string.IsNullOrEmpty(sv.lop) ? sv.lop : (object)DBNull.Value;

                cmd.Parameters.Add(new SqlParameter("@khoa", SqlDbType.VarChar)).Value =
                    !string.IsNullOrEmpty(sv.khoa) ? sv.khoa : (object)DBNull.Value;

                cmd.Parameters.AddWithValue("@diem", sv.diem);
                cmd.Parameters.AddWithValue("@hocPhi", sv.hocPhi);

                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                {
                    MessageBox.Show("Loi khi them dl vao csdl", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Them thanh cong", "Success", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void Delete(string msvDelete)
        {
            try
            {
                if (!string.IsNullOrEmpty(msvDelete))
                {
                    string query = "delete from DIEM where msv=@msvDelete;" +
                                   "delete from SV where msv=@msvDelete";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@msvDelete", msvDelete);
                    int res = cmd.ExecuteNonQuery();

                    if (res == 0)
                    {
                        MessageBox.Show("msv nay khong co", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("xoa thanh cong", "Success", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    throw new Exception("ma sinh vien k the de trong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal List<string> GetInfoByIdAndRender(string msv)
        {
            try
            {
                List<string> list = new List<string>();
                string query = "select sv.msv,hoten,ngaysinh,gioitinh,que,lop,khoa,diem,hocphi from SV sv " +
                               "inner join DIEM d " +
                               "on d.msv = sv.msv " +
                               "where sv.msv=@msv";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@msv", msv);

                SqlDataReader reader = cmd.ExecuteReader();

                // goi Read() trc khi truy cap dl.
                while (reader.Read())
                {
                    //(IDataRecord)reader
                    /* string m = string.Format("|{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|{7,10}|{8,10}|",
                         reader["msv"].ToString(),
                         reader["hoten"].ToString(),
                         reader["ngaySinh"].ToString(),
                         reader["gioiTinh"].ToString(),
                         reader["que"].ToString(),
                         reader["lop"].ToString(),
                         reader["khoa"].ToString(),
                         reader["diem"].ToString(),
                         reader["hocPhi"].ToString()
                         );
                     MessageBox.Show(m);*/
                    list.Add(reader["msv"].ToString());
                    list.Add(reader["hoten"].ToString());
                    list.Add(reader["ngaySinh"].ToString());
                    list.Add(reader["gioiTinh"].ToString());
                    list.Add(reader["que"].ToString());
                    list.Add(reader["lop"].ToString());
                    list.Add(reader["khoa"].ToString());
                    list.Add(reader["diem"].ToString());
                    list.Add(reader["hocPhi"].ToString());
                }

                // goi close khi doc xong.
                reader.Close();
                /*SqlDataReader reader = command.ExecuteReader();
                DataTable schemaTable = reader.GetSchemaTable();

                foreach (DataRow row in schemaTable.Rows)
                {
                    foreach (DataColumn column in schemaTable.Columns)
                    {
                        Console.WriteLine(String.Format("{0} = {1}",
                           column.ColumnName, row[column]));
                    }
                }*/
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        internal void Update(SV sv)
        {
            try
            {
                string query =
                    "update SV " +
                    "set hoten=@hoTen,ngaysinh=@ngaySinh,gioitinh=@gioiTinh,que=@que,lop=@lop,khoa=@khoa,hocphi=@hocPhi " +
                    "where msv=@msv;" +
                    "update DIEM set diem=@diem where msv=@msv;";
                SqlCommand cmd = new SqlCommand(query, connection);

                if (!string.IsNullOrEmpty(sv.msv))
                {
                    if (sv.msv.Length > 5)
                    {
                        throw new Exception("ma sinh vien khong qua 5 ki tu");
                    }
                    bool isMsvExit = isExit(sv.msv);
                    if (isMsvExit)
                    {
                        cmd.Parameters.AddWithValue("@msv", sv.msv);
                    }
                    else
                    {
                        throw new Exception("ma sinh vien khong ton tai");
                    }
                }
                else
                {
                    throw new Exception("ma sinh vien k the de trong");
                }

                cmd.Parameters.Add(new SqlParameter("@hoTen", SqlDbType.NVarChar)).Value =
                    !string.IsNullOrEmpty(sv.hoTen) ? sv.hoTen : (object)DBNull.Value;

                cmd.Parameters.Add(new SqlParameter("@ngaySinh", SqlDbType.Date)).Value =
                 !string.IsNullOrEmpty(sv.ngaySinh) ? sv.ngaySinh : (object)DBNull.Value;

                cmd.Parameters.Add(new SqlParameter("@gioiTinh", SqlDbType.NVarChar)).Value = sv.gioiTinh;

                cmd.Parameters.Add(new SqlParameter("@que", SqlDbType.NVarChar)).Value =
                    !string.IsNullOrEmpty(sv.que) ? sv.que : (object)DBNull.Value;

                cmd.Parameters.Add(new SqlParameter("@lop", SqlDbType.VarChar)).Value =
                    !string.IsNullOrEmpty(sv.lop) ? sv.lop : (object)DBNull.Value;

                cmd.Parameters.Add(new SqlParameter("@khoa", SqlDbType.VarChar)).Value =
                    !string.IsNullOrEmpty(sv.khoa) ? sv.khoa : (object)DBNull.Value;

                cmd.Parameters.AddWithValue("@diem", sv.diem);
                cmd.Parameters.AddWithValue("@hocPhi", sv.hocPhi);

                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                {
                    MessageBox.Show("Loi khi sua dl", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Sua thanh cong", "Success", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal bool isExit(string msv)
        {
            string query = "select * from SV where msv=@msv";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@msv", msv);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                /*MessageBox.Show("co");*/
                return true;
            }
            else
            {
                reader.Close();
                /* MessageBox.Show("k");*/
                return false;
            }
        }

        internal void exportExcel()
        {
            try
            {
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    {
                        IApplication application = excelEngine.Excel;
                        application.DefaultVersion = ExcelVersion.Excel2016;
                        //tao workbook
                        IWorkbook workbook = application.Workbooks.Create(1);
                        IWorksheet sheet = workbook.Worksheets[0];

                        string query = "select sv.msv,hoten,ngaysinh,gioitinh,que,lop,khoa,diem,hocphi from SV sv " +
                                       "inner join DIEM d " +
                                       "on d.msv = sv.msv";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        //cmd.CommandType = CommandType.Text;
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet, "result");

                        //tao datatable
                        DataTable dataTable = new DataTable();
                        dataTable = dataSet.Tables["result"];
                        sheet.ImportDataTable(dataTable, true, 1, 1, true);

                        //tao bang Excel dat style
                        IListObject table = sheet.ListObjects.Create("Student_PersonalDetails", sheet.UsedRange);

                        //style

                        table.Columns[0].Name = "Mã SV";
                        table.Columns[1].Name = "Họ Tên";
                        table.Columns[2].Name = "Ngày Sinh";
                        table.Columns[3].Name = "Giới Tính";
                        table.Columns[4].Name = "Quê Quán";
                        table.Columns[5].Name = "Lớp";
                        table.Columns[6].Name = "Khoa";
                        table.Columns[7].Name = "Điểm";
                        table.Columns[8].Name = "Học Phí";

                        table.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium14;

                        sheet.Columns[2].NumberFormat = "m/d/yyyy";

                        sheet.Rows[0].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        sheet.Columns[0].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        sheet.Columns[2].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        sheet.Columns[3].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        sheet.Columns[5].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        sheet.Columns[6].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        sheet.Columns[7].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        sheet.Columns[8].HorizontalAlignment = ExcelHAlign.HAlignCenter;

                        //Autofit the columns
                        sheet.UsedRange.AutofitColumns();

                        //luu file
                        string downloadsPath = new KnownFolder(KnownFolderType.Downloads).Path;
                        string excelExportedPath = downloadsPath + "\\Output.xlsx";
                        Stream excelStream = File.Create(excelExportedPath);
                        workbook.SaveAs(excelStream);
                        excelStream.Dispose();
                        MessageBox.Show("file da dc xuat tai " + excelExportedPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void total()
        {
            string query = "select sum(hocphi) from SV";
            SqlCommand cmd = new SqlCommand(query, connection);
            string tong = Convert.ToString(cmd.ExecuteScalar());
            MessageBox.Show("Tổng học phí của danh sách sinh viên là:\n" + tong);
        }

        internal void timkiem(string searchname, DataGridView dataGridView1)
        {
            string query = "select sv.msv,hoten,ngaysinh,gioitinh,que,lop,khoa,diem,hocphi from SV sv " +
                               "inner join DIEM d " +
                               "on d.msv = sv.msv where sv.msv = @msv or sv.hoten=@hoten";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@msv", searchname);
            cmd.Parameters.AddWithValue("@hoten", searchname);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "result");
            dataGridView1.DataSource = dataSet.Tables["result"];

            dataGridView1.Columns[0].HeaderText = "Mã SV";
            dataGridView1.Columns[1].HeaderText = "Họ Tên";
            dataGridView1.Columns[2].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[3].HeaderText = "Giới Tính";
            dataGridView1.Columns[4].HeaderText = "Quê Quán";
            dataGridView1.Columns[5].HeaderText = "Lớp";
            dataGridView1.Columns[6].HeaderText = "Khoa";
            dataGridView1.Columns[7].HeaderText = "Điểm";
            dataGridView1.Columns[8].HeaderText = "Học Phí";
        }
    }
}