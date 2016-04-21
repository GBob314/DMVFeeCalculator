namespace DMVFeeCalculator
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
            this.submit = new System.Windows.Forms.Button();
            this.prevSellPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleYear = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.estimateOutput = new System.Windows.Forms.TextBox();
            this.radio10Days = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radio30Days = new System.Windows.Forms.RadioButton();
            this.radio1Year = new System.Windows.Forms.RadioButton();
            this.radio2Years = new System.Windows.Forms.RadioButton();
            this.radioMoreThan2Years = new System.Windows.Forms.RadioButton();
            this.radioNotLate = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VLFOutput = new System.Windows.Forms.TextBox();
            this.lateOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(15, 90);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // prevSellPrice
            // 
            this.prevSellPrice.Location = new System.Drawing.Point(15, 25);
            this.prevSellPrice.Name = "prevSellPrice";
            this.prevSellPrice.Size = new System.Drawing.Size(100, 20);
            this.prevSellPrice.TabIndex = 1;
            this.prevSellPrice.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Previous Vehicle Selling Price:";
            // 
            // vehicleYear
            // 
            this.vehicleYear.CustomFormat = "yyyy";
            this.vehicleYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vehicleYear.Location = new System.Drawing.Point(15, 64);
            this.vehicleYear.Name = "vehicleYear";
            this.vehicleYear.Size = new System.Drawing.Size(100, 20);
            this.vehicleYear.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vehicle Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fee Estimate:";
            // 
            // estimateOutput
            // 
            this.estimateOutput.Location = new System.Drawing.Point(114, 279);
            this.estimateOutput.Name = "estimateOutput";
            this.estimateOutput.Size = new System.Drawing.Size(100, 20);
            this.estimateOutput.TabIndex = 6;
            this.estimateOutput.Text = "0";
            // 
            // radio10Days
            // 
            this.radio10Days.AutoSize = true;
            this.radio10Days.Location = new System.Drawing.Point(196, 64);
            this.radio10Days.Name = "radio10Days";
            this.radio10Days.Size = new System.Drawing.Size(79, 17);
            this.radio10Days.TabIndex = 7;
            this.radio10Days.TabStop = true;
            this.radio10Days.Text = "1 - 10 Days";
            this.radio10Days.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "How late is the registration?";
            // 
            // radio30Days
            // 
            this.radio30Days.AutoSize = true;
            this.radio30Days.Location = new System.Drawing.Point(196, 88);
            this.radio30Days.Name = "radio30Days";
            this.radio30Days.Size = new System.Drawing.Size(85, 17);
            this.radio30Days.TabIndex = 9;
            this.radio30Days.TabStop = true;
            this.radio30Days.Text = "11 - 30 Days";
            this.radio30Days.UseVisualStyleBackColor = true;
            // 
            // radio1Year
            // 
            this.radio1Year.AutoSize = true;
            this.radio1Year.Location = new System.Drawing.Point(196, 112);
            this.radio1Year.Name = "radio1Year";
            this.radio1Year.Size = new System.Drawing.Size(100, 17);
            this.radio1Year.TabIndex = 10;
            this.radio1Year.TabStop = true;
            this.radio1Year.Text = "31 days - 1 year";
            this.radio1Year.UseVisualStyleBackColor = true;
            // 
            // radio2Years
            // 
            this.radio2Years.AutoSize = true;
            this.radio2Years.Location = new System.Drawing.Point(196, 136);
            this.radio2Years.Name = "radio2Years";
            this.radio2Years.Size = new System.Drawing.Size(148, 17);
            this.radio2Years.TabIndex = 11;
            this.radio2Years.TabStop = true;
            this.radio2Years.Text = "More than 1 year - 2 years";
            this.radio2Years.UseVisualStyleBackColor = true;
            // 
            // radioMoreThan2Years
            // 
            this.radioMoreThan2Years.AutoSize = true;
            this.radioMoreThan2Years.Location = new System.Drawing.Point(196, 160);
            this.radioMoreThan2Years.Name = "radioMoreThan2Years";
            this.radioMoreThan2Years.Size = new System.Drawing.Size(110, 17);
            this.radioMoreThan2Years.TabIndex = 12;
            this.radioMoreThan2Years.TabStop = true;
            this.radioMoreThan2Years.Text = "More than 2 years";
            this.radioMoreThan2Years.UseVisualStyleBackColor = true;
            // 
            // radioNotLate
            // 
            this.radioNotLate.AutoSize = true;
            this.radioNotLate.Location = new System.Drawing.Point(196, 41);
            this.radioNotLate.Name = "radioNotLate";
            this.radioNotLate.Size = new System.Drawing.Size(62, 17);
            this.radioNotLate.TabIndex = 13;
            this.radioNotLate.TabStop = true;
            this.radioNotLate.Text = "Not late";
            this.radioNotLate.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "VLF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Late Fees:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total:";
            // 
            // VLFOutput
            // 
            this.VLFOutput.Location = new System.Drawing.Point(114, 227);
            this.VLFOutput.Name = "VLFOutput";
            this.VLFOutput.Size = new System.Drawing.Size(100, 20);
            this.VLFOutput.TabIndex = 17;
            this.VLFOutput.Text = "0";
            // 
            // lateOutput
            // 
            this.lateOutput.Location = new System.Drawing.Point(114, 253);
            this.lateOutput.Name = "lateOutput";
            this.lateOutput.Size = new System.Drawing.Size(100, 20);
            this.lateOutput.TabIndex = 18;
            this.lateOutput.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 320);
            this.Controls.Add(this.lateOutput);
            this.Controls.Add(this.VLFOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioNotLate);
            this.Controls.Add(this.radioMoreThan2Years);
            this.Controls.Add(this.radio2Years);
            this.Controls.Add(this.radio1Year);
            this.Controls.Add(this.radio30Days);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radio10Days);
            this.Controls.Add(this.estimateOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vehicleYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prevSellPrice);
            this.Controls.Add(this.submit);
            this.Name = "Form1";
            this.Text = "DMV Fee Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void prevSellPrice_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void estimateOutput_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void vehicleYear_ValueChanged(object sender, System.EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox prevSellPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker vehicleYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox estimateOutput;
        private System.Windows.Forms.RadioButton radio10Days;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radio30Days;
        private System.Windows.Forms.RadioButton radio1Year;
        private System.Windows.Forms.RadioButton radio2Years;
        private System.Windows.Forms.RadioButton radioMoreThan2Years;
        private System.Windows.Forms.RadioButton radioNotLate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VLFOutput;
        private System.Windows.Forms.TextBox lateOutput;
    }
}

