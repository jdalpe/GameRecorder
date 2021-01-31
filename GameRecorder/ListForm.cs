using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRecorder
{
    public partial class ListForm : UserControl
    {
        private FormStyle m_style;
        public Item[] Items = null;
        private Home m_h;
        private int m_root;
        private string m_name;
        private string m_repo = ".";

        public ListForm(string name, FormStyle style, Home h, int root, string repo)
        {
            InitializeComponent();
            addBtn.Text = "Ajouter " + name;
            m_name = name;
            m_style = style;
            m_h = h;
            m_root = root;
            m_repo = repo;
        }

        public ListBox GetListBox()
        {
            return listBox;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int id = 0;
            
            if (Items == null)
            {
                id = 0;
            }
            else
            {
                id = Items.Length;
            }
            Item i = new Item(id, Item.GetRoot(m_repo, m_root));
            m_style.Show(i, m_h, m_name);
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                int idSearch = int.Parse(listBox.SelectedItem.ToString().Split(':')[0]);

                //Viewer
                m_style.Show(Items[idSearch], m_h, m_name);
            }
        }
    }
}
