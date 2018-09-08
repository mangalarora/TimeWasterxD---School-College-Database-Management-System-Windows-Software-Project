using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace TimeWasterXD_JIET
{
      
    public partial class SelectUser : MetroFramework.Forms.MetroForm
    {
        SoundPlayer sn = new SoundPlayer(Properties.Resources.dustyroom_multimedia_select_digital_button);
        
        public SelectUser()
        {
            InitializeComponent();
           
           
            
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            sn.Play();
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show(); 
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            sn.Play();
            
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.icons8_Close_Window_96;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.icons8_Close_Window_Filled_100;

       
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sn.Play();
            
            this.Close();
            Application.Exit();
            
        }
    }
}
