﻿using System;
using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Crea = new System.Windows.Forms.Button();
            this.tabGestioneComande = new System.Windows.Forms.TabControl();
            this.tabConfigura = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txtOperatore = new System.Windows.Forms.TextBox();
            this.lblTipsOperatore = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblTipsSerie = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSalvaConfigurazione = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtIntestazione = new System.Windows.Forms.TextBox();
            this.lblTipsIntestazione = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNumeroComandaIniziale = new System.Windows.Forms.TextBox();
            this.lblTipsNumeroPartenza = new System.Windows.Forms.Label();
            this.tabCreaPiatto = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtQuantita = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCosto = new MaterialSkin.Controls.MaterialTextBox();
            this.ddlTipo = new MaterialSkin.Controls.MaterialComboBox();
            this.txtTipologia = new MaterialSkin.Controls.MaterialTextBox();
            this.tabListaPiatti = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvaListaPiatti = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.gdrListaPiatti = new System.Windows.Forms.DataGridView();
            this.tabCreaComanda = new System.Windows.Forms.TabPage();
            this.numPagato = new System.Windows.Forms.NumericUpDown();
            this.lblResto = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.tabVisualizzaComande = new System.Windows.Forms.TabPage();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.btnCercaComande = new System.Windows.Forms.Button();
            this.comandeDataFine = new System.Windows.Forms.DateTimePicker();
            this.comandeDataInizio = new System.Windows.Forms.DateTimePicker();
            this.btnEsportaXls = new System.Windows.Forms.Button();
            this.lblTotaleIncassoOggi = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gdvComandeOggi = new System.Windows.Forms.DataGridView();
            this.tabStatistiche = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btnCercaStatistiche = new System.Windows.Forms.Button();
            this.statsDataFine = new System.Windows.Forms.DateTimePicker();
            this.statsDataInizio = new System.Windows.Forms.DateTimePicker();
            this.lblStatisticheIncasso = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.btnEsportaXlsStatistiche = new System.Windows.Forms.Button();
            this.gdvStatistiche = new System.Windows.Forms.DataGridView();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnStatistiche = new FontAwesome.Sharp.IconButton();
            this.btnVisualizzaComande = new FontAwesome.Sharp.IconButton();
            this.btnComanda = new FontAwesome.Sharp.IconButton();
            this.btnListaPiatti = new FontAwesome.Sharp.IconButton();
            this.btnCreaPiatto = new FontAwesome.Sharp.IconButton();
            this.btnConfigurazione = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblTitoloStato = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.iconDropDownButton2 = new FontAwesome.Sharp.IconDropDownButton();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNomeProgramma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNomeTipologia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabGestioneComande.SuspendLayout();
            this.tabConfigura.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabCreaPiatto.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabListaPiatti.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrListaPiatti)).BeginInit();
            this.tabCreaComanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPagato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvComanda)).BeginInit();
            this.tabVisualizzaComande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvComandeOggi)).BeginInit();
            this.tabStatistiche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvStatistiche)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Crea
            // 
            this.Crea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Crea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crea.Location = new System.Drawing.Point(765, 670);
            this.Crea.Name = "Crea";
            this.Crea.Size = new System.Drawing.Size(164, 56);
            this.Crea.TabIndex = 0;
            this.Crea.Text = "Crea";
            this.Crea.UseVisualStyleBackColor = true;
            this.Crea.Click += new System.EventHandler(this.Crea_Click);
            // 
            // tabGestioneComande
            // 
            this.tabGestioneComande.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabGestioneComande.Controls.Add(this.tabHome);
            this.tabGestioneComande.Controls.Add(this.tabConfigura);
            this.tabGestioneComande.Controls.Add(this.tabCreaPiatto);
            this.tabGestioneComande.Controls.Add(this.tabListaPiatti);
            this.tabGestioneComande.Controls.Add(this.tabCreaComanda);
            this.tabGestioneComande.Controls.Add(this.tabVisualizzaComande);
            this.tabGestioneComande.Controls.Add(this.tabStatistiche);
            this.tabGestioneComande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGestioneComande.ItemSize = new System.Drawing.Size(50, 50);
            this.tabGestioneComande.Location = new System.Drawing.Point(0, 0);
            this.tabGestioneComande.Name = "tabGestioneComande";
            this.tabGestioneComande.SelectedIndex = 0;
            this.tabGestioneComande.Size = new System.Drawing.Size(1426, 940);
            this.tabGestioneComande.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabGestioneComande.TabIndex = 9;
            this.tabGestioneComande.SelectedIndexChanged += new System.EventHandler(this.tabGestioneComande_SelectedIndexchanged);
            // 
            // tabConfigura
            // 
            this.tabConfigura.Controls.Add(this.tableLayoutPanel2);
            this.tabConfigura.Location = new System.Drawing.Point(4, 54);
            this.tabConfigura.Name = "tabConfigura";
            this.tabConfigura.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfigura.Size = new System.Drawing.Size(1418, 882);
            this.tabConfigura.TabIndex = 4;
            this.tabConfigura.Text = "Configura";
            this.tabConfigura.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.86686F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.13315F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label20, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnSalvaConfigurazione, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1412, 876);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.txtOperatore, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblTipsOperatore, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(340, 528);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1069, 169);
            this.tableLayoutPanel6.TabIndex = 14;
            // 
            // txtOperatore
            // 
            this.txtOperatore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOperatore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperatore.Location = new System.Drawing.Point(402, 19);
            this.txtOperatore.Name = "txtOperatore";
            this.txtOperatore.Size = new System.Drawing.Size(265, 45);
            this.txtOperatore.TabIndex = 9;
            // 
            // lblTipsOperatore
            // 
            this.lblTipsOperatore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipsOperatore.AutoSize = true;
            this.lblTipsOperatore.Location = new System.Drawing.Point(274, 84);
            this.lblTipsOperatore.Name = "lblTipsOperatore";
            this.lblTipsOperatore.Size = new System.Drawing.Size(520, 17);
            this.lblTipsOperatore.TabIndex = 13;
            this.lblTipsOperatore.Text = "Impostare il nome dell\'operatore che andrà a creare le comande col il programma";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.txtSerie, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblTipsSerie, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(340, 353);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1069, 169);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // txtSerie
            // 
            this.txtSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(484, 19);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 45);
            this.txtSerie.TabIndex = 4;
            // 
            // lblTipsSerie
            // 
            this.lblTipsSerie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipsSerie.AutoSize = true;
            this.lblTipsSerie.Location = new System.Drawing.Point(230, 84);
            this.lblTipsSerie.Name = "lblTipsSerie";
            this.lblTipsSerie.Size = new System.Drawing.Size(608, 17);
            this.lblTipsSerie.TabIndex = 12;
            this.lblTipsSerie.Text = "Imposta una serie (Esempio: \"/a\") che verrà combinata col numero di comanda (Esem" +
    "pio: \"1/a\")";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(63, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(210, 39);
            this.label16.TabIndex = 1;
            this.label16.Text = "Intestazione:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(48, 204);
            this.label17.MaximumSize = new System.Drawing.Size(300, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(240, 117);
            this.label17.TabIndex = 5;
            this.label17.Text = "Numero di partenza delle comande:";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(79, 593);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(178, 39);
            this.label20.TabIndex = 8;
            this.label20.Text = "Operatore:";
            // 
            // btnSalvaConfigurazione
            // 
            this.btnSalvaConfigurazione.Location = new System.Drawing.Point(340, 703);
            this.btnSalvaConfigurazione.Name = "btnSalvaConfigurazione";
            this.btnSalvaConfigurazione.Size = new System.Drawing.Size(208, 80);
            this.btnSalvaConfigurazione.TabIndex = 7;
            this.btnSalvaConfigurazione.Text = "Salva";
            this.btnSalvaConfigurazione.UseVisualStyleBackColor = true;
            this.btnSalvaConfigurazione.Click += new System.EventHandler(this.btnSalvaConfigurazione_Click);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(115, 418);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 39);
            this.label18.TabIndex = 6;
            this.label18.Text = "Serie:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txtIntestazione, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTipsIntestazione, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(340, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1069, 169);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // txtIntestazione
            // 
            this.txtIntestazione.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtIntestazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntestazione.Location = new System.Drawing.Point(402, 36);
            this.txtIntestazione.Name = "txtIntestazione";
            this.txtIntestazione.Size = new System.Drawing.Size(265, 45);
            this.txtIntestazione.TabIndex = 2;
            // 
            // lblTipsIntestazione
            // 
            this.lblTipsIntestazione.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipsIntestazione.AutoSize = true;
            this.lblTipsIntestazione.Location = new System.Drawing.Point(335, 84);
            this.lblTipsIntestazione.Name = "lblTipsIntestazione";
            this.lblTipsIntestazione.Size = new System.Drawing.Size(399, 17);
            this.lblTipsIntestazione.TabIndex = 10;
            this.lblTipsIntestazione.Text = "Imposta l\'intestazione che verrà mostrata sopra ogni comanda";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.txtNumeroComandaIniziale, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTipsNumeroPartenza, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(340, 178);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1069, 169);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // txtNumeroComandaIniziale
            // 
            this.txtNumeroComandaIniziale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumeroComandaIniziale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroComandaIniziale.Location = new System.Drawing.Point(484, 19);
            this.txtNumeroComandaIniziale.Name = "txtNumeroComandaIniziale";
            this.txtNumeroComandaIniziale.Size = new System.Drawing.Size(100, 45);
            this.txtNumeroComandaIniziale.TabIndex = 3;
            // 
            // lblTipsNumeroPartenza
            // 
            this.lblTipsNumeroPartenza.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipsNumeroPartenza.AutoSize = true;
            this.lblTipsNumeroPartenza.Location = new System.Drawing.Point(232, 84);
            this.lblTipsNumeroPartenza.MaximumSize = new System.Drawing.Size(800, 0);
            this.lblTipsNumeroPartenza.Name = "lblTipsNumeroPartenza";
            this.lblTipsNumeroPartenza.Size = new System.Drawing.Size(605, 34);
            this.lblTipsNumeroPartenza.TabIndex = 11;
            this.lblTipsNumeroPartenza.Text = "Imposta il numero di partenza delle comande che verrà incrementato ad ogni comand" +
    "a creata. \r\n(Esempio: Inserendo 1 la prima comanda sarà creata col numero 1)";
            // 
            // tabCreaPiatto
            // 
            this.tabCreaPiatto.Controls.Add(this.tableLayoutPanel1);
            this.tabCreaPiatto.Location = new System.Drawing.Point(4, 54);
            this.tabCreaPiatto.Name = "tabCreaPiatto";
            this.tabCreaPiatto.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreaPiatto.Size = new System.Drawing.Size(1418, 782);
            this.tabCreaPiatto.TabIndex = 0;
            this.tabCreaPiatto.Text = "Crea piatto";
            this.tabCreaPiatto.UseVisualStyleBackColor = true;
            this.tabCreaPiatto.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Crea, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtQuantita, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCosto, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ddlTipo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTipologia, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNomeTipologia, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1412, 776);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // txtQuantita
            // 
            this.txtQuantita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantita.AnimateReadOnly = false;
            this.txtQuantita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantita.Depth = 0;
            this.txtQuantita.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantita.LeadingIcon = null;
            this.txtQuantita.Location = new System.Drawing.Point(736, 517);
            this.txtQuantita.MaxLength = 50;
            this.txtQuantita.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantita.Multiline = false;
            this.txtQuantita.Name = "txtQuantita";
            this.txtQuantita.Size = new System.Drawing.Size(222, 50);
            this.txtQuantita.TabIndex = 6;
            this.txtQuantita.Text = "";
            this.txtQuantita.TrailingIcon = null;
            this.txtQuantita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantita_KeyPress);
            // 
            // txtCosto
            // 
            this.txtCosto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCosto.AnimateReadOnly = false;
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCosto.Depth = 0;
            this.txtCosto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCosto.LeadingIcon = null;
            this.txtCosto.Location = new System.Drawing.Point(748, 362);
            this.txtCosto.MaxLength = 50;
            this.txtCosto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCosto.Multiline = false;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(197, 50);
            this.txtCosto.TabIndex = 7;
            this.txtCosto.Text = "";
            this.txtCosto.TrailingIcon = null;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // ddlTipo
            // 
            this.ddlTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ddlTipo.AutoResize = false;
            this.ddlTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ddlTipo.Depth = 0;
            this.ddlTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ddlTipo.DropDownHeight = 174;
            this.ddlTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipo.DropDownWidth = 121;
            this.ddlTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ddlTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ddlTipo.FormattingEnabled = true;
            this.ddlTipo.IntegralHeight = false;
            this.ddlTipo.ItemHeight = 43;
            this.ddlTipo.Items.AddRange(new object[] {
            "Piatto",
            "Bevanda"});
            this.ddlTipo.Location = new System.Drawing.Point(786, 208);
            this.ddlTipo.MaxDropDownItems = 4;
            this.ddlTipo.MouseState = MaterialSkin.MouseState.OUT;
            this.ddlTipo.Name = "ddlTipo";
            this.ddlTipo.Size = new System.Drawing.Size(121, 49);
            this.ddlTipo.StartIndex = 0;
            this.ddlTipo.TabIndex = 1;
            // 
            // txtTipologia
            // 
            this.txtTipologia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTipologia.AnimateReadOnly = false;
            this.txtTipologia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipologia.Depth = 0;
            this.txtTipologia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTipologia.LeadingIcon = null;
            this.txtTipologia.Location = new System.Drawing.Point(748, 52);
            this.txtTipologia.MaxLength = 50;
            this.txtTipologia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTipologia.Multiline = false;
            this.txtTipologia.Name = "txtTipologia";
            this.txtTipologia.Size = new System.Drawing.Size(197, 50);
            this.txtTipologia.TabIndex = 5;
            this.txtTipologia.Text = "";
            this.txtTipologia.TrailingIcon = null;
            // 
            // tabListaPiatti
            // 
            this.tabListaPiatti.Controls.Add(this.panel1);
            this.tabListaPiatti.Location = new System.Drawing.Point(4, 54);
            this.tabListaPiatti.Name = "tabListaPiatti";
            this.tabListaPiatti.Padding = new System.Windows.Forms.Padding(3);
            this.tabListaPiatti.Size = new System.Drawing.Size(1418, 782);
            this.tabListaPiatti.TabIndex = 1;
            this.tabListaPiatti.Text = "Lista piatti";
            this.tabListaPiatti.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalvaListaPiatti);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.gdrListaPiatti);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 776);
            this.panel1.TabIndex = 4;
            // 
            // btnSalvaListaPiatti
            // 
            this.btnSalvaListaPiatti.Location = new System.Drawing.Point(536, 618);
            this.btnSalvaListaPiatti.Name = "btnSalvaListaPiatti";
            this.btnSalvaListaPiatti.Size = new System.Drawing.Size(95, 51);
            this.btnSalvaListaPiatti.TabIndex = 1;
            this.btnSalvaListaPiatti.Text = "Salva";
            this.btnSalvaListaPiatti.UseVisualStyleBackColor = true;
            this.btnSalvaListaPiatti.Click += new System.EventHandler(this.btnSalvaListaPiatti_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(667, 34);
            this.label11.TabIndex = 3;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // gdrListaPiatti
            // 
            this.gdrListaPiatti.AllowUserToAddRows = false;
            this.gdrListaPiatti.AllowUserToOrderColumns = true;
            this.gdrListaPiatti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gdrListaPiatti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gdrListaPiatti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdrListaPiatti.DefaultCellStyle = dataGridViewCellStyle5;
            this.gdrListaPiatti.Location = new System.Drawing.Point(28, 117);
            this.gdrListaPiatti.Name = "gdrListaPiatti";
            this.gdrListaPiatti.RowHeadersWidth = 51;
            this.gdrListaPiatti.RowTemplate.Height = 24;
            this.gdrListaPiatti.Size = new System.Drawing.Size(1084, 495);
            this.gdrListaPiatti.TabIndex = 0;
            this.gdrListaPiatti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrListaPiatti_CellClick);
            // 
            // tabCreaComanda
            // 
            this.tabCreaComanda.Controls.Add(this.numPagato);
            this.tabCreaComanda.Controls.Add(this.lblResto);
            this.tabCreaComanda.Controls.Add(this.label22);
            this.tabCreaComanda.Controls.Add(this.label21);
            this.tabCreaComanda.Controls.Add(this.label12);
            this.tabCreaComanda.Controls.Add(this.lblCostoTotale);
            this.tabCreaComanda.Controls.Add(this.lblTotale);
            this.tabCreaComanda.Controls.Add(this.lblOraAttuale);
            this.tabCreaComanda.Controls.Add(this.label4);
            this.tabCreaComanda.Controls.Add(this.lblDataAttuale);
            this.tabCreaComanda.Controls.Add(this.label3);
            this.tabCreaComanda.Controls.Add(this.txtNominativo);
            this.tabCreaComanda.Controls.Add(this.label2);
            this.tabCreaComanda.Controls.Add(this.gdvComanda);
            this.tabCreaComanda.Controls.Add(this.btnCreaComanda);
            this.tabCreaComanda.Location = new System.Drawing.Point(4, 54);
            this.tabCreaComanda.Name = "tabCreaComanda";
            this.tabCreaComanda.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreaComanda.Size = new System.Drawing.Size(1418, 782);
            this.tabCreaComanda.TabIndex = 2;
            this.tabCreaComanda.Text = "Crea comanda";
            this.tabCreaComanda.UseVisualStyleBackColor = true;
            // 
            // numPagato
            // 
            this.numPagato.DecimalPlaces = 2;
            this.numPagato.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPagato.Location = new System.Drawing.Point(1062, 348);
            this.numPagato.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPagato.Name = "numPagato";
            this.numPagato.Size = new System.Drawing.Size(186, 45);
            this.numPagato.TabIndex = 16;
            this.numPagato.ValueChanged += new System.EventHandler(this.numPagato_ValueChanged);
            this.numPagato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numPagato_KeyPress);
            this.numPagato.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numPagato_KeyUp);
            // 
            // lblResto
            // 
            this.lblResto.AutoSize = true;
            this.lblResto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResto.Location = new System.Drawing.Point(1055, 410);
            this.lblResto.Name = "lblResto";
            this.lblResto.Size = new System.Drawing.Size(0, 39);
            this.lblResto.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(909, 412);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 39);
            this.label22.TabIndex = 14;
            this.label22.Text = "Resto:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(890, 350);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(134, 39);
            this.label21.TabIndex = 12;
            this.label21.Text = "Pagato:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1125, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Questa funzione permette di creare una comanda. Imposta la quantità desiderata ed" +
    " in automatico verrà calcolato il totale. Cliccare sul pulsante \"Stampa\" per cre" +
    "are la comanda.";
            // 
            // lblCostoTotale
            // 
            this.lblCostoTotale.AutoSize = true;
            this.lblCostoTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotale.Location = new System.Drawing.Point(1062, 295);
            this.lblCostoTotale.Name = "lblCostoTotale";
            this.lblCostoTotale.Size = new System.Drawing.Size(0, 39);
            this.lblCostoTotale.TabIndex = 9;
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotale.Location = new System.Drawing.Point(903, 297);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(121, 39);
            this.lblTotale.TabIndex = 8;
            this.lblTotale.Text = "Totale:";
            // 
            // lblOraAttuale
            // 
            this.lblOraAttuale.AutoSize = true;
            this.lblOraAttuale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOraAttuale.Location = new System.Drawing.Point(1063, 197);
            this.lblOraAttuale.Name = "lblOraAttuale";
            this.lblOraAttuale.Size = new System.Drawing.Size(73, 39);
            this.lblOraAttuale.TabIndex = 7;
            this.lblOraAttuale.Text = "Ora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(962, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ora:";
            // 
            // lblDataAttuale
            // 
            this.lblDataAttuale.AutoSize = true;
            this.lblDataAttuale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAttuale.Location = new System.Drawing.Point(1063, 149);
            this.lblDataAttuale.Name = "lblDataAttuale";
            this.lblDataAttuale.Size = new System.Drawing.Size(89, 39);
            this.lblDataAttuale.TabIndex = 5;
            this.lblDataAttuale.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(946, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data:";
            // 
            // txtNominativo
            // 
            this.txtNominativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNominativo.Location = new System.Drawing.Point(1062, 42);
            this.txtNominativo.Name = "txtNominativo";
            this.txtNominativo.Size = new System.Drawing.Size(340, 45);
            this.txtNominativo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(847, 42);
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvComanda.DefaultCellStyle = dataGridViewCellStyle6;
            this.gdvComanda.Location = new System.Drawing.Point(6, 42);
            this.gdvComanda.Name = "gdvComanda";
            this.gdvComanda.RowHeadersWidth = 51;
            this.gdvComanda.RowTemplate.Height = 24;
            this.gdvComanda.Size = new System.Drawing.Size(822, 551);
            this.gdvComanda.TabIndex = 1;
            this.gdvComanda.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvComanda_CellEndEdit);
            // 
            // btnCreaComanda
            // 
            this.btnCreaComanda.Location = new System.Drawing.Point(1062, 466);
            this.btnCreaComanda.Name = "btnCreaComanda";
            this.btnCreaComanda.Size = new System.Drawing.Size(147, 61);
            this.btnCreaComanda.TabIndex = 0;
            this.btnCreaComanda.Text = "Stampa";
            this.btnCreaComanda.UseVisualStyleBackColor = true;
            this.btnCreaComanda.Click += new System.EventHandler(this.btnCreaComanda_Click);
            // 
            // tabVisualizzaComande
            // 
            this.tabVisualizzaComande.Controls.Add(this.label32);
            this.tabVisualizzaComande.Controls.Add(this.label33);
            this.tabVisualizzaComande.Controls.Add(this.btnCercaComande);
            this.tabVisualizzaComande.Controls.Add(this.comandeDataFine);
            this.tabVisualizzaComande.Controls.Add(this.comandeDataInizio);
            this.tabVisualizzaComande.Controls.Add(this.btnEsportaXls);
            this.tabVisualizzaComande.Controls.Add(this.lblTotaleIncassoOggi);
            this.tabVisualizzaComande.Controls.Add(this.label14);
            this.tabVisualizzaComande.Controls.Add(this.label13);
            this.tabVisualizzaComande.Controls.Add(this.gdvComandeOggi);
            this.tabVisualizzaComande.Location = new System.Drawing.Point(4, 54);
            this.tabVisualizzaComande.Name = "tabVisualizzaComande";
            this.tabVisualizzaComande.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisualizzaComande.Size = new System.Drawing.Size(1418, 782);
            this.tabVisualizzaComande.TabIndex = 3;
            this.tabVisualizzaComande.Text = "Visualizza comande";
            this.tabVisualizzaComande.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(839, 510);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(65, 17);
            this.label32.TabIndex = 14;
            this.label32.Text = "Data fine";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(584, 510);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(74, 17);
            this.label33.TabIndex = 13;
            this.label33.Text = "Data inizio";
            // 
            // btnCercaComande
            // 
            this.btnCercaComande.Location = new System.Drawing.Point(684, 574);
            this.btnCercaComande.Name = "btnCercaComande";
            this.btnCercaComande.Size = new System.Drawing.Size(139, 46);
            this.btnCercaComande.TabIndex = 12;
            this.btnCercaComande.Text = "Cerca";
            this.btnCercaComande.UseVisualStyleBackColor = true;
            this.btnCercaComande.Click += new System.EventHandler(this.btnCercaComande_Click);
            // 
            // comandeDataFine
            // 
            this.comandeDataFine.Location = new System.Drawing.Point(770, 546);
            this.comandeDataFine.Name = "comandeDataFine";
            this.comandeDataFine.Size = new System.Drawing.Size(232, 22);
            this.comandeDataFine.TabIndex = 11;
            // 
            // comandeDataInizio
            // 
            this.comandeDataInizio.Location = new System.Drawing.Point(512, 546);
            this.comandeDataInizio.Name = "comandeDataInizio";
            this.comandeDataInizio.Size = new System.Drawing.Size(224, 22);
            this.comandeDataInizio.TabIndex = 10;
            // 
            // btnEsportaXls
            // 
            this.btnEsportaXls.Location = new System.Drawing.Point(1213, 587);
            this.btnEsportaXls.Name = "btnEsportaXls";
            this.btnEsportaXls.Size = new System.Drawing.Size(178, 33);
            this.btnEsportaXls.TabIndex = 5;
            this.btnEsportaXls.Text = "Esporta file excel";
            this.btnEsportaXls.UseVisualStyleBackColor = true;
            this.btnEsportaXls.Click += new System.EventHandler(this.btnEsportaXls_Click_1);
            // 
            // lblTotaleIncassoOggi
            // 
            this.lblTotaleIncassoOggi.AutoSize = true;
            this.lblTotaleIncassoOggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaleIncassoOggi.Location = new System.Drawing.Point(245, 587);
            this.lblTotaleIncassoOggi.Name = "lblTotaleIncassoOggi";
            this.lblTotaleIncassoOggi.Size = new System.Drawing.Size(0, 29);
            this.lblTotaleIncassoOggi.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(55, 587);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 29);
            this.label14.TabIndex = 3;
            this.label14.Text = "Totale incasso:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(527, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(377, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Lista di tutte le comande emesse con il calcolo dell\'incasso";
            // 
            // gdvComandeOggi
            // 
            this.gdvComandeOggi.AllowUserToAddRows = false;
            this.gdvComandeOggi.AllowUserToDeleteRows = false;
            this.gdvComandeOggi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvComandeOggi.Location = new System.Drawing.Point(36, 60);
            this.gdvComandeOggi.Name = "gdvComandeOggi";
            this.gdvComandeOggi.ReadOnly = true;
            this.gdvComandeOggi.RowHeadersWidth = 51;
            this.gdvComandeOggi.RowTemplate.Height = 24;
            this.gdvComandeOggi.Size = new System.Drawing.Size(1391, 436);
            this.gdvComandeOggi.TabIndex = 0;
            this.gdvComandeOggi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvComandeOggi_CellClick);
            // 
            // tabStatistiche
            // 
            this.tabStatistiche.Controls.Add(this.label31);
            this.tabStatistiche.Controls.Add(this.label30);
            this.tabStatistiche.Controls.Add(this.btnCercaStatistiche);
            this.tabStatistiche.Controls.Add(this.statsDataFine);
            this.tabStatistiche.Controls.Add(this.statsDataInizio);
            this.tabStatistiche.Controls.Add(this.lblStatisticheIncasso);
            this.tabStatistiche.Controls.Add(this.label29);
            this.tabStatistiche.Controls.Add(this.btnEsportaXlsStatistiche);
            this.tabStatistiche.Controls.Add(this.gdvStatistiche);
            this.tabStatistiche.Location = new System.Drawing.Point(4, 54);
            this.tabStatistiche.Name = "tabStatistiche";
            this.tabStatistiche.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistiche.Size = new System.Drawing.Size(1418, 782);
            this.tabStatistiche.TabIndex = 5;
            this.tabStatistiche.Text = "Statistiche";
            this.tabStatistiche.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(1640, 179);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 17);
            this.label31.TabIndex = 9;
            this.label31.Text = "Data fine";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(1066, 91);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(74, 17);
            this.label30.TabIndex = 8;
            this.label30.Text = "Data inizio";
            // 
            // btnCercaStatistiche
            // 
            this.btnCercaStatistiche.Location = new System.Drawing.Point(1166, 168);
            this.btnCercaStatistiche.Name = "btnCercaStatistiche";
            this.btnCercaStatistiche.Size = new System.Drawing.Size(139, 46);
            this.btnCercaStatistiche.TabIndex = 7;
            this.btnCercaStatistiche.Text = "Cerca";
            this.btnCercaStatistiche.UseVisualStyleBackColor = true;
            this.btnCercaStatistiche.Click += new System.EventHandler(this.btnCercaStatistiche_Click);
            // 
            // statsDataFine
            // 
            this.statsDataFine.Location = new System.Drawing.Point(1252, 127);
            this.statsDataFine.Name = "statsDataFine";
            this.statsDataFine.Size = new System.Drawing.Size(232, 22);
            this.statsDataFine.TabIndex = 6;
            // 
            // statsDataInizio
            // 
            this.statsDataInizio.Location = new System.Drawing.Point(994, 127);
            this.statsDataInizio.Name = "statsDataInizio";
            this.statsDataInizio.Size = new System.Drawing.Size(224, 22);
            this.statsDataInizio.TabIndex = 5;
            // 
            // lblStatisticheIncasso
            // 
            this.lblStatisticheIncasso.AutoSize = true;
            this.lblStatisticheIncasso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatisticheIncasso.Location = new System.Drawing.Point(1255, 466);
            this.lblStatisticheIncasso.Name = "lblStatisticheIncasso";
            this.lblStatisticheIncasso.Size = new System.Drawing.Size(0, 39);
            this.lblStatisticheIncasso.TabIndex = 4;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(987, 466);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(246, 39);
            this.label29.TabIndex = 3;
            this.label29.Text = "Totale incasso:";
            // 
            // btnEsportaXlsStatistiche
            // 
            this.btnEsportaXlsStatistiche.Location = new System.Drawing.Point(1132, 534);
            this.btnEsportaXlsStatistiche.Name = "btnEsportaXlsStatistiche";
            this.btnEsportaXlsStatistiche.Size = new System.Drawing.Size(173, 55);
            this.btnEsportaXlsStatistiche.TabIndex = 2;
            this.btnEsportaXlsStatistiche.Text = "Esporta excel";
            this.btnEsportaXlsStatistiche.UseVisualStyleBackColor = true;
            this.btnEsportaXlsStatistiche.Click += new System.EventHandler(this.btnEsportaXlsStatistiche_Click_1);
            // 
            // gdvStatistiche
            // 
            this.gdvStatistiche.AllowUserToAddRows = false;
            this.gdvStatistiche.AllowUserToDeleteRows = false;
            this.gdvStatistiche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvStatistiche.Location = new System.Drawing.Point(43, 59);
            this.gdvStatistiche.Name = "gdvStatistiche";
            this.gdvStatistiche.ReadOnly = true;
            this.gdvStatistiche.RowHeadersWidth = 51;
            this.gdvStatistiche.RowTemplate.Height = 24;
            this.gdvStatistiche.Size = new System.Drawing.Size(810, 519);
            this.gdvStatistiche.TabIndex = 0;
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
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenu.Controls.Add(this.btnStatistiche);
            this.panelMenu.Controls.Add(this.btnVisualizzaComande);
            this.panelMenu.Controls.Add(this.btnComanda);
            this.panelMenu.Controls.Add(this.btnListaPiatti);
            this.panelMenu.Controls.Add(this.btnCreaPiatto);
            this.panelMenu.Controls.Add(this.btnConfigurazione);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(245, 940);
            this.panelMenu.TabIndex = 14;
            // 
            // btnStatistiche
            // 
            this.btnStatistiche.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistiche.FlatAppearance.BorderSize = 0;
            this.btnStatistiche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistiche.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistiche.ForeColor = System.Drawing.Color.White;
            this.btnStatistiche.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnStatistiche.IconColor = System.Drawing.Color.White;
            this.btnStatistiche.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStatistiche.IconSize = 30;
            this.btnStatistiche.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistiche.Location = new System.Drawing.Point(0, 490);
            this.btnStatistiche.Name = "btnStatistiche";
            this.btnStatistiche.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStatistiche.Size = new System.Drawing.Size(245, 65);
            this.btnStatistiche.TabIndex = 23;
            this.btnStatistiche.Tag = "Statistiche";
            this.btnStatistiche.Text = "Statistiche";
            this.btnStatistiche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistiche.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistiche.UseVisualStyleBackColor = true;
            this.btnStatistiche.Click += new System.EventHandler(this.btnStatistiche_Click);
            // 
            // btnVisualizzaComande
            // 
            this.btnVisualizzaComande.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisualizzaComande.FlatAppearance.BorderSize = 0;
            this.btnVisualizzaComande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizzaComande.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizzaComande.ForeColor = System.Drawing.Color.White;
            this.btnVisualizzaComande.IconChar = FontAwesome.Sharp.IconChar.FolderBlank;
            this.btnVisualizzaComande.IconColor = System.Drawing.Color.White;
            this.btnVisualizzaComande.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVisualizzaComande.IconSize = 30;
            this.btnVisualizzaComande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizzaComande.Location = new System.Drawing.Point(0, 425);
            this.btnVisualizzaComande.Name = "btnVisualizzaComande";
            this.btnVisualizzaComande.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVisualizzaComande.Size = new System.Drawing.Size(245, 65);
            this.btnVisualizzaComande.TabIndex = 22;
            this.btnVisualizzaComande.Tag = "VisualizzaComande";
            this.btnVisualizzaComande.Text = "Visualizza comande";
            this.btnVisualizzaComande.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizzaComande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisualizzaComande.UseVisualStyleBackColor = true;
            this.btnVisualizzaComande.Click += new System.EventHandler(this.btnVisualizzaComande_Click);
            // 
            // btnComanda
            // 
            this.btnComanda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComanda.FlatAppearance.BorderSize = 0;
            this.btnComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComanda.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComanda.ForeColor = System.Drawing.Color.White;
            this.btnComanda.IconChar = FontAwesome.Sharp.IconChar.PlateWheat;
            this.btnComanda.IconColor = System.Drawing.Color.White;
            this.btnComanda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComanda.IconSize = 30;
            this.btnComanda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComanda.Location = new System.Drawing.Point(0, 360);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnComanda.Size = new System.Drawing.Size(245, 65);
            this.btnComanda.TabIndex = 21;
            this.btnComanda.Tag = "CreaComanda";
            this.btnComanda.Text = "Crea comanda";
            this.btnComanda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComanda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // btnListaPiatti
            // 
            this.btnListaPiatti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaPiatti.FlatAppearance.BorderSize = 0;
            this.btnListaPiatti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaPiatti.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaPiatti.ForeColor = System.Drawing.Color.White;
            this.btnListaPiatti.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.btnListaPiatti.IconColor = System.Drawing.Color.White;
            this.btnListaPiatti.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListaPiatti.IconSize = 30;
            this.btnListaPiatti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaPiatti.Location = new System.Drawing.Point(0, 295);
            this.btnListaPiatti.Name = "btnListaPiatti";
            this.btnListaPiatti.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnListaPiatti.Size = new System.Drawing.Size(245, 65);
            this.btnListaPiatti.TabIndex = 20;
            this.btnListaPiatti.Tag = "ListaPiatti";
            this.btnListaPiatti.Text = "Lista piatti";
            this.btnListaPiatti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaPiatti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaPiatti.UseVisualStyleBackColor = true;
            this.btnListaPiatti.Click += new System.EventHandler(this.btnListaPiatti_Click);
            // 
            // btnCreaPiatto
            // 
            this.btnCreaPiatto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreaPiatto.FlatAppearance.BorderSize = 0;
            this.btnCreaPiatto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreaPiatto.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreaPiatto.ForeColor = System.Drawing.Color.White;
            this.btnCreaPiatto.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCreaPiatto.IconColor = System.Drawing.Color.White;
            this.btnCreaPiatto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreaPiatto.IconSize = 30;
            this.btnCreaPiatto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreaPiatto.Location = new System.Drawing.Point(0, 230);
            this.btnCreaPiatto.Name = "btnCreaPiatto";
            this.btnCreaPiatto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCreaPiatto.Size = new System.Drawing.Size(245, 65);
            this.btnCreaPiatto.TabIndex = 19;
            this.btnCreaPiatto.Tag = "CreaPiatto";
            this.btnCreaPiatto.Text = "Crea piatto";
            this.btnCreaPiatto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreaPiatto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreaPiatto.UseVisualStyleBackColor = true;
            this.btnCreaPiatto.Click += new System.EventHandler(this.btnCreaPiatto_Click);
            // 
            // btnConfigurazione
            // 
            this.btnConfigurazione.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfigurazione.FlatAppearance.BorderSize = 0;
            this.btnConfigurazione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigurazione.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurazione.ForeColor = System.Drawing.Color.White;
            this.btnConfigurazione.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.btnConfigurazione.IconColor = System.Drawing.Color.White;
            this.btnConfigurazione.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfigurazione.IconSize = 30;
            this.btnConfigurazione.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigurazione.Location = new System.Drawing.Point(0, 165);
            this.btnConfigurazione.Name = "btnConfigurazione";
            this.btnConfigurazione.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConfigurazione.Size = new System.Drawing.Size(245, 65);
            this.btnConfigurazione.TabIndex = 18;
            this.btnConfigurazione.Tag = "Configurazione";
            this.btnConfigurazione.Text = "Configurazione";
            this.btnConfigurazione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigurazione.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfigurazione.UseVisualStyleBackColor = true;
            this.btnConfigurazione.Click += new System.EventHandler(this.btnConfigurazione_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(245, 65);
            this.btnHome.TabIndex = 17;
            this.btnHome.Tag = "Home";
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblTitolo);
            this.panel4.Controls.Add(this.btnMenu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 100);
            this.panel4.TabIndex = 0;
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.ForeColor = System.Drawing.Color.White;
            this.lblTitolo.Location = new System.Drawing.Point(0, 0);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(185, 80);
            this.lblTitolo.TabIndex = 2;
            this.lblTitolo.Text = "Gestione\r\ncomande\r\n";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(199, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 32);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Tag = "btnMenu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.btnMaximize);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.lblTitoloStato);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(245, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1426, 100);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.UpRightFromSquare;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(1336, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(44, 25);
            this.btnMaximize.TabIndex = 26;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(1292, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 25);
            this.btnMinimize.TabIndex = 25;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(1380, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 25);
            this.btnClose.TabIndex = 24;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitoloStato
            // 
            this.lblTitoloStato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitoloStato.AutoSize = true;
            this.lblTitoloStato.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitoloStato.Location = new System.Drawing.Point(534, 28);
            this.lblTitoloStato.Name = "lblTitoloStato";
            this.lblTitoloStato.Size = new System.Drawing.Size(238, 52);
            this.lblTitoloStato.TabIndex = 27;
            this.lblTitoloStato.Text = "Gestione";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabGestioneComande);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(245, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1426, 940);
            this.panel3.TabIndex = 16;
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // iconDropDownButton2
            // 
            this.iconDropDownButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton2.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton2.Name = "iconDropDownButton2";
            this.iconDropDownButton2.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton2.Text = "iconDropDownButton2";
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.tableLayoutPanel7);
            this.tabHome.Location = new System.Drawing.Point(4, 54);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(1418, 782);
            this.tabHome.TabIndex = 6;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblNomeProgramma, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1418, 782);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // lblNomeProgramma
            // 
            this.lblNomeProgramma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeProgramma.AutoSize = true;
            this.lblNomeProgramma.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProgramma.Location = new System.Drawing.Point(154, 100);
            this.lblNomeProgramma.Name = "lblNomeProgramma";
            this.lblNomeProgramma.Size = new System.Drawing.Size(400, 190);
            this.lblNomeProgramma.TabIndex = 0;
            this.lblNomeProgramma.Text = "Gestione comande";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "v 1.0.0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(867, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(392, 116);
            this.label5.TabIndex = 2;
            this.label5.Text = "Creato da \r\nDaris Cappelletti";
            // 
            // lblNomeTipologia
            // 
            this.lblNomeTipologia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeTipologia.AutoSize = true;
            this.lblNomeTipologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTipologia.Location = new System.Drawing.Point(80, 58);
            this.lblNomeTipologia.Name = "lblNomeTipologia";
            this.lblNomeTipologia.Size = new System.Drawing.Size(122, 39);
            this.lblNomeTipologia.TabIndex = 12;
            this.lblNomeTipologia.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 39);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipologia:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 39);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quantità:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 39);
            this.label8.TabIndex = 15;
            this.label8.Text = "Costo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 940);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Gestione comande";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabGestioneComande.ResumeLayout(false);
            this.tabConfigura.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabCreaPiatto.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabListaPiatti.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrListaPiatti)).EndInit();
            this.tabCreaComanda.ResumeLayout(false);
            this.tabCreaComanda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPagato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvComanda)).EndInit();
            this.tabVisualizzaComande.ResumeLayout(false);
            this.tabVisualizzaComande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvComandeOggi)).EndInit();
            this.tabStatistiche.ResumeLayout(false);
            this.tabStatistiche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvStatistiche)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Crea;
        private System.Windows.Forms.TabControl tabGestioneComande;
        private System.Windows.Forms.TabPage tabCreaPiatto;
        private System.Windows.Forms.TabPage tabListaPiatti;
        private System.Windows.Forms.DataGridView gdrListaPiatti;
        private System.Windows.Forms.Button btnSalvaListaPiatti;
        private System.Windows.Forms.TabPage tabCreaComanda;
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
        private System.Windows.Forms.TabPage tabVisualizzaComande;
        private System.Windows.Forms.DataGridView gdvComandeOggi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotaleIncassoOggi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEsportaXls;
        private System.Windows.Forms.TabPage tabConfigura;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtNumeroComandaIniziale;
        private System.Windows.Forms.TextBox txtIntestazione;
        private System.Windows.Forms.TabPage tabStatistiche;
        private System.Windows.Forms.DataGridView gdvStatistiche;
        private System.Windows.Forms.TextBox txtOperatore;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSalvaConfigurazione;
        private System.Windows.Forms.Label lblResto;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown numPagato;
        private Label lblTipsOperatore;
        private Label lblTipsSerie;
        private Label lblTipsNumeroPartenza;
        private Label lblTipsIntestazione;
        private Button btnEsportaXlsStatistiche;
        private Label lblStatisticheIncasso;
        private Label label29;
        private Label label31;
        private Label label30;
        private Button btnCercaStatistiche;
        private DateTimePicker statsDataFine;
        private DateTimePicker statsDataInizio;
        private Label label32;
        private Label label33;
        private Button btnCercaComande;
        private DateTimePicker comandeDataFine;
        private DateTimePicker comandeDataInizio;
        private Panel panelMenu;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnStatistiche;
        private FontAwesome.Sharp.IconButton btnVisualizzaComande;
        private FontAwesome.Sharp.IconButton btnComanda;
        private FontAwesome.Sharp.IconButton btnListaPiatti;
        private FontAwesome.Sharp.IconButton btnCreaPiatto;
        private FontAwesome.Sharp.IconButton btnConfigurazione;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMenu;
        private Label lblTitolo;
        private Label lblTitoloStato;
        private Panel panel1;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private MaterialSkin.Controls.MaterialComboBox ddlTipo;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton2;
        private MaterialSkin.Controls.MaterialTextBox txtCosto;
        private MaterialSkin.Controls.MaterialTextBox txtQuantita;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialTextBox txtTipologia;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TabPage tabHome;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label5;
        private Label lblNomeProgramma;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label lblNomeTipologia;
    }
}

