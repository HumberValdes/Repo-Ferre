namespace FERRETERÍA
{
    partial class FrmFabricante
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
            this.BtnIsertar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDFabricante = new System.Windows.Forms.TextBox();
            this.GrvFabricante = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrvFabricante)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIsertar
            // 
            this.BtnIsertar.Location = new System.Drawing.Point(26, 43);
            this.BtnIsertar.Name = "BtnIsertar";
            this.BtnIsertar.Size = new System.Drawing.Size(75, 23);
            this.BtnIsertar.TabIndex = 0;
            this.BtnIsertar.Text = "INSERTAR";
            this.BtnIsertar.UseVisualStyleBackColor = true;
            this.BtnIsertar.Click += new System.EventHandler(this.BtnIsertar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(26, 125);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(674, 43);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(330, 321);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(122, 23);
            this.BtnActualizar.TabIndex = 3;
            this.BtnActualizar.Text = "ACTUALIZAR TABLA";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(146, 89);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(100, 20);
            this.txtFabricante.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(290, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtIDFabricante
            // 
            this.txtIDFabricante.Location = new System.Drawing.Point(659, 89);
            this.txtIDFabricante.Name = "txtIDFabricante";
            this.txtIDFabricante.Size = new System.Drawing.Size(100, 20);
            this.txtIDFabricante.TabIndex = 6;
            // 
            // GrvFabricante
            // 
            this.GrvFabricante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvFabricante.Location = new System.Drawing.Point(249, 165);
            this.GrvFabricante.Name = "GrvFabricante";
            this.GrvFabricante.Size = new System.Drawing.Size(285, 150);
            this.GrvFabricante.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Iserta ID ejemplo (ABCD)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Inserta Nombre ejemplo (CEMEX S.A.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Iserta ID ejemplo (ABCD)";
            // 
            // FrmFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrvFabricante);
            this.Controls.Add(this.txtIDFabricante);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnIsertar);
            this.Name = "FrmFabricante";
            this.Text = "FABRICANTES";
            ((System.ComponentModel.ISupportInitialize)(this.GrvFabricante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIsertar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIDFabricante;
        private System.Windows.Forms.DataGridView GrvFabricante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}