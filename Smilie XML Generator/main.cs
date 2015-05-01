using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Smilie_XML_Generator
{
    public partial class main : MetroForm
    {
        string XML = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                     "<smilies_export>" + Environment.NewLine +
                     "<smilie_categories />";
        public main()
        {
            InitializeComponent();
            stepDescription.Text =  "Step One:" + Environment.NewLine +
                                    "First and foremost, I need to know where all your smilies are." + Environment.NewLine + Environment.NewLine +
                                    "Don't worry what's in the folder. I'll only search for pngs, jpeg (and jpgs) and gifs.";
        }

        private void openFolderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = smilieFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderPathText.Text = smilieFolder.SelectedPath;

                stepDescription.Text = "Step Two:" + Environment.NewLine +
                                        "Next I need to know the character to split the name at." + Environment.NewLine + Environment.NewLine +
                                        "Example 1: MySmilie.png should split at the '.'" + Environment.NewLine +
                                        "Example 2: MySmilie@x2.png should split at the '@'" + Environment.NewLine + Environment.NewLine +
                                        "Tip: Make sure all your images have go in this format name.extension or name@size.extension";

                twoLabel.Visible = true;
                charText.Visible = true;
                goToStepThree.Visible = true;
            }
        }

        private void goToStepThree_Click(object sender, EventArgs e)
        {
            stepDescription.Text =  "Step Three:" + Environment.NewLine +
                                    "Okay, now I need to know where to put the XML document." + Environment.NewLine + Environment.NewLine +
                                    "Please direct me to the location to save SmilieImport.xml";

            threeLabel.Visible = true;
            xmlFolderPath.Visible = true;
            xmlFolder.Visible = true;
        }

        private void xmlFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = xmlOutput.ShowDialog();
            if (result == DialogResult.OK)
            {
                xmlFolderPath.Text = xmlOutput.SelectedPath;

                stepDescription.Text = "Step Four:" + Environment.NewLine +
                                    "Just put in where the smilies are on your server and bada bing bada boom, you're ready to go." + Environment.NewLine + Environment.NewLine +
                                    "Example: styles/mysmilies/ (it must have the trailing slash)";

                fourLabel.Visible = true;
                serverPathTextBox.Visible = true;
                goButton.Visible = true;
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            stepDescription.Text = "Step Five:" + Environment.NewLine +
                                    "Ready to generate! Just hit that fancy \"Generate XML\" button!";

            generate.Visible = true;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            // Char to split at...
            char[] splitChar = charText.Text.ToCharArray();
            // Smilie Path
            string path = smilieFolder.SelectedPath;
            DirectoryInfo d = new DirectoryInfo(path);
            // XML Output Path
            string xmlPath = xmlOutput.SelectedPath;
            // Server path
            string serverPath = serverPathTextBox.Text;
            // Filter all files to list
            string[] extensions = { ".jpg", ".jpeg", ".png", ".gif" };

            string[] files = Directory.GetFiles(path, "*.*").Where(f => extensions.Contains(new FileInfo(f).Extension.ToLower())).ToArray();
            foreach (string file in files)
            {
                string _name = file.Replace(path + "\\", "");
                string name = _name.Substring(0, _name.IndexOf(charText.Text));
                char[] _title = name.ToCharArray();
                _title[0] = char.ToUpper(_title[0]);
                string title = new string(_title);

                XML += "<smilie title=\"" + title + "\" display_order=\"0\" display_in_editor=\"1\">" + Environment.NewLine +
                        "<image_url>" + serverPath + _name + "</image_url>" + Environment.NewLine +
                        "<sprite_params w=\"18\" h=\"18\"/>" + Environment.NewLine +
                        "<smilie_text>{" + name + "}</smilie_text>" + Environment.NewLine +
                        "</smilie>";
            }

            XML += "</smilies>" + Environment.NewLine +
                    "</smilies_export>";
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@xmlPath + "\\SmilieImport.xml", false))
                {
                    file.Write(XML);
                   
                }

                stepDescription.Text = "XML written! Just upload the images and import the XML file!";
            }
            catch (Exception ex)
            {
                stepDescription.Text = "There was in error when writing your file." + Environment.NewLine + Environment.NewLine + ex;
            }
        }

        private void matthDevLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.matthewh.in");
        }
    }
}
