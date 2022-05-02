using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms.DataVisualization.Charting;

namespace LogViewer
{
    public delegate void FileLoaded();
    public delegate void UpdateConfig();

    class LogConfig
    {
        public SeriesChartType graphType { get; set; }
        public string xAxisVariable { get; set; }
        public List<yAxisConfig> yAxes { get; set; }
    }

    class LoadedLog
    {
        public static event FileLoaded LoadedFile;
        public static event UpdateConfig RequestUpdateConfig;

        public static Dictionary<string, List<float>> log;
        public static string[] columns;
        public static LogConfig config = new LogConfig();

        public static void saveConfig(string path, Form1 form)
        {
            RequestUpdateConfig?.Invoke();

            string serializedConfig = JsonSerializer.Serialize(config);
            Console.WriteLine(serializedConfig);
            File.WriteAllText(path, serializedConfig);
        }

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
