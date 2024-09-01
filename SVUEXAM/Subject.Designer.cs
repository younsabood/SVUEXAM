namespace SVUEXAM
{
    partial class Subject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sname = new System.Windows.Forms.Label();
            this.Sdate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Relode = new Guna.UI.WinForms.GunaImageButton();
            this.Exit = new Guna.UI.WinForms.GunaImageButton();
            this.tab = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 733);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(280, 674);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1007, 59);
            this.panel3.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 909F));
            this.tableLayoutPanel1.Controls.Add(this.sname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Sdate, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(210, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(797, 59);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // sname
            // 
            this.sname.AutoSize = true;
            this.sname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sname.Location = new System.Drawing.Point(1, 1);
            this.sname.Margin = new System.Windows.Forms.Padding(1);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(54, 57);
            this.sname.TabIndex = 1;
            this.sname.Text = "name";
            this.sname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sdate
            // 
            this.Sdate.AutoSize = true;
            this.Sdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sdate.Location = new System.Drawing.Point(57, 1);
            this.Sdate.Margin = new System.Windows.Forms.Padding(1);
            this.Sdate.Name = "Sdate";
            this.Sdate.Size = new System.Drawing.Size(44, 57);
            this.Sdate.TabIndex = 2;
            this.Sdate.Text = "date";
            this.Sdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Relode);
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 59);
            this.panel2.TabIndex = 1;
            // 
            // Relode
            // 
            this.Relode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Relode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Relode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Relode.Image = global::SVUEXAM.Properties.Resources.icons8_update_50;
            this.Relode.ImageSize = new System.Drawing.Size(50, 50);
            this.Relode.Location = new System.Drawing.Point(86, 5);
            this.Relode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Relode.Name = "Relode";
            this.Relode.OnHoverImage = global::SVUEXAM.Properties.Resources.icons8_update;
            this.Relode.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.Relode.Size = new System.Drawing.Size(50, 50);
            this.Relode.TabIndex = 2;
            this.Relode.Click += new System.EventHandler(this.Relode_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Exit.Image = global::SVUEXAM.Properties.Resources.icons8_exit_50;
            this.Exit.ImageSize = new System.Drawing.Size(50, 50);
            this.Exit.Location = new System.Drawing.Point(148, 5);
            this.Exit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Exit.Name = "Exit";
            this.Exit.OnHoverImage = global::SVUEXAM.Properties.Resources.icons8_exit;
            this.Exit.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.Exit.Size = new System.Drawing.Size(50, 50);
            this.Exit.TabIndex = 1;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // tab
            // 
            this.tab.AutoScroll = true;
            this.tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tab.Dock = System.Windows.Forms.DockStyle.Left;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tab.Name = "tab";
            this.tab.Size = new System.Drawing.Size(280, 733);
            this.tab.TabIndex = 2;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 733);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label sname;
        private System.Windows.Forms.Label Sdate;
        private System.Windows.Forms.Panel tab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaImageButton Relode;
        private Guna.UI.WinForms.GunaImageButton Exit;
    }
}