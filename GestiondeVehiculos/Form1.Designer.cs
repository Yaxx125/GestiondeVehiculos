namespace GestiondeVehiculos
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
            btnAgregar = new Button();
            btnIniciar = new Button();
            btnMoverse = new Button();
            btnCargarBateria = new Button();
            btnDetenerse = new Button();
            label1 = new Label();
            lblMarca = new Label();
            lblModelo = new Label();
            lstMostrarVehiculos = new ListBox();
            lblCapacidadCarga = new Label();
            lblBateria = new Label();
            label2 = new Label();
            cboTipoVehiculo = new ComboBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtCarga = new TextBox();
            txtBateria = new TextBox();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(553, 119);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(145, 34);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(555, 172);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(143, 34);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnMoverse
            // 
            btnMoverse.Location = new Point(555, 217);
            btnMoverse.Name = "btnMoverse";
            btnMoverse.Size = new Size(145, 34);
            btnMoverse.TabIndex = 2;
            btnMoverse.Text = "Moverse";
            btnMoverse.UseVisualStyleBackColor = true;
            btnMoverse.Click += btnMoverse_Click;
            // 
            // btnCargarBateria
            // 
            btnCargarBateria.Location = new Point(555, 310);
            btnCargarBateria.Name = "btnCargarBateria";
            btnCargarBateria.Size = new Size(145, 34);
            btnCargarBateria.TabIndex = 3;
            btnCargarBateria.Text = "Cargar Bateria";
            btnCargarBateria.UseVisualStyleBackColor = true;
            btnCargarBateria.Click += btnCargarBateria_Click;
            // 
            // btnDetenerse
            // 
            btnDetenerse.Location = new Point(555, 262);
            btnDetenerse.Name = "btnDetenerse";
            btnDetenerse.Size = new Size(145, 34);
            btnDetenerse.TabIndex = 4;
            btnDetenerse.Text = "Detenerse";
            btnDetenerse.UseVisualStyleBackColor = true;
            btnDetenerse.Click += btnDetenerse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 102);
            label1.Name = "label1";
            label1.Size = new Size(185, 30);
            label1.TabIndex = 5;
            label1.Text = "Tipo de Vehiculo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(89, 150);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(84, 30);
            lblMarca.TabIndex = 6;
            lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModelo.Location = new Point(89, 193);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(98, 30);
            lblModelo.TabIndex = 7;
            lblModelo.Text = "Modelo:";
            // 
            // lstMostrarVehiculos
            // 
            lstMostrarVehiculos.FormattingEnabled = true;
            lstMostrarVehiculos.ItemHeight = 25;
            lstMostrarVehiculos.Location = new Point(89, 412);
            lstMostrarVehiculos.Name = "lstMostrarVehiculos";
            lstMostrarVehiculos.Size = new Size(609, 129);
            lstMostrarVehiculos.TabIndex = 9;
            lstMostrarVehiculos.SelectedIndexChanged += btnAgregar_Click;
            // 
            // lblCapacidadCarga
            // 
            lblCapacidadCarga.AutoSize = true;
            lblCapacidadCarga.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCapacidadCarga.Location = new Point(59, 262);
            lblCapacidadCarga.Name = "lblCapacidadCarga";
            lblCapacidadCarga.Size = new Size(224, 30);
            lblCapacidadCarga.TabIndex = 10;
            lblCapacidadCarga.Text = "Capacidad de carga:";
            // 
            // lblBateria
            // 
            lblBateria.AutoSize = true;
            lblBateria.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBateria.Location = new Point(50, 328);
            lblBateria.Name = "lblBateria";
            lblBateria.Size = new Size(246, 30);
            lblBateria.TabIndex = 11;
            lblBateria.Text = "Capacidad de bateria: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 20);
            label2.Name = "label2";
            label2.Size = new Size(656, 38);
            label2.TabIndex = 12;
            label2.Text = "Gestión de vehiculos para una flota empresarial";
            // 
            // cboTipoVehiculo
            // 
            cboTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoVehiculo.FormattingEnabled = true;
            cboTipoVehiculo.Items.AddRange(new object[] { "Auto", "Camión", "Motocicleta", "Vehiculo Eléctrico" });
            cboTipoVehiculo.Location = new Point(284, 105);
            cboTipoVehiculo.Name = "cboTipoVehiculo";
            cboTipoVehiculo.Size = new Size(182, 33);
            cboTipoVehiculo.TabIndex = 13;
            cboTipoVehiculo.SelectedIndexChanged += cboTipoVehiculo_SelectedIndexChanged;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(284, 149);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(182, 31);
            txtMarca.TabIndex = 14;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(284, 194);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(182, 31);
            txtModelo.TabIndex = 15;
            // 
            // txtCarga
            // 
            txtCarga.Location = new Point(302, 265);
            txtCarga.Name = "txtCarga";
            txtCarga.Size = new Size(150, 31);
            txtCarga.TabIndex = 17;
            // 
            // txtBateria
            // 
            txtBateria.Location = new Point(302, 329);
            txtBateria.Name = "txtBateria";
            txtBateria.Size = new Size(150, 31);
            txtBateria.TabIndex = 18;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(568, 365);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(btnLimpiar);
            Controls.Add(txtBateria);
            Controls.Add(txtCarga);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(cboTipoVehiculo);
            Controls.Add(label2);
            Controls.Add(lblBateria);
            Controls.Add(lblCapacidadCarga);
            Controls.Add(lstMostrarVehiculos);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(label1);
            Controls.Add(btnDetenerse);
            Controls.Add(btnCargarBateria);
            Controls.Add(btnMoverse);
            Controls.Add(btnIniciar);
            Controls.Add(btnAgregar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnIniciar;
        private Button btnMoverse;
        private Button btnCargarBateria;
        private Button btnDetenerse;
        private Label label1;
        private Label lblMarca;
        private Label lblModelo;
        private ListBox lstMostrarVehiculos;
        private Label lblCapacidadCarga;
        private Label lblBateria;
        private Label label2;
        private ComboBox cboTipoVehiculo;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtCarga;
        private TextBox txtBateria;
        private Button btnLimpiar;
    }
}
