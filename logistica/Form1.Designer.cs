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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.consumatori_num = new System.Windows.Forms.NumericUpDown();
            this.produttori_num = new System.Windows.Forms.NumericUpDown();
            this.produttori_label = new System.Windows.Forms.Label();
            this.consumatori_label = new System.Windows.Forms.Label();
            this.genera_btn = new System.Windows.Forms.Button();
            this.panel_table = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.DataGridView();
            this.productor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_btn = new System.Windows.Forms.Button();
            this.panel_text = new System.Windows.Forms.Panel();
            this.text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.consumatori_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produttori_num)).BeginInit();
            this.panel_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel_text.SuspendLayout();
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
            this.panel_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_table.Controls.Add(this.table);
            this.panel_table.Location = new System.Drawing.Point(12, 103);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(825, 571);
            this.panel_table.TabIndex = 6;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.CausesValidation = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productor});
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 70;
            this.table.Size = new System.Drawing.Size(825, 571);
            this.table.TabIndex = 6;
            this.table.Visible = false;
            // 
            // productor
            // 
            this.productor.HeaderText = "Productors";
            this.productor.MinimumWidth = 6;
            this.productor.Name = "productor";
            this.productor.ReadOnly = true;
            this.productor.Width = 150;
            // 
            // start_btn
            // 
            this.start_btn.AutoSize = true;
            this.start_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(610, 24);
            this.start_btn.Margin = new System.Windows.Forms.Padding(2);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(102, 39);
            this.start_btn.TabIndex = 7;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // panel_text
            // 
            this.panel_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_text.Controls.Add(this.text);
            this.panel_text.Location = new System.Drawing.Point(883, 103);
            this.panel_text.Name = "panel_text";
            this.panel_text.Size = new System.Drawing.Size(539, 571);
            this.panel_text.TabIndex = 9;
            this.panel_text.Visible = false;
            // 
            // text
            // 
            this.text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(0, 0);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(539, 571);
            this.text.TabIndex = 9;
            this.text.Text = "NORD-OVEST SYSTEM:";
            // 
            // logistica_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1466, 829);
            this.Controls.Add(this.panel_text);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.panel_table);
            this.Controls.Add(this.genera_btn);
            this.Controls.Add(this.consumatori_label);
            this.Controls.Add(this.produttori_label);
            this.Controls.Add(this.produttori_num);
            this.Controls.Add(this.consumatori_num);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1482, 868);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1482, 868);
            this.Name = "logistica_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logistica";
            ((System.ComponentModel.ISupportInitialize)(this.consumatori_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produttori_num)).EndInit();
            this.panel_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel_text.ResumeLayout(false);
            this.panel_text.PerformLayout();
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
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productor;
        private System.Windows.Forms.Panel panel_text;
        private System.Windows.Forms.TextBox text;
    }
}

