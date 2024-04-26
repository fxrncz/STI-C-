namespace Activity1
{
    partial class SquareForm
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
            this.lblSForm = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtSquare = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.opSquare = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnBacksf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSForm
            // 
            this.lblSForm.AutoSize = true;
            this.lblSForm.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSForm.Location = new System.Drawing.Point(86, 15);
            this.lblSForm.Name = "lblSForm";
            this.lblSForm.Size = new System.Drawing.Size(153, 31);
            this.lblSForm.TabIndex = 0;
            this.lblSForm.Text = "Square Form";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(28, 59);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(161, 18);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Enter Area of a Square:";
            // 
            // txtSquare
            // 
            this.txtSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSquare.Location = new System.Drawing.Point(30, 92);
            this.txtSquare.Name = "txtSquare";
            this.txtSquare.Size = new System.Drawing.Size(158, 24);
            this.txtSquare.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(28, 188);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(122, 18);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Area of a Square:";
            this.lbl2.Click += new System.EventHandler(this.label1_Click);
            // 
            // opSquare
            // 
            this.opSquare.AutoSize = true;
            this.opSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opSquare.Location = new System.Drawing.Point(156, 188);
            this.opSquare.Name = "opSquare";
            this.opSquare.Size = new System.Drawing.Size(58, 18);
            this.opSquare.TabIndex = 4;
            this.opSquare.Text = "Output";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.Location = new System.Drawing.Point(30, 131);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 31);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnBacksf
            // 
            this.btnBacksf.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBacksf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBacksf.Location = new System.Drawing.Point(31, 229);
            this.btnBacksf.Name = "btnBacksf";
            this.btnBacksf.Size = new System.Drawing.Size(100, 31);
            this.btnBacksf.TabIndex = 6;
            this.btnBacksf.Text = "Back";
            this.btnBacksf.UseVisualStyleBackColor = false;
            this.btnBacksf.Click += new System.EventHandler(this.btnBacksf_Click);
            // 
            // SquareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 272);
            this.Controls.Add(this.btnBacksf);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.opSquare);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtSquare);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblSForm);
            this.Name = "SquareForm";
            this.Text = "SquareForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSForm;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtSquare;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label opSquare;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnBacksf;
    }
}