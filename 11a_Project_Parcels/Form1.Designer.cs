
namespace _11a_Project_Parcels
{
    partial class FormParcel
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
            this.lbl_Head = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_PackageName = new System.Windows.Forms.Label();
            this.txt_PackageName = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.txt_Weight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.Location = new System.Drawing.Point(530, 41);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(248, 29);
            this.lbl_Head.TabIndex = 2;
            this.lbl_Head.Text = "\"Parcel\" Mail Services";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(158, 147);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(42, 29);
            this.lbl_ID.TabIndex = 3;
            this.lbl_ID.Text = "ID:";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(218, 141);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(179, 35);
            this.txt_ID.TabIndex = 8;
            // 
            // lbl_PackageName
            // 
            this.lbl_PackageName.AutoSize = true;
            this.lbl_PackageName.Location = new System.Drawing.Point(21, 202);
            this.lbl_PackageName.Name = "lbl_PackageName";
            this.lbl_PackageName.Size = new System.Drawing.Size(179, 29);
            this.lbl_PackageName.TabIndex = 9;
            this.lbl_PackageName.Text = "Package name:";
            // 
            // txt_PackageName
            // 
            this.txt_PackageName.Location = new System.Drawing.Point(218, 202);
            this.txt_PackageName.Name = "txt_PackageName";
            this.txt_PackageName.Size = new System.Drawing.Size(179, 35);
            this.txt_PackageName.TabIndex = 10;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(59, 254);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(141, 29);
            this.lbl_description.TabIndex = 11;
            this.lbl_description.Text = "Description:";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(218, 254);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(179, 35);
            this.txt_Description.TabIndex = 12;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(125, 319);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(75, 29);
            this.lbl_Price.TabIndex = 13;
            this.lbl_Price.Text = "Price:";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(218, 319);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(179, 35);
            this.txt_Price.TabIndex = 14;
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.Location = new System.Drawing.Point(106, 371);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(94, 29);
            this.lbl_Weight.TabIndex = 15;
            this.lbl_Weight.Text = "Weight:";
            // 
            // txt_Weight
            // 
            this.txt_Weight.Location = new System.Drawing.Point(218, 371);
            this.txt_Weight.Name = "txt_Weight";
            this.txt_Weight.Size = new System.Drawing.Size(179, 35);
            this.txt_Weight.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Package Size:";
            // 
            // cb_Type
            // 
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cb_Type.Location = new System.Drawing.Point(278, 471);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(218, 37);
            this.cb_Type.TabIndex = 18;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(130, 589);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(124, 58);
            this.btn_Add.TabIndex = 19;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(301, 589);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(124, 58);
            this.btn_Update.TabIndex = 20;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(466, 589);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(124, 58);
            this.btn_Delete.TabIndex = 21;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(782, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(733, 510);
            this.dataGridView1.TabIndex = 22;
            // 
            // FormParcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 1083);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cb_Type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Weight);
            this.Controls.Add(this.lbl_Weight);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.txt_PackageName);
            this.Controls.Add(this.lbl_PackageName);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Head);
            this.Name = "FormParcel";
            this.Text = "\"Parcel\" Mail Services";
            this.Load += new System.EventHandler(this.FormParcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_PackageName;
        private System.Windows.Forms.TextBox txt_PackageName;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.TextBox txt_Weight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

