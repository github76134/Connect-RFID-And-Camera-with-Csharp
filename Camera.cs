using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace RFID
{
    
    public partial class Camera : Form
    {
        private FilterInfoCollection cameras; // số lượng camera kết nối với máy
        private VideoCaptureDevice cam;

        public Camera()
        {
            InitializeComponent();
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in cameras)
            {
                cob_camera.Items.Add(device.Name); // Lấy tên các cam kết nối với máy tính
            }
            cob_camera.SelectedIndex = 0;
        }

        private void Camera_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_ketnoi_Click(object sender, EventArgs e)
        {
            //if(cam.IsRunning)
            //{
            //    DialogResult dg = MessageBox.Show("Camera này hiện đang hoạt động ")
            //}
            //else
            {
                cam = new VideoCaptureDevice(cameras[cob_camera.SelectedIndex].MonikerString);
                cam.NewFrame += Cam_NewFrame;
                cam.Start();
            }
        }
           

        private void Cam_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;
        }

        private void btn_ngatkn_Click(object sender, EventArgs e)
        {
            if(cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void btn_chup_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.InitialDirectory = Application.StartupPath + "\\anh";
            //if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{


            saveFileDialog1.FileName = Application.StartupPath + "\\anh\\anh.jpg";
            pictureBox1.Image.Save(saveFileDialog1.FileName);
            //}
        }
    }
}
