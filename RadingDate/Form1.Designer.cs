﻿namespace RadingDate
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
            DayOfWeekComboBox = new ComboBox();
            DayOfMonthComboBox = new ComboBox();
            MonthComboBox = new ComboBox();
            YearComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // DayOfWeekComboBox
            // 
            DayOfWeekComboBox.FormattingEnabled = true;
            DayOfWeekComboBox.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            DayOfWeekComboBox.Location = new Point(608, 71);
            DayOfWeekComboBox.Name = "DayOfWeekComboBox";
            DayOfWeekComboBox.Size = new Size(121, 23);
            DayOfWeekComboBox.TabIndex = 0;
            // 
            // DayOfMonthComboBox
            // 
            DayOfMonthComboBox.FormattingEnabled = true;
            DayOfMonthComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            DayOfMonthComboBox.Location = new Point(448, 71);
            DayOfMonthComboBox.Name = "DayOfMonthComboBox";
            DayOfMonthComboBox.Size = new Size(121, 23);
            DayOfMonthComboBox.TabIndex = 1;
            // 
            // MonthComboBox
            // 
            MonthComboBox.FormattingEnabled = true;
            MonthComboBox.Items.AddRange(new object[] { "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            MonthComboBox.Location = new Point(288, 71);
            MonthComboBox.Name = "MonthComboBox";
            MonthComboBox.Size = new Size(121, 23);
            MonthComboBox.TabIndex = 2;
            // 
            // YearComboBox
            // 
            YearComboBox.FormattingEnabled = true;
            YearComboBox.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" });
            YearComboBox.Location = new Point(113, 71);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(121, 23);
            YearComboBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 47);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 4;
            label1.Text = "שנה";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 47);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 5;
            label2.Text = "חודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(632, 47);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 7;
            label4.Text = "היום בשבוע";
            // 
            // button1
            // 
            button1.Location = new Point(192, 189);
            button1.Name = "button1";
            button1.Size = new Size(146, 23);
            button1.TabIndex = 8;
            button1.Text = "הכנס תאריך";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 47);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 9;
            label3.Text = "היום בחודש";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(YearComboBox);
            Controls.Add(MonthComboBox);
            Controls.Add(DayOfMonthComboBox);
            Controls.Add(DayOfWeekComboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DayOfWeekComboBox;
        private ComboBox DayOfMonthComboBox;
        private ComboBox MonthComboBox;
        private ComboBox YearComboBox;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button button1;
        private Label label3;
    }
}