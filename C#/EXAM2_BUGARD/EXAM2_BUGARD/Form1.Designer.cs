namespace EXAM2_BUGARD
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radFromUs = new System.Windows.Forms.RadioButton();
            this.radFromEuros = new System.Windows.Forms.RadioButton();
            this.radFromBritish = new System.Windows.Forms.RadioButton();
            this.radFromMexican = new System.Windows.Forms.RadioButton();
            this.radToUs = new System.Windows.Forms.RadioButton();
            this.radToEuros = new System.Windows.Forms.RadioButton();
            this.radToBritish = new System.Windows.Forms.RadioButton();
            this.radToMexican = new System.Windows.Forms.RadioButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency Conversion Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radFromMexican);
            this.groupBox1.Controls.Add(this.radFromBritish);
            this.groupBox1.Controls.Add(this.radFromEuros);
            this.groupBox1.Controls.Add(this.radFromUs);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From Currency";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radToMexican);
            this.groupBox2.Controls.Add(this.radToBritish);
            this.groupBox2.Controls.Add(this.radToEuros);
            this.groupBox2.Controls.Add(this.radToUs);
            this.groupBox2.Location = new System.Drawing.Point(307, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 178);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To Currency";
            // 
            // radFromUs
            // 
            this.radFromUs.AutoSize = true;
            this.radFromUs.Location = new System.Drawing.Point(19, 24);
            this.radFromUs.Name = "radFromUs";
            this.radFromUs.Size = new System.Drawing.Size(81, 17);
            this.radFromUs.TabIndex = 0;
            this.radFromUs.TabStop = true;
            this.radFromUs.Text = "U.S. Dollars";
            this.radFromUs.UseVisualStyleBackColor = true;
            // 
            // radFromEuros
            // 
            this.radFromEuros.AutoSize = true;
            this.radFromEuros.Location = new System.Drawing.Point(19, 57);
            this.radFromEuros.Name = "radFromEuros";
            this.radFromEuros.Size = new System.Drawing.Size(52, 17);
            this.radFromEuros.TabIndex = 1;
            this.radFromEuros.TabStop = true;
            this.radFromEuros.Text = "Euros";
            this.radFromEuros.UseVisualStyleBackColor = true;
            // 
            // radFromBritish
            // 
            this.radFromBritish.AutoSize = true;
            this.radFromBritish.Location = new System.Drawing.Point(19, 92);
            this.radFromBritish.Name = "radFromBritish";
            this.radFromBritish.Size = new System.Drawing.Size(92, 17);
            this.radFromBritish.TabIndex = 2;
            this.radFromBritish.TabStop = true;
            this.radFromBritish.Text = "British Pounds";
            this.radFromBritish.UseVisualStyleBackColor = true;
            // 
            // radFromMexican
            // 
            this.radFromMexican.AutoSize = true;
            this.radFromMexican.Location = new System.Drawing.Point(19, 130);
            this.radFromMexican.Name = "radFromMexican";
            this.radFromMexican.Size = new System.Drawing.Size(97, 17);
            this.radFromMexican.TabIndex = 3;
            this.radFromMexican.TabStop = true;
            this.radFromMexican.Text = "Mexican Pesos";
            this.radFromMexican.UseVisualStyleBackColor = true;
            // 
            // radToUs
            // 
            this.radToUs.AutoSize = true;
            this.radToUs.Location = new System.Drawing.Point(19, 24);
            this.radToUs.Name = "radToUs";
            this.radToUs.Size = new System.Drawing.Size(81, 17);
            this.radToUs.TabIndex = 0;
            this.radToUs.TabStop = true;
            this.radToUs.Text = "U.S. Dollars";
            this.radToUs.UseVisualStyleBackColor = true;
            // 
            // radToEuros
            // 
            this.radToEuros.AutoSize = true;
            this.radToEuros.Location = new System.Drawing.Point(19, 57);
            this.radToEuros.Name = "radToEuros";
            this.radToEuros.Size = new System.Drawing.Size(52, 17);
            this.radToEuros.TabIndex = 1;
            this.radToEuros.TabStop = true;
            this.radToEuros.Text = "Euros";
            this.radToEuros.UseVisualStyleBackColor = true;
            // 
            // radToBritish
            // 
            this.radToBritish.AutoSize = true;
            this.radToBritish.Location = new System.Drawing.Point(19, 92);
            this.radToBritish.Name = "radToBritish";
            this.radToBritish.Size = new System.Drawing.Size(92, 17);
            this.radToBritish.TabIndex = 2;
            this.radToBritish.TabStop = true;
            this.radToBritish.Text = "British Pounds";
            this.radToBritish.UseVisualStyleBackColor = true;
            // 
            // radToMexican
            // 
            this.radToMexican.AutoSize = true;
            this.radToMexican.Location = new System.Drawing.Point(19, 130);
            this.radToMexican.Name = "radToMexican";
            this.radToMexican.Size = new System.Drawing.Size(97, 17);
            this.radToMexican.TabIndex = 3;
            this.radToMexican.TabStop = true;
            this.radToMexican.Text = "Mexican Pesos";
            this.radToMexican.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(233, 267);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(307, 259);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(429, 256);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 338);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(560, 23);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "label2";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 370);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "COP2360 - Exam2 - Louis Bradley";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radFromMexican;
        private System.Windows.Forms.RadioButton radFromBritish;
        private System.Windows.Forms.RadioButton radFromEuros;
        private System.Windows.Forms.RadioButton radFromUs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radToMexican;
        private System.Windows.Forms.RadioButton radToBritish;
        private System.Windows.Forms.RadioButton radToEuros;
        private System.Windows.Forms.RadioButton radToUs;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}

