namespace CookBook
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
            FirstNameTxt = new TextBox();
            LastNameTxt = new TextBox();
            GreetUserBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(90, 51);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 38);
            label1.TabIndex = 0;
            label1.Text = "First name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 133);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 38);
            label2.TabIndex = 1;
            label2.Text = "Last name:";
            label2.Click += label2_Click;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Location = new Point(251, 51);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(357, 43);
            FirstNameTxt.TabIndex = 2;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Location = new Point(251, 133);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(357, 43);
            LastNameTxt.TabIndex = 3;
            // 
            // GreetUserBtn
            // 
            GreetUserBtn.Location = new Point(251, 216);
            GreetUserBtn.Name = "GreetUserBtn";
            GreetUserBtn.Size = new Size(357, 48);
            GreetUserBtn.TabIndex = 4;
            GreetUserBtn.Text = "Greet user";
            GreetUserBtn.UseVisualStyleBackColor = true;
            GreetUserBtn.Click += GreetUserBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(848, 429);
            Controls.Add(GreetUserBtn);
            Controls.Add(LastNameTxt);
            Controls.Add(FirstNameTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox FirstNameTxt;
        private TextBox LastNameTxt;
        private Button GreetUserBtn;
    }
}
