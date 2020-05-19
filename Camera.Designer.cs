namespace RFID
{
    partial class Camera
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
            this.cob_camera = new System.Windows.Forms.ComboBox();
            this.btn_ketnoi = new System.Windows.Forms.Button();
            this.btn_chup = new System.Windows.Forms.Button();
            this.btn_ngatkn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cob_camera
            // 
            this.cob_camera.FormattingEnabled = true;
            this.cob_camera.Location = new System.Drawing.Point(71, 28);
            this.cob_camera.Name = "cob_camera";
            this.cob_camera.Size = new System.Drawing.Size(238, 21);
            this.cob_camera.TabIndex = 0;
            // 
            // btn_ketnoi
            // 
            this.btn_ketnoi.Location = new System.Drawing.Point(71, 55);
            this.btn_ketnoi.Name = "btn_ketnoi";
            this.btn_ketnoi.Size = new System.Drawing.Size(75, 23);
            this.btn_ketnoi.TabIndex = 1;
            this.btn_ketnoi.Text = "Kết nối";
            this.btn_ketnoi.UseVisualStyleBackColor = true;
            this.btn_ketnoi.Click += new System.EventHandler(this.btn_ketnoi_Click);
            // 
            // btn_chup
            // 
            this.btn_chup.Location = new System.Drawing.Point(152, 55);
            this.btn_chup.Name = "btn_chup";
            this.btn_chup.Size = new System.Drawing.Size(75, 23);
            this.btn_chup.TabIndex = 2;
            this.btn_chup.Text = "Chụp ảnh ";
            this.btn_chup.UseVisualStyleBackColor = true;
            this.btn_chup.Click += new System.EventHandler(this.btn_chup_Click);
            // 
            // btn_ngatkn
            // 
            this.btn_ngatkn.Location = new System.Drawing.Point(234, 55);
            this.btn_ngatkn.Name = "btn_ngatkn";
            this.btn_ngatkn.Size = new System.Drawing.Size(75, 23);
            this.btn_ngatkn.TabIndex = 3;
            this.btn_ngatkn.Text = "Ngắt kết nối";
            this.btn_ngatkn.UseVisualStyleBackColor = true;
            this.btn_ngatkn.Click += new System.EventHandler(this.btn_ngatkn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "jpg|";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(276, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 163);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 292);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ngatkn);
            this.Controls.Add(this.btn_chup);
            this.Controls.Add(this.btn_ketnoi);
            this.Controls.Add(this.cob_camera);
            this.Name = "Camera";
            this.Text = "Camera";
            this.Load += new System.EventHandler(this.Camera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cob_camera;
        private System.Windows.Forms.Button btn_ketnoi;
        private System.Windows.Forms.Button btn_chup;
        private System.Windows.Forms.Button btn_ngatkn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}