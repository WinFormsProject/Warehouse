
namespace Warehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.suppList = new System.Windows.Forms.ListBox();
            this.showAllSupp = new System.Windows.Forms.Button();
            this.showAllCateg = new System.Windows.Forms.Button();
            this.categList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.avgQuantity = new System.Windows.Forms.Button();
            this.minQuantity = new System.Windows.Forms.Button();
            this.maxQuantity = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.showAllGoods = new System.Windows.Forms.Button();
            this.oldestProd = new System.Windows.Forms.Button();
            this.maxCostPrice = new System.Windows.Forms.Button();
            this.minCostPrice = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1226, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(443, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Management";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.suppList);
            this.groupBox2.Controls.Add(this.showAllSupp);
            this.groupBox2.Controls.Add(this.showAllCateg);
            this.groupBox2.Controls.Add(this.categList);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 598);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supplier";
            // 
            // suppList
            // 
            this.suppList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.suppList.Dock = System.Windows.Forms.DockStyle.Top;
            this.suppList.ForeColor = System.Drawing.Color.Navy;
            this.suppList.FormattingEnabled = true;
            this.suppList.ItemHeight = 18;
            this.suppList.Location = new System.Drawing.Point(3, 20);
            this.suppList.Name = "suppList";
            this.suppList.ScrollAlwaysVisible = true;
            this.suppList.Size = new System.Drawing.Size(348, 148);
            this.suppList.TabIndex = 10;
            this.suppList.SelectedIndexChanged += new System.EventHandler(this.suppList_SelectedIndexChanged);
            // 
            // showAllSupp
            // 
            this.showAllSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAllSupp.Location = new System.Drawing.Point(75, 188);
            this.showAllSupp.Name = "showAllSupp";
            this.showAllSupp.Size = new System.Drawing.Size(195, 51);
            this.showAllSupp.TabIndex = 9;
            this.showAllSupp.Text = "Show all suppliers";
            this.showAllSupp.UseVisualStyleBackColor = true;
            this.showAllSupp.Click += new System.EventHandler(this.showAllSupp_Click);
            // 
            // showAllCateg
            // 
            this.showAllCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAllCateg.Location = new System.Drawing.Point(75, 473);
            this.showAllCateg.Name = "showAllCateg";
            this.showAllCateg.Size = new System.Drawing.Size(195, 71);
            this.showAllCateg.TabIndex = 8;
            this.showAllCateg.Text = "Show all categories of goods";
            this.showAllCateg.UseVisualStyleBackColor = true;
            this.showAllCateg.Click += new System.EventHandler(this.showAllCateg_Click);
            // 
            // categList
            // 
            this.categList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.categList.FormattingEnabled = true;
            this.categList.ItemHeight = 18;
            this.categList.Location = new System.Drawing.Point(0, 277);
            this.categList.Name = "categList";
            this.categList.ScrollAlwaysVisible = true;
            this.categList.Size = new System.Drawing.Size(354, 148);
            this.categList.TabIndex = 4;
            this.categList.SelectedIndexChanged += new System.EventHandler(this.categList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Category";
            // 
            // avgQuantity
            // 
            this.avgQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgQuantity.Location = new System.Drawing.Point(124, 473);
            this.avgQuantity.Name = "avgQuantity";
            this.avgQuantity.Size = new System.Drawing.Size(249, 71);
            this.avgQuantity.TabIndex = 7;
            this.avgQuantity.Text = "Average quantity of goods in categories";
            this.avgQuantity.UseVisualStyleBackColor = true;
            this.avgQuantity.Click += new System.EventHandler(this.avgQuantity_Click);
            // 
            // minQuantity
            // 
            this.minQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minQuantity.Location = new System.Drawing.Point(189, 386);
            this.minQuantity.Name = "minQuantity";
            this.minQuantity.Size = new System.Drawing.Size(138, 39);
            this.minQuantity.TabIndex = 3;
            this.minQuantity.Text = "Min quantity";
            this.minQuantity.UseVisualStyleBackColor = true;
            this.minQuantity.Click += new System.EventHandler(this.minQuantity_Click);
            // 
            // maxQuantity
            // 
            this.maxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxQuantity.Location = new System.Drawing.Point(8, 386);
            this.maxQuantity.Name = "maxQuantity";
            this.maxQuantity.Size = new System.Drawing.Size(138, 39);
            this.maxQuantity.TabIndex = 2;
            this.maxQuantity.Text = "Max quantity";
            this.maxQuantity.UseVisualStyleBackColor = true;
            this.maxQuantity.Click += new System.EventHandler(this.maxQuantity_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.showAllGoods);
            this.groupBox4.Controls.Add(this.oldestProd);
            this.groupBox4.Controls.Add(this.maxCostPrice);
            this.groupBox4.Controls.Add(this.avgQuantity);
            this.groupBox4.Controls.Add(this.minCostPrice);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.maxQuantity);
            this.groupBox4.Controls.Add(this.minQuantity);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(354, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(872, 598);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Goods";
            // 
            // showAllGoods
            // 
            this.showAllGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAllGoods.Location = new System.Drawing.Point(488, 473);
            this.showAllGoods.Name = "showAllGoods";
            this.showAllGoods.Size = new System.Drawing.Size(249, 71);
            this.showAllGoods.TabIndex = 8;
            this.showAllGoods.Text = "Show all goods";
            this.showAllGoods.UseVisualStyleBackColor = true;
            this.showAllGoods.Click += new System.EventHandler(this.showAllGoods_Click);
            // 
            // oldestProd
            // 
            this.oldestProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldestProd.Location = new System.Drawing.Point(722, 386);
            this.oldestProd.Name = "oldestProd";
            this.oldestProd.Size = new System.Drawing.Size(138, 39);
            this.oldestProd.TabIndex = 6;
            this.oldestProd.Text = "Oldest product";
            this.oldestProd.UseVisualStyleBackColor = true;
            this.oldestProd.Click += new System.EventHandler(this.oldestProd_Click);
            // 
            // maxCostPrice
            // 
            this.maxCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxCostPrice.Location = new System.Drawing.Point(545, 386);
            this.maxCostPrice.Name = "maxCostPrice";
            this.maxCostPrice.Size = new System.Drawing.Size(138, 39);
            this.maxCostPrice.TabIndex = 5;
            this.maxCostPrice.Text = "Max cost price";
            this.maxCostPrice.UseVisualStyleBackColor = true;
            this.maxCostPrice.Click += new System.EventHandler(this.maxCostPrice_Click);
            // 
            // minCostPrice
            // 
            this.minCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minCostPrice.Location = new System.Drawing.Point(365, 386);
            this.minCostPrice.Name = "minCostPrice";
            this.minCostPrice.Size = new System.Drawing.Size(138, 39);
            this.minCostPrice.TabIndex = 4;
            this.minCostPrice.Text = "Min cost price";
            this.minCostPrice.UseVisualStyleBackColor = true;
            this.minCostPrice.Click += new System.EventHandler(this.minCostPrice_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(866, 341);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1226, 681);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox categList;
        private System.Windows.Forms.Button minQuantity;
        private System.Windows.Forms.Button maxQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button avgQuantity;
        private System.Windows.Forms.Button oldestProd;
        private System.Windows.Forms.Button maxCostPrice;
        private System.Windows.Forms.Button minCostPrice;
        private System.Windows.Forms.Button showAllSupp;
        private System.Windows.Forms.Button showAllCateg;
        private System.Windows.Forms.ListBox suppList;
        private System.Windows.Forms.Button showAllGoods;
    }
}

