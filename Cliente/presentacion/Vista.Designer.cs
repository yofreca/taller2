namespace Cliente.presentacion
{
    partial class Vista
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
            this.components = new System.ComponentModel.Container();
            this.pcbSemaforo = new System.Windows.Forms.PictureBox();
            this.ckbApagado = new System.Windows.Forms.CheckBox();
            this.ckbRojo = new System.Windows.Forms.CheckBox();
            this.ckbRojoIntermitente = new System.Windows.Forms.CheckBox();
            this.ckbAmarillo = new System.Windows.Forms.CheckBox();
            this.ckbAmarilloIntermitente = new System.Windows.Forms.CheckBox();
            this.ckbVerde = new System.Windows.Forms.CheckBox();
            this.ckbVerdeIntermitente = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSemaforo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbSemaforo
            // 
            this.pcbSemaforo.Location = new System.Drawing.Point(43, 29);
            this.pcbSemaforo.Name = "pcbSemaforo";
            this.pcbSemaforo.Size = new System.Drawing.Size(194, 337);
            this.pcbSemaforo.TabIndex = 8;
            this.pcbSemaforo.TabStop = false;
            // 
            // ckbApagado
            // 
            this.ckbApagado.AutoSize = true;
            this.ckbApagado.Location = new System.Drawing.Point(277, 59);
            this.ckbApagado.Name = "ckbApagado";
            this.ckbApagado.Size = new System.Drawing.Size(69, 17);
            this.ckbApagado.TabIndex = 9;
            this.ckbApagado.Text = "Apagado";
            this.ckbApagado.UseVisualStyleBackColor = true;
            // 
            // ckbRojo
            // 
            this.ckbRojo.AutoSize = true;
            this.ckbRojo.Location = new System.Drawing.Point(277, 95);
            this.ckbRojo.Name = "ckbRojo";
            this.ckbRojo.Size = new System.Drawing.Size(48, 17);
            this.ckbRojo.TabIndex = 10;
            this.ckbRojo.Text = "Rojo";
            this.ckbRojo.UseVisualStyleBackColor = true;
            // 
            // ckbRojoIntermitente
            // 
            this.ckbRojoIntermitente.AutoSize = true;
            this.ckbRojoIntermitente.Location = new System.Drawing.Point(360, 95);
            this.ckbRojoIntermitente.Name = "ckbRojoIntermitente";
            this.ckbRojoIntermitente.Size = new System.Drawing.Size(106, 17);
            this.ckbRojoIntermitente.TabIndex = 11;
            this.ckbRojoIntermitente.Text = "Rojo Intermitente";
            this.ckbRojoIntermitente.UseVisualStyleBackColor = true;
            // 
            // ckbAmarillo
            // 
            this.ckbAmarillo.AutoSize = true;
            this.ckbAmarillo.Location = new System.Drawing.Point(277, 133);
            this.ckbAmarillo.Name = "ckbAmarillo";
            this.ckbAmarillo.Size = new System.Drawing.Size(62, 17);
            this.ckbAmarillo.TabIndex = 12;
            this.ckbAmarillo.Text = "Amarillo";
            this.ckbAmarillo.UseVisualStyleBackColor = true;
            // 
            // ckbAmarilloIntermitente
            // 
            this.ckbAmarilloIntermitente.AutoSize = true;
            this.ckbAmarilloIntermitente.Location = new System.Drawing.Point(360, 133);
            this.ckbAmarilloIntermitente.Name = "ckbAmarilloIntermitente";
            this.ckbAmarilloIntermitente.Size = new System.Drawing.Size(120, 17);
            this.ckbAmarilloIntermitente.TabIndex = 13;
            this.ckbAmarilloIntermitente.Text = "Amarillo Intermitente";
            this.ckbAmarilloIntermitente.UseVisualStyleBackColor = true;
            // 
            // ckbVerde
            // 
            this.ckbVerde.AutoSize = true;
            this.ckbVerde.Location = new System.Drawing.Point(277, 172);
            this.ckbVerde.Name = "ckbVerde";
            this.ckbVerde.Size = new System.Drawing.Size(54, 17);
            this.ckbVerde.TabIndex = 14;
            this.ckbVerde.Text = "Verde";
            this.ckbVerde.UseVisualStyleBackColor = true;
            // 
            // ckbVerdeIntermitente
            // 
            this.ckbVerdeIntermitente.AutoSize = true;
            this.ckbVerdeIntermitente.Location = new System.Drawing.Point(360, 172);
            this.ckbVerdeIntermitente.Name = "ckbVerdeIntermitente";
            this.ckbVerdeIntermitente.Size = new System.Drawing.Size(112, 17);
            this.ckbVerdeIntermitente.TabIndex = 15;
            this.ckbVerdeIntermitente.Text = "Verde Intermitente";
            this.ckbVerdeIntermitente.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 576);
            this.Controls.Add(this.ckbVerdeIntermitente);
            this.Controls.Add(this.ckbVerde);
            this.Controls.Add(this.ckbAmarilloIntermitente);
            this.Controls.Add(this.ckbAmarillo);
            this.Controls.Add(this.ckbRojoIntermitente);
            this.Controls.Add(this.ckbRojo);
            this.Controls.Add(this.ckbApagado);
            this.Controls.Add(this.pcbSemaforo);
            this.Name = "Vista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista";
            ((System.ComponentModel.ISupportInitialize)(this.pcbSemaforo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbSemaforo;
        private System.Windows.Forms.CheckBox ckbApagado;
        private System.Windows.Forms.CheckBox ckbRojo;
        private System.Windows.Forms.CheckBox ckbRojoIntermitente;
        private System.Windows.Forms.CheckBox ckbAmarillo;
        private System.Windows.Forms.CheckBox ckbAmarilloIntermitente;
        private System.Windows.Forms.CheckBox ckbVerde;
        private System.Windows.Forms.CheckBox ckbVerdeIntermitente;
        private System.Windows.Forms.Timer timer1;
    }
}