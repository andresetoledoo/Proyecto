
namespace Proyecto
{
    partial class ModificarAnimal
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
            this.btConfirmar = new System.Windows.Forms.Button();
            this.tbRaza = new System.Windows.Forms.TextBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.tbDetalles = new System.Windows.Forms.TextBox();
            this.cbTamaño = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbDetalles = new System.Windows.Forms.Label();
            this.lbTamaño = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbRaza = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adopcionDAJDataSet3 = new Proyecto.AdopcionDAJDataSet3();
            this.animalTableAdapter = new Proyecto.AdopcionDAJDataSet3TableAdapters.AnimalTableAdapter();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.buttonFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adopcionDAJDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.LightSalmon;
            this.btConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.ForeColor = System.Drawing.SystemColors.Control;
            this.btConfirmar.Location = new System.Drawing.Point(1385, 568);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(250, 58);
            this.btConfirmar.TabIndex = 37;
            this.btConfirmar.Text = "Confirmar edición";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // tbRaza
            // 
            this.tbRaza.BackColor = System.Drawing.SystemColors.Control;
            this.tbRaza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRaza.Enabled = false;
            this.tbRaza.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRaza.Location = new System.Drawing.Point(736, 338);
            this.tbRaza.MaxLength = 50;
            this.tbRaza.Name = "tbRaza";
            this.tbRaza.Size = new System.Drawing.Size(287, 33);
            this.tbRaza.TabIndex = 36;
            this.tbRaza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRaza_KeyPress);
            // 
            // cbColor
            // 
            this.cbColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.Enabled = false;
            this.cbColor.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "",
            "Negro",
            "Blanco",
            "Gris",
            "Cafe",
            "Amarillo",
            "Dorado"});
            this.cbColor.Location = new System.Drawing.Point(736, 507);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(287, 41);
            this.cbColor.TabIndex = 35;
            // 
            // tbDetalles
            // 
            this.tbDetalles.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDetalles.Location = new System.Drawing.Point(1139, 291);
            this.tbDetalles.MaxLength = 500;
            this.tbDetalles.Multiline = true;
            this.tbDetalles.Name = "tbDetalles";
            this.tbDetalles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDetalles.Size = new System.Drawing.Size(496, 170);
            this.tbDetalles.TabIndex = 34;
            // 
            // cbTamaño
            // 
            this.cbTamaño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTamaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTamaño.Enabled = false;
            this.cbTamaño.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTamaño.FormattingEnabled = true;
            this.cbTamaño.Items.AddRange(new object[] {
            "",
            "Chico",
            "Mediano",
            "Grande"});
            this.cbTamaño.Location = new System.Drawing.Point(1348, 173);
            this.cbTamaño.Name = "cbTamaño";
            this.cbTamaño.Size = new System.Drawing.Size(287, 41);
            this.cbTamaño.TabIndex = 33;
            // 
            // cbTipo
            // 
            this.cbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Enabled = false;
            this.cbTipo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "",
            "Perro",
            "Gato"});
            this.cbTipo.Location = new System.Drawing.Point(736, 254);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(287, 41);
            this.cbTipo.TabIndex = 32;
            // 
            // cbSexo
            // 
            this.cbSexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Enabled = false;
            this.cbSexo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "",
            "Macho",
            "Hembra"});
            this.cbSexo.Location = new System.Drawing.Point(736, 420);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(287, 41);
            this.cbSexo.TabIndex = 31;
            // 
            // tbEdad
            // 
            this.tbEdad.BackColor = System.Drawing.SystemColors.Control;
            this.tbEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEdad.Enabled = false;
            this.tbEdad.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdad.Location = new System.Drawing.Point(1348, 88);
            this.tbEdad.MaxLength = 2;
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(287, 33);
            this.tbEdad.TabIndex = 30;
            this.tbEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEdad_KeyPress);
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.Control;
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombre.Enabled = false;
            this.tbNombre.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(736, 170);
            this.tbNombre.MaxLength = 50;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(287, 33);
            this.tbNombre.TabIndex = 29;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // lbDetalles
            // 
            this.lbDetalles.AutoSize = true;
            this.lbDetalles.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetalles.Location = new System.Drawing.Point(1133, 243);
            this.lbDetalles.Name = "lbDetalles";
            this.lbDetalles.Size = new System.Drawing.Size(110, 33);
            this.lbDetalles.TabIndex = 28;
            this.lbDetalles.Text = "Detalles:";
            // 
            // lbTamaño
            // 
            this.lbTamaño.AutoSize = true;
            this.lbTamaño.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTamaño.Location = new System.Drawing.Point(1133, 173);
            this.lbTamaño.Name = "lbTamaño";
            this.lbTamaño.Size = new System.Drawing.Size(109, 33);
            this.lbTamaño.TabIndex = 27;
            this.lbTamaño.Text = "Tamaño:";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad.Location = new System.Drawing.Point(1133, 88);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(76, 33);
            this.lbEdad.TabIndex = 26;
            this.lbEdad.Text = "Edad:";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.Location = new System.Drawing.Point(521, 504);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(79, 33);
            this.lbColor.TabIndex = 25;
            this.lbColor.Text = "Color:";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.Location = new System.Drawing.Point(521, 420);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(72, 33);
            this.lbSexo.TabIndex = 24;
            this.lbSexo.Text = "Sexo:";
            // 
            // lbRaza
            // 
            this.lbRaza.AutoSize = true;
            this.lbRaza.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRaza.Location = new System.Drawing.Point(520, 341);
            this.lbRaza.Name = "lbRaza";
            this.lbRaza.Size = new System.Drawing.Size(74, 33);
            this.lbRaza.TabIndex = 23;
            this.lbRaza.Text = "Raza:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(520, 257);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(69, 33);
            this.lbTipo.TabIndex = 22;
            this.lbTipo.Text = "Tipo:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(520, 173);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(111, 33);
            this.lbNombre.TabIndex = 21;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(520, 88);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(126, 33);
            this.lbId.TabIndex = 39;
            this.lbId.Text = "Id Animal:";
            // 
            // cbId
            // 
            this.cbId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animalBindingSource, "id_animal", true));
            this.cbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbId.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(736, 88);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(287, 41);
            this.cbId.TabIndex = 41;
            this.cbId.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.adopcionDAJDataSet3;
            // 
            // adopcionDAJDataSet3
            // 
            this.adopcionDAJDataSet3.DataSetName = "AdopcionDAJDataSet3";
            this.adopcionDAJDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(23, 88);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(390, 260);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 42;
            this.pictureBoxFoto.TabStop = false;
            // 
            // buttonFoto
            // 
            this.buttonFoto.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFoto.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFoto.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFoto.Location = new System.Drawing.Point(23, 354);
            this.buttonFoto.Name = "buttonFoto";
            this.buttonFoto.Size = new System.Drawing.Size(390, 50);
            this.buttonFoto.TabIndex = 43;
            this.buttonFoto.Text = "Cargar foto";
            this.buttonFoto.UseVisualStyleBackColor = false;
            this.buttonFoto.Click += new System.EventHandler(this.buttonFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(516, 63);
            this.lblTitulo.TabIndex = 44;
            this.lblTitulo.Text = "Modificar datos animal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(736, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 1);
            this.panel1.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(736, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 1);
            this.panel2.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(1348, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 1);
            this.panel3.TabIndex = 47;
            // 
            // btCerrar
            // 
            this.btCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCerrar.FlatAppearance.BorderSize = 0;
            this.btCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCerrar.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrar.ForeColor = System.Drawing.Color.LightSalmon;
            this.btCerrar.Location = new System.Drawing.Point(1632, 7);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(52, 55);
            this.btCerrar.TabIndex = 48;
            this.btCerrar.Text = "X";
            this.btCerrar.UseVisualStyleBackColor = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // ModificarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 658);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.buttonFoto);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.cbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.tbRaza);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.tbDetalles);
            this.Controls.Add(this.cbTamaño);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbDetalles);
            this.Controls.Add(this.lbTamaño);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.lbRaza);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarAnimal";
            this.Load += new System.EventHandler(this.ModificarAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adopcionDAJDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.TextBox tbRaza;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.TextBox tbDetalles;
        private System.Windows.Forms.ComboBox cbTamaño;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbDetalles;
        private System.Windows.Forms.Label lbTamaño;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbRaza;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.ComboBox cbId;
        private AdopcionDAJDataSet3 adopcionDAJDataSet3;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private AdopcionDAJDataSet3TableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button buttonFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btCerrar;
    }
}