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
            this.placeAmountValueTextbox = new System.Windows.Forms.TextBox();
            this.priceAmountLabel = new System.Windows.Forms.Label();
            this.prizePercentageValueTextbox = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPrizeLabel
            // 
            this.createPrizeLabel.AutoSize = true;
            this.createPrizeLabel.Location = new System.Drawing.Point(13, 13);
            this.createPrizeLabel.Name = "createPrizeLabel";
            this.createPrizeLabel.Size = new System.Drawing.Size(64, 13);
            this.createPrizeLabel.TabIndex = 0;
            this.createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Location = new System.Drawing.Point(12, 49);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(74, 13);
            this.placeNumberLabel.TabIndex = 1;
            this.placeNumberLabel.Text = "Place Number";
            // 
            // placeNumberValueTextbox
            // 
            this.placeNumberValueTextbox.Location = new System.Drawing.Point(92, 46);
            this.placeNumberValueTextbox.Name = "placeNumberValueTextbox";
            this.placeNumberValueTextbox.Size = new System.Drawing.Size(100, 20);
            this.placeNumberValueTextbox.TabIndex = 2;
            // 
            // placeNameValueTextbox
            // 
            this.placeNameValueTextbox.Location = new System.Drawing.Point(92, 72);
            this.placeNameValueTextbox.Name = "placeNameValueTextbox";
            this.placeNameValueTextbox.Size = new System.Drawing.Size(100, 20);
            this.placeNameValueTextbox.TabIndex = 6;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Location = new System.Drawing.Point(12, 75);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(65, 13);
            this.placeNameLabel.TabIndex = 5;
            this.placeNameLabel.Text = "Place Name";
            // 
            // placeAmountValueTextbox
            // 
            this.placeAmountValueTextbox.Location = new System.Drawing.Point(92, 98);
            this.placeAmountValueTextbox.Name = "placeAmountValueTextbox";
            this.placeAmountValueTextbox.Size = new System.Drawing.Size(100, 20);
            this.placeAmountValueTextbox.TabIndex = 8;
            // 
            // priceAmountLabel
            // 
            this.priceAmountLabel.AutoSize = true;
            this.priceAmountLabel.Location = new System.Drawing.Point(12, 101);
            this.priceAmountLabel.Name = "priceAmountLabel";
            this.priceAmountLabel.Size = new System.Drawing.Size(70, 13);
            this.priceAmountLabel.TabIndex = 7;
            this.priceAmountLabel.Text = "Price Amount";
            // 
            // prizePercentageValueTextbox
            // 
            this.prizePercentageValueTextbox.Location = new System.Drawing.Point(92, 145);
            this.prizePercentageValueTextbox.Name = "prizePercentageValueTextbox";
            this.prizePercentageValueTextbox.Size = new System.Drawing.Size(100, 20);
            this.prizePercentageValueTextbox.TabIndex = 10;
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Location = new System.Drawing.Point(12, 148);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(74, 13);
            this.prizePercentageLabel.TabIndex = 9;
            this.prizePercentageLabel.Text = "Place Number";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(126, 124);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(28, 13);
            this.orLabel.TabIndex = 11;
            this.orLabel.Text = "- or -";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Location = new System.Drawing.Point(16, 172);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(176, 23);
            this.createPrizeButton.TabIndex = 12;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 216);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercentageValueTextbox);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.placeAmountValueTextbox);
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
        private System.Windows.Forms.TextBox placeAmountValueTextbox;
        private System.Windows.Forms.Label priceAmountLabel;
        private System.Windows.Forms.TextBox prizePercentageValueTextbox;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button createPrizeButton;
    }
}