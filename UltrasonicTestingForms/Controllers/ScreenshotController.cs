using System.Drawing;
using System.Windows.Forms;

namespace UltrasonicTestingForms.Controllers
{
    public class ScreenshotController
    {
        public Bitmap GetControlScreenshot(Control control)
        {
            //ресайзим контрол до возможного максимума перед скриншотом
            Size szCurrent = control.Size;
            control.AutoSize = true;

            Bitmap bmp = new Bitmap(control.Width, control.Height);//создаем картинку нужных размеров
            control.DrawToBitmap(bmp, control.ClientRectangle);//копируем изображение нужного контрола в bmp

            //возвращаем размер контрола назад
            control.AutoSize = false;
            control.Size = szCurrent;
            return bmp;
        }
    }
}
