using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Zen.Barcode;
using System.Threading;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace BarcodeGenerator
{
    public partial class Dashboard : Form
    {
        private MySqlConnection connection = new MySqlConnection("SERVER=localhost; DATABASE=barcodes; UID=root; PASSWORD='';");
        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder commandBuilder;
        private DataTable table;
    
    public Dashboard()
        {
            InitializeComponent();
            backgroundWorkerGenAll.DoWork += genAll;
            adapter = new MySqlDataAdapter
            {
                SelectCommand = new MySqlCommand("SELECT * FROM barcodes", connection)
            };
            commandBuilder = new MySqlCommandBuilder(adapter);
            GetData();
        }

        private void GetData()
        {
            try
            {
                connection.Open();
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewCodes.DataSource = table;
                dataGridViewCodes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewCodes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nBist du dir sicher dass XAMPP gestartet ist?");
            }
            
        }

        private void UpdateDB()
        {
            commandBuilder.GetUpdateCommand();
            commandBuilder.GetInsertCommand();
            commandBuilder.GetDeleteCommand();
            adapter.Update(table);
            GetData();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string barcodeText = textBoxBarcodeText.Text;
            CodeQrBarcodeDraw barcode = BarcodeDrawFactory.CodeQr;
            BarcodeMetrics1d metrics = new BarcodeMetrics1d();
            try
            {
                Random r = new Random();
                Image code = BarcodeDrawFactory.CodeQr.Draw(textBoxBarcodeText.Text, 200, 5);
                pictureBoxBarcode.Image = code;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    code.Save(dialog.FileName, ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGenerateAll_Click(object sender, EventArgs e)
        {
            backgroundWorkerGenAll.RunWorkerAsync();
        }

        private void genAll(object sender, EventArgs eventArgs)
        {
            Random r = new Random();
                pictureBoxBarcode.Image = BarcodeDrawFactory.CodeEan8WithChecksum.Draw(r.Next(1000000, 9999999).ToString(), 200, 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDB();
        }

        private void dataGridViewCodes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < table.Rows.Count)
            {
                string code = table.Rows?[e.RowIndex]?["code"]?.ToString();
                if (code.Length == 8)
                {
                    pictureBoxBarcode.Image = BarcodeDrawFactory.CodeEan8WithChecksum.Draw(code.Substring(0, 7), 300, 5);
                }
            }
            
        }
    }
}
