namespace CalculoAreaPerimetro
{
    partial class Rombo
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
            this.lblDiagonalMenor = new System.Windows.Forms.Label();
            this.txtDiagonalMenor = new System.Windows.Forms.TextBox();
            this.txtDiagonalMayor = new System.Windows.Forms.TextBox();
            this.lblBaseMayor = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDiagonalMenor
            // 
            this.lblDiagonalMenor.AutoSize = true;
            this.lblDiagonalMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagonalMenor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiagonalMenor.Location = new System.Drawing.Point(114, 83);
            this.lblDiagonalMenor.Name = "lblDiagonalMenor";
            this.lblDiagonalMenor.Size = new System.Drawing.Size(242, 25);
            this.lblDiagonalMenor.TabIndex = 69;
            this.lblDiagonalMenor.Text = "Ingrese la diagonal menor:";
            // 
            // txtDiagonalMenor
            // 
            this.txtDiagonalMenor.Location = new System.Drawing.Point(386, 83);
            this.txtDiagonalMenor.Name = "txtDiagonalMenor";
            this.txtDiagonalMenor.Size = new System.Drawing.Size(140, 22);
            this.txtDiagonalMenor.TabIndex = 68;
            // 
            // txtDiagonalMayor
            // 
            this.txtDiagonalMayor.Location = new System.Drawing.Point(386, 38);
            this.txtDiagonalMayor.Name = "txtDiagonalMayor";
            this.txtDiagonalMayor.Size = new System.Drawing.Size(140, 22);
            this.txtDiagonalMayor.TabIndex = 67;
            // 
            // lblBaseMayor
            // 
            this.lblBaseMayor.AutoSize = true;
            this.lblBaseMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMayor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaseMayor.Location = new System.Drawing.Point(114, 34);
            this.lblBaseMayor.Name = "lblBaseMayor";
            this.lblBaseMayor.Size = new System.Drawing.Size(241, 25);
            this.lblBaseMayor.TabIndex = 66;
            this.lblBaseMayor.Text = "Ingrese la diagonal mayor:";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(288, 282);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(179, 22);
            this.txtPerimetro.TabIndex = 74;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(288, 246);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(179, 22);
            this.txtArea.TabIndex = 73;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPerimetro.Location = new System.Drawing.Point(179, 278);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(101, 25);
            this.lblPerimetro.TabIndex = 72;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblArea.Location = new System.Drawing.Point(184, 246);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(60, 25);
            this.lblArea.TabIndex = 71;
            this.lblArea.Text = "Área:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(288, 182);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 36);
            this.btnCalcular.TabIndex = 70;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLado.Location = new System.Drawing.Point(114, 132);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(145, 25);
            this.lblLado.TabIndex = 76;
            this.lblLado.Text = "Ingrese el lado:";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(386, 132);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(140, 22);
            this.txtLado.TabIndex = 75;
            // 
            // Rombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(651, 333);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblDiagonalMenor);
            this.Controls.Add(this.txtDiagonalMenor);
            this.Controls.Add(this.txtDiagonalMayor);
            this.Controls.Add(this.lblBaseMayor);
            this.Name = "Rombo";
            this.Text = "Rombo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiagonalMenor;
        private System.Windows.Forms.TextBox txtDiagonalMenor;
        private System.Windows.Forms.TextBox txtDiagonalMayor;
        private System.Windows.Forms.Label lblBaseMayor;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtLado;
    }
}