
namespace PreExamen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBFechaNac = new System.Windows.Forms.TextBox();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.DGVUni = new System.Windows.Forms.DataGridView();
            this.BTMostrar = new System.Windows.Forms.Button();
            this.BTAgregar = new System.Windows.Forms.Button();
            this.BTActualizar = new System.Windows.Forms.Button();
            this.BTEliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TBID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUni)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(199, 35);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(140, 22);
            this.TBNombre.TabIndex = 4;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(199, 86);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(140, 22);
            this.TBApellido.TabIndex = 5;
            // 
            // TBFechaNac
            // 
            this.TBFechaNac.Location = new System.Drawing.Point(199, 136);
            this.TBFechaNac.Name = "TBFechaNac";
            this.TBFechaNac.Size = new System.Drawing.Size(140, 22);
            this.TBFechaNac.TabIndex = 6;
            // 
            // TBCorreo
            // 
            this.TBCorreo.Location = new System.Drawing.Point(199, 184);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(140, 22);
            this.TBCorreo.TabIndex = 7;
            // 
            // DGVUni
            // 
            this.DGVUni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUni.Location = new System.Drawing.Point(30, 227);
            this.DGVUni.Name = "DGVUni";
            this.DGVUni.RowHeadersWidth = 51;
            this.DGVUni.RowTemplate.Height = 24;
            this.DGVUni.Size = new System.Drawing.Size(758, 213);
            this.DGVUni.TabIndex = 8;
            // 
            // BTMostrar
            // 
            this.BTMostrar.Location = new System.Drawing.Point(40, 456);
            this.BTMostrar.Name = "BTMostrar";
            this.BTMostrar.Size = new System.Drawing.Size(75, 23);
            this.BTMostrar.TabIndex = 9;
            this.BTMostrar.Text = "Mostrar";
            this.BTMostrar.UseVisualStyleBackColor = true;
            this.BTMostrar.Click += new System.EventHandler(this.BTMostrar_Click);
            // 
            // BTAgregar
            // 
            this.BTAgregar.Location = new System.Drawing.Point(446, 32);
            this.BTAgregar.Name = "BTAgregar";
            this.BTAgregar.Size = new System.Drawing.Size(87, 23);
            this.BTAgregar.TabIndex = 10;
            this.BTAgregar.Text = "Agregar";
            this.BTAgregar.UseVisualStyleBackColor = true;
            this.BTAgregar.Click += new System.EventHandler(this.BTAgregar_Click);
            // 
            // BTActualizar
            // 
            this.BTActualizar.Location = new System.Drawing.Point(446, 86);
            this.BTActualizar.Name = "BTActualizar";
            this.BTActualizar.Size = new System.Drawing.Size(87, 22);
            this.BTActualizar.TabIndex = 11;
            this.BTActualizar.Text = "Actualizar";
            this.BTActualizar.UseVisualStyleBackColor = true;
            this.BTActualizar.Click += new System.EventHandler(this.BTActualizar_Click);
            // 
            // BTEliminar
            // 
            this.BTEliminar.Location = new System.Drawing.Point(446, 136);
            this.BTEliminar.Name = "BTEliminar";
            this.BTEliminar.Size = new System.Drawing.Size(87, 22);
            this.BTEliminar.TabIndex = 12;
            this.BTEliminar.Text = "Eliminar";
            this.BTEliminar.UseVisualStyleBackColor = true;
            this.BTEliminar.Click += new System.EventHandler(this.BTEliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID";
            // 
            // TBID
            // 
            this.TBID.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TBID.Location = new System.Drawing.Point(604, 139);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(140, 22);
            this.TBID.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.TBID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTEliminar);
            this.Controls.Add(this.BTActualizar);
            this.Controls.Add(this.BTAgregar);
            this.Controls.Add(this.BTMostrar);
            this.Controls.Add(this.DGVUni);
            this.Controls.Add(this.TBCorreo);
            this.Controls.Add(this.TBFechaNac);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVUni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBFechaNac;
        private System.Windows.Forms.TextBox TBCorreo;
        private System.Windows.Forms.DataGridView DGVUni;
        private System.Windows.Forms.Button BTMostrar;
        private System.Windows.Forms.Button BTAgregar;
        private System.Windows.Forms.Button BTActualizar;
        private System.Windows.Forms.Button BTEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBID;
    }
}

