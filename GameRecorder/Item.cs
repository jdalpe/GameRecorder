using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecorder
{
    public class Item
    {
        // To be easier, an element has always 10.
        public int ELEMENT_STRUTURE = 10;
        public string[] Elements;
        public string Path;
        public string Name;
        public int ID;
        //This is a generic items
        public Item(string text, string path)
        {
            string[] elements = text.Split(Item.SEP, StringSplitOptions.None);
            Elements = elements;
            Name = elements[1];
            ID = int.Parse(elements[0]);
            Path = path;
        }

        public Item(int id, string path)
        {
            //Not complete
            ID = id;
            Path = path;
            Elements = new string[ELEMENT_STRUTURE];
            Elements[0] = id.ToString("0000");
        }

        public static string[] SEP = { "TABLETOPRECORDER" };

        public static Item[] LoadAll(int folder)
        {
            string root = GetRoot(folder);
            // make sure there's a directory
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            string[] files = Directory.GetFiles(root);
            if (files != null && files.Length > 0)
            {
                Item[] retValue = new Item[files.Length];
                for (int i = 0; i < files.Length; i++)
                {
                    retValue[i] = new Item(File.ReadAllText(files[i]), root);
                }
                return retValue;
            }
            return null;
        }

        public static string GetRoot(int id)
        {
            return "./section_" + id.ToString("0000") + "/";
        }

        public override string ToString()
        {
            string retValue = ID.ToString("0000") + SEP[0] + Name;
            for(int i=2; i<Elements.Length; i++)
            {
                retValue += SEP[0] + Elements[i];
            }
            return retValue;
        }

        public void Save()
        {
            File.WriteAllText(Path + ID.ToString("0000") + ".txt", ToString());
        }
        
    }
}
