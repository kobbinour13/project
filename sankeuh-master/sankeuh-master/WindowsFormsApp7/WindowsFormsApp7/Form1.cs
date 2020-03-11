using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetActivePanel(dashbord1);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Control"></param>
        public void SetActivePanel(UserControl Control)
        {
            dashbord1.Visible = false;
            task1.Visible = false;
            family1.Visible = false;
            facture1.Visible = false;
            message1.Visible = false;
            calender1.Visible = false;

            Control.Visible = true;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnForum = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnAnnouncement = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.dashbord1 = new WindowsFormsApp7.dashbord();
            this.calender1 = new WindowsFormsApp7.Calender();
            this.task1 = new WindowsFormsApp7.Task();
            this.family1 = new WindowsFormsApp7.family();
            this.message1 = new WindowsFormsApp7.Message();
            this.facture1 = new WindowsFormsApp7.facture();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.Panel1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.PictureBox2);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(267, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1052, 56);
            this.Panel2.TabIndex = 19;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label3.Location = new System.Drawing.Point(33, 16);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 20);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Dashboard";
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox2.ErrorImage = null;
            this.PictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox2.InitialImage")));
            this.PictureBox2.Location = new System.Drawing.Point(963, 4);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(52, 45);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 0;
            this.PictureBox2.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Panel1.Controls.Add(this.btnsettings);
            this.Panel1.Controls.Add(this.btnLogout);
            this.Panel1.Controls.Add(this.pnlStats);
            this.Panel1.Controls.Add(this.Button7);
            this.Panel1.Controls.Add(this.Button8);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.btnForum);
            this.Panel1.Controls.Add(this.btnMessages);
            this.Panel1.Controls.Add(this.btnCourses);
            this.Panel1.Controls.Add(this.btnAnnouncement);
            this.Panel1.Controls.Add(this.btnCalendar);
            this.Panel1.Controls.Add(this.btnDashboard);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(267, 755);
            this.Panel1.TabIndex = 18;
            // 
            // btnsettings
            // 
            this.btnsettings.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.Settings;
            this.btnsettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnsettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnsettings.Location = new System.Drawing.Point(16, 717);
            this.btnsettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(27, 25);
            this.btnsettings.TabIndex = 11;
            this.btnsettings.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnLogout.Location = new System.Drawing.Point(227, 717);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(27, 25);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.pnlStats.Location = new System.Drawing.Point(-1, 199);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(11, 34);
            this.pnlStats.TabIndex = 5;
            // 
            // Button7
            // 
            this.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button7.FlatAppearance.BorderSize = 0;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Button7.Location = new System.Drawing.Point(227, 628);
            this.Button7.Margin = new System.Windows.Forms.Padding(4);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(27, 25);
            this.Button7.TabIndex = 12;
            this.Button7.UseVisualStyleBackColor = false;
            // 
            // Button8
            // 
            this.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button8.FlatAppearance.BorderSize = 0;
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Button8.Location = new System.Drawing.Point(16, 628);
            this.Button8.Margin = new System.Windows.Forms.Padding(4);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(27, 25);
            this.Button8.TabIndex = 11;
            this.Button8.UseVisualStyleBackColor = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label2.Location = new System.Drawing.Point(54, 132);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(107, 13);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Ariana,18 rue X,2080";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label1.Location = new System.Drawing.Point(77, 112);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(68, 16);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Iheb Ayari";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnForum
            // 
            this.btnForum.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnForum.FlatAppearance.BorderSize = 0;
            this.btnForum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnForum.Image = global::WindowsFormsApp7.Properties.Resources.Forum;
            this.btnForum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForum.Location = new System.Drawing.Point(11, 415);
            this.btnForum.Margin = new System.Windows.Forms.Padding(4);
            this.btnForum.Name = "btnForum";
            this.btnForum.Size = new System.Drawing.Size(256, 34);
            this.btnForum.TabIndex = 5;
            this.btnForum.Text = "Manage invoice";
            this.btnForum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnForum.UseVisualStyleBackColor = true;
            this.btnForum.Click += new System.EventHandler(this.btnForum_Click_1);
            // 
            // btnMessages
            // 
            this.btnMessages.FlatAppearance.BorderSize = 0;
            this.btnMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessages.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMessages.Image = global::WindowsFormsApp7.Properties.Resources.Messages;
            this.btnMessages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMessages.Location = new System.Drawing.Point(11, 372);
            this.btnMessages.Margin = new System.Windows.Forms.Padding(4);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(256, 34);
            this.btnMessages.TabIndex = 4;
            this.btnMessages.Text = "    Messages";
            this.btnMessages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMessages.UseVisualStyleBackColor = true;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click_1);
            // 
            // btnCourses
            // 
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCourses.Image = global::WindowsFormsApp7.Properties.Resources.Courses;
            this.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.Location = new System.Drawing.Point(11, 329);
            this.btnCourses.Margin = new System.Windows.Forms.Padding(4);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(256, 34);
            this.btnCourses.TabIndex = 3;
            this.btnCourses.Text = "Family space";
            this.btnCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click_1);
            // 
            // btnAnnouncement
            // 
            this.btnAnnouncement.FlatAppearance.BorderSize = 0;
            this.btnAnnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnouncement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnouncement.Image = global::WindowsFormsApp7.Properties.Resources.Announcement;
            this.btnAnnouncement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnouncement.Location = new System.Drawing.Point(11, 286);
            this.btnAnnouncement.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnouncement.Name = "btnAnnouncement";
            this.btnAnnouncement.Size = new System.Drawing.Size(256, 34);
            this.btnAnnouncement.TabIndex = 2;
            this.btnAnnouncement.Text = "Task management";
            this.btnAnnouncement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnnouncement.UseVisualStyleBackColor = true;
            this.btnAnnouncement.Click += new System.EventHandler(this.btnAnnouncement_Click_1);
            // 
            // btnCalendar
            // 
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalendar.Image = global::WindowsFormsApp7.Properties.Resources.Calendar;
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(11, 242);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(256, 34);
            this.btnCalendar.TabIndex = 1;
            this.btnCalendar.Text = "     Calendar";
            this.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click_1);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDashboard.Image = global::WindowsFormsApp7.Properties.Resources.Dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(11, 199);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(256, 34);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "    Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.dashbord1);
            this.pnlDashboard.Controls.Add(this.calender1);
            this.pnlDashboard.Controls.Add(this.task1);
            this.pnlDashboard.Controls.Add(this.family1);
            this.pnlDashboard.Controls.Add(this.message1);
            this.pnlDashboard.Controls.Add(this.facture1);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(267, 56);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1052, 699);
            this.pnlDashboard.TabIndex = 20;
            // 
            // dashbord1
            // 
            this.dashbord1.Location = new System.Drawing.Point(0, -1);
            this.dashbord1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashbord1.Name = "dashbord1";
            this.dashbord1.Size = new System.Drawing.Size(1052, 699);
            this.dashbord1.TabIndex = 5;
            // 
            // calender1
            // 
            this.calender1.Location = new System.Drawing.Point(0, -2);
            this.calender1.Margin = new System.Windows.Forms.Padding(2);
            this.calender1.Name = "calender1";
            this.calender1.Size = new System.Drawing.Size(1052, 701);
            this.calender1.TabIndex = 4;
            // 
            // task1
            // 
            this.task1.Location = new System.Drawing.Point(0, 0);
            this.task1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(1052, 699);
            this.task1.TabIndex = 3;
            // 
            // family1
            // 
            this.family1.Location = new System.Drawing.Point(0, 0);
            this.family1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.family1.Name = "family1";
            this.family1.Size = new System.Drawing.Size(1052, 699);
            this.family1.TabIndex = 2;
            // 
            // message1
            // 
            this.message1.Location = new System.Drawing.Point(0, 0);
            this.message1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.message1.Name = "message1";
            this.message1.Size = new System.Drawing.Size(1052, 699);
            this.message1.TabIndex = 1;
            // 
            // facture1
            // 
            this.facture1.Location = new System.Drawing.Point(0, 0);
            this.facture1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.facture1.Name = "facture1";
            this.facture1.Size = new System.Drawing.Size(1052, 696);
            this.facture1.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1319, 755);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Name = "Form1";
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }








      

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            pnlStats.Top = btnDashboard.Top;
            pnlStats.Height = btnDashboard.Height;
            Label3.Text = btnDashboard.Text;

            SetActivePanel(dashbord1);

        }

        private void btnCalendar_Click_1(object sender, EventArgs e)
        {
            pnlStats.Top = btnCalendar.Top;
            pnlStats.Height = btnCalendar.Height;
            Label3.Text = btnCalendar.Text;

            SetActivePanel(calender1);

        }

        private void btnAnnouncement_Click_1(object sender, EventArgs e)
        {
            pnlStats.Top = btnAnnouncement.Top;
            pnlStats.Height = btnAnnouncement.Height;
            Label3.Text = btnAnnouncement.Text;


            SetActivePanel(task1);

        }

        private void btnCourses_Click_1(object sender, EventArgs e)
        {
            pnlStats.Top = btnCourses.Top;
            Label3.Text = btnCourses.Text;
            pnlStats.Height = btnCourses.Height;

            SetActivePanel(family1);
        }

        private void btnMessages_Click_1(object sender, EventArgs e)
        {
            pnlStats.Top = btnMessages.Top;
            pnlStats.Height = btnMessages.Height;
            Label3.Text = btnMessages.Text;
            SetActivePanel(message1);

        }

        private void btnForum_Click_1(object sender, EventArgs e)
        {
            pnlStats.Top = btnForum.Top;
            pnlStats.Height = btnForum.Height;
            Label3.Text = btnForum.Text;
            SetActivePanel(facture1);


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
