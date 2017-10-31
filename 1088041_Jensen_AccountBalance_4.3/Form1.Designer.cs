namespace _1088041_Jensen_AccountBalance_4._3
{
    partial class FormAccountBalance
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
            this.radioButtonDeposit = new System.Windows.Forms.RadioButton();
            this.radioButtonCheck = new System.Windows.Forms.RadioButton();
            this.radioButtonServiceCharge = new System.Windows.Forms.RadioButton();
            this.textBoxTransactionAmount = new System.Windows.Forms.TextBox();
            this.labelTransactionAmount = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonDeposit
            // 
            this.radioButtonDeposit.AutoSize = true;
            this.radioButtonDeposit.Location = new System.Drawing.Point(240, 124);
            this.radioButtonDeposit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonDeposit.Name = "radioButtonDeposit";
            this.radioButtonDeposit.Size = new System.Drawing.Size(116, 29);
            this.radioButtonDeposit.TabIndex = 0;
            this.radioButtonDeposit.TabStop = true;
            this.radioButtonDeposit.Text = "Deposit";
            this.radioButtonDeposit.UseVisualStyleBackColor = true;
            // 
            // radioButtonCheck
            // 
            this.radioButtonCheck.AutoSize = true;
            this.radioButtonCheck.Location = new System.Drawing.Point(240, 168);
            this.radioButtonCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonCheck.Name = "radioButtonCheck";
            this.radioButtonCheck.Size = new System.Drawing.Size(104, 29);
            this.radioButtonCheck.TabIndex = 1;
            this.radioButtonCheck.TabStop = true;
            this.radioButtonCheck.Text = "Check";
            this.radioButtonCheck.UseVisualStyleBackColor = true;
            // 
            // radioButtonServiceCharge
            // 
            this.radioButtonServiceCharge.AutoSize = true;
            this.radioButtonServiceCharge.Location = new System.Drawing.Point(240, 213);
            this.radioButtonServiceCharge.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonServiceCharge.Name = "radioButtonServiceCharge";
            this.radioButtonServiceCharge.Size = new System.Drawing.Size(191, 29);
            this.radioButtonServiceCharge.TabIndex = 2;
            this.radioButtonServiceCharge.TabStop = true;
            this.radioButtonServiceCharge.Text = "Service Charge";
            this.radioButtonServiceCharge.UseVisualStyleBackColor = true;
            // 
            // textBoxTransactionAmount
            // 
            this.textBoxTransactionAmount.Location = new System.Drawing.Point(240, 71);
            this.textBoxTransactionAmount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxTransactionAmount.Name = "textBoxTransactionAmount";
            this.textBoxTransactionAmount.Size = new System.Drawing.Size(196, 31);
            this.textBoxTransactionAmount.TabIndex = 3;
            // 
            // labelTransactionAmount
            // 
            this.labelTransactionAmount.AutoSize = true;
            this.labelTransactionAmount.Location = new System.Drawing.Point(24, 76);
            this.labelTransactionAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTransactionAmount.Name = "labelTransactionAmount";
            this.labelTransactionAmount.Size = new System.Drawing.Size(204, 25);
            this.labelTransactionAmount.TabIndex = 4;
            this.labelTransactionAmount.Text = "Transaction Amount";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(286, 254);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(150, 62);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "C&lear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(124, 254);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(150, 62);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "&Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(517, 406);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 44);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(240, 342);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(196, 31);
            this.textBoxBalance.TabIndex = 8;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(138, 345);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(90, 25);
            this.labelBalance.TabIndex = 9;
            this.labelBalance.Text = "Balance";
            // 
            // FormAccountBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 465);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelTransactionAmount);
            this.Controls.Add(this.textBoxTransactionAmount);
            this.Controls.Add(this.radioButtonServiceCharge);
            this.Controls.Add(this.radioButtonCheck);
            this.Controls.Add(this.radioButtonDeposit);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormAccountBalance";
            this.Text = "Checking Account Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonDeposit;
        private System.Windows.Forms.RadioButton radioButtonCheck;
        private System.Windows.Forms.RadioButton radioButtonServiceCharge;
        private System.Windows.Forms.TextBox textBoxTransactionAmount;
        private System.Windows.Forms.Label labelTransactionAmount;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label labelBalance;
    }
}

