
namespace QUANLIKTX.VIEW
{
    partial class frmMENU
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
            this.butphongkt = new System.Windows.Forms.Button();
            this.butsv = new System.Windows.Forms.Button();
            this.butback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(320, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ KÍ TÚC XÁ";
            // 
            // butphongkt
            // 
            this.butphongkt.Location = new System.Drawing.Point(325, 196);
            this.butphongkt.Name = "butphongkt";
            this.butphongkt.Size = new System.Drawing.Size(302, 54);
            this.butphongkt.TabIndex = 1;
            this.butphongkt.Text = "QUẢN LÍ PHÒNG KÍ TÚC";
            this.butphongkt.UseVisualStyleBackColor = true;
            this.butphongkt.Click += new System.EventHandler(this.butphongkt_Click);
            // 
            // butsv
            // 
            this.butsv.Location = new System.Drawing.Point(325, 271);
            this.butsv.Name = "butsv";
            this.butsv.Size = new System.Drawing.Size(302, 49);
            this.butsv.TabIndex = 2;
            this.butsv.Text = "QUẢN LÍ SINH VIÊN";
            this.butsv.UseVisualStyleBackColor = true;
            this.butsv.Click += new System.EventHandler(this.butsv_Click);
            // 
            // butback
            // 
            this.butback.Location = new System.Drawing.Point(326, 342);
            this.butback.Name = "butback";
            this.butback.Size = new System.Drawing.Size(302, 44);
            this.butback.TabIndex = 3;
            this.butback.Text = "QUAY LẠI";
            this.butback.UseVisualStyleBackColor = true;
            this.butback.Click += new System.EventHandler(this.butback_Click);
            // 
            // frmMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QUANLIKTX.Properties.Resources.KTX;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.butback);
            this.Controls.Add(this.butsv);
            this.Controls.Add(this.butphongkt);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmMENU";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "MENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butphongkt;
        private System.Windows.Forms.Button butsv;
        private System.Windows.Forms.Button butback;
    }
}