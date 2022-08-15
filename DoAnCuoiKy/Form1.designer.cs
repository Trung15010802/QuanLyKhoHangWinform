namespace QuanLyKhoHang
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButtonHome = new FontAwesome.Sharp.IconButton();
            this.iconButtonStats = new FontAwesome.Sharp.IconButton();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.iconButtonRemove = new FontAwesome.Sharp.IconButton();
            this.iconButtonAdd = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(163)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenu.Controls.Add(this.iconButtonStats);
            this.panelMenu.Controls.Add(this.iconButtonSearch);
            this.panelMenu.Controls.Add(this.iconButtonRemove);
            this.panelMenu.Controls.Add(this.iconButtonAdd);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(263, 798);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 161);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.iconButtonHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(263, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 64);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(263, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1072, 397);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(186)))), ((int)(((byte)(137)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(263, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1072, 337);
            this.panel4.TabIndex = 3;
            // 
            // iconButtonHome
            // 
            this.iconButtonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(189)))), ((int)(((byte)(163)))));
            this.iconButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonHome.FlatAppearance.BorderSize = 0;
            this.iconButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButtonHome.IconColor = System.Drawing.Color.White;
            this.iconButtonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHome.Location = new System.Drawing.Point(0, 0);
            this.iconButtonHome.Name = "iconButtonHome";
            this.iconButtonHome.Size = new System.Drawing.Size(165, 64);
            this.iconButtonHome.TabIndex = 2;
            this.iconButtonHome.Text = "HOME";
            this.iconButtonHome.UseVisualStyleBackColor = false;
            this.iconButtonHome.Click += new System.EventHandler(this.iconButtonHome_Click);
            // 
            // iconButtonStats
            // 
            this.iconButtonStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonStats.FlatAppearance.BorderSize = 0;
            this.iconButtonStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonStats.ForeColor = System.Drawing.Color.White;
            this.iconButtonStats.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButtonStats.IconColor = System.Drawing.Color.White;
            this.iconButtonStats.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonStats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonStats.Location = new System.Drawing.Point(0, 347);
            this.iconButtonStats.Name = "iconButtonStats";
            this.iconButtonStats.Size = new System.Drawing.Size(259, 62);
            this.iconButtonStats.TabIndex = 8;
            this.iconButtonStats.Text = "In, xuất danh sách";
            this.iconButtonStats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonStats.UseVisualStyleBackColor = true;
            this.iconButtonStats.Click += new System.EventHandler(this.iconButtonStats_Click);
            // 
            // iconButtonSearch
            // 
            this.iconButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSearch.FlatAppearance.BorderSize = 0;
            this.iconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSearch.ForeColor = System.Drawing.Color.White;
            this.iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassLocation;
            this.iconButtonSearch.IconColor = System.Drawing.Color.White;
            this.iconButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSearch.Location = new System.Drawing.Point(0, 285);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(259, 62);
            this.iconButtonSearch.TabIndex = 7;
            this.iconButtonSearch.Text = "Tìm kiếm hàng hoá";
            this.iconButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSearch.UseVisualStyleBackColor = true;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // iconButtonRemove
            // 
            this.iconButtonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonRemove.FlatAppearance.BorderSize = 0;
            this.iconButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRemove.ForeColor = System.Drawing.Color.White;
            this.iconButtonRemove.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonRemove.IconColor = System.Drawing.Color.White;
            this.iconButtonRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRemove.Location = new System.Drawing.Point(0, 223);
            this.iconButtonRemove.Name = "iconButtonRemove";
            this.iconButtonRemove.Size = new System.Drawing.Size(259, 62);
            this.iconButtonRemove.TabIndex = 6;
            this.iconButtonRemove.Text = "Chỉnh sửa, xoá hàng hoá";
            this.iconButtonRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRemove.UseVisualStyleBackColor = true;
            this.iconButtonRemove.Click += new System.EventHandler(this.iconButtonRemove_Click);
            // 
            // iconButtonAdd
            // 
            this.iconButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAdd.FlatAppearance.BorderSize = 0;
            this.iconButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAdd.ForeColor = System.Drawing.Color.White;
            this.iconButtonAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAdd.IconColor = System.Drawing.Color.White;
            this.iconButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdd.Location = new System.Drawing.Point(0, 161);
            this.iconButtonAdd.Name = "iconButtonAdd";
            this.iconButtonAdd.Size = new System.Drawing.Size(259, 62);
            this.iconButtonAdd.TabIndex = 4;
            this.iconButtonAdd.Text = "Thêm hàng hoá";
            this.iconButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAdd.UseVisualStyleBackColor = true;
            this.iconButtonAdd.Click += new System.EventHandler(this.iconButtonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::DoAnCuoiKy.Properties.Resources.Warehouse_Management_1__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(186)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(1335, 798);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Quản lý kho hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonAdd;
        private FontAwesome.Sharp.IconButton iconButtonStats;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private FontAwesome.Sharp.IconButton iconButtonRemove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

