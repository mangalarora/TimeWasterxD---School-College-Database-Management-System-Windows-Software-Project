using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace TimeWasterXD_JIET
{
    public partial class video : MetroFramework.Forms.MetroForm
    {
        private double i;
        private int j=0;
        public video()
        {
            InitializeComponent();
          
            timer1.Start();
           // this.FormBorderStyle = FormBorderStyle.None;
            //this.Width = pictureBox1.Width;
            //this.Height = pictureBox1.Height;
            /*
            byte[] MYFILE = Properties.Resources._1232;
             Process p = new Process();
             p.StartInfo.FileName = "D:\\1232.mp4";
             p.Start();
             */
            string s = "";
             s += "vid";
            if (File.Exists(Application.StartupPath + "\\" + s + ".mp4"))
            {
                //Do Nothing
            }
            else
            {
                MessageBox.Show("video extracted");
                byte[] myfile = Properties.Resources._1232;
                File.WriteAllBytes(Application.StartupPath + "\\" +s +".mp4", myfile);
                j = 3;
            }
                             
        }
            
        private void video_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if(i==4+j)
            {                
                this.Show();
                
            }
            if(i==8+j)
            {
                this.Hide();
               
                // SelectUser fm = new SelectUser();                
                // fm.Show();     
                this.Close();
            }

        }

        private void axVLCPlugin21_Enter(object sender, EventArgs e)
        {

        }
    }
}
