namespace SVUEXAM
{
    partial class DRDataInput
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
            this.contenar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Next = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Previous = new Guna.UI2.WinForms.Guna2ImageButton();
            this.contenar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenar
            // 
            this.contenar.BackColor = System.Drawing.Color.White;
            this.contenar.Controls.Add(this.tableLayoutPanel2);
            this.contenar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenar.Location = new System.Drawing.Point(0, 0);
            this.contenar.Name = "contenar";
            this.contenar.Size = new System.Drawing.Size(1119, 540);
            this.contenar.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Next, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Previous, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 474);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1119, 66);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // Next
            // 
            this.Next.AnimatedGIF = true;
            this.Next.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.Dock = System.Windows.Forms.DockStyle.Left;
            this.Next.HoverState.Image = global::SVUEXAM.Properties.Resources.icons8_next;
            this.Next.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.Next.Image = global::SVUEXAM.Properties.Resources.icons8_next_501;
            this.Next.ImageOffset = new System.Drawing.Point(0, 0);
            this.Next.ImageRotate = 0F;
            this.Next.ImageSize = new System.Drawing.Size(50, 50);
            this.Next.Location = new System.Drawing.Point(584, 3);
            this.Next.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.Next.Name = "Next";
            this.Next.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.Next.Size = new System.Drawing.Size(50, 60);
            this.Next.TabIndex = 12;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.AnimatedGIF = true;
            this.Previous.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previous.Dock = System.Windows.Forms.DockStyle.Right;
            this.Previous.HoverState.Image = global::SVUEXAM.Properties.Resources.icons8_go_back;
            this.Previous.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.Previous.Image = global::SVUEXAM.Properties.Resources.icons8_go_back_50;
            this.Previous.ImageOffset = new System.Drawing.Point(0, 0);
            this.Previous.ImageRotate = 0F;
            this.Previous.ImageSize = new System.Drawing.Size(50, 50);
            this.Previous.Location = new System.Drawing.Point(484, 3);
            this.Previous.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
            this.Previous.Name = "Previous";
            this.Previous.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.Previous.Size = new System.Drawing.Size(50, 60);
            this.Previous.TabIndex = 13;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // DRDataInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 540);
            this.Controls.Add(this.contenar);
            this.Name = "DRDataInput";
            this.Text = "DRDataInput";
            this.Load += new System.EventHandler(this.DRDataInput_Load);
            this.contenar.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2ImageButton Next;
        private Guna.UI2.WinForms.Guna2ImageButton Previous;
    }
}