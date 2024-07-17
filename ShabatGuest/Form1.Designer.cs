namespace ShabatGuest
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnEnterGuestName = new System.Windows.Forms.Button();
            this.lstGuestsName = new System.Windows.Forms.ListBox();
            this.btnAddGuset = new System.Windows.Forms.Button();
            this.btnDeleteGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(254, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "בורכים הבאים";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(271, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "הכנס שם אורח";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(198, 242);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(358, 38);
            this.txtGuestName.TabIndex = 2;
            this.txtGuestName.TextChanged += new System.EventHandler(this.txtGuestName_TextChanged);
            // 
            // btnEnterGuestName
            // 
            this.btnEnterGuestName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEnterGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEnterGuestName.Location = new System.Drawing.Point(236, 792);
            this.btnEnterGuestName.Name = "btnEnterGuestName";
            this.btnEnterGuestName.Size = new System.Drawing.Size(242, 75);
            this.btnEnterGuestName.TabIndex = 3;
            this.btnEnterGuestName.Text = "אישור";
            this.btnEnterGuestName.UseVisualStyleBackColor = false;
            this.btnEnterGuestName.Click += new System.EventHandler(this.btnEnterGuestName_Click);
            // 
            // lstGuestsName
            // 
            this.lstGuestsName.FormattingEnabled = true;
            this.lstGuestsName.ItemHeight = 31;
            this.lstGuestsName.Location = new System.Drawing.Point(221, 474);
            this.lstGuestsName.Name = "lstGuestsName";
            this.lstGuestsName.Size = new System.Drawing.Size(294, 283);
            this.lstGuestsName.TabIndex = 4;
            // 
            // btnAddGuset
            // 
            this.btnAddGuset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddGuset.Location = new System.Drawing.Point(165, 316);
            this.btnAddGuset.Name = "btnAddGuset";
            this.btnAddGuset.Size = new System.Drawing.Size(169, 111);
            this.btnAddGuset.TabIndex = 5;
            this.btnAddGuset.Text = "הוסף אורח חדש";
            this.btnAddGuset.UseVisualStyleBackColor = true;
            this.btnAddGuset.Click += new System.EventHandler(this.btnAddGuset_Click);
            // 
            // btnDeleteGuest
            // 
            this.btnDeleteGuest.Location = new System.Drawing.Point(436, 316);
            this.btnDeleteGuest.Name = "btnDeleteGuest";
            this.btnDeleteGuest.Size = new System.Drawing.Size(131, 111);
            this.btnDeleteGuest.TabIndex = 7;
            this.btnDeleteGuest.Text = "מחק אורח";
            this.btnDeleteGuest.UseVisualStyleBackColor = true;
            this.btnDeleteGuest.Click += new System.EventHandler(this.btnDeleteGuest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 919);
            this.Controls.Add(this.btnDeleteGuest);
            this.Controls.Add(this.btnAddGuset);
            this.Controls.Add(this.lstGuestsName);
            this.Controls.Add(this.btnEnterGuestName);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnEnterGuestName;
        private System.Windows.Forms.ListBox lstGuestsName;
        private System.Windows.Forms.Button btnAddGuset;
        private System.Windows.Forms.Button btnDeleteGuest;
    }
}

