using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeWasterXD_JIET
{
    public partial class Find : MetroFramework.Forms.MetroForm
    {
        public Find()
        {
            InitializeComponent();
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
           if (comboBox1.SelectedItem.ToString()=="Student")
            {
                stPanel.Show();
            }
            else
            {
                stPanel.Hide();
            }

            if (comboBox1.SelectedItem.ToString()=="Bus")
            {
                panel3.Show();
            }
            else
            {
                panel3.Hide();
            }

            if(comboBox1.SelectedItem.ToString()=="Hostel" )
            {
                hPanel.Show();
            }
            else
            {
                hPanel.Hide();
            }

            if(comboBox1.SelectedItem.ToString()=="Books")
            {
                panel4.Show();
            }
            else
            {
                panel4.Hide();
            }
            if(comboBox1.SelectedItem.ToString()=="ClassRoutine")
            {
                panel1.Show();
            }
            else
            {
                panel1.Hide();
            }
            if(comboBox1.SelectedItem.ToString()=="")
            {
                panel3.Hide();
                panel4.Hide();
                hPanel.Hide();
                stPanel.Hide();
            }
            else
            {

            }

        }

        private void Find_Load(object sender, EventArgs e)
        {

        }

        private void stPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
