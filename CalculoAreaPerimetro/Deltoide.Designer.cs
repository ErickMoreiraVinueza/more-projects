namespace CalculoAreaPerimetro
{
    partial class Deltoide
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
            this.txtLadoLargo = new System.Windows.Forms.TextBox();
            this.lblLadoLar = new System.Windows.Forms.Label();
            this.lblLadoCor = new System.Windows.Forms.Label();
            this.txtLadoCorto = new System.Windows.Forms.TextBox();
            this.lblDiagonalMenor = new System.Windows.Forms.Label();
            this.txtDiagonalMenor = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtDiagonalMayor = new System.Windows.Forms.TextBox();
            this.lblDiagonalMayor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLadoLargo
            // 
            this.txtLadoLargo.Location = new System.Drawing.Point(383, 164);
            this.txtLadoLargo.Name = "txtLadoLargo";
            this.txtLadoLargo.Size = new System.Drawing.Size(140, 22);
            this.txtLadoLargo.TabIndex = 83;
            // 
            // lblLadoLar
            // 
            this.lblLadoLar.AutoSize = true;
            this.lblLadoLar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoLar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLadoLar.Location = new System.Drawing.Point(112, 160);
            this.lblLadoLar.Name = "lblLadoLar";
            this.lblLadoLar.Size = new System.Drawing.Size(193, 25);
            this.lblLadoLar.TabIndex = 82;
            this.lblLadoLar.Text = "Ingrese el lado largo:";
            // 
            // lblLadoCor
            // 
            this.lblLadoCor.AutoSize = true;
            this.lblLadoCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoCor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLadoCor.Location = new System.Drawing.Point(112, 118);
            this.lblLadoCor.Name = "lblLadoCor";
            this.lblLadoCor.Size = new System.Drawing.Size(193, 25);
            this.lblLadoCor.TabIndex = 81;
            this.lblLadoCor.Text = "Ingrese el lado corto:";
            // 
            // txtLadoCorto
            // 
            this.txtLadoCorto.Location = new System.Drawing.Point(383, 118);
            this.txtLadoCorto.Name = "txtLadoCorto";
            this.txtLadoCorto.Size = new System.Drawing.Size(140, 22);
            this.txtLadoCorto.TabIndex = 80;
            // 
            // lblDiagonalMenor
            // 
            this.lblDiagonalMenor.AutoSize = true;
            this.lblDiagonalMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagonalMenor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiagonalMenor.Location = new System.Drawing.Point(112, 71);
            this.lblDiagonalMenor.Name = "lblDiagonalMenor";
            this.lblDiagonalMenor.Size = new System.Drawing.Size(242, 25);
            this.lblDiagonalMenor.TabIndex = 79;
            this.lblDiagonalMenor.Text = "Ingrese la diagonal menor:";
            // 
            // txtDiagonalMenor
            // 
            this.txtDiagonalMenor.Location = new System.Drawing.Point(383, 71);
            this.txtDiagonalMenor.Name = "txtDiagonalMenor";
            this.txtDiagonalMenor.Size = new System.Drawing.Size(140, 22);
            this.txtDiagonalMenor.TabIndex = 78;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(303, 311);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(179, 22);
            this.txtPerimetro.TabIndex = 77;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(303, 275);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(179, 22);
            this.txtArea.TabIndex = 76;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPerimetro.Location = new System.Drawing.Point(194, 307);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(101, 25);
            this.lblPerimetro.TabIndex = 75;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblArea.Location = new System.Drawing.Point(199, 275);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(60, 25);
            this.lblArea.TabIndex = 74;
            this.lblArea.Text = "Área:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(303, 211);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 36);
            this.btnCalcular.TabIndex = 73;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtDiagonalMayor
            // 
            this.txtDiagonalMayor.Location = new System.Drawing.Point(383, 30);
            this.txtDiagonalMayor.Name = "txtDiagonalMayor";
            this.txtDiagonalMayor.Size = new System.Drawing.Size(140, 22);
            this.txtDiagonalMayor.TabIndex = 72;
            // 
            // lblDiagonalMayor
            // 
            this.lblDiagonalMayor.AutoSize = true;
            this.lblDiagonalMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagonalMayor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiagonalMayor.Location = new System.Drawing.Point(112, 26);
            this.lblDiagonalMayor.Name = "lblDiagonalMayor";
            this.lblDiagonalMayor.Size = new System.Drawing.Size(241, 25);
            this.lblDiagonalMayor.TabIndex = 71;
            this.lblDiagonalMayor.Text = "Ingrese la diagonal mayor:";
            // 
            // Deltoide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(674, 388);
            this.Controls.Add(this.txtLadoLargo);
            this.Controls.Add(this.lblLadoLar);
            this.Controls.Add(this.lblLadoCor);
            this.Controls.Add(this.txtLadoCorto);
            this.Controls.Add(this.lblDiagonalMenor);
            this.Controls.Add(this.txtDiagonalMenor);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDiagonalMayor);
            this.Controls.Add(this.lblDiagonalMayor);
            this.Name = "Deltoide";
            this.Text = "Deltoide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLadoLargo;
        private System.Windows.Forms.Label lblLadoLar;
        private System.Windows.Forms.Label lblLadoCor;
        private System.Windows.Forms.TextBox txtLadoCorto;
        private System.Windows.Forms.Label lblDiagonalMenor;
        private System.Windows.Forms.TextBox txtDiagonalMenor;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtDiagonalMayor;
        private System.Windows.Forms.Label lblDiagonalMayor;
    }
}