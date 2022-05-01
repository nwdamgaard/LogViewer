using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using Microsoft.VisualBasic.FileIO;

namespace LogViewer
{
    public delegate void FileLoaded();

    class LoadedLog
    {
        public static event FileLoaded LoadedFile;

        public static Dictionary<string, List<float>> log;
        public static string[] columns;

        public static void loadFile(string path)
        {
            log = new Dictionary<string, List<float>>();
            List<string> name_lookup = new List<string>();

            using (TextFieldParser parser = new TextFieldParser(path, Encoding.Default))
            {
                parser.TextFieldType = FieldType.Delimited;

                string separator = Properties.Settings.Default.csv_delimeter;
                if(separator.Equals(""))
                {
                    separator = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
                }

                parser.SetDelimiters(separator);
                //create columns
                string[] col_names = parser.ReadFields();
                foreach(string name in col_names)
                {
                    log.Add(name, new List<float>());
                    name_lookup.Add(name);
                }

                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    for(int i = 0; i < fields.Length; i++)
                    {
                        log[name_lookup[i]].Add(float.Parse(fields[i]));
                    }
                }
            }

            columns = name_lookup.ToArray();

            Console.WriteLine("Opened file: " + path);

            LoadedFile?.Invoke();
        }
    }
}
