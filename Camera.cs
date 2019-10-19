using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
/// <summary>
/// /This is class creeated to make the capturing of an image easy, 
/// It uses Aforge video and imaging libraries.
/// 
/// </summary>

namespace iJob2019
{
   public  class CameraCapture
    {
        private FilterInfoCollection CaptureDevices;
        public  VideoCaptureDevice videoSource;
        public PictureBox _picture { get; set; }
        private Timer timer = new Timer()
        {
            Interval = 1000
        };
  
        public CameraCapture(PictureBox pictureBox,ComboBox comboBox)
        {
            try
            {
                _picture = pictureBox;//The picture from the form 
                CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo Device in CaptureDevices)
                {
                    comboBox.Items.Add(Device.Name);


                }
                //  if they are more than two cmaeras, the constructor should always select the second web camera
                if (comboBox.Items.Count != 1)
                {
                    comboBox.SelectedIndex = 1;

                }
                else
                {
                    comboBox.SelectedIndex = 0;
                }

                videoSource = new VideoCaptureDevice();
                videoSource = new VideoCaptureDevice(CaptureDevices[comboBox.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
               
                videoSource.Start();
                timer.Start();
                int counter = 0;
                timer.Tick += (object sender,EventArgs args) =>
                {
                    if (counter==9)
                    {
                        timer.Stop();
                        videoSource.SignalToStop();
                        videoSource.Stop();
                        videoSource.WaitForStop();
                        comboBox.Items.Clear();
                    }
                    counter++;
                };
               
          
                
               
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Camera loading has failed {ex.Message}");
            }
        }

       
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                _picture.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch (Exception)
            {

                MessageBox.Show("There was an error with the camera, please try again");
            }
        }
    }
}
