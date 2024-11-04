namespace TextureConverter
{
    partial class ConvertUnrealtoEnfusion
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            textBox1 = new TextBox();
            groupBox7 = new GroupBox();
            textBox6 = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            groupBox2 = new GroupBox();
            button3 = new Button();
            textBox2 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            folderBrowserDialog2 = new FolderBrowserDialog();
            groupBox5 = new GroupBox();
            textBox3 = new TextBox();
            groupBox6 = new GroupBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            groupBox3 = new GroupBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 58);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Source";
            // 
            // button2
            // 
            button2.Location = new Point(382, 22);
            button2.Name = "button2";
            button2.Size = new Size(93, 23);
            button2.TabIndex = 5;
            button2.Text = "Browse Folder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(370, 23);
            textBox1.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(textBox6);
            groupBox7.Location = new Point(263, 149);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(215, 57);
            groupBox7.TabIndex = 11;
            groupBox7.TabStop = false;
            groupBox7.Text = "AORM Mask";
            groupBox7.Enter += groupBox7_Enter;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(6, 22);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(202, 23);
            textBox6.TabIndex = 1;
            textBox6.Text = "_AORM";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(12, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(481, 57);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Destination";
            // 
            // button3
            // 
            button3.Location = new Point(382, 21);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 7;
            button3.Text = "Browse Folder";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 22);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(370, 23);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(12, 302);
            button1.Name = "button1";
            button1.Size = new Size(135, 34);
            button1.TabIndex = 2;
            button1.Text = "Convert Textures";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(6, 51);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(123, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "LZW Compression";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox3);
            groupBox5.Location = new Point(19, 149);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(238, 57);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Albedo / Base Colour";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(226, 23);
            textBox3.TabIndex = 0;
            textBox3.Text = "_Albedo";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBox5);
            groupBox6.Location = new Point(263, 212);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(215, 57);
            groupBox6.TabIndex = 11;
            groupBox6.TabStop = false;
            groupBox6.Text = "Normal";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 22);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(202, 23);
            textBox5.TabIndex = 2;
            textBox5.Text = "_Normal";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AORM/ARM", "MR/MetalnessRoughness" });
            comboBox1.Location = new Point(6, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 23);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "AORM/ARM";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Location = new Point(18, 212);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(239, 78);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Advanced Settings";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(385, 321);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(108, 15);
            progressBar1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 321);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 13;
            label1.Text = "Status:";
            // 
            // ConvertUnrealtoEnfusion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 348);
            Controls.Add(groupBox7);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ConvertUnrealtoEnfusion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TextureConverter (Unreal to Enfusion)";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private GroupBox groupBox2;
        private Button button1;
        private CheckBox checkBox1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private TextBox textBox2;
        private FolderBrowserDialog folderBrowserDialog2;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private TextBox textBox5;
        private ProgressBar progressBar1;
        private Label label1;
        private GroupBox groupBox7;
        private TextBox textBox6;
    }
}