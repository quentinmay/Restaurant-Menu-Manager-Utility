using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Linq;

namespace Restaurant_Menu
{
    public partial class Form1 : Form
    {
        private dynamic jsonMenu;
        public Form1()
        {
            InitializeComponent();
            
        }

       
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        async private void buttonOpenJSON_Click(object sender, EventArgs e)
        {
            jsonMenu = await downloadJson(textBoxURL.Text);
            //Console.WriteLine(jsonMenu);
            fillInData();
            //string filePath = "C:\\Users\\Public\\tacoshop.json";
            //openJson(filePath);

        }

         private void openJson(string filePath)
        {

            this.jsonMenu = JsonConvert.DeserializeObject(File.ReadAllText(filePath));
            fillInData();
        }
        async private Task<dynamic> downloadJson(string jsonURL)
        {

            try
            {

                HttpClient client = new HttpClient();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(jsonURL);
                
                request.ContentType = "application/json; charset=utf-8";
                request.Accept = "text/html, application/json, */*";
                request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes("username:password"));
                request.PreAuthenticate = false;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string[] ar = reader.ReadToEnd().Split('\n');
                    return (dynamic) JsonConvert.DeserializeObject(string.Join("\n", ar.Skip(6).Take(ar.Length - 6)));
                    
                }
            } catch(Exception err)
            {
                Console.WriteLine(err);
                return null;
            }
            
                
        }

        private void fillInData()
        {
            Console.WriteLine(jsonMenu.categories[0]);
            //Populate basic menu data.
            this.Text = "Editing " + (string)jsonMenu.restaurantName;
            textBoxRestaurantName.Text = (string)jsonMenu.restaurantName;
            textBoxRestaurantIcon.Text = (string)jsonMenu.restaurantIcon;
            textBoxRestaurantDescription.Text = (string)jsonMenu.restaurantDescription;


        
            
            //Populate existing items combobox
            foreach (dynamic category in jsonMenu.categories) {
                comboBoxCategory.Items.Add((string)category.categoryName);
                ITEMSlistBox1.Items.Add((string)category.categoryName);
            }
        }
        private void clearData()
        {
            //clears all boxes on the screen
            textBoxNewItemName.Clear();
            textBoxNewItemPrice.Clear();
            textBoxCurrentItemName.Clear();
            textBoxCurrentItemPrice.Clear();
            textBoxRestaurantName.Clear();
            textBoxRestaurantIcon.Clear();
            textBoxRestaurantDescription.Clear();
            comboBoxCategory.Text = string.Empty;
            comboBoxSelectItem.Text = string.Empty;
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void buttonSaveMenu_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string myFile = @"C:\Users\Public\testupload.txt";
                client.Credentials = CredentialCache.DefaultCredentials;
                client.UploadFile(@"http://192.168.0.200:80", "POST", myFile);
                client.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNewItemName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
