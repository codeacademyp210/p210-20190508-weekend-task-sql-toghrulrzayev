namespace Register
{
    partial class Products
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
            this.Panel = new System.Windows.Forms.Panel();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.ComboBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.Ad = new System.Windows.Forms.TextBox();
            this.Stock = new System.Windows.Forms.TextBox();
            this.Barcode = new System.Windows.Forms.TextBox();
            this.Color = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.LightGray;
            this.Panel.Controls.Add(this.GridView);
            this.Panel.Controls.Add(this.Brand);
            this.Panel.Controls.Add(this.Category);
            this.Panel.Controls.Add(this.Save_button);
            this.Panel.Controls.Add(this.Ad);
            this.Panel.Controls.Add(this.Stock);
            this.Panel.Controls.Add(this.Barcode);
            this.Panel.Controls.Add(this.Color);
            this.Panel.Controls.Add(this.Price);
            this.Panel.Controls.Add(this.Name);
            this.Panel.Controls.Add(this.label8);
            this.Panel.Controls.Add(this.label7);
            this.Panel.Controls.Add(this.label6);
            this.Panel.Controls.Add(this.label5);
            this.Panel.Controls.Add(this.label4);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.label1);
            this.Panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Panel.Location = new System.Drawing.Point(5, 3);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(794, 444);
            this.Panel.TabIndex = 1;
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.GridView.Location = new System.Drawing.Point(275, 20);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(516, 421);
            this.GridView.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Brand";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Color";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Barcode";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Stock";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ad";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.FormattingEnabled = true;
            this.Brand.Items.AddRange(new object[] {
            "Temiz meyve shireleri",
            "Chipsim",
            "Pull Bear",
            "5+ Avto saloon"});
            this.Brand.Location = new System.Drawing.Point(102, 148);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(121, 21);
            this.Brand.TabIndex = 17;
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "Lays",
            "Sok",
            "T-shirt",
            "Masin"});
            this.Category.Location = new System.Drawing.Point(102, 99);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(121, 21);
            this.Category.TabIndex = 16;
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.DarkGray;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save_button.Location = new System.Drawing.Point(115, 391);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(87, 28);
            this.Save_button.TabIndex = 15;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(102, 334);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(121, 20);
            this.Ad.TabIndex = 14;
            this.Ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ad_KeyPress);
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(102, 284);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(121, 20);
            this.Stock.TabIndex = 13;
            this.Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Stock_KeyPress);
            // 
            // Barcode
            // 
            this.Barcode.Location = new System.Drawing.Point(102, 240);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(121, 20);
            this.Barcode.TabIndex = 12;
            this.Barcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Barcode_KeyPress);
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(102, 195);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(121, 20);
            this.Color.TabIndex = 11;
            this.Color.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Color_KeyPress);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(102, 53);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(121, 20);
            this.Price.TabIndex = 10;
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(102, 20);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(121, 20);
            this.Name.TabIndex = 9;
            this.Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Barcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel);
           
            this.Text = "Form3";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.TextBox Stock;
        private System.Windows.Forms.TextBox Barcode;
        private System.Windows.Forms.TextBox Color;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.ComboBox Brand;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}