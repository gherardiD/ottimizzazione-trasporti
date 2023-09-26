namespace logistica
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
            this.panel_table = new System.Windows.Forms.Panel();
            this.table_default = new System.Windows.Forms.DataGridView();
            this.productor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tot_producted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.consumatori_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produttori_num)).BeginInit();
            this.panel_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_default)).BeginInit();
            this.SuspendLayout();
            // 
            // consumatori_num
            // 
            this.consumatori_num.AutoSize = true;
            this.consumatori_num.Location = new System.Drawing.Point(108, 46);
            this.consumatori_num.Margin = new System.Windows.Forms.Padding(2);
            this.consumatori_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.consumatori_num.Name = "consumatori_num";
            this.consumatori_num.Size = new System.Drawing.Size(90, 20);
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
            this.produttori_num.Location = new System.Drawing.Point(108, 23);
            this.produttori_num.Margin = new System.Windows.Forms.Padding(2);
            this.produttori_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.produttori_num.Name = "produttori_num";
            this.produttori_num.Size = new System.Drawing.Size(90, 20);
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
            this.produttori_label.Location = new System.Drawing.Point(16, 23);
            this.produttori_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.produttori_label.Name = "produttori_label";
            this.produttori_label.Size = new System.Drawing.Size(79, 17);
            this.produttori_label.TabIndex = 2;
            this.produttori_label.Text = "produttori";
            // 
            // consumatori_label
            // 
            this.consumatori_label.AutoSize = true;
            this.consumatori_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consumatori_label.Location = new System.Drawing.Point(16, 45);
            this.consumatori_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.consumatori_label.Name = "consumatori_label";
            this.consumatori_label.Size = new System.Drawing.Size(96, 17);
            this.consumatori_label.TabIndex = 3;
            this.consumatori_label.Text = "consumatori";
            // 
            // genera_btn
            // 
            this.genera_btn.AutoSize = true;
            this.genera_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.genera_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genera_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genera_btn.Location = new System.Drawing.Point(241, 24);
            this.genera_btn.Margin = new System.Windows.Forms.Padding(2);
            this.genera_btn.Name = "genera_btn";
            this.genera_btn.Size = new System.Drawing.Size(102, 39);
            this.genera_btn.TabIndex = 4;
            this.genera_btn.Text = "genera";
            this.genera_btn.UseVisualStyleBackColor = false;
            this.genera_btn.Click += new System.EventHandler(this.genera_btn_Click);
            // 
            // panel_table
            // 
            this.panel_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_table.Controls.Add(this.table_default);
            this.panel_table.Location = new System.Drawing.Point(12, 103);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(576, 174);
            this.panel_table.TabIndex = 6;
            // 
            // table_default
            // 
            this.table_default.CausesValidation = false;
            this.table_default.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_default.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productor,
            this.price_0,
            this.price_1,
            this.price_2,
            this.tot_producted});
            this.table_default.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_default.Location = new System.Drawing.Point(0, 0);
            this.table_default.Name = "table_default";
            this.table_default.RowHeadersWidth = 70;
            this.table_default.Size = new System.Drawing.Size(576, 174);
            this.table_default.TabIndex = 6;
            this.table_default.Visible = false;
            // 
            // productor
            // 
            this.productor.HeaderText = "productor";
            this.productor.Name = "productor";
            this.productor.ReadOnly = true;
            // 
            // price_0
            // 
            this.price_0.HeaderText = "price";
            this.price_0.Name = "price_0";
            // 
            // price_1
            // 
            this.price_1.HeaderText = "price";
            this.price_1.Name = "price_1";
            // 
            // price_2
            // 
            this.price_2.HeaderText = "price";
            this.price_2.Name = "price_2";
            // 
            // tot_producted
            // 
            this.tot_producted.HeaderText = "tot";
            this.tot_producted.Name = "tot_producted";
            this.tot_producted.ReadOnly = true;
            // 
            // logistica_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel_table);
            this.Controls.Add(this.genera_btn);
            this.Controls.Add(this.consumatori_label);
            this.Controls.Add(this.produttori_label);
            this.Controls.Add(this.produttori_num);
            this.Controls.Add(this.consumatori_num);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "logistica_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logistica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.consumatori_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produttori_num)).EndInit();
            this.panel_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_default)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown consumatori_num;
        private System.Windows.Forms.NumericUpDown produttori_num;
        private System.Windows.Forms.Label produttori_label;
        private System.Windows.Forms.Label consumatori_label;
        private System.Windows.Forms.Button genera_btn;
        private System.Windows.Forms.Panel panel_table;
        private System.Windows.Forms.DataGridView table_default;
        private System.Windows.Forms.DataGridViewTextBoxColumn productor;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_0;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tot_producted;
    }
}

