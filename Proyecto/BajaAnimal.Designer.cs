
namespace Proyecto
{
    partial class BajaAnimal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btBaja = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.lbSexo = new System.Windows.Forms.Label();
            this.tbSexo = new System.Windows.Forms.TextBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.lbDetalles = new System.Windows.Forms.Label();
            this.tbDetalles = new System.Windows.Forms.TextBox();
            this.lbFechadeRegistro = new System.Windows.Forms.Label();
            this.tbFechadeRegistro = new System.Windows.Forms.TextBox();
            this.lbTamaño = new System.Windows.Forms.Label();
            this.tbTamaño = new System.Windows.Forms.TextBox();
            this.lbEdad = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamañoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoadopcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adopcionDAJDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adopcionDAJDataSet3 = new Proyecto.AdopcionDAJDataSet3();
            this.animalTableAdapter1 = new Proyecto.AdopcionDAJDataSet3TableAdapters.AnimalTableAdapter();
            this.cbBajaAnimal = new System.Windows.Forms.ComboBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btCerrar = new System.Windows.Forms.Button();
            this.lbRaza = new System.Windows.Forms.Label();
            this.tbRaza = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adopcionDAJDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adopcionDAJDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btBaja
            // 
            this.btBaja.BackColor = System.Drawing.Color.LightSalmon;
            this.btBaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaja.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaja.ForeColor = System.Drawing.SystemColors.Control;
            this.btBaja.Location = new System.Drawing.Point(1366, 282);
            this.btBaja.Name = "btBaja";
            this.btBaja.Size = new System.Drawing.Size(225, 58);
            this.btBaja.TabIndex = 0;
            this.btBaja.Text = "Dar de baja";
            this.btBaja.UseVisualStyleBackColor = false;
            this.btBaja.Click += new System.EventHandler(this.btBaja_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.Control;
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombre.Enabled = false;
            this.tbNombre.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(521, 147);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(227, 30);
            this.tbNombre.TabIndex = 3;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(387, 150);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(104, 33);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Nombre";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(387, 218);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(62, 33);
            this.lbTipo.TabIndex = 6;
            this.lbTipo.Text = "Tipo";
            // 
            // tbTipo
            // 
            this.tbTipo.BackColor = System.Drawing.SystemColors.Control;
            this.tbTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTipo.Enabled = false;
            this.tbTipo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTipo.Location = new System.Drawing.Point(521, 214);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(227, 30);
            this.tbTipo.TabIndex = 5;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.Location = new System.Drawing.Point(845, 84);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(65, 33);
            this.lbSexo.TabIndex = 8;
            this.lbSexo.Text = "Sexo";
            // 
            // tbSexo
            // 
            this.tbSexo.BackColor = System.Drawing.SystemColors.Control;
            this.tbSexo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSexo.Enabled = false;
            this.tbSexo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSexo.Location = new System.Drawing.Point(963, 84);
            this.tbSexo.Name = "tbSexo";
            this.tbSexo.Size = new System.Drawing.Size(227, 30);
            this.tbSexo.TabIndex = 7;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.Location = new System.Drawing.Point(845, 146);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(72, 33);
            this.lbColor.TabIndex = 10;
            this.lbColor.Text = "Color";
            // 
            // tbColor
            // 
            this.tbColor.BackColor = System.Drawing.SystemColors.Control;
            this.tbColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbColor.Enabled = false;
            this.tbColor.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColor.Location = new System.Drawing.Point(963, 147);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(226, 30);
            this.tbColor.TabIndex = 9;
            // 
            // lbDetalles
            // 
            this.lbDetalles.AutoSize = true;
            this.lbDetalles.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetalles.Location = new System.Drawing.Point(1255, 36);
            this.lbDetalles.Name = "lbDetalles";
            this.lbDetalles.Size = new System.Drawing.Size(103, 33);
            this.lbDetalles.TabIndex = 18;
            this.lbDetalles.Text = "Detalles";
            // 
            // tbDetalles
            // 
            this.tbDetalles.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDetalles.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbDetalles.Location = new System.Drawing.Point(1261, 84);
            this.tbDetalles.Multiline = true;
            this.tbDetalles.Name = "tbDetalles";
            this.tbDetalles.ReadOnly = true;
            this.tbDetalles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDetalles.Size = new System.Drawing.Size(330, 171);
            this.tbDetalles.TabIndex = 17;
            // 
            // lbFechadeRegistro
            // 
            this.lbFechadeRegistro.AutoSize = true;
            this.lbFechadeRegistro.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechadeRegistro.Location = new System.Drawing.Point(387, 32);
            this.lbFechadeRegistro.Name = "lbFechadeRegistro";
            this.lbFechadeRegistro.Size = new System.Drawing.Size(201, 33);
            this.lbFechadeRegistro.TabIndex = 16;
            this.lbFechadeRegistro.Text = "Fecha de registro";
            // 
            // tbFechadeRegistro
            // 
            this.tbFechadeRegistro.BackColor = System.Drawing.SystemColors.Control;
            this.tbFechadeRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFechadeRegistro.Enabled = false;
            this.tbFechadeRegistro.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechadeRegistro.Location = new System.Drawing.Point(604, 32);
            this.tbFechadeRegistro.Name = "tbFechadeRegistro";
            this.tbFechadeRegistro.Size = new System.Drawing.Size(353, 30);
            this.tbFechadeRegistro.TabIndex = 15;
            // 
            // lbTamaño
            // 
            this.lbTamaño.AutoSize = true;
            this.lbTamaño.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTamaño.Location = new System.Drawing.Point(845, 218);
            this.lbTamaño.Name = "lbTamaño";
            this.lbTamaño.Size = new System.Drawing.Size(102, 33);
            this.lbTamaño.TabIndex = 14;
            this.lbTamaño.Text = "Tamaño";
            // 
            // tbTamaño
            // 
            this.tbTamaño.BackColor = System.Drawing.SystemColors.Control;
            this.tbTamaño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTamaño.Enabled = false;
            this.tbTamaño.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTamaño.Location = new System.Drawing.Point(963, 214);
            this.tbTamaño.Name = "tbTamaño";
            this.tbTamaño.Size = new System.Drawing.Size(226, 30);
            this.tbTamaño.TabIndex = 13;
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad.Location = new System.Drawing.Point(845, 282);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(69, 33);
            this.lbEdad.TabIndex = 12;
            this.lbEdad.Text = "Edad";
            // 
            // tbEdad
            // 
            this.tbEdad.BackColor = System.Drawing.SystemColors.Control;
            this.tbEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEdad.Enabled = false;
            this.tbEdad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdad.Location = new System.Drawing.Point(963, 278);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(226, 30);
            this.tbEdad.TabIndex = 11;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(387, 88);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(119, 33);
            this.lbId.TabIndex = 21;
            this.lbId.Text = "ID animal";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.colorDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.tamañoDataGridViewTextBoxColumn,
            this.fotoDataGridViewTextBoxColumn,
            this.detallesDataGridViewTextBoxColumn,
            this.fecharegistroDataGridViewTextBoxColumn,
            this.estadoadopcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.animalBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(321, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 270);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_animal";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_animal";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn2.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "raza";
            this.dataGridViewTextBoxColumn4.HeaderText = "raza";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "sexo";
            this.dataGridViewTextBoxColumn5.HeaderText = "sexo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // tamañoDataGridViewTextBoxColumn
            // 
            this.tamañoDataGridViewTextBoxColumn.DataPropertyName = "tamaño";
            this.tamañoDataGridViewTextBoxColumn.HeaderText = "tamaño";
            this.tamañoDataGridViewTextBoxColumn.Name = "tamañoDataGridViewTextBoxColumn";
            // 
            // fotoDataGridViewTextBoxColumn
            // 
            this.fotoDataGridViewTextBoxColumn.DataPropertyName = "foto";
            this.fotoDataGridViewTextBoxColumn.HeaderText = "foto";
            this.fotoDataGridViewTextBoxColumn.Name = "fotoDataGridViewTextBoxColumn";
            this.fotoDataGridViewTextBoxColumn.Visible = false;
            // 
            // detallesDataGridViewTextBoxColumn
            // 
            this.detallesDataGridViewTextBoxColumn.DataPropertyName = "detalles";
            this.detallesDataGridViewTextBoxColumn.HeaderText = "detalles";
            this.detallesDataGridViewTextBoxColumn.Name = "detallesDataGridViewTextBoxColumn";
            this.detallesDataGridViewTextBoxColumn.Visible = false;
            // 
            // fecharegistroDataGridViewTextBoxColumn
            // 
            this.fecharegistroDataGridViewTextBoxColumn.DataPropertyName = "fecha_registro";
            this.fecharegistroDataGridViewTextBoxColumn.HeaderText = "fecha_registro";
            this.fecharegistroDataGridViewTextBoxColumn.Name = "fecharegistroDataGridViewTextBoxColumn";
            this.fecharegistroDataGridViewTextBoxColumn.Visible = false;
            // 
            // estadoadopcionDataGridViewTextBoxColumn
            // 
            this.estadoadopcionDataGridViewTextBoxColumn.DataPropertyName = "estado_adopcion";
            this.estadoadopcionDataGridViewTextBoxColumn.HeaderText = "estado_adopcion";
            this.estadoadopcionDataGridViewTextBoxColumn.Name = "estadoadopcionDataGridViewTextBoxColumn";
            this.estadoadopcionDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.adopcionDAJDataSet3BindingSource;
            // 
            // adopcionDAJDataSet3BindingSource
            // 
            this.adopcionDAJDataSet3BindingSource.DataSource = this.adopcionDAJDataSet3;
            this.adopcionDAJDataSet3BindingSource.Position = 0;
            // 
            // adopcionDAJDataSet3
            // 
            this.adopcionDAJDataSet3.DataSetName = "AdopcionDAJDataSet3";
            this.adopcionDAJDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalTableAdapter1
            // 
            this.animalTableAdapter1.ClearBeforeFill = true;
            // 
            // cbBajaAnimal
            // 
            this.cbBajaAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBajaAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBajaAnimal.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBajaAnimal.FormattingEnabled = true;
            this.cbBajaAnimal.Location = new System.Drawing.Point(521, 84);
            this.cbBajaAnimal.Name = "cbBajaAnimal";
            this.cbBajaAnimal.Size = new System.Drawing.Size(227, 37);
            this.cbBajaAnimal.TabIndex = 24;
            this.cbBajaAnimal.SelectedIndexChanged += new System.EventHandler(this.cbBajaAnimal_SelectedIndexChanged);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(23, 88);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(329, 227);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 25;
            this.pictureBoxFoto.TabStop = false;
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
            this.lblTitulo.Size = new System.Drawing.Size(340, 63);
            this.lblTitulo.TabIndex = 26;
            this.lblTitulo.Text = "Baja de animal";
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
            this.btCerrar.TabIndex = 27;
            this.btCerrar.Text = "X";
            this.btCerrar.UseVisualStyleBackColor = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // lbRaza
            // 
            this.lbRaza.AutoSize = true;
            this.lbRaza.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRaza.Location = new System.Drawing.Point(387, 282);
            this.lbRaza.Name = "lbRaza";
            this.lbRaza.Size = new System.Drawing.Size(67, 33);
            this.lbRaza.TabIndex = 28;
            this.lbRaza.Text = "Raza";
            // 
            // tbRaza
            // 
            this.tbRaza.BackColor = System.Drawing.SystemColors.Control;
            this.tbRaza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRaza.Enabled = false;
            this.tbRaza.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRaza.Location = new System.Drawing.Point(521, 278);
            this.tbRaza.Name = "tbRaza";
            this.tbRaza.Size = new System.Drawing.Size(227, 30);
            this.tbRaza.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(521, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 1);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(521, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 1);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(521, 308);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 1);
            this.panel3.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(962, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 1);
            this.panel4.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(963, 176);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 1);
            this.panel5.TabIndex = 32;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(963, 245);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(227, 1);
            this.panel6.TabIndex = 32;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Location = new System.Drawing.Point(963, 308);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(227, 1);
            this.panel7.TabIndex = 32;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel8.Location = new System.Drawing.Point(604, 61);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(353, 1);
            this.panel8.TabIndex = 31;
            // 
            // BajaAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 658);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbRaza);
            this.Controls.Add(this.lbRaza);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.cbBajaAnimal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbDetalles);
            this.Controls.Add(this.tbDetalles);
            this.Controls.Add(this.lbFechadeRegistro);
            this.Controls.Add(this.tbFechadeRegistro);
            this.Controls.Add(this.lbTamaño);
            this.Controls.Add(this.tbTamaño);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.tbSexo);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btBaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BajaAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BajaAnimal";
            this.Load += new System.EventHandler(this.BajaAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adopcionDAJDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adopcionDAJDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBaja;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.TextBox tbSexo;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label lbDetalles;
        private System.Windows.Forms.TextBox tbDetalles;
        private System.Windows.Forms.Label lbFechadeRegistro;
        private System.Windows.Forms.TextBox tbFechadeRegistro;
        private System.Windows.Forms.Label lbTamaño;
        private System.Windows.Forms.TextBox tbTamaño;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.TextBox tbEdad;
        private AdopcionDAJDataSet adopcionDAJDataSet;
        private AdopcionDAJDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.DataGridViewTextBoxColumn idanimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource adopcionDAJDataSet3BindingSource;
        private AdopcionDAJDataSet3 adopcionDAJDataSet3;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private AdopcionDAJDataSet3TableAdapters.AnimalTableAdapter animalTableAdapter1;
        private System.Windows.Forms.ComboBox cbBajaAnimal;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Label lbRaza;
        private System.Windows.Forms.TextBox tbRaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamañoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detallesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoadopcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
    }
}