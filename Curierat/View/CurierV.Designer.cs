namespace Curierat.View
{
    partial class CurierV
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
            this.btnListaCol = new System.Windows.Forms.Button();
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
            // btnListaCol
            // 
            this.btnListaCol.Location = new System.Drawing.Point(869, 296);
            this.btnListaCol.Name = "btnListaCol";
            this.btnListaCol.Size = new System.Drawing.Size(136, 46);
            this.btnListaCol.TabIndex = 4;
            this.btnListaCol.Text = "Lista Colete";
            this.btnListaCol.UseVisualStyleBackColor = true;
            this.btnListaCol.Click += new System.EventHandler(this.btnListaCol_Click);
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
            this.label6.Location = new System.Drawing.Point(902, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cautare dupa Numar colet";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCautareLocatie
            // 
            this.txtCautareLocatie.Location = new System.Drawing.Point(905, 85);
            this.txtCautareLocatie.Name = "txtCautareLocatie";
            this.txtCautareLocatie.Size = new System.Drawing.Size(100, 20);
            this.txtCautareLocatie.TabIndex = 23;
            // 
            // btnCautareDupaLocatie
            // 
            this.btnCautareDupaLocatie.Location = new System.Drawing.Point(915, 129);
            this.btnCautareDupaLocatie.Name = "btnCautareDupaLocatie";
            this.btnCautareDupaLocatie.Size = new System.Drawing.Size(90, 35);
            this.btnCautareDupaLocatie.TabIndex = 24;
            this.btnCautareDupaLocatie.Text = "CAUTA";
            this.btnCautareDupaLocatie.UseVisualStyleBackColor = true;
            this.btnCautareDupaLocatie.Click += new System.EventHandler(this.btnCautareDupaLocatie_Click);
            // 
            // CurierV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 643);
            this.Controls.Add(this.btnListaCol);
            this.Controls.Add(this.btnCautareDupaLocatie);
            this.Controls.Add(this.txtCautareLocatie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDeconectare2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CurierV";
            this.Text = "CurierV";
            this.Load += new System.EventHandler(this.CurierV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListaCol;
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