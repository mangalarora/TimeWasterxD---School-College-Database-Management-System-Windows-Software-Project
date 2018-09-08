using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Media;
using System.IO;
using MySql.Data.MySqlClient;
namespace TimeWasterXD_JIET
{
    public partial class MainForm : MetroForm
    {



        SoundPlayer sn = new SoundPlayer(Properties.Resources.dustyroom_multimedia_select_digital_button);
         
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem tileItem5;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraEditors.TileItem tileItem7;
        private DevExpress.XtraEditors.TileItem tileItem8;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem10;
        private DevExpress.XtraEditors.TileItem tileItem6;
        private DevExpress.XtraEditors.TileItem tileItem9;
        private DevExpress.XtraEditors.TileItem tileItem11;
        private DevExpress.XtraEditors.TileItem tileItem12;
        private System.Timers.Timer timer1;
        private Label label2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox8;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileItem tileItem13;
        private DevExpress.XtraEditors.TileItem tileItem14;
        private DevExpress.XtraEditors.TileItem tileItem15;
        private DevExpress.XtraEditors.TileItem tileItem16;
        private DevExpress.XtraEditors.TileItem tileItem17;
        private DevExpress.XtraEditors.TileItem tileItem18;
        private Panel sidePanel;
        private Label label1;
        private PictureBox loginBtn;
        private TextBox pass;
        private TextBox uname;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private Panel panel1;
        private PictureBox pictureBox6;
        private Label label3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox7;
        private Label label4;
        private Panel panel2;
        private CheckBox checkBox1;
        private PictureBox pictureBox9;
        private Label label5;
        private Panel panel3;
        private DevExpress.XtraEditors.TileControl midPanel;


        public MainForm()
        {
            InitializeComponent();
            sn.Load();
            
            
          
        }
        
                            
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void InitializeComponent()
        {
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement13 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement14 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement15 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement16 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement17 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement18 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.midPanel = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem10 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem6 = new DevExpress.XtraEditors.TileItem();
            this.tileItem14 = new DevExpress.XtraEditors.TileItem();
            this.tileItem17 = new DevExpress.XtraEditors.TileItem();
            this.tileItem13 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.tileItem8 = new DevExpress.XtraEditors.TileItem();
            this.tileItem7 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem9 = new DevExpress.XtraEditors.TileItem();
            this.tileItem15 = new DevExpress.XtraEditors.TileItem();
            this.tileItem16 = new DevExpress.XtraEditors.TileItem();
            this.tileItem18 = new DevExpress.XtraEditors.TileItem();
            this.tileItem12 = new DevExpress.XtraEditors.TileItem();
            this.tileItem11 = new DevExpress.XtraEditors.TileItem();
            this.timer1 = new System.Timers.Timer();
            this.label2 = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.PictureBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.uname = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSize = true;
            this.panelControl1.Controls.Add(this.pictureBox8);
            this.panelControl1.Controls.Add(this.midPanel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(274, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(888, 483);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Speed_96;
            this.pictureBox8.Location = new System.Drawing.Point(656, 16);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(48, 47);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 4;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            this.pictureBox8.WaitOnLoad = true;
            // 
            // midPanel
            // 
            this.midPanel.AllowItemHover = true;
            this.midPanel.AppearanceGroupHighlighting.HoveredMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.midPanel.AppearanceGroupHighlighting.HoveredMaskOpacity = 60;
            this.midPanel.AppearanceGroupHighlighting.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.midPanel.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkGray;
            this.midPanel.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.White;
            this.midPanel.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.midPanel.AppearanceItem.Normal.Options.UseBackColor = true;
            this.midPanel.AppearanceItem.Normal.Options.UseForeColor = true;
            this.midPanel.AppearanceText.BackColor = System.Drawing.Color.DarkGray;
            this.midPanel.AppearanceText.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.midPanel.AppearanceText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.midPanel.AppearanceText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.midPanel.AppearanceText.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.midPanel.AppearanceText.Options.UseBackColor = true;
            this.midPanel.AppearanceText.Options.UseBorderColor = true;
            this.midPanel.AppearanceText.Options.UseForeColor = true;
            this.midPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.midPanel.ContextButtonOptions.AnimationType = DevExpress.Utils.ContextAnimationType.SequenceAnimation;
            this.midPanel.ContextButtonOptions.BottomPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.midPanel.ContextButtonOptions.CenterPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.midPanel.ContextButtonOptions.FarPanelColor = System.Drawing.Color.Fuchsia;
            this.midPanel.ContextButtonOptions.NearPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.midPanel.ContextButtonOptions.TopPanelColor = System.Drawing.Color.Purple;
            this.midPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Groups.Add(this.tileGroup2);
            this.midPanel.Groups.Add(this.tileGroup1);
            this.midPanel.Groups.Add(this.tileGroup4);
            this.midPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.midPanel.ItemBorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Always;
            this.midPanel.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.Single;
            this.midPanel.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.RandomSegmentedFade;
            this.midPanel.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.midPanel.Location = new System.Drawing.Point(2, 2);
            this.midPanel.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.midPanel.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.midPanel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.midPanel.LookAndFeel.UseWindowsXPTheme = true;
            this.midPanel.MaxId = 22;
            this.midPanel.Name = "midPanel";
            this.midPanel.OptionsAdaptiveLayout.ScrollMode = DevExpress.XtraEditors.TileControlAdaptiveLayoutScrollMode.ItemScrolling;
            this.midPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.midPanel.ScrollButtonFadeAnimationTime = 900;
            this.midPanel.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.midPanel.SelectionColor = System.Drawing.Color.MidnightBlue;
            this.midPanel.ShowText = true;
            this.midPanel.Size = new System.Drawing.Size(884, 479);
            this.midPanel.TabIndex = 1;
            this.midPanel.Text = "Dashboard";
            this.midPanel.Visible = false;
            this.midPanel.Click += new System.EventHandler(this.tileControl1_Click);
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem10);
            this.tileGroup2.Items.Add(this.tileItem2);
            this.tileGroup2.Items.Add(this.tileItem6);
            this.tileGroup2.Items.Add(this.tileItem14);
            this.tileGroup2.Items.Add(this.tileItem17);
            this.tileGroup2.Items.Add(this.tileItem13);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItem10
            // 
            this.tileItem10.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem10.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem10.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(184)))), ((int)(((byte)(254)))));
            this.tileItem10.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tileItem10.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem10.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem10.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem10.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement1.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_News_96;
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement1.Text = "Notice Board";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem10.Elements.Add(tileItemElement1);
            this.tileItem10.Id = 11;
            this.tileItem10.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem10.Name = "tileItem10";
            // 
            // tileItem2
            // 
            this.tileItem2.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem2.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(124)))), ((int)(((byte)(197)))));
            this.tileItem2.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tileItem2.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem2.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem2.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem2.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement2.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Class_96;
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement2.Text = "Class Routine";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem2.Elements.Add(tileItemElement2);
            this.tileItem2.Id = 10;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem2.Name = "tileItem2";
            // 
            // tileItem6
            // 
            this.tileItem6.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem6.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem6.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.tileItem6.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Navy;
            this.tileItem6.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem6.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tileItem6.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem6.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem6.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem6.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement3.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Calendar_96;
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement3.Text = "Academic Calendar";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem6.Elements.Add(tileItemElement3);
            this.tileItem6.Id = 12;
            this.tileItem6.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem6.Name = "tileItem6";
            // 
            // tileItem14
            // 
            this.tileItem14.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem14.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem14.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tileItem14.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tileItem14.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem14.AppearanceItem.Normal.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.tileItem14.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem14.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem14.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem14.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement4.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Hand_With_Pen_962;
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement4.Text = "Examinations";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem14.Elements.Add(tileItemElement4);
            this.tileItem14.Id = 17;
            this.tileItem14.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem14.Name = "tileItem14";
            // 
            // tileItem17
            // 
            this.tileItem17.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem17.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem17.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.tileItem17.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Aqua;
            this.tileItem17.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem17.AppearanceItem.Normal.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.tileItem17.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem17.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem17.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem17.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement5.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_E_Learning_96;
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement5.Text = "Study Material";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem17.Elements.Add(tileItemElement5);
            this.tileItem17.Id = 20;
            this.tileItem17.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem17.Name = "tileItem17";
            // 
            // tileItem13
            // 
            this.tileItem13.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem13.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem13.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.tileItem13.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tileItem13.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem13.AppearanceItem.Normal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tileItem13.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem13.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem13.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem13.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement6.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Book_Shelf_961;
            tileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement6.Text = "Library";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem13.Elements.Add(tileItemElement6);
            this.tileItem13.Id = 16;
            this.tileItem13.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem13.Name = "tileItem13";
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.tileItem3);
            this.tileGroup1.Items.Add(this.tileItem1);
            this.tileGroup1.Items.Add(this.tileItem5);
            this.tileGroup1.Items.Add(this.tileItem4);
            this.tileGroup1.Items.Add(this.tileItem8);
            this.tileGroup1.Items.Add(this.tileItem7);
            this.tileGroup1.Name = "tileGroup1";
            // 
            // tileItem3
            // 
            this.tileItem3.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem3.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(192)))), ((int)(((byte)(203)))));
            this.tileItem3.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tileItem3.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem3.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tileItem3.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem3.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem3.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem3.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement7.Appearance.Normal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement7.Appearance.Normal.Options.UseFont = true;
            tileItemElement7.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Classroom_128;
            tileItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement7.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement7.Text = "Teaching Staff";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem3.Elements.Add(tileItemElement7);
            this.tileItem3.Id = 2;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem3.Name = "tileItem3";
            this.tileItem3.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            // 
            // tileItem1
            // 
            this.tileItem1.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem1.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(183)))), ((int)(((byte)(73)))));
            this.tileItem1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Blue;
            this.tileItem1.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tileItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileItem1.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem1.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem1.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Always;
            this.tileItem1.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.RandomSegmentedFade;
            tileItemElement8.Appearance.Normal.BackColor = System.Drawing.Color.Transparent;
            tileItemElement8.Appearance.Normal.BackColor2 = System.Drawing.Color.Transparent;
            tileItemElement8.Appearance.Normal.BorderColor = System.Drawing.Color.Transparent;
            tileItemElement8.Appearance.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement8.Appearance.Normal.Options.UseBackColor = true;
            tileItemElement8.Appearance.Normal.Options.UseBorderColor = true;
            tileItemElement8.Appearance.Normal.Options.UseFont = true;
            tileItemElement8.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Student_Male_96;
            tileItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement8.ImageBorderColor = System.Drawing.Color.Blue;
            tileItemElement8.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement8.Text = "Student Registration";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem1.Elements.Add(tileItemElement8);
            this.tileItem1.Id = 0;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.tileItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // tileItem5
            // 
            this.tileItem5.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem5.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem5.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(72)))), ((int)(((byte)(152)))));
            this.tileItem5.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Blue;
            this.tileItem5.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem5.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tileItem5.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem5.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem5.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem5.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement9.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Member_96;
            tileItemElement9.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement9.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement9.Text = "Non Teaching Staff";
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem5.Elements.Add(tileItemElement9);
            this.tileItem5.Id = 4;
            this.tileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem5.Name = "tileItem5";
            // 
            // tileItem4
            // 
            this.tileItem4.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem4.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem4.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tileItem4.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tileItem4.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem4.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem4.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem4.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement10.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Checkmark_96;
            tileItemElement10.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement10.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement10.Text = "Student  Daily Attendance";
            tileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem4.Elements.Add(tileItemElement10);
            this.tileItem4.Id = 6;
            this.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem4.Name = "tileItem4";
            // 
            // tileItem8
            // 
            this.tileItem8.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem8.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem8.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tileItem8.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tileItem8.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem8.AppearanceItem.Normal.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.tileItem8.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem8.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem8.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem8.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement11.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Report_Card_96;
            tileItemElement11.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement11.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement11.ImageToTextIndent = 50;
            tileItemElement11.Text = "Report Card";
            tileItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem8.Elements.Add(tileItemElement11);
            this.tileItem8.Id = 8;
            this.tileItem8.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem8.Name = "tileItem8";
            // 
            // tileItem7
            // 
            this.tileItem7.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem7.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem7.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.tileItem7.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tileItem7.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem7.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem7.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem7.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement12.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Attendance_100;
            tileItemElement12.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement12.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement12.Text = "Staff Daily Attendance";
            tileItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem7.Elements.Add(tileItemElement12);
            this.tileItem7.Id = 7;
            this.tileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem7.Name = "tileItem7";
            // 
            // tileGroup4
            // 
            this.tileGroup4.Items.Add(this.tileItem9);
            this.tileGroup4.Items.Add(this.tileItem15);
            this.tileGroup4.Items.Add(this.tileItem16);
            this.tileGroup4.Items.Add(this.tileItem18);
            this.tileGroup4.Items.Add(this.tileItem12);
            this.tileGroup4.Items.Add(this.tileItem11);
            this.tileGroup4.Name = "tileGroup4";
            // 
            // tileItem9
            // 
            this.tileItem9.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem9.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem9.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(192)))), ((int)(((byte)(203)))));
            this.tileItem9.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Red;
            this.tileItem9.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem9.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem9.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem9.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement13.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Bus_96;
            tileItemElement13.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement13.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement13.Text = "Transport";
            tileItemElement13.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem9.Elements.Add(tileItemElement13);
            this.tileItem9.Id = 13;
            this.tileItem9.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem9.Name = "tileItem9";
            // 
            // tileItem15
            // 
            this.tileItem15.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem15.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem15.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(124)))), ((int)(((byte)(197)))));
            this.tileItem15.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tileItem15.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem15.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem15.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem15.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem15.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.RandomSegmentedFade;
            tileItemElement14.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Hostel_100;
            tileItemElement14.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement14.Text = "Hostel";
            tileItemElement14.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem15.Elements.Add(tileItemElement14);
            this.tileItem15.Id = 18;
            this.tileItem15.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem15.Name = "tileItem15";
            // 
            // tileItem16
            // 
            this.tileItem16.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem16.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem16.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray;
            this.tileItem16.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem16.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tileItem16.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem16.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem16.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement15.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Online_Support_96;
            tileItemElement15.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement15.Text = "Frontdesk Enquiry";
            tileItemElement15.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem16.Elements.Add(tileItemElement15);
            this.tileItem16.Id = 19;
            this.tileItem16.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem16.Name = "tileItem16";
            // 
            // tileItem18
            // 
            this.tileItem18.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem18.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem18.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(77)))));
            this.tileItem18.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Blue;
            this.tileItem18.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem18.AppearanceItem.Normal.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tileItem18.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem18.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem18.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem18.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement16.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Debit_Card_96;
            tileItemElement16.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement16.Text = "Payments";
            tileItemElement16.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem18.Elements.Add(tileItemElement16);
            this.tileItem18.Id = 21;
            this.tileItem18.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem18.Name = "tileItem18";
            // 
            // tileItem12
            // 
            this.tileItem12.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem12.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem12.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.tileItem12.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tileItem12.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem12.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem12.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem12.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement17.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Help_96;
            tileItemElement17.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement17.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement17.Text = "Help";
            tileItemElement17.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem12.Elements.Add(tileItemElement17);
            this.tileItem12.Id = 15;
            this.tileItem12.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem12.Name = "tileItem12";
            // 
            // tileItem11
            // 
            this.tileItem11.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.Desktop;
            this.tileItem11.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem11.AppearanceItem.Normal.BackColor = System.Drawing.Color.Coral;
            this.tileItem11.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tileItem11.AppearanceItem.Normal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem11.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem11.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem11.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement18.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Search_96;
            tileItemElement18.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement18.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement18.Text = "Find";
            tileItemElement18.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem11.Elements.Add(tileItemElement18);
            this.tileItem11.Id = 14;
            this.tileItem11.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem11.Name = "tileItem11";
            this.tileItem11.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem11_ItemClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "time";
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.panel1);
            this.sidePanel.Controls.Add(this.label1);
            this.sidePanel.Controls.Add(this.loginBtn);
            this.sidePanel.Controls.Add(this.pass);
            this.sidePanel.Controls.Add(this.uname);
            this.sidePanel.Controls.Add(this.pictureBox3);
            this.sidePanel.Controls.Add(this.pictureBox2);
            this.sidePanel.Controls.Add(this.pictureBox1);
            this.sidePanel.Controls.Add(this.checkBox1);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(20, 30);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(254, 483);
            this.sidePanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 483);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Privacy_Filled_100;
            this.pictureBox9.Location = new System.Drawing.Point(58, 329);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(26, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 6;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.panel3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Location = new System.Drawing.Point(80, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Privacy";
            this.label5.Click += new System.EventHandler(this.panel3_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Settings_96;
            this.pictureBox7.Location = new System.Drawing.Point(58, 292);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(26, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            this.pictureBox7.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            this.pictureBox7.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Location = new System.Drawing.Point(80, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Settings";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            this.label4.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Logout_Rounded_Up_Filled_100;
            this.pictureBox6.Location = new System.Drawing.Point(92, 391);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(66, 60);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.pictureBox6_MouseLeave);
            this.pictureBox6.MouseHover += new System.EventHandler(this.pictureBox6_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hi , Admin";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Help_96;
            this.pictureBox4.Location = new System.Drawing.Point(49, 52);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(152, 147);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(55, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 31);
            this.panel2.TabIndex = 5;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(55, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 29);
            this.panel3.TabIndex = 8;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Admin Panel";
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Login_96;
            this.loginBtn.Location = new System.Drawing.Point(92, 363);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(78, 72);
            this.loginBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginBtn.TabIndex = 5;
            this.loginBtn.TabStop = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            this.loginBtn.MouseLeave += new System.EventHandler(this.loginBtn_MouseLeave);
            this.loginBtn.MouseHover += new System.EventHandler(this.loginBtn_MouseHover);
            // 
            // pass
            // 
            this.pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pass.Location = new System.Drawing.Point(61, 291);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(168, 31);
            this.pass.TabIndex = 4;
            this.pass.Text = "Password";
            // 
            // uname
            // 
            this.uname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uname.Location = new System.Drawing.Point(61, 245);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(168, 31);
            this.uname.TabIndex = 3;
            this.uname.Text = "Username";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Password_96;
            this.pictureBox3.Location = new System.Drawing.Point(19, 285);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_User_96__1_;
            this.pictureBox2.Location = new System.Drawing.Point(19, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Admin_96;
            this.pictureBox1.Location = new System.Drawing.Point(49, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(49, 339);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 18);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Keep Me Logged In";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::TimeWasterXD_JIET.Properties.Resources.icons8_Back_To_80;
            this.pictureBox5.Location = new System.Drawing.Point(23, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(61, 55);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click_1);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.pictureBox5.MouseHover += new System.EventHandler(this.pictureBox5_MouseHover);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1182, 533);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.label2);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            string s = "";
            s += DateTime.Now.ToString("dddd") + " ";
            s += DateTime.Now.ToString("dd-MM-yyyy") + " ";
            s += DateTime.Now.ToString("HH:mm:ss") + " ";
            s += DateTime.Now.ToString("tt");
            label2.Text = s;
        }

       

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

       
       
      

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            sn.Play();
            this.Hide();
            SelectUser fm = new SelectUser();
            fm.Show();
        }

       

      

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_MouseHover(object sender, EventArgs e)
        {
            loginBtn.Image = Properties.Resources.icons8_Login_961;
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.Image = Properties.Resources.icons8_Login_96;
        }
      

        private void loginBtn_Click(object sender, EventArgs e)
        {
            sn.Play();
           
            midPanel.Refresh();
               
                
         
            midPanel.Show();
            midPanel.AnimateArrival = true;

            this.panel1.Show();
            pictureBox8.Show();

        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.icons8_Back_To_96;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.icons8_Back_To_80;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sn.Play();                    
            Application.Exit();
           
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.Untitled_1;
            pictureBox6.BackColor = Color.OrangeRed;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.icons8_Logout_Rounded_Up_Filled_100;
            pictureBox6.BackColor = Color.LightGray;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            sn.Play();
           
            this.panel1.Hide();
            pictureBox8.Hide();
            
            midPanel.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            sn.Play();
            Settings sf = new Settings();
            sf.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            sn.Play();
            Settings sf = new Settings();
            sf.Show();

        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            
            this.label4.ForeColor = Color.Gray;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            
            this.label4.ForeColor = Color.FromArgb(25, 25, 112);
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            sn.Play();
            StuReg sm = new StuReg();
            sm.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            sn.Play();
            Settings sb = new Settings();
            sb.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            sn.Play();
            Privacy pr = new Privacy();
            pr.Show();
        }

        private void tileItem11_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            sn.Play();
            Find fd = new Find();
            fd.Show();
        }
    }
}
