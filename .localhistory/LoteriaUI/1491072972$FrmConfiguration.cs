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

namespace LoteriaUI
{
    public partial class FrmConfiguration : Form
    {
        public FrmConfiguration()
        {
            InitializeComponent();

            initPagEuromillones();
        }


        private void initPagEuromillones()
        {
            var rutaLocal = ConfigurationManager.AppSettings["RutaLocal"];
            var rutaRemota = ConfigurationManager.AppSettings["RutaRemota"];

            txtRutaLocal.Text = rutaLocal;
            txtRutaRemota.Text = rutaRemota;
        }


        private void btnGuardarRutas_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea guardar los cambios?",
                                         "Aviso",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                guardarCambiosRutas();
            }
        }


        private void guardarCambiosRutas()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);

            config.AppSettings.Settings["RutaLocal"].Value = txtRutaLocal.Text;
            config.AppSettings.Settings["RutaRemota"].Value = txtRutaRemota.Text;

            config.Save();
            ConfigurationManager.RefreshSection("appSettings");


            //ConfigurationManager.AppSettings.Set("RutaLocal",txtRutaLocal.Text);
            //ConfigurationManager.AppSettings.Set("RutaRemota", txtRutaRemota.Text);

        }
    }
}
