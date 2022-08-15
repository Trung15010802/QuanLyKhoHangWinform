using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAcctive(Button button)
        {
            Button[] listButton = new Button[] { iconButtonAdd, iconButtonRemove, iconButtonSearch, iconButtonStats, iconButtonHome };
            for (int i = 0; i < listButton.Length; i++)
            {
                listButton[i].BackColor = new Color();
                if (button == listButton[i])
                    listButton[i].BackColor = Color.DeepSkyBlue;
            }
        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            buttonAcctive(iconButtonAdd);
            openForm(new GUIAdd());
        }

        private void iconButtonRemove_Click(object sender, EventArgs e)
        {
            buttonAcctive(iconButtonRemove);
            openForm(new GUIEdit());

        }

        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            buttonAcctive(iconButtonSearch);
            openForm(new GUISearch());
        }

        private void iconButtonStats_Click(object sender, EventArgs e)
        {
            buttonAcctive(iconButtonStats);
            openForm(new GUIPrint());
        }

        private void openForm(Form childForm)
        {
            if(this.panel4.Controls.Count > 0)
            {
                panel4.Controls.RemoveAt(0);
            }
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            childForm.Show();
            displayData();
        }

        private void iconButtonHome_Click(object sender, EventArgs e)
        {
            buttonAcctive(iconButtonHome);
            openForm(new GUIHome());
        }
        private void displayData()
        {
            Form form = new GUIDatabase();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Add(form);
            form.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
