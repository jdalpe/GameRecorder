using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecorder
{
    class Config
    {
        public string Title { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public string Language { get; set; }
        public string[] Sections { get; set; }
        public FormStyle[] Styles { get; set; }
        public bool Check { get; set; }

        public static string KEY_TITLE = "title";
        public static string KEY_ORGA = "orga";
        public static string KEY_LANGUAGE = "lang";
        public static string KEY_SECTION = "section";



        public Config(string f)
        {
            string[] text = File.ReadAllLines(f);
            // Check for normal structure
            Check = SetTitle(text);
            Check |= SetLang(text);
            Check |= SetOrga(text);
            Check |= SetSections(text);
        }

        private bool SetTitle(string[] lines)
        {
            try
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].ToLower().Contains(KEY_TITLE))
                    {
                        string[] elements = lines[i].Split(':');
                        Title = elements[1];
                        return true;
                    }
                }
            } catch (Exception)
            {

            }
            return false;
        }

        private bool SetOrga(string[] lines)
        {
            try
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].ToLower().Contains(KEY_ORGA))
                    {
                        string[] elements = lines[i].Split(':');
                        Column = int.Parse(elements[1]);
                        Row = int.Parse(elements[2]);
                        return true;
                    }
                }
            }
            catch (Exception)
            {

            }
            return false;
        }

        private bool SetLang(string[] lines)
        {
            try
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].ToLower().Contains(KEY_LANGUAGE))
                    {
                        string[] elements = lines[i].Split(':');
                        Language = elements[1];
                        return true;
                    }
                }
            }
            catch (Exception)
            {

            }
            return false;
        }

        private bool SetSections(string[] lines)
        {
            try
            {
                int nb = 0;
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].ToLower().Contains(KEY_SECTION))
                    {
                        nb++;
                    }
                }

                // get the number
                Sections = new string[nb];
                Styles = new FormStyle[nb];

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].ToLower().Contains(KEY_SECTION))
                    {
                        string[] elements = lines[i].Split(':');
                        int id = int.Parse(elements[1]) - 1;
                        Sections[id] = elements[2];
                        Styles[id] = new FormStyle(int.Parse(elements[3]));

                    }
                }

                if (nb > 0)
                    return true;

            }
            catch (Exception)
            {

            }
            return false;
        }
    }
}
