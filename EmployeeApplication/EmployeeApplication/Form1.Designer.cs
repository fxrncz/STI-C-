namespace EmployeeApplication
{
    partial class frmComputeSalary
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
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRPH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHW = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.opFN = new System.Windows.Forms.Label();
            this.opLN = new System.Windows.Forms.Label();
            this.opSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtFN
            // 
            this.txtFN.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFN.Location = new System.Drawing.Point(26, 45);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(187, 26);
            this.txtFN.TabIndex = 1;
            // 
            // txtLN
            // 
            this.txtLN.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLN.Location = new System.Drawing.Point(234, 45);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(187, 26);
            this.txtLN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtDept
            // 
            this.txtDept.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDept.Location = new System.Drawing.Point(26, 108);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(187, 26);
            this.txtDept.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Department";
            // 
            // txtJob
            // 
            this.txtJob.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.Location = new System.Drawing.Point(234, 108);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(187, 26);
            this.txtJob.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Job Title";
            // 
            // txtRPH
            // 
            this.txtRPH.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRPH.Location = new System.Drawing.Point(26, 197);
            this.txtRPH.Name = "txtRPH";
            this.txtRPH.Size = new System.Drawing.Size(187, 26);
            this.txtRPH.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rate per Hour";
            // 
            // txtHW
            // 
            this.txtHW.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHW.Location = new System.Drawing.Point(234, 197);
            this.txtHW.Name = "txtHW";
            this.txtHW.Size = new System.Drawing.Size(187, 26);
            this.txtHW.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total hours worked";
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(152, 239);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(143, 32);
            this.btnCompute.TabIndex = 12;
            this.btnCompute.Text = "Compute Salary";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "First Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Last Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Basic Salary:";
            // 
            // opFN
            // 
            this.opFN.AutoSize = true;
            this.opFN.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opFN.Location = new System.Drawing.Point(148, 301);
            this.opFN.Name = "opFN";
            this.opFN.Size = new System.Drawing.Size(145, 19);
            this.opFN.TabIndex = 16;
            this.opFN.Text = "<first name here>";
            // 
            // opLN
            // 
            this.opLN.AutoSize = true;
            this.opLN.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opLN.Location = new System.Drawing.Point(148, 334);
            this.opLN.Name = "opLN";
            this.opLN.Size = new System.Drawing.Size(142, 19);
            this.opLN.TabIndex = 17;
            this.opLN.Text = "<last name here>";
            // 
            // opSalary
            // 
            this.opSalary.AutoSize = true;
            this.opSalary.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opSalary.Location = new System.Drawing.Point(148, 367);
            this.opSalary.Name = "opSalary";
            this.opSalary.Size = new System.Drawing.Size(43, 19);
            this.opSalary.TabIndex = 18;
            this.opSalary.Text = "0.00";
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 412);
            this.Controls.Add(this.opSalary);
            this.Controls.Add(this.opLN);
            this.Controls.Add(this.opFN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtHW);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRPH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.label1);
            this.Name = "frmComputeSalary";
            this.Text = "Employee Salary Compute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRPH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label opFN;
        private System.Windows.Forms.Label opLN;
        private System.Windows.Forms.Label opSalary;
    }
}

