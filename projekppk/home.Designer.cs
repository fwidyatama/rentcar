namespace projekppk
{
    partial class home
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
            this.btnSewa = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnTambah = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnLihat = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.SuspendLayout();
            // 
            // btnSewa
            // 
            this.btnSewa.AutoSize = true;
            this.btnSewa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSewa.Depth = 0;
            this.btnSewa.Icon = null;
            this.btnSewa.Location = new System.Drawing.Point(618, 93);
            this.btnSewa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSewa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSewa.Name = "btnSewa";
            this.btnSewa.Primary = false;
            this.btnSewa.Size = new System.Drawing.Size(58, 36);
            this.btnSewa.TabIndex = 3;
            this.btnSewa.Text = "Sewa";
            this.btnSewa.UseVisualStyleBackColor = true;
            this.btnSewa.Click += new System.EventHandler(this.btnSewa_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.AutoSize = true;
            this.btnTambah.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTambah.Depth = 0;
            this.btnTambah.Icon = null;
            this.btnTambah.Location = new System.Drawing.Point(618, 163);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTambah.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Primary = false;
            this.btnTambah.Size = new System.Drawing.Size(123, 36);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Tambah Mobil";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnLihat
            // 
            this.btnLihat.AutoSize = true;
            this.btnLihat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLihat.Depth = 0;
            this.btnLihat.Icon = null;
            this.btnLihat.Location = new System.Drawing.Point(618, 226);
            this.btnLihat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLihat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.Primary = false;
            this.btnLihat.Size = new System.Drawing.Size(106, 36);
            this.btnLihat.TabIndex = 5;
            this.btnLihat.Text = "Lihat order";
            this.btnLihat.UseVisualStyleBackColor = true;
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(39, 91);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(560, 260);
            this.materialListView1.TabIndex = 6;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 387);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnSewa);
            this.Name = "home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton btnSewa;
        private MaterialSkin.Controls.MaterialFlatButton btnTambah;
        private MaterialSkin.Controls.MaterialFlatButton btnLihat;
        private MaterialSkin.Controls.MaterialListView materialListView1;
    }
}