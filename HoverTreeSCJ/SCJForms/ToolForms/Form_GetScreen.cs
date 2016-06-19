/* 何问起 http://hovertree.com/hovertreescj/ */
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
            FormWindowState h_currentState = MdiParent.WindowState;
            if (checkBox_isHide.Checked)
            {
                //MdiParent.Hide();
                //http://hovertree.com/h/bjaf/de7qg5wd.htm
                this.MdiParent.WindowState = FormWindowState.Minimized;
            }

            //创建图象，保存将来截取的图象
            Bitmap image = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics imgGraphics = Graphics.FromImage(image);
            //设置截屏区域 柯乐义
            imgGraphics.CopyFromScreen(0, 0, 0, 0, new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));
            //保存
            SaveImage(image);

            if (checkBox_isHide.Checked)
            {
                this.MdiParent.WindowState = h_currentState;
               // this.MdiParent.Show();
            }
        }


        //保存图象文件
        private void SaveImage(Image image)
        {
            //http://hovertree.com/h/bjaf/ruwwcg2p.htm
            saveFileDialog_getScreen.FileName = "何问起截图" + DateTime.Now.ToFileTime();
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