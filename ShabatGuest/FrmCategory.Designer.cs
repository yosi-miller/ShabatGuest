namespace ShabatGuest
{
    partial class FrmCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lalGuestName = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.txtAddFood = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dgvAllChoices = new System.Windows.Forms.DataGridView();
            this.dgvGuestChoices = new System.Windows.Forms.DataGridView();
            this.pAddFood = new System.Windows.Forms.Panel();
            this.lblCategoryName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllChoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestChoices)).BeginInit();
            this.pAddFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // lalGuestName
            // 
            this.lalGuestName.AutoSize = true;
            this.lalGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lalGuestName.Location = new System.Drawing.Point(717, 22);
            this.lalGuestName.Name = "lalGuestName";
            this.lalGuestName.Size = new System.Drawing.Size(161, 46);
            this.lalGuestName.TabIndex = 0;
            this.lalGuestName.Text = "שם אורח";
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddFood.Location = new System.Drawing.Point(747, 400);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(275, 80);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "הוספת מאכל";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // txtAddFood
            // 
            this.txtAddFood.Location = new System.Drawing.Point(309, 40);
            this.txtAddFood.Name = "txtAddFood";
            this.txtAddFood.Size = new System.Drawing.Size(200, 38);
            this.txtAddFood.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOk.Location = new System.Drawing.Point(12, 17);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(275, 80);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "אישור";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.Location = new System.Drawing.Point(686, 914);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(263, 68);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = ">>>";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNext.Location = new System.Drawing.Point(202, 914);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(263, 68);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "<<<";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dgvAllChoices
            // 
            this.dgvAllChoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllChoices.Location = new System.Drawing.Point(106, 86);
            this.dgvAllChoices.Name = "dgvAllChoices";
            this.dgvAllChoices.RowHeadersWidth = 102;
            this.dgvAllChoices.RowTemplate.Height = 40;
            this.dgvAllChoices.Size = new System.Drawing.Size(964, 287);
            this.dgvAllChoices.TabIndex = 6;
            this.dgvAllChoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvGuestChoices
            // 
            this.dgvGuestChoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestChoices.Location = new System.Drawing.Point(106, 515);
            this.dgvGuestChoices.Name = "dgvGuestChoices";
            this.dgvGuestChoices.RowHeadersWidth = 102;
            this.dgvGuestChoices.RowTemplate.Height = 40;
            this.dgvGuestChoices.Size = new System.Drawing.Size(964, 366);
            this.dgvGuestChoices.TabIndex = 7;
            // 
            // pAddFood
            // 
            this.pAddFood.Controls.Add(this.btnOk);
            this.pAddFood.Controls.Add(this.txtAddFood);
            this.pAddFood.Enabled = false;
            this.pAddFood.Location = new System.Drawing.Point(145, 379);
            this.pAddFood.Name = "pAddFood";
            this.pAddFood.Size = new System.Drawing.Size(527, 117);
            this.pAddFood.TabIndex = 8;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCategoryName.Location = new System.Drawing.Point(249, 22);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(209, 46);
            this.lblCategoryName.TabIndex = 9;
            this.lblCategoryName.Text = "שם קטגוריה";
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 1038);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.pAddFood);
            this.Controls.Add(this.dgvGuestChoices);
            this.Controls.Add(this.dgvAllChoices);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.lalGuestName);
            this.Name = "FrmCategory";
            this.Text = "FrmCategory";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllChoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestChoices)).EndInit();
            this.pAddFood.ResumeLayout(false);
            this.pAddFood.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalGuestName;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.TextBox txtAddFood;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dgvAllChoices;
        private System.Windows.Forms.DataGridView dgvGuestChoices;
        private System.Windows.Forms.Panel pAddFood;
        private System.Windows.Forms.Label lblCategoryName;
    }
}