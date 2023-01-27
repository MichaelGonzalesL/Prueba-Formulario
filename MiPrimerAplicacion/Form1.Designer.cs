namespace MiPrimerAplicacion
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
            this.btnRun = new System.Windows.Forms.Button();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Image = global::MiPrimerAplicacion.Properties.Resources.icons8_ejercicio_16;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRun.Location = new System.Drawing.Point(56, 80);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(91, 36);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEtiqueta.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.Color.Maroon;
            this.lblEtiqueta.Location = new System.Drawing.Point(205, 90);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(91, 26);
            this.lblEtiqueta.TabIndex = 1;
            this.lblEtiqueta.Text = "Etiqueta";
            this.lblEtiqueta.MouseLeave += new System.EventHandler(this.lblEtiqueta_MouseLeave);
            this.lblEtiqueta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblEtiqueta_MouseMove);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(56, 175);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(56, 232);
            this.txtNuevo.Multiline = true;
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNuevo.Size = new System.Drawing.Size(256, 112);
            this.txtNuevo.TabIndex = 3;
            this.txtNuevo.Leave += new System.EventHandler(this.txtNuevo_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.btnRun);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNuevo;
    }
}

