namespace EquipoWinForce
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
            TxtNombreEquipo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtPaisEquipo = new TextBox();
            Pais = new Label();
            BtnAgregarEquipo = new Button();
            BtnEliminarEquipo = new Button();
            BtnObtenerEquipos = new Button();
            DgvEquipos = new DataGridView();
            Equipo = new DataGridViewTextBoxColumn();
            PaisEquipo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // TxtNombreEquipo
            // 
            TxtNombreEquipo.Location = new Point(80, 52);
            TxtNombreEquipo.Name = "TxtNombreEquipo";
            TxtNombreEquipo.Size = new Size(122, 23);
            TxtNombreEquipo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 1;
            label1.Text = "Gestion de equipos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Equipo";
            // 
            // TxtPaisEquipo
            // 
            TxtPaisEquipo.Location = new Point(281, 52);
            TxtPaisEquipo.Name = "TxtPaisEquipo";
            TxtPaisEquipo.Size = new Size(122, 23);
            TxtPaisEquipo.TabIndex = 3;
            // 
            // Pais
            // 
            Pais.AutoSize = true;
            Pais.Location = new Point(220, 55);
            Pais.Name = "Pais";
            Pais.Size = new Size(28, 15);
            Pais.TabIndex = 4;
            Pais.Text = "Pais";
            // 
            // BtnAgregarEquipo
            // 
            BtnAgregarEquipo.Location = new Point(447, 52);
            BtnAgregarEquipo.Name = "BtnAgregarEquipo";
            BtnAgregarEquipo.Size = new Size(113, 23);
            BtnAgregarEquipo.TabIndex = 5;
            BtnAgregarEquipo.Text = "Agregar Equipo";
            BtnAgregarEquipo.UseVisualStyleBackColor = true;
            BtnAgregarEquipo.Click += BtnAgregarEquipo_Click;
            // 
            // BtnEliminarEquipo
            // 
            BtnEliminarEquipo.Location = new Point(589, 51);
            BtnEliminarEquipo.Name = "BtnEliminarEquipo";
            BtnEliminarEquipo.Size = new Size(113, 23);
            BtnEliminarEquipo.TabIndex = 7;
            BtnEliminarEquipo.Text = "Eliminar Equipo";
            BtnEliminarEquipo.UseVisualStyleBackColor = true;
            BtnEliminarEquipo.Click += BtnEliminarEquipo_Click;
            // 
            // BtnObtenerEquipos
            // 
            BtnObtenerEquipos.Location = new Point(19, 97);
            BtnObtenerEquipos.Name = "BtnObtenerEquipos";
            BtnObtenerEquipos.Size = new Size(161, 23);
            BtnObtenerEquipos.TabIndex = 8;
            BtnObtenerEquipos.Text = "Obtener Equipos";
            BtnObtenerEquipos.UseVisualStyleBackColor = true;
            BtnObtenerEquipos.Click += BtnObtenerEquipos_Click;
            // 
            // DgvEquipos
            // 
            DgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEquipos.Columns.AddRange(new DataGridViewColumn[] { Equipo, PaisEquipo });
            DgvEquipos.Location = new Point(19, 170);
            DgvEquipos.Name = "DgvEquipos";
            DgvEquipos.Size = new Size(313, 112);
            DgvEquipos.TabIndex = 9;
            // 
            // Equipo
            // 
            Equipo.HeaderText = "Equipo";
            Equipo.Name = "Equipo";
            Equipo.ReadOnly = true;
            // 
            // PaisEquipo
            // 
            PaisEquipo.HeaderText = "Pais Equipo";
            PaisEquipo.Name = "PaisEquipo";
            PaisEquipo.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvEquipos);
            Controls.Add(BtnObtenerEquipos);
            Controls.Add(BtnEliminarEquipo);
            Controls.Add(BtnAgregarEquipo);
            Controls.Add(Pais);
            Controls.Add(TxtPaisEquipo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtNombreEquipo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DgvEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNombreEquipo;
        private Label label1;
        private Label label2;
        private TextBox TxtPaisEquipo;
        private Label Pais;
        private Button BtnAgregarEquipo;
        private Button BtnEliminarEquipo;
        private Button BtnObtenerEquipos;
        private DataGridView DgvEquipos;
        private DataGridViewTextBoxColumn Equipo;
        private DataGridViewTextBoxColumn PaisEquipo;
    }
}
