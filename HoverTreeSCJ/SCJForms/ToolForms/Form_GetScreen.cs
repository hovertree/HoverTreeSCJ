using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace HoverTreeSCJ.SCJForms.ToolForms
{
    public partial class Form_GetScreen : Form
    {
        public Form_GetScreen()
        {
            InitializeComponent();
        }

        private void button_getScreen_Click(object sender, EventArgs e)
        {
            if(checkBox_isHide.Checked)
            this.MdiParent.Hide();

            //创建图象，保存将来截取的图象
            Bitmap image = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics imgGraphics = Graphics.FromImage(image);
            //设置截屏区域 柯乐义
            imgGraphics.CopyFromScreen(0, 0, 0, 0, new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));
            //保存
            SaveImage(image);

            if(checkBox_isHide.Checked)
            this.MdiParent.Show();
        }


        //保存图象文件
        private void SaveImage(Image image)
        {
            if (saveFileDialog_getScreen.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = saveFileDialog_getScreen.FileName;
                string extension = Path.GetExtension(fileName);
                if (extension == ".jpg")
                {
                    image.Save(fileName, ImageFormat.Jpeg);
                }
                else
                {
                    image.Save(fileName, ImageFormat.Bmp);
                }
            }
        }
    }
}