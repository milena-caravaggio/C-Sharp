namespace SistemaSoma
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblNDois = new System.Windows.Forms.Label();
            this.txtNUm = new System.Windows.Forms.TextBox();
            this.txtNDois = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnCalcular.Location = new System.Drawing.Point(223, 355);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(127, 57);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnLimpar.Location = new System.Drawing.Point(369, 355);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(127, 57);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTitulo.Location = new System.Drawing.Point(280, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(285, 39);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Sistema de Soma";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNum.Location = new System.Drawing.Point(12, 129);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(308, 31);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Digite o primeiro numero";
            // 
            // lblNDois
            // 
            this.lblNDois.AutoSize = true;
            this.lblNDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNDois.Location = new System.Drawing.Point(12, 183);
            this.lblNDois.Name = "lblNDois";
            this.lblNDois.Size = new System.Drawing.Size(315, 31);
            this.lblNDois.TabIndex = 4;
            this.lblNDois.Text = "Digite o segundo numero";
            // 
            // txtNUm
            // 
            this.txtNUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtNUm.Location = new System.Drawing.Point(343, 126);
            this.txtNUm.Name = "txtNUm";
            this.txtNUm.Size = new System.Drawing.Size(153, 38);
            this.txtNUm.TabIndex = 5;
            // 
            // txtNDois
            // 
            this.txtNDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtNDois.Location = new System.Drawing.Point(343, 183);
            this.txtNDois.Name = "txtNDois";
            this.txtNDois.Size = new System.Drawing.Size(153, 38);
            this.txtNDois.TabIndex = 6;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtResult.Location = new System.Drawing.Point(343, 241);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(153, 38);
            this.txtResult.TabIndex = 7;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblResult.Location = new System.Drawing.Point(183, 248);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(137, 31);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNDois);
            this.Controls.Add(this.txtNUm);
            this.Controls.Add(this.lblNDois);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Sistema de Soma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblNDois;
        private System.Windows.Forms.TextBox txtNUm;
        private System.Windows.Forms.TextBox txtNDois;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
    }
}

