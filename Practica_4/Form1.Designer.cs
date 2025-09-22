namespace Practica_4
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
            Grilla_Equipos = new DataGridView();
            label1 = new Label();
            BTN_AGREGAR = new Button();
            PIKER_ALTA = new DateTimePicker();
            PIKER_BAJA = new DateTimePicker();
            BTN_UPDATE = new Button();
            Grilla_Baja_Equipos = new DataGridView();
            Grilla_Filtro = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            FILTRO = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Grilla_Equipos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Baja_Equipos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Filtro).BeginInit();
            SuspendLayout();
            // 
            // Grilla_Equipos
            // 
            Grilla_Equipos.AllowUserToAddRows = false;
            Grilla_Equipos.AllowUserToDeleteRows = false;
            Grilla_Equipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Equipos.Location = new Point(59, 48);
            Grilla_Equipos.Name = "Grilla_Equipos";
            Grilla_Equipos.ReadOnly = true;
            Grilla_Equipos.Size = new Size(630, 150);
            Grilla_Equipos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 26);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Equipos";
            // 
            // BTN_AGREGAR
            // 
            BTN_AGREGAR.Location = new Point(59, 204);
            BTN_AGREGAR.Name = "BTN_AGREGAR";
            BTN_AGREGAR.Size = new Size(75, 23);
            BTN_AGREGAR.TabIndex = 2;
            BTN_AGREGAR.Text = "Agregar";
            BTN_AGREGAR.UseVisualStyleBackColor = true;
            BTN_AGREGAR.Click += BTN_AGREGAR_Click;
            // 
            // PIKER_ALTA
            // 
            PIKER_ALTA.Location = new Point(59, 243);
            PIKER_ALTA.Name = "PIKER_ALTA";
            PIKER_ALTA.Size = new Size(200, 23);
            PIKER_ALTA.TabIndex = 3;
            // 
            // PIKER_BAJA
            // 
            PIKER_BAJA.Location = new Point(59, 281);
            PIKER_BAJA.Name = "PIKER_BAJA";
            PIKER_BAJA.Size = new Size(200, 23);
            PIKER_BAJA.TabIndex = 4;
            // 
            // BTN_UPDATE
            // 
            BTN_UPDATE.Location = new Point(399, 22);
            BTN_UPDATE.Name = "BTN_UPDATE";
            BTN_UPDATE.Size = new Size(75, 23);
            BTN_UPDATE.TabIndex = 5;
            BTN_UPDATE.Text = "UPDATE";
            BTN_UPDATE.UseVisualStyleBackColor = true;
            BTN_UPDATE.Click += BTN_UPDATE_Click;
            // 
            // Grilla_Baja_Equipos
            // 
            Grilla_Baja_Equipos.AllowUserToAddRows = false;
            Grilla_Baja_Equipos.AllowUserToDeleteRows = false;
            Grilla_Baja_Equipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Baja_Equipos.Location = new Point(44, 281);
            Grilla_Baja_Equipos.Name = "Grilla_Baja_Equipos";
            Grilla_Baja_Equipos.ReadOnly = true;
            Grilla_Baja_Equipos.Size = new Size(630, 150);
            Grilla_Baja_Equipos.TabIndex = 6;
            // 
            // Grilla_Filtro
            // 
            Grilla_Filtro.AllowUserToAddRows = false;
            Grilla_Filtro.AllowUserToDeleteRows = false;
            Grilla_Filtro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Filtro.Location = new Point(44, 516);
            Grilla_Filtro.Name = "Grilla_Filtro";
            Grilla_Filtro.ReadOnly = true;
            Grilla_Filtro.Size = new Size(630, 150);
            Grilla_Filtro.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 263);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 8;
            label2.Text = "EQUIPOS DADO DE BAJA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 498);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 9;
            label3.Text = "BUSQUEDA ENTRE";
            // 
            // FILTRO
            // 
            FILTRO.Location = new Point(190, 487);
            FILTRO.Name = "FILTRO";
            FILTRO.Size = new Size(100, 23);
            FILTRO.TabIndex = 10;
            FILTRO.TextChanged += FILTRO_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 724);
            Controls.Add(FILTRO);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Grilla_Filtro);
            Controls.Add(Grilla_Baja_Equipos);
            Controls.Add(BTN_UPDATE);
            Controls.Add(PIKER_BAJA);
            Controls.Add(PIKER_ALTA);
            Controls.Add(BTN_AGREGAR);
            Controls.Add(label1);
            Controls.Add(Grilla_Equipos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Grilla_Equipos).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Baja_Equipos).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Filtro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grilla_Equipos;
        private Label label1;
        private Button BTN_AGREGAR;
        private DateTimePicker PIKER_ALTA;
        private DateTimePicker PIKER_BAJA;
        private Button BTN_UPDATE;
        private DataGridView Grilla_Baja_Equipos;
        private DataGridView Grilla_Filtro;
        private Label label2;
        private Label label3;
        private TextBox FILTRO;
    }
}
