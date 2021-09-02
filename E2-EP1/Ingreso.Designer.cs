namespace E2_EP1
{
    partial class Ingreso
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
            this.Voto = new System.Windows.Forms.Label();
            this.btnregresar = new System.Windows.Forms.Button();
            this.rtxtVotos = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso de Botaciones";
            // 
            // Voto
            // 
            this.Voto.AutoSize = true;
            this.Voto.Location = new System.Drawing.Point(12, 75);
            this.Voto.Name = "Voto";
            this.Voto.Size = new System.Drawing.Size(35, 13);
            this.Voto.TabIndex = 1;
            this.Voto.Text = "Voto: ";
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(420, 279);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(121, 23);
            this.btnregresar.TabIndex = 3;
            this.btnregresar.Text = "Atras";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // rtxtVotos
            // 
            this.rtxtVotos.Location = new System.Drawing.Point(12, 99);
            this.rtxtVotos.Name = "rtxtVotos";
            this.rtxtVotos.Size = new System.Drawing.Size(382, 214);
            this.rtxtVotos.TabIndex = 4;
            this.rtxtVotos.Text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(420, 180);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(420, 97);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(121, 23);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "Ver votos";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnDescartar
            // 
            this.btnDescartar.Location = new System.Drawing.Point(420, 139);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(121, 23);
            this.btnDescartar.TabIndex = 7;
            this.btnDescartar.Text = "Descartar cambios";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 333);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rtxtVotos);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.Voto);
            this.Controls.Add(this.label1);
            this.Name = "Ingreso";
            this.Text = "Ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Voto;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.RichTextBox rtxtVotos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnDescartar;
    }
}