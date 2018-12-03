namespace RoundingProgramMo
{
    partial class frmRoundingProgram
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
            this.lblEnterDec = new System.Windows.Forms.Label();
            this.txtDecimalNum = new System.Windows.Forms.TextBox();
            this.lblHowMany = new System.Windows.Forms.Label();
            this.nudDecimalPlaces = new System.Windows.Forms.NumericUpDown();
            this.btnRound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimalPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterDec
            // 
            this.lblEnterDec.AutoSize = true;
            this.lblEnterDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterDec.Location = new System.Drawing.Point(10, 50);
            this.lblEnterDec.Name = "lblEnterDec";
            this.lblEnterDec.Size = new System.Drawing.Size(257, 25);
            this.lblEnterDec.TabIndex = 0;
            this.lblEnterDec.Text = "Enter a Decimal Number: ";
            // 
            // txtDecimalNum
            // 
            this.txtDecimalNum.Location = new System.Drawing.Point(273, 55);
            this.txtDecimalNum.Name = "txtDecimalNum";
            this.txtDecimalNum.Size = new System.Drawing.Size(163, 20);
            this.txtDecimalNum.TabIndex = 1;
            // 
            // lblHowMany
            // 
            this.lblHowMany.AutoSize = true;
            this.lblHowMany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowMany.Location = new System.Drawing.Point(10, 101);
            this.lblHowMany.Name = "lblHowMany";
            this.lblHowMany.Size = new System.Drawing.Size(507, 25);
            this.lblHowMany.TabIndex = 2;
            this.lblHowMany.Text = "How many Decimal places do you want to round to?";
            // 
            // nudDecimalPlaces
            // 
            this.nudDecimalPlaces.Location = new System.Drawing.Point(523, 106);
            this.nudDecimalPlaces.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDecimalPlaces.Name = "nudDecimalPlaces";
            this.nudDecimalPlaces.Size = new System.Drawing.Size(42, 20);
            this.nudDecimalPlaces.TabIndex = 3;
            // 
            // btnRound
            // 
            this.btnRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRound.Location = new System.Drawing.Point(273, 150);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(82, 38);
            this.btnRound.TabIndex = 4;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            // 
            // frmRoundingProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(628, 227);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.nudDecimalPlaces);
            this.Controls.Add(this.lblHowMany);
            this.Controls.Add(this.txtDecimalNum);
            this.Controls.Add(this.lblEnterDec);
            this.Name = "frmRoundingProgram";
            this.Text = "Rounding Program By Mohammed";
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimalPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterDec;
        private System.Windows.Forms.TextBox txtDecimalNum;
        private System.Windows.Forms.Label lblHowMany;
        private System.Windows.Forms.NumericUpDown nudDecimalPlaces;
        private System.Windows.Forms.Button btnRound;
    }
}

