
namespace QUANLIKTX.VIEW
{
    partial class CHITIETPHONG
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butthem = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.buttim = new System.Windows.Forms.Button();
            this.butback = new System.Windows.Forms.Button();
            this.txtmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butp = new System.Windows.Forms.Button();
            this.buthd = new System.Windows.Forms.Button();
            this.textvt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(964, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(12, 160);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(118, 42);
            this.butthem.TabIndex = 1;
            this.butthem.Text = "Thêm";
            this.butthem.UseVisualStyleBackColor = true;
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(166, 162);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(99, 39);
            this.butxoa.TabIndex = 2;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(314, 162);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(112, 40);
            this.butsua.TabIndex = 3;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            // 
            // buttim
            // 
            this.buttim.Location = new System.Drawing.Point(456, 162);
            this.buttim.Name = "buttim";
            this.buttim.Size = new System.Drawing.Size(112, 40);
            this.buttim.TabIndex = 3;
            this.buttim.Text = "Tìm Kiếm";
            this.buttim.UseVisualStyleBackColor = true;
            // 
            // butback
            // 
            this.butback.Location = new System.Drawing.Point(614, 162);
            this.butback.Name = "butback";
            this.butback.Size = new System.Drawing.Size(112, 42);
            this.butback.TabIndex = 3;
            this.butback.Text = "Quay lại";
            this.butback.UseVisualStyleBackColor = true;
            this.butback.Click += new System.EventHandler(this.butback_Click);
            // 
            // txtmp
            // 
            this.txtmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmp.Location = new System.Drawing.Point(128, 26);
            this.txtmp.Name = "txtmp";
            this.txtmp.Size = new System.Drawing.Size(230, 26);
            this.txtmp.TabIndex = 4;
            this.txtmp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vị trí ";
            // 
            // butp
            // 
            this.butp.BackColor = System.Drawing.Color.Coral;
            this.butp.Location = new System.Drawing.Point(1010, 281);
            this.butp.Name = "butp";
            this.butp.Size = new System.Drawing.Size(200, 42);
            this.butp.TabIndex = 3;
            this.butp.Text = "Phòng kí túc";
            this.butp.UseVisualStyleBackColor = false;
            this.butp.Click += new System.EventHandler(this.butp_Click);
            // 
            // buthd
            // 
            this.buthd.BackColor = System.Drawing.Color.Cornsilk;
            this.buthd.Location = new System.Drawing.Point(1010, 392);
            this.buthd.Name = "buthd";
            this.buthd.Size = new System.Drawing.Size(200, 42);
            this.buthd.TabIndex = 3;
            this.buthd.Text = "Hóa Đơn phòng";
            this.buthd.UseVisualStyleBackColor = false;
            this.buthd.Click += new System.EventHandler(this.buthd_Click);
            // 
            // textvt
            // 
            this.textvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textvt.Location = new System.Drawing.Point(529, 26);
            this.textvt.Name = "textvt";
            this.textvt.Size = new System.Drawing.Size(249, 26);
            this.textvt.TabIndex = 4;
            this.textvt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CHITIETPHONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 664);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textvt);
            this.Controls.Add(this.txtmp);
            this.Controls.Add(this.buthd);
            this.Controls.Add(this.butp);
            this.Controls.Add(this.butback);
            this.Controls.Add(this.buttim);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CHITIETPHONG";
            this.Text = "CHITIETPHONG";
            this.Load += new System.EventHandler(this.CHITIETPHONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button buttim;
        private System.Windows.Forms.Button butback;
        private System.Windows.Forms.TextBox txtmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butp;
        private System.Windows.Forms.Button buthd;
        private System.Windows.Forms.TextBox textvt;
    }
}