
namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.provinceBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.leastPopulatedDisplay = new System.Windows.Forms.Label();
            this.mostPopulatedDisplay = new System.Windows.Forms.Label();
            this.provinceCapitalDisplay = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.provincePopulationDisplay = new System.Windows.Forms.Label();
            this.provinceNameDisplay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.locationDisplay = new System.Windows.Forms.Label();
            this.cityPopulationDisplay = new System.Windows.Forms.Label();
            this.cityNameDisplay = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.totalDistLabel = new System.Windows.Forms.Label();
            this.provinceComboDist2 = new System.Windows.Forms.ComboBox();
            this.provinceComboDist1 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cityComboDist2 = new System.Windows.Forms.ComboBox();
            this.cityComboDist1 = new System.Windows.Forms.ComboBox();
            this.calcDistanceBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.popComparerLabel = new System.Windows.Forms.Label();
            this.citynamePopLabel = new System.Windows.Forms.Label();
            this.provinceComboPop2 = new System.Windows.Forms.ComboBox();
            this.provinceComboPop1 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cityComboPop2 = new System.Windows.Forms.ComboBox();
            this.cityComboPop1 = new System.Windows.Forms.ComboBox();
            this.compareBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.provincesRankingLabel = new System.Windows.Forms.Label();
            this.provByCityLBox = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cityBox);
            this.groupBox1.Controls.Add(this.provinceBox);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(20, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(516, 499);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "City:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Province:";
            // 
            // cityBox
            // 
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Location = new System.Drawing.Point(76, 188);
            this.cityBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(366, 40);
            this.cityBox.TabIndex = 4;
            this.cityBox.SelectedIndexChanged += new System.EventHandler(this.cityBox_SelectedIndexChanged);
            // 
            // provinceBox
            // 
            this.provinceBox.FormattingEnabled = true;
            this.provinceBox.Location = new System.Drawing.Point(76, 87);
            this.provinceBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.provinceBox.Name = "provinceBox";
            this.provinceBox.Size = new System.Drawing.Size(366, 40);
            this.provinceBox.TabIndex = 3;
            this.provinceBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 427);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(368, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Parse XML";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 273);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Parse CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 350);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(368, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Parse JSON";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, -2);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(959, 59);
            this.label3.TabIndex = 1;
            this.label3.Text = "Canadian Cities and Province Information Tool";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.leastPopulatedDisplay);
            this.groupBox2.Controls.Add(this.mostPopulatedDisplay);
            this.groupBox2.Controls.Add(this.provinceCapitalDisplay);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.provincePopulationDisplay);
            this.groupBox2.Controls.Add(this.provinceNameDisplay);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(574, 68);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Size = new System.Drawing.Size(732, 397);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Province Information";
            // 
            // leastPopulatedDisplay
            // 
            this.leastPopulatedDisplay.AutoSize = true;
            this.leastPopulatedDisplay.Location = new System.Drawing.Point(316, 341);
            this.leastPopulatedDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leastPopulatedDisplay.Name = "leastPopulatedDisplay";
            this.leastPopulatedDisplay.Size = new System.Drawing.Size(0, 32);
            this.leastPopulatedDisplay.TabIndex = 10;
            // 
            // mostPopulatedDisplay
            // 
            this.mostPopulatedDisplay.AutoSize = true;
            this.mostPopulatedDisplay.Location = new System.Drawing.Point(316, 279);
            this.mostPopulatedDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mostPopulatedDisplay.Name = "mostPopulatedDisplay";
            this.mostPopulatedDisplay.Size = new System.Drawing.Size(0, 32);
            this.mostPopulatedDisplay.TabIndex = 9;
            // 
            // provinceCapitalDisplay
            // 
            this.provinceCapitalDisplay.AutoSize = true;
            this.provinceCapitalDisplay.Location = new System.Drawing.Point(215, 215);
            this.provinceCapitalDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.provinceCapitalDisplay.Name = "provinceCapitalDisplay";
            this.provinceCapitalDisplay.Size = new System.Drawing.Size(0, 32);
            this.provinceCapitalDisplay.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(37, 341);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(235, 32);
            this.label19.TabIndex = 7;
            this.label19.Text = "Least Populated City:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 279);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(235, 32);
            this.label18.TabIndex = 6;
            this.label18.Text = "Most Populated City:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 215);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 32);
            this.label16.TabIndex = 5;
            this.label16.Text = "Capital:";
            // 
            // provincePopulationDisplay
            // 
            this.provincePopulationDisplay.AutoSize = true;
            this.provincePopulationDisplay.Location = new System.Drawing.Point(288, 151);
            this.provincePopulationDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.provincePopulationDisplay.Name = "provincePopulationDisplay";
            this.provincePopulationDisplay.Size = new System.Drawing.Size(0, 32);
            this.provincePopulationDisplay.TabIndex = 4;
            // 
            // provinceNameDisplay
            // 
            this.provinceNameDisplay.AutoSize = true;
            this.provinceNameDisplay.Location = new System.Drawing.Point(288, 87);
            this.provinceNameDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.provinceNameDisplay.Name = "provinceNameDisplay";
            this.provinceNameDisplay.Size = new System.Drawing.Size(0, 32);
            this.provinceNameDisplay.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Province Population:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Province Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.locationDisplay);
            this.groupBox3.Controls.Add(this.cityPopulationDisplay);
            this.groupBox3.Controls.Add(this.cityNameDisplay);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(1309, 68);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Size = new System.Drawing.Size(713, 297);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "City Information";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(243, 226);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 47);
            this.button4.TabIndex = 7;
            this.button4.Text = "Show in Map";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // locationDisplay
            // 
            this.locationDisplay.AutoSize = true;
            this.locationDisplay.Location = new System.Drawing.Point(243, 173);
            this.locationDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationDisplay.Name = "locationDisplay";
            this.locationDisplay.Size = new System.Drawing.Size(0, 32);
            this.locationDisplay.TabIndex = 6;
            // 
            // cityPopulationDisplay
            // 
            this.cityPopulationDisplay.AutoSize = true;
            this.cityPopulationDisplay.Location = new System.Drawing.Point(282, 119);
            this.cityPopulationDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityPopulationDisplay.Name = "cityPopulationDisplay";
            this.cityPopulationDisplay.Size = new System.Drawing.Size(0, 32);
            this.cityPopulationDisplay.TabIndex = 5;
            // 
            // cityNameDisplay
            // 
            this.cityNameDisplay.AutoSize = true;
            this.cityNameDisplay.Location = new System.Drawing.Point(282, 66);
            this.cityNameDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityNameDisplay.Name = "cityNameDisplay";
            this.cityNameDisplay.Size = new System.Drawing.Size(0, 32);
            this.cityNameDisplay.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(353, 66);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 32);
            this.label17.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Location:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "City Population:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "City Name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(574, 484);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox4.Size = new System.Drawing.Size(1450, 510);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Functions";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.totalDistLabel);
            this.groupBox6.Controls.Add(this.provinceComboDist2);
            this.groupBox6.Controls.Add(this.provinceComboDist1);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.cityComboDist2);
            this.groupBox6.Controls.Add(this.cityComboDist1);
            this.groupBox6.Controls.Add(this.calcDistanceBtn);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(726, 38);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox6.Size = new System.Drawing.Size(717, 454);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Calculate Distance";
            // 
            // totalDistLabel
            // 
            this.totalDistLabel.AutoSize = true;
            this.totalDistLabel.Location = new System.Drawing.Point(310, 333);
            this.totalDistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalDistLabel.Name = "totalDistLabel";
            this.totalDistLabel.Size = new System.Drawing.Size(0, 32);
            this.totalDistLabel.TabIndex = 16;
            // 
            // provinceComboDist2
            // 
            this.provinceComboDist2.FormattingEnabled = true;
            this.provinceComboDist2.Location = new System.Drawing.Point(381, 100);
            this.provinceComboDist2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.provinceComboDist2.Name = "provinceComboDist2";
            this.provinceComboDist2.Size = new System.Drawing.Size(310, 40);
            this.provinceComboDist2.TabIndex = 15;
            this.provinceComboDist2.SelectedIndexChanged += new System.EventHandler(this.provinceComboDist2_SelectedIndexChanged);
            // 
            // provinceComboDist1
            // 
            this.provinceComboDist1.FormattingEnabled = true;
            this.provinceComboDist1.Location = new System.Drawing.Point(22, 100);
            this.provinceComboDist1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.provinceComboDist1.Name = "provinceComboDist1";
            this.provinceComboDist1.Size = new System.Drawing.Size(323, 40);
            this.provinceComboDist1.TabIndex = 14;
            this.provinceComboDist1.SelectedIndexChanged += new System.EventHandler(this.provinceComboDist1_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(444, 51);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(139, 32);
            this.label23.TabIndex = 13;
            this.label23.Text = "Province #2";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(97, 51);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(139, 32);
            this.label22.TabIndex = 12;
            this.label22.Text = "Province #1";
            // 
            // cityComboDist2
            // 
            this.cityComboDist2.FormattingEnabled = true;
            this.cityComboDist2.Location = new System.Drawing.Point(381, 213);
            this.cityComboDist2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cityComboDist2.Name = "cityComboDist2";
            this.cityComboDist2.Size = new System.Drawing.Size(310, 40);
            this.cityComboDist2.TabIndex = 11;
            // 
            // cityComboDist1
            // 
            this.cityComboDist1.FormattingEnabled = true;
            this.cityComboDist1.Location = new System.Drawing.Point(22, 213);
            this.cityComboDist1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cityComboDist1.Name = "cityComboDist1";
            this.cityComboDist1.Size = new System.Drawing.Size(323, 40);
            this.cityComboDist1.TabIndex = 10;
            // 
            // calcDistanceBtn
            // 
            this.calcDistanceBtn.Location = new System.Drawing.Point(293, 390);
            this.calcDistanceBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.calcDistanceBtn.Name = "calcDistanceBtn";
            this.calcDistanceBtn.Size = new System.Drawing.Size(150, 47);
            this.calcDistanceBtn.TabIndex = 8;
            this.calcDistanceBtn.Text = "Calculate";
            this.calcDistanceBtn.UseVisualStyleBackColor = true;
            this.calcDistanceBtn.Click += new System.EventHandler(this.calcDistanceBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(126, 333);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 32);
            this.label15.TabIndex = 7;
            this.label15.Text = "Total Distance:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(444, 158);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 32);
            this.label12.TabIndex = 4;
            this.label12.Text = "City #2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 158);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 32);
            this.label11.TabIndex = 3;
            this.label11.Text = "City #1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.popComparerLabel);
            this.groupBox5.Controls.Add(this.citynamePopLabel);
            this.groupBox5.Controls.Add(this.provinceComboPop2);
            this.groupBox5.Controls.Add(this.provinceComboPop1);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.cityComboPop2);
            this.groupBox5.Controls.Add(this.cityComboPop1);
            this.groupBox5.Controls.Add(this.compareBtn);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(19, 38);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox5.Size = new System.Drawing.Size(704, 454);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Compare Population";
            // 
            // popComparerLabel
            // 
            this.popComparerLabel.AutoSize = true;
            this.popComparerLabel.Location = new System.Drawing.Point(240, 333);
            this.popComparerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.popComparerLabel.Name = "popComparerLabel";
            this.popComparerLabel.Size = new System.Drawing.Size(0, 32);
            this.popComparerLabel.TabIndex = 15;
            // 
            // citynamePopLabel
            // 
            this.citynamePopLabel.AutoSize = true;
            this.citynamePopLabel.Location = new System.Drawing.Point(240, 284);
            this.citynamePopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.citynamePopLabel.Name = "citynamePopLabel";
            this.citynamePopLabel.Size = new System.Drawing.Size(0, 32);
            this.citynamePopLabel.TabIndex = 14;
            // 
            // provinceComboPop2
            // 
            this.provinceComboPop2.FormattingEnabled = true;
            this.provinceComboPop2.Location = new System.Drawing.Point(366, 100);
            this.provinceComboPop2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.provinceComboPop2.Name = "provinceComboPop2";
            this.provinceComboPop2.Size = new System.Drawing.Size(314, 40);
            this.provinceComboPop2.TabIndex = 13;
            this.provinceComboPop2.SelectedIndexChanged += new System.EventHandler(this.provinceComboPop2_SelectedIndexChanged);
            // 
            // provinceComboPop1
            // 
            this.provinceComboPop1.FormattingEnabled = true;
            this.provinceComboPop1.Location = new System.Drawing.Point(22, 100);
            this.provinceComboPop1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.provinceComboPop1.Name = "provinceComboPop1";
            this.provinceComboPop1.Size = new System.Drawing.Size(318, 40);
            this.provinceComboPop1.TabIndex = 12;
            this.provinceComboPop1.SelectedIndexChanged += new System.EventHandler(this.provinceComboPop1_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(448, 51);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(139, 32);
            this.label21.TabIndex = 11;
            this.label21.Text = "Province #2";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(100, 51);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(139, 32);
            this.label20.TabIndex = 10;
            this.label20.Text = "Province #1";
            // 
            // cityComboPop2
            // 
            this.cityComboPop2.FormattingEnabled = true;
            this.cityComboPop2.Location = new System.Drawing.Point(366, 213);
            this.cityComboPop2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cityComboPop2.Name = "cityComboPop2";
            this.cityComboPop2.Size = new System.Drawing.Size(314, 40);
            this.cityComboPop2.TabIndex = 9;
            // 
            // cityComboPop1
            // 
            this.cityComboPop1.FormattingEnabled = true;
            this.cityComboPop1.Location = new System.Drawing.Point(22, 213);
            this.cityComboPop1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cityComboPop1.Name = "cityComboPop1";
            this.cityComboPop1.Size = new System.Drawing.Size(318, 40);
            this.cityComboPop1.TabIndex = 8;
            // 
            // compareBtn
            // 
            this.compareBtn.Location = new System.Drawing.Point(240, 390);
            this.compareBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(150, 47);
            this.compareBtn.TabIndex = 7;
            this.compareBtn.Text = "Compare";
            this.compareBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(100, 333);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 32);
            this.label14.TabIndex = 6;
            this.label14.Text = "Population:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(100, 284);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 32);
            this.label13.TabIndex = 5;
            this.label13.Text = "Larger City:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 32);
            this.label10.TabIndex = 2;
            this.label10.Text = "City #2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 158);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "City #1";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(1896, 11);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(150, 47);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // provincesRankingLabel
            // 
            this.provincesRankingLabel.AutoSize = true;
            this.provincesRankingLabel.Location = new System.Drawing.Point(184, 574);
            this.provincesRankingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.provincesRankingLabel.Name = "provincesRankingLabel";
            this.provincesRankingLabel.Size = new System.Drawing.Size(208, 32);
            this.provincesRankingLabel.TabIndex = 7;
            this.provincesRankingLabel.Text = "Provinces Ranking";
            // 
            // provByCityLBox
            // 
            this.provByCityLBox.FormattingEnabled = true;
            this.provByCityLBox.ItemHeight = 32;
            this.provByCityLBox.Location = new System.Drawing.Point(20, 713);
            this.provByCityLBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.provByCityLBox.Name = "provByCityLBox";
            this.provByCityLBox.Size = new System.Drawing.Size(546, 548);
            this.provByCityLBox.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(33, 651);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 47);
            this.button5.TabIndex = 9;
            this.button5.Text = "By Cities";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(345, 651);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 47);
            this.button6.TabIndex = 10;
            this.button6.Text = "By Population";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2073, 1278);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.provByCityLBox);
            this.Controls.Add(this.provincesRankingLabel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.ComboBox provinceBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cityComboDist2;
        private System.Windows.Forms.ComboBox cityComboDist1;
        private System.Windows.Forms.Button calcDistanceBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cityComboPop2;
        private System.Windows.Forms.ComboBox cityComboPop1;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label provinceNameDisplay;
        private System.Windows.Forms.Label provincePopulationDisplay;
        private System.Windows.Forms.Label cityPopulationDisplay;
        private System.Windows.Forms.Label cityNameDisplay;
        private System.Windows.Forms.Label locationDisplay;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label leastPopulatedDisplay;
        private System.Windows.Forms.Label mostPopulatedDisplay;
        private System.Windows.Forms.Label provinceCapitalDisplay;
        private System.Windows.Forms.ComboBox provinceComboDist2;
        private System.Windows.Forms.ComboBox provinceComboDist1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox provinceComboPop2;
        private System.Windows.Forms.ComboBox provinceComboPop1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label popComparerLabel;
        private System.Windows.Forms.Label citynamePopLabel;
        private System.Windows.Forms.Label totalDistLabel;
        private System.Windows.Forms.Label provincesRankingLabel;
        private System.Windows.Forms.ListBox provByCityLBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
    }
}

