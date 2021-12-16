
namespace FormularioCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPut = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbConsulta = new System.Windows.Forms.ComboBox();
            this.txtIdDelete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNtripulantes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNaves = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtidCuerpo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.cbConsulta);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnPut);
            this.panel1.Controls.Add(this.btnGet);
            this.panel1.Controls.Add(this.btnPost);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 529);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(3, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 61);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPut
            // 
            this.btnPut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPut.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnPut.Location = new System.Drawing.Point(3, 293);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(183, 61);
            this.btnPut.TabIndex = 3;
            this.btnPut.Text = "Update";
            this.btnPut.UseVisualStyleBackColor = true;
            // 
            // btnGet
            // 
            this.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnGet.Location = new System.Drawing.Point(3, 226);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(183, 61);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Read";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnPost
            // 
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnPost.Location = new System.Drawing.Point(3, 159);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(183, 61);
            this.btnPost.TabIndex = 1;
            this.btnPost.Text = "Insert";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 100);
            this.panel2.TabIndex = 1;
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.panel2.MouseHover += new System.EventHandler(this.panel2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormularioCliente.Properties.Resources.silueta_de_usuario;
            this.pictureBox1.Location = new System.Drawing.Point(39, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtidCuerpo);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtDuracion);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtNaves);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtNtripulantes);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtDescripcion);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtNombre);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtIdDelete);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(189, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(610, 526);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 284);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbConsulta
            // 
            this.cbConsulta.FormattingEnabled = true;
            this.cbConsulta.Items.AddRange(new object[] {
            "Nave",
            "CuerpoCeleste",
            "Usuario",
            "Mision",
            "DistribucionMineral"});
            this.cbConsulta.Location = new System.Drawing.Point(12, 121);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(159, 21);
            this.cbConsulta.TabIndex = 2;
            this.cbConsulta.SelectedIndexChanged += new System.EventHandler(this.cbConsulta_SelectedIndexChanged);
            // 
            // txtIdDelete
            // 
            this.txtIdDelete.Location = new System.Drawing.Point(16, 312);
            this.txtIdDelete.Name = "txtIdDelete";
            this.txtIdDelete.Size = new System.Drawing.Size(100, 20);
            this.txtIdDelete.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "id";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(16, 379);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripcion:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(131, 379);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(251, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "nTripulantes";
            // 
            // txtNtripulantes
            // 
            this.txtNtripulantes.Location = new System.Drawing.Point(237, 379);
            this.txtNtripulantes.Name = "txtNtripulantes";
            this.txtNtripulantes.Size = new System.Drawing.Size(100, 20);
            this.txtNtripulantes.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(357, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Naves";
            // 
            // txtNaves
            // 
            this.txtNaves.Location = new System.Drawing.Point(343, 379);
            this.txtNaves.Name = "txtNaves";
            this.txtNaves.Size = new System.Drawing.Size(100, 20);
            this.txtNaves.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(474, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Duracion";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(460, 379);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(100, 20);
            this.txtDuracion.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(30, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "idCuerpo";
            // 
            // txtidCuerpo
            // 
            this.txtidCuerpo.Location = new System.Drawing.Point(16, 431);
            this.txtidCuerpo.Name = "txtidCuerpo";
            this.txtidCuerpo.Size = new System.Drawing.Size(100, 20);
            this.txtidCuerpo.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClienteFormulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtidCuerpo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNaves;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNtripulantes;
    }
}

