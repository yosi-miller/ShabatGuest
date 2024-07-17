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
            selectAllFoodByCategory(lblCategoryName.Text);
            selectAllFoodByGuest(lblCategoryName.Text, lalGuestName.Text);
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            if (Index == ParentInstance.categoriesList.Count - 1)
                btnNext.Enabled = false;
            if (Index == 0)
                btnBack.Enabled = false;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            // enable to desply add food area
            pAddFood.Enabled = true;
            btnAddFood.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            // טיפול שמירת המאכל שנוסף
            if (string.IsNullOrEmpty(txtAddFood.Text))
                return;
            insertNewFood(txtAddFood.Text);
        }

        private void insertNewFood(string food)
        {
            string query = @"IF NOT EXISTS (SELECT dishes.dishes_name
                                FROM dishes
                                INNER JOIN guest
                                ON dishes.guest_id =  guest.id
                                INNER JOIN category
                                ON dishes.category_id =  category.id
                                WHERE guest.guest_name = @currentGuest 
                                AND category.category_name = @currentCategory
                                AND dishes.dishes_name = @currentFood
                                )
                                BEGIN
                                    INSERT INTO dishes (dishes_name, guest_id, category_id)
                                    VALUES (@currentFood,
                                            (SELECT id FROM guest WHERE guest_name = @currentGuest),
                                            (SELECT id FROM category WHERE category_name = @currentCategory))
                                END";

            if (ParentInstance.connectDb())
            {
                SqlCommand cmd = new SqlCommand(query, ParentInstance.connection);
                cmd.Parameters.AddWithValue("@currentGuest", lalGuestName.Text);
                cmd.Parameters.AddWithValue("@currentCategory", lblCategoryName.Text);
                cmd.Parameters.AddWithValue("@currentFood", food);
                int updateRows = cmd.ExecuteNonQuery();
                if (updateRows == -1)
                {
                    MessageBox.Show("בחרת כבר את זה, בחר מאכל אחר");
                    return;
                }
                ParentInstance.disConnectDb();
            }
            
            // after the addition the new food import agine the food and food of category
            selectAllFoodByCategory(lblCategoryName.Text);
            selectAllFoodByGuest(lblCategoryName.Text, lalGuestName.Text);

            // מנקה את הטקסט שהוזן בתיבת אינפוט
            txtAddFood.Text = "";
            // משנה את מצב הכפתור הוספת מאכל ואת מצב הפנאל הוספת מאכל
            btnAddFood.Enabled = true;
            pAddFood.Enabled = false;
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

        private void selectAllFoodByCategory(string category)
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
            dgvAllChoices.DataSource = result;
        }

        private void selectAllFoodByGuest(string categoryName, string guestName)
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
            dgvGuestChoices.DataSource = result;
        }
    }
}