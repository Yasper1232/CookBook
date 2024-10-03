namespace CookBook.UI
{
    partial class RecipeIngredientsForm
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
            AllIngredientsLbx = new ListBox();
            RecipeIngredientslbx = new ListBox();
            AddIngredientBtn = new Button();
            RemoveIngredientbtn = new Button();
            AllIngredientsCustomLbx = new CustomUserControls.CustomListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 38);
            label1.Name = "label1";
            label1.Size = new Size(196, 38);
            label1.TabIndex = 0;
            label1.Text = "All ingredients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(495, 38);
            label2.Name = "label2";
            label2.Size = new Size(246, 38);
            label2.TabIndex = 1;
            label2.Text = "Recipe ingredients";
            // 
            // AllIngredientsLbx
            // 
            AllIngredientsLbx.FormattingEnabled = true;
            AllIngredientsLbx.ItemHeight = 37;
            AllIngredientsLbx.Location = new Point(49, 97);
            AllIngredientsLbx.Name = "AllIngredientsLbx";
            AllIngredientsLbx.Size = new Size(331, 374);
            AllIngredientsLbx.TabIndex = 2;
            // 
            // RecipeIngredientslbx
            // 
            RecipeIngredientslbx.FormattingEnabled = true;
            RecipeIngredientslbx.ItemHeight = 37;
            RecipeIngredientslbx.Location = new Point(450, 97);
            RecipeIngredientslbx.Name = "RecipeIngredientslbx";
            RecipeIngredientslbx.Size = new Size(338, 374);
            RecipeIngredientslbx.TabIndex = 3;
            // 
            // AddIngredientBtn
            // 
            AddIngredientBtn.Location = new Point(77, 497);
            AddIngredientBtn.Name = "AddIngredientBtn";
            AddIngredientBtn.Size = new Size(249, 47);
            AddIngredientBtn.TabIndex = 4;
            AddIngredientBtn.Text = "Add ingredient";
            AddIngredientBtn.UseVisualStyleBackColor = true;
            AddIngredientBtn.Click += AddIngredientBtn_Click;
            // 
            // RemoveIngredientbtn
            // 
            RemoveIngredientbtn.Location = new Point(467, 497);
            RemoveIngredientbtn.Name = "RemoveIngredientbtn";
            RemoveIngredientbtn.Size = new Size(302, 47);
            RemoveIngredientbtn.TabIndex = 5;
            RemoveIngredientbtn.Text = "Remove ingredient";
            RemoveIngredientbtn.UseVisualStyleBackColor = true;
            RemoveIngredientbtn.Click += RemoveIngredientbtn_Click;
            // 
            // AllIngredientsCustomLbx
            // 
            AllIngredientsCustomLbx.Location = new Point(49, 608);
            AllIngredientsCustomLbx.Name = "AllIngredientsCustomLbx";
            AllIngredientsCustomLbx.Size = new Size(325, 353);
            AllIngredientsCustomLbx.TabIndex = 6;
            // 
            // RecipeIngredientsForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 1055);
            Controls.Add(AllIngredientsCustomLbx);
            Controls.Add(RemoveIngredientbtn);
            Controls.Add(AddIngredientBtn);
            Controls.Add(RecipeIngredientslbx);
            Controls.Add(AllIngredientsLbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(6);
            Name = "RecipeIngredientsForm";
            Text = "RecipeIngredientsForm";
            Load += RecipeIngredientsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox AllIngredientsLbx;
        private ListBox RecipeIngredientslbx;
        private Button AddIngredientBtn;
        private Button RemoveIngredientbtn;
        private CustomUserControls.CustomListBox AllIngredientsCustomLbx;
    }
}