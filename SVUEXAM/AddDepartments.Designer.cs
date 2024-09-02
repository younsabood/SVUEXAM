namespace SVUEXAM
{
    partial class AddDepartments
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
            this.box = new System.Windows.Forms.TableLayoutPanel();
            this.DepName = new System.Windows.Forms.Label();
            this.box.SuspendLayout();
            this.SuspendLayout();
            // 
            // box
            // 
            this.box.BackColor = System.Drawing.Color.Red;
            this.box.ColumnCount = 1;
            this.box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.box.Controls.Add(this.DepName, 0, 0);
            this.box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box.Location = new System.Drawing.Point(0, 0);
            this.box.Name = "box";
            this.box.Padding = new System.Windows.Forms.Padding(2);
            this.box.RowCount = 1;
            this.box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.box.Size = new System.Drawing.Size(140, 120);
            this.box.TabIndex = 0;
            // 
            // DepName
            // 
            this.DepName.AutoSize = true;
            this.DepName.BackColor = System.Drawing.Color.Transparent;
            this.DepName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DepName.Location = new System.Drawing.Point(2, 2);
            this.DepName.Margin = new System.Windows.Forms.Padding(0);
            this.DepName.Name = "DepName";
            this.DepName.Size = new System.Drawing.Size(136, 116);
            this.DepName.TabIndex = 1;
            this.DepName.Text = "BAIT";
            this.DepName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DepName.Click += new System.EventHandler(this.DepName_Click);
            this.DepName.Enter += new System.EventHandler(this.DepName_Enter);
            this.DepName.Leave += new System.EventHandler(this.DepName_Leave);
            // 
            // AddDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.box);
            this.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AddDepartments";
            this.Size = new System.Drawing.Size(140, 120);
            this.box.ResumeLayout(false);
            this.box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel box;
        private System.Windows.Forms.Label DepName;
    }
}
