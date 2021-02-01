using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRecorder
{
    public partial class Style4Form : Form
    {
        private Item m_item;
        private Home m_form;

        
        public Style4Form(Item i, Home h, string name)
        {
            InitializeComponent();
            m_form = h;
            m_item = i;
            this.Text = name;
            nomTB.Text = i.Name;
            informationTB.Text = i.Elements[2];
            mediaTB.Text = i.Elements[3];
            
            if (File.Exists(mediaTB.Text))
            { 
                mediaPB.Image = Image.FromFile(mediaTB.Text);
            }
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            m_item.Name = nomTB.Text;
            m_item.Elements[2] = informationTB.Text;
            m_item.Elements[3] = mediaTB.Text;
            m_item.Save();
            this.Close();
            m_form.Reload();

        }

        private void chercherBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.DefaultExt = "png";
            openFileDialog.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";
            openFileDialog.ShowDialog();

            if (File.Exists(openFileDialog.FileName))
            {
                mediaTB.Text = openFileDialog.FileName;
                mediaPB.Image = Image.FromFile(mediaTB.Text);
            }
        }

        private void locationBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(mediaTB.Text))
            {
                Process.Start("explorer.exe", Path.GetDirectoryName(mediaTB.Text));
            }
        }
    }
}
