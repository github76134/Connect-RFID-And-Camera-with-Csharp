namespace RFID
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cob_br = new System.Windows.Forms.ComboBox();
            this.cob_com = new System.Windows.Forms.ComboBox();
            this.Btn_huy = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Btn_ketnoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_ghi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ngatkn = new System.Windows.Forms.Button();
            this.btn_chup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cob_camera = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.btn_vao_ra = new System.Windows.Forms.Button();
            this.txt_CR_IP = new System.Windows.Forms.TextBox();
            this.rad_IP = new System.Windows.Forms.RadioButton();
            this.rad_USB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(557, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 318);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trạng thái :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Chưa kết nối";
            // 
            // cob_br
            // 
            this.cob_br.FormattingEnabled = true;
            this.cob_br.Location = new System.Drawing.Point(234, 60);
            this.cob_br.Name = "cob_br";
            this.cob_br.Size = new System.Drawing.Size(121, 21);
            this.cob_br.TabIndex = 3;
            // 
            // cob_com
            // 
            this.cob_com.FormattingEnabled = true;
            this.cob_com.Location = new System.Drawing.Point(232, 31);
            this.cob_com.Name = "cob_com";
            this.cob_com.Size = new System.Drawing.Size(123, 21);
            this.cob_com.TabIndex = 4;
            // 
            // Btn_huy
            // 
            this.Btn_huy.Location = new System.Drawing.Point(361, 58);
            this.Btn_huy.Name = "Btn_huy";
            this.Btn_huy.Size = new System.Drawing.Size(92, 23);
            this.Btn_huy.TabIndex = 6;
            this.Btn_huy.Text = "Đóng kết nối";
            this.Btn_huy.UseVisualStyleBackColor = true;
            this.Btn_huy.Click += new System.EventHandler(this.Btn_huy_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataReceive);
            // 
            // Btn_ketnoi
            // 
            this.Btn_ketnoi.Location = new System.Drawing.Point(361, 29);
            this.Btn_ketnoi.Name = "Btn_ketnoi";
            this.Btn_ketnoi.Size = new System.Drawing.Size(92, 23);
            this.Btn_ketnoi.TabIndex = 5;
            this.Btn_ketnoi.Text = "Kết nối";
            this.Btn_ketnoi.UseVisualStyleBackColor = true;
            this.Btn_ketnoi.Click += new System.EventHandler(this.Btn_ketnoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "COM :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "BRate";
            // 
            // btn_ghi
            // 
            this.btn_ghi.Location = new System.Drawing.Point(459, 31);
            this.btn_ghi.Name = "btn_ghi";
            this.btn_ghi.Size = new System.Drawing.Size(92, 23);
            this.btn_ghi.TabIndex = 9;
            this.btn_ghi.Text = "Mở cửa";
            this.btn_ghi.UseVisualStyleBackColor = true;
            this.btn_ghi.Click += new System.EventHandler(this.btn_ghi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ngatkn
            // 
            this.btn_ngatkn.Location = new System.Drawing.Point(431, 113);
            this.btn_ngatkn.Name = "btn_ngatkn";
            this.btn_ngatkn.Size = new System.Drawing.Size(75, 23);
            this.btn_ngatkn.TabIndex = 15;
            this.btn_ngatkn.Text = "Ngắt kết nối";
            this.btn_ngatkn.UseVisualStyleBackColor = true;
            this.btn_ngatkn.Click += new System.EventHandler(this.btn_ngatkn_Click);
            // 
            // btn_chup
            // 
            this.btn_chup.Location = new System.Drawing.Point(350, 113);
            this.btn_chup.Name = "btn_chup";
            this.btn_chup.Size = new System.Drawing.Size(75, 23);
            this.btn_chup.TabIndex = 14;
            this.btn_chup.Text = "Chụp ảnh ";
            this.btn_chup.UseVisualStyleBackColor = true;
            this.btn_chup.Click += new System.EventHandler(this.btn_chup_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Kết nối";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cob_camera
            // 
            this.cob_camera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_camera.Enabled = false;
            this.cob_camera.FormattingEnabled = true;
            this.cob_camera.Location = new System.Drawing.Point(18, 113);
            this.cob_camera.Name = "cob_camera";
            this.cob_camera.Size = new System.Drawing.Size(232, 21);
            this.cob_camera.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(269, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Đọc dữ liệu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(361, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Ghi Du liệu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "888555222333664@";
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(15, 39);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(168, 20);
            this.txt_ma.TabIndex = 20;
            // 
            // btn_vao_ra
            // 
            this.btn_vao_ra.Location = new System.Drawing.Point(15, 63);
            this.btn_vao_ra.Name = "btn_vao_ra";
            this.btn_vao_ra.Size = new System.Drawing.Size(89, 23);
            this.btn_vao_ra.TabIndex = 21;
            this.btn_vao_ra.Text = "Xe vào";
            this.btn_vao_ra.UseVisualStyleBackColor = true;
            this.btn_vao_ra.Click += new System.EventHandler(this.btn_vao_ra_Click);
            // 
            // txt_CR_IP
            // 
            this.txt_CR_IP.Enabled = false;
            this.txt_CR_IP.Location = new System.Drawing.Point(18, 137);
            this.txt_CR_IP.Name = "txt_CR_IP";
            this.txt_CR_IP.Size = new System.Drawing.Size(232, 20);
            this.txt_CR_IP.TabIndex = 22;
            // 
            // rad_IP
            // 
            this.rad_IP.AutoSize = true;
            this.rad_IP.Location = new System.Drawing.Point(269, 139);
            this.rad_IP.Name = "rad_IP";
            this.rad_IP.Size = new System.Drawing.Size(35, 17);
            this.rad_IP.TabIndex = 23;
            this.rad_IP.Text = "IP";
            this.rad_IP.UseVisualStyleBackColor = true;
            // 
            // rad_USB
            // 
            this.rad_USB.AutoSize = true;
            this.rad_USB.Location = new System.Drawing.Point(310, 140);
            this.rad_USB.Name = "rad_USB";
            this.rad_USB.Size = new System.Drawing.Size(47, 17);
            this.rad_USB.TabIndex = 24;
            this.rad_USB.Text = "USB";
            this.rad_USB.UseVisualStyleBackColor = true;
            this.rad_USB.CheckedChanged += new System.EventHandler(this.rad_USB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 353);
            this.Controls.Add(this.rad_USB);
            this.Controls.Add(this.rad_IP);
            this.Controls.Add(this.txt_CR_IP);
            this.Controls.Add(this.btn_vao_ra);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_ngatkn);
            this.Controls.Add(this.btn_chup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cob_camera);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ghi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_huy);
            this.Controls.Add(this.Btn_ketnoi);
            this.Controls.Add(this.cob_com);
            this.Controls.Add(this.cob_br);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cob_br;
        private System.Windows.Forms.ComboBox cob_com;
        private System.Windows.Forms.Button Btn_huy;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Btn_ketnoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_ghi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ngatkn;
        private System.Windows.Forms.Button btn_chup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cob_camera;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Button btn_vao_ra;
        private System.Windows.Forms.TextBox txt_CR_IP;
        private System.Windows.Forms.RadioButton rad_IP;
        private System.Windows.Forms.RadioButton rad_USB;
    }
}

