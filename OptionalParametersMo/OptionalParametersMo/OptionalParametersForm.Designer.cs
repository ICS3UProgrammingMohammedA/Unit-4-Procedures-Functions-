namespace OptionalParametersMo
{
    partial class frmOptionalParameters
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
            this.lblWords = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEnterAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtEnterCity = new System.Windows.Forms.TextBox();
            this.txtEnterPostalCode = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtEnterUnit = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtEnterProvince = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWords.Location = new System.Drawing.Point(93, 45);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(352, 24);
            this.lblWords.TabIndex = 0;
            this.lblWords.Text = "Enter your full address in the fields below";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(43, 102);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(90, 24);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address :";
            // 
            // txtEnterAddress
            // 
            this.txtEnterAddress.Location = new System.Drawing.Point(139, 102);
            this.txtEnterAddress.Name = "txtEnterAddress";
            this.txtEnterAddress.Size = new System.Drawing.Size(115, 20);
            this.txtEnterAddress.TabIndex = 2;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(83, 152);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(50, 24);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City :";
            // 
            // txtEnterCity
            // 
            this.txtEnterCity.Location = new System.Drawing.Point(139, 157);
            this.txtEnterCity.Name = "txtEnterCity";
            this.txtEnterCity.Size = new System.Drawing.Size(115, 20);
            this.txtEnterCity.TabIndex = 4;
            // 
            // txtEnterPostalCode
            // 
            this.txtEnterPostalCode.Location = new System.Drawing.Point(139, 210);
            this.txtEnterPostalCode.Name = "txtEnterPostalCode";
            this.txtEnterPostalCode.Size = new System.Drawing.Size(115, 20);
            this.txtEnterPostalCode.TabIndex = 5;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.Location = new System.Drawing.Point(12, 205);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(121, 24);
            this.lblPostalCode.TabIndex = 6;
            this.lblPostalCode.Text = "Postal Code :";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(340, 102);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(52, 24);
            this.lblUnit.TabIndex = 7;
            this.lblUnit.Text = "Unit :";
            // 
            // txtEnterUnit
            // 
            this.txtEnterUnit.Location = new System.Drawing.Point(398, 106);
            this.txtEnterUnit.Name = "txtEnterUnit";
            this.txtEnterUnit.Size = new System.Drawing.Size(115, 20);
            this.txtEnterUnit.TabIndex = 8;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(298, 157);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(94, 24);
            this.lblProvince.TabIndex = 9;
            this.lblProvince.Text = "Province :";
            // 
            // txtEnterProvince
            // 
            this.txtEnterProvince.Location = new System.Drawing.Point(398, 161);
            this.txtEnterProvince.Name = "txtEnterProvince";
            this.txtEnterProvince.Size = new System.Drawing.Size(115, 20);
            this.txtEnterProvince.TabIndex = 10;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(236, 274);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(91, 40);
            this.btnEnter.TabIndex = 11;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // frmOptionalParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(547, 374);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtEnterProvince);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.txtEnterUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.txtEnterPostalCode);
            this.Controls.Add(this.txtEnterCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtEnterAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblWords);
            this.Name = "frmOptionalParameters";
            this.Text = "Optional Parameters By Mohammed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtEnterAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtEnterCity;
        private System.Windows.Forms.TextBox txtEnterPostalCode;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtEnterUnit;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtEnterProvince;
        private System.Windows.Forms.Button btnEnter;
    }
}

