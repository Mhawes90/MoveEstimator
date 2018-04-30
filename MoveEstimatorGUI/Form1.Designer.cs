namespace MoveEstimatorGUI
{
    partial class estimatorWindow
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.hoursMessage = new System.Windows.Forms.Label();
            this.mileMessage = new System.Windows.Forms.Label();
            this.hoursInput = new System.Windows.Forms.TextBox();
            this.mileInput = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.totalTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleLabel.Location = new System.Drawing.Point(292, 55);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(336, 51);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Move Estimator";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // hoursMessage
            // 
            this.hoursMessage.AutoSize = true;
            this.hoursMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursMessage.Location = new System.Drawing.Point(71, 173);
            this.hoursMessage.Name = "hoursMessage";
            this.hoursMessage.Size = new System.Drawing.Size(520, 36);
            this.hoursMessage.TabIndex = 1;
            this.hoursMessage.Text = "Enter number of hours move will take: ";
            // 
            // mileMessage
            // 
            this.mileMessage.AutoSize = true;
            this.mileMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileMessage.Location = new System.Drawing.Point(71, 262);
            this.mileMessage.Name = "mileMessage";
            this.mileMessage.Size = new System.Drawing.Size(512, 36);
            this.mileMessage.TabIndex = 2;
            this.mileMessage.Text = "Enter the distance for move(in miles): ";
            // 
            // hoursInput
            // 
            this.hoursInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursInput.Location = new System.Drawing.Point(705, 168);
            this.hoursInput.Name = "hoursInput";
            this.hoursInput.Size = new System.Drawing.Size(100, 41);
            this.hoursInput.TabIndex = 3;
            // 
            // mileInput
            // 
            this.mileInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileInput.Location = new System.Drawing.Point(705, 257);
            this.mileInput.Name = "mileInput";
            this.mileInput.Size = new System.Drawing.Size(100, 41);
            this.mileInput.TabIndex = 4;
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(525, 354);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(281, 83);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate Total";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(110, 488);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(644, 112);
            this.totalTextBox.TabIndex = 6;
            this.totalTextBox.Text = "Your move cost is estimated at: ";
            this.totalTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // estimatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 693);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.mileInput);
            this.Controls.Add(this.hoursInput);
            this.Controls.Add(this.mileMessage);
            this.Controls.Add(this.hoursMessage);
            this.Controls.Add(this.titleLabel);
            this.Name = "estimatorWindow";
            this.Text = "Move Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label hoursMessage;
        private System.Windows.Forms.Label mileMessage;
        private System.Windows.Forms.TextBox hoursInput;
        private System.Windows.Forms.TextBox mileInput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label totalTextBox;
    }
}

