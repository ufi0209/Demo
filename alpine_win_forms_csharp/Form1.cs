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

namespace alpine_win_forms_csharp
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            SetValuesToCombobox(cboSeparator);
        }

        enum Separator
        {
            Tab,
            Semicolon,
            Hyphen
        }

        private BindingList<ParentChildBOM> ParentsAndChildBindinglist = new BindingList<ParentChildBOM>();

        private string ImportPath;
        private char separator = ';';

        private void SetValuesToCombobox(ComboBox current)
        {
            try
            {
                current.DataSource = Enum.GetValues(typeof(Separator));
                current.SelectedIndex = -1;
                current.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrog!");
            }

        }

        #region "Userinteraction"
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog currentFileDialog = new OpenFileDialog();
                currentFileDialog.Title = "Select file";
                currentFileDialog.InitialDirectory = @"c:\";
                currentFileDialog.FileName = txtFilePath.Text;
                currentFileDialog.Filter = "Text and CSV Files(*.txt, *.csv)|*.txt;*.csv|Text Files(*.txt)|*.txt|CSV Files(*.csv)|*.csv|All Files(*.*)|*.*";
                currentFileDialog.FilterIndex = 1;
                currentFileDialog.RestoreDirectory = true;
                if (currentFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = currentFileDialog.FileName;
                    ImportPath = currentFileDialog.FileName;
                    txtFilePath.ReadOnly = true;
                    ImportFile(ImportPath);
                    Application.DoEvents();
                }

            }
            catch (IOException)
            {
                MessageBox.Show("Hozzáférés megtagadva!");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrog!");
            }
        }

        public void ImportFile(string filePath, bool needSeparetor = false)
        {
            try
            {

                ParentsAndChildBindinglist.Clear();
                StreamReader streamReader = new StreamReader(filePath);
                string[] totalData = new string[File.ReadAllLines(filePath).Length];
                while (!streamReader.EndOfStream)
                {
                    totalData = streamReader.ReadLine().Split(separator);
                    ParentsAndChildBindinglist.Add(new ParentChildBOM(totalData[0], totalData[1]));
                }
                streamReader.Close();
                dGVParentAndChild.DataSource = ParentsAndChildBindinglist;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrog!");
            }
        }

        private void txtChildSearch_TextChanged(object sender, EventArgs e)
        {
            //ParentsAndChildBindinglist
            dGVSearchResult.DataSource = null;
            var  SearchQuery = new BindingList<ParentChildBOM>();
            var queryChild = from item in ParentsAndChildBindinglist
                                       where item.Parent == txtChildSearch.Text
                                       select item;

            foreach (var currentItem in queryChild)
            {
                SearchQuery.Add(new ParentChildBOM(currentItem.Parent, currentItem.Child));
            }

            dGVSearchResult.DataSource = SearchQuery ;

        }
        private void txtParentSearch_TextChanged_1(object sender, EventArgs e)
        {
            //ParentsAndChildBindinglist
            dGVSearchResult.DataSource = null;
            var SearchQuery = new BindingList<ParentChildBOM>();
            var queryParent = from item in ParentsAndChildBindinglist
                              where item.Child == txtParentSearch.Text
                              select item;

            foreach (var currentItem in queryParent)
            {
                SearchQuery.Add(new ParentChildBOM(currentItem.Parent, currentItem.Child));
            }
            dGVSearchResult.DataSource = SearchQuery;
        }
        
       

        private void cboSeparator_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (Convert.ToString(cboSeparator.SelectedItem))
            {
                case "Tab":
                    separator = '\t';
                    break;
                case "Semicolon":
                    separator = ';';
                    break;
                case "Hyphen":
                    separator = '-';
                    break;
            }
        }

        #endregion

        #region ParentChildBOM Class
        private class ParentChildBOM
        {
            private string parent;
            public string Parent
            {
                get
                {
                    return parent;
                }

                set
                {
                    parent = value;
                }
            }

            private string child;
            public string Child
            {
                get
                {
                    return child;
                }

                set
                {
                    child = value;
                }
            }

            public ParentChildBOM(string parent, string child)
            {
                this.Parent = parent;
                this.Child = child;
            }
        }
        #endregion       
    }
}
