﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coder_s_space
{
    public partial class FormMarketplace : Form
    {
        
        public FormMarketplace()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGitHub_Click(object sender, EventArgs e)
        {
            TaskDetails uc1 = new TaskDetails();
            uc1.Location = new Point(
                (this.ClientSize.Width - uc1.Width) / 2,
                (this.ClientSize.Height - uc1.Height-300) / 2
            );
            this.Controls.Add(uc1);
            uc1.BringToFront();
            uc1.guna2Button4.Click += OnPostClicked;
           

        }


        private void OnPostClicked(object sender, EventArgs e)
        {
            // Get the parent control of the sender button
            Control parent = ((Control)sender).Parent;

            // Cast the parent control to a TaskDetails user control
            TaskDetails taskDetails = parent as TaskDetails;

            
            DateTime clickTime = DateTime.Now;
            if (taskDetails != null)
            {
                FormProfile formP = new FormProfile();
                string userName = formP.UserName; // get the username from FormProfile
                Image userImage = formP.pictureBox3.Image;
                PostTask postTask = new PostTask(taskDetails.TaskPrice,taskDetails.TaskTitle,taskDetails.TaskDescription,userName,userImage,clickTime);
                flowLayoutPanel1.Controls.Add(postTask);
                postTask.BringToFront();
                taskDetails.Dispose();
            }
        }


        public void AddTask(UserControl childForm, FlowLayoutPanel parentPanel)
        {
                    
               /* childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;*/
                childForm.Dock = DockStyle.Top;
                parentPanel.Controls.Add(childForm);
                parentPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                
                // childForm.Size = parentPanel.Size;
                  
        }
    }
}
