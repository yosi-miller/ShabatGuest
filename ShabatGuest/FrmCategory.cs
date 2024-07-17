using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ShabatGuest
{
    public partial class FrmCategory : Form
    {
        // מאפיין לשמירת המופע של הטופס האבא
        Form1 ParentInstance;
        // אינדקס קטגוריה נוכחית
        int Index;
        public FrmCategory(Form1 _parentInstance, string _categoryName, string _guestName, int _index)
        {
            // הפונקציה הזאת מתרחשת מתי שהטופס נטען
            InitializeComponent();
            lalGuestName.Text = _guestName;
            lblCategoryName.Text = _categoryName;
            ParentInstance = _parentInstance;

            Index = _index;
            
            Console.WriteLine(ParentInstance.categoriesList.Count() + " " + Index);
            //dgvAllChoices.DataSource = selectAllFoodByCategory(_categoryName);
            //dgvGuestChoices.DataSource = selectAllFoodByGuest(_categoryName, _guestName);
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Index.ToString());
            if (Index == ParentInstance.categoriesList.Count - 1)
                btnNext.Enabled = false;
            if (Index == 0)
                btnBack.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvGuestChoices.DataSource = "db";
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            // enable to desply add food area
            pAddFood.Enabled = true;
            btnAddFood.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // משנה את מצב הכפתור הוספת מאכל ואת מצב הפנאל הוספת מאכל
            btnAddFood.Enabled = true;
            pAddFood.Enabled = false;

            // טיפול שמירת המאכל שנוסף
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Index < ParentInstance.categoriesList.Count() - 1)
            {
                ParentInstance.categoriesList[Index + 1].Visible = true;
                Visible = false;
                Console.WriteLine(ParentInstance.categoriesList[Index] + "next" + Index);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Index > 0)
            {
                ParentInstance.categoriesList[Index - 1].Visible = true;
                Visible = false;
            }
        }

        private DataTable selectAllFoodByCategory(string category)
        {
            DataTable result = new DataTable();
            string query = @"SELECT dishes.dishes_name AS 'שם', COUNT(dishes.dishes_name) AS 'כמות'
                                FROM dishes
                                INNER JOIN category
                                ON dishes.category_id = category.id
                                WHERE category.category_name = @category
                                GROUP BY dishes.dishes_name";
            if (ParentInstance.connectDb())
            {
                SqlCommand cmd = new SqlCommand(query, ParentInstance.connection);
                cmd.Parameters.AddWithValue("@category", category);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(result);
                ParentInstance.disConnectDb();
            }
            return result;
        }

        private DataTable selectAllFoodByGuest(string categoryName, string guestName)
        {
            DataTable result = new DataTable();
            string qurey = @"SELECT dishes.dishes_name AS 'הבחירה שלך'
                                    FROM dishes
                                    INNER JOIN guest
                                    ON dishes.guest_id =  guest.id
                                    INNER JOIN category
                                    ON dishes.category_id =  category.id
                                    WHERE guest.guest_name = @guestName 
                                    AND category.category_name = @categoryName";
           
            if (ParentInstance.connectDb())
            {
                SqlCommand cmd = new SqlCommand(qurey, ParentInstance.connection);
                cmd.Parameters.AddWithValue("@categoryName", categoryName);
                cmd.Parameters.AddWithValue("@guestName", guestName);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(result);
                ParentInstance.disConnectDb();
            }
            return result;
        }
    }
}