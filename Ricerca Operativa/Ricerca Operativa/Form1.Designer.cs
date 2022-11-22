namespace Ricerca_Operativa
{
    partial class RicercaOperativa
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.nUD_Righe = new System.Windows.Forms.NumericUpDown();
            this.nUD_Colonne = new System.Windows.Forms.NumericUpDown();
            this.Tabella = new System.Windows.Forms.DataGridView();
            this.nUP_max = new System.Windows.Forms.NumericUpDown();
            this.nUP_Min = new System.Windows.Forms.NumericUpDown();
            this.Rj_Avvia = new Client.RJButtons();
            this.Rj_CreaTabella = new Client.RJButtons();
            this.rJ_Riempi = new Client.RJButtons();
            this.lbl_NumRighe = new System.Windows.Forms.Label();
            this.lbl_NumColonne = new System.Windows.Forms.Label();
            this.lbl_CostMin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Righe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Colonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUP_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUP_Min)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nUD_Righe
            // 
            this.nUD_Righe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nUD_Righe.Location = new System.Drawing.Point(53, 39);
            this.nUD_Righe.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_Righe.Name = "nUD_Righe";
            this.nUD_Righe.Size = new System.Drawing.Size(86, 20);
            this.nUD_Righe.TabIndex = 0;
            this.nUD_Righe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUD_Righe.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nUD_Colonne
            // 
            this.nUD_Colonne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nUD_Colonne.Location = new System.Drawing.Point(164, 39);
            this.nUD_Colonne.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_Colonne.Name = "nUD_Colonne";
            this.nUD_Colonne.Size = new System.Drawing.Size(86, 20);
            this.nUD_Colonne.TabIndex = 1;
            this.nUD_Colonne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUD_Colonne.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Tabella
            // 
            this.Tabella.AllowUserToAddRows = false;
            this.Tabella.AllowUserToDeleteRows = false;
            this.Tabella.AllowUserToResizeColumns = false;
            this.Tabella.AllowUserToResizeRows = false;
            this.Tabella.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabella.BackgroundColor = System.Drawing.Color.White;
            this.Tabella.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabella.GridColor = System.Drawing.Color.Gray;
            this.Tabella.Location = new System.Drawing.Point(49, 134);
            this.Tabella.Name = "Tabella";
            this.Tabella.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tabella.RowHeadersVisible = false;
            this.Tabella.Size = new System.Drawing.Size(945, 285);
            this.Tabella.TabIndex = 3;
            this.Tabella.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Tabella_EditingControlShowing);
            // 
            // nUP_max
            // 
            this.nUP_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nUP_max.Location = new System.Drawing.Point(866, 23);
            this.nUP_max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUP_max.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUP_max.Name = "nUP_max";
            this.nUP_max.Size = new System.Drawing.Size(56, 20);
            this.nUP_max.TabIndex = 7;
            this.nUP_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUP_max.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // nUP_Min
            // 
            this.nUP_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nUP_Min.Location = new System.Drawing.Point(866, 77);
            this.nUP_Min.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUP_Min.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUP_Min.Name = "nUP_Min";
            this.nUP_Min.Size = new System.Drawing.Size(56, 20);
            this.nUP_Min.TabIndex = 8;
            this.nUP_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUP_Min.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Rj_Avvia
            // 
            this.Rj_Avvia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Rj_Avvia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(204)))), ((int)(((byte)(170)))));
            this.Rj_Avvia.FlatAppearance.BorderSize = 0;
            this.Rj_Avvia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rj_Avvia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rj_Avvia.ForeColor = System.Drawing.Color.White;
            this.Rj_Avvia.Location = new System.Drawing.Point(442, 27);
            this.Rj_Avvia.Name = "Rj_Avvia";
            this.Rj_Avvia.Size = new System.Drawing.Size(139, 40);
            this.Rj_Avvia.TabIndex = 10;
            this.Rj_Avvia.Text = "AVVIA";
            this.Rj_Avvia.UseVisualStyleBackColor = false;
            this.Rj_Avvia.Click += new System.EventHandler(this.Rj_Avvia_Click);
            // 
            // Rj_CreaTabella
            // 
            this.Rj_CreaTabella.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Rj_CreaTabella.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(204)))), ((int)(((byte)(170)))));
            this.Rj_CreaTabella.FlatAppearance.BorderSize = 0;
            this.Rj_CreaTabella.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rj_CreaTabella.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rj_CreaTabella.ForeColor = System.Drawing.Color.White;
            this.Rj_CreaTabella.Location = new System.Drawing.Point(286, 27);
            this.Rj_CreaTabella.Name = "Rj_CreaTabella";
            this.Rj_CreaTabella.Size = new System.Drawing.Size(150, 40);
            this.Rj_CreaTabella.TabIndex = 9;
            this.Rj_CreaTabella.Text = "Crea Tabella";
            this.Rj_CreaTabella.UseVisualStyleBackColor = false;
            this.Rj_CreaTabella.Click += new System.EventHandler(this.Rj_CreaTabella_Click);
            // 
            // rJ_Riempi
            // 
            this.rJ_Riempi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rJ_Riempi.BackColor = System.Drawing.Color.Teal;
            this.rJ_Riempi.FlatAppearance.BorderSize = 0;
            this.rJ_Riempi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Riempi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Riempi.ForeColor = System.Drawing.Color.White;
            this.rJ_Riempi.Location = new System.Drawing.Point(749, 27);
            this.rJ_Riempi.Name = "rJ_Riempi";
            this.rJ_Riempi.Size = new System.Drawing.Size(98, 40);
            this.rJ_Riempi.TabIndex = 11;
            this.rJ_Riempi.Text = "RIEMPI";
            this.rJ_Riempi.UseVisualStyleBackColor = false;
            this.rJ_Riempi.Click += new System.EventHandler(this.rJ_Riempi_Click);
            // 
            // lbl_NumRighe
            // 
            this.lbl_NumRighe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_NumRighe.AutoSize = true;
            this.lbl_NumRighe.Font = new System.Drawing.Font("Miriam Libre", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumRighe.ForeColor = System.Drawing.Color.Black;
            this.lbl_NumRighe.Location = new System.Drawing.Point(50, 23);
            this.lbl_NumRighe.Name = "lbl_NumRighe";
            this.lbl_NumRighe.Size = new System.Drawing.Size(89, 14);
            this.lbl_NumRighe.TabIndex = 12;
            this.lbl_NumRighe.Text = "Numero Righe:";
            // 
            // lbl_NumColonne
            // 
            this.lbl_NumColonne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_NumColonne.AutoSize = true;
            this.lbl_NumColonne.Font = new System.Drawing.Font("Miriam Libre", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumColonne.ForeColor = System.Drawing.Color.Black;
            this.lbl_NumColonne.Location = new System.Drawing.Point(161, 23);
            this.lbl_NumColonne.Name = "lbl_NumColonne";
            this.lbl_NumColonne.Size = new System.Drawing.Size(102, 14);
            this.lbl_NumColonne.TabIndex = 13;
            this.lbl_NumColonne.Text = "Numero Colonne:";
            // 
            // lbl_CostMin
            // 
            this.lbl_CostMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_CostMin.AutoSize = true;
            this.lbl_CostMin.Font = new System.Drawing.Font("Miriam Libre", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CostMin.ForeColor = System.Drawing.Color.Black;
            this.lbl_CostMin.Location = new System.Drawing.Point(863, 60);
            this.lbl_CostMin.Name = "lbl_CostMin";
            this.lbl_CostMin.Size = new System.Drawing.Size(87, 14);
            this.lbl_CostMin.TabIndex = 14;
            this.lbl_CostMin.Text = "Costo Minimo:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Libre", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(863, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Costo Massimo:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.nUD_Righe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nUD_Colonne);
            this.panel1.Controls.Add(this.lbl_CostMin);
            this.panel1.Controls.Add(this.nUP_max);
            this.panel1.Controls.Add(this.lbl_NumColonne);
            this.panel1.Controls.Add(this.nUP_Min);
            this.panel1.Controls.Add(this.lbl_NumRighe);
            this.panel1.Controls.Add(this.Rj_CreaTabella);
            this.panel1.Controls.Add(this.rJ_Riempi);
            this.panel1.Controls.Add(this.Rj_Avvia);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 106);
            this.panel1.TabIndex = 16;
            // 
            // RicercaOperativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tabella);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "RicercaOperativa";
            this.Text = "Ricerca Operativa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Righe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Colonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUP_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUP_Min)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUD_Righe;
        private System.Windows.Forms.NumericUpDown nUD_Colonne;
        private System.Windows.Forms.DataGridView Tabella;
        private System.Windows.Forms.NumericUpDown nUP_max;
        private System.Windows.Forms.NumericUpDown nUP_Min;
        private Client.RJButtons Rj_CreaTabella;
        private Client.RJButtons Rj_Avvia;
        private Client.RJButtons rJ_Riempi;
        private System.Windows.Forms.Label lbl_NumRighe;
        private System.Windows.Forms.Label lbl_NumColonne;
        private System.Windows.Forms.Label lbl_CostMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

