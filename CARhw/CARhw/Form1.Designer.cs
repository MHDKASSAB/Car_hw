namespace CARhw
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.next_btn = new System.Windows.Forms.Button();
            this.show_btn = new System.Windows.Forms.Button();
            this.res_lbl = new System.Windows.Forms.Label();
            this.wheel_txt = new System.Windows.Forms.TextBox();
            this.color_txt = new System.Windows.Forms.TextBox();
            this.mod_txt = new System.Windows.Forms.TextBox();
            this.wheels_lbl = new System.Windows.Forms.Label();
            this.color_lbl = new System.Windows.Forms.Label();
            this.mod_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.next_btn);
            this.panel1.Controls.Add(this.show_btn);
            this.panel1.Controls.Add(this.res_lbl);
            this.panel1.Controls.Add(this.wheel_txt);
            this.panel1.Controls.Add(this.color_txt);
            this.panel1.Controls.Add(this.mod_txt);
            this.panel1.Controls.Add(this.wheels_lbl);
            this.panel1.Controls.Add(this.color_lbl);
            this.panel1.Controls.Add(this.mod_lbl);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 425);
            this.panel1.TabIndex = 0;
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(208, 369);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(132, 34);
            this.next_btn.TabIndex = 5;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // show_btn
            // 
            this.show_btn.Location = new System.Drawing.Point(359, 369);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(132, 34);
            this.show_btn.TabIndex = 4;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // res_lbl
            // 
            this.res_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.res_lbl.Location = new System.Drawing.Point(393, 42);
            this.res_lbl.Name = "res_lbl";
            this.res_lbl.Size = new System.Drawing.Size(363, 313);
            this.res_lbl.TabIndex = 2;
            this.res_lbl.Text = "Results";
            // 
            // wheel_txt
            // 
            this.wheel_txt.Location = new System.Drawing.Point(158, 194);
            this.wheel_txt.Name = "wheel_txt";
            this.wheel_txt.Size = new System.Drawing.Size(172, 26);
            this.wheel_txt.TabIndex = 3;
            // 
            // color_txt
            // 
            this.color_txt.Location = new System.Drawing.Point(158, 151);
            this.color_txt.Name = "color_txt";
            this.color_txt.Size = new System.Drawing.Size(172, 26);
            this.color_txt.TabIndex = 2;
            // 
            // mod_txt
            // 
            this.mod_txt.Location = new System.Drawing.Point(158, 99);
            this.mod_txt.Name = "mod_txt";
            this.mod_txt.Size = new System.Drawing.Size(172, 26);
            this.mod_txt.TabIndex = 1;
            // 
            // wheels_lbl
            // 
            this.wheels_lbl.AutoSize = true;
            this.wheels_lbl.Location = new System.Drawing.Point(59, 200);
            this.wheels_lbl.Name = "wheels_lbl";
            this.wheels_lbl.Size = new System.Drawing.Size(62, 20);
            this.wheels_lbl.TabIndex = 0;
            this.wheels_lbl.Text = "Wheels";
            // 
            // color_lbl
            // 
            this.color_lbl.AutoSize = true;
            this.color_lbl.Location = new System.Drawing.Point(59, 151);
            this.color_lbl.Name = "color_lbl";
            this.color_lbl.Size = new System.Drawing.Size(46, 20);
            this.color_lbl.TabIndex = 0;
            this.color_lbl.Text = "Color";
            // 
            // mod_lbl
            // 
            this.mod_lbl.AutoSize = true;
            this.mod_lbl.Location = new System.Drawing.Point(59, 99);
            this.mod_lbl.Name = "mod_lbl";
            this.mod_lbl.Size = new System.Drawing.Size(52, 20);
            this.mod_lbl.TabIndex = 0;
            this.mod_lbl.Text = "Model";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Label res_lbl;
        private System.Windows.Forms.TextBox wheel_txt;
        private System.Windows.Forms.TextBox color_txt;
        private System.Windows.Forms.TextBox mod_txt;
        private System.Windows.Forms.Label wheels_lbl;
        private System.Windows.Forms.Label color_lbl;
        private System.Windows.Forms.Label mod_lbl;
    }
}

