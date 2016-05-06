namespace Text_Adventure_Framework
{
    partial class Initialize
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
            this.playerNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.classSelect = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalStat = new System.Windows.Forms.TextBox();
            this.dexterityNum = new System.Windows.Forms.NumericUpDown();
            this.constitutionNum = new System.Windows.Forms.NumericUpDown();
            this.intelligenceNum = new System.Windows.Forms.NumericUpDown();
            this.wisdomNum = new System.Windows.Forms.NumericUpDown();
            this.charismaNum = new System.Windows.Forms.NumericUpDown();
            this.strengthNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dexterityNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constitutionNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelligenceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisdomNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charismaNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strengthNum)).BeginInit();
            this.SuspendLayout();
            // 
            // playerNameBox
            // 
            this.playerNameBox.Location = new System.Drawing.Point(88, 25);
            this.playerNameBox.Name = "playerNameBox";
            this.playerNameBox.Size = new System.Drawing.Size(150, 20);
            this.playerNameBox.TabIndex = 0;
            this.playerNameBox.Text = "Hero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.playerNameBox);
            this.groupBox1.Controls.Add(this.classSelect);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.totalStat);
            this.groupBox1.Controls.Add(this.dexterityNum);
            this.groupBox1.Controls.Add(this.constitutionNum);
            this.groupBox1.Controls.Add(this.intelligenceNum);
            this.groupBox1.Controls.Add(this.wisdomNum);
            this.groupBox1.Controls.Add(this.charismaNum);
            this.groupBox1.Controls.Add(this.strengthNum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 278);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Class";
            // 
            // classSelect
            // 
            this.classSelect.FormattingEnabled = true;
            this.classSelect.Items.AddRange(new object[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Ranger",
            "Paladin",
            "Monk",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Wizard",
            "Battlemage"});
            this.classSelect.Location = new System.Drawing.Point(110, 238);
            this.classSelect.Name = "classSelect";
            this.classSelect.Size = new System.Drawing.Size(121, 21);
            this.classSelect.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Charisma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Wisdom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Intelligence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Constitution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dexterity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Strength";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Points Remaining";
            // 
            // totalStat
            // 
            this.totalStat.Enabled = false;
            this.totalStat.Location = new System.Drawing.Point(110, 54);
            this.totalStat.Name = "totalStat";
            this.totalStat.Size = new System.Drawing.Size(33, 20);
            this.totalStat.TabIndex = 6;
            this.totalStat.Text = "25";
            // 
            // dexterityNum
            // 
            this.dexterityNum.Location = new System.Drawing.Point(110, 108);
            this.dexterityNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dexterityNum.Name = "dexterityNum";
            this.dexterityNum.Size = new System.Drawing.Size(33, 20);
            this.dexterityNum.TabIndex = 5;
            this.dexterityNum.ValueChanged += new System.EventHandler(this.dexterityNum_ValueChanged);
            // 
            // constitutionNum
            // 
            this.constitutionNum.Location = new System.Drawing.Point(110, 134);
            this.constitutionNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.constitutionNum.Name = "constitutionNum";
            this.constitutionNum.Size = new System.Drawing.Size(33, 20);
            this.constitutionNum.TabIndex = 4;
            this.constitutionNum.ValueChanged += new System.EventHandler(this.constitutionNum_ValueChanged);
            // 
            // intelligenceNum
            // 
            this.intelligenceNum.Location = new System.Drawing.Point(110, 160);
            this.intelligenceNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.intelligenceNum.Name = "intelligenceNum";
            this.intelligenceNum.Size = new System.Drawing.Size(33, 20);
            this.intelligenceNum.TabIndex = 3;
            this.intelligenceNum.ValueChanged += new System.EventHandler(this.intelligenceNum_ValueChanged);
            // 
            // wisdomNum
            // 
            this.wisdomNum.Location = new System.Drawing.Point(110, 186);
            this.wisdomNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.wisdomNum.Name = "wisdomNum";
            this.wisdomNum.Size = new System.Drawing.Size(33, 20);
            this.wisdomNum.TabIndex = 2;
            this.wisdomNum.ValueChanged += new System.EventHandler(this.wisdomNum_ValueChanged);
            // 
            // charismaNum
            // 
            this.charismaNum.Location = new System.Drawing.Point(110, 212);
            this.charismaNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.charismaNum.Name = "charismaNum";
            this.charismaNum.Size = new System.Drawing.Size(33, 20);
            this.charismaNum.TabIndex = 1;
            this.charismaNum.ValueChanged += new System.EventHandler(this.charismaNum_ValueChanged);
            // 
            // strengthNum
            // 
            this.strengthNum.Location = new System.Drawing.Point(110, 82);
            this.strengthNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.strengthNum.Name = "strengthNum";
            this.strengthNum.Size = new System.Drawing.Size(33, 20);
            this.strengthNum.TabIndex = 0;
            this.strengthNum.ValueChanged += new System.EventHandler(this.strengthNum_ValueChanged);
            // 
            // Initialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 587);
            this.Controls.Add(this.groupBox1);
            this.Name = "Initialize";
            this.Text = "Set Your Options";
            this.Load += new System.EventHandler(this.Initialize_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dexterityNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constitutionNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelligenceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisdomNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charismaNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strengthNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox playerNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalStat;
        private System.Windows.Forms.NumericUpDown dexterityNum;
        private System.Windows.Forms.NumericUpDown constitutionNum;
        private System.Windows.Forms.NumericUpDown intelligenceNum;
        private System.Windows.Forms.NumericUpDown wisdomNum;
        private System.Windows.Forms.NumericUpDown charismaNum;
        private System.Windows.Forms.NumericUpDown strengthNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox classSelect;
    }
}

