﻿using GestioneComande.Model;
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

namespace GestioneComande
{
    public partial class Form1 : Form
    {
        Bitmap memoryImage;

        public Form1()
        {
            InitializeComponent();
            loadListaPiatti();
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
                    objPiatto.Quantita = Convert.ToInt16(txtQuantita.Text);

                    // Create context object and then save company data.  
                    context.Piatto.Add(objPiatto);
                    context.SaveChanges();

                    loadListaPiatti();
                }
            }
            catch (Exception ex)
            {
                // Handle any exception.
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
        }

        private void loadComanda()
        {
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
        }

        private void btnSalvaListaPiatti_Click(object sender, EventArgs e)
        {
            var context = new Model.Model();
            this.gdrListaPiatti.EndEdit();
            this.gdrListaPiatti.Update();

            foreach(DataGridViewRow riga in gdrListaPiatti.Rows)
            {
                var id = Convert.ToInt16(riga.Cells["Id"].Value);
                var tipologia = riga.Cells["Tipologia"].Value.ToString();
                var quantita = Convert.ToInt16(riga.Cells["Quantita"].Value);
                var costo = Convert.ToDecimal(riga.Cells["Costo"].Value);
                //Piatto piatto = riga as Model.Piatto;
                ////Piatto cust = row.DataBoundItem as Piatto;

                var piattoDB = context.Piatto.SingleOrDefault(x => x.ID == id);
                piattoDB.Tipologia = tipologia.ToString();
                piattoDB.Costo = costo;
                piattoDB.Quantita = quantita;
            }

            context.SaveChanges();
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
            string html = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "template-pdf.html");

            // imposto l'oggetto
            html = html.Replace("{pratica-titolo}", "1");

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
            
            Print(html);

            rimuoviQuantita();
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
            decimal total = 0;

            foreach (DataGridViewRow row in gdvComanda.Rows)
            {
                if(row.Cells["Costo"].Value != null &&
                    row.Cells["Costo"].Value.ToString() != "" &&
                    row.Cells["Quantità"].Value != null && 
                    row.Cells["Quantità"].Value.ToString() != "")
                {
                    total += (decimal)row.Cells["Costo"].Value * (int)row.Cells["Quantità"].Value;
                }
            }

            lblCostoTotale.Text = total.ToString();
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