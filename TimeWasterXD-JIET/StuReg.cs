using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using MetroFramework;
using MetroFramework.Forms;

namespace TimeWasterXD_JIET
{
    public partial class StuReg : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial catalog=jdb;UserId=root;password='mangalakshita'");
        private int a = 0;
        string valid = "";
        public StuReg()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
            gender.SelectedIndex = 0;
            category.SelectedIndex = 0;
            religion.SelectedIndex = 0;
            regDate.Text = DateTime.Now.ToLongDateString();
            totalfees.Text = "200000";
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm fm = new MainForm();
            fm.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.tabControl1.SelectTab(1);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(2);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(1);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(3);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(2);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(4);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(3);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(5);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(4);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(6);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(5);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void StuReg_Load(object sender, EventArgs e)
        {

        }

        private void StuReg_KeyDown(object sender, KeyEventArgs e)
        {

            /*if(e.KeyCode == Keys.Back)
            {
                this.Hide();
                MainForm fm = new MainForm();
                fm.Show();
            }    */
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.tabControl1.SelectTab(tabPage1);

            }

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] di = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in di)
            {
                //for text set
                textBox6.Text = file;
                // string fn = getfn(file);
                //for image set
                try
                {
                    pictureBox1.Image = Image.FromFile(file);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception b)
                {
                    MessageBox.Show(b.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = "";
                textBox6.Text = opf.FileName;
                pictureBox1.Image = Image.FromFile(opf.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

     
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (gender.Text == "" || fname.Text == "" || lname.Text == "" || mname.Text == "" || dob.Text == "" )
            {
                MessageBox.Show("Please Fill Out All Fields");
            }
            else
            {
                try
                {

                   // Regexp(@"^([7-9]{1})([0-9]{4})([0-9]{5})$", fname,valid , "Phone Number ");
                   // Regexp(@"^([7-9]{1})([0-9]{4})([0-9]{5})$", mname, valid, "Phone Number ");
                    //Regexp(@"^([7-9]{1})([0-9]{4})([0-9]{5})$", lname, valid, "Phone Number ");
                    Regexp(@"^([a-zA-Z\s]{0,50})$", fname, valid, "First Name");
                    Regexp(@"^([a-zA-Z\s]{0,50})$", mname, valid, "Middle Name");
                    Regexp(@"^([a-zA-Z\s]{0,50})$", lname, valid, "Last Name");
                   Regexp(@"^([a-zA-Z]{2}[0-9]{2}[0-1]{1}[0-9]{2})$", regno, valid, "Registration No.");
                    string rt = regno.Text;
                       
                    int p = regno.Text.Length;
                    MessageBox.Show(p.ToString());
                    rt = rt.Substring(p-3);
                    MessageBox.Show(rt);
                   // string check = l[p - 3] + l[p - 2] + l[p-1];
                    //MessageBox.Show(p);


                    if (Convert.ToInt32(rt)>120)
                    {
                       if( MetroFramework.MetroMessageBox.Show(this," Registration No. is Invalid (Last 3 digits  should  be less than or equal to 120)"," Invalid Registrariton No",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error )==DialogResult.Retry)
                        {
                            regno.Focus();
                        }
                        
                    }
                    else
                    {

                    }
                       
                    Regexp(@"^([0-9]{2}[a-zA-Z]{5}[0-9]{3})$", unrollno, valid, "University Roll No.");
                   // Regexp(@"^([0-1]{1}[0-9]{2})$", classrollno, valid, "University Roll No.");







                    string minority = "";
                    foreach(Control a in panel2.Controls)
                    {
                        if( a is RadioButton)
                        {
                            RadioButton b = (RadioButton)a;
                            if(b.Checked)
                            {
                                minority = b.Text;
                            }
                        }
                    }
                   
                    string query = $"INSERT INTO `student`(`regDate`, `fname`, `mname`, `lname`, `gender`, `dob`, `category`, `religion`, `minority`, `unrollno`) VALUES ('{regDate.Text}','{fname.Text}','{mname.Text}','{lname.Text}','{gender.Text}','{dob.Text}','{category.Text}','{religion.Text}','{minority}','{unrollno.Text}')";
                    con.Open();
                    MySqlCommand cmd2 = new MySqlCommand(query, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();




                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    con.Open();
                    MySqlCommand cmd;
                    cmd = new MySqlCommand("UPDATE student SET picture= @img WHERE `unrollno`='" + unrollno.Text + "'", con);
                    cmd.Parameters.Add("@img", MySqlDbType.LongBlob).Value = img;
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        con.Close();
                        MessageBox.Show("Image Inserted");
                        MessageBox.Show(" You Have Successfully Signed Up This User \"" + fname.Text+" "+lname.Text+" \"");
                    }
                    else
                    {
                        con.Close();
                    }


                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("" + ex.Message + "");
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (unrollno.Text == null )
            {
                MessageBox.Show("please Fill out UserName");
            }
            else
            {
                try
                {
                    try
                    {
                        int i;
                        con.Open();
                        string s = $"SELECT * FROM `student` WHERE `unrollno`='{unrollno.Text}'";
                        MySqlCommand cd = new MySqlCommand(s, con);
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cd);
                        da.Fill(dt);
                        i = Convert.ToInt32(dt.Rows.Count.ToString());
                        textBox6.Text = null;
                        if (i == 0)
                        {
                            MessageBox.Show("No Match Found");
                            con.Close();
                        }
                        else
                        {
                           // MySqlDataReader mdr = cd.ExecuteReader();

                            fname.Text = dt.Rows[0][1].ToString();
                            lname.Text = dt.Rows[0][3].ToString();
                            mname.Text = dt.Rows[0][2].ToString();
                            gender.Text = dt.Rows[0][4].ToString();
                            dob.Text = dt.Rows[0][5].ToString();
                            category.Text = dt.Rows[0][6].ToString();
                            religion.Text = dt.Rows[0][7].ToString();
                            regDate.Text = dt.Rows[0][0].ToString();
                            string minority = dt.Rows[0][8].ToString();

                            foreach(Control a in this.panel2.Controls)
                            {
                                if( a is RadioButton)
                                {
                                    RadioButton b = (RadioButton)a;
                                    if(b.Text==minority)
                                    {
                                        b.Checked = true; 
                                    }
                                    else
                                    {
                                        b.Checked = false;
                                    }
                                }
                            }

                            try
                            {
                                byte[] img = (byte[])dt.Rows[0][10];
                                MemoryStream ms = new MemoryStream(img);
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                            catch
                            {
                                con.Close();
                            }

                            da.Dispose();
                            con.Close();

                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception s)
                {
                    con.Close();
                    MessageBox.Show(s.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            foreach (Control c in this.tabControl1.Controls )
            {
                if( c is TextBox)
                {
                    c.Text = "";
                }  
                if(c is DateTimePicker)
                {
                    c.Text = null;
                }
                if(c is RadioButton)
                {
                    RadioButton b = (RadioButton)c;
                    b.Checked = false;
                }
                if(c is ComboBox)
                {
                    ComboBox b = (ComboBox)c;
                    b.SelectedItem = null;
                }




            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM `student` WHERE `unrollno`='{unrollno.Text}'";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);               
            }
             

            button5_Click(sender, e);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (unrollno.Text == "" )
            {
                MessageBox.Show("Please Fill Out All Fields");
            }
            else
            {
                try
                {
                    string minority = "";
                    foreach (Control a in panel2.Controls)
                    {
                        if (a is RadioButton)
                        {
                            RadioButton b = (RadioButton)a;
                            if (b.Checked)
                            {
                                minority = b.Text;
                            }
                        }
                    }
                    con.Open();
                    string query = $"UPDATE `student` SET `regDate`='{regDate.Text}',`fname`='{fname.Text}',`mname`='{mname.Text}',`lname`='{lname.Text}',`gender`='{gender.Text}',`dob`='{dob.Text}',`category`='{category.Text}',`religion`='{religion.Text}',`minority`= '{minority}'  WHERE `unrollno`='{unrollno.Text}' ";
                    MySqlCommand cmd2 = new MySqlCommand(query, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();

                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();


                    con.Open();
                    MySqlCommand cmd;
                    cmd = new MySqlCommand($"UPDATE student SET picture= @img WHERE `unrollno`='{unrollno.Text}'", con);
                    cmd.Parameters.Add("@img", MySqlDbType.LongBlob).Value = img;
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Image Updated");
                    }
                    con.Close();
                    MessageBox.Show("" + unrollno.Text + ", This Student Details is Updated Successfully");

                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("" + ex.Message + "");
                }
            }

        }

        private void feespaid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)

            {
                string str ;
                str = null;
                totalfees.Text= totalfees.Text.Replace(",", str).ToString();
                feespaid.Text = feespaid.Text.Replace(",", str).ToString();

                if (totalfees.Text==null)
                {
                    //do nothing
                }
                else if(  Convert.ToInt64( totalfees.Text) >  Convert.ToInt64( feespaid.Text))
                {
                    // then
                   Int64 a = Convert.ToInt64(totalfees.Text) - Convert.ToInt64(feespaid.Text);
                    label57.Text = string.Format("{0:n0}", a);
                    label57.Text = label57.Text + " RS";
                    feespaid.Text = string.Format("{0:n0}", Convert.ToInt64(feespaid.Text));
                    totalfees.Text = string.Format("{0:n0}", Convert.ToInt64(totalfees.Text));
                   
                }
            }
        }

        private void feesdue_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void feesdue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // string a = StringFormat();
          
            char ch = e.KeyChar;

            if (e.KeyChar == (char)Keys.Enter)
            {
               //don nothing

            }
            else if(e.KeyChar==(char)Keys.Back)
            {
                //don nothing 
            }
            else if(e.KeyChar==(char)Keys.Tab)
            {
                
            }
            else if (!char.IsDigit(ch))    
            {

                e.Handled = true;
                MessageBox.Show("enter valid input (integers)");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(class1.SelectedItem.ToString()=="Other")
            {
                course.SelectedIndex = 0;
                year.SelectedIndex = 0;
                year.Enabled = true;
                course.Enabled = true;

            }
            else
            {
                //DO NOTHING
               
                year.Enabled = false;
                course.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(course.SelectedItem.ToString()== "B.Tech")
            {
                year.Items.Clear();
                year.Items.AddRange(new object[] { "I" ,"II","III","IV"});
                year.SelectedIndex = 0;
            }
            else if(course.SelectedItem.ToString()== "M.Tech" || course.SelectedItem.ToString() == "MBA")
            {
                year.Items.Clear();
                year.Items.AddRange(new object[] { "I", "II" });
                year.SelectedIndex = 0;
            }
            else if (course.SelectedItem.ToString()== "B.Sc.(Nursing)")
            {
                year.Items.Clear();
                year.Items.AddRange(new object[] { "I","II","III","IV","V"});
                year.SelectedIndex = 0;
            }


        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void country_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(country.SelectedItem.ToString()=="Other")
            {
                country.DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                country.DropDownStyle = ComboBoxStyle.DropDownList;
                state.Items.Clear();
                int a = country.SelectedIndex;
                //con.Open();

                //string query = $"SELECT from country  where index ='{a}'";
                
                //state.Items.AddRange(new object[] { "I", "II", "III", "IV", "V" });
                //state.SelectedIndex = 0;

            }
        }

        private void state_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (state.SelectedItem.ToString() == "Other")
            {
                state.DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                state.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void city_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (city.SelectedItem.ToString() == "Other")
            {
                city.DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                city.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }



        public void Regexp(string re, TextBox tb, string lbl, string s)
        {
            Regex regex = new Regex(re);

            if (regex.IsMatch(tb.Text))
            {
                lbl = "valid";
            }
            else
            {

               if( MetroFramework.MetroMessageBox.Show(this,s + " is Invalid", "Invalid " + s, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)==DialogResult.Retry);
                {
                    
                    tb.Focus();
                }
              //  if(MetroFramework.MetroMessageBox.Show(this))
                lbl = "invalid";
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(section.SelectedItem.ToString()=="A")
            {
                batch.Items.Clear();
                batch.Items.AddRange(new object[] {"A1","A2","A3" });
            }
           else if (section.SelectedItem.ToString() == "B")
            {
                batch.Items.Clear();
                batch.Items.AddRange(new object[] { "B1", "B2", "B3" });
            }
           else if (section.SelectedItem.ToString() == "C")
            {
                batch.Items.Clear();
                batch.Items.AddRange(new object[] { "C1", "C2", "C3" });
            }
           else if (section.SelectedItem.ToString() == "D")
            {
                batch.Items.Clear();
                batch.Items.AddRange(new object[] { "D1", "D2", "D3" });
            }
           else if (section.SelectedItem.ToString() == "E")
            {
                batch.Items.Clear();
                batch.Items.AddRange(new object[] { "E1", "E2", "E3" });
            }
            else if (section.SelectedItem.ToString() == "K")
            {
                batch.Items.Clear();
                batch.Items.AddRange(new object[] { "K1", "K2", "K3" });
            }
            else
            {
                batch.Items.Clear();
                batch.Items.AddRange(new object[] {"1","2","3" });
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.AliceBlue;
            pictureBox15.BackColor = Color.AliceBlue;
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.SkyBlue;
            pictureBox15.BackColor = Color.SkyBlue;
        }
      
      

        private void button3_MouseHover_1(object sender, EventArgs e)
        {

            button3.BackColor = Color.AliceBlue;
            pictureBox3.BackColor = Color.AliceBlue;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {

            button3.BackColor = Color.SkyBlue;
            pictureBox3.BackColor = Color.SkyBlue;
        }

        private void pictureBox16_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.AliceBlue;
            pictureBox16.BackColor = Color.AliceBlue;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.SkyBlue;
            pictureBox16.BackColor = Color.SkyBlue;

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.AliceBlue;
            pictureBox17.BackColor = Color.AliceBlue;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.SkyBlue;
            pictureBox17.BackColor = Color.SkyBlue;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.AliceBlue;
            pictureBox18.BackColor = Color.AliceBlue;
        }

        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.SkyBlue;
            pictureBox18.BackColor = Color.SkyBlue;
        }

        private void regno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(char.IsLower(ch))
            {
                
            }
           
            regno.Text.ToUpper();
        }

        private void regno_TextChanged(object sender, EventArgs e)
        {
            regno.Text.ToUpper();
        }

        private void regno_KeyUp(object sender, KeyEventArgs e)
        {
           
                }

        private void regno_KeyDown(object sender, KeyEventArgs e)
        {

            

        }
    }
}


        /*Regexp(@"^([\w]+)@([\w]+)\.([\w]+)$", mail, lbl, "E-Mail ");
                Regexp(@"^([7-9]{1})([0-9]{4})([0-9]{5})$", phone, lbl, "Phone Number ");
                Regexp(@"^([][0-1]{1})([0-9]{2})$", age, lbl, "Age "); */