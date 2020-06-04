using InterfaceDA.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceDA
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new F1());
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new F2());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new F3());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new F4());
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new F5());
            hideSubMenu();
        }
    }
}
