namespace TextureConverter
{
    partial class TextureScaler
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
            folderBrowserDialog1 = new FolderBrowserDialog();
            groupBox2 = new GroupBox();
            button3 = new Button();
            textBox2 = new TextBox();
            button1 = new Button();
            folderBrowserDialog2 = new FolderBrowserDialog();
            groupBox5 = new GroupBox();
            comboBox1 = new ComboBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            groupBox3 = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
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
            button1.Location = new Point(12, 231);
            button1.Name = "button1";
            button1.Size = new Size(240, 34);
            button1.TabIndex = 2;
            button1.Text = "Scale Textures";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(comboBox1);
            groupBox5.Location = new Point(12, 149);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(125, 56);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Select Scale (%)";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "75%", "50%", "25%" });
            comboBox1.Location = new Point(6, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(104, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "75%";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(385, 250);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(108, 15);
            progressBar1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 250);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 13;
            label1.Text = "Status:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Location = new Point(150, 149);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(134, 74);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Options";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(6, 47);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(123, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "LZW Compression";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(112, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Replace Original";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // TextureScaler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 274);
            Controls.Add(groupBox3);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(groupBox5);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TextureScaler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Texture Scaler";
            Load += Form4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
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
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private TextBox textBox2;
        private FolderBrowserDialog folderBrowserDialog2;
        private GroupBox groupBox5;
        private ProgressBar progressBar1;
        private Label label1;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}