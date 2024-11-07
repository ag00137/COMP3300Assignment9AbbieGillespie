namespace COMP3300Assignment9AbbieGillespie
{
    partial class MainForm
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
            ChooseFileBtn = new Button();
            AccountsDisplayTxtBox = new ListBox();
            SuspendLayout();
            // 
            // ChooseFileBtn
            // 
            ChooseFileBtn.Location = new Point(12, 12);
            ChooseFileBtn.Name = "ChooseFileBtn";
            ChooseFileBtn.Size = new Size(112, 34);
            ChooseFileBtn.TabIndex = 0;
            ChooseFileBtn.Text = "Choose FIle";
            ChooseFileBtn.UseVisualStyleBackColor = true;
            ChooseFileBtn.Click += ChooseFileBtn_Click;
            // 
            // AccountsDisplayTxtBox
            // 
            AccountsDisplayTxtBox.FormattingEnabled = true;
            AccountsDisplayTxtBox.ItemHeight = 25;
            AccountsDisplayTxtBox.Location = new Point(12, 62);
            AccountsDisplayTxtBox.Name = "AccountsDisplayTxtBox";
            AccountsDisplayTxtBox.Size = new Size(776, 204);
            AccountsDisplayTxtBox.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AccountsDisplayTxtBox);
            Controls.Add(ChooseFileBtn);
            Name = "MainForm";
            Text = "Assignment 9 by Gillespie";
            ResumeLayout(false);
        }

        #endregion

        private Button ChooseFileBtn;
        private ListBox AccountsDisplayTxtBox;
    }
}
