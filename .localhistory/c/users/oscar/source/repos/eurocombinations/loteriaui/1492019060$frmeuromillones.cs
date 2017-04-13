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
using EuroCombinations.Manage;
using Infrastructure.TableUtilities.Manage;
using Infrastructure.Tools.Euromillones;
using LoteriaUI.Models.Euromillones;
//using FileDownloader = FileDownloader.Core.FileDownloader;

namespace LoteriaUI
{
    public partial class FrmEuromillones : Form
    {
        private DataTableLoader<mEuroCombination> _dtLoader;
        private DataGridViewConfigurator<mEuroCombination> _dtgConfigurator;


        public FrmEuromillones()
        {
            InitializeComponent();
            initDataGridView();
        }


        public FrmEuromillones(FrmMain mdi)
        {
            MdiParent = mdi;

            InitializeComponent();
            initDataGridView();
        }


        private void initDataGridView()
        {
            _dtLoader = new DataTableLoader<mEuroCombination>();
            _dtgConfigurator = new DataGridViewConfigurator<mEuroCombination>(dataGridView1,_dtLoader);

            var fileDataExtractor = new FileDataExtractor(cargarFichero());
            var combinationManager = new CombinationManager(fileDataExtractor);
            var combinations = combinationManager.Combinations.Select(x => new mEuroCombination(x))
                                                              .OrderByDescending(x => x.Date)
                                                              .ToList();
                

            _dtgConfigurator.addSource(combinations);
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
            obtenerListaCombinaciones(cargarFichero());
        }



        private string[]  cargarFichero()
        {
            var rutaLocal = ConfigurationManager.AppSettings["RutaLocal"];
            var fullPath = rutaLocal + "Historico.csv";
            var fileDownloader = new global::FileDownloader.Core.FileDownloader();

            return fileDownloader.getFile(fullPath);
        }


        private void obtenerListaCombinaciones(string[] datos)
        {
            var fileDataExtractor = new FileDataExtractor(datos);
            var combinationManager = new CombinationManager(fileDataExtractor);
            
            
        }
    }
}
