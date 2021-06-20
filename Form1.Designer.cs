
namespace Restaurant_Menu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAddNewItem = new System.Windows.Forms.Button();
            this.textBoxNewItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewItemPrice = new System.Windows.Forms.TextBox();
            this.buttonAddItemPicture = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSelectItem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonSaveMenu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCurrentItemPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCurrentItemName = new System.Windows.Forms.TextBox();
            this.buttonOpenJSON = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxRestaurantName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxRestaurantIcon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRestaurantDescription = new System.Windows.Forms.TextBox();
            this.buttonSaveItem = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listViewItems = new System.Windows.Forms.ListView();
            this.itemCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxNewItemDescription = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxNewItemCategory = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxNewCategory = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxNewCategoryDescription = new System.Windows.Forms.TextBox();
            this.buttonNewCategoryPicture = new System.Windows.Forms.Button();
            this.buttonNewCategory = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.comboBoxDeleteCategory = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxCurrentItemDescription = new System.Windows.Forms.TextBox();
            this.buttonChangeCurrentItemPicture = new System.Windows.Forms.Button();
            this.pictureBoxCurrentItemPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxCategoryPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxItemPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentItemPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoryPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddNewItem
            // 
            this.buttonAddNewItem.BackColor = System.Drawing.Color.Lime;
            this.buttonAddNewItem.Location = new System.Drawing.Point(312, 358);
            this.buttonAddNewItem.Name = "buttonAddNewItem";
            this.buttonAddNewItem.Size = new System.Drawing.Size(107, 76);
            this.buttonAddNewItem.TabIndex = 0;
            this.buttonAddNewItem.Text = "Add New Item";
            this.buttonAddNewItem.UseVisualStyleBackColor = false;
            this.buttonAddNewItem.Click += new System.EventHandler(this.buttonAddNewItem_Click);
            // 
            // textBoxNewItemName
            // 
            this.textBoxNewItemName.Location = new System.Drawing.Point(326, 89);
            this.textBoxNewItemName.Name = "textBoxNewItemName";
            this.textBoxNewItemName.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewItemName.TabIndex = 1;
            this.textBoxNewItemName.TextChanged += new System.EventHandler(this.textBoxNewItemName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Price:";
            // 
            // textBoxNewItemPrice
            // 
            this.textBoxNewItemPrice.Location = new System.Drawing.Point(326, 123);
            this.textBoxNewItemPrice.Name = "textBoxNewItemPrice";
            this.textBoxNewItemPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewItemPrice.TabIndex = 3;
            // 
            // buttonAddItemPicture
            // 
            this.buttonAddItemPicture.Location = new System.Drawing.Point(287, 260);
            this.buttonAddItemPicture.Name = "buttonAddItemPicture";
            this.buttonAddItemPicture.Size = new System.Drawing.Size(75, 52);
            this.buttonAddItemPicture.TabIndex = 6;
            this.buttonAddItemPicture.Text = "Add Item Picture";
            this.buttonAddItemPicture.UseVisualStyleBackColor = true;
            this.buttonAddItemPicture.Click += new System.EventHandler(this.buttonAddItemPicture_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Open Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 454);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "New Menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(486, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Edit Item:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Add New Item:";
            // 
            // comboBoxSelectItem
            // 
            this.comboBoxSelectItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectItem.FormattingEnabled = true;
            this.comboBoxSelectItem.Location = new System.Drawing.Point(608, 84);
            this.comboBoxSelectItem.Name = "comboBoxSelectItem";
            this.comboBoxSelectItem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectItem.TabIndex = 12;
            this.comboBoxSelectItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectItem_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Select Existing Item:";
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteItem.Location = new System.Drawing.Point(683, 358);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(68, 50);
            this.buttonDeleteItem.TabIndex = 14;
            this.buttonDeleteItem.Text = "Delete Item";
            this.buttonDeleteItem.UseVisualStyleBackColor = false;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // buttonSaveMenu
            // 
            this.buttonSaveMenu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonSaveMenu.Location = new System.Drawing.Point(982, 427);
            this.buttonSaveMenu.Name = "buttonSaveMenu";
            this.buttonSaveMenu.Size = new System.Drawing.Size(107, 76);
            this.buttonSaveMenu.TabIndex = 15;
            this.buttonSaveMenu.Text = "Save Menu";
            this.buttonSaveMenu.UseVisualStyleBackColor = false;
            this.buttonSaveMenu.Click += new System.EventHandler(this.buttonSaveMenu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Item Price:";
            // 
            // textBoxCurrentItemPrice
            // 
            this.textBoxCurrentItemPrice.Enabled = false;
            this.textBoxCurrentItemPrice.Location = new System.Drawing.Point(608, 136);
            this.textBoxCurrentItemPrice.Name = "textBoxCurrentItemPrice";
            this.textBoxCurrentItemPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentItemPrice.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(541, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Item Name:";
            // 
            // textBoxCurrentItemName
            // 
            this.textBoxCurrentItemName.Enabled = false;
            this.textBoxCurrentItemName.Location = new System.Drawing.Point(608, 110);
            this.textBoxCurrentItemName.Name = "textBoxCurrentItemName";
            this.textBoxCurrentItemName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentItemName.TabIndex = 16;
            // 
            // buttonOpenJSON
            // 
            this.buttonOpenJSON.Location = new System.Drawing.Point(610, 429);
            this.buttonOpenJSON.Name = "buttonOpenJSON";
            this.buttonOpenJSON.Size = new System.Drawing.Size(112, 48);
            this.buttonOpenJSON.TabIndex = 20;
            this.buttonOpenJSON.Text = "Open .Json";
            this.buttonOpenJSON.UseVisualStyleBackColor = true;
            this.buttonOpenJSON.Click += new System.EventHandler(this.buttonOpenJSON_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(801, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Restaurant Name:";
            // 
            // textBoxRestaurantName
            // 
            this.textBoxRestaurantName.Location = new System.Drawing.Point(900, 78);
            this.textBoxRestaurantName.Name = "textBoxRestaurantName";
            this.textBoxRestaurantName.Size = new System.Drawing.Size(100, 20);
            this.textBoxRestaurantName.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(808, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Restaurant Icon:";
            // 
            // textBoxRestaurantIcon
            // 
            this.textBoxRestaurantIcon.Location = new System.Drawing.Point(900, 104);
            this.textBoxRestaurantIcon.Name = "textBoxRestaurantIcon";
            this.textBoxRestaurantIcon.Size = new System.Drawing.Size(100, 20);
            this.textBoxRestaurantIcon.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(776, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Restaurant Description:";
            // 
            // textBoxRestaurantDescription
            // 
            this.textBoxRestaurantDescription.Location = new System.Drawing.Point(900, 142);
            this.textBoxRestaurantDescription.Multiline = true;
            this.textBoxRestaurantDescription.Name = "textBoxRestaurantDescription";
            this.textBoxRestaurantDescription.Size = new System.Drawing.Size(185, 82);
            this.textBoxRestaurantDescription.TabIndex = 25;
            // 
            // buttonSaveItem
            // 
            this.buttonSaveItem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonSaveItem.Location = new System.Drawing.Point(536, 332);
            this.buttonSaveItem.Name = "buttonSaveItem";
            this.buttonSaveItem.Size = new System.Drawing.Size(107, 76);
            this.buttonSaveItem.TabIndex = 27;
            this.buttonSaveItem.Text = "Save Item ";
            this.buttonSaveItem.UseVisualStyleBackColor = false;
            this.buttonSaveItem.Click += new System.EventHandler(this.buttonSaveItem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(478, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Select Existing Category:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(608, 56);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 28;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(492, 429);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(112, 48);
            this.buttonClearAll.TabIndex = 30;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(241, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Webserver URL:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(328, 456);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(158, 20);
            this.textBoxURL.TabIndex = 31;
            this.textBoxURL.Text = "http://192.168.0.200/tacoshop.json";
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listViewItems
            // 
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemCategory,
            this.itemName,
            this.itemPrice});
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(877, 262);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(212, 143);
            this.listViewItems.TabIndex = 40;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.SelectedIndexChanged += new System.EventHandler(this.listViewItems_SelectedIndexChanged);
            // 
            // itemCategory
            // 
            this.itemCategory.Text = "Category";
            this.itemCategory.Width = 69;
            // 
            // itemName
            // 
            this.itemName.Text = "Name";
            this.itemName.Width = 97;
            // 
            // itemPrice
            // 
            this.itemPrice.Text = "Price";
            this.itemPrice.Width = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(870, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "All Menu Items";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(251, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Item Category:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(240, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Item Description:";
            // 
            // textBoxNewItemDescription
            // 
            this.textBoxNewItemDescription.Location = new System.Drawing.Point(326, 149);
            this.textBoxNewItemDescription.Multiline = true;
            this.textBoxNewItemDescription.Name = "textBoxNewItemDescription";
            this.textBoxNewItemDescription.Size = new System.Drawing.Size(148, 82);
            this.textBoxNewItemDescription.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(208, 31);
            this.label16.TabIndex = 46;
            this.label16.Text = "New Category:";
            // 
            // comboBoxNewItemCategory
            // 
            this.comboBoxNewItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewItemCategory.FormattingEnabled = true;
            this.comboBoxNewItemCategory.Location = new System.Drawing.Point(325, 56);
            this.comboBoxNewItemCategory.Name = "comboBoxNewItemCategory";
            this.comboBoxNewItemCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNewItemCategory.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "Category Name:";
            // 
            // textBoxNewCategory
            // 
            this.textBoxNewCategory.Location = new System.Drawing.Point(97, 52);
            this.textBoxNewCategory.Name = "textBoxNewCategory";
            this.textBoxNewCategory.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewCategory.TabIndex = 48;
            this.textBoxNewCategory.TextChanged += new System.EventHandler(this.textBoxNewCategory_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 26);
            this.label18.TabIndex = 53;
            this.label18.Text = "Category\r\nDescription:";
            // 
            // textBoxNewCategoryDescription
            // 
            this.textBoxNewCategoryDescription.Location = new System.Drawing.Point(97, 83);
            this.textBoxNewCategoryDescription.Multiline = true;
            this.textBoxNewCategoryDescription.Name = "textBoxNewCategoryDescription";
            this.textBoxNewCategoryDescription.Size = new System.Drawing.Size(138, 82);
            this.textBoxNewCategoryDescription.TabIndex = 52;
            // 
            // buttonNewCategoryPicture
            // 
            this.buttonNewCategoryPicture.Location = new System.Drawing.Point(16, 200);
            this.buttonNewCategoryPicture.Name = "buttonNewCategoryPicture";
            this.buttonNewCategoryPicture.Size = new System.Drawing.Size(75, 52);
            this.buttonNewCategoryPicture.TabIndex = 51;
            this.buttonNewCategoryPicture.Text = "Add Category Picture";
            this.buttonNewCategoryPicture.UseVisualStyleBackColor = true;
            this.buttonNewCategoryPicture.Click += new System.EventHandler(this.buttonNewCategoryPicture_Click);
            // 
            // buttonNewCategory
            // 
            this.buttonNewCategory.BackColor = System.Drawing.Color.Lime;
            this.buttonNewCategory.Location = new System.Drawing.Point(31, 278);
            this.buttonNewCategory.Name = "buttonNewCategory";
            this.buttonNewCategory.Size = new System.Drawing.Size(107, 76);
            this.buttonNewCategory.TabIndex = 54;
            this.buttonNewCategory.Text = "Add New Category";
            this.buttonNewCategory.UseVisualStyleBackColor = false;
            this.buttonNewCategory.Click += new System.EventHandler(this.buttonNewCategory_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(9, 357);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(235, 31);
            this.label19.TabIndex = 55;
            this.label19.Text = "Delete Category:";
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteCategory.Location = new System.Drawing.Point(167, 398);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(68, 50);
            this.buttonDeleteCategory.TabIndex = 56;
            this.buttonDeleteCategory.Text = "Delete Category";
            this.buttonDeleteCategory.UseVisualStyleBackColor = false;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // comboBoxDeleteCategory
            // 
            this.comboBoxDeleteCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeleteCategory.FormattingEnabled = true;
            this.comboBoxDeleteCategory.Location = new System.Drawing.Point(31, 414);
            this.comboBoxDeleteCategory.Name = "comboBoxDeleteCategory";
            this.comboBoxDeleteCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeleteCategory.TabIndex = 58;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 398);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 13);
            this.label20.TabIndex = 57;
            this.label20.Text = "Item Category:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialogAddCategory";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(522, 173);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 13);
            this.label21.TabIndex = 62;
            this.label21.Text = "Item Description:";
            // 
            // textBoxCurrentItemDescription
            // 
            this.textBoxCurrentItemDescription.Enabled = false;
            this.textBoxCurrentItemDescription.Location = new System.Drawing.Point(608, 162);
            this.textBoxCurrentItemDescription.Multiline = true;
            this.textBoxCurrentItemDescription.Name = "textBoxCurrentItemDescription";
            this.textBoxCurrentItemDescription.Size = new System.Drawing.Size(148, 82);
            this.textBoxCurrentItemDescription.TabIndex = 61;
            // 
            // buttonChangeCurrentItemPicture
            // 
            this.buttonChangeCurrentItemPicture.Enabled = false;
            this.buttonChangeCurrentItemPicture.Location = new System.Drawing.Point(569, 273);
            this.buttonChangeCurrentItemPicture.Name = "buttonChangeCurrentItemPicture";
            this.buttonChangeCurrentItemPicture.Size = new System.Drawing.Size(75, 52);
            this.buttonChangeCurrentItemPicture.TabIndex = 60;
            this.buttonChangeCurrentItemPicture.Text = "Add Item Picture";
            this.buttonChangeCurrentItemPicture.UseVisualStyleBackColor = true;
            this.buttonChangeCurrentItemPicture.Click += new System.EventHandler(this.buttonChangeCurrentItemPicture_Click);
            // 
            // pictureBoxCurrentItemPicture
            // 
            this.pictureBoxCurrentItemPicture.Location = new System.Drawing.Point(650, 256);
            this.pictureBoxCurrentItemPicture.Name = "pictureBoxCurrentItemPicture";
            this.pictureBoxCurrentItemPicture.Size = new System.Drawing.Size(89, 89);
            this.pictureBoxCurrentItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCurrentItemPicture.TabIndex = 59;
            this.pictureBoxCurrentItemPicture.TabStop = false;
            // 
            // pictureBoxCategoryPicture
            // 
            this.pictureBoxCategoryPicture.Location = new System.Drawing.Point(97, 183);
            this.pictureBoxCategoryPicture.Name = "pictureBoxCategoryPicture";
            this.pictureBoxCategoryPicture.Size = new System.Drawing.Size(89, 89);
            this.pictureBoxCategoryPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCategoryPicture.TabIndex = 50;
            this.pictureBoxCategoryPicture.TabStop = false;
            // 
            // pictureBoxItemPicture
            // 
            this.pictureBoxItemPicture.Location = new System.Drawing.Point(368, 243);
            this.pictureBoxItemPicture.Name = "pictureBoxItemPicture";
            this.pictureBoxItemPicture.Size = new System.Drawing.Size(89, 89);
            this.pictureBoxItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxItemPicture.TabIndex = 5;
            this.pictureBoxItemPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1101, 506);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBoxCurrentItemDescription);
            this.Controls.Add(this.buttonChangeCurrentItemPicture);
            this.Controls.Add(this.pictureBoxCurrentItemPicture);
            this.Controls.Add(this.comboBoxDeleteCategory);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.buttonDeleteCategory);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.buttonNewCategory);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxNewCategoryDescription);
            this.Controls.Add(this.buttonNewCategoryPicture);
            this.Controls.Add(this.pictureBoxCategoryPicture);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxNewCategory);
            this.Controls.Add(this.comboBoxNewItemCategory);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxNewItemDescription);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewItems);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonSaveItem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxRestaurantDescription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxRestaurantIcon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxRestaurantName);
            this.Controls.Add(this.buttonOpenJSON);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCurrentItemPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCurrentItemName);
            this.Controls.Add(this.buttonSaveMenu);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSelectItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonAddItemPicture);
            this.Controls.Add(this.pictureBoxItemPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewItemPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNewItemName);
            this.Controls.Add(this.buttonAddNewItem);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Editting TacoBellMenu.json";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentItemPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoryPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewItem;
        private System.Windows.Forms.TextBox textBoxNewItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewItemPrice;
        private System.Windows.Forms.PictureBox pictureBoxItemPicture;
        private System.Windows.Forms.Button buttonAddItemPicture;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSelectItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonSaveMenu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCurrentItemPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCurrentItemName;
        private System.Windows.Forms.Button buttonOpenJSON;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxRestaurantName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxRestaurantIcon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxRestaurantDescription;
        private System.Windows.Forms.Button buttonSaveItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader itemCategory;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader itemPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxNewItemDescription;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxNewItemCategory;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxNewCategory;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxNewCategoryDescription;
        private System.Windows.Forms.Button buttonNewCategoryPicture;
        private System.Windows.Forms.PictureBox pictureBoxCategoryPicture;
        private System.Windows.Forms.Button buttonNewCategory;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.ComboBox comboBoxDeleteCategory;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxCurrentItemDescription;
        private System.Windows.Forms.Button buttonChangeCurrentItemPicture;
        private System.Windows.Forms.PictureBox pictureBoxCurrentItemPicture;
    }
}

