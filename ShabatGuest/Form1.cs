using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace ShabatGuest
{
    public partial class Form1 : Form
    {
        // מגדיר מתשנה שכיל את הערך שחוזר בעת חיבור לדאטה בייס
        public SqlConnection connection;

        // מגדיר את נתיב החיבור לשרת SQL
        public readonly string connectionString = "server=YOSEF-MILLER\\SQLEXPRESS; initial catalog=shabat; user id=sa; password=1234; TrustServerCertificate=Yes";

        // מגדיר מערך קבוע - צריך להגדיר גודל ולא ניתן להוסיף
        public FrmCategory[] categories;

        // מגדיר מערך דינמי - המערך מתארך לפי הצורך
        public List<FrmCategory> categoriesList = new List<FrmCategory>();

        public Form1()
        {
            InitializeComponent();
            // מייבא בעת הרצת הקובץ את רשימת האורחים
            showAllGuest();
        }
        public bool connectDb()
        {
            try
            {
                // create a connection to DB
                connection = new SqlConnection(connectionString);

                // open the connection
                connection.Open();
                Console.WriteLine("החיבור הצליח");

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // disconnect to DB
        public void disConnectDb()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void showAllGuest(string name = "")
        {
            // like to fillter the name by defualt return all name becuas that select % filter operator
            string query = @"SELECT guest_name FROM guest WHERE guest_name LIKE '%' + @name + '%'";

            if (connectDb())
            {
                // create command var
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);

                // make the query and read the result
                SqlDataReader reader = cmd.ExecuteReader();

                // מנקה את כל הנתונים שיש בתיבה שמציגה את כל הקטגוריות של האוכל
                lstGuestsName.Items.Clear();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lstGuestsName.Items.Add(reader[0].ToString());
                    }
                }
                disConnectDb();
            }
        }

        private void btnAddGuset_Click(object sender, EventArgs e)
        {
            // בודק שהאורח הכניס שם 
            if (txtGuestName.Text == "")
            {
                MessageBox.Show("הכנס שם אורח");
                return;
            }

            // שאילתה הוספת אורח חדשה ותבדוק שהיא כבר לא קיימת
            string query = @"IF (@guest_name != '')
                                    BEGIN
                                        IF NOT EXISTS(SELECT guest_name FROM guest WHERE guest_name = @guest_name)
                                            BEGIN
                                                INSERT INTO
                                                    guest (guest_name)
                                                    VALUES (@guest_name)
                                            END
                                    END";
            if (connectDb())
            {
                // create command var
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@guest_name", txtGuestName.Text);

                // make the query and return the number of effect row
                int updateRows = cmd.ExecuteNonQuery();
                
                if (updateRows == -1)
                {
                    MessageBox.Show("השם קיים נא הכנס שם חדש");
                    txtGuestName.Text = "";
                    return;
                }
            }
            showAllGuest();
            txtGuestName.Text = "";
            disConnectDb();
        }

        private void txtGuestName_TextChanged(object sender, EventArgs e)
        {
            // מטרת הפונקציה לבצע סינון על השמות המוצגים שמתי שמתחילים להקיש שם יסנן את השמות שמתאמים לזה 
            showAllGuest(txtGuestName.Text);
        }

        private void btnEnterGuestName_Click(object sender, EventArgs e)
        {
            if (lstGuestsName.SelectedIndex >= 0)
            {
                string guestName = lstGuestsName.SelectedItem.ToString();
                showAllCategories(guestName);
                return;
            }
            MessageBox.Show("נא בחר שם אורח");
            return;
        }

        // פונקציה שתעביר את המשתמש למסך בחירת מאכלים לפי קטגוריה
        private void showAllCategories(string userName)
        {
            string query = @"SELECT category_name FROM category";

            if (connectDb())
            {
                // create command var
                SqlCommand cmd = new SqlCommand(query, connection);

                // make the query and read the result
                SqlDataReader reader = cmd.ExecuteReader();

                int index = 0;

                if (reader.HasRows)
                {
                    categoriesList.Clear();
                    while (reader.Read())
                    {
                        string categoryName = reader[0].ToString();
                        Form1 formInstance = this;
                        categoriesList.Add(new FrmCategory(formInstance, categoryName, userName, index++));
                    }
                    categoriesList.First().Show();
                }
                disConnectDb();
            }
        }

        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            // this function to be delete guest from database
            if (lstGuestsName.SelectedIndex > 1)
            {
                string guestName = lstGuestsName.SelectedItem.ToString();
                MessageBox.Show("האורח נמחק בההצלחה");
                showAllGuest();
                return;
            }
            MessageBox.Show("נא בחר שם אורח");
            return;
        }

    }
}
