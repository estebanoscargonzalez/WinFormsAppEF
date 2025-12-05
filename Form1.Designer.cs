namespace WinFormsAppEF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelId = new Label();
            labelNombre = new Label();
            labelDescripcion = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            dgvDatos = new DataGridView();
            btnEliminar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(204, 29);
            labelId.Name = "labelId";
            labelId.Size = new Size(20, 15);
            labelId.TabIndex = 0;
            labelId.Text = "Id:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(170, 92);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(54, 15);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre:";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(152, 155);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(72, 15);
            labelDescripcion.TabIndex = 2;
            labelDescripcion.Text = "Descripcion:";
            // 
            // txtId
            // 
            txtId.AccessibleName = "";
            txtId.Location = new Point(230, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(240, 23);
            txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.AccessibleName = "";
            txtNombre.Location = new Point(230, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(240, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.AccessibleName = "";
            txtDescripcion.Location = new Point(230, 152);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(240, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.AccessibleName = "";
            btnAgregar.Location = new Point(483, 152);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(35, 225);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(736, 199);
            dgvDatos.TabIndex = 7;
            dgvDatos.CellClick += dgvDatos_CellClick;
            dgvDatos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(483, 26);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(483, 89);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvDatos);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(labelDescripcion);
            Controls.Add(labelNombre);
            Controls.Add(labelId);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelId;
        private Label labelNombre;
        private Label labelDescripcion;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Button btnAgregar;
        private DataGridView dgvDatos;
        private Button btnEliminar;
        private Button btnActualizar;
    }
}
