using Ibsys_GUI.Entity.Input;
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
using System.Xml.Serialization;

namespace Ibsys_GUI
{
    public partial class Form1 : Form
    {
        private results input;

        public Form1()
        {
            InitializeComponent();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Cursor Files|*.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(results));
                TextReader reader = new StreamReader(openFileDialog1.FileName);
                object obj = deserializer.Deserialize(reader);
                input = (results)obj;

                dataGridView1.DataSource = input.warehousestock.article;
                dataGridView2.DataSource = input.waitinglistworkstations;
                
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
