namespace CookBook.UI
{
    partial class RecipesForm
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
            RecipesFilterCbx = new ComboBox();
            RecipeTypesCbx = new ComboBox();
            DescriptionTxt = new RichTextBox();
            AddRecipeTypeBtn = new Button();
            RecipesGrid = new DataGridView();
            NameTxt = new TextBox();
            ClearAllFieldsBtn = new Button();
            AddRecipeBtn = new Button();
            RecipePictureBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            EditRecipeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).BeginInit();
            SuspendLayout();
            // 
            // RecipesFilterCbx
            // 
            RecipesFilterCbx.FormattingEnabled = true;
            RecipesFilterCbx.Location = new Point(10, 30);
            RecipesFilterCbx.Name = "RecipesFilterCbx";
            RecipesFilterCbx.Size = new Size(886, 39);
            RecipesFilterCbx.TabIndex = 0;
            RecipesFilterCbx.SelectedIndexChanged += RecipesFilterCbx_SelectedIndexChanged;
            // 
            // RecipeTypesCbx
            // 
            RecipeTypesCbx.FormattingEnabled = true;
            RecipeTypesCbx.Location = new Point(1064, 111);
            RecipeTypesCbx.Name = "RecipeTypesCbx";
            RecipeTypesCbx.Size = new Size(212, 39);
            RecipeTypesCbx.TabIndex = 1;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.Location = new Point(1064, 191);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(352, 101);
            DescriptionTxt.TabIndex = 2;
            DescriptionTxt.Text = "";
            // 
            // AddRecipeTypeBtn
            // 
            AddRecipeTypeBtn.Location = new Point(1298, 111);
            AddRecipeTypeBtn.Name = "AddRecipeTypeBtn";
            AddRecipeTypeBtn.Size = new Size(117, 38);
            AddRecipeTypeBtn.TabIndex = 3;
            AddRecipeTypeBtn.Text = "Add";
            AddRecipeTypeBtn.UseVisualStyleBackColor = true;
            AddRecipeTypeBtn.Click += AddRecipeTypeBtn_Click;
            // 
            // RecipesGrid
            // 
            RecipesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RecipesGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            RecipesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RecipesGrid.Location = new Point(10, 115);
            RecipesGrid.Name = "RecipesGrid";
            RecipesGrid.RowHeadersWidth = 51;
            RecipesGrid.Size = new Size(886, 509);
            RecipesGrid.TabIndex = 4;
            RecipesGrid.CellClick += RecipesGrid_CellClick;
            RecipesGrid.CellContentClick += RecipesGrid_CellContentClick;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(1064, 34);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(352, 38);
            NameTxt.TabIndex = 5;
            // 
            // ClearAllFieldsBtn
            // 
            ClearAllFieldsBtn.Location = new Point(992, 575);
            ClearAllFieldsBtn.Name = "ClearAllFieldsBtn";
            ClearAllFieldsBtn.Size = new Size(423, 38);
            ClearAllFieldsBtn.TabIndex = 6;
            ClearAllFieldsBtn.Text = "Clear All Fields";
            ClearAllFieldsBtn.UseVisualStyleBackColor = true;
            ClearAllFieldsBtn.Click += ClearAllFieldsBtn_Click;
            // 
            // AddRecipeBtn
            // 
            AddRecipeBtn.Location = new Point(992, 500);
            AddRecipeBtn.Name = "AddRecipeBtn";
            AddRecipeBtn.Size = new Size(423, 36);
            AddRecipeBtn.TabIndex = 8;
            AddRecipeBtn.Text = "Add Recipe";
            AddRecipeBtn.UseVisualStyleBackColor = true;
            AddRecipeBtn.Click += AddRecipeBtn_Click;
            // 
            // RecipePictureBox
            // 
            RecipePictureBox.Location = new Point(1064, 309);
            RecipePictureBox.Name = "RecipePictureBox";
            RecipePictureBox.Size = new Size(351, 163);
            RecipePictureBox.TabIndex = 9;
            RecipePictureBox.TabStop = false;
            RecipePictureBox.Click += RecipePictureBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(969, 38);
            label1.Name = "label1";
            label1.Size = new Size(80, 31);
            label1.TabIndex = 10;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(969, 117);
            label2.Name = "label2";
            label2.Size = new Size(67, 31);
            label2.TabIndex = 11;
            label2.Text = "Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(916, 213);
            label3.Name = "label3";
            label3.Size = new Size(136, 31);
            label3.TabIndex = 12;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(969, 379);
            label4.Name = "label4";
            label4.Size = new Size(83, 31);
            label4.TabIndex = 13;
            label4.Text = "Image:";
            // 
            // EditRecipeButton
            // 
            EditRecipeButton.Location = new Point(993, 500);
            EditRecipeButton.Name = "EditRecipeButton";
            EditRecipeButton.Size = new Size(423, 36);
            EditRecipeButton.TabIndex = 14;
            EditRecipeButton.Text = "Edit";
            EditRecipeButton.UseVisualStyleBackColor = true;
            EditRecipeButton.Click += EditRecipeButton_Click;
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 719);
            Controls.Add(EditRecipeButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RecipePictureBox);
            Controls.Add(AddRecipeBtn);
            Controls.Add(ClearAllFieldsBtn);
            Controls.Add(NameTxt);
            Controls.Add(RecipesGrid);
            Controls.Add(AddRecipeTypeBtn);
            Controls.Add(DescriptionTxt);
            Controls.Add(RecipeTypesCbx);
            Controls.Add(RecipesFilterCbx);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(5);
            Name = "RecipesForm";
            Text = "RecipesForm";
            Load += RecipesForm_Load;
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox RecipesFilterCbx;
        private ComboBox RecipeTypesCbx;
        private RichTextBox DescriptionTxt;
        private Button AddRecipeTypeBtn;
        private DataGridView RecipesGrid;
        private TextBox NameTxt;
        private Button ClearAllFieldsBtn;
        private Button AddRecipeBtn;
        private PictureBox RecipePictureBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button EditRecipeButton;
    }
}