using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WtterDaten
{
    public partial class Form1 : Form
    {
        static string file = "wetterdaten.csv";

        List<cDataset> data = new List<cDataset>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckCSV();

            LoadCSV();
        }

        public void CheckCSV()
        {
            if (!System.IO.File.Exists(file))
            {
                System.IO.File.Create(file).Close();
            }
        }

        public void LoadCSV()
        {
            data.Clear();
            string[] lines = System.IO.File.ReadAllLines(file);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(';');
                string datum = parts[0];
                double temperatur = double.Parse(parts[1]);
                double luftfeuchtigkeit = double.Parse(parts[2]);
                data.Add(new cDataset(datum, temperatur, luftfeuchtigkeit));
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            txtAusgabe.Text = "";
            foreach (cDataset dataset in data)
            {
                txtAusgabe.Text += dataset.ToString() + Environment.NewLine;
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double avgTemp = 0;
            double avgHum = 0;
            foreach (cDataset dataset in data)
            {
                avgTemp += dataset.temperatur;
                avgHum += dataset.luftfeuchtigkeit;
            }
            avgTemp /= data.Count;
            avgHum /= data.Count;

            txtAusgabe.Text = $"Average Temperature: {avgTemp}; Average Humidity: {avgHum}";
        }
    }
}
