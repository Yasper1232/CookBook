﻿namespace CookBook.UI
{
    partial class FoodManagerForm
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
            components = new System.ComponentModel.Container();
            LeftPanel = new Panel();
            RecipesLbx = new CustomUserControls.CustomListBox();
            PrepareFoodBtn = new Button();
            CreateShopingListBtn = new Button();
            UnvailableBtn = new Button();
            AvailableBtn = new Button();
            RightPanel = new Panel();
            NotificationIcon = new PictureBox();
            IngredientsLbx = new CustomUserControls.CustomListBox();
            DescriptionTxt = new RichTextBox();
            RecipePicture = new PictureBox();
            TotalPriceLbl = new Label();
            TotalKcalLbl = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            notificationTooltip = new ToolTip(components);
            LeftPanel.SuspendLayout();
            RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NotificationIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipePicture).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.CornflowerBlue;
            LeftPanel.Controls.Add(RecipesLbx);
            LeftPanel.Controls.Add(PrepareFoodBtn);
            LeftPanel.Controls.Add(CreateShopingListBtn);
            LeftPanel.Controls.Add(UnvailableBtn);
            LeftPanel.Controls.Add(AvailableBtn);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(399, 682);
            LeftPanel.TabIndex = 0;
            // 
            // RecipesLbx
            // 
            RecipesLbx.Location = new Point(12, 81);
            RecipesLbx.Name = "RecipesLbx";
            RecipesLbx.SelectedItem = null;
            RecipesLbx.Size = new Size(381, 402);
            RecipesLbx.TabIndex = 4;
            RecipesLbx.Load += RecipesLbx_Load;
            // 
            // PrepareFoodBtn
            // 
            PrepareFoodBtn.Location = new Point(12, 501);
            PrepareFoodBtn.Name = "PrepareFoodBtn";
            PrepareFoodBtn.Size = new Size(381, 56);
            PrepareFoodBtn.TabIndex = 3;
            PrepareFoodBtn.Text = "Prepare food";
            PrepareFoodBtn.UseVisualStyleBackColor = true;
            PrepareFoodBtn.Click += PrepareFoodBtn_Click;
            // 
            // CreateShopingListBtn
            // 
            CreateShopingListBtn.Location = new Point(12, 501);
            CreateShopingListBtn.Name = "CreateShopingListBtn";
            CreateShopingListBtn.Size = new Size(381, 56);
            CreateShopingListBtn.TabIndex = 2;
            CreateShopingListBtn.Text = "Create shopping list";
            CreateShopingListBtn.UseVisualStyleBackColor = true;
            CreateShopingListBtn.Click += CreateShopingListBtn_Click;
            // 
            // UnvailableBtn
            // 
            UnvailableBtn.BackColor = Color.FromArgb(255, 128, 128);
            UnvailableBtn.Location = new Point(211, 12);
            UnvailableBtn.Name = "UnvailableBtn";
            UnvailableBtn.Size = new Size(182, 63);
            UnvailableBtn.TabIndex = 1;
            UnvailableBtn.Text = "Unvailable";
            UnvailableBtn.UseVisualStyleBackColor = false;
            UnvailableBtn.Click += UnvailableBtn_Click;
            // 
            // AvailableBtn
            // 
            AvailableBtn.BackColor = Color.LimeGreen;
            AvailableBtn.Location = new Point(12, 12);
            AvailableBtn.Name = "AvailableBtn";
            AvailableBtn.Size = new Size(193, 63);
            AvailableBtn.TabIndex = 0;
            AvailableBtn.Text = "Available";
            AvailableBtn.UseVisualStyleBackColor = false;
            AvailableBtn.Click += AvailableBtn_Click;
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.RoyalBlue;
            RightPanel.Controls.Add(NotificationIcon);
            RightPanel.Controls.Add(IngredientsLbx);
            RightPanel.Controls.Add(DescriptionTxt);
            RightPanel.Controls.Add(RecipePicture);
            RightPanel.Controls.Add(TotalPriceLbl);
            RightPanel.Controls.Add(TotalKcalLbl);
            RightPanel.Controls.Add(label3);
            RightPanel.Controls.Add(label2);
            RightPanel.Controls.Add(label1);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(399, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(966, 682);
            RightPanel.TabIndex = 1;
            // 
            // NotificationIcon
            // 
            NotificationIcon.Image = Properties.Resources.notification;
            NotificationIcon.Location = new Point(345, 18);
            NotificationIcon.Name = "NotificationIcon";
            NotificationIcon.Size = new Size(92, 91);
            NotificationIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            NotificationIcon.TabIndex = 8;
            NotificationIcon.TabStop = false;
            NotificationIcon.MouseEnter += NotificationIcon_MouseEnter;
            NotificationIcon.MouseLeave += NotificationIcon_MouseLeave;
            // 
            // IngredientsLbx
            // 
            IngredientsLbx.Location = new Point(26, 118);
            IngredientsLbx.Name = "IngredientsLbx";
            IngredientsLbx.SelectedItem = null;
            IngredientsLbx.Size = new Size(411, 253);
            IngredientsLbx.TabIndex = 7;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.Location = new Point(26, 391);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(411, 279);
            DescriptionTxt.TabIndex = 6;
            DescriptionTxt.Text = "";
            // 
            // RecipePicture
            // 
            RecipePicture.Location = new Point(556, 391);
            RecipePicture.Name = "RecipePicture";
            RecipePicture.Size = new Size(356, 279);
            RecipePicture.TabIndex = 5;
            RecipePicture.TabStop = false;
            // 
            // TotalPriceLbl
            // 
            TotalPriceLbl.AutoSize = true;
            TotalPriceLbl.Location = new Point(890, 81);
            TotalPriceLbl.Name = "TotalPriceLbl";
            TotalPriceLbl.Size = new Size(26, 28);
            TotalPriceLbl.TabIndex = 4;
            TotalPriceLbl.Text = "/";
            // 
            // TotalKcalLbl
            // 
            TotalKcalLbl.AutoSize = true;
            TotalKcalLbl.Location = new Point(890, 18);
            TotalKcalLbl.Name = "TotalKcalLbl";
            TotalKcalLbl.Size = new Size(26, 28);
            TotalKcalLbl.TabIndex = 3;
            TotalKcalLbl.Text = "/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(639, 81);
            label3.Name = "label3";
            label3.Size = new Size(166, 28);
            label3.TabIndex = 2;
            label3.Text = "TotalPrice:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(639, 18);
            label2.Name = "label2";
            label2.Size = new Size(222, 28);
            label2.TabIndex = 1;
            label2.Text = "Total calories:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 12);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 0;
            label1.Text = "Ingredients";
            // 
            // FoodManagerForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 682);
            Controls.Add(RightPanel);
            Controls.Add(LeftPanel);
            Font = new Font("SimSun", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FoodManagerForm";
            Text = "FoodManagerForm";
            Load += FoodManagerForm_Load;
            LeftPanel.ResumeLayout(false);
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NotificationIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipePicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftPanel;
        private Panel RightPanel;
        private Button PrepareFoodBtn;
        private Button CreateShopingListBtn;
        private Button UnvailableBtn;
        private Button AvailableBtn;
        private CustomUserControls.CustomListBox RecipesLbx;
        private RichTextBox DescriptionTxt;
        private PictureBox RecipePicture;
        private Label TotalPriceLbl;
        private Label TotalKcalLbl;
        private Label label3;
        private Label label2;
        private Label label1;
        private CustomUserControls.CustomListBox IngredientsLbx;
        private PictureBox NotificationIcon;
        private ToolTip notificationTooltip;
    }
}