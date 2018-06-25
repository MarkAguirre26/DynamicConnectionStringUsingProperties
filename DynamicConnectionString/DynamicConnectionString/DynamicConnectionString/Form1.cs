using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DynamicConnectionString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        void get()
        {
            textBox2.Text = Properties.Settings.Default.ConnectionString;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            get();
        }

        private void cmdSet_Click(object sender, EventArgs e)
        {
            /*
           * Steps how to create "ConnectionString" in Properties
           *1. Right click your project in solution explorer
           *2. proceed to   Properties>Setting
           *3. Under the Setting tab put ConnectionString or any name you want.
           *4. Save
           * * */
            Properties.Settings.Default.ConnectionString = textBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void cmdGet_Click(object sender, EventArgs e)
        {
            get();
        }
    }
}
