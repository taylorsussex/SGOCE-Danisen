using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGOCE_Danisen
{
    public partial class DanisenSimulator : Form
    {
        public DanisenSimulator()
        {
            InitializeComponent();
        }

        // Browse for input file
        private void BrowseInput_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                InputPath.Text = openFileDialog.FileName;
            }
        }

        // Browse for output file
        private void BrowseOutput1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                OutputPath1.Text = openFileDialog.FileName;
            }
        }

        // Browse for output file
        private void BrowseOutput2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                OutputPath2.Text = openFileDialog.FileName;
            }
        }

        private void BrowseHistory_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                HistoryPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void Simulate_Click(object sender, EventArgs e)
        {
            DanisenParser dp = new DanisenParser(InputPath.Text, OutputPath1.Text, OutputPath2.Text, HistoryPath.Text);
            dp.Go();
        }
    }
}
