namespace ExamTemplate
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Question = new System.Windows.Forms.Label();
            this.Answer1 = new System.Windows.Forms.RadioButton();
            this.Answer2 = new System.Windows.Forms.RadioButton();
            this.Answer3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Answer4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 430);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1196, 34);
            this.progressBar1.TabIndex = 0;
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Question.Location = new System.Drawing.Point(12, 10);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(102, 54);
            this.Question.TabIndex = 1;
            this.Question.Text = "start";
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Answer1.Location = new System.Drawing.Point(12, 80);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(101, 45);
            this.Answer1.TabIndex = 2;
            this.Answer1.TabStop = true;
            this.Answer1.Text = "start";
            this.Answer1.UseVisualStyleBackColor = true;
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Answer2.Location = new System.Drawing.Point(12, 150);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(101, 45);
            this.Answer2.TabIndex = 3;
            this.Answer2.TabStop = true;
            this.Answer2.Text = "start";
            this.Answer2.UseVisualStyleBackColor = true;
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Answer3.Location = new System.Drawing.Point(12, 220);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(101, 45);
            this.Answer3.TabIndex = 4;
            this.Answer3.TabStop = true;
            this.Answer3.Text = "start";
            this.Answer3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(10, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1196, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Answer4.Location = new System.Drawing.Point(10, 290);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(101, 45);
            this.Answer4.TabIndex = 6;
            this.Answer4.TabStop = true;
            this.Answer4.Text = "start";
            this.Answer4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1218, 476);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "You better not fail this";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar progressBar1;
        private Label Question;
        private RadioButton Answer1;
        private RadioButton Answer2;
        private RadioButton Answer3;
        private Button button1;
        private RadioButton Answer4;
    }
}