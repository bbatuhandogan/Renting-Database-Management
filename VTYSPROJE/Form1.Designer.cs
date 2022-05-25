namespace VTYSPROJE
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Urun = new System.Windows.Forms.Button();
            this.Musteri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Test = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vTYSPROJEDataSet = new VTYSPROJE.VTYSPROJEDataSet();
            this.vTYSPROJEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vTYSPROJEDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vTYSPROJEDataSet1 = new VTYSPROJE.VTYSPROJEDataSet1();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunTableAdapter = new VTYSPROJE.VTYSPROJEDataSet1TableAdapters.UrunTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSPROJEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSPROJEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSPROJEDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSPROJEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Urun
            // 
            this.Urun.AccessibleDescription = "Urun";
            this.Urun.AccessibleName = "Urun";
            this.Urun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Urun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Urun.BackgroundImage")));
            this.Urun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Urun.Location = new System.Drawing.Point(51, 267);
            this.Urun.Name = "Urun";
            this.Urun.Size = new System.Drawing.Size(281, 69);
            this.Urun.TabIndex = 1;
            this.Urun.Text = "Urun Menu";
            this.Urun.UseVisualStyleBackColor = false;
            this.Urun.Click += new System.EventHandler(this.Urun_Click_1);
            // 
            // Musteri
            // 
            this.Musteri.AccessibleDescription = "Musteri";
            this.Musteri.AccessibleName = "Musteri";
            this.Musteri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Musteri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Musteri.BackgroundImage")));
            this.Musteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Musteri.Location = new System.Drawing.Point(51, 377);
            this.Musteri.Name = "Musteri";
            this.Musteri.Size = new System.Drawing.Size(281, 69);
            this.Musteri.TabIndex = 2;
            this.Musteri.Text = "Musteri Menu";
            this.Musteri.UseVisualStyleBackColor = false;
            this.Musteri.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F, System.Drawing.FontStyle.Bold);
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(890, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "VERİTABANI YÖNETİM SİSTEMLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F, System.Drawing.FontStyle.Bold);
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(636, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(536, 57);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Kiralama Sistemi";
            // 
            // Test
            // 
            this.Test.AccessibleDescription = "Urun";
            this.Test.AccessibleName = "Urun";
            this.Test.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Test.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Test.BackgroundImage")));
            this.Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Test.Location = new System.Drawing.Point(51, 484);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(281, 69);
            this.Test.TabIndex = 5;
            this.Test.Text = "Kiralama Menu";
            this.Test.UseVisualStyleBackColor = false;
            this.Test.Click += new System.EventHandler(this.Test_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1206, 847);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // vTYSPROJEDataSet
            // 
            this.vTYSPROJEDataSet.DataSetName = "VTYSPROJEDataSet";
            this.vTYSPROJEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vTYSPROJEDataSetBindingSource
            // 
            this.vTYSPROJEDataSetBindingSource.DataSource = this.vTYSPROJEDataSet;
            this.vTYSPROJEDataSetBindingSource.Position = 0;
            // 
            // vTYSPROJEDataSetBindingSource1
            // 
            this.vTYSPROJEDataSetBindingSource1.DataSource = this.vTYSPROJEDataSet;
            this.vTYSPROJEDataSetBindingSource1.Position = 0;
            // 
            // vTYSPROJEDataSet1
            // 
            this.vTYSPROJEDataSet1.DataSetName = "VTYSPROJEDataSet1";
            this.vTYSPROJEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "Urun";
            this.urunBindingSource.DataSource = this.vTYSPROJEDataSet1;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(768, 745);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(417, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Muhammed Yusuf Macit 170419029 & Batuhan Doğan 170418044";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.Musteri);
            this.Controls.Add(this.Urun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSPROJEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSPROJEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSPROJEDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSPROJEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Urun;
        private System.Windows.Forms.Button Musteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource vTYSPROJEDataSetBindingSource;
        private VTYSPROJEDataSet vTYSPROJEDataSet;
        private System.Windows.Forms.BindingSource vTYSPROJEDataSetBindingSource1;
        private VTYSPROJEDataSet1 vTYSPROJEDataSet1;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private VTYSPROJEDataSet1TableAdapters.UrunTableAdapter urunTableAdapter;
        private System.Windows.Forms.Label label3;
    }
}

