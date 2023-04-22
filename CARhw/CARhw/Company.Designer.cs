namespace CARhw
{
    partial class Company
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
            this.show_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.res_lbl = new System.Windows.Forms.Label();
            this.add_txt = new System.Windows.Forms.TextBox();
            this.mob_txt = new System.Windows.Forms.TextBox();
            this.nm_txt = new System.Windows.Forms.TextBox();
            this.add_lbl = new System.Windows.Forms.Label();
            this.mob_lbl = new System.Windows.Forms.Label();
            this.nm_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.show_btn);
            this.panel1.Controls.Add(this.next_btn);
            this.panel1.Controls.Add(this.res_lbl);
            this.panel1.Controls.Add(this.add_txt);
            this.panel1.Controls.Add(this.mob_txt);
            this.panel1.Controls.Add(this.nm_txt);
            this.panel1.Controls.Add(this.add_lbl);
            this.panel1.Controls.Add(this.mob_lbl);
            this.panel1.Controls.Add(this.nm_lbl);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 425);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // show_btn
            // 
            this.show_btn.Location = new System.Drawing.Point(369, 367);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(88, 39);
            this.show_btn.TabIndex = 4;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(235, 367);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(88, 39);
            this.next_btn.TabIndex = 5;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // res_lbl
            // 
            this.res_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.res_lbl.Location = new System.Drawing.Point(415, 27);
            this.res_lbl.Name = "res_lbl";
            this.res_lbl.Size = new System.Drawing.Size(304, 333);
            this.res_lbl.TabIndex = 2;
            this.res_lbl.Text = "result";
            // 
            // add_txt
            // 
            this.add_txt.Location = new System.Drawing.Point(181, 163);
            this.add_txt.Name = "add_txt";
            this.add_txt.Size = new System.Drawing.Size(190, 26);
            this.add_txt.TabIndex = 3;
            // 
            // mob_txt
            // 
            this.mob_txt.Location = new System.Drawing.Point(181, 118);
            this.mob_txt.Name = "mob_txt";
            this.mob_txt.Size = new System.Drawing.Size(190, 26);
            this.mob_txt.TabIndex = 2;
            // 
            // nm_txt
            // 
            this.nm_txt.Location = new System.Drawing.Point(181, 65);
            this.nm_txt.Name = "nm_txt";
            this.nm_txt.Size = new System.Drawing.Size(190, 26);
            this.nm_txt.TabIndex = 1;
            // 
            // add_lbl
            // 
            this.add_lbl.AutoSize = true;
            this.add_lbl.Location = new System.Drawing.Point(68, 169);
            this.add_lbl.Name = "add_lbl";
            this.add_lbl.Size = new System.Drawing.Size(68, 20);
            this.add_lbl.TabIndex = 0;
            this.add_lbl.Text = "Address";
            // 
            // mob_lbl
            // 
            this.mob_lbl.AutoSize = true;
            this.mob_lbl.Location = new System.Drawing.Point(68, 124);
            this.mob_lbl.Name = "mob_lbl";
            this.mob_lbl.Size = new System.Drawing.Size(55, 20);
            this.mob_lbl.TabIndex = 0;
            this.mob_lbl.Text = "Mobile";
            // 
            // nm_lbl
            // 
            this.nm_lbl.AutoSize = true;
            this.nm_lbl.Location = new System.Drawing.Point(68, 65);
            this.nm_lbl.Name = "nm_lbl";
            this.nm_lbl.Size = new System.Drawing.Size(51, 20);
            this.nm_lbl.TabIndex = 0;
            this.nm_lbl.Text = "Name";
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Company";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Company_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label add_lbl;
        private System.Windows.Forms.Label mob_lbl;
        private System.Windows.Forms.Label nm_lbl;
        private System.Windows.Forms.Label res_lbl;
        private System.Windows.Forms.TextBox add_txt;
        private System.Windows.Forms.TextBox mob_txt;
        private System.Windows.Forms.TextBox nm_txt;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Button next_btn;
    }
}