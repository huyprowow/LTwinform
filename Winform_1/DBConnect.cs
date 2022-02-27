using MySql.Data.MySqlClient;//add mysql library
using System.Collections.Generic;
using System.Windows.Forms;

namespace Winform_1.Connection_DB
{
    internal class DBConnect
    {
        private MySqlConnection connection;//mo ket noi den csdl
        private string server;//cho biet may chu dc luu o dau (localhost)
        private string database;//ten csdl dung (cai ban nay vua tao)
        private string uid;// mat khau mysql
        private string password;//mk mysql

        //ham tao
        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "game1";
            uid = "root";
            password = "shinigami";
            string connectionString;//chuoi ket noi voi csdl gan cho bien "connection"
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        //mo ket noi trc khi truy van
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //khi xu lis loi nos tra ve cac ma loi
                switch (ex.Number)
                {
                    case 0://loi ket noi server
                        MessageBox.Show("k the ket noi den server");
                        break;

                    case 1045://sai tk mk
                        MessageBox.Show("username/password sai, thu lai sau");
                        break;
                }
                return false;
            }
        }

        //dong ket noi dong sau khi hoan thanh truy van de giai phong tai nguyen
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /**
         * Thông thường Insert, update và delete được  sử dụng để ghi hoặc thay đổi dữ liệu trong cơ sở dữ liệu, trong khi Select được sử dụng để đọc dữ liệu.
         * Vì lý do này, chúng tôi có các loại phương thức khác nhau để thực hiện các truy vấn đó.
         * Các phương pháp như sau:
            * ExecuteNonQuery: Được sử dụng để thực hiện một lệnh sẽ không trả về bất kỳ dữ liệu nào, ví dụ Insert: update hoặc delete.
            * ExecuteReader: Được sử dụng để thực hiện một lệnh sẽ trả về 0 hoặc nhiều bản ghi chẳng hạn Select.
            * ExecuteScalar: Được sử dụng để thực hiện một lệnh sẽ chỉ trả về 1 giá trị chẳng hạn Select Count(*).
         */

        /**
         * Mở kết nối với cơ sở dữ liệu.
         * Tạo một lệnh MySQL.
         * Gán kết nối và truy vấn cho lệnh.
-Thực hiện bằng cách sử dụng hàm tạo hoặc Connection và các phương thức CommandText trong lớp MySqlCommand
         * Thực hiện lệnh.
         * Đóng kết nối
         */

        // chen
        private void Insert()
        {
            string query = "INSERT INTO Player (ten,diem) VALUES('test1',10)";
            if (this.OpenConnection())
            {
                //tao query
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();//chay query k tra ve
                this.CloseConnection();//dong ket noi
            }
        }

        // update
        private void Update()
        {
            string query = "Update Player SET ten='Huy dep trai', age='20' WHERE ten='test1'";
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();//tao query
                cmd.CommandText = query;//gan query
                cmd.Connection = this.connection;//gan ket noi
                cmd.ExecuteNonQuery();//chay query
                this.CloseConnection();//dong kn
            }
        }

        //xoa
        private void Delete()
        {
            string query = "DELETE FROM Player WHERE name='Huy dep trai'";
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                this.CloseConnection();
            }
        }

        /**
         * Mở kết nối với cơ sở dữ liệu.
         * Tạo một lệnh MySQL.
         * Gán kết nối và truy vấn cho lệnh. Điều này có thể được thực hiện bằng cách sử dụng hàm tạo hoặc sử dụng Connection và các CommandText phương thức trong MySqlCommand lớp.
         * Tạo một MySqlDataReader đối tượng để đọc các bản ghi / dữ liệu đã chọn.
         * Thực hiện lệnh.
         * Đọc các bản ghi và hiển thị chúng hoặc lưu trữ chúng trong một danh sách.
         * Đóng trình đọc dữ liệu.
         * Đóng kết nối.
         */

        //select
        public List<string>[] Select()
        {
            string query = "SELECT * FROM Player";
            //tao danh sach de luu kq
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[3] = new List<string>();

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //tao bien dataReader de doc du lieu tu kq tra ve sau khi chay truy van
                MySqlDataReader dataReader = cmd.ExecuteReader();//truy van co tra ve dl
                //doc dl, luu vao dand sach
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["player_id"] + "");
                    list[1].Add(dataReader["ten"] + "");
                    list[3].Add(dataReader["diem"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }

        /**
         * Mở kết nối với cơ sở dữ liệu.
         * Tạo một lệnh MySQL.
         * Gán kết nối và truy vấn cho lệnh. Điều này có thể được thực hiện bằng cách sử dụng hàm tạo hoặc sử dụng Connection và các CommandText phương thức trong MySqlCommand lớp.
         * Thực hiện lệnh.
         * Phân tích kết quả nếu cần thiết.
         * Đóng kết nối.
        */

        //dem
        public int Count()
        {
            string query = "SELECT Count(*) FROM Player";
            int Count = -1;
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");//trave 1 gia tri
                this.CloseConnection();
                return Count;
            }
            else
            {
                return Count;
            }
        }

        /*
        //backup
        public void Backup()
        {
            //trong mysql de backup viet:
            //mysqldump -u username -p password -h localhost game1 > "E:\Backup.sql"
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //luu file vao o E:\ voi thoi gian hien tai la ten file
                string path;
                path = "E:\\MySqlBackup" + year + "-" + month + "-" + day +
            "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }

        //phuc hoi
        public void Restore()
        {
            //restore mysql
            //mysql -u username -p password -h localhost game1 < "E:\Backup.sql"
            try
            {
                //doc file tu E:\
                string path;
                path = "E:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }
        */
    }
}