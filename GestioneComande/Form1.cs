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

        public Form1()
        {
            InitializeComponent();
            loadListaPiatti();
            setDeleteButton();
            this.WindowState = FormWindowState.Maximized;
            tabGestioneComande.SizeMode = TabSizeMode.Fixed;
            tabGestioneComande.ItemSize = 
                new Size((tabGestioneComande.Width / tabGestioneComande.TabPages.Count) - 1, tabGestioneComande.ItemSize.Height);
        }
        
        //Hook to form or parent container Resize event, either Resize or ResizeEnd.
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            tabGestioneComande.ItemSize = 
                new Size((tabGestioneComande.Width / tabGestioneComande.TabPages.Count) - 1, tabGestioneComande.ItemSize.Height);
        }

        private void Crea_Click(object sender, EventArgs e)
        {            
            try
            {
                //using (var connection = new SqlConnection())
                //using (var command = new SqlCommand())
                using (var context = new Model.Model())
                {
                    // Set values into company model.  
                    Piatto objPiatto = new Piatto();
                    objPiatto.Tipologia = txtTipologia.Text;
                    objPiatto.Costo = Convert.ToDecimal(txtCosto.Text);
                    objPiatto.Quantita = Convert.ToInt32(txtQuantita.Text);

                    // Create context object and then save company data.  
                    context.Piatto.Add(objPiatto);
                    context.SaveChanges();

                    loadListaPiatti();

                    MessageBox.Show("Piatto \"" + txtTipologia.Text + "\" creato correttamente.", "Messaggio");
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

        private void loadListaPiatti()
        {
            var context = new Model.Model();
            gdrListaPiatti.DataSource = context.Piatto.ToList();
            gdrListaPiatti.Columns["ID"].ReadOnly = true;
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

        private void loadComanda()
        {
            lblCostoTotale.Text = "";
            lblDataAttuale.Text = DateTime.Now.ToShortDateString();
            lblOraAttuale.Text = DateTime.Now.ToShortTimeString();
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Piatto", typeof(string));
            dt.Columns.Add("Costo", typeof(decimal));
            dt.Columns.Add("Quantità", typeof(int));

            var context = new Model.Model();
            
            int space = 20;
            foreach (var piatto in context.Piatto.ToList())
            {
                var labelTipologia = new Label() { Name = "lbl" + piatto.Tipologia, Text = piatto.Tipologia };
                var labelCosto = new Label() { Name = "lbl" + piatto.Costo, Text = piatto.Costo.ToString() };
                var labelQuantita = new Label() { Name = "lbl" + piatto.Quantita, Text = piatto.Quantita.ToString() };
                //var dropdown = new ComboBox() { Name = "ddl" + piatto.Tipologia, Text = "Seleziona la quantità" };

                int n = piatto.Quantita;

                dt.Rows.Add(piatto.ID, piatto.Tipologia, piatto.Costo);
            }

            gdvComanda.DataSource = dt;
            gdvComanda.Columns["ID"].ReadOnly = true;
        }

        private void loadComandeOggi()
        {
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Descrizione", typeof(string));
            dt.Columns.Add("Totale", typeof(decimal));
            dt.Columns.Add("Data", typeof(DateTime));

            var context = new Model.Model();

            var comandeOggi = context.Comanda.Where(x => EntityFunctions.TruncateTime(x.Data) == DateTime.Today).ToList();
            foreach (var comanda in comandeOggi)
            {
                dt.Rows.Add(comanda.ID, comanda.Descrizione, comanda.Totale, comanda.Data);
            }

            gdvComandeOggi.DataSource = dt;
            gdvComandeOggi.Columns["ID"].ReadOnly = true;
            gdvComandeOggi.Columns["Descrizione"].ReadOnly = true;
            gdvComandeOggi.Columns["Totale"].ReadOnly = true;
            gdvComandeOggi.Columns["Data"].ReadOnly = true;
        }

        private void gdrListaPiatti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var context = new Model.Model();
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

                        context.Piatto.Remove(piatto);
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
                var context = new Model.Model();
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


        WebBrowser webBrowser = new WebBrowser();
        void Print(string str)
        {
            webBrowser.DocumentText = str;
            webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
        }
        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser.ShowPrintDialog();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    string descrizioneComanda = "";

                    string html = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "HtmlFile/template-pdf.html");
                    
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

                    foreach (DataGridViewRow item in this.gdvComanda.Rows)
                    {
                        string tipologia = Convert.ToString(item.Cells["Piatto"].Value);
                        string costo = Convert.ToString(item.Cells["Costo"].Value);
                        string quantita = Convert.ToString(item.Cells["Quantità"].Value);

                        descrizioneComanda += "Piatto: " + tipologia + ", Costo: " + costo + ", Quantità: " + quantita + " - ";

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

                    table += "<tr><td><strong>Totale</strong></td><td></td><td>" + lblCostoTotale.Text + " euro</td></tr>";

                    // chiudo la tabella
                    table += "</tbody></table>";

                    html = html.Replace("{opzionali}", table);

                    // imposto l'oggetto
                    var comandaID = creaComandaSulDb(descrizioneComanda);
                    html = html.Replace("{pratica-titolo}", comandaID.ToString());

                    Print(html);

                    rimuoviQuantita();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante la creazione della comanda.", "Errore");
            }
        }

        private int creaComandaSulDb(string descrizioneComanda)
        {
            var context = new Model.Model();
            decimal costo = Convert.ToDecimal(lblCostoTotale.Text);
            var comanda = new Comanda()
            {
                Descrizione = descrizioneComanda,
                Data = DateTime.Now,
                Totale = costo
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

        private void gdvComanda_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var context = new Model.Model();
            decimal total = 0;

            var id = gdvComanda.Rows[e.RowIndex].Cells["id"].Value != null 
                ? Convert.ToInt32(gdvComanda.Rows[e.RowIndex].Cells["id"].Value) 
                : (int?)null;
            var quantità = gdvComanda.Rows[e.RowIndex].Cells["Quantità"].Value != null
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

        private void rimuoviQuantita()
        {
            var context = new Model.Model();

            foreach (DataGridViewRow row in this.gdvComanda.Rows)
            {

                if(row.Cells["ID"].Value != null &&
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
    }
}
