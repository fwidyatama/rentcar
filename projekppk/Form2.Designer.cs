namespace projekppk
{
    partial class Order
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
            this.RiwayatOrder = new MaterialSkin.Controls.MaterialListView();
            this.SuspendLayout();
            // 
            // RiwayatOrder
            // 
            this.RiwayatOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RiwayatOrder.Depth = 0;
            this.RiwayatOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.RiwayatOrder.FullRowSelect = true;
            this.RiwayatOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.RiwayatOrder.Location = new System.Drawing.Point(54, 81);
            this.RiwayatOrder.Margin = new System.Windows.Forms.Padding(2);
            this.RiwayatOrder.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RiwayatOrder.MouseState = MaterialSkin.MouseState.OUT;
            this.RiwayatOrder.Name = "RiwayatOrder";
            this.RiwayatOrder.OwnerDraw = true;
            this.RiwayatOrder.Size = new System.Drawing.Size(670, 278);
            this.RiwayatOrder.TabIndex = 0;
            this.RiwayatOrder.UseCompatibleStateImageBehavior = false;
            this.RiwayatOrder.View = System.Windows.Forms.View.Details;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 374);
            this.Controls.Add(this.RiwayatOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView RiwayatOrder;
    }
}