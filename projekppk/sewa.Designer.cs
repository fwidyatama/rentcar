﻿namespace projekppk
{
    partial class Sewa
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
            this.lblMerk = new MaterialSkin.Controls.MaterialLabel();
            this.tbMerk = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelTipe = new MaterialSkin.Controls.MaterialLabel();
            this.tbTipe = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelTanggal = new MaterialSkin.Controls.MaterialLabel();
            this.labelPengembalian = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelPelanggan = new MaterialSkin.Controls.MaterialLabel();
            this.labelNama = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnsewamobil = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lblMerk
            // 
            this.lblMerk.AutoSize = true;
            this.lblMerk.Depth = 0;
            this.lblMerk.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMerk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMerk.Location = new System.Drawing.Point(40, 112);
            this.lblMerk.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMerk.Name = "lblMerk";
            this.lblMerk.Size = new System.Drawing.Size(43, 19);
            this.lblMerk.TabIndex = 0;
            this.lblMerk.Text = "Merk";
            // 
            // tbMerk
            // 
            this.tbMerk.Depth = 0;
            this.tbMerk.Hint = "";
            this.tbMerk.Location = new System.Drawing.Point(243, 108);
            this.tbMerk.MaxLength = 32767;
            this.tbMerk.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbMerk.Name = "tbMerk";
            this.tbMerk.PasswordChar = '\0';
            this.tbMerk.SelectedText = "";
            this.tbMerk.SelectionLength = 0;
            this.tbMerk.SelectionStart = 0;
            this.tbMerk.Size = new System.Drawing.Size(197, 23);
            this.tbMerk.TabIndex = 1;
            this.tbMerk.TabStop = false;
            this.tbMerk.UseSystemPasswordChar = false;
            // 
            // labelTipe
            // 
            this.labelTipe.AutoSize = true;
            this.labelTipe.Depth = 0;
            this.labelTipe.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTipe.Location = new System.Drawing.Point(40, 150);
            this.labelTipe.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTipe.Name = "labelTipe";
            this.labelTipe.Size = new System.Drawing.Size(38, 19);
            this.labelTipe.TabIndex = 2;
            this.labelTipe.Text = "Tipe";
            // 
            // tbTipe
            // 
            this.tbTipe.Depth = 0;
            this.tbTipe.Hint = "";
            this.tbTipe.Location = new System.Drawing.Point(243, 146);
            this.tbTipe.MaxLength = 32767;
            this.tbTipe.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbTipe.Name = "tbTipe";
            this.tbTipe.PasswordChar = '\0';
            this.tbTipe.SelectedText = "";
            this.tbTipe.SelectionLength = 0;
            this.tbTipe.SelectionStart = 0;
            this.tbTipe.Size = new System.Drawing.Size(197, 23);
            this.tbTipe.TabIndex = 3;
            this.tbTipe.TabStop = false;
            this.tbTipe.UseSystemPasswordChar = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(243, 197);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Depth = 0;
            this.labelTanggal.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTanggal.Location = new System.Drawing.Point(40, 197);
            this.labelTanggal.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(149, 19);
            this.labelTanggal.TabIndex = 5;
            this.labelTanggal.Text = "Tanggal Peminjaman";
            // 
            // labelPengembalian
            // 
            this.labelPengembalian.AutoSize = true;
            this.labelPengembalian.Depth = 0;
            this.labelPengembalian.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPengembalian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPengembalian.Location = new System.Drawing.Point(40, 255);
            this.labelPengembalian.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPengembalian.Name = "labelPengembalian";
            this.labelPengembalian.Size = new System.Drawing.Size(160, 19);
            this.labelPengembalian.TabIndex = 6;
            this.labelPengembalian.Text = "Tanggal Pengembalian";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(243, 255);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // labelPelanggan
            // 
            this.labelPelanggan.AutoSize = true;
            this.labelPelanggan.Depth = 0;
            this.labelPelanggan.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPelanggan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPelanggan.Location = new System.Drawing.Point(40, 301);
            this.labelPelanggan.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPelanggan.Name = "labelPelanggan";
            this.labelPelanggan.Size = new System.Drawing.Size(122, 19);
            this.labelPelanggan.TabIndex = 8;
            this.labelPelanggan.Text = "Nama Pelanggan";
            // 
            // labelNama
            // 
            this.labelNama.Depth = 0;
            this.labelNama.Hint = "";
            this.labelNama.Location = new System.Drawing.Point(243, 297);
            this.labelNama.MaxLength = 32767;
            this.labelNama.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelNama.Name = "labelNama";
            this.labelNama.PasswordChar = '\0';
            this.labelNama.SelectedText = "";
            this.labelNama.SelectionLength = 0;
            this.labelNama.SelectionStart = 0;
            this.labelNama.Size = new System.Drawing.Size(197, 23);
            this.labelNama.TabIndex = 9;
            this.labelNama.TabStop = false;
            this.labelNama.UseSystemPasswordChar = false;
            // 
            // btnsewamobil
            // 
            this.btnsewamobil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsewamobil.Depth = 0;
            this.btnsewamobil.Icon = null;
            this.btnsewamobil.Location = new System.Drawing.Point(174, 340);
            this.btnsewamobil.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnsewamobil.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsewamobil.Name = "btnsewamobil";
            this.btnsewamobil.Primary = false;
            this.btnsewamobil.Size = new System.Drawing.Size(196, 36);
            this.btnsewamobil.TabIndex = 10;
            this.btnsewamobil.Text = "Sewa Mobil";
            this.btnsewamobil.UseVisualStyleBackColor = true;
            this.btnsewamobil.Click += new System.EventHandler(this.btnsewamobil_Click);
            // 
            // sewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 402);
            this.Controls.Add(this.btnsewamobil);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelPelanggan);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.labelPengembalian);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbTipe);
            this.Controls.Add(this.labelTipe);
            this.Controls.Add(this.tbMerk);
            this.Controls.Add(this.lblMerk);
            this.Name = "sewa";
            this.Text = "sewa";
            this.Load += new System.EventHandler(this.sewa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblMerk;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbMerk;
        private MaterialSkin.Controls.MaterialLabel labelTipe;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbTipe;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel labelTanggal;
        private MaterialSkin.Controls.MaterialLabel labelPengembalian;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MaterialSkin.Controls.MaterialLabel labelPelanggan;
        private MaterialSkin.Controls.MaterialSingleLineTextField labelNama;
        private MaterialSkin.Controls.MaterialFlatButton btnsewamobil;
    }
}