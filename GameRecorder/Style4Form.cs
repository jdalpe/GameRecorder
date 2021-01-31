using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private string m_mediaFile = "";
        
        public Style4Form(Item i, Home h, string name)
        {
            InitializeComponent();
            m_form = h;
            m_item = i;
            this.Text = name;
            nomTB.Text = i.Name;
            informationTB.Text = i.Elements[2];
            m_mediaFile = i.Elements[3];
            Console.WriteLine(m_mediaFile);
            if (File.Exists(m_mediaFile))
            { 
                mediaPB.Image = Image.FromFile(m_mediaFile);
            }
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            m_item.Name = nomTB.Text;
            m_item.Elements[2] = informationTB.Text;
            m_item.Elements[3] = m_mediaFile;
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
                m_mediaFile = openFileDialog.FileName;
                mediaPB.Image = Image.FromFile(m_mediaFile);
            }
        }
    }
}
