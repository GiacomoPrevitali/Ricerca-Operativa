namespace Ricerca_Operativa
{
    partial class Form2
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
            this.lsB_Costi = new System.Windows.Forms.ListBox();
            this.Rj_Chiudi = new Client.RJButtons();
            this.SuspendLayout();
            // 
            // lsB_Costi
            // 
            this.lsB_Costi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsB_Costi.FormattingEnabled = true;
            this.lsB_Costi.Location = new System.Drawing.Point(12, 16);
            this.lsB_Costi.Name = "lsB_Costi";
            this.lsB_Costi.Size = new System.Drawing.Size(406, 418);
            this.lsB_Costi.TabIndex = 0;
            this.lsB_Costi.SelectedIndexChanged += new System.EventHandler(this.lsB_Costi_SelectedIndexChanged);
            // 
            // Rj_Chiudi
            // 
            this.Rj_Chiudi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Rj_Chiudi.FlatAppearance.BorderSize = 0;
            this.Rj_Chiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rj_Chiudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rj_Chiudi.ForeColor = System.Drawing.Color.White;
            this.Rj_Chiudi.Location = new System.Drawing.Point(125, 466);
            this.Rj_Chiudi.Name = "Rj_Chiudi";
            this.Rj_Chiudi.Size = new System.Drawing.Size(150, 40);
            this.Rj_Chiudi.TabIndex = 2;
            this.Rj_Chiudi.Text = "CHIUDI";
            this.Rj_Chiudi.UseVisualStyleBackColor = false;
            this.Rj_Chiudi.Click += new System.EventHandler(this.Rj_Chiudi_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 565);
            this.Controls.Add(this.Rj_Chiudi);
            this.Controls.Add(this.lsB_Costi);
            this.Name = "Form2";
            this.Text = "Tabella Costi";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsB_Costi;
        private Client.RJButtons Rj_Chiudi;
    }
}