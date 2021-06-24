
namespace ejercicio_4
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_agregarnombre = new System.Windows.Forms.Button();
            this.lista1 = new System.Windows.Forms.ListBox();
            this.lista2 = new System.Windows.Forms.ListBox();
            this.cbx_edadynombre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ordenar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_agregaredad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(63, 75);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(181, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(307, 75);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(181, 20);
            this.txt_edad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "INGRESE EL NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "INGRESE LA EDAD";
            // 
            // btn_agregarnombre
            // 
            this.btn_agregarnombre.Location = new System.Drawing.Point(63, 101);
            this.btn_agregarnombre.Name = "btn_agregarnombre";
            this.btn_agregarnombre.Size = new System.Drawing.Size(181, 23);
            this.btn_agregarnombre.TabIndex = 4;
            this.btn_agregarnombre.Text = "AGREGAR";
            this.btn_agregarnombre.UseVisualStyleBackColor = true;
            this.btn_agregarnombre.Click += new System.EventHandler(this.btn_ingresanombre_Click);
            // 
            // lista1
            // 
            this.lista1.FormattingEnabled = true;
            this.lista1.Location = new System.Drawing.Point(63, 138);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(181, 95);
            this.lista1.TabIndex = 6;
            // 
            // lista2
            // 
            this.lista2.FormattingEnabled = true;
            this.lista2.Location = new System.Drawing.Point(307, 130);
            this.lista2.Name = "lista2";
            this.lista2.Size = new System.Drawing.Size(181, 95);
            this.lista2.TabIndex = 7;
            // 
            // cbx_edadynombre
            // 
            this.cbx_edadynombre.FormattingEnabled = true;
            this.cbx_edadynombre.Location = new System.Drawing.Point(63, 273);
            this.cbx_edadynombre.Name = "cbx_edadynombre";
            this.cbx_edadynombre.Size = new System.Drawing.Size(181, 21);
            this.cbx_edadynombre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "NOMBRE Y EDAD";
            // 
            // btn_ordenar
            // 
            this.btn_ordenar.Location = new System.Drawing.Point(307, 273);
            this.btn_ordenar.Name = "btn_ordenar";
            this.btn_ordenar.Size = new System.Drawing.Size(181, 23);
            this.btn_ordenar.TabIndex = 10;
            this.btn_ordenar.Text = "ORDENAR";
            this.btn_ordenar.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(307, 326);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(181, 23);
            this.btn_limpiar.TabIndex = 11;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_agregaredad
            // 
            this.btn_agregaredad.Location = new System.Drawing.Point(307, 101);
            this.btn_agregaredad.Name = "btn_agregaredad";
            this.btn_agregaredad.Size = new System.Drawing.Size(181, 23);
            this.btn_agregaredad.TabIndex = 12;
            this.btn_agregaredad.Text = "AGREGAR";
            this.btn_agregaredad.UseVisualStyleBackColor = true;
            this.btn_agregaredad.Click += new System.EventHandler(this.btn_agregaredad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.btn_agregaredad);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_ordenar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_edadynombre);
            this.Controls.Add(this.lista2);
            this.Controls.Add(this.lista1);
            this.Controls.Add(this.btn_agregarnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_agregarnombre;
        private System.Windows.Forms.ListBox lista1;
        private System.Windows.Forms.ListBox lista2;
        private System.Windows.Forms.ComboBox cbx_edadynombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ordenar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_agregaredad;
    }
}

