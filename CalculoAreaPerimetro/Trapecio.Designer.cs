namespace CalculoAreaPerimetro
{
    partial class Trapecio
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
            this.txtBaseMenor = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtBaseMayor = new System.Windows.Forms.TextBox();
            this.lblBaseMayor = new System.Windows.Forms.Label();
            this.lblBaseMenor = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblLadoIzq = new System.Windows.Forms.Label();
            this.lblLadoDer = new System.Windows.Forms.Label();
            this.txtLadoIzq = new System.Windows.Forms.TextBox();
            this.txtLadoDer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBaseMenor
            // 
            this.txtBaseMenor.Location = new System.Drawing.Point(389, 74);
            this.txtBaseMenor.Name = "txtBaseMenor";
            this.txtBaseMenor.Size = new System.Drawing.Size(140, 22);
            this.txtBaseMenor.TabIndex = 49;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(312, 366);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(179, 22);
            this.txtPerimetro.TabIndex = 47;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(312, 330);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(179, 22);
            this.txtArea.TabIndex = 46;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPerimetro.Location = new System.Drawing.Point(203, 362);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(101, 25);
            this.lblPerimetro.TabIndex = 45;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblArea.Location = new System.Drawing.Point(208, 330);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(60, 25);
            this.lblArea.TabIndex = 44;
            this.lblArea.Text = "Área:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(312, 266);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 36);
            this.btnCalcular.TabIndex = 43;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtBaseMayor
            // 
            this.txtBaseMayor.Location = new System.Drawing.Point(389, 29);
            this.txtBaseMayor.Name = "txtBaseMayor";
            this.txtBaseMayor.Size = new System.Drawing.Size(140, 22);
            this.txtBaseMayor.TabIndex = 42;
            // 
            // lblBaseMayor
            // 
            this.lblBaseMayor.AutoSize = true;
            this.lblBaseMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMayor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaseMayor.Location = new System.Drawing.Point(147, 25);
            this.lblBaseMayor.Name = "lblBaseMayor";
            this.lblBaseMayor.Size = new System.Drawing.Size(210, 25);
            this.lblBaseMayor.TabIndex = 41;
            this.lblBaseMayor.Text = "Ingrese la base mayor:";
            // 
            // lblBaseMenor
            // 
            this.lblBaseMenor.AutoSize = true;
            this.lblBaseMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMenor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaseMenor.Location = new System.Drawing.Point(147, 74);
            this.lblBaseMenor.Name = "lblBaseMenor";
            this.lblBaseMenor.Size = new System.Drawing.Size(211, 25);
            this.lblBaseMenor.TabIndex = 50;
            this.lblBaseMenor.Text = "Ingrese la base menor:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(389, 121);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(140, 22);
            this.txtAltura.TabIndex = 51;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAltura.Location = new System.Drawing.Point(147, 121);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(159, 25);
            this.lblAltura.TabIndex = 52;
            this.lblAltura.Text = "Ingrese la Altura:";
            // 
            // lblLadoIzq
            // 
            this.lblLadoIzq.AutoSize = true;
            this.lblLadoIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoIzq.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLadoIzq.Location = new System.Drawing.Point(147, 163);
            this.lblLadoIzq.Name = "lblLadoIzq";
            this.lblLadoIzq.Size = new System.Drawing.Size(229, 25);
            this.lblLadoIzq.TabIndex = 53;
            this.lblLadoIzq.Text = "Ingrese el lado izquierdo:";
            // 
            // lblLadoDer
            // 
            this.lblLadoDer.AutoSize = true;
            this.lblLadoDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoDer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLadoDer.Location = new System.Drawing.Point(147, 212);
            this.lblLadoDer.Name = "lblLadoDer";
            this.lblLadoDer.Size = new System.Drawing.Size(221, 25);
            this.lblLadoDer.TabIndex = 54;
            this.lblLadoDer.Text = "Ingrese el lado derecho:";
            // 
            // txtLadoIzq
            // 
            this.txtLadoIzq.Location = new System.Drawing.Point(389, 167);
            this.txtLadoIzq.Name = "txtLadoIzq";
            this.txtLadoIzq.Size = new System.Drawing.Size(140, 22);
            this.txtLadoIzq.TabIndex = 55;
            // 
            // txtLadoDer
            // 
            this.txtLadoDer.Location = new System.Drawing.Point(389, 215);
            this.txtLadoDer.Name = "txtLadoDer";
            this.txtLadoDer.Size = new System.Drawing.Size(140, 22);
            this.txtLadoDer.TabIndex = 56;
            // 
            // Trapecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(667, 406);
            this.Controls.Add(this.txtLadoDer);
            this.Controls.Add(this.txtLadoIzq);
            this.Controls.Add(this.lblLadoDer);
            this.Controls.Add(this.lblLadoIzq);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblBaseMenor);
            this.Controls.Add(this.txtBaseMenor);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtBaseMayor);
            this.Controls.Add(this.lblBaseMayor);
            this.Name = "Trapecio";
            this.Text = "Trapecio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaseMenor;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtBaseMayor;
        private System.Windows.Forms.Label lblBaseMayor;
        private System.Windows.Forms.Label lblBaseMenor;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblLadoIzq;
        private System.Windows.Forms.Label lblLadoDer;
        private System.Windows.Forms.TextBox txtLadoIzq;
        private System.Windows.Forms.TextBox txtLadoDer;
    }
}