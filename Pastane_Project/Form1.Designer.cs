namespace Pastane_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnMalzemeEkle = new Button();
            label5 = new Label();
            txtMaterialNotes = new TextBox();
            label4 = new Label();
            txtMaterialPrice = new TextBox();
            label3 = new Label();
            txtMaterialStock = new TextBox();
            label2 = new Label();
            txtMaterialName = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            btnUrunEkle = new Button();
            label8 = new Label();
            txtProductBPrice = new TextBox();
            label9 = new Label();
            txtProductName = new TextBox();
            groupBox4 = new GroupBox();
            cmbMaterial = new ComboBox();
            cmbProduct = new ComboBox();
            btnEkle = new Button();
            label12 = new Label();
            txtCost = new TextBox();
            label13 = new Label();
            txtAmount = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMalzemeEkle);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMaterialNotes);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaterialPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaterialStock);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaterialName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 213);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Malzeme Girişi";
            // 
            // btnMalzemeEkle
            // 
            btnMalzemeEkle.Location = new Point(91, 171);
            btnMalzemeEkle.Name = "btnMalzemeEkle";
            btnMalzemeEkle.Size = new Size(138, 30);
            btnMalzemeEkle.TabIndex = 1;
            btnMalzemeEkle.Text = "Malzeme Ekle";
            btnMalzemeEkle.UseVisualStyleBackColor = true;
            btnMalzemeEkle.Click += btnMalzemeEkle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 139);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 9;
            label5.Text = "NOTLAR: ";
            // 
            // txtMaterialNotes
            // 
            txtMaterialNotes.Location = new Point(91, 136);
            txtMaterialNotes.Name = "txtMaterialNotes";
            txtMaterialNotes.Size = new Size(138, 29);
            txtMaterialNotes.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 104);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 7;
            label4.Text = "FİYAT: ";
            // 
            // txtMaterialPrice
            // 
            txtMaterialPrice.Location = new Point(91, 101);
            txtMaterialPrice.Name = "txtMaterialPrice";
            txtMaterialPrice.Size = new Size(138, 29);
            txtMaterialPrice.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 69);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 5;
            label3.Text = "STOK: ";
            // 
            // txtMaterialStock
            // 
            txtMaterialStock.Location = new Point(91, 66);
            txtMaterialStock.Name = "txtMaterialStock";
            txtMaterialStock.Size = new Size(138, 29);
            txtMaterialStock.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 34);
            label2.Name = "label2";
            label2.Size = new Size(38, 21);
            label2.TabIndex = 3;
            label2.Text = "AD: ";
            // 
            // txtMaterialName
            // 
            txtMaterialName.Location = new Point(91, 31);
            txtMaterialName.MaxLength = 30;
            txtMaterialName.Name = "txtMaterialName";
            txtMaterialName.Size = new Size(138, 29);
            txtMaterialName.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 231);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(730, 232);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Malzemeler";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(724, 204);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(btnUrunEkle);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtProductBPrice);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtProductName);
            groupBox3.Location = new Point(253, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(235, 213);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ürün Girişi";
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(91, 63);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(138, 30);
            btnUrunEkle.TabIndex = 1;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 117);
            label8.Name = "label8";
            label8.Size = new Size(130, 21);
            label8.TabIndex = 5;
            label8.Text = "ÜRÜN MALİYETİ: ";
            // 
            // txtProductBPrice
            // 
            txtProductBPrice.Enabled = false;
            txtProductBPrice.Location = new Point(142, 114);
            txtProductBPrice.Name = "txtProductBPrice";
            txtProductBPrice.Size = new Size(87, 29);
            txtProductBPrice.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(47, 31);
            label9.Name = "label9";
            label9.Size = new Size(38, 21);
            label9.TabIndex = 3;
            label9.Text = "AD: ";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(91, 28);
            txtProductName.MaxLength = 30;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(138, 29);
            txtProductName.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cmbMaterial);
            groupBox4.Controls.Add(cmbProduct);
            groupBox4.Controls.Add(btnEkle);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(txtCost);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(txtAmount);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label15);
            groupBox4.Location = new Point(494, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(248, 213);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ürün Oluştur";
            // 
            // cmbMaterial
            // 
            cmbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterial.FormattingEnabled = true;
            cmbMaterial.Location = new Point(100, 63);
            cmbMaterial.Name = "cmbMaterial";
            cmbMaterial.Size = new Size(138, 29);
            cmbMaterial.TabIndex = 9;
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(100, 28);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(138, 29);
            cmbProduct.TabIndex = 8;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(100, 168);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(138, 30);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 136);
            label12.Name = "label12";
            label12.Size = new Size(78, 21);
            label12.TabIndex = 7;
            label12.Text = "MALİYET: ";
            // 
            // txtCost
            // 
            txtCost.Enabled = false;
            txtCost.Location = new Point(100, 133);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(138, 29);
            txtCost.TabIndex = 6;
            txtCost.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 101);
            label13.Name = "label13";
            label13.Size = new Size(71, 21);
            label13.TabIndex = 5;
            label13.Text = "MİKTAR: ";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(100, 98);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(138, 29);
            txtAmount.TabIndex = 4;
            txtAmount.Text = "0";
            txtAmount.Click += txtAmount_Click;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 66);
            label14.Name = "label14";
            label14.Size = new Size(88, 21);
            label14.TabIndex = 3;
            label14.Text = "MALZEME: ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(33, 31);
            label15.Name = "label15";
            label15.Size = new Size(61, 21);
            label15.TabIndex = 1;
            label15.Text = "ÜRÜN: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 156);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 7;
            label1.Text = "SATIŞ TUTARI: ";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(142, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(87, 29);
            textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(149, 190, 181);
            ClientSize = new Size(754, 475);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(42, 57, 76);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Pasta Hane";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnMalzemeEkle;
        private Label label5;
        private TextBox txtMaterialNotes;
        private Label label4;
        private TextBox txtMaterialPrice;
        private Label label3;
        private TextBox txtMaterialStock;
        private Label label2;
        private TextBox txtMaterialName;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Button btnUrunEkle;
        private Label label8;
        private TextBox txtProductBPrice;
        private Label label9;
        private TextBox txtProductName;
        private GroupBox groupBox4;
        private Button btnEkle;
        private Label label12;
        private TextBox txtCost;
        private Label label13;
        private TextBox txtAmount;
        private Label label14;
        private Label label15;
        private ComboBox cmbMaterial;
        private ComboBox cmbProduct;
        private Label label1;
        private TextBox textBox1;
    }
}