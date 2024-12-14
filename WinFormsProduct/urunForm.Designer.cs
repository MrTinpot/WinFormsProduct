namespace WinFormsProduct
{
    partial class urunForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtDesc = new System.Windows.Forms.RichTextBox();
            this.checkDurum = new System.Windows.Forms.CheckBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.dgUrun = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryCollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtxtDesc);
            this.groupBox1.Controls.Add(this.checkDurum);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.txtMarka);
            this.groupBox1.Controls.Add(this.txtUrunAd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(24, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ürün Açıklaması:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Menşei";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün Adı";
            // 
            // rtxtDesc
            // 
            this.rtxtDesc.Location = new System.Drawing.Point(172, 64);
            this.rtxtDesc.Name = "rtxtDesc";
            this.rtxtDesc.Size = new System.Drawing.Size(212, 143);
            this.rtxtDesc.TabIndex = 5;
            this.rtxtDesc.Text = "";
            // 
            // checkDurum
            // 
            this.checkDurum.AutoSize = true;
            this.checkDurum.Location = new System.Drawing.Point(27, 168);
            this.checkDurum.Name = "checkDurum";
            this.checkDurum.Size = new System.Drawing.Size(72, 22);
            this.checkDurum.TabIndex = 3;
            this.checkDurum.Text = "Durum";
            this.checkDurum.UseVisualStyleBackColor = true;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(27, 138);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 24);
            this.txtCountry.TabIndex = 2;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(27, 88);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 24);
            this.txtMarka.TabIndex = 1;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(27, 47);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(100, 24);
            this.txtUrunAd.TabIndex = 0;
            // 
            // dgUrun
            // 
            this.dgUrun.AllowUserToDeleteRows = false;
            this.dgUrun.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.dgUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUrun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.Marka,
            this.countryCollumn,
            this.descColumn,
            this.durumColumn});
            this.dgUrun.Location = new System.Drawing.Point(478, 12);
            this.dgUrun.Name = "dgUrun";
            this.dgUrun.ReadOnly = true;
            this.dgUrun.Size = new System.Drawing.Size(532, 224);
            this.dgUrun.TabIndex = 2;
            this.dgUrun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Ürün";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // Marka
            // 
            this.Marka.HeaderText = "Marka";
            this.Marka.Name = "Marka";
            this.Marka.ReadOnly = true;
            // 
            // countryCollumn
            // 
            this.countryCollumn.HeaderText = "Menşei";
            this.countryCollumn.Name = "countryCollumn";
            this.countryCollumn.ReadOnly = true;
            this.countryCollumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countryCollumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // descColumn
            // 
            this.descColumn.HeaderText = "Açıklama";
            this.descColumn.Name = "descColumn";
            this.descColumn.ReadOnly = true;
            // 
            // durumColumn
            // 
            this.durumColumn.HeaderText = "Durum";
            this.durumColumn.Name = "durumColumn";
            this.durumColumn.ReadOnly = true;
            // 
            // urunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 261);
            this.Controls.Add(this.dgUrun);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "urunForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Ürün Panel";
            this.Load += new System.EventHandler(this.urunForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUrun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtDesc;
        private System.Windows.Forms.CheckBox checkDurum;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgUrun;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryCollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumColumn;
    }
}