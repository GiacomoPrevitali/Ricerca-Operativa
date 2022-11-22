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
            this.Btn_CreaTabella = new System.Windows.Forms.Button();
            this.Tabella = new System.Windows.Forms.DataGridView();
            this.btn_AVVIA = new System.Windows.Forms.Button();
            this.btn_Test = new System.Windows.Forms.Button();
            this.nUP_max = new System.Windows.Forms.NumericUpDown();
            this.nUP_Min = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Righe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Colonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUP_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUP_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // nUD_Righe
            // 
            this.nUD_Righe.Location = new System.Drawing.Point(62, 41);
            this.nUD_Righe.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_Righe.Name = "nUD_Righe";
            this.nUD_Righe.Size = new System.Drawing.Size(120, 20);
            this.nUD_Righe.TabIndex = 0;
            this.nUD_Righe.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nUD_Colonne
            // 
            this.nUD_Colonne.Location = new System.Drawing.Point(216, 41);
            this.nUD_Colonne.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_Colonne.Name = "nUD_Colonne";
            this.nUD_Colonne.Size = new System.Drawing.Size(120, 20);
            this.nUD_Colonne.TabIndex = 1;
            this.nUD_Colonne.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Btn_CreaTabella
            // 
            this.Btn_CreaTabella.Location = new System.Drawing.Point(363, 41);
            this.Btn_CreaTabella.Name = "Btn_CreaTabella";
            this.Btn_CreaTabella.Size = new System.Drawing.Size(75, 23);
            this.Btn_CreaTabella.TabIndex = 2;
            this.Btn_CreaTabella.Text = "Crea Tabella";
            this.Btn_CreaTabella.UseVisualStyleBackColor = true;
            this.Btn_CreaTabella.Click += new System.EventHandler(this.Btn_CreaTabella_Click);
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
            this.Tabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabella.GridColor = System.Drawing.Color.LightGray;
            this.Tabella.Location = new System.Drawing.Point(62, 143);
            this.Tabella.Name = "Tabella";
            this.Tabella.RowHeadersVisible = false;
            this.Tabella.Size = new System.Drawing.Size(910, 269);
            this.Tabella.TabIndex = 3;
            this.Tabella.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Tabella_EditingControlShowing);
            // 
            // btn_AVVIA
            // 
            this.btn_AVVIA.Location = new System.Drawing.Point(454, 41);
            this.btn_AVVIA.Name = "btn_AVVIA";
            this.btn_AVVIA.Size = new System.Drawing.Size(75, 23);
            this.btn_AVVIA.TabIndex = 4;
            this.btn_AVVIA.Text = "AVVIA";
            this.btn_AVVIA.UseVisualStyleBackColor = true;
            this.btn_AVVIA.Click += new System.EventHandler(this.btn_AVVIA_Click);
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(642, 41);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(75, 23);
            this.btn_Test.TabIndex = 5;
            this.btn_Test.Text = "RIEMPI";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // nUP_max
            // 
            this.nUP_max.Location = new System.Drawing.Point(751, 12);
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
            this.nUP_max.Size = new System.Drawing.Size(120, 20);
            this.nUP_max.TabIndex = 7;
            this.nUP_max.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // nUP_Min
            // 
            this.nUP_Min.Location = new System.Drawing.Point(751, 44);
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
            this.nUP_Min.Size = new System.Drawing.Size(120, 20);
            this.nUP_Min.TabIndex = 8;
            this.nUP_Min.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // RicercaOperativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1033, 461);
            this.Controls.Add(this.nUP_Min);
            this.Controls.Add(this.nUP_max);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.btn_AVVIA);
            this.Controls.Add(this.Tabella);
            this.Controls.Add(this.Btn_CreaTabella);
            this.Controls.Add(this.nUD_Colonne);
            this.Controls.Add(this.nUD_Righe);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "RicercaOperativa";
            this.Text = "Ricerca Operativa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Righe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Colonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUP_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUP_Min)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUD_Righe;
        private System.Windows.Forms.NumericUpDown nUD_Colonne;
        private System.Windows.Forms.Button Btn_CreaTabella;
        private System.Windows.Forms.DataGridView Tabella;
        private System.Windows.Forms.Button btn_AVVIA;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.NumericUpDown nUP_max;
        private System.Windows.Forms.NumericUpDown nUP_Min;
    }
}

