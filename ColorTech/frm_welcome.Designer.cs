namespace ColorTech
{
    partial class frm_welcome
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
            this.tab_welcomeScreen = new System.Windows.Forms.TabControl();
            this.tabPage_main = new System.Windows.Forms.TabPage();
            this.grp_productMain = new System.Windows.Forms.GroupBox();
            this.combo_proHeadMain = new System.Windows.Forms.ComboBox();
            this.lbl_proHeadMain = new System.Windows.Forms.Label();
            this.combo_proNameMain = new System.Windows.Forms.ComboBox();
            this.submit_productMain = new System.Windows.Forms.Button();
            this.lbl_proNameMain = new System.Windows.Forms.Label();
            this.tabPage_sub = new System.Windows.Forms.TabPage();
            this.grp_productSub = new System.Windows.Forms.GroupBox();
            this.combo_proHeadSub = new System.Windows.Forms.ComboBox();
            this.lbl_proHeadSub = new System.Windows.Forms.Label();
            this.combo_proNameSub = new System.Windows.Forms.ComboBox();
            this.submit_productSub = new System.Windows.Forms.Button();
            this.lbl_proNameSub = new System.Windows.Forms.Label();
            this.tabPage_raw = new System.Windows.Forms.TabPage();
            this.grp_stockEntry = new System.Windows.Forms.GroupBox();
            this.lbl_mrnoStock = new System.Windows.Forms.Label();
            this.txt_mrnoStock = new System.Windows.Forms.TextBox();
            this.submit_stockEntry = new System.Windows.Forms.Button();
            this.dateTime_stock = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateStock = new System.Windows.Forms.Label();
            this.lbl_quantityStock = new System.Windows.Forms.Label();
            this.txt_quantityStock = new System.Windows.Forms.TextBox();
            this.txt_itemStock = new System.Windows.Forms.TextBox();
            this.lbl_itemStock = new System.Windows.Forms.Label();
            this.grp_newEntry = new System.Windows.Forms.GroupBox();
            this.dateTime_new = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateNew = new System.Windows.Forms.Label();
            this.lbl_mrnoNew = new System.Windows.Forms.Label();
            this.txt_mrnoNew = new System.Windows.Forms.TextBox();
            this.submit_newEntry = new System.Windows.Forms.Button();
            this.txt_quantityNew = new System.Windows.Forms.TextBox();
            this.lbl_itemNew = new System.Windows.Forms.Label();
            this.lbl_quantityNew = new System.Windows.Forms.Label();
            this.txt_itemNew = new System.Windows.Forms.TextBox();
            this.tabPage_master = new System.Windows.Forms.TabPage();
            this.grp_productMaster = new System.Windows.Forms.GroupBox();
            this.combo_proHeadMaster = new System.Windows.Forms.ComboBox();
            this.lbl_proHeadMaster = new System.Windows.Forms.Label();
            this.combo_proNameMaster = new System.Windows.Forms.ComboBox();
            this.submit_productMaster = new System.Windows.Forms.Button();
            this.lbl_proNameMaster = new System.Windows.Forms.Label();
            this.tab_welcomeScreen.SuspendLayout();
            this.tabPage_main.SuspendLayout();
            this.grp_productMain.SuspendLayout();
            this.tabPage_sub.SuspendLayout();
            this.grp_productSub.SuspendLayout();
            this.tabPage_raw.SuspendLayout();
            this.grp_stockEntry.SuspendLayout();
            this.grp_newEntry.SuspendLayout();
            this.tabPage_master.SuspendLayout();
            this.grp_productMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_welcomeScreen
            // 
            this.tab_welcomeScreen.Controls.Add(this.tabPage_main);
            this.tab_welcomeScreen.Controls.Add(this.tabPage_sub);
            this.tab_welcomeScreen.Controls.Add(this.tabPage_raw);
            this.tab_welcomeScreen.Controls.Add(this.tabPage_master);
            this.tab_welcomeScreen.Location = new System.Drawing.Point(4, 7);
            this.tab_welcomeScreen.Name = "tab_welcomeScreen";
            this.tab_welcomeScreen.SelectedIndex = 0;
            this.tab_welcomeScreen.Size = new System.Drawing.Size(474, 234);
            this.tab_welcomeScreen.TabIndex = 3;
            // 
            // tabPage_main
            // 
            this.tabPage_main.Controls.Add(this.grp_productMain);
            this.tabPage_main.Location = new System.Drawing.Point(4, 22);
            this.tabPage_main.Name = "tabPage_main";
            this.tabPage_main.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_main.Size = new System.Drawing.Size(466, 208);
            this.tabPage_main.TabIndex = 0;
            this.tabPage_main.Text = "Main Batch";
            this.tabPage_main.UseVisualStyleBackColor = true;
            // 
            // grp_productMain
            // 
            this.grp_productMain.Controls.Add(this.combo_proHeadMain);
            this.grp_productMain.Controls.Add(this.lbl_proHeadMain);
            this.grp_productMain.Controls.Add(this.combo_proNameMain);
            this.grp_productMain.Controls.Add(this.submit_productMain);
            this.grp_productMain.Controls.Add(this.lbl_proNameMain);
            this.grp_productMain.Location = new System.Drawing.Point(6, 6);
            this.grp_productMain.Name = "grp_productMain";
            this.grp_productMain.Size = new System.Drawing.Size(281, 150);
            this.grp_productMain.TabIndex = 1;
            this.grp_productMain.TabStop = false;
            this.grp_productMain.Text = "Product Name";
            // 
            // combo_proHeadMain
            // 
            this.combo_proHeadMain.FormattingEnabled = true;
            this.combo_proHeadMain.Location = new System.Drawing.Point(127, 25);
            this.combo_proHeadMain.Name = "combo_proHeadMain";
            this.combo_proHeadMain.Size = new System.Drawing.Size(131, 21);
            this.combo_proHeadMain.TabIndex = 5;
            // 
            // lbl_proHeadMain
            // 
            this.lbl_proHeadMain.AutoSize = true;
            this.lbl_proHeadMain.Location = new System.Drawing.Point(6, 28);
            this.lbl_proHeadMain.Name = "lbl_proHeadMain";
            this.lbl_proHeadMain.Size = new System.Drawing.Size(73, 13);
            this.lbl_proHeadMain.TabIndex = 4;
            this.lbl_proHeadMain.Text = "Product Head";
            // 
            // combo_proNameMain
            // 
            this.combo_proNameMain.FormattingEnabled = true;
            this.combo_proNameMain.Items.AddRange(new object[] {
            "Isotrap Clear Gloss",
            "Isotrap Clear Matt",
            "UV Pro Clear Gloss",
            "Isotrap White Gloss",
            "Isotrap White Matt",
            "UV Pro White Gloss",
            "Isotrap Black Gloss",
            "Isotrap Black Matt",
            "UV Pro Black Gloss"});
            this.combo_proNameMain.Location = new System.Drawing.Point(127, 67);
            this.combo_proNameMain.Name = "combo_proNameMain";
            this.combo_proNameMain.Size = new System.Drawing.Size(131, 21);
            this.combo_proNameMain.TabIndex = 3;
            // 
            // submit_productMain
            // 
            this.submit_productMain.Location = new System.Drawing.Point(127, 104);
            this.submit_productMain.Name = "submit_productMain";
            this.submit_productMain.Size = new System.Drawing.Size(131, 23);
            this.submit_productMain.TabIndex = 2;
            this.submit_productMain.Text = "Submit";
            this.submit_productMain.UseVisualStyleBackColor = true;
            this.submit_productMain.Click += new System.EventHandler(this.submit_productMain_Click);
            // 
            // lbl_proNameMain
            // 
            this.lbl_proNameMain.AutoSize = true;
            this.lbl_proNameMain.Location = new System.Drawing.Point(6, 71);
            this.lbl_proNameMain.Name = "lbl_proNameMain";
            this.lbl_proNameMain.Size = new System.Drawing.Size(75, 13);
            this.lbl_proNameMain.TabIndex = 0;
            this.lbl_proNameMain.Text = "Product Name";
            // 
            // tabPage_sub
            // 
            this.tabPage_sub.Controls.Add(this.grp_productSub);
            this.tabPage_sub.Location = new System.Drawing.Point(4, 22);
            this.tabPage_sub.Name = "tabPage_sub";
            this.tabPage_sub.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_sub.Size = new System.Drawing.Size(466, 208);
            this.tabPage_sub.TabIndex = 1;
            this.tabPage_sub.Text = "Sub Batch";
            this.tabPage_sub.UseVisualStyleBackColor = true;
            // 
            // grp_productSub
            // 
            this.grp_productSub.Controls.Add(this.combo_proHeadSub);
            this.grp_productSub.Controls.Add(this.lbl_proHeadSub);
            this.grp_productSub.Controls.Add(this.combo_proNameSub);
            this.grp_productSub.Controls.Add(this.submit_productSub);
            this.grp_productSub.Controls.Add(this.lbl_proNameSub);
            this.grp_productSub.Location = new System.Drawing.Point(6, 6);
            this.grp_productSub.Name = "grp_productSub";
            this.grp_productSub.Size = new System.Drawing.Size(281, 148);
            this.grp_productSub.TabIndex = 2;
            this.grp_productSub.TabStop = false;
            this.grp_productSub.Text = "Product Name";
            // 
            // combo_proHeadSub
            // 
            this.combo_proHeadSub.FormattingEnabled = true;
            this.combo_proHeadSub.Location = new System.Drawing.Point(127, 30);
            this.combo_proHeadSub.Name = "combo_proHeadSub";
            this.combo_proHeadSub.Size = new System.Drawing.Size(131, 21);
            this.combo_proHeadSub.TabIndex = 7;
            // 
            // lbl_proHeadSub
            // 
            this.lbl_proHeadSub.AutoSize = true;
            this.lbl_proHeadSub.Location = new System.Drawing.Point(8, 33);
            this.lbl_proHeadSub.Name = "lbl_proHeadSub";
            this.lbl_proHeadSub.Size = new System.Drawing.Size(73, 13);
            this.lbl_proHeadSub.TabIndex = 6;
            this.lbl_proHeadSub.Text = "Product Head";
            // 
            // combo_proNameSub
            // 
            this.combo_proNameSub.FormattingEnabled = true;
            this.combo_proNameSub.Items.AddRange(new object[] {
            "Isotrap Clear Gloss",
            "Isotrap Clear Matt",
            "UV Pro Clear Gloss",
            "Isotrap White Gloss",
            "Isotrap White Matt",
            "UV Pro White Gloss",
            "Isotrap Black Gloss",
            "Isotrap Black Matt",
            "UV Pro Black Gloss"});
            this.combo_proNameSub.Location = new System.Drawing.Point(127, 67);
            this.combo_proNameSub.Name = "combo_proNameSub";
            this.combo_proNameSub.Size = new System.Drawing.Size(131, 21);
            this.combo_proNameSub.TabIndex = 3;
            // 
            // submit_productSub
            // 
            this.submit_productSub.Location = new System.Drawing.Point(127, 104);
            this.submit_productSub.Name = "submit_productSub";
            this.submit_productSub.Size = new System.Drawing.Size(131, 23);
            this.submit_productSub.TabIndex = 2;
            this.submit_productSub.Text = "Submit";
            this.submit_productSub.UseVisualStyleBackColor = true;
            this.submit_productSub.Click += new System.EventHandler(this.submit_productSub_Click);
            // 
            // lbl_proNameSub
            // 
            this.lbl_proNameSub.AutoSize = true;
            this.lbl_proNameSub.Location = new System.Drawing.Point(8, 70);
            this.lbl_proNameSub.Name = "lbl_proNameSub";
            this.lbl_proNameSub.Size = new System.Drawing.Size(75, 13);
            this.lbl_proNameSub.TabIndex = 0;
            this.lbl_proNameSub.Text = "Product Name";
            this.lbl_proNameSub.Click += new System.EventHandler(this.lbl_proNameSub_Click);
            // 
            // tabPage_raw
            // 
            this.tabPage_raw.Controls.Add(this.grp_stockEntry);
            this.tabPage_raw.Controls.Add(this.grp_newEntry);
            this.tabPage_raw.Location = new System.Drawing.Point(4, 22);
            this.tabPage_raw.Name = "tabPage_raw";
            this.tabPage_raw.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_raw.Size = new System.Drawing.Size(466, 208);
            this.tabPage_raw.TabIndex = 2;
            this.tabPage_raw.Text = "Raw Material";
            this.tabPage_raw.UseVisualStyleBackColor = true;
            // 
            // grp_stockEntry
            // 
            this.grp_stockEntry.Controls.Add(this.lbl_mrnoStock);
            this.grp_stockEntry.Controls.Add(this.txt_mrnoStock);
            this.grp_stockEntry.Controls.Add(this.submit_stockEntry);
            this.grp_stockEntry.Controls.Add(this.dateTime_stock);
            this.grp_stockEntry.Controls.Add(this.lbl_dateStock);
            this.grp_stockEntry.Controls.Add(this.lbl_quantityStock);
            this.grp_stockEntry.Controls.Add(this.txt_quantityStock);
            this.grp_stockEntry.Controls.Add(this.txt_itemStock);
            this.grp_stockEntry.Controls.Add(this.lbl_itemStock);
            this.grp_stockEntry.Location = new System.Drawing.Point(238, 6);
            this.grp_stockEntry.Name = "grp_stockEntry";
            this.grp_stockEntry.Size = new System.Drawing.Size(223, 198);
            this.grp_stockEntry.TabIndex = 5;
            this.grp_stockEntry.TabStop = false;
            this.grp_stockEntry.Text = "Stock Entry";
            // 
            // lbl_mrnoStock
            // 
            this.lbl_mrnoStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mrnoStock.AutoSize = true;
            this.lbl_mrnoStock.Location = new System.Drawing.Point(6, 131);
            this.lbl_mrnoStock.Name = "lbl_mrnoStock";
            this.lbl_mrnoStock.Size = new System.Drawing.Size(44, 13);
            this.lbl_mrnoStock.TabIndex = 8;
            this.lbl_mrnoStock.Text = "M.R.No";
            // 
            // txt_mrnoStock
            // 
            this.txt_mrnoStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mrnoStock.Location = new System.Drawing.Point(73, 128);
            this.txt_mrnoStock.Name = "txt_mrnoStock";
            this.txt_mrnoStock.Size = new System.Drawing.Size(135, 20);
            this.txt_mrnoStock.TabIndex = 7;
            // 
            // submit_stockEntry
            // 
            this.submit_stockEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.submit_stockEntry.Location = new System.Drawing.Point(73, 159);
            this.submit_stockEntry.Name = "submit_stockEntry";
            this.submit_stockEntry.Size = new System.Drawing.Size(135, 23);
            this.submit_stockEntry.TabIndex = 5;
            this.submit_stockEntry.Text = "Submit";
            this.submit_stockEntry.UseVisualStyleBackColor = true;
            // 
            // dateTime_stock
            // 
            this.dateTime_stock.CustomFormat = "dd MMMM, yyyy";
            this.dateTime_stock.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_stock.Location = new System.Drawing.Point(73, 20);
            this.dateTime_stock.Name = "dateTime_stock";
            this.dateTime_stock.Size = new System.Drawing.Size(135, 20);
            this.dateTime_stock.TabIndex = 6;
            // 
            // lbl_dateStock
            // 
            this.lbl_dateStock.AutoSize = true;
            this.lbl_dateStock.Location = new System.Drawing.Point(6, 26);
            this.lbl_dateStock.Name = "lbl_dateStock";
            this.lbl_dateStock.Size = new System.Drawing.Size(30, 13);
            this.lbl_dateStock.TabIndex = 0;
            this.lbl_dateStock.Text = "Date";
            // 
            // lbl_quantityStock
            // 
            this.lbl_quantityStock.AutoSize = true;
            this.lbl_quantityStock.Location = new System.Drawing.Point(6, 92);
            this.lbl_quantityStock.Name = "lbl_quantityStock";
            this.lbl_quantityStock.Size = new System.Drawing.Size(46, 13);
            this.lbl_quantityStock.TabIndex = 2;
            this.lbl_quantityStock.Text = "Quantity";
            // 
            // txt_quantityStock
            // 
            this.txt_quantityStock.Location = new System.Drawing.Point(73, 89);
            this.txt_quantityStock.Name = "txt_quantityStock";
            this.txt_quantityStock.Size = new System.Drawing.Size(135, 20);
            this.txt_quantityStock.TabIndex = 5;
            // 
            // txt_itemStock
            // 
            this.txt_itemStock.Location = new System.Drawing.Point(73, 55);
            this.txt_itemStock.Name = "txt_itemStock";
            this.txt_itemStock.Size = new System.Drawing.Size(135, 20);
            this.txt_itemStock.TabIndex = 4;
            // 
            // lbl_itemStock
            // 
            this.lbl_itemStock.AutoSize = true;
            this.lbl_itemStock.Location = new System.Drawing.Point(6, 58);
            this.lbl_itemStock.Name = "lbl_itemStock";
            this.lbl_itemStock.Size = new System.Drawing.Size(58, 13);
            this.lbl_itemStock.TabIndex = 1;
            this.lbl_itemStock.Text = "Item Name";
            // 
            // grp_newEntry
            // 
            this.grp_newEntry.Controls.Add(this.dateTime_new);
            this.grp_newEntry.Controls.Add(this.lbl_dateNew);
            this.grp_newEntry.Controls.Add(this.lbl_mrnoNew);
            this.grp_newEntry.Controls.Add(this.txt_mrnoNew);
            this.grp_newEntry.Controls.Add(this.submit_newEntry);
            this.grp_newEntry.Controls.Add(this.txt_quantityNew);
            this.grp_newEntry.Controls.Add(this.lbl_itemNew);
            this.grp_newEntry.Controls.Add(this.lbl_quantityNew);
            this.grp_newEntry.Controls.Add(this.txt_itemNew);
            this.grp_newEntry.Location = new System.Drawing.Point(6, 6);
            this.grp_newEntry.Name = "grp_newEntry";
            this.grp_newEntry.Size = new System.Drawing.Size(226, 198);
            this.grp_newEntry.TabIndex = 4;
            this.grp_newEntry.TabStop = false;
            this.grp_newEntry.Text = "New Entry";
            // 
            // dateTime_new
            // 
            this.dateTime_new.CustomFormat = "dd MMMM, yyyy";
            this.dateTime_new.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_new.Location = new System.Drawing.Point(69, 20);
            this.dateTime_new.Name = "dateTime_new";
            this.dateTime_new.Size = new System.Drawing.Size(135, 20);
            this.dateTime_new.TabIndex = 12;
            // 
            // lbl_dateNew
            // 
            this.lbl_dateNew.AutoSize = true;
            this.lbl_dateNew.Location = new System.Drawing.Point(6, 26);
            this.lbl_dateNew.Name = "lbl_dateNew";
            this.lbl_dateNew.Size = new System.Drawing.Size(30, 13);
            this.lbl_dateNew.TabIndex = 11;
            this.lbl_dateNew.Text = "Date";
            // 
            // lbl_mrnoNew
            // 
            this.lbl_mrnoNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mrnoNew.AutoSize = true;
            this.lbl_mrnoNew.Location = new System.Drawing.Point(6, 131);
            this.lbl_mrnoNew.Name = "lbl_mrnoNew";
            this.lbl_mrnoNew.Size = new System.Drawing.Size(44, 13);
            this.lbl_mrnoNew.TabIndex = 10;
            this.lbl_mrnoNew.Text = "M.R.No";
            // 
            // txt_mrnoNew
            // 
            this.txt_mrnoNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mrnoNew.Location = new System.Drawing.Point(69, 128);
            this.txt_mrnoNew.Name = "txt_mrnoNew";
            this.txt_mrnoNew.Size = new System.Drawing.Size(135, 20);
            this.txt_mrnoNew.TabIndex = 9;
            // 
            // submit_newEntry
            // 
            this.submit_newEntry.Location = new System.Drawing.Point(69, 159);
            this.submit_newEntry.Name = "submit_newEntry";
            this.submit_newEntry.Size = new System.Drawing.Size(135, 23);
            this.submit_newEntry.TabIndex = 4;
            this.submit_newEntry.Text = "Submit";
            this.submit_newEntry.UseVisualStyleBackColor = true;
            this.submit_newEntry.Click += new System.EventHandler(this.submit_newEntry_Click);
            // 
            // txt_quantityNew
            // 
            this.txt_quantityNew.Location = new System.Drawing.Point(69, 89);
            this.txt_quantityNew.Name = "txt_quantityNew";
            this.txt_quantityNew.Size = new System.Drawing.Size(135, 20);
            this.txt_quantityNew.TabIndex = 3;
            // 
            // lbl_itemNew
            // 
            this.lbl_itemNew.AutoSize = true;
            this.lbl_itemNew.Location = new System.Drawing.Point(5, 58);
            this.lbl_itemNew.Name = "lbl_itemNew";
            this.lbl_itemNew.Size = new System.Drawing.Size(58, 13);
            this.lbl_itemNew.TabIndex = 0;
            this.lbl_itemNew.Text = "Item Name";
            // 
            // lbl_quantityNew
            // 
            this.lbl_quantityNew.AutoSize = true;
            this.lbl_quantityNew.Location = new System.Drawing.Point(6, 92);
            this.lbl_quantityNew.Name = "lbl_quantityNew";
            this.lbl_quantityNew.Size = new System.Drawing.Size(46, 13);
            this.lbl_quantityNew.TabIndex = 1;
            this.lbl_quantityNew.Text = "Quantity";
            // 
            // txt_itemNew
            // 
            this.txt_itemNew.Location = new System.Drawing.Point(69, 55);
            this.txt_itemNew.Name = "txt_itemNew";
            this.txt_itemNew.Size = new System.Drawing.Size(135, 20);
            this.txt_itemNew.TabIndex = 2;
            // 
            // tabPage_master
            // 
            this.tabPage_master.Controls.Add(this.grp_productMaster);
            this.tabPage_master.Location = new System.Drawing.Point(4, 22);
            this.tabPage_master.Name = "tabPage_master";
            this.tabPage_master.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_master.Size = new System.Drawing.Size(466, 208);
            this.tabPage_master.TabIndex = 3;
            this.tabPage_master.Text = "Master Batch";
            this.tabPage_master.UseVisualStyleBackColor = true;
            // 
            // grp_productMaster
            // 
            this.grp_productMaster.Controls.Add(this.combo_proHeadMaster);
            this.grp_productMaster.Controls.Add(this.lbl_proHeadMaster);
            this.grp_productMaster.Controls.Add(this.combo_proNameMaster);
            this.grp_productMaster.Controls.Add(this.submit_productMaster);
            this.grp_productMaster.Controls.Add(this.lbl_proNameMaster);
            this.grp_productMaster.Location = new System.Drawing.Point(6, 6);
            this.grp_productMaster.Name = "grp_productMaster";
            this.grp_productMaster.Size = new System.Drawing.Size(281, 150);
            this.grp_productMaster.TabIndex = 2;
            this.grp_productMaster.TabStop = false;
            this.grp_productMaster.Text = "Product Name";
            // 
            // combo_proHeadMaster
            // 
            this.combo_proHeadMaster.FormattingEnabled = true;
            this.combo_proHeadMaster.Location = new System.Drawing.Point(127, 25);
            this.combo_proHeadMaster.Name = "combo_proHeadMaster";
            this.combo_proHeadMaster.Size = new System.Drawing.Size(131, 21);
            this.combo_proHeadMaster.TabIndex = 5;
            // 
            // lbl_proHeadMaster
            // 
            this.lbl_proHeadMaster.AutoSize = true;
            this.lbl_proHeadMaster.Location = new System.Drawing.Point(6, 28);
            this.lbl_proHeadMaster.Name = "lbl_proHeadMaster";
            this.lbl_proHeadMaster.Size = new System.Drawing.Size(73, 13);
            this.lbl_proHeadMaster.TabIndex = 4;
            this.lbl_proHeadMaster.Text = "Product Head";
            // 
            // combo_proNameMaster
            // 
            this.combo_proNameMaster.FormattingEnabled = true;
            this.combo_proNameMaster.Items.AddRange(new object[] {
            "Isotrap Clear Gloss",
            "Isotrap Clear Matt",
            "UV Pro Clear Gloss",
            "Isotrap White Gloss",
            "Isotrap White Matt",
            "UV Pro White Gloss",
            "Isotrap Black Gloss",
            "Isotrap Black Matt",
            "UV Pro Black Gloss"});
            this.combo_proNameMaster.Location = new System.Drawing.Point(127, 67);
            this.combo_proNameMaster.Name = "combo_proNameMaster";
            this.combo_proNameMaster.Size = new System.Drawing.Size(131, 21);
            this.combo_proNameMaster.TabIndex = 3;
            // 
            // submit_productMaster
            // 
            this.submit_productMaster.Location = new System.Drawing.Point(127, 104);
            this.submit_productMaster.Name = "submit_productMaster";
            this.submit_productMaster.Size = new System.Drawing.Size(131, 23);
            this.submit_productMaster.TabIndex = 2;
            this.submit_productMaster.Text = "Submit";
            this.submit_productMaster.UseVisualStyleBackColor = true;
            this.submit_productMaster.Click += new System.EventHandler(this.submit_productMaster_Click);
            // 
            // lbl_proNameMaster
            // 
            this.lbl_proNameMaster.AutoSize = true;
            this.lbl_proNameMaster.Location = new System.Drawing.Point(6, 71);
            this.lbl_proNameMaster.Name = "lbl_proNameMaster";
            this.lbl_proNameMaster.Size = new System.Drawing.Size(75, 13);
            this.lbl_proNameMaster.TabIndex = 0;
            this.lbl_proNameMaster.Text = "Product Name";
            // 
            // frm_welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(479, 242);
            this.Controls.Add(this.tab_welcomeScreen);
            this.Name = "frm_welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.frm_welcome_Load);
            this.tab_welcomeScreen.ResumeLayout(false);
            this.tabPage_main.ResumeLayout(false);
            this.grp_productMain.ResumeLayout(false);
            this.grp_productMain.PerformLayout();
            this.tabPage_sub.ResumeLayout(false);
            this.grp_productSub.ResumeLayout(false);
            this.grp_productSub.PerformLayout();
            this.tabPage_raw.ResumeLayout(false);
            this.grp_stockEntry.ResumeLayout(false);
            this.grp_stockEntry.PerformLayout();
            this.grp_newEntry.ResumeLayout(false);
            this.grp_newEntry.PerformLayout();
            this.tabPage_master.ResumeLayout(false);
            this.grp_productMaster.ResumeLayout(false);
            this.grp_productMaster.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_welcomeScreen;
        private System.Windows.Forms.TabPage tabPage_main;
        private System.Windows.Forms.GroupBox grp_productMain;
        private System.Windows.Forms.ComboBox combo_proNameMain;
        private System.Windows.Forms.Button submit_productMain;
        private System.Windows.Forms.Label lbl_proNameMain;
        private System.Windows.Forms.TabPage tabPage_sub;
        private System.Windows.Forms.GroupBox grp_productSub;
        private System.Windows.Forms.ComboBox combo_proNameSub;
        private System.Windows.Forms.Button submit_productSub;
        private System.Windows.Forms.Label lbl_proNameSub;
        private System.Windows.Forms.TabPage tabPage_raw;
        private System.Windows.Forms.GroupBox grp_stockEntry;
        private System.Windows.Forms.Label lbl_mrnoStock;
        private System.Windows.Forms.TextBox txt_mrnoStock;
        private System.Windows.Forms.Button submit_stockEntry;
        private System.Windows.Forms.DateTimePicker dateTime_stock;
        private System.Windows.Forms.Label lbl_dateStock;
        private System.Windows.Forms.Label lbl_quantityStock;
        private System.Windows.Forms.TextBox txt_quantityStock;
        private System.Windows.Forms.TextBox txt_itemStock;
        private System.Windows.Forms.Label lbl_itemStock;
        private System.Windows.Forms.GroupBox grp_newEntry;
        private System.Windows.Forms.Label lbl_mrnoNew;
        private System.Windows.Forms.TextBox txt_mrnoNew;
        private System.Windows.Forms.Button submit_newEntry;
        private System.Windows.Forms.TextBox txt_quantityNew;
        private System.Windows.Forms.Label lbl_itemNew;
        private System.Windows.Forms.Label lbl_quantityNew;
        private System.Windows.Forms.TextBox txt_itemNew;
        private System.Windows.Forms.DateTimePicker dateTime_new;
        private System.Windows.Forms.Label lbl_dateNew;
        private System.Windows.Forms.ComboBox combo_proHeadMain;
        private System.Windows.Forms.Label lbl_proHeadMain;
        private System.Windows.Forms.ComboBox combo_proHeadSub;
        private System.Windows.Forms.Label lbl_proHeadSub;
        private System.Windows.Forms.TabPage tabPage_master;
        private System.Windows.Forms.GroupBox grp_productMaster;
        private System.Windows.Forms.ComboBox combo_proHeadMaster;
        private System.Windows.Forms.Label lbl_proHeadMaster;
        private System.Windows.Forms.ComboBox combo_proNameMaster;
        private System.Windows.Forms.Button submit_productMaster;
        private System.Windows.Forms.Label lbl_proNameMaster;
    }
}