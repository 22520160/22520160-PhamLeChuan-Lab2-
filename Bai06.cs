using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;
using System.IO;

namespace Lab02
{
    public partial class Bai06 : Form
    {
        string tableMenu = "CREATE TABLE IF NOT EXISTS MENU (IDMA INTEGER PRIMARY KEY AUTOINCREMENT, TenMonAn TEXT, HinhAnh TEXT, IDNCC INTEGER, FOREIGN KEY(IDNCC) REFERENCES NguoiDung(IDNCC));";
        private SQLiteConnection conn;
        string[] menu;

        public Bai06()
        {
            InitializeComponent();

            conn = new SQLiteConnection("Data Source=Menu.db");
            conn.Open();

            string tableMenu = "CREATE TABLE IF NOT EXISTS MENU (IDMA INTEGER PRIMARY KEY, TenMonAn TEXT, HinhAnh TEXT, IDNCC INTERGER, FOREIGN KEY(IDNCC) REFERENCES NguoiDung(IDNCC));";
            SQLiteCommand tablecmd = new SQLiteCommand(tableMenu, conn);
            tablecmd.ExecuteNonQuery();

            AddDish(1, "Phở", "Pho.jpg", 101);
            AddDish(2, "Mì Quảng", "MiQuang.jpg", 102);
            AddDish(3, "Bò Kho", "BoKho.jpg", 103);
            AddDish(4, "Bánh Cuốn Nóng", "BanhCuonNong.jpg", 104);
            AddDish(5, "Bánh Canh", "BanhCanh.jpg", 105);

            string tableCustomer = "CREATE TABLE IF NOT EXISTS CUSTOMER (IDNCC INTEGER PRIMARY KEY, HoVaTen TEXT, QuyenHan TEXT);";
            SQLiteCommand tablecmd2 = new SQLiteCommand(tableCustomer, conn);
            tablecmd2.ExecuteNonQuery();

            AddCus(101, "Nguyen Van A", "Ban hang");
            AddCus(102, "Nguyen Van B", "Ban hang");
            AddCus(103, "Nguyen Van C", "Ban hang");
            AddCus(104, "Nguyen Van D", "Ban hang");
            AddCus(105, "Nguyen Van E", "Ban hang");

            menu = GetMenu(conn);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            tbDish.Clear();
            pbDish.Hide();
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string[] GetMenu(SQLiteConnection conn)
        {
            string q = "SELECT TenMonAn FROM MENU;";
            SQLiteCommand cmd = new SQLiteCommand(q, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();

            var menuList = new List<string>();
            while (reader.Read())
            {
                string tenMonAn = reader["TenMonAn"].ToString();
                menuList.Add(tenMonAn);
            }
            reader.Close();
            return menuList.ToArray();
        }

        private void AddDish(int idMA, string tenMonAn, string hinhAnh, int idNCC)
        {
            string query = "INSERT INTO MENU (IDMA, TenMonAn, HinhAnh, IDNCC) VALUES (@IDMA, @TenMonAn, @HinhAnh, @IDNCC);";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@IDMA", idMA);
            cmd.Parameters.AddWithValue("@TenMonAn", tenMonAn);
            cmd.Parameters.AddWithValue("@HinhAnh", hinhAnh);
            cmd.Parameters.AddWithValue("@IDNCC", idNCC);
            cmd.ExecuteNonQuery();
        }

        private void AddCus(int idNCC, string hovaten, string quyenhan)
        {
            string query = "INSERT INTO CUSTOMER (IDNCC, HoVaTen, QuyenHan) VALUES (@IDNCC, @HoVaTen, @QuyenHan);";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@IDNCC", idNCC);
            cmd.Parameters.AddWithValue("@HoVaTen", hovaten);
            cmd.Parameters.AddWithValue("@QuyenHan", quyenhan);
            cmd.ExecuteNonQuery();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            foreach (string s in menu)
            {
                lvMenu.Items.Add(s);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            int listDish = menu.Length;

            Random random = new Random();
            int randomIndex = random.Next(listDish);
            string selectedDish = menu[randomIndex];

            string query = "SELECT TenMonAn, HinhAnh, HoVaTen FROM MENU JOIN CUSTOMER ON MENU.IDNCC + CUSTOMER.IDNCC WHERE TenMonAn = @TenMonAn;";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@TenMonAn", selectedDish);
            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string ten = reader["TenMonAn"].ToString();
                string hinh = reader["HinhAnh"].ToString();
                string hovaten = reader["HoVaTen"].ToString();

                pbDish.Image = Image.FromFile(hinh);
                tbDish.Text = "Món Ăn: " + ten + "\r\n " + " Người cung cấp: " + hovaten;
            }

            reader.Close();
            pbDish.Show();
        }
        
        
        private void lvMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}