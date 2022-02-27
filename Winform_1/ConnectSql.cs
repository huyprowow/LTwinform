using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                MessageBox.Show("open connect success");
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
                MessageBox.Show("close connect success");
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
                string query = "select * from SV";
                SqlCommand cmd = new SqlCommand(query, connection);
                //cmd.CommandType = CommandType.Text;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "result");
                dataGridView1.DataSource = dataSet.Tables["result"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void InSert(
            string msv,
            string hoTen,
            string ngaySinh,
            string gioiTinh,
            string que,
            string lop,
            string khoa,
            double diem,
            double hocPhi
            )
        {
            try
            {
                string query = "insert into SV values(@msv,@hoTen,@ngaySinh,@gioiTinh,@que,@lop,@khoa,@diem,@hocPhi)";
                SqlCommand cmd = new SqlCommand(query, connection);

                /////parameter nao truyen vao k co => dat la null tru msv (khoa chinh)
                if (!string.IsNullOrEmpty(msv))
                {
                    bool isMsvExit = isExit(msv);
                    if (isMsvExit)
                    {
                        throw new Exception("ma sinh vien da co");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@msv", msv);
                    }
                }
                else
                {
                    throw new Exception("ma sinh vien k the de trong");
                }

                cmd.Parameters.Add(new SqlParameter("@hoTen", SqlDbType.NVarChar)).Value =
                    !string.IsNullOrEmpty(hoTen) ? hoTen : (object)DBNull.Value;

                cmd.Parameters.Add(new SqlParameter("@ngaySinh", SqlDbType.Date)).Value =
                 !string.IsNullOrEmpty(ngaySinh) ? ngaySinh : (object)DBNull.Value;

                cmd.Parameters.Add(new SqlParameter("@gioiTinh", SqlDbType.NVarChar)).Value = gioiTinh;

                cmd.Parameters.Add(new SqlParameter("@que", SqlDbType.NVarChar)).Value =
                    !string.IsNullOrEmpty(que) ? que : (object)DBNull.Value;

                cmd.Parameters.Add(new SqlParameter("@lop", SqlDbType.VarChar)).Value =
                    !string.IsNullOrEmpty(lop) ? lop : (object)DBNull.Value;

                cmd.Parameters.Add(new SqlParameter("@khoa", SqlDbType.VarChar)).Value =
                    !string.IsNullOrEmpty(khoa) ? khoa : (object)DBNull.Value;

                cmd.Parameters.AddWithValue("@diem", diem);
                cmd.Parameters.AddWithValue("@hocPhi", hocPhi);

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
                    string query = "delete from SV where msv=@msvDelete";
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
                string query = "select * from SV where msv=@msv";

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

        internal void Update(
            string msv,
            string hoTen,
            string ngaySinh,
            string gioiTinh,
            string que,
            string lop,
            string khoa,
            double diem,
            double hocPhi
            )
        {
            try
            {
                string query =
                    "update SV " +
                    "set hoten=@hoTen,ngaysinh=@ngaySinh,gioitinh=@gioiTinh,que=@que,lop=@lop,khoa=@khoa,diem=@diem,hocphi=@hocPhi " +
                    "where msv=@msv";
                SqlCommand cmd = new SqlCommand(query, connection);

                if (!string.IsNullOrEmpty(msv))
                {
                    bool isMsvExit = isExit(msv);
                    if (isMsvExit)
                    {
                        cmd.Parameters.AddWithValue("@msv", msv);
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
                    !string.IsNullOrEmpty(hoTen) ? hoTen : (object)DBNull.Value;

                cmd.Parameters.Add(new SqlParameter("@ngaySinh", SqlDbType.Date)).Value =
                 !string.IsNullOrEmpty(ngaySinh) ? ngaySinh : (object)DBNull.Value;

                cmd.Parameters.Add(new SqlParameter("@gioiTinh", SqlDbType.NVarChar)).Value = gioiTinh;

                cmd.Parameters.Add(new SqlParameter("@que", SqlDbType.NVarChar)).Value =
                    !string.IsNullOrEmpty(que) ? que : (object)DBNull.Value;

                cmd.Parameters.Add(new SqlParameter("@lop", SqlDbType.VarChar)).Value =
                    !string.IsNullOrEmpty(lop) ? lop : (object)DBNull.Value;

                cmd.Parameters.Add(new SqlParameter("@khoa", SqlDbType.VarChar)).Value =
                    !string.IsNullOrEmpty(khoa) ? khoa : (object)DBNull.Value;

                cmd.Parameters.AddWithValue("@diem", diem);
                cmd.Parameters.AddWithValue("@hocPhi", hocPhi);

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
    }
}