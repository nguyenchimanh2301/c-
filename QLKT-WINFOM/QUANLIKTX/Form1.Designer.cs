
namespace QUANLIKTX
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butlogin = new System.Windows.Forms.Button();
            this.butexit = new System.Windows.Forms.Button();
            this.txtus = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRƯỜNG ĐẠI HỌC SƯ PHẠM KĨ THUẬT HƯNG YÊN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QUANLIKTX.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(192, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 247);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // butlogin
            // 
            this.butlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butlogin.Location = new System.Drawing.Point(241, 545);
            this.butlogin.Name = "butlogin";
            this.butlogin.Size = new System.Drawing.Size(158, 57);
            this.butlogin.TabIndex = 2;
            this.butlogin.Text = "Đăng nhập";
            this.butlogin.UseVisualStyleBackColor = true;
            this.butlogin.Click += new System.EventHandler(this.butlogin_Click);
            // 
            // butexit
            // 
            this.butexit.Location = new System.Drawing.Point(449, 545);
            this.butexit.Name = "butexit";
            this.butexit.Size = new System.Drawing.Size(146, 57);
            this.butexit.TabIndex = 3;
            this.butexit.Text = "Thoát";
            this.butexit.UseVisualStyleBackColor = true;
            this.butexit.Click += new System.EventHandler(this.butexit_Click);
            // 
            // txtus
            // 
            this.txtus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtus.Location = new System.Drawing.Point(285, 385);
            this.txtus.Name = "txtus";
            this.txtus.Size = new System.Drawing.Size(421, 29);
            this.txtus.TabIndex = 4;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(285, 439);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(423, 29);
            this.txtpass.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tài khoản ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mật khẩu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(892, 667);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtus);
            this.Controls.Add(this.butexit);
            this.Controls.Add(this.butlogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butlogin;
        private System.Windows.Forms.Button butexit;
        private System.Windows.Forms.TextBox txtus;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

