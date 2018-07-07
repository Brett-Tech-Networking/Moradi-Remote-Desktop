using System;
using MSTSCLib;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moradi_Remote_Desktop
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        // paint 

        public Point current = new Point();
        public Point old = new Point();
        public TextBox t = new TextBox();
        public Pen p = new Pen(Color.Red, 5);
        public Graphics g;
        public Form1()
        {
            InitializeComponent();

            g = remote.CreateGraphics();
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            // Enable drag-and-drop operations and 
            // add handlers for DragEnter and DragDrop.
            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(this.Form1_Load);
            this.DragEnter += new DragEventHandler(this.Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Connect_Click(object sender, EventArgs e)
        {

        }

        private void Connect_Click_1(object sender, EventArgs e)
        {
            try
            {
                remote.Server = hostiptextbox.Text;
                remote.UserName = usertextbox.Text;
                
                IMsTscNonScriptable secured = (IMsTscNonScriptable)remote.GetOcx();
                secured.ClearTextPassword = passwordtextbox.Text;
                remote.Connect();
            }
            catch
            {
                label4.Text = "Connection Status: ERROR";
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            try
            {


                if (remote.Connected.ToString() == "1")
                    remote.Disconnect();
            }
            catch
            {
                //
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void usertextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    }

