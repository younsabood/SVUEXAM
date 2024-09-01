namespace SVUEXAM
{
    partial class TabControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.major = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 555F));
            this.tableLayoutPanel1.Controls.Add(this.Subject, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.major, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 74);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // major
            // 
            this.major.AutoSize = true;
            this.major.Dock = System.Windows.Forms.DockStyle.Fill;
            this.major.Location = new System.Drawing.Point(3, 0);
            this.major.Name = "major";
            this.major.Size = new System.Drawing.Size(92, 74);
            this.major.TabIndex = 0;
            this.major.Text = "Major";
            this.major.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Subject.Location = new System.Drawing.Point(101, 0);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(180, 74);
            this.Subject.TabIndex = 1;
            this.Subject.Text = "SubjectName";
            this.Subject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "TabControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(684, 94);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label major;
        private System.Windows.Forms.Label Subject;
    }
}
