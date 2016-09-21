namespace Black_Hat_Solver
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
            this.cypherTextBox = new System.Windows.Forms.TextBox();
            this.plainTextBox = new System.Windows.Forms.TextBox();
            this.wordScoreButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wordScoreValue = new System.Windows.Forms.Label();
            this.smartDetectionButton = new System.Windows.Forms.Button();
            this.playfairButton = new System.Windows.Forms.Button();
            this.ceasarButton = new System.Windows.Forms.Button();
            this.substitutionButton = new System.Windows.Forms.Button();
            this.columnTransButton = new System.Windows.Forms.Button();
            this.hillButton = new System.Windows.Forms.Button();
            this.ceasarModeBox = new System.Windows.Forms.GroupBox();
            this.ceasarModeRadioBruteForce = new System.Windows.Forms.RadioButton();
            this.ceasarModeRadioSmart = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cipherValue = new System.Windows.Forms.Label();
            this.vigenereButton = new System.Windows.Forms.Button();
            this.vigenereModeBox = new System.Windows.Forms.GroupBox();
            this.vigenereModeRadioBruteForce = new System.Windows.Forms.RadioButton();
            this.vigenereModeRadioSmart = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vigenereMaxSize = new System.Windows.Forms.TextBox();
            this.VigenereMinSize = new System.Windows.Forms.TextBox();
            this.vigenereCheckBoxUseDict = new System.Windows.Forms.CheckBox();
            this.possibleKeyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ceasarModeBox.SuspendLayout();
            this.vigenereModeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cypherTextBox
            // 
            this.cypherTextBox.Location = new System.Drawing.Point(13, 13);
            this.cypherTextBox.Multiline = true;
            this.cypherTextBox.Name = "cypherTextBox";
            this.cypherTextBox.Size = new System.Drawing.Size(259, 314);
            this.cypherTextBox.TabIndex = 0;
            // 
            // plainTextBox
            // 
            this.plainTextBox.Location = new System.Drawing.Point(736, 12);
            this.plainTextBox.Multiline = true;
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(259, 315);
            this.plainTextBox.TabIndex = 1;
            // 
            // wordScoreButton
            // 
            this.wordScoreButton.Location = new System.Drawing.Point(279, 13);
            this.wordScoreButton.Name = "wordScoreButton";
            this.wordScoreButton.Size = new System.Drawing.Size(98, 23);
            this.wordScoreButton.TabIndex = 2;
            this.wordScoreButton.Text = "Get Word Score";
            this.wordScoreButton.UseVisualStyleBackColor = true;
            this.wordScoreButton.Click += new System.EventHandler(this.wordCountButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key:";
            // 
            // keyValue
            // 
            this.keyValue.AutoSize = true;
            this.keyValue.Location = new System.Drawing.Point(642, 295);
            this.keyValue.Name = "keyValue";
            this.keyValue.Size = new System.Drawing.Size(55, 13);
            this.keyValue.TabIndex = 4;
            this.keyValue.Text = "Key Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Word Score:";
            // 
            // wordScoreValue
            // 
            this.wordScoreValue.AutoSize = true;
            this.wordScoreValue.Location = new System.Drawing.Point(642, 312);
            this.wordScoreValue.Name = "wordScoreValue";
            this.wordScoreValue.Size = new System.Drawing.Size(94, 13);
            this.wordScoreValue.TabIndex = 6;
            this.wordScoreValue.Text = "Word Score Value";
            // 
            // smartDetectionButton
            // 
            this.smartDetectionButton.Location = new System.Drawing.Point(279, 43);
            this.smartDetectionButton.Name = "smartDetectionButton";
            this.smartDetectionButton.Size = new System.Drawing.Size(98, 23);
            this.smartDetectionButton.TabIndex = 7;
            this.smartDetectionButton.Text = "Smart Detection";
            this.smartDetectionButton.UseVisualStyleBackColor = true;
            // 
            // playfairButton
            // 
            this.playfairButton.Location = new System.Drawing.Point(279, 73);
            this.playfairButton.Name = "playfairButton";
            this.playfairButton.Size = new System.Drawing.Size(98, 23);
            this.playfairButton.TabIndex = 8;
            this.playfairButton.Text = "Playfair";
            this.playfairButton.UseVisualStyleBackColor = true;
            // 
            // ceasarButton
            // 
            this.ceasarButton.Location = new System.Drawing.Point(278, 304);
            this.ceasarButton.Name = "ceasarButton";
            this.ceasarButton.Size = new System.Drawing.Size(98, 23);
            this.ceasarButton.TabIndex = 9;
            this.ceasarButton.Text = "Caesar";
            this.ceasarButton.UseVisualStyleBackColor = true;
            this.ceasarButton.Click += new System.EventHandler(this.ceaserButton_Click);
            // 
            // substitutionButton
            // 
            this.substitutionButton.Location = new System.Drawing.Point(279, 102);
            this.substitutionButton.Name = "substitutionButton";
            this.substitutionButton.Size = new System.Drawing.Size(98, 23);
            this.substitutionButton.TabIndex = 10;
            this.substitutionButton.Text = "Substitution";
            this.substitutionButton.UseVisualStyleBackColor = true;
            // 
            // columnTransButton
            // 
            this.columnTransButton.Location = new System.Drawing.Point(279, 163);
            this.columnTransButton.Name = "columnTransButton";
            this.columnTransButton.Size = new System.Drawing.Size(98, 23);
            this.columnTransButton.TabIndex = 11;
            this.columnTransButton.Text = "Column Trans";
            this.columnTransButton.UseVisualStyleBackColor = true;
            // 
            // hillButton
            // 
            this.hillButton.Location = new System.Drawing.Point(279, 193);
            this.hillButton.Name = "hillButton";
            this.hillButton.Size = new System.Drawing.Size(98, 23);
            this.hillButton.TabIndex = 12;
            this.hillButton.Text = "Hill";
            this.hillButton.UseVisualStyleBackColor = true;
            // 
            // ceasarModeBox
            // 
            this.ceasarModeBox.Controls.Add(this.ceasarModeRadioBruteForce);
            this.ceasarModeBox.Controls.Add(this.ceasarModeRadioSmart);
            this.ceasarModeBox.Location = new System.Drawing.Point(382, 293);
            this.ceasarModeBox.Name = "ceasarModeBox";
            this.ceasarModeBox.Size = new System.Drawing.Size(145, 34);
            this.ceasarModeBox.TabIndex = 14;
            this.ceasarModeBox.TabStop = false;
            this.ceasarModeBox.Text = "Ceaser Mode:";
            // 
            // ceasarModeRadioBruteForce
            // 
            this.ceasarModeRadioBruteForce.AutoSize = true;
            this.ceasarModeRadioBruteForce.Location = new System.Drawing.Point(64, 16);
            this.ceasarModeRadioBruteForce.Name = "ceasarModeRadioBruteForce";
            this.ceasarModeRadioBruteForce.Size = new System.Drawing.Size(80, 17);
            this.ceasarModeRadioBruteForce.TabIndex = 14;
            this.ceasarModeRadioBruteForce.Text = "Brute Force";
            this.ceasarModeRadioBruteForce.UseVisualStyleBackColor = true;
            // 
            // ceasarModeRadioSmart
            // 
            this.ceasarModeRadioSmart.AutoSize = true;
            this.ceasarModeRadioSmart.Checked = true;
            this.ceasarModeRadioSmart.Location = new System.Drawing.Point(6, 16);
            this.ceasarModeRadioSmart.Name = "ceasarModeRadioSmart";
            this.ceasarModeRadioSmart.Size = new System.Drawing.Size(52, 17);
            this.ceasarModeRadioSmart.TabIndex = 13;
            this.ceasarModeRadioSmart.TabStop = true;
            this.ceasarModeRadioSmart.Text = "Smart";
            this.ceasarModeRadioSmart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cipher:";
            // 
            // cipherValue
            // 
            this.cipherValue.AutoSize = true;
            this.cipherValue.Location = new System.Drawing.Point(642, 277);
            this.cipherValue.Name = "cipherValue";
            this.cipherValue.Size = new System.Drawing.Size(67, 13);
            this.cipherValue.TabIndex = 16;
            this.cipherValue.Text = "Cipher Value";
            // 
            // vigenereButton
            // 
            this.vigenereButton.Location = new System.Drawing.Point(279, 134);
            this.vigenereButton.Name = "vigenereButton";
            this.vigenereButton.Size = new System.Drawing.Size(98, 23);
            this.vigenereButton.TabIndex = 17;
            this.vigenereButton.Text = "Vigenère";
            this.vigenereButton.UseVisualStyleBackColor = true;
            this.vigenereButton.Click += new System.EventHandler(this.vigenereButton_Click);
            // 
            // vigenereModeBox
            // 
            this.vigenereModeBox.Controls.Add(this.vigenereModeRadioBruteForce);
            this.vigenereModeBox.Controls.Add(this.vigenereModeRadioSmart);
            this.vigenereModeBox.Location = new System.Drawing.Point(386, 125);
            this.vigenereModeBox.Name = "vigenereModeBox";
            this.vigenereModeBox.Size = new System.Drawing.Size(145, 34);
            this.vigenereModeBox.TabIndex = 15;
            this.vigenereModeBox.TabStop = false;
            this.vigenereModeBox.Text = "Vigenère Mode:";
            // 
            // vigenereModeRadioBruteForce
            // 
            this.vigenereModeRadioBruteForce.AutoSize = true;
            this.vigenereModeRadioBruteForce.Checked = true;
            this.vigenereModeRadioBruteForce.Location = new System.Drawing.Point(64, 16);
            this.vigenereModeRadioBruteForce.Name = "vigenereModeRadioBruteForce";
            this.vigenereModeRadioBruteForce.Size = new System.Drawing.Size(80, 17);
            this.vigenereModeRadioBruteForce.TabIndex = 14;
            this.vigenereModeRadioBruteForce.TabStop = true;
            this.vigenereModeRadioBruteForce.Text = "Brute Force";
            this.vigenereModeRadioBruteForce.UseVisualStyleBackColor = true;
            // 
            // vigenereModeRadioSmart
            // 
            this.vigenereModeRadioSmart.AutoSize = true;
            this.vigenereModeRadioSmart.Location = new System.Drawing.Point(6, 16);
            this.vigenereModeRadioSmart.Name = "vigenereModeRadioSmart";
            this.vigenereModeRadioSmart.Size = new System.Drawing.Size(52, 17);
            this.vigenereModeRadioSmart.TabIndex = 13;
            this.vigenereModeRadioSmart.Text = "Smart";
            this.vigenereModeRadioSmart.UseVisualStyleBackColor = true;
            this.vigenereModeRadioSmart.CheckedChanged += new System.EventHandler(this.vigenereModeRadioSmart_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Min:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Max:";
            // 
            // vigenereMaxSize
            // 
            this.vigenereMaxSize.Location = new System.Drawing.Point(631, 139);
            this.vigenereMaxSize.Name = "vigenereMaxSize";
            this.vigenereMaxSize.Size = new System.Drawing.Size(19, 20);
            this.vigenereMaxSize.TabIndex = 20;
            this.vigenereMaxSize.Text = "10";
            this.vigenereMaxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VigenereMinSize
            // 
            this.VigenereMinSize.Location = new System.Drawing.Point(570, 138);
            this.VigenereMinSize.Name = "VigenereMinSize";
            this.VigenereMinSize.Size = new System.Drawing.Size(19, 20);
            this.VigenereMinSize.TabIndex = 22;
            this.VigenereMinSize.Text = "5";
            this.VigenereMinSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vigenereCheckBoxUseDict
            // 
            this.vigenereCheckBoxUseDict.AutoSize = true;
            this.vigenereCheckBoxUseDict.Location = new System.Drawing.Point(657, 141);
            this.vigenereCheckBoxUseDict.Name = "vigenereCheckBoxUseDict";
            this.vigenereCheckBoxUseDict.Size = new System.Drawing.Size(73, 17);
            this.vigenereCheckBoxUseDict.TabIndex = 23;
            this.vigenereCheckBoxUseDict.Text = "Use Dict?";
            this.vigenereCheckBoxUseDict.UseVisualStyleBackColor = true;
            this.vigenereCheckBoxUseDict.CheckedChanged += new System.EventHandler(this.vigenereCheckBoxUseDict_CheckedChanged);
            // 
            // possibleKeyTextBox
            // 
            this.possibleKeyTextBox.Location = new System.Drawing.Point(475, 13);
            this.possibleKeyTextBox.Name = "possibleKeyTextBox";
            this.possibleKeyTextBox.Size = new System.Drawing.Size(100, 20);
            this.possibleKeyTextBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "All or part of key:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 339);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.possibleKeyTextBox);
            this.Controls.Add(this.vigenereCheckBoxUseDict);
            this.Controls.Add(this.VigenereMinSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vigenereMaxSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vigenereModeBox);
            this.Controls.Add(this.vigenereButton);
            this.Controls.Add(this.cipherValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ceasarModeBox);
            this.Controls.Add(this.hillButton);
            this.Controls.Add(this.columnTransButton);
            this.Controls.Add(this.substitutionButton);
            this.Controls.Add(this.ceasarButton);
            this.Controls.Add(this.playfairButton);
            this.Controls.Add(this.smartDetectionButton);
            this.Controls.Add(this.wordScoreValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keyValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wordScoreButton);
            this.Controls.Add(this.plainTextBox);
            this.Controls.Add(this.cypherTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ceasarModeBox.ResumeLayout(false);
            this.ceasarModeBox.PerformLayout();
            this.vigenereModeBox.ResumeLayout(false);
            this.vigenereModeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cypherTextBox;
        private System.Windows.Forms.TextBox plainTextBox;
        private System.Windows.Forms.Button wordScoreButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label keyValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label wordScoreValue;
        private System.Windows.Forms.Button smartDetectionButton;
        private System.Windows.Forms.Button playfairButton;
        private System.Windows.Forms.Button ceasarButton;
        private System.Windows.Forms.Button substitutionButton;
        private System.Windows.Forms.Button columnTransButton;
        private System.Windows.Forms.Button hillButton;
        private System.Windows.Forms.GroupBox ceasarModeBox;
        private System.Windows.Forms.RadioButton ceasarModeRadioBruteForce;
        private System.Windows.Forms.RadioButton ceasarModeRadioSmart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cipherValue;
        private System.Windows.Forms.Button vigenereButton;
        private System.Windows.Forms.GroupBox vigenereModeBox;
        private System.Windows.Forms.RadioButton vigenereModeRadioBruteForce;
        private System.Windows.Forms.RadioButton vigenereModeRadioSmart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vigenereMaxSize;
        private System.Windows.Forms.TextBox VigenereMinSize;
        private System.Windows.Forms.CheckBox vigenereCheckBoxUseDict;
        private System.Windows.Forms.TextBox possibleKeyTextBox;
        private System.Windows.Forms.Label label6;
    }
}

