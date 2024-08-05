namespace CookBook.UI
{
    partial class IngredientsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NameTxt = new TextBox();
            TypeTxt = new TextBox();
            numericUpDown1 = new NumericUpDown();
            WeightNum = new NumericUpDown();
            KcalPer100gNum = new NumericUpDown();
            PricePer100gNum = new NumericUpDown();
            AddToFridgeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WeightNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KcalPer100gNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PricePer100gNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 37);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 38);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 117);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 38);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 193);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(145, 38);
            label3.TabIndex = 2;
            label3.Text = "Weight (g)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 272);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(200, 38);
            label4.TabIndex = 3;
            label4.Text = "Calories (100g)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 346);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(163, 38);
            label5.TabIndex = 4;
            label5.Text = "Price (100g)";
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(343, 32);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(464, 43);
            NameTxt.TabIndex = 5;
            // 
            // TypeTxt
            // 
            TypeTxt.Location = new Point(343, 112);
            TypeTxt.Name = "TypeTxt";
            TypeTxt.Size = new Size(464, 43);
            TypeTxt.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1206, 644);
            numericUpDown1.Margin = new Padding(11);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(1631, 43);
            numericUpDown1.TabIndex = 7;
            // 
            // WeightNum
            // 
            WeightNum.DecimalPlaces = 2;
            WeightNum.Location = new Point(343, 188);
            WeightNum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            WeightNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WeightNum.Name = "WeightNum";
            WeightNum.Size = new Size(464, 43);
            WeightNum.TabIndex = 8;
            WeightNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // KcalPer100gNum
            // 
            KcalPer100gNum.DecimalPlaces = 2;
            KcalPer100gNum.Location = new Point(343, 267);
            KcalPer100gNum.Maximum = new decimal(new int[] { 900, 0, 0, 0 });
            KcalPer100gNum.Name = "KcalPer100gNum";
            KcalPer100gNum.Size = new Size(464, 43);
            KcalPer100gNum.TabIndex = 9;
            KcalPer100gNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // PricePer100gNum
            // 
            PricePer100gNum.BackColor = SystemColors.Window;
            PricePer100gNum.DecimalPlaces = 2;
            PricePer100gNum.Location = new Point(343, 341);
            PricePer100gNum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            PricePer100gNum.Name = "PricePer100gNum";
            PricePer100gNum.Size = new Size(464, 43);
            PricePer100gNum.TabIndex = 10;
            // 
            // AddToFridgeBtn
            // 
            AddToFridgeBtn.Location = new Point(343, 417);
            AddToFridgeBtn.Name = "AddToFridgeBtn";
            AddToFridgeBtn.Size = new Size(464, 46);
            AddToFridgeBtn.TabIndex = 11;
            AddToFridgeBtn.Text = "Add to fridge";
            AddToFridgeBtn.UseVisualStyleBackColor = true;
            AddToFridgeBtn.Click += AddToFridgeBtn_Click;
            // 
            // IngredientsForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 495);
            Controls.Add(AddToFridgeBtn);
            Controls.Add(PricePer100gNum);
            Controls.Add(KcalPer100gNum);
            Controls.Add(WeightNum);
            Controls.Add(numericUpDown1);
            Controls.Add(TypeTxt);
            Controls.Add(NameTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(6);
            Name = "IngredientsForm";
            Text = "My fridge";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)WeightNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)KcalPer100gNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)PricePer100gNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NameTxt;
        private TextBox TypeTxt;
        private NumericUpDown numericUpDown1;
        private NumericUpDown WeightNum;
        private NumericUpDown KcalPer100gNum;
        private NumericUpDown PricePer100gNum;
        private Button AddToFridgeBtn;
    }
}