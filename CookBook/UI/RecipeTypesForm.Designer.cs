namespace CookBook.UI
{
    partial class RecipeTypesForm
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
            NewTypeTxt = new TextBox();
            RecipeTypesLbx = new ListBox();
            AddRecipeTypeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 40);
            label1.Name = "label1";
            label1.Size = new Size(81, 38);
            label1.TabIndex = 0;
            label1.Text = "Type:";
            // 
            // NewTypeTxt
            // 
            NewTypeTxt.Location = new Point(159, 40);
            NewTypeTxt.Name = "NewTypeTxt";
            NewTypeTxt.Size = new Size(278, 43);
            NewTypeTxt.TabIndex = 1;
            // 
            // RecipeTypesLbx
            // 
            RecipeTypesLbx.FormattingEnabled = true;
            RecipeTypesLbx.ItemHeight = 37;
            RecipeTypesLbx.Location = new Point(51, 123);
            RecipeTypesLbx.Name = "RecipeTypesLbx";
            RecipeTypesLbx.Size = new Size(386, 300);
            RecipeTypesLbx.TabIndex = 2;
            // 
            // AddRecipeTypeBtn
            // 
            AddRecipeTypeBtn.Location = new Point(62, 472);
            AddRecipeTypeBtn.Name = "AddRecipeTypeBtn";
            AddRecipeTypeBtn.Size = new Size(375, 43);
            AddRecipeTypeBtn.TabIndex = 3;
            AddRecipeTypeBtn.Text = "Add";
            AddRecipeTypeBtn.UseVisualStyleBackColor = true;
            AddRecipeTypeBtn.Click += AddRecipeTypeBtn_Click;
            // 
            // RecipeTypesForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 568);
            Controls.Add(AddRecipeTypeBtn);
            Controls.Add(RecipeTypesLbx);
            Controls.Add(NewTypeTxt);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(6);
            Name = "RecipeTypesForm";
            Text = "RecipeTypesForm";
            Load += RecipeTypesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NewTypeTxt;
        private ListBox RecipeTypesLbx;
        private Button AddRecipeTypeBtn;
    }
}