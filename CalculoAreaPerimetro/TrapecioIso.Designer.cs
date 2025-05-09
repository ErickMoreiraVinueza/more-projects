namespace CalculoAreaPerimetro
{
    partial class TrapecioIso
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
            this.txtLadoObli = new System.Windows.Forms.TextBox();
            this.lblLadoObli = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblBaseMenor = new System.Windows.Forms.Label();
            this.txtBaseMenor = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtBaseMayor = new System.Windows.Forms.TextBox();
            this.lblBaseMayor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLadoObli
            // 
            this.txtLadoObli.Location = new System.Drawing.Point(436, 172);
            this.txtLadoObli.Name = "txtLadoObli";
            this.txtLadoObli.Size = new System.Drawing.Size(140, 22);
            this.txtLadoObli.TabIndex = 70;
            // 
            // lblLadoObli
            // 
            this.lblLadoObli.AutoSize = true;
            this.lblLadoObli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoObli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLadoObli.Location = new System.Drawing.Point(194, 168);
            this.lblLadoObli.Name = "lblLadoObli";
            this.lblLadoObli.Size = new System.Drawing.Size(212, 25);
            this.lblLadoObli.TabIndex = 68;
            this.lblLadoObli.Text = "Ingrese el lado oblicuo:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAltura.Location = new System.Drawing.Point(194, 126);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(159, 25);
            this.lblAltura.TabIndex = 67;
            this.lblAltura.Text = "Ingrese la Altura:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(436, 126);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(140, 22);
            this.txtAltura.TabIndex = 66;
            // 
            // lblBaseMenor
            // 
            this.lblBaseMenor.AutoSize = true;
            this.lblBaseMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMenor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaseMenor.Location = new System.Drawing.Point(194, 79);
            this.lblBaseMenor.Name = "lblBaseMenor";
            this.lblBaseMenor.Size = new System.Drawing.Size(211, 25);
            this.lblBaseMenor.TabIndex = 65;
            this.lblBaseMenor.Text = "Ingrese la base menor:";
            // 
            // txtBaseMenor
            // 
            this.txtBaseMenor.Location = new System.Drawing.Point(436, 79);
            this.txtBaseMenor.Name = "txtBaseMenor";
            this.txtBaseMenor.Size = new System.Drawing.Size(140, 22);
            this.txtBaseMenor.TabIndex = 64;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(356, 319);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(179, 22);
            this.txtPerimetro.TabIndex = 63;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(356, 283);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(179, 22);
            this.txtArea.TabIndex = 62;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPerimetro.Location = new System.Drawing.Point(247, 315);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(101, 25);
            this.lblPerimetro.TabIndex = 61;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblArea.Location = new System.Drawing.Point(252, 283);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(60, 25);
            this.lblArea.TabIndex = 60;
            this.lblArea.Text = "Área:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(356, 219);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 36);
            this.btnCalcular.TabIndex = 59;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtBaseMayor
            // 
            this.txtBaseMayor.Location = new System.Drawing.Point(436, 34);
            this.txtBaseMayor.Name = "txtBaseMayor";
            this.txtBaseMayor.Size = new System.Drawing.Size(140, 22);
            this.txtBaseMayor.TabIndex = 58;
            // 
            // lblBaseMayor
            // 
            this.lblBaseMayor.AutoSize = true;
            this.lblBaseMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMayor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaseMayor.Location = new System.Drawing.Point(194, 30);
            this.lblBaseMayor.Name = "lblBaseMayor";
            this.lblBaseMayor.Size = new System.Drawing.Size(210, 25);
            this.lblBaseMayor.TabIndex = 57;
            this.lblBaseMayor.Text = "Ingrese la base mayor:";
            // 
            // TrapecioIso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(699, 380);
            this.Controls.Add(this.txtLadoObli);
            this.Controls.Add(this.lblLadoObli);
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
            this.Name = "TrapecioIso";
            this.Text = "TrapecioIso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLadoObli;
        private System.Windows.Forms.Label lblLadoObli;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblBaseMenor;
        private System.Windows.Forms.TextBox txtBaseMenor;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtBaseMayor;
        private System.Windows.Forms.Label lblBaseMayor;
    }
}