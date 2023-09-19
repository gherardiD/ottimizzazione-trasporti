﻿namespace logistica
{
    partial class logistica_form
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
            this.consumatori_num = new System.Windows.Forms.NumericUpDown();
            this.produttori_num = new System.Windows.Forms.NumericUpDown();
            this.produttori_label = new System.Windows.Forms.Label();
            this.consumatori_label = new System.Windows.Forms.Label();
            this.genera_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.consumatori_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produttori_num)).BeginInit();
            this.SuspendLayout();
            // 
            // consumatori_num
            // 
            this.consumatori_num.AutoSize = true;
            this.consumatori_num.Location = new System.Drawing.Point(144, 56);
            this.consumatori_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.consumatori_num.Name = "consumatori_num";
            this.consumatori_num.Size = new System.Drawing.Size(120, 22);
            this.consumatori_num.TabIndex = 0;
            this.consumatori_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // produttori_num
            // 
            this.produttori_num.AutoSize = true;
            this.produttori_num.Location = new System.Drawing.Point(144, 28);
            this.produttori_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.produttori_num.Name = "produttori_num";
            this.produttori_num.Size = new System.Drawing.Size(120, 22);
            this.produttori_num.TabIndex = 1;
            this.produttori_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // produttori_label
            // 
            this.produttori_label.AutoSize = true;
            this.produttori_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produttori_label.Location = new System.Drawing.Point(22, 28);
            this.produttori_label.Name = "produttori_label";
            this.produttori_label.Size = new System.Drawing.Size(90, 20);
            this.produttori_label.TabIndex = 2;
            this.produttori_label.Text = "produttori";
            // 
            // consumatori_label
            // 
            this.consumatori_label.AutoSize = true;
            this.consumatori_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consumatori_label.Location = new System.Drawing.Point(22, 55);
            this.consumatori_label.Name = "consumatori_label";
            this.consumatori_label.Size = new System.Drawing.Size(112, 20);
            this.consumatori_label.TabIndex = 3;
            this.consumatori_label.Text = "consumatori";
            // 
            // genera_btn
            // 
            this.genera_btn.AutoSize = true;
            this.genera_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.genera_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genera_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genera_btn.Location = new System.Drawing.Point(321, 29);
            this.genera_btn.Name = "genera_btn";
            this.genera_btn.Size = new System.Drawing.Size(136, 48);
            this.genera_btn.TabIndex = 4;
            this.genera_btn.Text = "genera";
            this.genera_btn.UseVisualStyleBackColor = false;
            this.genera_btn.Click += new System.EventHandler(this.genera_btn_Click);
            // 
            // logistica_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.genera_btn);
            this.Controls.Add(this.consumatori_label);
            this.Controls.Add(this.produttori_label);
            this.Controls.Add(this.produttori_num);
            this.Controls.Add(this.consumatori_num);
            this.Name = "logistica_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logistica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.consumatori_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produttori_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown consumatori_num;
        private System.Windows.Forms.NumericUpDown produttori_num;
        private System.Windows.Forms.Label produttori_label;
        private System.Windows.Forms.Label consumatori_label;
        private System.Windows.Forms.Button genera_btn;
    }
}
