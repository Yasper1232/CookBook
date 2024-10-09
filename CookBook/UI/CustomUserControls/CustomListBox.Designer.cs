namespace CookBook.UI.CustomUserControls
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
            CustomLbx.Dock = DockStyle.Fill;
            CustomLbx.FormattingEnabled = true;
            CustomLbx.Location = new Point(0, 0);
            CustomLbx.Name = "CustomLbx";
            CustomLbx.Size = new Size(603, 466);
            CustomLbx.TabIndex = 0;
            CustomLbx.DrawItem += CustomLbx_DrawItem;
            CustomLbx.MeasureItem += CustomLbx_MeasureItem;
            CustomLbx.SelectedIndexChanged += CustomLbx_SelectedIndexChanged;
            // 
            // CustomListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomLbx);
            Name = "CustomListBox";
            Size = new Size(603, 466);
            ResumeLayout(false);
        }

        #endregion

        private ListBox CustomLbx;
    }
}
