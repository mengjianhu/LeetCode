using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //   string filePath = @"C:\Users\humengjian\Desktop\素材\QQ图片20220809100520.png";
            //   Bitmap bitmap = new Bitmap(filePath);
            //string sss= GetBase64String(bitmap);
            //   Console.WriteLine(sss.Length);
            //   File.WriteAllText("111.txt", sss);
            //   Console.WriteLine(sss);
            //   byte[] bb = ImageToByte(bitmap);

            //Image mm=getImageBuf(bb);

            //bitmap.Save("test.png");


            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        public static string GetBase64String(Bitmap image)
        {
            string UserPhoto = "";
            using (MemoryStream ms1 = new MemoryStream())
            {
                image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr1 = new byte[ms1.Length];
                ms1.Position = 0;
                ms1.Read(arr1, 0, (int)ms1.Length);
                ms1.Close();
                UserPhoto = Convert.ToBase64String(arr1);
            }
            return UserPhoto;
        }
        public static byte[] ImageToByte(Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
               
                bitmap.Save(ms, ImageFormat.Bmp);
                byte[] bytes = ms.GetBuffer();
                return bytes;
            }
        }
        public static Image getImageBuf(byte[] buf)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(buf))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
