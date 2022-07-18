namespace GestioneComande
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Crea = new System.Windows.Forms.Button();
            this.txtTipologia = new System.Windows.Forms.TextBox();
            this.lblTipologia = new System.Windows.Forms.Label();
            this.lblQuantità = new System.Windows.Forms.Label();
            this.txtQuantita = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblTitoloCreaPiatto = new System.Windows.Forms.Label();
            this.tabGestioneComande = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvaListaPiatti = new System.Windows.Forms.Button();
            this.gdrListaPiatti = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblOraAttuale = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDataAttuale = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNominativo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gdvComanda = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblTotale = new System.Windows.Forms.Label();
            this.lblCostoTotale = new System.Windows.Forms.Label();
            this.tabGestioneComande.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrListaPiatti)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvComanda)).BeginInit();
            this.SuspendLayout();
            // 
            // Crea
            // 
            this.Crea.Location = new System.Drawing.Point(434, 266);
            this.Crea.Name = "Crea";
            this.Crea.Size = new System.Drawing.Size(75, 23);
            this.Crea.TabIndex = 0;
            this.Crea.Text = "Crea";
            this.Crea.UseVisualStyleBackColor = true;
            this.Crea.Click += new System.EventHandler(this.Crea_Click);
            // 
            // txtTipologia
            // 
            this.txtTipologia.Location = new System.Drawing.Point(335, 132);
            this.txtTipologia.Name = "txtTipologia";
            this.txtTipologia.Size = new System.Drawing.Size(311, 22);
            this.txtTipologia.TabIndex = 1;
            // 
            // lblTipologia
            // 
            this.lblTipologia.AutoSize = true;
            this.lblTipologia.Location = new System.Drawing.Point(245, 135);
            this.lblTipologia.Name = "lblTipologia";
            this.lblTipologia.Size = new System.Drawing.Size(66, 17);
            this.lblTipologia.TabIndex = 2;
            this.lblTipologia.Text = "Tipologia";
            // 
            // lblQuantità
            // 
            this.lblQuantità.AutoSize = true;
            this.lblQuantità.Location = new System.Drawing.Point(245, 172);
            this.lblQuantità.Name = "lblQuantità";
            this.lblQuantità.Size = new System.Drawing.Size(62, 17);
            this.lblQuantità.TabIndex = 4;
            this.lblQuantità.Text = "Quantità";
            // 
            // txtQuantita
            // 
            this.txtQuantita.Location = new System.Drawing.Point(335, 169);
            this.txtQuantita.Name = "txtQuantita";
            this.txtQuantita.Size = new System.Drawing.Size(311, 22);
            this.txtQuantita.TabIndex = 3;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(245, 213);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(44, 17);
            this.lblCosto.TabIndex = 6;
            this.lblCosto.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(335, 210);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(311, 22);
            this.txtCosto.TabIndex = 5;
            // 
            // lblTitoloCreaPiatto
            // 
            this.lblTitoloCreaPiatto.AutoSize = true;
            this.lblTitoloCreaPiatto.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitoloCreaPiatto.Location = new System.Drawing.Point(282, 18);
            this.lblTitoloCreaPiatto.Name = "lblTitoloCreaPiatto";
            this.lblTitoloCreaPiatto.Size = new System.Drawing.Size(358, 76);
            this.lblTitoloCreaPiatto.TabIndex = 8;
            this.lblTitoloCreaPiatto.Text = "Crea piatto";
            // 
            // tabGestioneComande
            // 
            this.tabGestioneComande.Controls.Add(this.tabPage1);
            this.tabGestioneComande.Controls.Add(this.tabPage2);
            this.tabGestioneComande.Controls.Add(this.tabPage3);
            this.tabGestioneComande.Location = new System.Drawing.Point(3, 12);
            this.tabGestioneComande.Name = "tabGestioneComande";
            this.tabGestioneComande.SelectedIndex = 0;
            this.tabGestioneComande.Size = new System.Drawing.Size(903, 508);
            this.tabGestioneComande.TabIndex = 9;
            this.tabGestioneComande.SelectedIndexChanged += new System.EventHandler(this.tabGestioneComande_SelectedIndexchanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTitoloCreaPiatto);
            this.tabPage1.Controls.Add(this.Crea);
            this.tabPage1.Controls.Add(this.lblCosto);
            this.tabPage1.Controls.Add(this.txtQuantita);
            this.tabPage1.Controls.Add(this.txtCosto);
            this.tabPage1.Controls.Add(this.txtTipologia);
            this.tabPage1.Controls.Add(this.lblQuantità);
            this.tabPage1.Controls.Add(this.lblTipologia);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(895, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crea piatto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnSalvaListaPiatti);
            this.tabPage2.Controls.Add(this.gdrListaPiatti);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(895, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista piatti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista piatti";
            // 
            // btnSalvaListaPiatti
            // 
            this.btnSalvaListaPiatti.Location = new System.Drawing.Point(401, 420);
            this.btnSalvaListaPiatti.Name = "btnSalvaListaPiatti";
            this.btnSalvaListaPiatti.Size = new System.Drawing.Size(95, 51);
            this.btnSalvaListaPiatti.TabIndex = 1;
            this.btnSalvaListaPiatti.Text = "Salva";
            this.btnSalvaListaPiatti.UseVisualStyleBackColor = true;
            this.btnSalvaListaPiatti.Click += new System.EventHandler(this.btnSalvaListaPiatti_Click);
            // 
            // gdrListaPiatti
            // 
            this.gdrListaPiatti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrListaPiatti.Location = new System.Drawing.Point(3, 84);
            this.gdrListaPiatti.Name = "gdrListaPiatti";
            this.gdrListaPiatti.RowTemplate.Height = 24;
            this.gdrListaPiatti.Size = new System.Drawing.Size(886, 330);
            this.gdrListaPiatti.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblCostoTotale);
            this.tabPage3.Controls.Add(this.lblTotale);
            this.tabPage3.Controls.Add(this.lblOraAttuale);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lblDataAttuale);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtNominativo);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.gdvComanda);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(895, 479);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Crea comanda";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblOraAttuale
            // 
            this.lblOraAttuale.AutoSize = true;
            this.lblOraAttuale.Location = new System.Drawing.Point(107, 449);
            this.lblOraAttuale.Name = "lblOraAttuale";
            this.lblOraAttuale.Size = new System.Drawing.Size(32, 17);
            this.lblOraAttuale.TabIndex = 7;
            this.lblOraAttuale.Text = "Ora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ora";
            // 
            // lblDataAttuale
            // 
            this.lblDataAttuale.AutoSize = true;
            this.lblDataAttuale.Location = new System.Drawing.Point(104, 428);
            this.lblDataAttuale.Name = "lblDataAttuale";
            this.lblDataAttuale.Size = new System.Drawing.Size(38, 17);
            this.lblDataAttuale.TabIndex = 5;
            this.lblDataAttuale.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data";
            // 
            // txtNominativo
            // 
            this.txtNominativo.Location = new System.Drawing.Point(104, 399);
            this.txtNominativo.Name = "txtNominativo";
            this.txtNominativo.Size = new System.Drawing.Size(219, 22);
            this.txtNominativo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nominativo";
            // 
            // gdvComanda
            // 
            this.gdvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvComanda.Location = new System.Drawing.Point(3, 55);
            this.gdvComanda.Name = "gdvComanda";
            this.gdvComanda.RowTemplate.Height = 24;
            this.gdvComanda.Size = new System.Drawing.Size(892, 325);
            this.gdvComanda.TabIndex = 1;
            this.gdvComanda.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvComanda_CellEndEdit);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Stampa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Location = new System.Drawing.Point(502, 408);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(48, 17);
            this.lblTotale.TabIndex = 8;
            this.lblTotale.Text = "Totale";
            // 
            // lblCostoTotale
            // 
            this.lblCostoTotale.AutoSize = true;
            this.lblCostoTotale.Location = new System.Drawing.Point(557, 407);
            this.lblCostoTotale.Name = "lblCostoTotale";
            this.lblCostoTotale.Size = new System.Drawing.Size(0, 17);
            this.lblCostoTotale.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 513);
            this.Controls.Add(this.tabGestioneComande);
            this.Name = "Form1";
            this.Text = "Gestione comande";
            this.tabGestioneComande.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrListaPiatti)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvComanda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Crea;
        private System.Windows.Forms.TextBox txtTipologia;
        private System.Windows.Forms.Label lblTipologia;
        private System.Windows.Forms.Label lblQuantità;
        private System.Windows.Forms.TextBox txtQuantita;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblTitoloCreaPiatto;
        private System.Windows.Forms.TabControl tabGestioneComande;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gdrListaPiatti;
        private System.Windows.Forms.Button btnSalvaListaPiatti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gdvComanda;
        private System.Windows.Forms.Label lblDataAttuale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNominativo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOraAttuale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblCostoTotale;
        private System.Windows.Forms.Label lblTotale;
    }
}

