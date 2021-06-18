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
                    return (dynamic)JsonConvert.DeserializeObject(string.Join("\n", ar.Skip(6).Take(ar.Length - 6)));

                }
            }
            catch (Exception err)
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
            refreshListViewItems();

        }

        private void refreshListViewItems()
        {
            listViewItems.Items.Clear();
            foreach (dynamic category in jsonMenu.categories)
            {
                comboBoxCategory.Items.Add((string)category.categoryName);


                //Fills in listViewItems
                foreach (dynamic item in category.categoryItems)
                {
                    ListViewItem tmp = new ListViewItem((string)category.categoryName);
                    tmp.SubItems.Add((string)item.itemName);
                    tmp.SubItems.Add((string)item.itemPrice);

                    listViewItems.Items.Add(tmp);
                }
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
            comboBoxCategory.Items.Clear();
            comboBoxSelectItem.Items.Clear();
            listViewItems.Clear();

            textBoxCurrentItemName.Enabled = false;
            textBoxCurrentItemPrice.Enabled = false;
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
                client.UploadFile(@"http://192.168.0.200:80", "POST", myFile); //Switch to textBoxURL.Text
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeCurrentCategory(comboBoxCategory.SelectedItem.ToString());
        }

        private void changeCurrentCategory(string selectedCategory)
        {
            //Disable editing currentItem until we populate later
            textBoxCurrentItemName.Enabled = false;
            textBoxCurrentItemName.Clear();
            textBoxCurrentItemPrice.Enabled = false;
            textBoxCurrentItemPrice.Clear();


            comboBoxSelectItem.Items.Clear();

            foreach (dynamic category in jsonMenu.categories)
            {
                if (category.categoryName == selectedCategory)
                {
                    //Fills in items
                    foreach (dynamic item in category.categoryItems)
                    {
                        comboBoxSelectItem.Items.Add((string)item.itemName);
                    }
                }
            }
        }

        private void comboBoxSelectItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeCurrentItem(comboBoxSelectItem.SelectedItem.ToString());
        }

        private void changeCurrentItem(string selectedItem)
        {
            //Reenable textBoxes for current item since were now allowing edits to them.
            textBoxCurrentItemName.Enabled = true;
            textBoxCurrentItemPrice.Enabled = true;

            dynamic itemObject = findItem(comboBoxCategory.SelectedItem.ToString(), selectedItem);
            textBoxCurrentItemName.Text = selectedItem;

            textBoxCurrentItemPrice.Text = itemObject.itemPrice;
        }

        private dynamic findItem(string category, string itemName)
        {
            foreach (dynamic currentCategory in jsonMenu.categories)
            {
                if (currentCategory.categoryName == category)
                {
                    foreach (dynamic item in currentCategory.categoryItems)
                    {
                        if (item.itemName == itemName)
                        {
                            return item;
                        }
                            
                    }
                }
            }
            return null; //Couldnt find item.
        }

        private void buttonSaveItem_Click(object sender, EventArgs e)
        {
            saveChangesToItem();
        }
        private void saveChangesToItem()
        {
            if (!string.IsNullOrEmpty(comboBoxSelectItem.SelectedItem.ToString()))
            {
                dynamic changedItem = findItem(comboBoxCategory.SelectedItem.ToString(), comboBoxSelectItem.SelectedItem.ToString());
                if (changedItem.itemName != textBoxCurrentItemName.Text) //name change, so check if that name is already taken.
                {
                    if (!itemExists(textBoxCurrentItemName.Text))
                    {
                        changedItem.itemName = textBoxCurrentItemName.Text;
                        changedItem.itemPrice = textBoxCurrentItemPrice.Text;
                        comboBoxSelectItem.Items[comboBoxSelectItem.SelectedIndex] = textBoxCurrentItemName.Text;
                    } else
                    {
                        MessageBox.Show("Couldn't be done because an item with that name already exists.");
                    }
                } else //Then its probably just price change.
                {
                    changedItem.itemPrice = textBoxCurrentItemPrice.Text;
                }
                refreshListViewItems();
                
                
            }

        }

        private void refreshAllData()
        {
            clearData();
            fillInData();
        }

        private bool itemExists(string itemName)
        {
            foreach (dynamic category in jsonMenu.categories)
            {
                foreach (dynamic item in category.categoryItems)
                {
                    if (item.itemName == itemName)
                    {
                        return true;
                    }

                }
                
            }
            return false;
        }
    }
}
