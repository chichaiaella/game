﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1: Form
    {
       
     
        public Form1()
        {
            InitializeComponent();
           
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.name = txtUserName.Text;
            form2.ShowDialog();
            

      

        }
    }
}
