namespace WinFormsArray
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(38, 25);
            button1.Name = "button1";
            button1.Size = new Size(166, 71);
            button1.TabIndex = 0;
            button1.Text = "Array1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(37, 126);
            button2.Name = "button2";
            button2.Size = new Size(167, 79);
            button2.TabIndex = 1;
            button2.Text = "Array2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(246, 61);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 365);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(638, 61);
            label1.Name = "label1";
            label1.Size = new Size(221, 359);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // button3
            // 
            button3.Location = new Point(499, 77);
            button3.Name = "button3";
            button3.Size = new Size(126, 90);
            button3.TabIndex = 4;
            button3.Text = "GetData";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 31);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 5;
            label2.Text = "พิมพ์รายชื่อ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(638, 31);
            label3.Name = "label3";
            label3.Size = new Size(151, 28);
            label3.TabIndex = 5;
            label3.Text = "รายชื่อที่บันทึกแล้ว";
            // 
            // button4
            // 
            button4.Location = new Point(499, 193);
            button4.Name = "button4";
            button4.Size = new Size(126, 75);
            button4.TabIndex = 6;
            button4.Text = "GetNumber";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(47, 228);
            button5.Name = "button5";
            button5.Size = new Size(157, 94);
            button5.TabIndex = 7;
            button5.Text = "Array 2 มิติ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(941, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 36);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(941, 141);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 116);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(941, 297);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(183, 120);
            checkedListBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "WinForm.Array";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Button button3;
        private Label label2;
        private Label label3;
        private Button button4;
        private Button button5;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private CheckedListBox checkedListBox1;
    }
}
