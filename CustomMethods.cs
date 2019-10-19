using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iJob2019
{
    public static class CustomMethods
    {
        public static int CalculateAge(string date)

        {
            try
            {
                string[] dob = date.Split('/');
                string[] nowDate = DateTime.Now.ToShortDateString().Split('/');
                return int.Parse(nowDate[2]) - int.Parse(dob[2]);//the years for each date 
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static void DislayNotification(Label label,string message, string color)
        {
        
            label.ForeColor = System.Drawing.Color.FromName(color);
            label.Text = message;
        }

        //Adding and getting the image from the database

        public static void SaveImage(string labId,PictureBox imageOrigin)
        {
            SqlCommand cmd = new SqlCommand("Insert into Image (ID,Image) Values('"+labId+"',@Image)", Database.connection);
           // SqlDataReader dr;
            if (imageOrigin.Image != null)
            {
                MemoryStream ms = new MemoryStream();                
                imageOrigin.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] a = ms.GetBuffer();
                ms.Close();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Image", a);
               
                Database.connection.Open();
                cmd.ExecuteNonQuery();
                Database.connection.Close();
            }
            else
            {
                MessageBox.Show("Image is Null");
            }
        }

        public static void  GetImage(string labId,PictureBox ImageToDisplay)
        {// Retrieve an image i the datbse and dispay it to the picturebox

            try
            {
                if (Database.connection.State!=ConnectionState.Closed)
                {
                   Database.connection.Open();
                }
                SqlCommand cmd = new SqlCommand("Select Image from Image Where ID ='" + labId + "'", Database.connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlCommandBuilder cbd = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Database.connection.Close();
                byte[] ap = (byte[])(ds.Tables[0].Rows[0]["Image"]);
                MemoryStream ms = new MemoryStream(ap);
                ImageToDisplay.Image = Image.FromStream(ms);
                ms.Close();
                if (Database.connection.State == ConnectionState.Open)
                {
                    Database.connection.Close();
                }
            }
            catch (Exception ex)
            {
                if (Database.connection.State != ConnectionState.Closed)
                {
                    Database.connection.Close();
                }
                MessageBox.Show(ex.Message);

            }

        }

    }
}
