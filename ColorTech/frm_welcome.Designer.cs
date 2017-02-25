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
            this.panel_options = new System.Windows.Forms.Panel();
            this.btn_rawMaterial = new System.Windows.Forms.Button();
            this.btn_subBatch = new System.Windows.Forms.Button();
            this.btn_mainBatch = new System.Windows.Forms.Button();
            this.panel_content = new System.Windows.Forms.Panel();
            this.lbl_stockDate = new System.Windows.Forms.Label();
            this.lbl_stockItemName = new System.Windows.Forms.Label();
            this.lbl_stockQuantity = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_newItemName = new System.Windows.Forms.Label();
            this.lbl_newQuantity = new System.Windows.Forms.Label();
            this.txt_newItemName = new System.Windows.Forms.TextBox();
            this.txt_newQuantity = new System.Windows.Forms.TextBox();
            this.grpbox_newEntrycontent = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_newEntrySubmit = new System.Windows.Forms.Button();
            this.btn_stockEntrySubmit = new System.Windows.Forms.Button();
            this.panel_options.SuspendLayout();
            this.panel_content.SuspendLayout();
            this.grpbox_newEntrycontent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_options
            // 
            this.panel_options.Controls.Add(this.btn_rawMaterial);
            this.panel_options.Controls.Add(this.btn_subBatch);
            this.panel_options.Controls.Add(this.btn_mainBatch);
            this.panel_options.Location = new System.Drawing.Point(12, 12);
            this.panel_options.Name = "panel_options";
            this.panel_options.Size = new System.Drawing.Size(487, 59);
            this.panel_options.TabIndex = 0;
            // 
            // btn_rawMaterial
            // 
            this.btn_rawMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rawMaterial.Location = new System.Drawing.Point(324, 16);
            this.btn_rawMaterial.Name = "btn_rawMaterial";
            this.btn_rawMaterial.Size = new System.Drawing.Size(132, 26);
            this.btn_rawMaterial.TabIndex = 3;
            this.btn_rawMaterial.Text = "Raw Material";
            this.btn_rawMaterial.UseVisualStyleBackColor = true;
            this.btn_rawMaterial.Click += new System.EventHandler(this.btn_rawMaterial_Click);
            // 
            // btn_subBatch
            // 
            this.btn_subBatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_subBatch.Location = new System.Drawing.Point(171, 16);
            this.btn_subBatch.Name = "btn_subBatch";
            this.btn_subBatch.Size = new System.Drawing.Size(132, 26);
            this.btn_subBatch.TabIndex = 2;
            this.btn_subBatch.Text = "Sub Batch";
            this.btn_subBatch.UseVisualStyleBackColor = true;
            this.btn_subBatch.Click += new System.EventHandler(this.btn_subBatch_Click);
            // 
            // btn_mainBatch
            // 
            this.btn_mainBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mainBatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mainBatch.Location = new System.Drawing.Point(22, 16);
            this.btn_mainBatch.Name = "btn_mainBatch";
            this.btn_mainBatch.Size = new System.Drawing.Size(132, 26);
            this.btn_mainBatch.TabIndex = 1;
            this.btn_mainBatch.Text = "Main Batch";
            this.btn_mainBatch.UseVisualStyleBackColor = true;
            this.btn_mainBatch.Click += new System.EventHandler(this.btn_mainBatch_Click);
            // 
            // panel_content
            // 
            this.panel_content.Controls.Add(this.groupBox1);
            this.panel_content.Controls.Add(this.grpbox_newEntrycontent);
            this.panel_content.Location = new System.Drawing.Point(13, 78);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(486, 188);
            this.panel_content.TabIndex = 1;
            // 
            // lbl_stockDate
            // 
            this.lbl_stockDate.AutoSize = true;
            this.lbl_stockDate.Location = new System.Drawing.Point(6, 26);
            this.lbl_stockDate.Name = "lbl_stockDate";
            this.lbl_stockDate.Size = new System.Drawing.Size(30, 13);
            this.lbl_stockDate.TabIndex = 0;
            this.lbl_stockDate.Text = "Date";
            // 
            // lbl_stockItemName
            // 
            this.lbl_stockItemName.AutoSize = true;
            this.lbl_stockItemName.Location = new System.Drawing.Point(6, 63);
            this.lbl_stockItemName.Name = "lbl_stockItemName";
            this.lbl_stockItemName.Size = new System.Drawing.Size(58, 13);
            this.lbl_stockItemName.TabIndex = 1;
            this.lbl_stockItemName.Text = "Item Name";
            // 
            // lbl_stockQuantity
            // 
            this.lbl_stockQuantity.AutoSize = true;
            this.lbl_stockQuantity.Location = new System.Drawing.Point(6, 96);
            this.lbl_stockQuantity.Name = "lbl_stockQuantity";
            this.lbl_stockQuantity.Size = new System.Drawing.Size(46, 13);
            this.lbl_stockQuantity.TabIndex = 2;
            this.lbl_stockQuantity.Text = "Quantity";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(73, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 20);
            this.textBox3.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MMMM, yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // lbl_newItemName
            // 
            this.lbl_newItemName.AutoSize = true;
            this.lbl_newItemName.Location = new System.Drawing.Point(6, 25);
            this.lbl_newItemName.Name = "lbl_newItemName";
            this.lbl_newItemName.Size = new System.Drawing.Size(58, 13);
            this.lbl_newItemName.TabIndex = 0;
            this.lbl_newItemName.Text = "Item Name";
            // 
            // lbl_newQuantity
            // 
            this.lbl_newQuantity.AutoSize = true;
            this.lbl_newQuantity.Location = new System.Drawing.Point(6, 61);
            this.lbl_newQuantity.Name = "lbl_newQuantity";
            this.lbl_newQuantity.Size = new System.Drawing.Size(46, 13);
            this.lbl_newQuantity.TabIndex = 1;
            this.lbl_newQuantity.Text = "Quantity";
            // 
            // txt_newItemName
            // 
            this.txt_newItemName.Location = new System.Drawing.Point(69, 22);
            this.txt_newItemName.Name = "txt_newItemName";
            this.txt_newItemName.Size = new System.Drawing.Size(132, 20);
            this.txt_newItemName.TabIndex = 2;
            // 
            // txt_newQuantity
            // 
            this.txt_newQuantity.Location = new System.Drawing.Point(69, 58);
            this.txt_newQuantity.Name = "txt_newQuantity";
            this.txt_newQuantity.Size = new System.Drawing.Size(132, 20);
            this.txt_newQuantity.TabIndex = 3;
            // 
            // grpbox_newEntrycontent
            // 
            this.grpbox_newEntrycontent.Controls.Add(this.btn_newEntrySubmit);
            this.grpbox_newEntrycontent.Controls.Add(this.txt_newQuantity);
            this.grpbox_newEntrycontent.Controls.Add(this.lbl_newItemName);
            this.grpbox_newEntrycontent.Controls.Add(this.lbl_newQuantity);
            this.grpbox_newEntrycontent.Controls.Add(this.txt_newItemName);
            this.grpbox_newEntrycontent.Location = new System.Drawing.Point(16, 12);
            this.grpbox_newEntrycontent.Name = "grpbox_newEntrycontent";
            this.grpbox_newEntrycontent.Size = new System.Drawing.Size(224, 164);
            this.grpbox_newEntrycontent.TabIndex = 2;
            this.grpbox_newEntrycontent.TabStop = false;
            this.grpbox_newEntrycontent.Text = "New Entry";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_stockEntrySubmit);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lbl_stockDate);
            this.groupBox1.Controls.Add(this.lbl_stockQuantity);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lbl_stockItemName);
            this.groupBox1.Location = new System.Drawing.Point(247, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 164);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Entry";
            // 
            // btn_newEntrySubmit
            // 
            this.btn_newEntrySubmit.Location = new System.Drawing.Point(69, 91);
            this.btn_newEntrySubmit.Name = "btn_newEntrySubmit";
            this.btn_newEntrySubmit.Size = new System.Drawing.Size(132, 23);
            this.btn_newEntrySubmit.TabIndex = 4;
            this.btn_newEntrySubmit.Text = "Submit";
            this.btn_newEntrySubmit.UseVisualStyleBackColor = true;
            // 
            // btn_stockEntrySubmit
            // 
            this.btn_stockEntrySubmit.Location = new System.Drawing.Point(73, 126);
            this.btn_stockEntrySubmit.Name = "btn_stockEntrySubmit";
            this.btn_stockEntrySubmit.Size = new System.Drawing.Size(135, 23);
            this.btn_stockEntrySubmit.TabIndex = 5;
            this.btn_stockEntrySubmit.Text = "Submit";
            this.btn_stockEntrySubmit.UseVisualStyleBackColor = true;
            // 
            // frm_welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(508, 273);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.panel_options);
            this.Name = "frm_welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.frm_welcome_Load);
            this.panel_options.ResumeLayout(false);
            this.panel_content.ResumeLayout(false);
            this.grpbox_newEntrycontent.ResumeLayout(false);
            this.grpbox_newEntrycontent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_options;
        private System.Windows.Forms.Button btn_mainBatch;
        private System.Windows.Forms.Button btn_subBatch;
        private System.Windows.Forms.Button btn_rawMaterial;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.TextBox txt_newQuantity;
        private System.Windows.Forms.TextBox txt_newItemName;
        private System.Windows.Forms.Label lbl_newQuantity;
        private System.Windows.Forms.Label lbl_newItemName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_stockQuantity;
        private System.Windows.Forms.Label lbl_stockItemName;
        private System.Windows.Forms.Label lbl_stockDate;
        private System.Windows.Forms.GroupBox grpbox_newEntrycontent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_stockEntrySubmit;
        private System.Windows.Forms.Button btn_newEntrySubmit;
    }
}