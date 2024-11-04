namespace TextureConverter
{
    partial class ConvertPBRtoEnfusion
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
            checkBox1 = new CheckBox();
            folderBrowserDialog2 = new FolderBrowserDialog();
            groupBox5 = new GroupBox();
            textBox3 = new TextBox();
            groupBox6 = new GroupBox();
            textBox5 = new TextBox();
            groupBox3 = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            groupBox4 = new GroupBox();
            textBox4 = new TextBox();
            groupBox8 = new GroupBox();
            textBox7 = new TextBox();
            groupBox9 = new GroupBox();
            textBox8 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 58);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Source";
            // 
            // button2
            // 
            button2.Location = new Point(394, 22);
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
            textBox1.Size = new Size(382, 23);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(12, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(493, 57);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Destination";
            // 
            // button3
            // 
            button3.Location = new Point(394, 21);
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
            textBox2.Size = new Size(382, 23);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(12, 338);
            button1.Name = "button1";
            button1.Size = new Size(240, 34);
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
            checkBox1.Location = new Point(6, 96);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Enable LZW**";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox3);
            groupBox5.Location = new Point(12, 149);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(179, 57);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Albedo / Base Colour";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 23);
            textBox3.TabIndex = 0;
            textBox3.Text = "_BaseColor";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBox5);
            groupBox6.Location = new Point(326, 212);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(179, 57);
            groupBox6.TabIndex = 11;
            groupBox6.TabStop = false;
            groupBox6.Text = "Normal";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 22);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(167, 23);
            textBox5.TabIndex = 2;
            textBox5.Text = "_Normal";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox4);
            groupBox3.Controls.Add(checkBox3);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Location = new Point(197, 149);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(123, 120);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Advanced Settings";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 47);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(86, 19);
            checkBox4.TabIndex = 6;
            checkBox4.Text = "Exclude M*";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 22);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(87, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Exclude AO";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 71);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(99, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Exclude NMO";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(397, 357);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(108, 15);
            progressBar1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 357);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 13;
            label1.Text = "Status:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox4);
            groupBox4.Location = new Point(326, 149);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(179, 57);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Roughness";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(167, 23);
            textBox4.TabIndex = 0;
            textBox4.Text = "_Roughness";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(textBox7);
            groupBox8.Location = new Point(12, 275);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(179, 57);
            groupBox8.TabIndex = 11;
            groupBox8.TabStop = false;
            groupBox8.Text = "Ambient Occlusion / AO";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(6, 22);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(167, 23);
            textBox7.TabIndex = 0;
            textBox7.Text = "_AO";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(textBox8);
            groupBox9.Location = new Point(12, 212);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(179, 57);
            groupBox9.TabIndex = 12;
            groupBox9.TabStop = false;
            groupBox9.Text = "Metalness";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(6, 22);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(167, 23);
            textBox8.TabIndex = 0;
            textBox8.Text = "_Metalness";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 275);
            label2.Name = "label2";
            label2.Size = new Size(275, 15);
            label2.TabIndex = 14;
            label2.Text = "* Refers to ignoring Metalness when creating NMO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 290);
            label3.Name = "label3";
            label3.Size = new Size(260, 15);
            label3.TabIndex = 15;
            label3.Text = "** LZW refers to the TIFF compression algorithm";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 384);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox9);
            Controls.Add(groupBox8);
            Controls.Add(groupBox4);
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
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TextureConverter (PBR to Enfusion)";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
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
        private GroupBox groupBox3;
        private TextBox textBox3;
        private TextBox textBox5;
        private ProgressBar progressBar1;
        private Label label1;
        private GroupBox groupBox4;
        private TextBox textBox4;
        private GroupBox groupBox8;
        private TextBox textBox7;
        private GroupBox groupBox9;
        private TextBox textBox8;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private Label label2;
        private Label label3;
    }
}