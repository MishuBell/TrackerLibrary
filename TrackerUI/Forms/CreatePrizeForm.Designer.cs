namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.createPrizeLabel = new System.Windows.Forms.Label();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.placeNumberValueTextbox = new System.Windows.Forms.TextBox();
            this.placeNameValueTextbox = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizeAmountValueTextbox = new System.Windows.Forms.TextBox();
            this.priceAmountLabel = new System.Windows.Forms.Label();
            this.prizePercentageValueTextbox = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPrizeLabel
            // 
            this.createPrizeLabel.AutoSize = true;
            this.createPrizeLabel.Location = new System.Drawing.Point(52, 13);
            this.createPrizeLabel.Name = "createPrizeLabel";
            this.createPrizeLabel.Size = new System.Drawing.Size(64, 13);
            this.createPrizeLabel.TabIndex = 0;
            this.createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Location = new System.Drawing.Point(45, 49);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(74, 13);
            this.placeNumberLabel.TabIndex = 1;
            this.placeNumberLabel.Text = "Place Number";
            // 
            // placeNumberValueTextbox
            // 
            this.placeNumberValueTextbox.Location = new System.Drawing.Point(131, 46);
            this.placeNumberValueTextbox.Name = "placeNumberValueTextbox";
            this.placeNumberValueTextbox.Size = new System.Drawing.Size(100, 20);
            this.placeNumberValueTextbox.TabIndex = 2;
            // 
            // placeNameValueTextbox
            // 
            this.placeNameValueTextbox.Location = new System.Drawing.Point(131, 72);
            this.placeNameValueTextbox.Name = "placeNameValueTextbox";
            this.placeNameValueTextbox.Size = new System.Drawing.Size(100, 20);
            this.placeNameValueTextbox.TabIndex = 6;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Location = new System.Drawing.Point(45, 75);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(65, 13);
            this.placeNameLabel.TabIndex = 5;
            this.placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValueTextbox
            // 
            this.prizeAmountValueTextbox.Location = new System.Drawing.Point(131, 98);
            this.prizeAmountValueTextbox.Name = "prizeAmountValueTextbox";
            this.prizeAmountValueTextbox.Size = new System.Drawing.Size(100, 20);
            this.prizeAmountValueTextbox.TabIndex = 8;
            this.prizeAmountValueTextbox.Text = "0";
            // 
            // priceAmountLabel
            // 
            this.priceAmountLabel.AutoSize = true;
            this.priceAmountLabel.Location = new System.Drawing.Point(45, 101);
            this.priceAmountLabel.Name = "priceAmountLabel";
            this.priceAmountLabel.Size = new System.Drawing.Size(70, 13);
            this.priceAmountLabel.TabIndex = 7;
            this.priceAmountLabel.Text = "Price Amount";
            // 
            // prizePercentageValueTextbox
            // 
            this.prizePercentageValueTextbox.Location = new System.Drawing.Point(131, 145);
            this.prizePercentageValueTextbox.Name = "prizePercentageValueTextbox";
            this.prizePercentageValueTextbox.Size = new System.Drawing.Size(100, 20);
            this.prizePercentageValueTextbox.TabIndex = 10;
            this.prizePercentageValueTextbox.Text = "0";
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Location = new System.Drawing.Point(45, 148);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(88, 13);
            this.prizePercentageLabel.TabIndex = 9;
            this.prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(165, 124);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(28, 13);
            this.orLabel.TabIndex = 11;
            this.orLabel.Text = "- or -";
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.Location = new System.Drawing.Point(48, 172);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(183, 23);
            this.CreatePrizeButton.TabIndex = 12;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 216);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercentageValueTextbox);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.prizeAmountValueTextbox);
            this.Controls.Add(this.priceAmountLabel);
            this.Controls.Add(this.placeNameValueTextbox);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberValueTextbox);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.createPrizeLabel);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPrizeLabel;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.TextBox placeNumberValueTextbox;
        private System.Windows.Forms.TextBox placeNameValueTextbox;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox prizeAmountValueTextbox;
        private System.Windows.Forms.Label priceAmountLabel;
        private System.Windows.Forms.TextBox prizePercentageValueTextbox;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button CreatePrizeButton;
    }
}