using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Drawing;

namespace Restaurant_Menu
{
    public partial class Form1 : Form
    {
        private dynamic jsonMenu;
        private string categoryPicture = "";
        private string newItemPicture = "";
        private string currentItemPicture = "";
        private List<string[]> mediaFilesToUpload = new List<string[]>();
        public Form1()
        {
            InitializeComponent();

        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }



        async private void buttonOpenJSON_Click(object sender, EventArgs e)
        {
            clearData();
            jsonMenu = await downloadJson(textBoxURL.Text);
            //Console.WriteLine(jsonMenu);
            fillInData();
            textBoxURL.Enabled = false;
            buttonOpenJSON.Enabled = false;
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
                    return (dynamic)JsonConvert.DeserializeObject(reader.ReadToEnd());

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
            //Populate basic menu data.
            this.Text = "Editing " + (string)jsonMenu.restaurantName;
            textBoxRestaurantName.Text = (string)jsonMenu.restaurantName;
            textBoxRestaurantIcon.Text = (string)jsonMenu.restaurantIcon;
            textBoxRestaurantDescription.Text = (string)jsonMenu.restaurantDescription;
            foreach (dynamic category in jsonMenu.categories)
            {
                comboBoxCategory.Items.Add((string)category.categoryName);
                comboBoxNewItemCategory.Items.Add((string)category.categoryName);
                comboBoxDeleteCategory.Items.Add((string)category.categoryName);
            }
            //Populate existing items combobox
            refreshListViewItems();

        }

        private void refreshListViewItems()
        {
            listViewItems.Items.Clear();
            foreach (dynamic category in jsonMenu.categories)
            {


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
            textBoxNewItemDescription.Clear();

            textBoxCurrentItemName.Clear();
            textBoxCurrentItemPrice.Clear();
            textBoxCurrentItemDescription.Clear();

            textBoxRestaurantName.Clear();
            textBoxRestaurantIcon.Clear();
            textBoxRestaurantDescription.Clear();

            comboBoxCategory.Items.Clear();
            comboBoxNewItemCategory.Items.Clear();
            comboBoxSelectItem.Items.Clear();
            comboBoxDeleteCategory.Items.Clear();

            listViewItems.Items.Clear();

            

            textBoxNewCategory.Clear();
            textBoxNewCategoryDescription.Clear();

            textBoxCurrentItemName.Enabled = false;
            textBoxCurrentItemPrice.Enabled = false;
            textBoxCurrentItemDescription.Enabled = false;

            categoryPicture = "";
            newItemPicture = "";
            currentItemPicture = "";

            pictureBoxCategoryPicture.Image = null;
            pictureBoxItemPicture.Image = null;
            pictureBoxCurrentItemPicture.Image = null;
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private async void buttonSaveMenu_Click(object sender, EventArgs e)
        {
            uploadMenu(textBoxURL.Text, jsonMenu);
            foreach(string[] picture in mediaFilesToUpload) {
                await uploadPicture(textBoxURL.Text, picture[0]);
            }
            mediaFilesToUpload.Clear();
        }

        private async Task<bool> uploadMenu(string urlString, dynamic jsonMenu)
        {
            try
            {
                WebClient client = new WebClient();
                var url = new Uri(urlString);
                JObject data = new JObject();
                data.Add("fileName", url.LocalPath);
                data.Add("menu", jsonMenu);

                string dataString = JsonConvert.SerializeObject(data);

                client.Credentials = CredentialCache.DefaultCredentials;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                await client.UploadStringTaskAsync("http://" + url.IdnHost + "/upload", "POST", dataString);

                client.Dispose();
                return true;
                

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " http://" + (new Uri(urlString)).IdnHost + "/upload");
                Console.Write(err);
                return false;
            }
            return false;
        }

        private async Task<bool> uploadPicture(string urlString, string picturePath)
        {
            try
            {
                WebClient client = new WebClient();
                
                var url = new Uri(urlString);

                using (Image image = Image.FromFile(picturePath))
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        image.Save(m, image.RawFormat);
                        byte[] imageBytes = m.ToArray();

                        // Convert byte[] to Base64 String
                        string base64String = Convert.ToBase64String(imageBytes);

                        JObject data = new JObject();
                        data.Add("fileName", Path.GetFileName(picturePath));
                        data.Add("fileData", base64String);

                        string dataString = JsonConvert.SerializeObject(data);
                        client.Credentials = CredentialCache.DefaultCredentials;
                        client.Headers[HttpRequestHeader.ContentType] = "application/json";
                        await client.UploadStringTaskAsync("http://" + url.IdnHost + "/picture", "POST", dataString);
                        client.Dispose();
                        
                    }
                }
                return true;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " http://" + (new Uri(urlString)).IdnHost + "/picture" + " Upload:" + picturePath);
                Console.Write(err);
                return false;
            }
            return false;
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
            textBoxCurrentItemDescription.Enabled = false;
            textBoxCurrentItemDescription.Clear();
            buttonChangeCurrentItemPicture.Enabled = false;

            pictureBoxCurrentItemPicture.Image = null;
            currentItemPicture = "";

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
            if (comboBoxSelectItem.SelectedIndex == -1)
            {
                textBoxCurrentItemName.Enabled = false;
                textBoxCurrentItemPrice.Enabled = false;
                textBoxCurrentItemDescription.Enabled = false;
                buttonChangeCurrentItemPicture.Enabled = false;
                textBoxCurrentItemName.Clear();
                textBoxCurrentItemPrice.Clear();
                textBoxCurrentItemDescription.Clear();


            } else
            {
                changeCurrentItem(comboBoxSelectItem.SelectedItem.ToString());
            }
            
        }

        private void changeCurrentItem(string selectedItem)
        {
            var url = new Uri(textBoxURL.Text);

            //Reenable textBoxes for current item since were now allowing edits to them.
            textBoxCurrentItemName.Enabled = true;
            textBoxCurrentItemPrice.Enabled = true;
            textBoxCurrentItemDescription.Enabled = true;
            buttonChangeCurrentItemPicture.Enabled = true;

            pictureBoxCurrentItemPicture.Image = null;
            currentItemPicture = "";

            dynamic itemObject = getItemByName(selectedItem);
            textBoxCurrentItemName.Text = selectedItem;

            textBoxCurrentItemPrice.Text = itemObject.itemPrice;

            textBoxCurrentItemDescription.Text = itemObject.itemDescription;


  
            if (!string.IsNullOrEmpty((string)itemObject.itemPicture))
            {
                try
                {
                    string urlString = "http://" + url.IdnHost + "/" + (string)itemObject.itemPicture;
                    pictureBoxCurrentItemPicture.Load(urlString);
                }
                catch (Exception err)
                {
                    //MessageBox.Show("Error loading picture (" + "http://" + url.IdnHost + "/" + (string)itemObject.itemPicture + "). Save your menu to fix this problem.");
                    pictureBoxCurrentItemPicture.Image = Restaurant_Menu.Properties.Resources.FileNotFound1;
                    Console.Write(err);
                }
            }

            

            
        }

        private dynamic getItemByName( string itemName)
        {
            foreach (dynamic currentCategory in jsonMenu.categories)
            {
                foreach (dynamic item in currentCategory.categoryItems)
                {
                    if (item.itemName == itemName)
                    {
                        return item;
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
            if (comboBoxSelectItem.SelectedIndex != -1)
            {
                dynamic changedItem = getItemByName(comboBoxSelectItem.SelectedItem.ToString());
                if (changedItem.itemName != textBoxCurrentItemName.Text) //name change, so check if that name is already taken.
                {
                    if (!itemExists(textBoxCurrentItemName.Text))
                    {
                        changedItem.itemName = textBoxCurrentItemName.Text;
                        changedItem.itemPrice = textBoxCurrentItemPrice.Text;
                        changedItem.itemDescription = textBoxCurrentItemDescription.Text;
                        comboBoxSelectItem.Items[comboBoxSelectItem.SelectedIndex] = textBoxCurrentItemName.Text;
                        if (!string.IsNullOrEmpty(currentItemPicture))
                        {
                            changedItem.itemPicture = Path.GetFileName(currentItemPicture);
                            mediaFilesToUpload.Add(new string[] { currentItemPicture, "" });
                        }
                    } else
                    {
                        MessageBox.Show("Couldn't be done because an item with that name already exists.");
                    }
                } else //Then its probably just price change.
                {
                    changedItem.itemPrice = textBoxCurrentItemPrice.Text;
                    changedItem.itemDescription = textBoxCurrentItemDescription.Text;
                    if (!string.IsNullOrEmpty(currentItemPicture))
                    {
                        changedItem.itemPicture = Path.GetFileName(currentItemPicture);
                        mediaFilesToUpload.Add(new string[] { currentItemPicture, "" });
                    }
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

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            deleteCurrentItem();
        }

        private void deleteCurrentItem()
        {
            if (!string.IsNullOrEmpty(comboBoxSelectItem.SelectedItem.ToString()))
            {
                deleteItemByName(comboBoxSelectItem.SelectedItem.ToString());
                comboBoxSelectItem.Items.Remove(comboBoxSelectItem.SelectedItem);
                textBoxCurrentItemName.Enabled = false;
                textBoxCurrentItemPrice.Enabled = false;
                textBoxCurrentItemDescription.Enabled = false;

                pictureBoxCurrentItemPicture.Image = null;
                currentItemPicture = "";

                textBoxCurrentItemName.Clear();
                textBoxCurrentItemPrice.Clear();
                textBoxCurrentItemDescription.Clear();
                refreshListViewItems();

            } else
            {
                MessageBox.Show("No item to delete.");
            }
        }

        private dynamic getItemCategory(string itemName)
        {

            foreach (dynamic category in jsonMenu.categories)
            {
                foreach (dynamic item in category.categoryItems)
                {
                    if (item.itemName == itemName)
                    {
                        return category;
                    }

                }

            }
            return null;
        }

        private dynamic getCategoryByName(string categoryName)
        {
            foreach (dynamic category in jsonMenu.categories)
            {
                if (category.categoryName == categoryName)
                {
                    return category;
                }
            }
            return null;
        }

        private void deleteItemByName(string itemName)
        {
            dynamic searchItem = getItemByName(itemName);
            searchItem.Remove();
        }

        private void buttonAddNewItem_Click(object sender, EventArgs e)
        {
            addNewItem();

        }
        private void addNewItem()
        {

            if (!itemExists(textBoxNewItemName.Text) && !string.IsNullOrEmpty(textBoxNewItemName.Text) && !string.IsNullOrEmpty(textBoxNewItemPrice.Text) && comboBoxNewItemCategory.SelectedIndex != -1)
            {
                JObject newItem = new JObject();
                newItem.Add("itemName", textBoxNewItemName.Text);
                newItem.Add("itemDescription", textBoxNewItemDescription.Text);
                newItem.Add("itemPrice", textBoxNewItemPrice.Text);
                newItem.Add("itemPicture", Path.GetFileName(newItemPicture));
                mediaFilesToUpload.Add(new string[] { newItemPicture, "" });
                dynamic category = getCategoryByName(comboBoxNewItemCategory.SelectedItem.ToString());
                
                
                category.categoryItems.Add(newItem);
                refreshAllData();
            }
            else
            {
                MessageBox.Show("There was a problem creating this item.");
            }
        }

        private void textBoxNewCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNewCategory_Click(object sender, EventArgs e)
        {
            addNewCategory();
        }

        private void addNewCategory()
        {

            if ((getCategoryByName(textBoxNewCategory.Text) == null) && !string.IsNullOrEmpty(textBoxNewCategory.Text))
            {
                JObject newCategory = new JObject();
                newCategory.Add("categoryName", textBoxNewCategory.Text);
                newCategory.Add("categoryDescription", textBoxNewCategoryDescription.Text);
                newCategory.Add("categoryPicture", Path.GetFileName(categoryPicture));
                mediaFilesToUpload.Add(new string[]{ categoryPicture, ""});
                newCategory.Add("categoryItems", new JArray());


                jsonMenu.categories.Add(newCategory);
                refreshAllData();
            }
            else
            {
                MessageBox.Show("There was a problem creating this category.");
            }
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            if (comboBoxDeleteCategory.SelectedIndex != -1)
            {
                deleteCategoryByName(comboBoxDeleteCategory.SelectedItem.ToString());
                refreshAllData();
            } else
            {
                MessageBox.Show("There was a problem deleting this category.");
            }
            
            
        }

        private void deleteCategoryByName(string categoryName)
        {
            dynamic searchCategory = getCategoryByName(categoryName);
            searchCategory.Remove();
        }

        private void buttonNewCategoryPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseCategoryPicture = new OpenFileDialog();
            chooseCategoryPicture.Filter = "Image Files| *.jpg; *.jpeg; ...";
            if (chooseCategoryPicture.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(chooseCategoryPicture.FileName);

                if (extension == ".jpeg" || extension == ".jpg")
                {
                    pictureBoxCategoryPicture.Image = Image.FromFile(chooseCategoryPicture.FileName);
                    categoryPicture = chooseCategoryPicture.FileName;

                }

            }
        }

        private void buttonAddItemPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseItemPicture = new OpenFileDialog();
            chooseItemPicture.Filter = "Image Files| *.jpg; *.jpeg; ...";
            if (chooseItemPicture.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(chooseItemPicture.FileName);

                if (extension == ".jpeg" || extension == ".jpg")
                {
                    pictureBoxItemPicture.Image = Image.FromFile(chooseItemPicture.FileName);
                    newItemPicture = chooseItemPicture.FileName;
                }

            }
        }

        private void buttonChangeCurrentItemPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseItemPicture = new OpenFileDialog();
            chooseItemPicture.Filter = "Image Files| *.jpg; *.jpeg; ...";
            if (chooseItemPicture.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(chooseItemPicture.FileName);

                if (extension == ".jpeg" || extension == ".jpg")
                {
                    pictureBoxCurrentItemPicture.Image = Image.FromFile(chooseItemPicture.FileName);
                    currentItemPicture = chooseItemPicture.FileName;
                }

            }
        }
    }
}
