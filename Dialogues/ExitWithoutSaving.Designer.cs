namespace Locnes.Dialogues
{
    partial class ExitWithoutSaving
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
            comp_label = new Label();
            comp_items = new ListBox();
            comp_cancel = new Button();
            comp_dontsave = new Button();
            comp_save = new Button();
            SuspendLayout();
            // 
            // comp_label
            // 
            comp_label.AutoSize = true;
            comp_label.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comp_label.ForeColor = Color.White;
            comp_label.Location = new Point(6, 6);
            comp_label.Name = "comp_label";
            comp_label.Size = new Size(287, 17);
            comp_label.TabIndex = 0;
            comp_label.Text = "Save changes to following files before exiting?";
            // 
            // comp_items
            // 
            comp_items.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comp_items.BackColor = Color.FromArgb(42, 42, 42);
            comp_items.BorderStyle = BorderStyle.None;
            comp_items.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comp_items.ForeColor = SystemColors.ActiveBorder;
            comp_items.FormattingEnabled = true;
            comp_items.ItemHeight = 15;
            comp_items.Location = new Point(7, 32);
            comp_items.Name = "comp_items";
            comp_items.Size = new Size(286, 120);
            comp_items.TabIndex = 1;
            // 
            // comp_cancel
            // 
            comp_cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comp_cancel.AutoSize = true;
            comp_cancel.BackColor = Color.FromArgb(32, 32, 32);
            comp_cancel.FlatAppearance.BorderSize = 0;
            comp_cancel.FlatStyle = FlatStyle.Flat;
            comp_cancel.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comp_cancel.Location = new Point(235, 158);
            comp_cancel.Name = "comp_cancel";
            comp_cancel.Size = new Size(58, 28);
            comp_cancel.TabIndex = 2;
            comp_cancel.Text = "Cancel";
            comp_cancel.UseVisualStyleBackColor = false;
            comp_cancel.Click += comp_cancel_Click;
            // 
            // comp_dontsave
            // 
            comp_dontsave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comp_dontsave.AutoSize = true;
            comp_dontsave.BackColor = Color.FromArgb(32, 32, 32);
            comp_dontsave.FlatAppearance.BorderSize = 0;
            comp_dontsave.FlatStyle = FlatStyle.Flat;
            comp_dontsave.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comp_dontsave.Location = new Point(151, 158);
            comp_dontsave.Name = "comp_dontsave";
            comp_dontsave.Size = new Size(78, 28);
            comp_dontsave.TabIndex = 3;
            comp_dontsave.Text = "Don't Save";
            comp_dontsave.UseVisualStyleBackColor = false;
            comp_dontsave.Click += comp_dontsave_Click;
            // 
            // comp_save
            // 
            comp_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comp_save.AutoSize = true;
            comp_save.BackColor = Color.FromArgb(32, 32, 32);
            comp_save.FlatAppearance.BorderSize = 0;
            comp_save.FlatStyle = FlatStyle.Flat;
            comp_save.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comp_save.Location = new Point(98, 158);
            comp_save.Name = "comp_save";
            comp_save.Size = new Size(47, 28);
            comp_save.TabIndex = 4;
            comp_save.Text = "Save";
            comp_save.UseVisualStyleBackColor = false;
            // 
            // ExitWithoutSaving
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 37);
            ClientSize = new Size(301, 192);
            Controls.Add(comp_save);
            Controls.Add(comp_dontsave);
            Controls.Add(comp_cancel);
            Controls.Add(comp_items);
            Controls.Add(comp_label);
            ForeColor = SystemColors.ActiveBorder;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ExitWithoutSaving";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Locnes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label comp_label;
        private ListBox comp_items;
        private Button comp_cancel;
        private Button comp_dontsave;
        private Button comp_save;
    }
}