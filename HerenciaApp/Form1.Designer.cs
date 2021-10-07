
namespace HerenciaApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdPiso = new System.Windows.Forms.RadioButton();
            this.rdLocal = new System.Windows.Forms.RadioButton();
            this.lblInmueble = new System.Windows.Forms.Label();
            this.txtBoxNroPiso = new System.Windows.Forms.TextBox();
            this.txtBoxNroVentanas = new System.Windows.Forms.TextBox();
            this.lblNroPiso = new System.Windows.Forms.Label();
            this.lblNroVentanas = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtBoxSuperficie = new System.Windows.Forms.TextBox();
            this.lblSuperficie = new System.Windows.Forms.Label();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.txtBoxAntiguedad = new System.Windows.Forms.TextBox();
            this.txtBoxPrecioBase = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdPiso
            // 
            this.rdPiso.AutoSize = true;
            this.rdPiso.Location = new System.Drawing.Point(54, 56);
            this.rdPiso.Name = "rdPiso";
            this.rdPiso.Size = new System.Drawing.Size(45, 17);
            this.rdPiso.TabIndex = 0;
            this.rdPiso.TabStop = true;
            this.rdPiso.Text = "Piso";
            this.rdPiso.UseVisualStyleBackColor = true;
            this.rdPiso.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdLocal
            // 
            this.rdLocal.AutoSize = true;
            this.rdLocal.Location = new System.Drawing.Point(180, 56);
            this.rdLocal.Name = "rdLocal";
            this.rdLocal.Size = new System.Drawing.Size(51, 17);
            this.rdLocal.TabIndex = 1;
            this.rdLocal.TabStop = true;
            this.rdLocal.Text = "Local";
            this.rdLocal.UseVisualStyleBackColor = true;
            this.rdLocal.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblInmueble
            // 
            this.lblInmueble.AutoSize = true;
            this.lblInmueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInmueble.Location = new System.Drawing.Point(12, 27);
            this.lblInmueble.Name = "lblInmueble";
            this.lblInmueble.Size = new System.Drawing.Size(129, 16);
            this.lblInmueble.TabIndex = 2;
            this.lblInmueble.Text = "Tipo de Inmueble";
            // 
            // txtBoxNroPiso
            // 
            this.txtBoxNroPiso.Location = new System.Drawing.Point(54, 107);
            this.txtBoxNroPiso.Name = "txtBoxNroPiso";
            this.txtBoxNroPiso.Size = new System.Drawing.Size(39, 20);
            this.txtBoxNroPiso.TabIndex = 3;
            // 
            // txtBoxNroVentanas
            // 
            this.txtBoxNroVentanas.Location = new System.Drawing.Point(180, 107);
            this.txtBoxNroVentanas.Name = "txtBoxNroVentanas";
            this.txtBoxNroVentanas.Size = new System.Drawing.Size(39, 20);
            this.txtBoxNroVentanas.TabIndex = 4;
            // 
            // lblNroPiso
            // 
            this.lblNroPiso.AutoSize = true;
            this.lblNroPiso.Location = new System.Drawing.Point(51, 91);
            this.lblNroPiso.Name = "lblNroPiso";
            this.lblNroPiso.Size = new System.Drawing.Size(42, 13);
            this.lblNroPiso.TabIndex = 5;
            this.lblNroPiso.Text = "Piso N°";
            this.lblNroPiso.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNroVentanas
            // 
            this.lblNroVentanas.AutoSize = true;
            this.lblNroVentanas.Location = new System.Drawing.Point(177, 91);
            this.lblNroVentanas.Name = "lblNroVentanas";
            this.lblNroVentanas.Size = new System.Drawing.Size(82, 13);
            this.lblNroVentanas.TabIndex = 6;
            this.lblNroVentanas.Text = "N° de Ventanas";
            this.lblNroVentanas.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(25, 157);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Dirección";
            this.lblDireccion.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(28, 173);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(177, 20);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtBoxSuperficie
            // 
            this.txtBoxSuperficie.Location = new System.Drawing.Point(28, 232);
            this.txtBoxSuperficie.Name = "txtBoxSuperficie";
            this.txtBoxSuperficie.Size = new System.Drawing.Size(38, 20);
            this.txtBoxSuperficie.TabIndex = 9;
            // 
            // lblSuperficie
            // 
            this.lblSuperficie.AutoSize = true;
            this.lblSuperficie.Location = new System.Drawing.Point(25, 216);
            this.lblSuperficie.Name = "lblSuperficie";
            this.lblSuperficie.Size = new System.Drawing.Size(54, 13);
            this.lblSuperficie.TabIndex = 10;
            this.lblSuperficie.Text = "Superficie";
            this.lblSuperficie.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(112, 216);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(61, 13);
            this.lblAntiguedad.TabIndex = 11;
            this.lblAntiguedad.Text = "Antiguedad";
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Location = new System.Drawing.Point(196, 216);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(64, 13);
            this.lblPrecioBase.TabIndex = 12;
            this.lblPrecioBase.Text = "Precio Base";
            this.lblPrecioBase.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtBoxAntiguedad
            // 
            this.txtBoxAntiguedad.Location = new System.Drawing.Point(115, 232);
            this.txtBoxAntiguedad.Name = "txtBoxAntiguedad";
            this.txtBoxAntiguedad.Size = new System.Drawing.Size(26, 20);
            this.txtBoxAntiguedad.TabIndex = 13;
            // 
            // txtBoxPrecioBase
            // 
            this.txtBoxPrecioBase.Location = new System.Drawing.Point(199, 232);
            this.txtBoxPrecioBase.Name = "txtBoxPrecioBase";
            this.txtBoxPrecioBase.Size = new System.Drawing.Size(61, 20);
            this.txtBoxPrecioBase.TabIndex = 14;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCalcular.Location = new System.Drawing.Point(28, 272);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(231, 34);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular Precio Final";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "m2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "años";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(282, 373);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtBoxPrecioBase);
            this.Controls.Add(this.txtBoxAntiguedad);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.lblAntiguedad);
            this.Controls.Add(this.lblSuperficie);
            this.Controls.Add(this.txtBoxSuperficie);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNroVentanas);
            this.Controls.Add(this.lblNroPiso);
            this.Controls.Add(this.txtBoxNroVentanas);
            this.Controls.Add(this.txtBoxNroPiso);
            this.Controls.Add(this.lblInmueble);
            this.Controls.Add(this.rdLocal);
            this.Controls.Add(this.rdPiso);
            this.Name = "Form1";
            this.Text = "Venta de Inmueble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdPiso;
        private System.Windows.Forms.RadioButton rdLocal;
        private System.Windows.Forms.Label lblInmueble;
        private System.Windows.Forms.TextBox txtBoxNroPiso;
        private System.Windows.Forms.TextBox txtBoxNroVentanas;
        private System.Windows.Forms.Label lblNroPiso;
        private System.Windows.Forms.Label lblNroVentanas;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtBoxSuperficie;
        private System.Windows.Forms.Label lblSuperficie;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.TextBox txtBoxAntiguedad;
        private System.Windows.Forms.TextBox txtBoxPrecioBase;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

