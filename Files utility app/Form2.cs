using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files_utility_app
{
    public partial class Form2 : Form
    {
        public int MaxDepth { get; set; }
        public string Extensions { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void ustawienia_Load(object sender, EventArgs e)
        {
            comboBoxMaxDepth.Text = MaxDepth.ToString();
            textBoxExtensions.Text = Extensions;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveData()
        {
            try
            {
                MaxDepth = int.Parse(comboBoxMaxDepth.Text);
            }
            catch { };
            Extensions = textBoxExtensions.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveData();
            Close();
        }
    }
}
