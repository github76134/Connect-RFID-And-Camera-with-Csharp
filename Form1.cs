using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Xml;
using AForge.Video.DirectShow;
using AForge.Video;

namespace RFID
{
    public partial class Form1 : Form
    {
        string InputData = String.Empty;
        delegate void SetTextCallback(string text);

        private FilterInfoCollection cameras; // số lượng camera kết nối với máy
        private VideoCaptureDevice cam;

        RFID rfid = new RFID();

        public Form1()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            cob_br.Items.AddRange(BaudRate);



            // -----------------------------------------------------------------------------------
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in cameras)
            {
                cob_camera.Items.Add(device.Name); // Lấy tên các cam kết nối với máy tính
            }
            cob_camera.SelectedIndex = 0;
            //-----------------------------------------------------------------------------------

        }

        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            try
            {
                InputData = serialPort1.ReadTo("\r\n");
                //InputData = serialPort1.ReadExisting();
                if (InputData != String.Empty)
                {
                    SetText(InputData);
                }
            }
            catch { }
        }

        

        // 5F FA E1 28
        // lưu mã
        string ma = null;
        private void SetText(string text)
        {
            if (this.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                textBox1.Text = text;
                ma = text;

                NhanMa_RFID(ma);
                XyLy_Data(ma);                    
            }
        }
        string ten_CapMa = "CMM"; // là tên arduino gửi lên đề nghị cấp data mới.
                                  //Kt cổng vào hay ra 1 hay 2
                                  //string data;

        public void NhanMa_RFID(string Data_Input)
        {
            // CMM : Cap ma moi danh cho lay ma tu dong
            // #R# : Mo cong ra
            // #V# : Mo cong vao
            string taoma = TaoMa();
            if (Data_Input.Equals(ten_CapMa))
            {
                txt_ma.Text = taoma;
                serialPort1.WriteLine(taoma);
            }
            Set_ChuyenLang(Data_Input);
            
        }

        public void Set_ChuyenLang(string Data_Input)
        {
            if (Data_Input.Contains("#V#"))
                btn_vao_ra.Text = "Xe ra";
            if (Data_Input.Contains("#R#"))
                btn_vao_ra.Text = "Xe vào";
        }

        public void XyLy_Data(string Data_Input)
        {
            if (Data_Input.Contains('$'))
            {
                string[] CatChuoi = Data_Input.Split('$');
                rfid.Ma = CatChuoi[0];
                rfid.Data = CatChuoi[1];
                Chup_Anh(rfid.Ma, "jpg");    
            }
        }



        private void XyLy_Ma_RFID(string RFID)
        {



            //----------Xe vào----------
            //B1 : Quẹt thẻ chụp hình
            //B2 : Lưu mã thẻ và biển số xe(ảnh chụp biển số và biển số nhận dạng

            //---------Xe ra------------
            //B1 : Quẹt thẻ chụp hình
            //B2 : Lấy mã kiểm tra + biển số
            //if (RFID.Contains(" 5f fa e1 28"))
            //MessageBox.Show(text);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cob_com.DataSource = SerialPort.GetPortNames();
            cob_br.SelectedIndex = 7;
            rad_USB.Checked = true;
        }



        private void Btn_ketnoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = cob_com.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cob_br.Text);
                    try
                    {
                        serialPort1.Open();
                        label5.Text = ("Đã kết nối");

                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại cổng " + serialPort1.PortName, "Cổng " + serialPort1.PortName + " không khả dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Btn_huy_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            label5.Text = ("Chưa kết nối");
        }

        private void btn_ghi_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("M@");
            }
            else
            {
                MessageBox.Show("Vui lòng kết nối với hệ thống xử lý", "Không có kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(rad_USB.Checked == true)
            {

                cam = new VideoCaptureDevice(cameras[cob_camera.SelectedIndex].MonikerString);
                cam.NewFrame += Cam_NewFrame;
                cam.Start();
            }
            if (rad_IP.Checked == true)
            {


                MJPEGStream stream;
                string ip = txt_CR_IP.Text.Trim();
                if (ip.Length > 0)
                {
                    stream = new MJPEGStream("http://" + ip + ":4747/video");
                    stream.NewFrame += Stream_NewFrame;
                    stream.Start();
                }
                else
                {
                    MessageBox.Show("Nhập vào địa chỉ ip hay chọn kết nối USB", "Địa chỉ IP rỗng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bmp;
        }

        private void Cam_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;
        }

        private void btn_chup_Click(object sender, EventArgs e)
        {
            if (ma is null)
            {
                MessageBox.Show("Vui lòng quẹt thẻ trước", "Chưa có mã thẻ trong hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                Chup_Anh(ma, "jpg");
            }

        }

        private void Chup_Anh(string maRFID, string duoiAnh)// đuôi của anh vd : jpg,png,gif,...
        {

            DateTime time = DateTime.Now;
            string tt = time.ToString("-ddmmyyyy-hhmmss");
            string maAnh = maRFID.Replace(" ", "") + tt;
            saveFileDialog1.FileName = Application.StartupPath + "\\anh\\" + maAnh + "." + duoiAnh;
            pictureBox1.Image.Save(saveFileDialog1.FileName);
            pictureBox2.Image = pictureBox1.Image;
        }


        private void btn_ngatkn_Click(object sender, EventArgs e)
        {
            if (cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("D62@");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(textBox2.Text.Trim());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == true)
            //{
            //    serialPort1.WriteLine("V@");
            //    MessageBox.Show("Vào");
            //}
            //else
            //{
            //    serialPort1.WriteLine("R@");
            //    MessageBox.Show("Ra");
            //}
        }

        public string TaoMa()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks) + "@";
        }

        private void btn_vao_ra_Click(object sender, EventArgs e)
        {

            //serialPort1.WriteLine("8");

            //string cc;
            if (btn_vao_ra.Text.Equals("Xe vào"))
            {
                serialPort1.Write("V@");
                //btn_vao_ra.Text = "Xe ra";
            }
            else
            if (btn_vao_ra.Text.Equals("Xe ra"))
            {
                serialPort1.Write("R@");
                //btn_vao_ra.Text = "Xe vào";
                //InputData = serialPort1.ReadTo("\r\n");
                //InputData = serialPort1.ReadExisting();
                //cc = serialPort1.ReadTo("\r\n");
                //if (cc.Equals("@DMR@"))
                //{
                //    MessageBox.Show("Thay đổi thành xe ra", "");
                //    btn_vao_ra.Text = "Xe vào";
                //}
            }


            //cc = serialPort1.ReadTo("\r\n");

            //////SetText(cc);

            //MessageBox.Show(cc);

            //if (cc.Equals("V"))
            //{
            //    MessageBox.Show("Thay đổi thành xe vào", "");
            //    btn_vao_ra.Text = "Xe ra";
            //}
            //else
            //    if (cc.Equals("R"))
            //{
            //    MessageBox.Show("Thay đổi thành xe ra", "");
            //    btn_vao_ra.Text = "Xe vào";
            //}


            //MessageBox.Show("");

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (cam.IsRunning)
                {
                    cam.Stop();
                }
            } catch (Exception ex)
            { }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void rad_USB_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_IP.Checked == true)
            {
                cob_camera.Enabled = false;
                txt_CR_IP.Enabled = true;
                
            }
            else
            {
                cob_camera.Enabled = true;
                txt_CR_IP.Enabled = false;
            }

        }
    }

    public class RFID
    {

        public string Ma;
        public string Data;

    }
}


