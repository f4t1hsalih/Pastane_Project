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
            btnGetir = new Button();
            btnMalzemeEkle = new Button();
            label5 = new Label();
            txtMaterialNotes = new TextBox();
            label4 = new Label();
            TxtMaterialPrice = new TextBox();
            label3 = new Label();
            txtMaterialStock = new TextBox();
            label2 = new Label();
            txtMaterialName = new TextBox();
            label1 = new Label();
            txtMaterialid = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            btnGuncelle = new Button();
            btnUrunMalzemeEkle = new Button();
            label6 = new Label();
            txtProductStock = new TextBox();
            label7 = new Label();
            txtProductSPrice = new TextBox();
            label8 = new Label();
            txtProductBPrice = new TextBox();
            label9 = new Label();
            txtProductName = new TextBox();
            label10 = new Label();
            txtProductid = new TextBox();
            groupBox4 = new GroupBox();
            btnEkle = new Button();
            label12 = new Label();
            txtMaliyet = new TextBox();
            label13 = new Label();
            txtMiktar = new TextBox();
            label14 = new Label();
            txtMalzemeSec = new TextBox();
            label15 = new Label();
            txtUrunSec = new TextBox();
            groupBox5 = new GroupBox();
            btnCikis = new Button();
            btnKasa = new Button();
            btnMalzemeListesi = new Button();
            btnÜrünListesi = new Button();
            groupBox6 = new GroupBox();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGetir);
            groupBox1.Controls.Add(btnMalzemeEkle);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMaterialNotes);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtMaterialPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaterialStock);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaterialName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMaterialid);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 298);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Malzeme Girişi";
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(91, 250);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(138, 30);
            btnGetir.TabIndex = 10;
            btnGetir.Text = "Getir";
            btnGetir.UseVisualStyleBackColor = true;
            // 
            // btnMalzemeEkle
            // 
            btnMalzemeEkle.Location = new Point(91, 203);
            btnMalzemeEkle.Name = "btnMalzemeEkle";
            btnMalzemeEkle.Size = new Size(138, 30);
            btnMalzemeEkle.TabIndex = 1;
            btnMalzemeEkle.Text = "Malzeme Ekle";
            btnMalzemeEkle.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 171);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 9;
            label5.Text = "NOTLAR: ";
            // 
            // txtMaterialNotes
            // 
            txtMaterialNotes.Location = new Point(91, 168);
            txtMaterialNotes.Name = "txtMaterialNotes";
            txtMaterialNotes.Size = new Size(138, 29);
            txtMaterialNotes.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 136);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 7;
            label4.Text = "FİYAT: ";
            // 
            // TxtMaterialPrice
            // 
            TxtMaterialPrice.Location = new Point(91, 133);
            TxtMaterialPrice.Name = "TxtMaterialPrice";
            TxtMaterialPrice.Size = new Size(138, 29);
            TxtMaterialPrice.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 101);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 5;
            label3.Text = "STOK: ";
            // 
            // txtMaterialStock
            // 
            txtMaterialStock.Location = new Point(91, 98);
            txtMaterialStock.Name = "txtMaterialStock";
            txtMaterialStock.Size = new Size(138, 29);
            txtMaterialStock.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 66);
            label2.Name = "label2";
            label2.Size = new Size(38, 21);
            label2.TabIndex = 3;
            label2.Text = "AD: ";
            // 
            // txtMaterialName
            // 
            txtMaterialName.Location = new Point(91, 63);
            txtMaterialName.Name = "txtMaterialName";
            txtMaterialName.Size = new Size(138, 29);
            txtMaterialName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 31);
            label1.Name = "label1";
            label1.Size = new Size(32, 21);
            label1.TabIndex = 1;
            label1.Text = "ID: ";
            // 
            // txtMaterialid
            // 
            txtMaterialid.Location = new Point(91, 28);
            txtMaterialid.Name = "txtMaterialid";
            txtMaterialid.Size = new Size(138, 29);
            txtMaterialid.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 316);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(727, 219);
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
            dataGridView1.Size = new Size(721, 191);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnGuncelle);
            groupBox3.Controls.Add(btnUrunMalzemeEkle);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtProductStock);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtProductSPrice);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtProductBPrice);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtProductName);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtProductid);
            groupBox3.Location = new Point(253, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(235, 298);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ürün Girişi";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(91, 250);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(138, 30);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnUrunMalzemeEkle
            // 
            btnUrunMalzemeEkle.Location = new Point(91, 203);
            btnUrunMalzemeEkle.Name = "btnUrunMalzemeEkle";
            btnUrunMalzemeEkle.Size = new Size(138, 30);
            btnUrunMalzemeEkle.TabIndex = 1;
            btnUrunMalzemeEkle.Text = "Malzeme Ekle";
            btnUrunMalzemeEkle.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 171);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 9;
            label6.Text = "STOK: ";
            // 
            // txtProductStock
            // 
            txtProductStock.Location = new Point(91, 168);
            txtProductStock.Name = "txtProductStock";
            txtProductStock.Size = new Size(138, 29);
            txtProductStock.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 136);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 7;
            label7.Text = "S.FİYAT: ";
            // 
            // txtProductSPrice
            // 
            txtProductSPrice.Location = new Point(91, 133);
            txtProductSPrice.Name = "txtProductSPrice";
            txtProductSPrice.Size = new Size(138, 29);
            txtProductSPrice.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 101);
            label8.Name = "label8";
            label8.Size = new Size(71, 21);
            label8.TabIndex = 5;
            label8.Text = "M.FİYAT: ";
            // 
            // txtProductBPrice
            // 
            txtProductBPrice.Location = new Point(91, 98);
            txtProductBPrice.Name = "txtProductBPrice";
            txtProductBPrice.Size = new Size(138, 29);
            txtProductBPrice.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(47, 66);
            label9.Name = "label9";
            label9.Size = new Size(38, 21);
            label9.TabIndex = 3;
            label9.Text = "AD: ";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(91, 63);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(138, 29);
            txtProductName.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 31);
            label10.Name = "label10";
            label10.Size = new Size(32, 21);
            label10.TabIndex = 1;
            label10.Text = "ID: ";
            // 
            // txtProductid
            // 
            txtProductid.Location = new Point(91, 28);
            txtProductid.Name = "txtProductid";
            txtProductid.Size = new Size(138, 29);
            txtProductid.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnEkle);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(txtMaliyet);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(txtMiktar);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(txtMalzemeSec);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(txtUrunSec);
            groupBox4.Location = new Point(494, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(245, 298);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ürün Oluştur";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(100, 168);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(138, 30);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
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
            // txtMaliyet
            // 
            txtMaliyet.Location = new Point(100, 133);
            txtMaliyet.Name = "txtMaliyet";
            txtMaliyet.Size = new Size(138, 29);
            txtMaliyet.TabIndex = 6;
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
            // txtMiktar
            // 
            txtMiktar.Location = new Point(100, 98);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(138, 29);
            txtMiktar.TabIndex = 4;
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
            // txtMalzemeSec
            // 
            txtMalzemeSec.Location = new Point(100, 63);
            txtMalzemeSec.Name = "txtMalzemeSec";
            txtMalzemeSec.Size = new Size(138, 29);
            txtMalzemeSec.TabIndex = 2;
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
            // txtUrunSec
            // 
            txtUrunSec.Location = new Point(100, 28);
            txtUrunSec.Name = "txtUrunSec";
            txtUrunSec.Size = new Size(138, 29);
            txtUrunSec.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnCikis);
            groupBox5.Controls.Add(btnKasa);
            groupBox5.Controls.Add(btnMalzemeListesi);
            groupBox5.Controls.Add(btnÜrünListesi);
            groupBox5.Location = new Point(745, 316);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(250, 219);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "İşlemler";
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(43, 157);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(176, 30);
            btnCikis.TabIndex = 14;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnKasa
            // 
            btnKasa.Location = new Point(43, 121);
            btnKasa.Name = "btnKasa";
            btnKasa.Size = new Size(176, 30);
            btnKasa.TabIndex = 13;
            btnKasa.Text = "Kasa";
            btnKasa.UseVisualStyleBackColor = true;
            btnKasa.Click += btnKasa_Click;
            // 
            // btnMalzemeListesi
            // 
            btnMalzemeListesi.Location = new Point(43, 85);
            btnMalzemeListesi.Name = "btnMalzemeListesi";
            btnMalzemeListesi.Size = new Size(176, 30);
            btnMalzemeListesi.TabIndex = 12;
            btnMalzemeListesi.Text = "Malzeme Listesi";
            btnMalzemeListesi.UseVisualStyleBackColor = true;
            btnMalzemeListesi.Click += btnMalzemeListesi_Click;
            // 
            // btnÜrünListesi
            // 
            btnÜrünListesi.Location = new Point(43, 49);
            btnÜrünListesi.Name = "btnÜrünListesi";
            btnÜrünListesi.Size = new Size(176, 30);
            btnÜrünListesi.TabIndex = 11;
            btnÜrünListesi.Text = "Ürün Listesi";
            btnÜrünListesi.UseVisualStyleBackColor = true;
            btnÜrünListesi.Click += btnÜrünListesi_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(listBox1);
            groupBox6.Location = new Point(745, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(250, 298);
            groupBox6.TabIndex = 15;
            groupBox6.TabStop = false;
            groupBox6.Text = "Ürün Girişi";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(3, 25);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(244, 270);
            listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(149, 190, 181);
            ClientSize = new Size(1007, 547);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
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
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMaterialid;
        private Button btnGetir;
        private Button btnMalzemeEkle;
        private Label label5;
        private TextBox txtMaterialNotes;
        private Label label4;
        private TextBox TxtMaterialPrice;
        private Label label3;
        private TextBox txtMaterialStock;
        private Label label2;
        private TextBox txtMaterialName;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Button btnGuncelle;
        private Button btnUrunMalzemeEkle;
        private Label label6;
        private TextBox txtProductStock;
        private Label label7;
        private TextBox txtProductSPrice;
        private Label label8;
        private TextBox txtProductBPrice;
        private Label label9;
        private TextBox txtProductName;
        private Label label10;
        private TextBox txtProductid;
        private GroupBox groupBox4;
        private Button btnEkle;
        private Label label12;
        private TextBox txtMaliyet;
        private Label label13;
        private TextBox txtMiktar;
        private Label label14;
        private TextBox txtMalzemeSec;
        private Label label15;
        private TextBox txtUrunSec;
        private GroupBox groupBox5;
        private Button btnCikis;
        private Button btnKasa;
        private Button btnMalzemeListesi;
        private Button btnÜrünListesi;
        private GroupBox groupBox6;
        private ListBox listBox1;
    }
}