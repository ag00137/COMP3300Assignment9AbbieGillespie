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
            CheckingAccountBtn = new Button();
            SavingsAccountBtn = new Button();
            BusinessAcountsBtn = new Button();
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
            AccountsDisplayTxtBox.Size = new Size(993, 229);
            AccountsDisplayTxtBox.TabIndex = 1;
            // 
            // CheckingAccountBtn
            // 
            CheckingAccountBtn.Location = new Point(166, 309);
            CheckingAccountBtn.Name = "CheckingAccountBtn";
            CheckingAccountBtn.Size = new Size(183, 35);
            CheckingAccountBtn.TabIndex = 2;
            CheckingAccountBtn.Text = "Checking Accounts";
            CheckingAccountBtn.UseVisualStyleBackColor = true;
            CheckingAccountBtn.Click += CheckingAccountBtn_Click;
            // 
            // SavingsAccountBtn
            // 
            SavingsAccountBtn.Location = new Point(417, 310);
            SavingsAccountBtn.Name = "SavingsAccountBtn";
            SavingsAccountBtn.Size = new Size(183, 34);
            SavingsAccountBtn.TabIndex = 3;
            SavingsAccountBtn.Text = "Savings Accounts";
            SavingsAccountBtn.UseVisualStyleBackColor = true;
            SavingsAccountBtn.Click += SavingsAccountBtn_Click;
            // 
            // BusinessAcountsBtn
            // 
            BusinessAcountsBtn.Location = new Point(670, 310);
            BusinessAcountsBtn.Name = "BusinessAcountsBtn";
            BusinessAcountsBtn.Size = new Size(183, 34);
            BusinessAcountsBtn.TabIndex = 4;
            BusinessAcountsBtn.Text = "Business Accounts";
            BusinessAcountsBtn.UseVisualStyleBackColor = true;
            BusinessAcountsBtn.Click += BusinessAcountsBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 360);
            Controls.Add(BusinessAcountsBtn);
            Controls.Add(SavingsAccountBtn);
            Controls.Add(CheckingAccountBtn);
            Controls.Add(AccountsDisplayTxtBox);
            Controls.Add(ChooseFileBtn);
            Name = "MainForm";
            Text = "Assignment 9 by Gillespie";
            ResumeLayout(false);
        }

        #endregion

        private Button ChooseFileBtn;
        private ListBox AccountsDisplayTxtBox;
        private Button CheckingAccountBtn;
        private Button SavingsAccountBtn;
        private Button BusinessAcountsBtn;
    }
}
