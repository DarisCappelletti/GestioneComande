using GestioneComande.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Data.Entity.Core.Objects;

namespace GestioneComande
{
    public partial class Form1 : Form
    {
        Bitmap memoryImage;
        WebBrowser webBrowser = new WebBrowser();
        Model.Model context = new Model.Model();

        public Form1()
        {
            InitializeComponent();
            loadListaPiatti();
            setDeleteButton();
            setStampaButton();
            this.WindowState = FormWindowState.Maximized;
            tabGestioneComande.SizeMode = TabSizeMode.Fixed;
            tabGestioneComande.ItemSize =
                new Size((tabGestioneComande.Width / tabGestioneComande.TabPages.Count) - 1, tabGestioneComande.ItemSize.Height);
        }

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
                    // Do nothing here (let's suppose that TabPage index 0 is the address information which is already loaded.
                    break;
                case 1:
                    break;
                case 2:
                    loadComanda();
                    break;
                case 3:
                    loadComandeOggi();
                    break;
            }
        }

        // TAB CREA PIATTO

        private void Crea_Click(object sender, EventArgs e)
        {
            try
            {
                // Set values into company model.  
                Piatto objPiatto = new Piatto();
                objPiatto.Tipologia = txtTipologia.Text;
                objPiatto.Costo = Convert.ToDecimal(txtCosto.Text);
                objPiatto.Quantita = Convert.ToInt32(txtQuantita.Text);
                objPiatto.Attivo = true;

                // Create context object and then save company data.  
                context.Piatto.Add(objPiatto);
                context.SaveChanges();

                loadListaPiatti();

                MessageBox.Show("Piatto \"" + txtTipologia.Text + "\" creato correttamente.", "Messaggio");
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
            gdrListaPiatti.DataSource = context.Piatto.Where(x => !x.Eliminato)
                //.Select(x => new {
                //    ID = x.ID,
                //    Tipologia = x.Tipologia,
                //    Quantita = x.Quantita,
                //    Costo = x.Costo,
                //    Attivo = x.Attivo
                //})
                .ToList();
            gdrListaPiatti.Columns["ID"].Visible = false;
            gdrListaPiatti.Columns["Eliminato"].Visible = false;
            gdrListaPiatti.Columns["Items"].Visible = false;
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
                string columnName = this.gdrListaPiatti.Columns[e.ColumnIndex].Name;
                if (columnName == "btnElimina")
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
                    var tipologia = riga.Cells["Tipologia"].Value.ToString();
                    var quantita = Convert.ToInt32(riga.Cells["Quantita"].Value);
                    var costo = Convert.ToDecimal(riga.Cells["Costo"].Value);
                    //Piatto piatto = riga as Model.Piatto;
                    ////Piatto cust = row.DataBoundItem as Piatto;

                    var piattoDB = context.Piatto.SingleOrDefault(x => x.ID == id);
                    piattoDB.Tipologia = tipologia.ToString();
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

            lblDataAttuale.Text = DateTime.Now.ToShortDateString();
            lblOraAttuale.Text = DateTime.Now.ToShortTimeString();

            // Imposto la tabella
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Piatto", typeof(string));
            dt.Columns.Add("Costo", typeof(decimal));
            dt.Columns.Add("Rimaste", typeof(int));
            dt.Columns.Add("Quantità", typeof(int));
            
            foreach (var piatto in context.Piatto.Where(x => !x.Eliminato && x.Attivo).ToList())
            {
                dt.Rows.Add(piatto.ID, piatto.Tipologia, piatto.Costo, piatto.Quantita);
            }

            gdvComanda.DataSource = dt;
            gdvComanda.Columns["ID"].Visible = false;
            gdvComanda.Columns["Costo"].ReadOnly = true;
            gdvComanda.Columns["Rimaste"].ReadOnly = true;
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
                else
                {
                    string html = impostaPdf(this.gdvComanda.Rows, null);

                    var listaItems = new List<ComandaItem>();

                    foreach (DataGridViewRow item in this.gdvComanda.Rows)
                    {
                        int id = Convert.ToInt32(item.Cells["ID"].Value);
                        string tipologia = Convert.ToString(item.Cells["Piatto"].Value);
                        string costo = Convert.ToString(item.Cells["Costo"].Value);
                        string quantita = Convert.ToString(item.Cells["Quantità"].Value);

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
            
            string table = "";

            // apro la tabella
            table +=
            "<h4>Ordine</h4>" +
            "<table class=\"tabella-pdf\">" +
            "<thead>" +
            "<tr><th>Tipologia</th>" +
            "<th>Costo</th>" +
            "<th>Quantità</th>" +
            "</tr>" +
            "</thead><tbody>";
            
            if(rows != null)
            {
                // inserisco il footer - richiedente e data
                string footerUtente = txtNominativo.Text;
                string footerData =
                    DateTime.Now.ToShortDateString();
                string footerOra =
                    DateTime.Now.ToShortTimeString();
                html =
                    html
                    .Replace("{footer-utente}", footerUtente)
                    .Replace("{footer-data}", footerData)
                    .Replace("{footer-ora}", footerOra);

                foreach (DataGridViewRow item in rows)
                {
                    string tipologia = Convert.ToString(item.Cells["Piatto"].Value);
                    string costo = Convert.ToString(item.Cells["Costo"].Value);
                    string quantita = Convert.ToString(item.Cells["Quantità"].Value);


                    var quantitaValore = quantita != "" ? Convert.ToInt32(item.Cells["Quantità"].Value) : 0;

                    if(quantitaValore > 0)
                    {
                        table +=
                            "<tr><td>" +
                            tipologia +
                            "</td><td>" +
                            costo +
                            "</td>" +
                            "<td>" +
                            quantita +
                            "</td>" +
                            "</tr>";
                    }
                }

                table += "<tr><td><strong>Totale</strong></td><td></td><td>" + lblCostoTotale.Text + " euro</td></tr>";
            }
            else
            {
                // inserisco il footer - richiedente e data
                string footerUtente = txtNominativo.Text;
                string footerData =
                    DateTime.Now.ToShortDateString();
                string footerOra =
                    DateTime.Now.ToShortTimeString();
                html =
                    html
                    .Replace("{footer-utente}", comanda.Nominativo)
                    .Replace("{footer-data}", comanda.Data.ToShortDateString())
                    .Replace("{footer-ora}", comanda.Data.ToShortTimeString());

                foreach (var item in comanda.Items)
                {
                    table +=
                            "<tr><td>" +
                            item.piatto.Tipologia +
                            "</td><td>" +
                            item.piatto.Costo +
                            "</td>" +
                            "<td>" +
                            item.Quantita +
                            "</td>" +
                            "</tr>";
                }

                table += "<tr><td><strong>Totale</strong></td><td></td><td>" + comanda.Totale + " euro</td></tr>";
            }
            
            // chiudo la tabella
            table += "</tbody></table>";

            html = html.Replace("{opzionali}", table);

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

        private int creaComandaSulDb(List<ComandaItem> items)
        {
            decimal costo = Convert.ToDecimal(lblCostoTotale.Text);

            var descrizione = "";
            int i = items.Count;
            foreach (var item in items)
            {
                descrizione += "Piatto: " + item.piatto.Tipologia + ", Costo: " + item.piatto.Costo + ", Quantità: " + item.Quantita;
                if (i > 1) { descrizione += " || "; }
                i--;
            }

            var comanda = new Comanda()
            {
                Nominativo = txtNominativo.Text,
                Descrizione = descrizione,
                Data = DateTime.Now,
                Totale = costo,
                Items = items
            };

            context.Comanda.Add(comanda);
            context.SaveChanges();

            return comanda.ID;
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

        private void loadComandeOggi()
        {
            var dt = new DataTable();
            dt.Columns.Add("Comanda", typeof(string));
            dt.Columns.Add("Nominativo", typeof(string));
            dt.Columns.Add("Descrizione", typeof(string));
            dt.Columns.Add("Totale", typeof(decimal));
            dt.Columns.Add("Data", typeof(DateTime));

            var comandeOggi = 
                context.Comanda.Where(x => EntityFunctions.TruncateTime(x.Data) == DateTime.Today)
                .OrderByDescending(x => x.ID)
                .ToList();

            decimal incasso = 0;
            foreach (var comanda in comandeOggi)
            {
                incasso += comanda.Totale;
                dt.Rows.Add(comanda.ID, comanda.Nominativo, comanda.Descrizione, comanda.Totale, comanda.Data);
            }

            gdvComandeOggi.DataSource = dt;
            gdvComandeOggi.Columns["Comanda"].ReadOnly = true;
            gdvComandeOggi.Columns["Descrizione"].ReadOnly = true;
            gdvComandeOggi.Columns["Totale"].ReadOnly = true;
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
                string columnName = this.gdvComandeOggi.Columns[e.ColumnIndex].Name;
                if (columnName == "btnStampa")
                {
                    var id = gdvComandeOggi.Rows[e.RowIndex].Cells["Comanda"].Value;

                    if (id != null)
                    {
                        var idComanda = Convert.ToInt32(id);
                        var comanda = context.Comanda.FirstOrDefault(x => x.ID == idComanda);

                        string html = impostaPdf(null, comanda);

                        html = html.Replace("{pratica-titolo}", idComanda.ToString());

                        Print(html);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'eliminazione del piatto.", "Errore");
            }
        }
    }
}
