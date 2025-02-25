namespace C_homework1._2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox_num1 = new TextBox();
            textBox_num2 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label6 = new Label();
            operator_textBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 39);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 0;
            label1.Text = "简易计算器";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 123);
            label2.Name = "label2";
            label2.Size = new Size(154, 24);
            label2.TabIndex = 1;
            label2.Text = "请输入第一个数：";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 183);
            label3.Name = "label3";
            label3.Size = new Size(154, 24);
            label3.TabIndex = 2;
            label3.Text = "请输入第二个数：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 248);
            label4.Name = "label4";
            label4.Size = new Size(136, 24);
            label4.TabIndex = 3;
            label4.Text = "请选择运算符：";
            label4.Click += label4_Click;
            // 
            // textBox_num1
            // 
            textBox_num1.Location = new Point(278, 124);
            textBox_num1.Name = "textBox_num1";
            textBox_num1.Size = new Size(87, 30);
            textBox_num1.TabIndex = 4;
            textBox_num1.TextChanged += textBox1_TextChanged;
            // 
            // textBox_num2
            // 
            textBox_num2.Location = new Point(278, 180);
            textBox_num2.Name = "textBox_num2";
            textBox_num2.Size = new Size(87, 30);
            textBox_num2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 393);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 7;
            label5.Text = "计算结果：";
            label5.Click += label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(247, 390);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 30);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(182, 347);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "计算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(224, 243);
            button2.Name = "button2";
            button2.Size = new Size(31, 34);
            button2.TabIndex = 10;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(278, 243);
            button3.Name = "button3";
            button3.Size = new Size(29, 34);
            button3.TabIndex = 11;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(336, 243);
            button4.Name = "button4";
            button4.Size = new Size(29, 34);
            button4.TabIndex = 12;
            button4.Text = "*";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(394, 243);
            button5.Name = "button5";
            button5.Size = new Size(29, 34);
            button5.TabIndex = 13;
            button5.Text = "/";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 298);
            label6.Name = "label6";
            label6.Size = new Size(154, 24);
            label6.TabIndex = 14;
            label6.Text = "选择的运算符为：";
            // 
            // operator_textBox
            // 
            operator_textBox.Location = new Point(298, 292);
            operator_textBox.Name = "operator_textBox";
            operator_textBox.Size = new Size(38, 30);
            operator_textBox.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 499);
            Controls.Add(operator_textBox);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox_num2);
            Controls.Add(textBox_num1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_num1;
        private TextBox textBox_num2;
        private Label label5;
        private TextBox textBox4;
        private Button button1;
        private int operator1 = 0;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label6;
        private TextBox operator_textBox;
    }
}