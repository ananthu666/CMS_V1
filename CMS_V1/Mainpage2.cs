using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_V1
{
    public partial class Mainpage2 : Form
    {
        public Mainpage2()
        {
            InitializeComponent();
        }
        bool menuExpanded = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            /*
            if(menuExpanded==false)
            {
                MenuContainer.Height += 10;
                if(MenuContainer.Height>= 207)
                {
                    menuTransition.Stop();
                    menuExpanded = true;
                }
            }
            else
            {
                MenuContainer.Height -= 10;
                if (MenuContainer.Height <= 63)
                {
                    menuTransition.Stop();
                    menuExpanded = false;
                }
            }*/
        }



        private void Mainpage2_Load(object sender, EventArgs e)
        {


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpanded = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                sideBar.Width -= 10;
                if (sideBar.Width <= 57
                    )
                {
                    sidebarExpanded = false;
                    sidebarTransition.Stop();
                   
                }
            }
            else
            {
                sideBar.Width += 10;


                if (sideBar.Width >= 169)
                {
                    sidebarExpanded = true;
                    sidebarTransition.Stop();
                }
            }

        }

        private void sideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_DragOver(object sender, DragEventArgs e)
        {

        }
    }
}
