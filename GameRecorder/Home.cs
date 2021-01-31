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
    public partial class Home : Form
    {
        private Config m_config;
        private ListForm[] m_listForms;
        private Item[][] m_items;

        private static int xPos = 12;
        private static int yPos = 71;
        private static int xDelta = 10;
        private static int yDelta = 10;

        private string _root = "";


        public Home(string root)
        {
            if (root == null)
            {
                _root = ".";
            }
            else
            {
                _root = root;
            }
            InitializeComponent();

            //Config parser
            m_config = new Config(Path.Combine(_root, "config.txt"));

            //Fill UI
            if (m_config.Check)
            {
                m_items = new Item[m_config.Sections.Length][];
                m_listForms = new ListForm[m_config.Sections.Length];
                for (int i = 0; i < m_config.Sections.Length; i++)
                {
                    m_listForms[i] = new ListForm(m_config.Sections[i], m_config.Styles[i], this, i, _root);
                }

                titleLb.Text = m_config.Title;

                // Fill UI and data on it.
                int id = 0;
                int actualX = xPos;
                int actualY = yPos;
                int maxX = 0;
                int maxY = 0;
                for (int r = 0; r < m_config.Row; r++)
                {
                    for (int c = 0; c < m_config.Column; c++)
                    {
                        if (id < m_listForms.Length)
                        {
                            m_listForms[id].Location = new Point(actualX, actualY);
                            InitListBox(m_listForms[id], id);
                            this.Controls.Add(m_listForms[id]);
                        }
                        actualX += xDelta + m_listForms[0].Size.Width;
                        maxX = Math.Max(maxX, actualX);
                        id++;
                    }
                    actualX = xPos;
                    actualY += yDelta + m_listForms[0].Size.Height;
                    maxY = Math.Max(maxY, actualY);
                }
                maxX += xDelta;
                maxY += yDelta*2;
                this.Size = new Size(Math.Min(1500, maxX), Math.Min(800, maxY));
            }
            else
            {
                titleLb.Text = "Make sure your config.txt is correct.";
            }
        }

        public void Reload()
        {
            for (int i = 0; i < m_listForms.Length; i++)
            {
                InitListBox(m_listForms[i], i);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        //Fill anything
        private void InitListBox(ListForm lf, int folder)
        {
            ListBox lb = lf.GetListBox();
            lb.Items.Clear();
            Item[] genericStruc = Item.LoadAll(_root, folder);
        
            if (genericStruc != null)
            {
                m_items[folder] = new Item[genericStruc.Length];
                for (int i = 0; i < genericStruc.Length; i++)
                {
                    m_items[folder][i] = genericStruc[i];
                    lb.Items.Add(m_items[folder][i].ID + ":" + m_items[folder][i].Name);
                }
                lf.Items = m_items[folder];
            }
            lb.SelectedIndex = lb.Items.Count - 1;
        }

    }
}
