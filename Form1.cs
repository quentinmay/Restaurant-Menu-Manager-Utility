using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Restaurant_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void open_json_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Public\\tacoshop.json";
            
            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(filePath));
            fillInData(jsonFile);
        }

        private void fillInData(dynamic jsonFile)
        {
            textBoxRestaurantName.Text = (string)jsonFile["restaurantName"];
            textBoxRestaurantIcon.Text = (string)jsonFile["restaurantIcon"];
            textBoxRestaurantDescription.Text = (string)jsonFile["restaurantDescription"];
        }
    }
}
