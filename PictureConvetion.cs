using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iJob2019
{
    public class PictureConvetion
    {
        /// <summary>
        /// ////////This method uses the System.Drawing.Image.Save method to save the image to a memorystream. 
        /// The memorystream can then be used to return a byte array using the ToArray() method in the MemoryStream class.
        /// </summary>
        /// <param name="imageIn"></param>
        /// <returns></returns>
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        /// <summary>
        //This method uses the Image.FromStream method in the Image class to create a method from a memorystream which has been created using a byte array. The image thus created is returned in this method.
        //The way I happen to use this method was to transport an image to a web service, by converting it to a byte array and vice-versa.
        //Hope this class is useful to the community as well.The code of ImageConverter.cs can be downloaded from the link at the top of this article.
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns></returns>
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
    // Rajan Tawate Author
    //https://www.codeproject.com/Articles/15460/C-Image-to-Byte-Array-and-Byte-Array-to-Image-Conv
}
