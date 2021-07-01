
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAddNewItem = new System.Windows.Forms.Button();
            this.textBoxNewItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewItemPrice = new System.Windows.Forms.TextBox();
            this.buttonAddItemPicture = new System.Windows.Forms.Button();
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
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRestaurantDescription = new System.Windows.Forms.TextBox();
            this.buttonSaveItem = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
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
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonRestaurantIcon = new System.Windows.Forms.Button();
            this.pictureBoxRestaurantIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxCurrentItemPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxCategoryPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxItemPicture = new System.Windows.Forms.PictureBox();
            this.textBoxNewMenu = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestaurantIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentItemPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoryPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddNewItem
            // 
            this.buttonAddNewItem.BackColor = System.Drawing.Color.Lime;
            this.buttonAddNewItem.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewItem.Location = new System.Drawing.Point(303, 387);
            this.buttonAddNewItem.Name = "buttonAddNewItem";
            this.buttonAddNewItem.Size = new System.Drawing.Size(107, 82);
            this.buttonAddNewItem.TabIndex = 0;
            this.buttonAddNewItem.Text = "Add New Item";
            this.buttonAddNewItem.UseVisualStyleBackColor = false;
            this.buttonAddNewItem.Click += new System.EventHandler(this.buttonAddNewItem_Click);
            // 
            // textBoxNewItemName
            // 
            this.textBoxNewItemName.Location = new System.Drawing.Point(326, 96);
            this.textBoxNewItemName.Name = "textBoxNewItemName";
            this.textBoxNewItemName.Size = new System.Drawing.Size(100, 21);
            this.textBoxNewItemName.TabIndex = 1;
            this.textBoxNewItemName.TextChanged += new System.EventHandler(this.textBoxNewItemName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Price:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxNewItemPrice
            // 
            this.textBoxNewItemPrice.Location = new System.Drawing.Point(326, 132);
            this.textBoxNewItemPrice.Name = "textBoxNewItemPrice";
            this.textBoxNewItemPrice.Size = new System.Drawing.Size(100, 21);
            this.textBoxNewItemPrice.TabIndex = 3;
            // 
            // buttonAddItemPicture
            // 
            this.buttonAddItemPicture.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddItemPicture.Location = new System.Drawing.Point(278, 281);
            this.buttonAddItemPicture.Name = "buttonAddItemPicture";
            this.buttonAddItemPicture.Size = new System.Drawing.Size(75, 56);
            this.buttonAddItemPicture.TabIndex = 6;
            this.buttonAddItemPicture.Text = "Add Item Picture";
            this.buttonAddItemPicture.UseVisualStyleBackColor = true;
            this.buttonAddItemPicture.Click += new System.EventHandler(this.buttonAddItemPicture_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(75, 518);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 25);
            this.button4.TabIndex = 8;
            this.button4.Text = "New Menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(486, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Edit Item:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "Add New Item:";
            // 
            // comboBoxSelectItem
            // 
            this.comboBoxSelectItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectItem.FormattingEnabled = true;
            this.comboBoxSelectItem.Location = new System.Drawing.Point(608, 90);
            this.comboBoxSelectItem.Name = "comboBoxSelectItem";
            this.comboBoxSelectItem.Size = new System.Drawing.Size(121, 22);
            this.comboBoxSelectItem.TabIndex = 12;
            this.comboBoxSelectItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectItem_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(491, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Select Existing Item:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteItem.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteItem.Location = new System.Drawing.Point(674, 387);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(68, 54);
            this.buttonDeleteItem.TabIndex = 14;
            this.buttonDeleteItem.Text = "Delete Item";
            this.buttonDeleteItem.UseVisualStyleBackColor = false;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // buttonSaveMenu
            // 
            this.buttonSaveMenu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonSaveMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveMenu.Location = new System.Drawing.Point(973, 461);
            this.buttonSaveMenu.Name = "buttonSaveMenu";
            this.buttonSaveMenu.Size = new System.Drawing.Size(107, 82);
            this.buttonSaveMenu.TabIndex = 15;
            this.buttonSaveMenu.Text = "Save Menu";
            this.buttonSaveMenu.UseVisualStyleBackColor = false;
            this.buttonSaveMenu.Click += new System.EventHandler(this.buttonSaveMenu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(536, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "Item Price:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxCurrentItemPrice
            // 
            this.textBoxCurrentItemPrice.Enabled = false;
            this.textBoxCurrentItemPrice.Location = new System.Drawing.Point(608, 146);
            this.textBoxCurrentItemPrice.Name = "textBoxCurrentItemPrice";
            this.textBoxCurrentItemPrice.Size = new System.Drawing.Size(100, 21);
            this.textBoxCurrentItemPrice.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(532, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 14);
            this.label8.TabIndex = 17;
            this.label8.Text = "Item Name:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxCurrentItemName
            // 
            this.textBoxCurrentItemName.Enabled = false;
            this.textBoxCurrentItemName.Location = new System.Drawing.Point(608, 118);
            this.textBoxCurrentItemName.Name = "textBoxCurrentItemName";
            this.textBoxCurrentItemName.Size = new System.Drawing.Size(100, 21);
            this.textBoxCurrentItemName.TabIndex = 16;
            // 
            // buttonOpenJSON
            // 
            this.buttonOpenJSON.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenJSON.Location = new System.Drawing.Point(655, 462);
            this.buttonOpenJSON.Name = "buttonOpenJSON";
            this.buttonOpenJSON.Size = new System.Drawing.Size(112, 52);
            this.buttonOpenJSON.TabIndex = 20;
            this.buttonOpenJSON.Text = "Open .Json";
            this.buttonOpenJSON.UseVisualStyleBackColor = true;
            this.buttonOpenJSON.Click += new System.EventHandler(this.buttonOpenJSON_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(792, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 14);
            this.label9.TabIndex = 22;
            this.label9.Text = "Restaurant Name:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBoxRestaurantName
            // 
            this.textBoxRestaurantName.Location = new System.Drawing.Point(900, 27);
            this.textBoxRestaurantName.Name = "textBoxRestaurantName";
            this.textBoxRestaurantName.Size = new System.Drawing.Size(100, 21);
            this.textBoxRestaurantName.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(799, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 14);
            this.label10.TabIndex = 24;
            this.label10.Text = "Restaurant Icon:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(767, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 14);
            this.label11.TabIndex = 26;
            this.label11.Text = "Restaurant Description:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBoxRestaurantDescription
            // 
            this.textBoxRestaurantDescription.Location = new System.Drawing.Point(900, 153);
            this.textBoxRestaurantDescription.Multiline = true;
            this.textBoxRestaurantDescription.Name = "textBoxRestaurantDescription";
            this.textBoxRestaurantDescription.Size = new System.Drawing.Size(185, 88);
            this.textBoxRestaurantDescription.TabIndex = 25;
            // 
            // buttonSaveItem
            // 
            this.buttonSaveItem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonSaveItem.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveItem.Location = new System.Drawing.Point(527, 359);
            this.buttonSaveItem.Name = "buttonSaveItem";
            this.buttonSaveItem.Size = new System.Drawing.Size(107, 82);
            this.buttonSaveItem.TabIndex = 27;
            this.buttonSaveItem.Text = "Save Item ";
            this.buttonSaveItem.UseVisualStyleBackColor = false;
            this.buttonSaveItem.Click += new System.EventHandler(this.buttonSaveItem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(469, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 14);
            this.label12.TabIndex = 29;
            this.label12.Text = "Select Existing Category:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(608, 60);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 22);
            this.comboBoxCategory.TabIndex = 28;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(241, 494);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 14);
            this.label13.TabIndex = 32;
            this.label13.Text = "Webserver URL:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(328, 491);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(158, 21);
            this.textBoxURL.TabIndex = 31;
            this.textBoxURL.Text = "http://149.248.9.96/sample.json";
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
            this.listViewItems.Location = new System.Drawing.Point(877, 282);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(212, 154);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(870, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 14);
            this.label3.TabIndex = 41;
            this.label3.Text = "All Menu Items";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(242, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 14);
            this.label14.TabIndex = 43;
            this.label14.Text = "Item Category:";
            this.label14.Click += new System.EventHandler(this.label14_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(229, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 14);
            this.label15.TabIndex = 45;
            this.label15.Text = "Item Description:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // textBoxNewItemDescription
            // 
            this.textBoxNewItemDescription.Location = new System.Drawing.Point(326, 160);
            this.textBoxNewItemDescription.Multiline = true;
            this.textBoxNewItemDescription.Name = "textBoxNewItemDescription";
            this.textBoxNewItemDescription.Size = new System.Drawing.Size(148, 88);
            this.textBoxNewItemDescription.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(205, 34);
            this.label16.TabIndex = 46;
            this.label16.Text = "New Category:";
            // 
            // comboBoxNewItemCategory
            // 
            this.comboBoxNewItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewItemCategory.FormattingEnabled = true;
            this.comboBoxNewItemCategory.Location = new System.Drawing.Point(325, 60);
            this.comboBoxNewItemCategory.Name = "comboBoxNewItemCategory";
            this.comboBoxNewItemCategory.Size = new System.Drawing.Size(121, 22);
            this.comboBoxNewItemCategory.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 14);
            this.label17.TabIndex = 49;
            this.label17.Text = "Category Name:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // textBoxNewCategory
            // 
            this.textBoxNewCategory.Location = new System.Drawing.Point(97, 56);
            this.textBoxNewCategory.Name = "textBoxNewCategory";
            this.textBoxNewCategory.Size = new System.Drawing.Size(100, 21);
            this.textBoxNewCategory.TabIndex = 48;
            this.textBoxNewCategory.TextChanged += new System.EventHandler(this.textBoxNewCategory_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(19, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 28);
            this.label18.TabIndex = 53;
            this.label18.Text = "Category\r\nDescription:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // textBoxNewCategoryDescription
            // 
            this.textBoxNewCategoryDescription.Location = new System.Drawing.Point(97, 89);
            this.textBoxNewCategoryDescription.Multiline = true;
            this.textBoxNewCategoryDescription.Name = "textBoxNewCategoryDescription";
            this.textBoxNewCategoryDescription.Size = new System.Drawing.Size(138, 88);
            this.textBoxNewCategoryDescription.TabIndex = 52;
            // 
            // buttonNewCategoryPicture
            // 
            this.buttonNewCategoryPicture.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewCategoryPicture.Location = new System.Drawing.Point(7, 216);
            this.buttonNewCategoryPicture.Name = "buttonNewCategoryPicture";
            this.buttonNewCategoryPicture.Size = new System.Drawing.Size(75, 56);
            this.buttonNewCategoryPicture.TabIndex = 51;
            this.buttonNewCategoryPicture.Text = "Add Category Picture";
            this.buttonNewCategoryPicture.UseVisualStyleBackColor = true;
            this.buttonNewCategoryPicture.Click += new System.EventHandler(this.buttonNewCategoryPicture_Click);
            // 
            // buttonNewCategory
            // 
            this.buttonNewCategory.BackColor = System.Drawing.Color.Lime;
            this.buttonNewCategory.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewCategory.Location = new System.Drawing.Point(22, 300);
            this.buttonNewCategory.Name = "buttonNewCategory";
            this.buttonNewCategory.Size = new System.Drawing.Size(107, 82);
            this.buttonNewCategory.TabIndex = 54;
            this.buttonNewCategory.Text = "Add New Category";
            this.buttonNewCategory.UseVisualStyleBackColor = false;
            this.buttonNewCategory.Click += new System.EventHandler(this.buttonNewCategory_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(9, 384);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(231, 34);
            this.label19.TabIndex = 55;
            this.label19.Text = "Delete Category:";
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteCategory.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCategory.Location = new System.Drawing.Point(158, 430);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(68, 54);
            this.buttonDeleteCategory.TabIndex = 56;
            this.buttonDeleteCategory.Text = "Delete Category";
            this.buttonDeleteCategory.UseVisualStyleBackColor = false;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // comboBoxDeleteCategory
            // 
            this.comboBoxDeleteCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeleteCategory.FormattingEnabled = true;
            this.comboBoxDeleteCategory.Location = new System.Drawing.Point(31, 446);
            this.comboBoxDeleteCategory.Name = "comboBoxDeleteCategory";
            this.comboBoxDeleteCategory.Size = new System.Drawing.Size(121, 22);
            this.comboBoxDeleteCategory.TabIndex = 58;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(19, 430);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 14);
            this.label20.TabIndex = 57;
            this.label20.Text = "Item Category:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialogAddCategory";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(513, 187);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 14);
            this.label21.TabIndex = 62;
            this.label21.Text = "Item Description:";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // textBoxCurrentItemDescription
            // 
            this.textBoxCurrentItemDescription.Enabled = false;
            this.textBoxCurrentItemDescription.Location = new System.Drawing.Point(608, 174);
            this.textBoxCurrentItemDescription.Multiline = true;
            this.textBoxCurrentItemDescription.Name = "textBoxCurrentItemDescription";
            this.textBoxCurrentItemDescription.Size = new System.Drawing.Size(148, 88);
            this.textBoxCurrentItemDescription.TabIndex = 61;
            // 
            // buttonChangeCurrentItemPicture
            // 
            this.buttonChangeCurrentItemPicture.Enabled = false;
            this.buttonChangeCurrentItemPicture.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeCurrentItemPicture.Location = new System.Drawing.Point(560, 295);
            this.buttonChangeCurrentItemPicture.Name = "buttonChangeCurrentItemPicture";
            this.buttonChangeCurrentItemPicture.Size = new System.Drawing.Size(75, 56);
            this.buttonChangeCurrentItemPicture.TabIndex = 60;
            this.buttonChangeCurrentItemPicture.Text = "Add Item Picture";
            this.buttonChangeCurrentItemPicture.UseVisualStyleBackColor = true;
            this.buttonChangeCurrentItemPicture.Click += new System.EventHandler(this.buttonChangeCurrentItemPicture_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(488, 493);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 14);
            this.label22.TabIndex = 66;
            this.label22.Text = "Password:";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(548, 490);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 21);
            this.textBoxPassword.TabIndex = 65;
            this.textBoxPassword.Text = "password";
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(486, 465);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 14);
            this.label23.TabIndex = 64;
            this.label23.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(548, 462);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 21);
            this.textBoxUsername.TabIndex = 63;
            this.textBoxUsername.Text = "username";
            // 
            // buttonRestaurantIcon
            // 
            this.buttonRestaurantIcon.Enabled = false;
            this.buttonRestaurantIcon.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestaurantIcon.Location = new System.Drawing.Point(892, 70);
            this.buttonRestaurantIcon.Name = "buttonRestaurantIcon";
            this.buttonRestaurantIcon.Size = new System.Drawing.Size(75, 56);
            this.buttonRestaurantIcon.TabIndex = 68;
            this.buttonRestaurantIcon.Text = "Add Restaurant Icon";
            this.buttonRestaurantIcon.UseVisualStyleBackColor = true;
            this.buttonRestaurantIcon.Click += new System.EventHandler(this.buttonRestaurantIcon_Click);
            // 
            // pictureBoxRestaurantIcon
            // 
            this.pictureBoxRestaurantIcon.Location = new System.Drawing.Point(982, 51);
            this.pictureBoxRestaurantIcon.Name = "pictureBoxRestaurantIcon";
            this.pictureBoxRestaurantIcon.Size = new System.Drawing.Size(89, 96);
            this.pictureBoxRestaurantIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRestaurantIcon.TabIndex = 67;
            this.pictureBoxRestaurantIcon.TabStop = false;
            // 
            // pictureBoxCurrentItemPicture
            // 
            this.pictureBoxCurrentItemPicture.Location = new System.Drawing.Point(650, 276);
            this.pictureBoxCurrentItemPicture.Name = "pictureBoxCurrentItemPicture";
            this.pictureBoxCurrentItemPicture.Size = new System.Drawing.Size(89, 96);
            this.pictureBoxCurrentItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCurrentItemPicture.TabIndex = 59;
            this.pictureBoxCurrentItemPicture.TabStop = false;
            this.pictureBoxCurrentItemPicture.Click += new System.EventHandler(this.pictureBoxCurrentItemPicture_Click);
            // 
            // pictureBoxCategoryPicture
            // 
            this.pictureBoxCategoryPicture.Location = new System.Drawing.Point(97, 197);
            this.pictureBoxCategoryPicture.Name = "pictureBoxCategoryPicture";
            this.pictureBoxCategoryPicture.Size = new System.Drawing.Size(89, 96);
            this.pictureBoxCategoryPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCategoryPicture.TabIndex = 50;
            this.pictureBoxCategoryPicture.TabStop = false;
            // 
            // pictureBoxItemPicture
            // 
            this.pictureBoxItemPicture.Location = new System.Drawing.Point(368, 262);
            this.pictureBoxItemPicture.Name = "pictureBoxItemPicture";
            this.pictureBoxItemPicture.Size = new System.Drawing.Size(89, 96);
            this.pictureBoxItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxItemPicture.TabIndex = 5;
            this.pictureBoxItemPicture.TabStop = false;
            // 
            // textBoxNewMenu
            // 
            this.textBoxNewMenu.Location = new System.Drawing.Point(85, 491);
            this.textBoxNewMenu.Name = "textBoxNewMenu";
            this.textBoxNewMenu.Size = new System.Drawing.Size(101, 21);
            this.textBoxNewMenu.TabIndex = 69;
            this.textBoxNewMenu.TextChanged += new System.EventHandler(this.textBoxNewMenu_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(4, 495);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 14);
            this.label24.TabIndex = 70;
            this.label24.Text = "Menu Name:";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1101, 545);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.textBoxNewMenu);
            this.Controls.Add(this.buttonRestaurantIcon);
            this.Controls.Add(this.pictureBoxRestaurantIcon);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.textBoxUsername);
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
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonSaveItem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxRestaurantDescription);
            this.Controls.Add(this.label10);
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
            this.Controls.Add(this.buttonAddItemPicture);
            this.Controls.Add(this.pictureBoxItemPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewItemPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNewItemName);
            this.Controls.Add(this.buttonAddNewItem);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Manager Utility Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestaurantIcon)).EndInit();
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxRestaurantDescription;
        private System.Windows.Forms.Button buttonSaveItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxCategory;
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
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonRestaurantIcon;
        private System.Windows.Forms.PictureBox pictureBoxRestaurantIcon;
        private System.Windows.Forms.TextBox textBoxNewMenu;
        private System.Windows.Forms.Label label24;
    }
}

