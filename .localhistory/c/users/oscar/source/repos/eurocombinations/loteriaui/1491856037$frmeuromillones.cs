using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileDownloader = FileDownloader.Core.FileDownloader;

namespace LoteriaUI
{
    public partial class FrmEuromillones : Form
    {
        public FrmEuromillones()
        {
            InitializeComponent();
        }


        public FrmEuromillones(FrmMain mdi)
        {
            MdiParent = mdi;
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea actualizar el fichero?",
                                         "Aviso",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                actualizarFichero();
            }
        }


        private void actualizarFichero()
        {
            var rutaLocal = ConfigurationManager.AppSettings["RutaLocal"];
            var rutaRemota = ConfigurationManager.AppSettings["RutaRemota"];

            var fileDownloader = new global::FileDownloader.Core.FileDownloader();
            fileDownloader.DownloadFile(rutaRemota, rutaLocal, "Historico.csv");

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            cargarFichero();
        }



        private string[]  cargarFichero()
        {
            var rutaLocal = ConfigurationManager.AppSettings["RutaLocal"];
            var fullPath = rutaLocal + "Historico.csv";
            var fileDownloader = new global::FileDownloader.Core.FileDownloader();

            return fileDownloader.getFile(fullPath);
        }
    }
}
