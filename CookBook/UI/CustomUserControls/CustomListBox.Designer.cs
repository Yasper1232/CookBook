﻿namespace CookBook.UI.CustomUserControls
{
    partial class CustomListBox
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            CustomLbx = new ListBox();
            SuspendLayout();
            // 
            // CustomLbx
            // 
            CustomLbx.FormattingEnabled = true;
            CustomLbx.Location = new Point(3, 7);
            CustomLbx.Name = "CustomLbx";
            CustomLbx.Size = new Size(319, 364);
            CustomLbx.TabIndex = 0;
            // 
            // CustomListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomLbx);
            Name = "CustomListBox";
            Size = new Size(325, 377);
            ResumeLayout(false);
        }

        #endregion

        private ListBox CustomLbx;
    }
}
