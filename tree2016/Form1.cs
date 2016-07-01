using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppl2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            // object Form2;


        //            string ipath1 = "c:\\tmp1\\このみタペ.jpg";
            string ipath1 = "c:\\tmp1\\ぱんちら.jpg";
            /* ぱんちらに変更 */

            // ファイル存在チェックして対応
            if (System.IO.File.Exists(ipath1))
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // 窓に大きさあわせる

                pictureBox1.Load(ipath1);

                /* ここから Form2生成して表示のコード試験 */
                Form2 myform2 = new Form2();

                myform2.Show();
                
                myform2.pictureBoxF2.SizeMode = PictureBoxSizeMode.Zoom; // 窓に大きさあわせる
                myform2.pictureBoxF2.Load(ipath1);

                button1.Text = "おーーけー!";
            }
            else { 
                button1.Text = "いや　ファイルがだめだ!";
            }
        }
    }
   
}
