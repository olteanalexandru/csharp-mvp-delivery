namespace Curierat.View
{
    partial class CoordonatorV
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdaugareCol = new System.Windows.Forms.Button();
            this.btnActualizareCol = new System.Windows.Forms.Button();
            this.btnStergereCol = new System.Windows.Forms.Button();
            this.btnListaCol = new System.Windows.Forms.Button();
            this.Numar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.txtLivrator = new System.Windows.Forms.ComboBox();
            this.btnDeconectare2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCautareLocatie = new System.Windows.Forms.TextBox();
            this.btnCautareDupaLocatie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numar";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Locatie";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Curier";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Traseu Optim";
            this.Column4.MinimumWidth = 15;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // btnAdaugareCol
            // 
            this.btnAdaugareCol.Location = new System.Drawing.Point(523, 388);
            this.btnAdaugareCol.Name = "btnAdaugareCol";
            this.btnAdaugareCol.Size = new System.Drawing.Size(114, 55);
            this.btnAdaugareCol.TabIndex = 1;
            this.btnAdaugareCol.Text = "Adaugare Colet";
            this.btnAdaugareCol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdaugareCol.UseVisualStyleBackColor = true;
            this.btnAdaugareCol.Click += new System.EventHandler(this.btnAdaugareCol_Click);
            // 
            // btnActualizareCol
            // 
            this.btnActualizareCol.Location = new System.Drawing.Point(382, 388);
            this.btnActualizareCol.Name = "btnActualizareCol";
            this.btnActualizareCol.Size = new System.Drawing.Size(114, 55);
            this.btnActualizareCol.TabIndex = 2;
            this.btnActualizareCol.Text = "Actualizare Colet";
            this.btnActualizareCol.UseVisualStyleBackColor = true;
            this.btnActualizareCol.Click += new System.EventHandler(this.btnActualizareCol_Click);
            // 
            // btnStergereCol
            // 
            this.btnStergereCol.Location = new System.Drawing.Point(244, 388);
            this.btnStergereCol.Name = "btnStergereCol";
            this.btnStergereCol.Size = new System.Drawing.Size(114, 55);
            this.btnStergereCol.TabIndex = 3;
            this.btnStergereCol.Text = "Stergere Colet";
            this.btnStergereCol.UseVisualStyleBackColor = true;
            this.btnStergereCol.Click += new System.EventHandler(this.btnStergereCol_Click);
            // 
            // btnListaCol
            // 
            this.btnListaCol.Location = new System.Drawing.Point(30, 397);
            this.btnListaCol.Name = "btnListaCol";
            this.btnListaCol.Size = new System.Drawing.Size(136, 46);
            this.btnListaCol.TabIndex = 4;
            this.btnListaCol.Text = "Lista Colete";
            this.btnListaCol.UseVisualStyleBackColor = true;
            this.btnListaCol.Click += new System.EventHandler(this.btnListaCol_Click);
            // 
            // Numar
            // 
            this.Numar.AutoSize = true;
            this.Numar.Location = new System.Drawing.Point(803, 43);
            this.Numar.Name = "Numar";
            this.Numar.Size = new System.Drawing.Size(38, 13);
            this.Numar.TabIndex = 5;
            this.Numar.Text = "Numar";
            this.Numar.Click += new System.EventHandler(this.COD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(795, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Locatie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(803, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Curier";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(888, 36);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 11;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // txtLocatie
            // 
            this.txtLocatie.Location = new System.Drawing.Point(888, 91);
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(100, 20);
            this.txtLocatie.TabIndex = 12;
            // 
            // txtLivrator
            // 
            this.txtLivrator.FormattingEnabled = true;
            this.txtLivrator.Items.AddRange(new object[] {
            "Curier1",
            "Curier2",
            "Curier3"});
            this.txtLivrator.Location = new System.Drawing.Point(888, 148);
            this.txtLivrator.Name = "txtLivrator";
            this.txtLivrator.Size = new System.Drawing.Size(100, 21);
            this.txtLivrator.TabIndex = 17;
            this.txtLivrator.SelectedIndexChanged += new System.EventHandler(this.txtLivrator_SelectedIndexChanged);
            // 
            // btnDeconectare2
            // 
            this.btnDeconectare2.Location = new System.Drawing.Point(12, 571);
            this.btnDeconectare2.Name = "btnDeconectare2";
            this.btnDeconectare2.Size = new System.Drawing.Size(154, 60);
            this.btnDeconectare2.TabIndex = 21;
            this.btnDeconectare2.Text = "Deconectare";
            this.btnDeconectare2.UseVisualStyleBackColor = true;
            this.btnDeconectare2.Click += new System.EventHandler(this.btnDeconectare2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(823, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cautare dupa Numar colet";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCautareLocatie
            // 
            this.txtCautareLocatie.Location = new System.Drawing.Point(854, 444);
            this.txtCautareLocatie.Name = "txtCautareLocatie";
            this.txtCautareLocatie.Size = new System.Drawing.Size(100, 20);
            this.txtCautareLocatie.TabIndex = 23;
            // 
            // btnCautareDupaLocatie
            // 
            this.btnCautareDupaLocatie.Location = new System.Drawing.Point(854, 479);
            this.btnCautareDupaLocatie.Name = "btnCautareDupaLocatie";
            this.btnCautareDupaLocatie.Size = new System.Drawing.Size(90, 35);
            this.btnCautareDupaLocatie.TabIndex = 24;
            this.btnCautareDupaLocatie.Text = "CAUTA";
            this.btnCautareDupaLocatie.UseVisualStyleBackColor = true;
            this.btnCautareDupaLocatie.Click += new System.EventHandler(this.btnCautareDupaLocatie_Click);
            // 
            // CoordonatorV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 643);
            this.Controls.Add(this.btnCautareDupaLocatie);
            this.Controls.Add(this.txtCautareLocatie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDeconectare2);
            this.Controls.Add(this.txtLivrator);
            this.Controls.Add(this.txtLocatie);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numar);
            this.Controls.Add(this.btnListaCol);
            this.Controls.Add(this.btnStergereCol);
            this.Controls.Add(this.btnActualizareCol);
            this.Controls.Add(this.btnAdaugareCol);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CoordonatorV";
            this.Text = "CoordonatorV";
            this.Load += new System.EventHandler(this.CoordonatorV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdaugareCol;
        private System.Windows.Forms.Button btnActualizareCol;
        private System.Windows.Forms.Button btnStergereCol;
        private System.Windows.Forms.Button btnListaCol;
        private System.Windows.Forms.Label Numar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtLocatie;
        private System.Windows.Forms.ComboBox txtLivrator;
        private System.Windows.Forms.Button btnDeconectare2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCautareLocatie;
        private System.Windows.Forms.Button btnCautareDupaLocatie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}