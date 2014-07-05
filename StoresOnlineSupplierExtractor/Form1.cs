using CsvHelper;
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

namespace StoresOnlineSupplierExtractor
{
    public partial class Form1 : Form
    {
        private List<Supplier> _supplierList;

        public Form1()
        {
            InitializeComponent();

            _supplierList = new List<Supplier>();
            txtInputDir.Text = "C:\\apps\\suppliers";
            txtOutputFile.Text = "C:\\Users\\Matthew\\SkyDrive\\Documents\\Peregrine\\traphappens_suppliers.csv";
        }

        private void btnBrowseInputDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                txtInputDir.Text = folderDlg.SelectedPath;
            }
        }

        private void btnBrowseOutputDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                txtOutputFile.Text = folderDlg.SelectedPath + "\\output.csv";
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            txtResults.Text = "Main screen turn on...";
            logResults("====================================================");

            //Loop through all files in the output folder
            string[] files = Directory.GetFiles(txtInputDir.Text, "*.htm");
            logResults("Found " + files.Length.ToString() + " files to process.");
            foreach (string file in files)
            {
                extractSupplierFromFile(file);
            }

            if (_supplierList.Count() > 0)
            {
                //Write the output file
                writeSuppliersToCsv();

                logResults("====================================================");
                logResults("Extraction finished.");
            }
            else
            {
                //MessageBox.Show("No suppliers found.", "Supplier Extract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logResults("No suppliers found.");
            }
        }

        private void logResults(string strMessage)
        {
            txtResults.Text = txtResults.Text + Environment.NewLine + strMessage;
        }

        private void writeSuppliersToCsv()
        {
            using (StreamWriter writer = new StreamWriter(txtOutputFile.Text, false))
            {
                var csvWriter = new CsvWriter(writer);
                csvWriter.WriteRecords(_supplierList);
            }
        }

        private void extractSupplierFromFile(string filePath)
        {
            string line;
            Supplier supp = new Supplier();

            // Read the file and display it line by line.
            System.IO.StreamReader file = new StreamReader(filePath);
            while((line = file.ReadLine()) != null)
            {
                //company
                if (line.Contains("name=\"company\" id=\"company\""))
                {
                    int start = line.IndexOf("value") + 7;
                    if (start > (-1 + 7))
                    {
                        int length = line.IndexOf("maxlength") - line.IndexOf("value") - 9;
                        supp.Company = clean(line.Substring(start, length));
                    }
                }

                //contact name
                if (line.Contains("name=\"contactname\" id=\"contactname\""))
                {
                    int start = line.IndexOf("value") + 7;
                    if (start > (-1 + 7))
                    {
                        int length = line.IndexOf("type") - line.IndexOf("value") - 9;
                        supp.ContactName = clean(line.Substring(start, length));
                    }
                }

                //address1
                if (line.Contains("name=\"address1\" id=\"address1\""))
                {
                    int start = line.IndexOf("value") + 7;
                    if (start > (-1 + 7))
                    {
                        int length = line.IndexOf("type") - line.IndexOf("value") - 9;
                        supp.Address1 = clean(line.Substring(start, length));
                    }
                }

                //address2
                if (line.Contains("name=\"address2\" id=\"address2\""))
                {
                    int start = line.IndexOf("value") + 7;
                    if (start > (-1 +7))
                    {
                        int length = line.IndexOf("type") - line.IndexOf("value") - 9;
                        supp.Address2 = clean(line.Substring(start, length));
                    }
                }

                //address3
                if (line.Contains("name=\"address3\" id=\"address3\""))
                {
                    int start = line.IndexOf("value") + 7;
                    if (start > (-1 + 7))
                    {
                        int length = line.IndexOf("type") - line.IndexOf("value") - 9;
                        supp.Address3 = clean(line.Substring(start, length));
                    }
                }

                //city
                if (line.Contains("name=\"city\" id=\"city\""))
                {
                    int start = line.IndexOf("value") + 7;
                    if (start > (-1 + 7))
                    {
                        int length = line.IndexOf("type") - line.IndexOf("value") - 9;
                        supp.City = clean(line.Substring(start, length));
                    }
                }

                //state
                if (line.Contains("name=\"state\" id=\"state\""))
                {
                    int start = line.IndexOf("value") + 7;
                    if (start > (-1 + 7))
                    {
                        int length = line.IndexOf("type") - line.IndexOf("value") - 9;
                        supp.State = clean(line.Substring(start, length));
                    }
                }

                //postalcode
                if (line.Contains("name=\"postalcode\" id=\"postalcode\""))
                {
                    int start = line.IndexOf("value") + 7;
                    if (start > (-1 + 7))
                    {
                        int length = line.IndexOf("type") - line.IndexOf("value") - 9;
                        supp.PostalCode = clean(line.Substring(start, length));
                    }
                }

                //country
                if (line.Contains("name=\"country\" id=\"country\""))
                {
                    int start = line.IndexOf("value") + 7;
                    if (start > (-1 + 7))
                    {
                        int length = line.IndexOf("type") - line.IndexOf("value") - 9;
                        supp.Country = clean(line.Substring(start, length));
                    }
                }

                //dayphone
                if (line.Contains("name=\"dayphone\" id=\"dayphone\""))
                {
                    int start = line.IndexOf("value") + 7;
                    if (start > (-1 + 7))
                    {
                        int length = line.IndexOf("type") - line.IndexOf("value") - 9;
                        supp.Day = clean(line.Substring(start, length));
                    }
                }

                //evephone
                if (line.Contains("name=\"evephone\" id=\"evephone\""))
                {
                    int start = line.IndexOf("value") + 7;
                    if (start > (-1 + 7))
                    {
                        int length = line.IndexOf("type") - line.IndexOf("value") - 9;
                        supp.Evening = clean(line.Substring(start, length));
                    }
                }

                //fax
                if (line.Contains("name=\"fax\" id=\"fax\""))
                {
                    int start = line.IndexOf("value") + 7;
                    if (start > (-1 + 7))
                    {
                        int length = line.IndexOf("type") - line.IndexOf("value") - 9;
                        supp.Fax = clean(line.Substring(start, length));
                    }
                }

                //email
                if (line.Contains("name=\"email\" id=\"email\""))
                {
                    int start = line.IndexOf("value") + 7;
                    if (start > (-1 + 7))
                    {
                        int length = line.IndexOf("type") - line.IndexOf("value") - 9;
                        supp.Email = clean(line.Substring(start, length));
                    }
                }

                //subject
                if (line.Contains("name=\"subject\" id=\"subject\""))
                {
                    int start = line.IndexOf("value") + 7;
                    if (start > (-1 + 7))
                    {
                        int length = line.IndexOf("type") - line.IndexOf("value") - 9;
                        supp.Subject = clean(line.Substring(start, length));
                    }
                }

                //notes
                if (line.Contains("name=\"notes\" id=\"notes\""))
                {
                    int start = line.IndexOf(">") + 1;
                    string strNotes = string.Empty;

                    if (line.IndexOf("</textarea>") > -1)
                    {
                        //notes is only a single line, woo hoo
                        strNotes = line.Substring(start, line.IndexOf("</textarea>") - start);
                    }
                    else
                    {
                        strNotes = line.Substring(start, line.Length - start);
                        //loop and get the rest of the lines until the closing textarea tag
                        while((line = file.ReadLine()) != null)
                        {
                            if (line.IndexOf("</textarea>") > -1)
                            {
                                strNotes = strNotes + "; " + line.Substring(0, line.IndexOf("</textarea>"));
                                break;
                            }
                            else
                            {
                                strNotes = strNotes + "; " + line;
                            }
                        }

                    }

                    if (!string.IsNullOrEmpty(strNotes))
                    {
                        supp.Notes = clean(strNotes);
                    }
                }

                //instructions
                if (line.Contains("name=\"instructions\" id=\"instructions\""))
                {
                    int start = line.IndexOf(">") + 1;
                    string strInstructions = string.Empty;

                    if (line.IndexOf("</textarea>") > -1)
                    {
                        //notes is only a single line, woo hoo
                        strInstructions = line.Substring(start, line.IndexOf("</textarea>") - start);
                    }
                    else
                    {
                        strInstructions = line.Substring(start, line.Length - start);
                        //loop and get the rest of the lines until the closing textarea tag
                        while ((line = file.ReadLine()) != null)
                        {
                            if (line.IndexOf("</textarea>") > -1)
                            {
                                strInstructions = strInstructions + "; " + line.Substring(0, line.IndexOf("</textarea>"));
                                break;
                            }
                            else
                            {
                                strInstructions = strInstructions + "; " + line;
                            }
                        }

                    }

                    if (!string.IsNullOrEmpty(strInstructions))
                    {
                        supp.Message = clean(strInstructions);
                    }
                }

            }
            file.Close();

            if (!string.IsNullOrEmpty(supp.Company))
            {
                //Add supplier to list
                _supplierList.Add(supp);

                //Log processing of file to output textbox
                logResults(supp.Company);
            }
            else
            {
                logResults("@@@@@@@@@@");
                logResults("ERROR: No supplier found in " + filePath);
                logResults("@@@@@@@@@@");
            }
        }

        private string clean(string strInput)
        {
            string strOutput = strInput;

            //Replace &#39; with '
            strOutput = strOutput.Replace("&#39;", "'");

            //Replace &amp; with &
            strOutput = strOutput.Replace("&amp;", "&");

            return strOutput;
        }
    }
}
