namespace project_u5.view
{
    partial class frmAddUpdateInventarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbInventarios = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbSerie = new System.Windows.Forms.Label();
            this.lbFechaAd = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboAreas = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbAreas = new System.Windows.Forms.Label();
            this.lbObservaciones = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.mcFecha = new System.Windows.Forms.MonthCalendar();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lbInventarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 52);
            this.panel1.TabIndex = 62;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(769, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 34);
            this.btnClose.TabIndex = 140;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lbInventarios
            // 
            this.lbInventarios.AutoSize = true;
            this.lbInventarios.BackColor = System.Drawing.Color.Gray;
            this.lbInventarios.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInventarios.ForeColor = System.Drawing.SystemColors.Window;
            this.lbInventarios.Location = new System.Drawing.Point(10, 9);
            this.lbInventarios.Name = "lbInventarios";
            this.lbInventarios.Size = new System.Drawing.Size(133, 25);
            this.lbInventarios.TabIndex = 1;
            this.lbInventarios.Text = "Inventarios";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lbNombre.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.lbNombre.Location = new System.Drawing.Point(11, 82);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(64, 21);
            this.lbNombre.TabIndex = 141;
            this.lbNombre.Text = "Nombre";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lbDescripcion.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.ForeColor = System.Drawing.SystemColors.Window;
            this.lbDescripcion.Location = new System.Drawing.Point(11, 118);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(109, 21);
            this.lbDescripcion.TabIndex = 145;
            this.lbDescripcion.Text = "Descripción";
            // 
            // lbSerie
            // 
            this.lbSerie.AutoSize = true;
            this.lbSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lbSerie.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSerie.ForeColor = System.Drawing.SystemColors.Window;
            this.lbSerie.Location = new System.Drawing.Point(11, 174);
            this.lbSerie.Name = "lbSerie";
            this.lbSerie.Size = new System.Drawing.Size(55, 21);
            this.lbSerie.TabIndex = 144;
            this.lbSerie.Text = "Serie";
            // 
            // lbFechaAd
            // 
            this.lbFechaAd.AutoSize = true;
            this.lbFechaAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lbFechaAd.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaAd.ForeColor = System.Drawing.SystemColors.Window;
            this.lbFechaAd.Location = new System.Drawing.Point(11, 203);
            this.lbFechaAd.Name = "lbFechaAd";
            this.lbFechaAd.Size = new System.Drawing.Size(91, 21);
            this.lbFechaAd.TabIndex = 146;
            this.lbFechaAd.Text = "Fecha ad.";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDescripcion.Location = new System.Drawing.Point(135, 118);
            this.txtDescripcion.MaxLength = 45;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(656, 26);
            this.txtDescripcion.TabIndex = 143;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNombre.Location = new System.Drawing.Point(135, 82);
            this.txtNombre.MaxLength = 45;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 26);
            this.txtNombre.TabIndex = 142;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboAreas
            // 
            this.cboAreas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cboAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAreas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboAreas.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAreas.ForeColor = System.Drawing.SystemColors.Menu;
            this.cboAreas.FormattingEnabled = true;
            this.cboAreas.Location = new System.Drawing.Point(135, 386);
            this.cboAreas.MaxDropDownItems = 6;
            this.cboAreas.Name = "cboAreas";
            this.cboAreas.Size = new System.Drawing.Size(248, 25);
            this.cboAreas.TabIndex = 147;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.Gray;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAceptar.Location = new System.Drawing.Point(281, 472);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(210, 34);
            this.btnAceptar.TabIndex = 148;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbAreas
            // 
            this.lbAreas.AutoSize = true;
            this.lbAreas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lbAreas.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAreas.ForeColor = System.Drawing.SystemColors.Window;
            this.lbAreas.Location = new System.Drawing.Point(11, 386);
            this.lbAreas.Name = "lbAreas";
            this.lbAreas.Size = new System.Drawing.Size(55, 21);
            this.lbAreas.TabIndex = 149;
            this.lbAreas.Text = "Áreas";
            // 
            // lbObservaciones
            // 
            this.lbObservaciones.AutoSize = true;
            this.lbObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lbObservaciones.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObservaciones.ForeColor = System.Drawing.SystemColors.Window;
            this.lbObservaciones.Location = new System.Drawing.Point(2, 426);
            this.lbObservaciones.Name = "lbObservaciones";
            this.lbObservaciones.Size = new System.Drawing.Size(127, 21);
            this.lbObservaciones.TabIndex = 150;
            this.lbObservaciones.Text = "Observaciones";
            // 
            // txtSerie
            // 
            this.txtSerie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerie.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSerie.Location = new System.Drawing.Point(135, 174);
            this.txtSerie.MaxLength = 45;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(248, 26);
            this.txtSerie.TabIndex = 151;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mcFecha
            // 
            this.mcFecha.Location = new System.Drawing.Point(135, 212);
            this.mcFecha.Name = "mcFecha";
            this.mcFecha.TabIndex = 152;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtObservaciones.Location = new System.Drawing.Point(135, 426);
            this.txtObservaciones.MaxLength = 45;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(656, 26);
            this.txtObservaciones.TabIndex = 153;
            this.txtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lbColor.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.ForeColor = System.Drawing.SystemColors.Window;
            this.lbColor.Location = new System.Drawing.Point(409, 212);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(55, 21);
            this.lbColor.TabIndex = 154;
            this.lbColor.Text = "Color";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lbTipo.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbTipo.Location = new System.Drawing.Point(409, 264);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(154, 21);
            this.lbTipo.TabIndex = 155;
            this.lbTipo.Text = "Tipo Adquisición";
            // 
            // cboTipo
            // 
            this.cboTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboTipo.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.ForeColor = System.Drawing.SystemColors.Menu;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Directa",
            "Indirecta"});
            this.cboTipo.Location = new System.Drawing.Point(569, 264);
            this.cboTipo.MaxDropDownItems = 6;
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(248, 25);
            this.cboTipo.TabIndex = 156;
            // 
            // txtColor
            // 
            this.txtColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtColor.Location = new System.Drawing.Point(569, 212);
            this.txtColor.MaxLength = 45;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(248, 26);
            this.txtColor.TabIndex = 157;
            this.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAddUpdateInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(832, 518);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.mcFecha);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lbObservaciones);
            this.Controls.Add(this.lbAreas);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbSerie);
            this.Controls.Add(this.lbFechaAd);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cboAreas);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateInventarios";
            this.Text = "Transactions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbInventarios;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbSerie;
        private System.Windows.Forms.Label lbFechaAd;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboAreas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbObservaciones;
        private System.Windows.Forms.Label lbAreas;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.MonthCalendar mcFecha;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.TextBox txtColor;
    }
}