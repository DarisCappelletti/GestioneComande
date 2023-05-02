using GestioneComande.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity.Core.Objects;
using System.Runtime.InteropServices;

namespace GestioneComande
{
    public partial class Form1 : Form
    {
        Bitmap memoryImage;
        WebBrowser webBrowser = new WebBrowser();
        Model.Model context = new Model.Model();
        private int borderSize = 2;
        private Size formSize;

        public Form1()
        {
            InitializeComponent();
            loadConfigurazione();
            loadListaPiatti();
            setDeleteButton();
            setStampaButton();
            CollapseMenu();
            tabGestioneComande.SizeMode = TabSizeMode.Fixed;
            this.WindowState = FormWindowState.Maximized;
            tabGestioneComande.SizeMode = TabSizeMode.Fixed;
            tabGestioneComande.ItemSize =
                new Size((tabGestioneComande.Width / tabGestioneComande.TabPages.Count) - 1, tabGestioneComande.ItemSize.Height);

            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);

            SetFullWidthElementi();
        }

        private void SetFullWidthElementi()
        {
            txtIntestazione.Width = Convert.ToInt32(this.Width * 0.9);
            txtNumeroComandaIniziale.Width = Convert.ToInt32(this.Width * 0.9);
            txtSerie.Width = Convert.ToInt32(this.Width * 0.9);
            txtOperatore.Width = Convert.ToInt32(this.Width * 0.9);
            txtTipologia.Width = Convert.ToInt32(this.Width * 0.9);
            ddlTipo.Width = Convert.ToInt32(this.Width * 0.9);
            lblTipsIntestazione.Width = Convert.ToInt32(this.Width * 0.9);
            lblTipsNumeroPartenza.Width = Convert.ToInt32(this.Width * 0.9);
            lblTipsOperatore.Width = Convert.ToInt32(this.Width * 0.9);
            lblTipsSerie.Width = Convert.ToInt32(this.Width * 0.9);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            tabGestioneComande.ItemSize =
                new Size((tabGestioneComande.Width / tabGestioneComande.TabPages.Count) - 1, tabGestioneComande.ItemSize.Height);
        }

        private void tabGestioneComande_SelectedIndexchanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    loadConfigurazione();
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    loadComanda();
                    break;
                case 4:
                    loadComande();
                    break;
                case 5:
                    loadStatistiche();
                    break;
            }
        }

        // TAB CONFIGURAZIONE

        private void loadConfigurazione()
        {
            if(context.Configurazione.Count() > 0)
            {
                var configurazione = context.Configurazione.FirstOrDefault();
                txtIntestazione.Text = configurazione.Intestazione;
                txtSerie.Text = configurazione.Serie;
                txtNumeroComandaIniziale.Text = configurazione.ComandaIniziale.ToString();
                txtOperatore.Text = configurazione.Operatore;
            }
        }

        private void btnSalvaConfigurazione_Click(object sender, EventArgs e)
        {
            creaConfigurazione();
        }

        private void creaConfigurazione()
        {
            // Salvo la configurazione esistente
            if (context.Configurazione.Count() > 0)
            {
                var configurazione = context.Configurazione.FirstOrDefault();
                configurazione.ComandaIniziale = txtNumeroComandaIniziale.Text == "" ? 1 : Convert.ToInt32(txtNumeroComandaIniziale.Text);
                configurazione.Intestazione = txtIntestazione.Text;
                configurazione.Operatore = txtOperatore.Text;
                configurazione.Serie = txtSerie.Text == "" ? "/a" : txtSerie.Text;

                context.SaveChanges();

                loadConfigurazione();

                MessageBox.Show("Configurazione aggiornata correttamente.", "Messaggio");
            }
            else
            {
                // Creo una nuova configurazione
                var configurazione = new Configurazione();
                configurazione.ComandaIniziale = txtNumeroComandaIniziale.Text == "" ? 1 : Convert.ToInt32(txtNumeroComandaIniziale.Text);
                configurazione.Intestazione = txtIntestazione.Text;
                configurazione.Operatore = txtOperatore.Text;
                configurazione.Serie = txtSerie.Text == "" ? "/a" : txtSerie.Text;

                context.Configurazione.Add(configurazione);
                context.SaveChanges();

                loadConfigurazione();

                MessageBox.Show("Configurazione creata correttamente.", "Messaggio");
            }
        }

        // TAB CREA PIATTO

        private void Crea_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTipologia.Text == "")
                {
                    MessageBox.Show("Impostare un nome.", "Errore");
                }
                else if (ddlTipo.SelectedItem == null ||
                    (ddlTipo.SelectedItem.ToString() != "Piatto" && ddlTipo.SelectedItem.ToString() != "Bevanda"))
                {
                    MessageBox.Show("Selezionare la tipologia corretta dal menu a tendina.", "Errore");
                }
                else if (txtQuantita.Text == "")
                {
                    MessageBox.Show("Impostare la quantità.", "Errore");
                }
                else if (txtCosto.Text == "")
                {
                    MessageBox.Show("Impostare il costo.", "Errore");
                }
                else
                {
                    var tipo = ddlTipo.SelectedItem.ToString();
                    // Set values into company model.  
                    Piatto objPiatto = new Piatto();
                    objPiatto.Nome = txtTipologia.Text;
                    objPiatto.Tipologia = tipo;
                    objPiatto.Costo = Convert.ToDecimal(txtCosto.Text.Replace(".", ","));
                    objPiatto.Quantita = Convert.ToInt32(txtQuantita.Text);
                    objPiatto.Attivo = true;

                    // Create context object and then save company data.  
                    context.Piatto.Add(objPiatto);
                    context.SaveChanges();

                    loadListaPiatti();

                    txtTipologia.Text = "";
                    txtCosto.Text = "";
                    txtQuantita.Text = "";
                    ddlTipo.SelectedItem = null;

                    var messaggio =
                        tipo == "Bevanda"
                        ? tipo + " \"" + objPiatto.Nome + "\" creata correttamente."
                        : tipo + " \"" + objPiatto.Nome + "\" creato correttamente.";

                    MessageBox.Show(messaggio, "Messaggio");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante la creazione del piatto.", "Errore");
            }
        }

        private void creaPiattoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }

        // TAB LISTA PIATTI

        private void loadListaPiatti()
        {
            gdrListaPiatti.DataSource = context.Piatto.Where(x => !x.Eliminato).ToList();
            gdrListaPiatti.Columns["ID"].Visible = false;
            gdrListaPiatti.Columns["Eliminato"].Visible = false;
            gdrListaPiatti.Columns["Items"].Visible = false;

            gdrListaPiatti.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            gdrListaPiatti.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            gdrListaPiatti.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void setDeleteButton()
        {
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "btnElimina";
            deleteButton.HeaderText = "Elimina";
            deleteButton.Text = "Elimina";
            deleteButton.UseColumnTextForButtonValue = true;
            this.gdrListaPiatti.Columns.Add(deleteButton);
        }

        private void gdrListaPiatti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if click is on new row or header row
                if (e.RowIndex == gdrListaPiatti.NewRowIndex || e.RowIndex < 0)
                    return;

                //Check if click is on specific column 
                //if (e.ColumnIndex == gdrListaPiatti.Columns["btnElimina"].Index)
                string columnName = e.ColumnIndex >= 0 ? this.gdrListaPiatti.Columns[e.ColumnIndex].Name : null;
                if (columnName != null && columnName == "btnElimina")
                {
                    var id = gdrListaPiatti.Rows[e.RowIndex].Cells["id"].Value;

                    if (id != null)
                    {
                        var idPiatto = Convert.ToInt32(id);
                        var piatto = context.Piatto.FirstOrDefault(x => x.ID == idPiatto);

                        //context.Piatto.Remove(piatto);
                        piatto.Eliminato = true;
                        context.SaveChanges();

                        gdrListaPiatti.Columns.Clear();

                        loadListaPiatti();

                        setDeleteButton();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'eliminazione del piatto.", "Errore");
            }
        }

        private void btnSalvaListaPiatti_Click(object sender, EventArgs e)
        {
            try
            {
                this.gdrListaPiatti.EndEdit();
                this.gdrListaPiatti.Update();

                foreach (DataGridViewRow riga in gdrListaPiatti.Rows)
                {

                    var id = Convert.ToInt32(riga.Cells["Id"].Value);
                    var nome = riga.Cells["Nome"].Value.ToString();
                    var quantita = Convert.ToInt32(riga.Cells["Quantita"].Value);
                    var costo = Convert.ToDecimal(riga.Cells["Costo"].Value);
                    //Piatto piatto = riga as Model.Piatto;
                    ////Piatto cust = row.DataBoundItem as Piatto;

                    var piattoDB = context.Piatto.SingleOrDefault(x => x.ID == id);
                    piattoDB.Nome = nome.ToString();
                    piattoDB.Costo = costo;
                    piattoDB.Quantita = quantita;
                }

                context.SaveChanges();

                MessageBox.Show("Lista aggiornata correttamente.", "Messaggio");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'aggiornamento della lista dei piatti.", "Errore");
            }
        }

        // TAB COMANDA

        private void loadComanda()
        {
            // Reset testi
            txtNominativo.Text = "";
            lblCostoTotale.Text = "";

            lblResto.Text = "";
            numPagato.Value = 0;

            lblDataAttuale.Text = DateTime.Now.ToShortDateString();
            lblOraAttuale.Text = DateTime.Now.ToShortTimeString();

            // Imposto la tabella
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Piatto", typeof(string));
            dt.Columns.Add("Costo", typeof(decimal));
            dt.Columns.Add("Rimaste", typeof(int));
            dt.Columns.Add("Quantità", typeof(int));

            var listaPiatti = 
                context.Piatto.Where(x => !x.Eliminato && x.Attivo)
                .OrderByDescending(x => x.Tipologia)
                .ThenBy(x => x.Nome)
                .ToList();

            foreach (var piatto in listaPiatti)
            {
                dt.Rows.Add(piatto.ID, piatto.Nome, piatto.Costo, piatto.Quantita);
            }

            gdvComanda.DataSource = dt;
            gdvComanda.Columns["ID"].Visible = false;
            gdvComanda.Columns["Costo"].ReadOnly = true;
            gdvComanda.Columns["Rimaste"].ReadOnly = true;
            
            gdvComanda.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            gdvComanda.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            gdvComanda.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        //private void gdvComanda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    btnCreaComanda.Visible = false;
        //}

        private void gdvComanda_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            btnCreaComanda.Visible = true;
            decimal total = 0;

            var id = gdvComanda.Rows[e.RowIndex].Cells["id"].Value != null && gdvComanda.Rows[e.RowIndex].Cells["id"].Value.ToString() != ""
                ? Convert.ToInt32(gdvComanda.Rows[e.RowIndex].Cells["id"].Value)
                : (int?)null;

            var quantità = gdvComanda.Rows[e.RowIndex].Cells["Quantità"].Value != null && gdvComanda.Rows[e.RowIndex].Cells["Quantità"].Value.ToString() != ""
                ? Convert.ToInt32(gdvComanda.Rows[e.RowIndex].Cells["Quantità"].Value)
                : (int?)null;

            if (id != null &&
                gdvComanda.Rows[e.RowIndex].Cells["Quantità"].Value != null &&
                gdvComanda.Rows[e.RowIndex].Cells["Quantità"].Value.ToString() != "" &&
                context.Piatto.FirstOrDefault(x => x.ID == id).Quantita < quantità
                )
            {
                gdvComanda.Rows[e.RowIndex].Cells["Quantità"].Value = DBNull.Value;
                MessageBox.Show("Quantità richiesta superiore a quella presente ovvero " + context.Piatto.FirstOrDefault(x => x.ID == id).Quantita, "Errore");
            }
            else
            {
                foreach (DataGridViewRow row in gdvComanda.Rows)
                {
                    if (row.Cells["Costo"].Value != null &&
                        row.Cells["Costo"].Value.ToString() != "" &&
                        row.Cells["Quantità"].Value != null &&
                        row.Cells["Quantità"].Value.ToString() != "")
                    {
                        total += (decimal)row.Cells["Costo"].Value * (int)row.Cells["Quantità"].Value;
                    }
                }

                lblCostoTotale.Text = total.ToString();
                aggiornaResto();
            }
        }

        private void btnCreaComanda_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblCostoTotale.Text == "")
                {
                    MessageBox.Show("Per creare la domanda è necessario inserire almeno un piatto.", "Errore");
                }
                else if (txtNominativo.Text == "")
                {
                    MessageBox.Show("Per creare la domanda è necessario inserire il nominativo.", "Errore");
                }
                else if (numPagato.Value == 0)
                {
                    MessageBox.Show("Per creare la domanda è necessario inserire l'importo pagato.", "Errore");
                }
                else if (Convert.ToDecimal(lblCostoTotale.Text) > numPagato.Value)
                {
                    MessageBox.Show("L'importo pagato è inferiore al costo dei piatti.", "Errore");
                }
                else
                {
                    string html = impostaPdf(this.gdvComanda.Rows, null);

                    var listaItems = new List<ComandaItem>();

                    foreach (DataGridViewRow item in this.gdvComanda.Rows)
                    {
                        int id = Convert.ToInt32(item.Cells["ID"].Value);

                        var piatto = context.Piatto.FirstOrDefault(x => x.ID == id);

                        if (
                            item.Cells["id"].Value != null && item.Cells["id"].Value.ToString() != "" &&
                            item.Cells["Quantità"].Value != null && item.Cells["Quantità"].Value.ToString() != ""
                          )
                            {
                            listaItems.Add(new ComandaItem()
                            {
                                ID_Piatto = piatto.ID,
                                piatto = piatto,
                                Quantita = Convert.ToInt32(item.Cells["Quantità"].Value)
                            });
                        }
                    }

                    // imposto l'oggetto
                    var comandaID = creaComandaSulDb(listaItems);
                    html = html.Replace("{pratica-titolo}", comandaID.ToString());

                    Print(html);

                    rimuoviQuantita();

                    loadComanda();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante la creazione della comanda.", "Errore");
            }
        }

        private string impostaPdf(DataGridViewRowCollection rows = null, Comanda comanda = null)
        {
            string html = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "HtmlFile/template-pdf.html");

            string pdfConPiatti =
                rows == null
                ? creaTabellaPdf("{piatti}", html, null, comanda)
                : creaTabellaPdf("{piatti}", html, rows, null);

            string pdfConBevande =
                rows == null
                ? creaTabellaPdf("{bevande}", pdfConPiatti, null, comanda)
                : creaTabellaPdf("{bevande}", pdfConPiatti, rows, null);

            return pdfConBevande;
        }

        private string creaTabellaPdf(string itemReplace, string html, DataGridViewRowCollection rows = null, Comanda comanda = null)
        {
            var tipo = itemReplace == "{piatti}" ? "Piatto" : "Bevanda";
            var table = "";

            // apro la tabella
            table +=
            "<table class=\"tabella-pdf\">" +
            "<thead>" +
            "<tr><th class=\"nome\">" + tipo + "</th>" +
            "<th>Costo</th>" +
            "<th>Quantità</th>" +
            "<th>Parziale</th>" +
            "</tr>" +
            "</thead><tbody>";

            if (rows != null)
            {
                var configurazione = getConfigurazione();
                // inserisco il footer - richiedente e data
                string footerUtente = txtNominativo.Text;
                string footerData =
                    DateTime.Now.ToShortDateString();
                string footerOra =
                    DateTime.Now.ToShortTimeString();
                html =
                    html
                    .Replace("{pratica-intestazione}", configurazione.Intestazione)
                    .Replace("{footer-utente}", footerUtente)
                    .Replace("{footer-data}", footerData)
                    .Replace("{footer-ora}", footerOra)
                    .Replace("{pratica-operatore}", configurazione.Operatore);

                decimal totale = 0;

                foreach (DataGridViewRow item in rows)
                {
                    int ID = Convert.ToInt32(item.Cells["ID"].Value);
                    var piatto = context.Piatto.FirstOrDefault(x => x.ID == ID);

                    if(piatto.Tipologia == tipo)
                    {
                        string nome = Convert.ToString(item.Cells["Piatto"].Value);
                        string costo = Convert.ToString(item.Cells["Costo"].Value);
                        string quantita = Convert.ToString(item.Cells["Quantità"].Value);
                        decimal parziale = 0;
                        int quantitaValore = 0;

                        if (quantita != "")
                        {
                            quantitaValore = Convert.ToInt32(item.Cells["Quantità"].Value);
                            parziale = Convert.ToDecimal(item.Cells["Costo"].Value) * Convert.ToInt32(item.Cells["Quantità"].Value);
                            totale += parziale;
                        }

                        if (quantitaValore > 0)
                        {
                            table +=
                                "<tr><td class=\"nome\">" +
                                nome +
                                "</td><td>" +
                                costo +
                                "</td>" +
                                "<td>" +
                                quantita +
                                "</td>" +
                                "<td>" +
                                parziale.ToString() +
                                "</td>" +
                                "</tr>";
                        }
                    }
                }

                table += "<tr><td colspan=\"3\"><strong>Totale</strong></td><td>" + totale + " euro</td></tr>";
            }
            else
            {
                // inserisco il footer - richiedente e data
                html =
                    html
                    .Replace("{pratica-intestazione}", comanda.Intestazione)
                    .Replace("{footer-utente}", comanda.Nominativo)
                    .Replace("{footer-data}", comanda.Data.ToShortDateString())
                    .Replace("{footer-ora}", comanda.Data.ToShortTimeString())
                    .Replace("{pratica-operatore}", comanda.Operatore);

                decimal totale = 0;
                foreach (var item in comanda.Items)
                {
                    if(item.piatto.Tipologia == tipo)
                    {
                        var parziale = item.Quantita * item.piatto.Costo;
                        totale += parziale;
                        table +=
                                "<tr><td class=\"nome\">" +
                                item.piatto.Nome +
                                "</td><td>" +
                                item.piatto.Costo +
                                "</td>" +
                                "<td>" +
                                item.Quantita +
                                "</td>" +
                                "<td>" +
                                parziale +
                                "</td>" +
                                "</tr>";
                    }
                }

                table += "<tr><td colspan=\"3\"><strong>Totale</strong></td><td>" + totale + " euro</td></tr>";
            }

            // chiudo la tabella
            table += "</tbody></table>";

            html = html.Replace(itemReplace, table);

            return html;
        }

        void Print(string str)
        {
            webBrowser.DocumentText = str;
            webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
        }

        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser.ShowPrintDialog();
        }

        private string creaComandaSulDb(List<ComandaItem> items)
        {
            decimal costo = Convert.ToDecimal(lblCostoTotale.Text);
            decimal pagato = Convert.ToDecimal(numPagato.Value);
            decimal resto = Convert.ToDecimal(lblResto.Text);
            Configurazione configurazione = getConfigurazione();

            var descrizione = "";
            int i = items.Count;
            foreach (var item in items)
            {
                descrizione += "Piatto: " + item.piatto.Nome + ", Costo: " + item.piatto.Costo + ", Quantità: " + item.Quantita;
                if (i > 1) { descrizione += " || "; }
                i--;
            }

            var comanda = new Comanda()
            {
                Intestazione = configurazione.Intestazione,
                Numero = configurazione.ComandaIniziale,
                Serie = configurazione.Serie,
                Operatore = configurazione.Operatore,
                Nominativo = txtNominativo.Text,
                Descrizione = descrizione,
                Data = DateTime.Now,
                Totale = costo,
                Pagato = pagato,
                Resto = resto,
                Items = items
            };

            context.Comanda.Add(comanda);
            context.SaveChanges();

            incrementaComandaIniziale(configurazione);

            return comanda.Numero.ToString() + comanda.Serie;
        }

        private void incrementaComandaIniziale(Configurazione configurazione)
        {
            configurazione.ComandaIniziale = configurazione.ComandaIniziale + 1;
            context.SaveChanges();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            //e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void rimuoviQuantita()
        {

            foreach (DataGridViewRow row in this.gdvComanda.Rows)
            {

                if (row.Cells["ID"].Value != null &&
                    row.Cells["ID"].Value.ToString() != "" &&
                    row.Cells["Quantità"].Value != null &&
                    row.Cells["Quantità"].Value.ToString() != "")
                {
                    int id = Convert.ToInt32(row.Cells["ID"].Value);
                    int quantità = Convert.ToInt32(row.Cells["Quantità"].Value);

                    var piatto = context.Piatto.FirstOrDefault(x => x.ID == id);
                    piatto.Quantita = piatto.Quantita - quantità;
                    context.SaveChanges();
                }
            }

            loadListaPiatti();
        }

        // TAB COMANDE OGGI

        private void loadComande(DateTime? inizio = null, DateTime? fine = null)
        {
            if (inizio == null)
            {
                inizio = DateTime.Now.Date;
            }
            if (fine == null)
            {
                fine = DateTime.Now.Date;
            }

            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Numero", typeof(string));
            dt.Columns.Add("Serie", typeof(string));
            dt.Columns.Add("Nominativo", typeof(string));
            dt.Columns.Add("Descrizione", typeof(string));
            dt.Columns.Add("Totale", typeof(decimal));
            dt.Columns.Add("Pagato", typeof(decimal));
            dt.Columns.Add("Resto", typeof(decimal));
            dt.Columns.Add("Data", typeof(DateTime));

            var comandeOggi = 
                context.Comanda
                .Where(x =>
                        EntityFunctions.TruncateTime(x.Data) >= inizio &&
                        EntityFunctions.TruncateTime(x.Data) <= fine
                    )
                .OrderByDescending(x => x.ID)
                .ToList();

            decimal incasso = 0;
            foreach (var comanda in comandeOggi)
            {
                incasso += comanda.Totale;
                dt.Rows.Add(
                    comanda.ID, comanda.Numero, comanda.Serie, comanda.Nominativo, 
                    comanda.Descrizione, comanda.Totale, comanda.Pagato, comanda.Resto, comanda.Data
                    );
            }

            gdvComandeOggi.DataSource = dt;
            gdvComandeOggi.Columns["ID"].Visible = false;
            gdvComandeOggi.Columns["Numero"].ReadOnly = true;
            gdvComandeOggi.Columns["Serie"].ReadOnly = true;
            gdvComandeOggi.Columns["Descrizione"].ReadOnly = true;
            gdvComandeOggi.Columns["Totale"].ReadOnly = true;
            gdvComandeOggi.Columns["Pagato"].ReadOnly = true;
            gdvComandeOggi.Columns["Resto"].ReadOnly = true;
            gdvComandeOggi.Columns["Data"].ReadOnly = true;

            lblTotaleIncassoOggi.Text = incasso.ToString() + " euro";
        }

        private void setStampaButton()
        {
            var stampaButton = new DataGridViewButtonColumn();
            stampaButton.Name = "btnStampa";
            stampaButton.HeaderText = "Azione";
            stampaButton.Text = "Stampa";
            stampaButton.UseColumnTextForButtonValue = true;
            this.gdvComandeOggi.Columns.Add(stampaButton);
        }

        private void gdvComandeOggi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if click is on new row or header row
                if (e.RowIndex == gdrListaPiatti.NewRowIndex || e.RowIndex < 0)
                    return;

                //Check if click is on specific column 
                //if (e.ColumnIndex == gdrListaPiatti.Columns["btnElimina"].Index)
                string columnName = e.ColumnIndex >= 0 ? this.gdvComandeOggi.Columns[e.ColumnIndex].Name : null;
                if (columnName != null && columnName == "btnStampa")
                {
                    var id = gdvComandeOggi.Rows[e.RowIndex].Cells["ID"].Value;

                    if (id != null)
                    {
                        var idComanda = Convert.ToInt32(id);
                        var comanda = context.Comanda.FirstOrDefault(x => x.ID == idComanda);

                        string html = impostaPdf(null, comanda);

                        html = html.Replace("{pratica-titolo}", comanda.Numero.ToString() + comanda.Serie);

                        Print(html);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante la stampa della comanda.", "Errore");
            }
        }

        private bool copyAlltoClipboard()
        {
            gdvComandeOggi.SelectAll();

            gdvComandeOggi.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataObject dataObj = gdvComandeOggi.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void btnEsportaXls_Click_1(object sender, EventArgs e)
        {
            if (copyAlltoClipboard())
            {
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
        }

        private void btnCercaComande_Click(object sender, EventArgs e)
        {
            loadComande(comandeDataInizio.Value.Date, comandeDataFine.Value.Date);
        }

        // TAB STATISTICHE OGGI

        private void loadStatistiche(DateTime? inizio = null, DateTime? fine = null)
        {
            if(inizio == null)
            {
                inizio = DateTime.Now.Date;
            }
            if (fine == null)
            {
                fine = DateTime.Now.Date;
            }

            var piatti =
                context.Item
                .Where(x => 
                        EntityFunctions.TruncateTime(x.comanda.Data) >= inizio && 
                        EntityFunctions.TruncateTime(x.comanda.Data) <= fine
                    )
                .GroupBy(x => x.piatto)
                .Select(x => x.Key).ToList();

            var piattiFinali = piatti.Select(x => new Statistiche
            {
                Tipologia = x.Nome,
                Rimasto = x.Quantita,
                Venduto = x.Items.Where(y => y.comanda.Data.Date == DateTime.Today && y.piatto.ID == x.ID).Sum(y => y.Quantita),
                Totale = x.Quantita + x.Items.Where(y => y.comanda.Data.Date == DateTime.Today && y.piatto.ID == x.ID).Sum(y => y.Quantita),
                Guadagno = x.Items.Where(y => y.comanda.Data.Date == DateTime.Today && y.piatto.ID == x.ID).Sum(y => y.Quantita) * x.Costo
            }).ToList();
            // Imposto la tabella
            var dt = new DataTable();
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Totale", typeof(int));
            dt.Columns.Add("Rimasto", typeof(int));
            dt.Columns.Add("Venduto", typeof(int));
            dt.Columns.Add("Guadagno", typeof(decimal));

            decimal totale = 0;

            foreach (var piatto in piattiFinali)
            {
                totale += piatto.Guadagno;
                dt.Rows.Add(piatto.Tipologia, piatto.Totale, piatto.Rimasto, piatto.Venduto, piatto.Guadagno );
            }

            gdvStatistiche.DataSource = dt;
            gdvStatistiche.Columns["Nome"].ReadOnly = true;
            gdvStatistiche.Columns["Rimasto"].ReadOnly = true;
            gdvStatistiche.Columns["Venduto"].ReadOnly = true;
            gdvStatistiche.Columns["Totale"].ReadOnly = true;
            gdvStatistiche.Columns["Guadagno"].ReadOnly = true;

            lblStatisticheIncasso.Text = totale.ToString() + " euro";
        }


        private bool copyAlltoClipboardStatistiche()
        {
            gdvStatistiche.SelectAll();

            gdvStatistiche.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataObject dataObj = gdvStatistiche.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnEsportaXlsStatistiche_Click_1(object sender, EventArgs e)
        {
            if (copyAlltoClipboardStatistiche())
            {
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
        }


        private void btnCercaStatistiche_Click(object sender, EventArgs e)
        {
            loadStatistiche(statsDataInizio.Value.Date, statsDataFine.Value.Date);
        }

        // UTILITY

        private void numPagato_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            //{
            //    e.KeyChar = ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            //}
        }

        private void numPagato_KeyUp(object sender, KeyEventArgs e)
        {
            aggiornaResto();
        }

        private void numPagato_ValueChanged(object sender, EventArgs e)
        {
            aggiornaResto();
        }

        private void aggiornaResto()
        {
            if (lblCostoTotale.Text != "")
            {
                var totale = Convert.ToDecimal(lblCostoTotale.Text);
                lblResto.Text = (numPagato.Value - totale).ToString();
            }
        }

        private Configurazione getConfigurazione()
        {
            if (context.Configurazione.Count() == 0)
            {
                creaConfigurazione();
            }
            
            var configurazione = context.Configurazione.FirstOrDefault();
            return configurazione;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if(this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if(this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                lblTitolo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach(var menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 245;
                lblTitolo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                btnMenu.Location = new Point(199, 12);
                foreach (var menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void btnConfigurazione_Click(object sender, EventArgs e)
        {
            tabGestioneComande.SelectedIndex = 1;
            lblTitoloStato.Text = "Configurazione";
        }

        private void btnCreaPiatto_Click(object sender, EventArgs e)
        {
            tabGestioneComande.SelectedIndex = 2;
            lblTitoloStato.Text = "Crea piatto";
        }

        private void btnListaPiatti_Click(object sender, EventArgs e)
        {
            tabGestioneComande.SelectedIndex = 3;
            lblTitoloStato.Text = "Lista piatti";
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            tabGestioneComande.SelectedIndex = 4;
            lblTitoloStato.Text = "Crea comanda";
        }

        private void btnVisualizzaComande_Click(object sender, EventArgs e)
        {
            tabGestioneComande.SelectedIndex = 5;
            lblTitoloStato.Text = "Visualizza comande";
        }

        private void btnStatistiche_Click(object sender, EventArgs e)
        {
            tabGestioneComande.SelectedIndex = 6;
            lblTitoloStato.Text = "Statistiche";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters, and a single decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.' || (sender as TextBox)?.Text?.Contains('.') == true))
            {
                e.Handled = true;
            }
        }

        private void txtQuantita_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabGestioneComande.SelectedIndex = 0;
            lblTitoloStato.Text = "Home";
        }

        private void tabVisualizzaComande_Click(object sender, EventArgs e)
        {

        }
    }

    public class Statistiche {
        public string Tipologia { get; set; }
        public int Rimasto { get; set; }
        public int Venduto { get; set; }
        public int Totale { get; set; }
        public decimal Guadagno { get; set; }
    }
}
