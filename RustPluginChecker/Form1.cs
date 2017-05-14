using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RustPluginChecker
{
    public partial class Form1 : Form
    {
        const string PLUGIN_INFO_FILE = "C:/Users/acous/Desktop/plugin_info.json";
        
        List<RustPlugin> pluginsList = new List<RustPlugin>();
        RustPluginRefList pluginsRefList = new RustPluginRefList();

        List<RustPlugin> errorList = new List<RustPlugin>();
        List<Details> details = new List<Details>();

        public Form1()
        {
            InitializeComponent();

            dataGridShowPlugins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        
        void btnCheck_Click(object sender, EventArgs e)
        {
            pluginsList = new List<RustPlugin>();
            details = new List<Details>();
            errorList = new List<RustPlugin>();

            if(isPluginRefLoaded() && isRconPluginsTextbox())
            {
                MessageBox.Show("Please wait while we check the plugin references.", "Important");

                foreach (string line in tbMultiLine.Lines)
                {
                    string name = "";
                    string version = "";
                    
                    int openBracket = 40;
                    int closingBracket = 41;
                    int doubleQuotes = 34;

                    int bracketCount = 0;
                    int quotesCount = 0;

                    bool skip = false;

                    foreach (char c in line)
                    {
                        int val = (int)c;

                        skip = false;

                        if (val == openBracket || val == closingBracket)
                        {
                            bracketCount++;
                            skip = true;
                        }
                        if (val == doubleQuotes)
                        {
                            quotesCount++;
                            skip = true;
                        }

                        if (bracketCount == 1 && !skip)
                            version += c;

                        if (quotesCount == 1 && !skip)
                            name += c;                  
                    }

                    pluginsList.Add(new RustPlugin(name, version));
                }

                foreach (RustPlugin rp in pluginsList)
                {
                    int count = 0;
                    int index = doesPluginHaveRef(rp.name);

                    progressbar.Maximum = pluginsList.Count;
                    progressbar.Step = 1;

                    if (index != -1)
                    {
                        string url = pluginsRefList.allPluginsRef[index].link;
                        HtmlWeb web = new HtmlWeb();

                        if (url != null)
                        {
                            HtmlAgilityPack.HtmlDocument document = web.Load(url);

                            HtmlAgilityPack.HtmlNode ourNode = document.DocumentNode.SelectSingleNode("//div[@class='secondaryContent']//h3");

                            if (ourNode.InnerHtml.Substring(0, 7).Contains("Version"))
                            {

                                string version = ourNode.InnerHtml.Replace("Version ", "");

                                if (rp.version != version)
                                    details.Add(new Details(rp.name, rp.version, version, pluginsRefList.allPluginsRef[index].link));
                            }
                            else
                                errorList.Add(rp);
                        }
                    }
                    else
                        errorList.Add(rp);

                    progressbar.PerformStep();
                    count++;
                }

                dgError.DataSource = errorList;
                dgError.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgPluginCompare.DataSource = details;
                dgPluginCompare.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        int doesPluginHaveRef(string pluginName)
        {
            int i = 0;

            foreach(PluginRef pr in pluginsRefList.allPluginsRef)
            {
                if(pluginName == pr.name)
                    return i;

                ++i;
            }

            return -1;
        }

        void btnResources_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON FILES | *.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                pluginsRefList = LoadFile(filePath);

                dataGridShowPlugins.DataSource = pluginsRefList.allPluginsRef;

                tbFileLocation.Text = filePath;
            }

            dataGridShowPlugins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        bool isPluginRefLoaded()
        {
            if (pluginsRefList.allPluginsRef != null)
                return true;
            else
            {
                MessageBox.Show("Please locate a valid plugins file.","Important");
                return false;
            }
        }

        bool isRconPluginsTextbox()
        {
            if (tbMultiLine.Text != "")
                return true;
            else
            {
                MessageBox.Show("Please supply the raw text from the oxide console\n" +  
                                "using the 'plugins' command.","Important");
                return false;
            }
        }

        RustPluginRefList LoadFile(String fileNameLocation)
        {
            StreamReader r = new StreamReader(fileNameLocation);
            string json = r.ReadToEnd();

            return JsonConvert.DeserializeObject<RustPluginRefList>(json);
        }

    }//class

}//namespace