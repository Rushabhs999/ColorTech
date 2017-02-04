namespace ColorTech
{
    partial class frm_batchSheet
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grp_batchDetails = new System.Windows.Forms.GroupBox();
            this.tbl_batchDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.txt_Product = new System.Windows.Forms.TextBox();
            this.grp_batchAllDetails = new System.Windows.Forms.GroupBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.grp_Options = new System.Windows.Forms.GroupBox();
            this.lbl_batchNo = new System.Windows.Forms.Label();
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.lbl_batchSize = new System.Windows.Forms.Label();
            this.lbl_batchStarted = new System.Windows.Forms.Label();
            this.lbl_batchCompleted = new System.Windows.Forms.Label();
            this.txt_batchNo = new System.Windows.Forms.TextBox();
            this.txt_Customer = new System.Windows.Forms.TextBox();
            this.txt_batchSize = new System.Windows.Forms.TextBox();
            this.txt_batchStarted = new System.Windows.Forms.TextBox();
            this.txt_batchCompleted = new System.Windows.Forms.TextBox();
            this.grpDetailsRight = new System.Windows.Forms.GroupBox();
            this.grpMaterial = new System.Windows.Forms.GroupBox();
            this.tbl_material = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_weightedBy = new System.Windows.Forms.Label();
            this.txt_weightedBy = new System.Windows.Forms.TextBox();
            this.lbl_checkedBy = new System.Windows.Forms.Label();
            this.lbl_packingMaterial = new System.Windows.Forms.Label();
            this.txt_checkedBy = new System.Windows.Forms.TextBox();
            this.txt_packingMaterial = new System.Windows.Forms.TextBox();
            this.grpDetailsLeft = new System.Windows.Forms.GroupBox();
            this.grpQAstatus = new System.Windows.Forms.GroupBox();
            this.tbl_qaStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_sampleGiven = new System.Windows.Forms.Label();
            this.txts_sampleGiven = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_density = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.txt_density = new System.Windows.Forms.TextBox();
            this.lbl_testedBy = new System.Windows.Forms.Label();
            this.txt_testedBy = new System.Windows.Forms.TextBox();
            this.grp_filteredBy = new System.Windows.Forms.GroupBox();
            this.tbl_filteredBy = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_machineNo = new System.Windows.Forms.Label();
            this.txt_machineNo = new System.Windows.Forms.TextBox();
            this.lbl_unitNo = new System.Windows.Forms.Label();
            this.lbl_viscoity = new System.Windows.Forms.Label();
            this.txt_UnitNo = new System.Windows.Forms.TextBox();
            this.txt_viscocity = new System.Windows.Forms.TextBox();
            this.lbl_solid = new System.Windows.Forms.Label();
            this.txt_solid = new System.Windows.Forms.TextBox();
            this.grp_quantity = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_quantityPacked = new System.Windows.Forms.Label();
            this.txt_quantityPacked = new System.Windows.Forms.TextBox();
            this.lbl_packedBy = new System.Windows.Forms.Label();
            this.txt_packedBy = new System.Windows.Forms.TextBox();
            this.grp_batchDetails.SuspendLayout();
            this.tbl_batchDetails.SuspendLayout();
            this.grp_batchAllDetails.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.grpDetailsRight.SuspendLayout();
            this.grpMaterial.SuspendLayout();
            this.tbl_material.SuspendLayout();
            this.grpDetailsLeft.SuspendLayout();
            this.grpQAstatus.SuspendLayout();
            this.tbl_qaStatus.SuspendLayout();
            this.grp_filteredBy.SuspendLayout();
            this.tbl_filteredBy.SuspendLayout();
            this.grp_quantity.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MMMM , yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(770, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // grp_batchDetails
            // 
            this.grp_batchDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_batchDetails.Controls.Add(this.tbl_batchDetails);
            this.grp_batchDetails.Location = new System.Drawing.Point(6, 19);
            this.grp_batchDetails.Name = "grp_batchDetails";
            this.grp_batchDetails.Size = new System.Drawing.Size(662, 121);
            this.grp_batchDetails.TabIndex = 1;
            this.grp_batchDetails.TabStop = false;
            this.grp_batchDetails.Text = "Batch Details";
            // 
            // tbl_batchDetails
            // 
            this.tbl_batchDetails.ColumnCount = 4;
            this.tbl_batchDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_batchDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_batchDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_batchDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_batchDetails.Controls.Add(this.lbl_Product, 0, 0);
            this.tbl_batchDetails.Controls.Add(this.txt_Product, 1, 0);
            this.tbl_batchDetails.Controls.Add(this.lbl_batchNo, 0, 1);
            this.tbl_batchDetails.Controls.Add(this.lbl_Customer, 0, 2);
            this.tbl_batchDetails.Controls.Add(this.lbl_batchSize, 2, 0);
            this.tbl_batchDetails.Controls.Add(this.lbl_batchStarted, 2, 1);
            this.tbl_batchDetails.Controls.Add(this.lbl_batchCompleted, 2, 2);
            this.tbl_batchDetails.Controls.Add(this.txt_batchNo, 1, 1);
            this.tbl_batchDetails.Controls.Add(this.txt_Customer, 1, 2);
            this.tbl_batchDetails.Controls.Add(this.txt_batchSize, 3, 0);
            this.tbl_batchDetails.Controls.Add(this.txt_batchStarted, 3, 1);
            this.tbl_batchDetails.Controls.Add(this.txt_batchCompleted, 3, 2);
            this.tbl_batchDetails.Location = new System.Drawing.Point(16, 19);
            this.tbl_batchDetails.Name = "tbl_batchDetails";
            this.tbl_batchDetails.RowCount = 3;
            this.tbl_batchDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_batchDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_batchDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_batchDetails.Size = new System.Drawing.Size(638, 83);
            this.tbl_batchDetails.TabIndex = 1;
            // 
            // lbl_Product
            // 
            this.lbl_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Location = new System.Drawing.Point(3, 6);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(136, 13);
            this.lbl_Product.TabIndex = 0;
            this.lbl_Product.Text = "Product";
            // 
            // txt_Product
            // 
            this.txt_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Product.Location = new System.Drawing.Point(145, 3);
            this.txt_Product.Name = "txt_Product";
            this.txt_Product.Size = new System.Drawing.Size(164, 20);
            this.txt_Product.TabIndex = 1;
            // 
            // grp_batchAllDetails
            // 
            this.grp_batchAllDetails.Controls.Add(this.grpDetailsLeft);
            this.grp_batchAllDetails.Controls.Add(this.grpDetailsRight);
            this.grp_batchAllDetails.Controls.Add(this.btn_Submit);
            this.grp_batchAllDetails.Controls.Add(this.dateTimePicker1);
            this.grp_batchAllDetails.Location = new System.Drawing.Point(78, 27);
            this.grp_batchAllDetails.Name = "grp_batchAllDetails";
            this.grp_batchAllDetails.Size = new System.Drawing.Size(928, 662);
            this.grp_batchAllDetails.TabIndex = 4;
            this.grp_batchAllDetails.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(686, 623);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(224, 23);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // grp_Options
            // 
            this.grp_Options.Location = new System.Drawing.Point(12, 27);
            this.grp_Options.Name = "grp_Options";
            this.grp_Options.Size = new System.Drawing.Size(54, 623);
            this.grp_Options.TabIndex = 6;
            this.grp_Options.TabStop = false;
            this.grp_Options.Text = "Option";
            // 
            // lbl_batchNo
            // 
            this.lbl_batchNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_batchNo.AutoSize = true;
            this.lbl_batchNo.Location = new System.Drawing.Point(3, 32);
            this.lbl_batchNo.Name = "lbl_batchNo";
            this.lbl_batchNo.Size = new System.Drawing.Size(136, 13);
            this.lbl_batchNo.TabIndex = 2;
            this.lbl_batchNo.Text = "Batch No.";
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.Location = new System.Drawing.Point(3, 61);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(136, 13);
            this.lbl_Customer.TabIndex = 3;
            this.lbl_Customer.Text = "Customer";
            // 
            // lbl_batchSize
            // 
            this.lbl_batchSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_batchSize.AutoSize = true;
            this.lbl_batchSize.Location = new System.Drawing.Point(315, 6);
            this.lbl_batchSize.Name = "lbl_batchSize";
            this.lbl_batchSize.Size = new System.Drawing.Size(145, 13);
            this.lbl_batchSize.TabIndex = 4;
            this.lbl_batchSize.Text = "Batch Size";
            // 
            // lbl_batchStarted
            // 
            this.lbl_batchStarted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_batchStarted.AutoSize = true;
            this.lbl_batchStarted.Location = new System.Drawing.Point(315, 32);
            this.lbl_batchStarted.Name = "lbl_batchStarted";
            this.lbl_batchStarted.Size = new System.Drawing.Size(145, 13);
            this.lbl_batchStarted.TabIndex = 5;
            this.lbl_batchStarted.Text = "Batch Started at";
            // 
            // lbl_batchCompleted
            // 
            this.lbl_batchCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_batchCompleted.AutoSize = true;
            this.lbl_batchCompleted.Location = new System.Drawing.Point(315, 61);
            this.lbl_batchCompleted.Name = "lbl_batchCompleted";
            this.lbl_batchCompleted.Size = new System.Drawing.Size(145, 13);
            this.lbl_batchCompleted.TabIndex = 6;
            this.lbl_batchCompleted.Text = "Batch Completed on";
            // 
            // txt_batchNo
            // 
            this.txt_batchNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_batchNo.Location = new System.Drawing.Point(145, 29);
            this.txt_batchNo.Name = "txt_batchNo";
            this.txt_batchNo.Size = new System.Drawing.Size(164, 20);
            this.txt_batchNo.TabIndex = 7;
            // 
            // txt_Customer
            // 
            this.txt_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Customer.Location = new System.Drawing.Point(145, 55);
            this.txt_Customer.Name = "txt_Customer";
            this.txt_Customer.Size = new System.Drawing.Size(164, 20);
            this.txt_Customer.TabIndex = 8;
            // 
            // txt_batchSize
            // 
            this.txt_batchSize.Location = new System.Drawing.Point(466, 3);
            this.txt_batchSize.Name = "txt_batchSize";
            this.txt_batchSize.Size = new System.Drawing.Size(169, 20);
            this.txt_batchSize.TabIndex = 9;
            // 
            // txt_batchStarted
            // 
            this.txt_batchStarted.Location = new System.Drawing.Point(466, 29);
            this.txt_batchStarted.Name = "txt_batchStarted";
            this.txt_batchStarted.Size = new System.Drawing.Size(169, 20);
            this.txt_batchStarted.TabIndex = 10;
            // 
            // txt_batchCompleted
            // 
            this.txt_batchCompleted.Location = new System.Drawing.Point(466, 55);
            this.txt_batchCompleted.Name = "txt_batchCompleted";
            this.txt_batchCompleted.Size = new System.Drawing.Size(169, 20);
            this.txt_batchCompleted.TabIndex = 11;
            // 
            // grpDetailsRight
            // 
            this.grpDetailsRight.Controls.Add(this.grp_quantity);
            this.grpDetailsRight.Controls.Add(this.grp_filteredBy);
            this.grpDetailsRight.Controls.Add(this.grpQAstatus);
            this.grpDetailsRight.Controls.Add(this.grpMaterial);
            this.grpDetailsRight.Location = new System.Drawing.Point(686, 45);
            this.grpDetailsRight.Name = "grpDetailsRight";
            this.grpDetailsRight.Size = new System.Drawing.Size(224, 572);
            this.grpDetailsRight.TabIndex = 4;
            this.grpDetailsRight.TabStop = false;
            // 
            // grpMaterial
            // 
            this.grpMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMaterial.Controls.Add(this.tbl_material);
            this.grpMaterial.Location = new System.Drawing.Point(6, 19);
            this.grpMaterial.Name = "grpMaterial";
            this.grpMaterial.Size = new System.Drawing.Size(212, 124);
            this.grpMaterial.TabIndex = 0;
            this.grpMaterial.TabStop = false;
            this.grpMaterial.Text = "Material";
            // 
            // tbl_material
            // 
            this.tbl_material.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_material.ColumnCount = 2;
            this.tbl_material.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tbl_material.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tbl_material.Controls.Add(this.lbl_weightedBy, 0, 0);
            this.tbl_material.Controls.Add(this.txt_weightedBy, 1, 0);
            this.tbl_material.Controls.Add(this.lbl_checkedBy, 0, 1);
            this.tbl_material.Controls.Add(this.lbl_packingMaterial, 0, 2);
            this.tbl_material.Controls.Add(this.txt_checkedBy, 1, 1);
            this.tbl_material.Controls.Add(this.txt_packingMaterial, 1, 2);
            this.tbl_material.Location = new System.Drawing.Point(6, 20);
            this.tbl_material.Name = "tbl_material";
            this.tbl_material.RowCount = 3;
            this.tbl_material.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.tbl_material.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tbl_material.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tbl_material.Size = new System.Drawing.Size(200, 96);
            this.tbl_material.TabIndex = 0;
            // 
            // lbl_weightedBy
            // 
            this.lbl_weightedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_weightedBy.AutoSize = true;
            this.lbl_weightedBy.Location = new System.Drawing.Point(3, 8);
            this.lbl_weightedBy.Name = "lbl_weightedBy";
            this.lbl_weightedBy.Size = new System.Drawing.Size(78, 13);
            this.lbl_weightedBy.TabIndex = 0;
            this.lbl_weightedBy.Text = "Weighted By";
            // 
            // txt_weightedBy
            // 
            this.txt_weightedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_weightedBy.Location = new System.Drawing.Point(87, 5);
            this.txt_weightedBy.Name = "txt_weightedBy";
            this.txt_weightedBy.Size = new System.Drawing.Size(110, 20);
            this.txt_weightedBy.TabIndex = 1;
            // 
            // lbl_checkedBy
            // 
            this.lbl_checkedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_checkedBy.AutoSize = true;
            this.lbl_checkedBy.Location = new System.Drawing.Point(3, 39);
            this.lbl_checkedBy.Name = "lbl_checkedBy";
            this.lbl_checkedBy.Size = new System.Drawing.Size(78, 13);
            this.lbl_checkedBy.TabIndex = 2;
            this.lbl_checkedBy.Text = "Checked By ";
            // 
            // lbl_packingMaterial
            // 
            this.lbl_packingMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_packingMaterial.AutoSize = true;
            this.lbl_packingMaterial.Location = new System.Drawing.Point(3, 66);
            this.lbl_packingMaterial.Name = "lbl_packingMaterial";
            this.lbl_packingMaterial.Size = new System.Drawing.Size(78, 26);
            this.lbl_packingMaterial.TabIndex = 3;
            this.lbl_packingMaterial.Text = "Packing Material ";
            // 
            // txt_checkedBy
            // 
            this.txt_checkedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_checkedBy.Location = new System.Drawing.Point(87, 36);
            this.txt_checkedBy.Name = "txt_checkedBy";
            this.txt_checkedBy.Size = new System.Drawing.Size(110, 20);
            this.txt_checkedBy.TabIndex = 4;
            // 
            // txt_packingMaterial
            // 
            this.txt_packingMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_packingMaterial.Location = new System.Drawing.Point(87, 69);
            this.txt_packingMaterial.Name = "txt_packingMaterial";
            this.txt_packingMaterial.Size = new System.Drawing.Size(110, 20);
            this.txt_packingMaterial.TabIndex = 5;
            // 
            // grpDetailsLeft
            // 
            this.grpDetailsLeft.Controls.Add(this.grp_batchDetails);
            this.grpDetailsLeft.Location = new System.Drawing.Point(6, 45);
            this.grpDetailsLeft.Name = "grpDetailsLeft";
            this.grpDetailsLeft.Size = new System.Drawing.Size(674, 526);
            this.grpDetailsLeft.TabIndex = 5;
            this.grpDetailsLeft.TabStop = false;
            // 
            // grpQAstatus
            // 
            this.grpQAstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grpQAstatus.Controls.Add(this.tbl_qaStatus);
            this.grpQAstatus.Location = new System.Drawing.Point(6, 149);
            this.grpQAstatus.Name = "grpQAstatus";
            this.grpQAstatus.Size = new System.Drawing.Size(212, 150);
            this.grpQAstatus.TabIndex = 1;
            this.grpQAstatus.TabStop = false;
            this.grpQAstatus.Text = "Q A Status";
            // 
            // tbl_qaStatus
            // 
            this.tbl_qaStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_qaStatus.ColumnCount = 2;
            this.tbl_qaStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tbl_qaStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tbl_qaStatus.Controls.Add(this.lbl_sampleGiven, 0, 0);
            this.tbl_qaStatus.Controls.Add(this.txts_sampleGiven, 1, 0);
            this.tbl_qaStatus.Controls.Add(this.lbl_Status, 0, 1);
            this.tbl_qaStatus.Controls.Add(this.lbl_density, 0, 2);
            this.tbl_qaStatus.Controls.Add(this.txt_Status, 1, 1);
            this.tbl_qaStatus.Controls.Add(this.txt_density, 1, 2);
            this.tbl_qaStatus.Controls.Add(this.lbl_testedBy, 0, 3);
            this.tbl_qaStatus.Controls.Add(this.txt_testedBy, 1, 3);
            this.tbl_qaStatus.Location = new System.Drawing.Point(6, 15);
            this.tbl_qaStatus.Name = "tbl_qaStatus";
            this.tbl_qaStatus.RowCount = 4;
            this.tbl_qaStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.31915F));
            this.tbl_qaStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.68085F));
            this.tbl_qaStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tbl_qaStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tbl_qaStatus.Size = new System.Drawing.Size(200, 125);
            this.tbl_qaStatus.TabIndex = 0;
            // 
            // lbl_sampleGiven
            // 
            this.lbl_sampleGiven.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sampleGiven.AutoSize = true;
            this.lbl_sampleGiven.Location = new System.Drawing.Point(3, 9);
            this.lbl_sampleGiven.Name = "lbl_sampleGiven";
            this.lbl_sampleGiven.Size = new System.Drawing.Size(78, 13);
            this.lbl_sampleGiven.TabIndex = 0;
            this.lbl_sampleGiven.Text = "Sample Given";
            // 
            // txts_sampleGiven
            // 
            this.txts_sampleGiven.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txts_sampleGiven.Location = new System.Drawing.Point(87, 6);
            this.txts_sampleGiven.Name = "txts_sampleGiven";
            this.txts_sampleGiven.Size = new System.Drawing.Size(110, 20);
            this.txts_sampleGiven.TabIndex = 1;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(3, 38);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(78, 13);
            this.lbl_Status.TabIndex = 2;
            this.lbl_Status.Text = "Status";
            // 
            // lbl_density
            // 
            this.lbl_density.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_density.AutoSize = true;
            this.lbl_density.Location = new System.Drawing.Point(3, 67);
            this.lbl_density.Name = "lbl_density";
            this.lbl_density.Size = new System.Drawing.Size(78, 13);
            this.lbl_density.TabIndex = 3;
            this.lbl_density.Text = "Density";
            // 
            // txt_Status
            // 
            this.txt_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Status.Location = new System.Drawing.Point(87, 35);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(110, 20);
            this.txt_Status.TabIndex = 4;
            // 
            // txt_density
            // 
            this.txt_density.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_density.Location = new System.Drawing.Point(87, 64);
            this.txt_density.Name = "txt_density";
            this.txt_density.Size = new System.Drawing.Size(110, 20);
            this.txt_density.TabIndex = 5;
            // 
            // lbl_testedBy
            // 
            this.lbl_testedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_testedBy.AutoSize = true;
            this.lbl_testedBy.Location = new System.Drawing.Point(3, 101);
            this.lbl_testedBy.Name = "lbl_testedBy";
            this.lbl_testedBy.Size = new System.Drawing.Size(78, 13);
            this.lbl_testedBy.TabIndex = 6;
            this.lbl_testedBy.Text = "Tested By";
            // 
            // txt_testedBy
            // 
            this.txt_testedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_testedBy.Location = new System.Drawing.Point(87, 97);
            this.txt_testedBy.Name = "txt_testedBy";
            this.txt_testedBy.Size = new System.Drawing.Size(110, 20);
            this.txt_testedBy.TabIndex = 7;
            // 
            // grp_filteredBy
            // 
            this.grp_filteredBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_filteredBy.Controls.Add(this.tbl_filteredBy);
            this.grp_filteredBy.Location = new System.Drawing.Point(6, 305);
            this.grp_filteredBy.Name = "grp_filteredBy";
            this.grp_filteredBy.Size = new System.Drawing.Size(212, 150);
            this.grp_filteredBy.TabIndex = 2;
            this.grp_filteredBy.TabStop = false;
            this.grp_filteredBy.Text = "Filtered By";
            // 
            // tbl_filteredBy
            // 
            this.tbl_filteredBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_filteredBy.ColumnCount = 2;
            this.tbl_filteredBy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tbl_filteredBy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tbl_filteredBy.Controls.Add(this.lbl_machineNo, 0, 0);
            this.tbl_filteredBy.Controls.Add(this.txt_machineNo, 1, 0);
            this.tbl_filteredBy.Controls.Add(this.lbl_unitNo, 0, 1);
            this.tbl_filteredBy.Controls.Add(this.lbl_viscoity, 0, 2);
            this.tbl_filteredBy.Controls.Add(this.txt_UnitNo, 1, 1);
            this.tbl_filteredBy.Controls.Add(this.txt_viscocity, 1, 2);
            this.tbl_filteredBy.Controls.Add(this.lbl_solid, 0, 3);
            this.tbl_filteredBy.Controls.Add(this.txt_solid, 1, 3);
            this.tbl_filteredBy.Location = new System.Drawing.Point(6, 15);
            this.tbl_filteredBy.Name = "tbl_filteredBy";
            this.tbl_filteredBy.RowCount = 4;
            this.tbl_filteredBy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.31915F));
            this.tbl_filteredBy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.68085F));
            this.tbl_filteredBy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tbl_filteredBy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tbl_filteredBy.Size = new System.Drawing.Size(200, 125);
            this.tbl_filteredBy.TabIndex = 0;
            // 
            // lbl_machineNo
            // 
            this.lbl_machineNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_machineNo.AutoSize = true;
            this.lbl_machineNo.Location = new System.Drawing.Point(3, 9);
            this.lbl_machineNo.Name = "lbl_machineNo";
            this.lbl_machineNo.Size = new System.Drawing.Size(78, 13);
            this.lbl_machineNo.TabIndex = 0;
            this.lbl_machineNo.Text = "Machine No";
            // 
            // txt_machineNo
            // 
            this.txt_machineNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_machineNo.Location = new System.Drawing.Point(87, 6);
            this.txt_machineNo.Name = "txt_machineNo";
            this.txt_machineNo.Size = new System.Drawing.Size(110, 20);
            this.txt_machineNo.TabIndex = 1;
            // 
            // lbl_unitNo
            // 
            this.lbl_unitNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_unitNo.AutoSize = true;
            this.lbl_unitNo.Location = new System.Drawing.Point(3, 38);
            this.lbl_unitNo.Name = "lbl_unitNo";
            this.lbl_unitNo.Size = new System.Drawing.Size(78, 13);
            this.lbl_unitNo.TabIndex = 2;
            this.lbl_unitNo.Text = "Unit No";
            // 
            // lbl_viscoity
            // 
            this.lbl_viscoity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_viscoity.AutoSize = true;
            this.lbl_viscoity.Location = new System.Drawing.Point(3, 67);
            this.lbl_viscoity.Name = "lbl_viscoity";
            this.lbl_viscoity.Size = new System.Drawing.Size(78, 13);
            this.lbl_viscoity.TabIndex = 3;
            this.lbl_viscoity.Text = "Viscocity";
            // 
            // txt_UnitNo
            // 
            this.txt_UnitNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UnitNo.Location = new System.Drawing.Point(87, 35);
            this.txt_UnitNo.Name = "txt_UnitNo";
            this.txt_UnitNo.Size = new System.Drawing.Size(110, 20);
            this.txt_UnitNo.TabIndex = 4;
            // 
            // txt_viscocity
            // 
            this.txt_viscocity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_viscocity.Location = new System.Drawing.Point(87, 64);
            this.txt_viscocity.Name = "txt_viscocity";
            this.txt_viscocity.Size = new System.Drawing.Size(110, 20);
            this.txt_viscocity.TabIndex = 5;
            // 
            // lbl_solid
            // 
            this.lbl_solid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_solid.AutoSize = true;
            this.lbl_solid.Location = new System.Drawing.Point(3, 101);
            this.lbl_solid.Name = "lbl_solid";
            this.lbl_solid.Size = new System.Drawing.Size(78, 13);
            this.lbl_solid.TabIndex = 6;
            this.lbl_solid.Text = "Solid";
            // 
            // txt_solid
            // 
            this.txt_solid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_solid.Location = new System.Drawing.Point(87, 97);
            this.txt_solid.Name = "txt_solid";
            this.txt_solid.Size = new System.Drawing.Size(110, 20);
            this.txt_solid.TabIndex = 7;
            // 
            // grp_quantity
            // 
            this.grp_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_quantity.Controls.Add(this.tableLayoutPanel1);
            this.grp_quantity.Location = new System.Drawing.Point(6, 466);
            this.grp_quantity.Name = "grp_quantity";
            this.grp_quantity.Size = new System.Drawing.Size(212, 100);
            this.grp_quantity.TabIndex = 3;
            this.grp_quantity.TabStop = false;
            this.grp_quantity.Text = "Quantity";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.5F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_quantityPacked, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_quantityPacked, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_packedBy, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_packedBy, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 79);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_quantityPacked
            // 
            this.lbl_quantityPacked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_quantityPacked.AutoSize = true;
            this.lbl_quantityPacked.Location = new System.Drawing.Point(3, 6);
            this.lbl_quantityPacked.Name = "lbl_quantityPacked";
            this.lbl_quantityPacked.Size = new System.Drawing.Size(75, 26);
            this.lbl_quantityPacked.TabIndex = 0;
            this.lbl_quantityPacked.Text = "Quantity Packed";
            // 
            // txt_quantityPacked
            // 
            this.txt_quantityPacked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_quantityPacked.Location = new System.Drawing.Point(84, 9);
            this.txt_quantityPacked.Name = "txt_quantityPacked";
            this.txt_quantityPacked.Size = new System.Drawing.Size(113, 20);
            this.txt_quantityPacked.TabIndex = 1;
            // 
            // lbl_packedBy
            // 
            this.lbl_packedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_packedBy.AutoSize = true;
            this.lbl_packedBy.Location = new System.Drawing.Point(3, 52);
            this.lbl_packedBy.Name = "lbl_packedBy";
            this.lbl_packedBy.Size = new System.Drawing.Size(75, 13);
            this.lbl_packedBy.TabIndex = 2;
            this.lbl_packedBy.Text = "Packed By ";
            // 
            // txt_packedBy
            // 
            this.txt_packedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_packedBy.Location = new System.Drawing.Point(84, 48);
            this.txt_packedBy.Name = "txt_packedBy";
            this.txt_packedBy.Size = new System.Drawing.Size(113, 20);
            this.txt_packedBy.TabIndex = 4;
            // 
            // frm_batchSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1018, 701);
            this.Controls.Add(this.grp_Options);
            this.Controls.Add(this.grp_batchAllDetails);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_batchSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Sheet";
            this.grp_batchDetails.ResumeLayout(false);
            this.tbl_batchDetails.ResumeLayout(false);
            this.tbl_batchDetails.PerformLayout();
            this.grp_batchAllDetails.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.grpDetailsRight.ResumeLayout(false);
            this.grpMaterial.ResumeLayout(false);
            this.tbl_material.ResumeLayout(false);
            this.tbl_material.PerformLayout();
            this.grpDetailsLeft.ResumeLayout(false);
            this.grpQAstatus.ResumeLayout(false);
            this.tbl_qaStatus.ResumeLayout(false);
            this.tbl_qaStatus.PerformLayout();
            this.grp_filteredBy.ResumeLayout(false);
            this.tbl_filteredBy.ResumeLayout(false);
            this.tbl_filteredBy.PerformLayout();
            this.grp_quantity.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox grp_batchDetails;
        private System.Windows.Forms.TableLayoutPanel tbl_batchDetails;
        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.TextBox txt_Product;
        private System.Windows.Forms.GroupBox grp_batchAllDetails;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_batchNo;
        private System.Windows.Forms.Label lbl_Customer;
        private System.Windows.Forms.Label lbl_batchSize;
        private System.Windows.Forms.Label lbl_batchStarted;
        private System.Windows.Forms.Label lbl_batchCompleted;
        private System.Windows.Forms.TextBox txt_batchNo;
        private System.Windows.Forms.TextBox txt_Customer;
        private System.Windows.Forms.TextBox txt_batchSize;
        private System.Windows.Forms.TextBox txt_batchStarted;
        private System.Windows.Forms.TextBox txt_batchCompleted;
        private System.Windows.Forms.GroupBox grp_Options;
        private System.Windows.Forms.GroupBox grpDetailsRight;
        private System.Windows.Forms.GroupBox grpMaterial;
        private System.Windows.Forms.TableLayoutPanel tbl_material;
        private System.Windows.Forms.Label lbl_weightedBy;
        private System.Windows.Forms.TextBox txt_weightedBy;
        private System.Windows.Forms.Label lbl_checkedBy;
        private System.Windows.Forms.Label lbl_packingMaterial;
        private System.Windows.Forms.TextBox txt_checkedBy;
        private System.Windows.Forms.TextBox txt_packingMaterial;
        private System.Windows.Forms.GroupBox grpDetailsLeft;
        private System.Windows.Forms.GroupBox grpQAstatus;
        private System.Windows.Forms.TableLayoutPanel tbl_qaStatus;
        private System.Windows.Forms.Label lbl_sampleGiven;
        private System.Windows.Forms.TextBox txts_sampleGiven;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_density;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.TextBox txt_density;
        private System.Windows.Forms.Label lbl_testedBy;
        private System.Windows.Forms.TextBox txt_testedBy;
        private System.Windows.Forms.GroupBox grp_filteredBy;
        private System.Windows.Forms.TableLayoutPanel tbl_filteredBy;
        private System.Windows.Forms.Label lbl_machineNo;
        private System.Windows.Forms.TextBox txt_machineNo;
        private System.Windows.Forms.Label lbl_unitNo;
        private System.Windows.Forms.Label lbl_viscoity;
        private System.Windows.Forms.TextBox txt_UnitNo;
        private System.Windows.Forms.TextBox txt_viscocity;
        private System.Windows.Forms.Label lbl_solid;
        private System.Windows.Forms.TextBox txt_solid;
        private System.Windows.Forms.GroupBox grp_quantity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_quantityPacked;
        private System.Windows.Forms.TextBox txt_quantityPacked;
        private System.Windows.Forms.Label lbl_packedBy;
        private System.Windows.Forms.TextBox txt_packedBy;
    }
}

