﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalManagement
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void customerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer Cust = new AddCustomer();
            Cust.MdiParent = this;
            Cust.Show();
        }

        private void addNewVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVideo frm = new AddVideo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void issueReturnVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentalReturnVideo frm = new RentalReturnVideo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void regularCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerList frm = new CustomerList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void popularVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopularVideo frm = new PopularVideo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VideoRentalManagement_Load(object sender, EventArgs e)
        {
            AddCustomer Cust = new AddCustomer();
            Cust.MdiParent = this;
            Cust.Show();
        }

        private void toolStripDashBoard_Click(object sender, EventArgs e)
        {
            AddCustomer Cust = new AddCustomer();
            Cust.MdiParent = this;
            Cust.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            AddVideo frm = new AddVideo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripCustomers_Click(object sender, EventArgs e)
        {
            RentalReturnVideo frm = new RentalReturnVideo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripPOS_Click(object sender, EventArgs e)
        {
            CustomerList frm = new CustomerList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            PopularVideo frm = new PopularVideo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
