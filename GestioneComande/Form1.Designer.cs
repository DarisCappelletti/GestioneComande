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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvaListaPiatti = new System.Windows.Forms.Button();
            this.gdrListaPiatti = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCostoTotale = new System.Windows.Forms.Label();
            this.lblTotale = new System.Windows.Forms.Label();
            this.lblOraAttuale = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDataAttuale = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNominativo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gdvComanda = new System.Windows.Forms.DataGridView();
            this.btnCreaComanda = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblTotaleIncassoOggi = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gdvComandeOggi = new System.Windows.Forms.DataGridView();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnEsportaXls = new System.Windows.Forms.Button();
            this.tabGestioneComande.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrListaPiatti)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvComanda)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvComandeOggi)).BeginInit();
            this.SuspendLayout();
            // 
            // Crea
            // 
            this.Crea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crea.Location = new System.Drawing.Point(608, 393);
            this.Crea.Name = "Crea";
            this.Crea.Size = new System.Drawing.Size(164, 56);
            this.Crea.TabIndex = 0;
            this.Crea.Text = "Crea";
            this.Crea.UseVisualStyleBackColor = true;
            this.Crea.Click += new System.EventHandler(this.Crea_Click);
            // 
            // txtTipologia
            // 
            this.txtTipologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipologia.Location = new System.Drawing.Point(558, 149);
            this.txtTipologia.Name = "txtTipologia";
            this.txtTipologia.Size = new System.Drawing.Size(311, 45);
            this.txtTipologia.TabIndex = 1;
            // 
            // lblTipologia
            // 
            this.lblTipologia.AutoSize = true;
            this.lblTipologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipologia.Location = new System.Drawing.Point(386, 155);
            this.lblTipologia.Name = "lblTipologia";
            this.lblTipologia.Size = new System.Drawing.Size(166, 39);
            this.lblTipologia.TabIndex = 2;
            this.lblTipologia.Text = "Tipologia:";
            // 
            // lblQuantità
            // 
            this.lblQuantità.AutoSize = true;
            this.lblQuantità.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantità.Location = new System.Drawing.Point(386, 235);
            this.lblQuantità.Name = "lblQuantità";
            this.lblQuantità.Size = new System.Drawing.Size(154, 39);
            this.lblQuantità.TabIndex = 4;
            this.lblQuantità.Text = "Quantità:";
            // 
            // txtQuantita
            // 
            this.txtQuantita.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantita.Location = new System.Drawing.Point(558, 232);
            this.txtQuantita.Name = "txtQuantita";
            this.txtQuantita.Size = new System.Drawing.Size(311, 45);
            this.txtQuantita.TabIndex = 3;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(386, 303);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(115, 39);
            this.lblCosto.TabIndex = 6;
            this.lblCosto.Text = "Costo:";
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(558, 303);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(311, 45);
            this.txtCosto.TabIndex = 5;
            // 
            // lblTitoloCreaPiatto
            // 
            this.lblTitoloCreaPiatto.AutoSize = true;
            this.lblTitoloCreaPiatto.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitoloCreaPiatto.Location = new System.Drawing.Point(515, 24);
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
            this.tabGestioneComande.Controls.Add(this.tabPage4);
            this.tabGestioneComande.Location = new System.Drawing.Point(3, 12);
            this.tabGestioneComande.Name = "tabGestioneComande";
            this.tabGestioneComande.SelectedIndex = 0;
            this.tabGestioneComande.Size = new System.Drawing.Size(1410, 668);
            this.tabGestioneComande.TabIndex = 9;
            this.tabGestioneComande.SelectedIndexChanged += new System.EventHandler(this.tabGestioneComande_SelectedIndexchanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
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
            this.tabPage1.Size = new System.Drawing.Size(1402, 639);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crea piatto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(689, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Questa funzione permette di creare un piatto che sarà poi visualizzato durante la" +
    " creazione di una comanda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(559, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Inserisci il costo del piatto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(558, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Inserisci la quantità disponibile";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Inserisci il nome del piatto\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnSalvaListaPiatti);
            this.tabPage2.Controls.Add(this.gdrListaPiatti);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1402, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista piatti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1218, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista piatti";
            // 
            // btnSalvaListaPiatti
            // 
            this.btnSalvaListaPiatti.Location = new System.Drawing.Point(673, 585);
            this.btnSalvaListaPiatti.Name = "btnSalvaListaPiatti";
            this.btnSalvaListaPiatti.Size = new System.Drawing.Size(95, 51);
            this.btnSalvaListaPiatti.TabIndex = 1;
            this.btnSalvaListaPiatti.Text = "Salva";
            this.btnSalvaListaPiatti.UseVisualStyleBackColor = true;
            this.btnSalvaListaPiatti.Click += new System.EventHandler(this.btnSalvaListaPiatti_Click);
            // 
            // gdrListaPiatti
            // 
            this.gdrListaPiatti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gdrListaPiatti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gdrListaPiatti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdrListaPiatti.DefaultCellStyle = dataGridViewCellStyle1;
            this.gdrListaPiatti.Location = new System.Drawing.Point(10, 87);
            this.gdrListaPiatti.Name = "gdrListaPiatti";
            this.gdrListaPiatti.RowTemplate.Height = 24;
            this.gdrListaPiatti.Size = new System.Drawing.Size(1386, 495);
            this.gdrListaPiatti.TabIndex = 0;
            this.gdrListaPiatti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrListaPiatti_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.lblCostoTotale);
            this.tabPage3.Controls.Add(this.lblTotale);
            this.tabPage3.Controls.Add(this.lblOraAttuale);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lblDataAttuale);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtNominativo);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.gdvComanda);
            this.tabPage3.Controls.Add(this.btnCreaComanda);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1402, 639);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Crea comanda";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1125, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Questa funzione permette di creare una comanda. Imposta la quantità desiderata ed" +
    " in automatico verrà calcolato il totale. Cliccare sul pulsante \"Stampa\" per cre" +
    "are la comanda.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, -9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(470, 76);
            this.label5.TabIndex = 10;
            this.label5.Text = "Crea comanda";
            // 
            // lblCostoTotale
            // 
            this.lblCostoTotale.AutoSize = true;
            this.lblCostoTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotale.Location = new System.Drawing.Point(1027, 558);
            this.lblCostoTotale.Name = "lblCostoTotale";
            this.lblCostoTotale.Size = new System.Drawing.Size(0, 39);
            this.lblCostoTotale.TabIndex = 9;
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotale.Location = new System.Drawing.Point(891, 558);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(121, 39);
            this.lblTotale.TabIndex = 8;
            this.lblTotale.Text = "Totale:";
            // 
            // lblOraAttuale
            // 
            this.lblOraAttuale.AutoSize = true;
            this.lblOraAttuale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOraAttuale.Location = new System.Drawing.Point(665, 593);
            this.lblOraAttuale.Name = "lblOraAttuale";
            this.lblOraAttuale.Size = new System.Drawing.Size(73, 39);
            this.lblOraAttuale.TabIndex = 7;
            this.lblOraAttuale.Text = "Ora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ora:";
            // 
            // lblDataAttuale
            // 
            this.lblDataAttuale.AutoSize = true;
            this.lblDataAttuale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAttuale.Location = new System.Drawing.Point(665, 555);
            this.lblDataAttuale.Name = "lblDataAttuale";
            this.lblDataAttuale.Size = new System.Drawing.Size(89, 39);
            this.lblDataAttuale.TabIndex = 5;
            this.lblDataAttuale.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(561, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data:";
            // 
            // txtNominativo
            // 
            this.txtNominativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNominativo.Location = new System.Drawing.Point(209, 552);
            this.txtNominativo.Name = "txtNominativo";
            this.txtNominativo.Size = new System.Drawing.Size(340, 45);
            this.txtNominativo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nominativo:";
            // 
            // gdvComanda
            // 
            this.gdvComanda.AllowUserToAddRows = false;
            this.gdvComanda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gdvComanda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gdvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvComanda.DefaultCellStyle = dataGridViewCellStyle2;
            this.gdvComanda.Location = new System.Drawing.Point(13, 82);
            this.gdvComanda.Name = "gdvComanda";
            this.gdvComanda.RowTemplate.Height = 24;
            this.gdvComanda.Size = new System.Drawing.Size(1365, 459);
            this.gdvComanda.TabIndex = 1;
            this.gdvComanda.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvComanda_CellEndEdit);
            // 
            // btnCreaComanda
            // 
            this.btnCreaComanda.Location = new System.Drawing.Point(1230, 550);
            this.btnCreaComanda.Name = "btnCreaComanda";
            this.btnCreaComanda.Size = new System.Drawing.Size(147, 61);
            this.btnCreaComanda.TabIndex = 0;
            this.btnCreaComanda.Text = "Stampa";
            this.btnCreaComanda.UseVisualStyleBackColor = true;
            this.btnCreaComanda.Click += new System.EventHandler(this.btnCreaComanda_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnEsportaXls);
            this.tabPage4.Controls.Add(this.lblTotaleIncassoOggi);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.gdvComandeOggi);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1402, 639);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Visualizza comande";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblTotaleIncassoOggi
            // 
            this.lblTotaleIncassoOggi.AutoSize = true;
            this.lblTotaleIncassoOggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaleIncassoOggi.Location = new System.Drawing.Point(214, 600);
            this.lblTotaleIncassoOggi.Name = "lblTotaleIncassoOggi";
            this.lblTotaleIncassoOggi.Size = new System.Drawing.Size(0, 29);
            this.lblTotaleIncassoOggi.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 600);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 29);
            this.label14.TabIndex = 3;
            this.label14.Text = "Totale incasso:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(431, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(519, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Lista di tutte le comande emesse nella giornata odierna con il calcolo dell\'incas" +
    "so";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(529, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(348, 39);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lista comande di oggi";
            // 
            // gdvComandeOggi
            // 
            this.gdvComandeOggi.AllowUserToAddRows = false;
            this.gdvComandeOggi.AllowUserToDeleteRows = false;
            this.gdvComandeOggi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvComandeOggi.Location = new System.Drawing.Point(5, 73);
            this.gdvComandeOggi.Name = "gdvComandeOggi";
            this.gdvComandeOggi.ReadOnly = true;
            this.gdvComandeOggi.RowTemplate.Height = 24;
            this.gdvComandeOggi.Size = new System.Drawing.Size(1391, 520);
            this.gdvComandeOggi.TabIndex = 0;
            this.gdvComandeOggi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvComandeOggi_CellClick);
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
            // btnEsportaXls
            // 
            this.btnEsportaXls.Location = new System.Drawing.Point(1182, 600);
            this.btnEsportaXls.Name = "btnEsportaXls";
            this.btnEsportaXls.Size = new System.Drawing.Size(178, 33);
            this.btnEsportaXls.TabIndex = 5;
            this.btnEsportaXls.Text = "Esporta file excel";
            this.btnEsportaXls.UseVisualStyleBackColor = true;
            this.btnEsportaXls.Click += new System.EventHandler(this.btnEsportaXls_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 685);
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
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvComandeOggi)).EndInit();
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
        private System.Windows.Forms.Button btnCreaComanda;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gdvComandeOggi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotaleIncassoOggi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEsportaXls;
    }
}

