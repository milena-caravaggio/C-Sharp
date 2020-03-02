namespace SistemaConta
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
            this.label2 = new System.Windows.Forms.Label();
            this.lhsOperand = new System.Windows.Forms.TextBox();
            this.rhsOperand = new System.Windows.Forms.TextBox();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.radioSub = new System.Windows.Forms.RadioButton();
            this.radioMult = new System.Windows.Forms.RadioButton();
            this.radioDiv = new System.Windows.Forms.RadioButton();
            this.radioRam = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left operand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Right operand";
            // 
            // lhsOperand
            // 
            this.lhsOperand.Location = new System.Drawing.Point(12, 76);
            this.lhsOperand.Name = "lhsOperand";
            this.lhsOperand.Size = new System.Drawing.Size(100, 20);
            this.lhsOperand.TabIndex = 2;
            this.lhsOperand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lhsOperand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lhsOperand_KeyPress);
            // 
            // rhsOperand
            // 
            this.rhsOperand.Location = new System.Drawing.Point(273, 76);
            this.rhsOperand.Name = "rhsOperand";
            this.rhsOperand.Size = new System.Drawing.Size(100, 20);
            this.rhsOperand.TabIndex = 3;
            this.rhsOperand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rhsOperand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rhsOperand_KeyPress);
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Location = new System.Drawing.Point(150, 95);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(72, 17);
            this.radioAdd.TabIndex = 4;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "+ Addition";
            this.radioAdd.UseVisualStyleBackColor = true;
            // 
            // radioSub
            // 
            this.radioSub.AutoSize = true;
            this.radioSub.Location = new System.Drawing.Point(150, 115);
            this.radioSub.Name = "radioSub";
            this.radioSub.Size = new System.Drawing.Size(85, 17);
            this.radioSub.TabIndex = 5;
            this.radioSub.TabStop = true;
            this.radioSub.Text = "- Subtraction";
            this.radioSub.UseVisualStyleBackColor = true;
            // 
            // radioMult
            // 
            this.radioMult.AutoSize = true;
            this.radioMult.Location = new System.Drawing.Point(150, 138);
            this.radioMult.Name = "radioMult";
            this.radioMult.Size = new System.Drawing.Size(93, 17);
            this.radioMult.TabIndex = 6;
            this.radioMult.TabStop = true;
            this.radioMult.Text = "* Multiplication";
            this.radioMult.UseVisualStyleBackColor = true;
            // 
            // radioDiv
            // 
            this.radioDiv.AutoSize = true;
            this.radioDiv.Location = new System.Drawing.Point(150, 161);
            this.radioDiv.Name = "radioDiv";
            this.radioDiv.Size = new System.Drawing.Size(70, 17);
            this.radioDiv.TabIndex = 7;
            this.radioDiv.TabStop = true;
            this.radioDiv.Text = "/ Division";
            this.radioDiv.UseVisualStyleBackColor = true;
            // 
            // radioRam
            // 
            this.radioRam.AutoSize = true;
            this.radioRam.Location = new System.Drawing.Point(150, 184);
            this.radioRam.Name = "radioRam";
            this.radioRam.Size = new System.Drawing.Size(87, 17);
            this.radioRam.TabIndex = 8;
            this.radioRam.TabStop = true;
            this.radioRam.Text = "% Ramainder";
            this.radioRam.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(25, 203);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Expression";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Result";
            // 
            // txtExp
            // 
            this.txtExp.Enabled = false;
            this.txtExp.Location = new System.Drawing.Point(121, 243);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(100, 20);
            this.txtExp.TabIndex = 12;
            this.txtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(121, 275);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 13;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(25, 307);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 14;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 356);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.radioRam);
            this.Controls.Add(this.radioDiv);
            this.Controls.Add(this.radioMult);
            this.Controls.Add(this.radioSub);
            this.Controls.Add(this.radioAdd);
            this.Controls.Add(this.rhsOperand);
            this.Controls.Add(this.lhsOperand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maths Operators";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lhsOperand;
        private System.Windows.Forms.TextBox rhsOperand;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.RadioButton radioSub;
        private System.Windows.Forms.RadioButton radioMult;
        private System.Windows.Forms.RadioButton radioDiv;
        private System.Windows.Forms.RadioButton radioRam;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnQuit;
    }
}

