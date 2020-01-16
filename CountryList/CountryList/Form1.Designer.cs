namespace CountryList
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
            this.Country = new System.Windows.Forms.Label();
            this.CountryList = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.Label();
            this.GDP = new System.Windows.Forms.Label();
            this.Inflation = new System.Windows.Forms.Label();
            this.HDI = new System.Windows.Forms.Label();
            this.Partners = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Inflationtext = new System.Windows.Forms.TextBox();
            this.HDItext = new System.Windows.Forms.TextBox();
            this.MainpartnersText = new System.Windows.Forms.TextBox();
            this.SearchByName = new System.Windows.Forms.Label();
            this.NameSearch = new System.Windows.Forms.TextBox();
            this.Box1 = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.GoTo = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.SearchNPBar = new System.Windows.Forms.TextBox();
            this.SNamePArtnersText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Namettextbox = new System.Windows.Forms.Label();
            this.GDGTextBox = new System.Windows.Forms.Label();
            this.InflationTextBox = new System.Windows.Forms.Label();
            this.TradebalanceBox = new System.Windows.Forms.Label();
            this.HDITextBox = new System.Windows.Forms.Label();
            this.PartnersBox = new System.Windows.Forms.Label();
            this.RemoveBox = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OrderedTick = new System.Windows.Forms.CheckBox();
            this.Unordered = new System.Windows.Forms.CheckBox();
            this.adddANewCountrey = new System.Windows.Forms.Button();
            this.Box1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(99, 57);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(57, 17);
            this.Country.TabIndex = 2;
            this.Country.Text = "Country";
            this.Country.Click += new System.EventHandler(this.Country_Click);
            // 
            // CountryList
            // 
            this.CountryList.Location = new System.Drawing.Point(55, 87);
            this.CountryList.Name = "CountryList";
            this.CountryList.Size = new System.Drawing.Size(160, 315);
            this.CountryList.TabIndex = 4;
            this.CountryList.UseCompatibleStateImageBehavior = false;
            this.CountryList.SelectedIndexChanged += new System.EventHandler(this.CountryList_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(220, 44);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(6, 30);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(45, 17);
            this.Name.TabIndex = 6;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // GDP
            // 
            this.GDP.AutoSize = true;
            this.GDP.Location = new System.Drawing.Point(6, 118);
            this.GDP.Name = "GDP";
            this.GDP.Size = new System.Drawing.Size(87, 17);
            this.GDP.TabIndex = 7;
            this.GDP.Text = "GDP Growth";
            this.GDP.Click += new System.EventHandler(this.GDP_Click);
            // 
            // Inflation
            // 
            this.Inflation.AutoSize = true;
            this.Inflation.Location = new System.Drawing.Point(6, 174);
            this.Inflation.Name = "Inflation";
            this.Inflation.Size = new System.Drawing.Size(57, 17);
            this.Inflation.TabIndex = 8;
            this.Inflation.Text = "Inflation";
            this.Inflation.Click += new System.EventHandler(this.Inflation_Click);
            // 
            // HDI
            // 
            this.HDI.AutoSize = true;
            this.HDI.Location = new System.Drawing.Point(6, 219);
            this.HDI.Name = "HDI";
            this.HDI.Size = new System.Drawing.Size(31, 17);
            this.HDI.TabIndex = 9;
            this.HDI.Text = "HDI";
            this.HDI.Click += new System.EventHandler(this.HDI_Click);
            // 
            // Partners
            // 
            this.Partners.AutoSize = true;
            this.Partners.Location = new System.Drawing.Point(-3, 283);
            this.Partners.Name = "Partners";
            this.Partners.Size = new System.Drawing.Size(92, 17);
            this.Partners.TabIndex = 10;
            this.Partners.Text = "MainPartners";
            this.Partners.Click += new System.EventHandler(this.Partners_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Inflationtext
            // 
            this.Inflationtext.Location = new System.Drawing.Point(6, 194);
            this.Inflationtext.Name = "Inflationtext";
            this.Inflationtext.Size = new System.Drawing.Size(206, 22);
            this.Inflationtext.TabIndex = 12;
            this.Inflationtext.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // HDItext
            // 
            this.HDItext.Location = new System.Drawing.Point(6, 248);
            this.HDItext.Name = "HDItext";
            this.HDItext.Size = new System.Drawing.Size(205, 22);
            this.HDItext.TabIndex = 13;
            this.HDItext.TextChanged += new System.EventHandler(this.HDItext_TextChanged);
            // 
            // MainpartnersText
            // 
            this.MainpartnersText.Location = new System.Drawing.Point(6, 313);
            this.MainpartnersText.Name = "MainpartnersText";
            this.MainpartnersText.Size = new System.Drawing.Size(208, 22);
            this.MainpartnersText.TabIndex = 14;
            this.MainpartnersText.TextChanged += new System.EventHandler(this.MainpartnersText_TextChanged);
            // 
            // SearchByName
            // 
            this.SearchByName.AutoSize = true;
            this.SearchByName.Location = new System.Drawing.Point(55, 409);
            this.SearchByName.Name = "SearchByName";
            this.SearchByName.Size = new System.Drawing.Size(114, 17);
            this.SearchByName.TabIndex = 16;
            this.SearchByName.Text = "Search By Name";
            this.SearchByName.Click += new System.EventHandler(this.SearchByName_Click);
            // 
            // NameSearch
            // 
            this.NameSearch.Location = new System.Drawing.Point(55, 444);
            this.NameSearch.Name = "NameSearch";
            this.NameSearch.Size = new System.Drawing.Size(160, 22);
            this.NameSearch.TabIndex = 17;
            // 
            // Box1
            // 
            this.Box1.Controls.Add(this.Add);
            this.Box1.Controls.Add(this.GoTo);
            this.Box1.Controls.Add(this.Remove);
            this.Box1.Controls.Add(this.listView1);
            this.Box1.Controls.Add(this.Name);
            this.Box1.Controls.Add(this.GDP);
            this.Box1.Controls.Add(this.textBox1);
            this.Box1.Controls.Add(this.MainpartnersText);
            this.Box1.Controls.Add(this.Inflation);
            this.Box1.Controls.Add(this.Partners);
            this.Box1.Controls.Add(this.HDItext);
            this.Box1.Controls.Add(this.HDI);
            this.Box1.Controls.Add(this.Inflationtext);
            this.Box1.Location = new System.Drawing.Point(255, 57);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(281, 409);
            this.Box1.TabIndex = 19;
            this.Box1.TabStop = false;
            this.Box1.Text = "Edible Data";
            this.Box1.Enter += new System.EventHandler(this.Box1_Enter);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(184, 369);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 17;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button2_Click);
            // 
            // GoTo
            // 
            this.GoTo.Location = new System.Drawing.Point(92, 369);
            this.GoTo.Name = "GoTo";
            this.GoTo.Size = new System.Drawing.Size(75, 23);
            this.GoTo.TabIndex = 16;
            this.GoTo.Text = "Go To";
            this.GoTo.UseVisualStyleBackColor = true;
            this.GoTo.Click += new System.EventHandler(this.GoTo_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(0, 369);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 15;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // SearchNPBar
            // 
            this.SearchNPBar.Location = new System.Drawing.Point(58, 501);
            this.SearchNPBar.Name = "SearchNPBar";
            this.SearchNPBar.Size = new System.Drawing.Size(157, 22);
            this.SearchNPBar.TabIndex = 20;
            this.SearchNPBar.TextChanged += new System.EventHandler(this.SearchNPBar_TextChanged);
            // 
            // SNamePArtnersText
            // 
            this.SNamePArtnersText.AutoSize = true;
            this.SNamePArtnersText.Location = new System.Drawing.Point(58, 478);
            this.SNamePArtnersText.Name = "SNamePArtnersText";
            this.SNamePArtnersText.Size = new System.Drawing.Size(172, 17);
            this.SNamePArtnersText.TabIndex = 21;
            this.SNamePArtnersText.Text = "Search By Name Partners";
            this.SNamePArtnersText.Click += new System.EventHandler(this.SNamePArtnersText_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Namettextbox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GDGTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.InflationTextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TradebalanceBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.HDITextBox, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.PartnersBox, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(585, 195);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 382);
            this.tableLayoutPanel1.TabIndex = 22;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Namettextbox
            // 
            this.Namettextbox.AutoSize = true;
            this.Namettextbox.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Namettextbox.Location = new System.Drawing.Point(3, 0);
            this.Namettextbox.Name = "Namettextbox";
            this.Namettextbox.Size = new System.Drawing.Size(45, 17);
            this.Namettextbox.TabIndex = 0;
            this.Namettextbox.Text = "Name";
            this.Namettextbox.Click += new System.EventHandler(this.Namettextbox_Click);
            // 
            // GDGTextBox
            // 
            this.GDGTextBox.AutoSize = true;
            this.GDGTextBox.Location = new System.Drawing.Point(112, 0);
            this.GDGTextBox.Name = "GDGTextBox";
            this.GDGTextBox.Size = new System.Drawing.Size(38, 17);
            this.GDGTextBox.TabIndex = 1;
            this.GDGTextBox.Text = "GDP";
            this.GDGTextBox.Click += new System.EventHandler(this.GDGTextBox_Click);
            // 
            // InflationTextBox
            // 
            this.InflationTextBox.AutoSize = true;
            this.InflationTextBox.Location = new System.Drawing.Point(221, 0);
            this.InflationTextBox.Name = "InflationTextBox";
            this.InflationTextBox.Size = new System.Drawing.Size(57, 17);
            this.InflationTextBox.TabIndex = 2;
            this.InflationTextBox.Text = "Inflation";
            this.InflationTextBox.Click += new System.EventHandler(this.InflationTextBox_Click);
            // 
            // TradebalanceBox
            // 
            this.TradebalanceBox.AutoSize = true;
            this.TradebalanceBox.Location = new System.Drawing.Point(337, 0);
            this.TradebalanceBox.Name = "TradebalanceBox";
            this.TradebalanceBox.Size = new System.Drawing.Size(101, 17);
            this.TradebalanceBox.TabIndex = 4;
            this.TradebalanceBox.Text = "Trade Balance";
            this.TradebalanceBox.Click += new System.EventHandler(this.TradebalanceBox_Click);
            // 
            // HDITextBox
            // 
            this.HDITextBox.AutoSize = true;
            this.HDITextBox.Location = new System.Drawing.Point(452, 0);
            this.HDITextBox.Name = "HDITextBox";
            this.HDITextBox.Size = new System.Drawing.Size(31, 17);
            this.HDITextBox.TabIndex = 3;
            this.HDITextBox.Text = "HDI";
            this.HDITextBox.Click += new System.EventHandler(this.HDITextBox_Click);
            // 
            // PartnersBox
            // 
            this.PartnersBox.AutoSize = true;
            this.PartnersBox.Location = new System.Drawing.Point(542, 0);
            this.PartnersBox.Name = "PartnersBox";
            this.PartnersBox.Size = new System.Drawing.Size(62, 17);
            this.PartnersBox.TabIndex = 5;
            this.PartnersBox.Text = "Partners";
            this.PartnersBox.Click += new System.EventHandler(this.PartnersBox_Click);
            // 
            // RemoveBox
            // 
            this.RemoveBox.Location = new System.Drawing.Point(264, 478);
            this.RemoveBox.Name = "RemoveBox";
            this.RemoveBox.Size = new System.Drawing.Size(117, 23);
            this.RemoveBox.TabIndex = 23;
            this.RemoveBox.Text = "Remove";
            this.RemoveBox.UseVisualStyleBackColor = true;
            this.RemoveBox.Click += new System.EventHandler(this.RemoveBox_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(411, 477);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(103, 23);
            this.SaveButton.TabIndex = 24;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OrderedTick
            // 
            this.OrderedTick.AutoSize = true;
            this.OrderedTick.Location = new System.Drawing.Point(42, 543);
            this.OrderedTick.Name = "OrderedTick";
            this.OrderedTick.Size = new System.Drawing.Size(83, 21);
            this.OrderedTick.TabIndex = 25;
            this.OrderedTick.Text = "Ordered";
            this.OrderedTick.UseVisualStyleBackColor = true;
            this.OrderedTick.CheckedChanged += new System.EventHandler(this.OrderedTick_CheckedChanged);
            // 
            // Unordered
            // 
            this.Unordered.AutoSize = true;
            this.Unordered.Location = new System.Drawing.Point(131, 543);
            this.Unordered.Name = "Unordered";
            this.Unordered.Size = new System.Drawing.Size(106, 21);
            this.Unordered.TabIndex = 26;
            this.Unordered.Text = "Un-Ordered";
            this.Unordered.UseVisualStyleBackColor = true;
            this.Unordered.CheckedChanged += new System.EventHandler(this.Unordered_CheckedChanged);
            // 
            // adddANewCountrey
            // 
            this.adddANewCountrey.Location = new System.Drawing.Point(313, 527);
            this.adddANewCountrey.Name = "adddANewCountrey";
            this.adddANewCountrey.Size = new System.Drawing.Size(168, 50);
            this.adddANewCountrey.TabIndex = 27;
            this.adddANewCountrey.Text = "Add as a new Country";
            this.adddANewCountrey.UseVisualStyleBackColor = true;
            this.adddANewCountrey.Click += new System.EventHandler(this.addasanewcountry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 620);
            this.Controls.Add(this.adddANewCountrey);
            this.Controls.Add(this.Unordered);
            this.Controls.Add(this.OrderedTick);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RemoveBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.SNamePArtnersText);
            this.Controls.Add(this.SearchNPBar);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.NameSearch);
            this.Controls.Add(this.SearchByName);
            this.Controls.Add(this.CountryList);
            this.Controls.Add(this.Country);
            this.Name = "Form1";
            this.Text = "Check";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Box1.ResumeLayout(false);
            this.Box1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.ListView CountryList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label GDP;
        private System.Windows.Forms.Label Inflation;
        private System.Windows.Forms.Label HDI;
        private System.Windows.Forms.Label Partners;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Inflationtext;
        private System.Windows.Forms.TextBox HDItext;
        private System.Windows.Forms.TextBox MainpartnersText;
        private System.Windows.Forms.Label SearchByName;
        private System.Windows.Forms.TextBox NameSearch;
        private System.Windows.Forms.GroupBox Box1;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button GoTo;
        private System.Windows.Forms.TextBox SearchNPBar;
        private System.Windows.Forms.Label SNamePArtnersText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Namettextbox;
        private System.Windows.Forms.Label GDGTextBox;
        private System.Windows.Forms.Label InflationTextBox;
        private System.Windows.Forms.Label HDITextBox;
        private System.Windows.Forms.Label TradebalanceBox;
        private System.Windows.Forms.Label PartnersBox;
        private System.Windows.Forms.Button RemoveBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox OrderedTick;
        private System.Windows.Forms.CheckBox Unordered;
        private System.Windows.Forms.Button adddANewCountrey;
    }
}

