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
using LoteriaUI.Tools;
using NumbersAnalyzer.Models;

//using FileDownloader = FileDownloader.Core.FileDownloader;

namespace LoteriaUI
{
    public partial class FrmEuromillones : Form
    {
        private DataTableLoader<mEuroCombination> _dtLoader;
        private DataGridViewConfigurator<mEuroCombination> _dtgConfigurator;
        private CombinationManager _combinationManager;


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
            _dtgConfigurator = new DataGridViewConfigurator<mEuroCombination>(dataGridView1, _dtLoader);

            var fileDataExtractor = new FileDataExtractor(cargarFichero());
            _combinationManager = new CombinationManager(fileDataExtractor);
            var combinations = _combinationManager.Combinations.Select(x => new mEuroCombination(x))
                                                              .OrderByDescending(x => x.Date)
                                                              .ToList();

            lblNumCombinaciones.Text = _combinationManager.Combinations.Count.ToString();
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



        private string[] cargarFichero()
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var patterns = _combinationManager.getPatterns();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var numbers = _combinationManager.Combinations.Select(x => x.Number5).ToList();

            var section1 = new Section() { From = 1, To = 10, Name = "Seccion1" };
            var section2 = new Section() { From = 10, To = 20, Name = "Seccion2" };
            var section3 = new Section() { From = 20, To = 30, Name = "Seccion3" };
            var section4 = new Section() { From = 30, To = 40, Name = "Seccion4" };
            var section5 = new Section() { From = 40, To = 50, Name = "Seccion5" };

            var sections = new Sections();
            sections.Add(section1);
            sections.Add(section2);
            sections.Add(section3);
            sections.Add(section4);
            sections.Add(section5);


            var dataProvider = new DataProvider(numbers,sections);

            var numbersAnalyzer = new NumbersAnalyzer.Analitics.NumbersAnalyzer();
            numbersAnalyzer.AnalyzeNumbers(dataProvider);
            
        }
    }
}
