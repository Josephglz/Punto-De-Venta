namespace Vista
{
    partial class home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.smEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.smProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mRegistros = new System.Windows.Forms.ToolStripMenuItem();
            this.smVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.smReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tablaVentas = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAdministracion,
            this.mRegistros,
            this.mSalir});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1280, 33);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "Menú";
            // 
            // mAdministracion
            // 
            this.mAdministracion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smEmpleados,
            this.smProductos});
            this.mAdministracion.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAdministracion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mAdministracion.Name = "mAdministracion";
            this.mAdministracion.Size = new System.Drawing.Size(155, 29);
            this.mAdministracion.Text = "Administración";
            // 
            // smEmpleados
            // 
            this.smEmpleados.Name = "smEmpleados";
            this.smEmpleados.Size = new System.Drawing.Size(190, 30);
            this.smEmpleados.Text = "Empleados";
            this.smEmpleados.Click += new System.EventHandler(this.smEmpleados_Click);
            // 
            // smProductos
            // 
            this.smProductos.Name = "smProductos";
            this.smProductos.Size = new System.Drawing.Size(190, 30);
            this.smProductos.Text = "Productos";
            this.smProductos.Click += new System.EventHandler(this.smProductos_Click);
            // 
            // mRegistros
            // 
            this.mRegistros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smVentas,
            this.smReportes});
            this.mRegistros.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mRegistros.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mRegistros.Name = "mRegistros";
            this.mRegistros.Size = new System.Drawing.Size(105, 29);
            this.mRegistros.Text = "Registros";
            // 
            // smVentas
            // 
            this.smVentas.Name = "smVentas";
            this.smVentas.Size = new System.Drawing.Size(175, 30);
            this.smVentas.Text = "Ventas";
            // 
            // smReportes
            // 
            this.smReportes.Name = "smReportes";
            this.smReportes.Size = new System.Drawing.Size(175, 30);
            this.smReportes.Text = "Reportes";
            // 
            // mSalir
            // 
            this.mSalir.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSalir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mSalir.Name = "mSalir";
            this.mSalir.Size = new System.Drawing.Size(63, 29);
            this.mSalir.Text = "Salir";
            this.mSalir.Click += new System.EventHandler(this.mSalir_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCodigo.Location = new System.Drawing.Point(30, 65);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(646, 56);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "CODIGO DE BARRAS";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Webdings", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(696, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 56);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "L";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tablaVentas
            // 
            this.tablaVentas.AllowUserToAddRows = false;
            this.tablaVentas.AllowUserToDeleteRows = false;
            this.tablaVentas.AllowUserToResizeColumns = false;
            this.tablaVentas.AllowUserToResizeRows = false;
            this.tablaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.tablaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaVentas.CausesValidation = false;
            this.tablaVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tablaVentas.ColumnHeadersHeight = 30;
            this.tablaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaVentas.DefaultCellStyle = dataGridViewCellStyle10;
            this.tablaVentas.EnableHeadersVisualStyles = false;
            this.tablaVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tablaVentas.Location = new System.Drawing.Point(30, 159);
            this.tablaVentas.MultiSelect = false;
            this.tablaVentas.Name = "tablaVentas";
            this.tablaVentas.ReadOnly = true;
            this.tablaVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tablaVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.tablaVentas.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.tablaVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaVentas.Size = new System.Drawing.Size(739, 514);
            this.tablaVentas.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMas);
            this.flowLayoutPanel1.Controls.Add(this.btnMenos);
            this.flowLayoutPanel1.Controls.Add(this.btnBorrar);
            this.flowLayoutPanel1.Controls.Add(this.btnPagar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(785, 499);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 174);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // btnMas
            // 
            this.btnMas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMas.FlatAppearance.BorderSize = 0;
            this.btnMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMas.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMas.Location = new System.Drawing.Point(3, 3);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(73, 56);
            this.btnMas.TabIndex = 4;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = false;
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMenos.FlatAppearance.BorderSize = 0;
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenos.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenos.Location = new System.Drawing.Point(82, 3);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(73, 56);
            this.btnMenos.TabIndex = 5;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBorrar.Location = new System.Drawing.Point(161, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(73, 56);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "X";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnPagar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPagar.Location = new System.Drawing.Point(3, 65);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(231, 56);
            this.btnPagar.TabIndex = 7;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tablaVentas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mAdministracion;
        private System.Windows.Forms.ToolStripMenuItem smEmpleados;
        private System.Windows.Forms.ToolStripMenuItem smProductos;
        private System.Windows.Forms.ToolStripMenuItem mRegistros;
        private System.Windows.Forms.ToolStripMenuItem smVentas;
        private System.Windows.Forms.ToolStripMenuItem smReportes;
        private System.Windows.Forms.ToolStripMenuItem mSalir;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView tablaVentas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnPagar;
    }
}