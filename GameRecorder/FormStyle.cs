using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecorder
{
    public class FormStyle
    {
        private int m_index;
        public FormStyle(int indexForm)
        {
            m_index = indexForm;
        }

        public void Show(Item content, Home h, string name)
        {
            switch (m_index)
            {
                case 1:
                    Style1Form rForm1 = new Style1Form(content, h, name);
                    rForm1.Show();
                    break;
                case 2:
                    Style2Form rForm2 = new Style2Form(content, h, name);
                    rForm2.Show();
                    break;
                case 3:
                    Style3Form rForm3 = new Style3Form(content, h, name);
                    rForm3.Show();
                    break;
            }
        }
    }
}
