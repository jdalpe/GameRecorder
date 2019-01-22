using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRecorder
{
    public partial class Style2Form : Form
    {
        private Item m_item;
        private Home m_form;
        
        public Style2Form(Item i, Home h, string name)
        {
            InitializeComponent();
            m_form = h;
            m_item = i;
            this.Text = name;
            nomTB.Text = i.Name;
            descTB.Text = i.Elements[2];
            dateTB.Text = i.Elements[3];
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            m_item.Name = nomTB.Text;
            m_item.Elements[2] = descTB.Text;
            m_item.Elements[3] = dateTB.Text;
            m_item.Save();
            this.Close();
            m_form.Reload();

        }
    }
}
