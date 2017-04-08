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
using System.Xml;

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
            //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //config.AppSettings.Settings["RutaLocal"].Value = txtRutaLocal.Text;
            //config.AppSettings.Settings["RutaRemota"].Value = txtRutaRemota.Text;

            //config.Save(ConfigurationSaveMode.Full);
            //ConfigurationManager.RefreshSection("appSettings");

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);


            foreach (XmlElement element in xmlDoc.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value.Equals("Setting1"))
                        {
                            node.Attributes[1].Value = "New Value";
                        }
                    }
                }
            }

           // var xmlConfiguration = xmlDoc.ChildNodes[];
           // var xmlAppSettings = xmlConfiguration.OwnerDocument.

            //ConfigurationManager.AppSettings.Set("RutaLocal",txtRutaLocal.Text);
            //ConfigurationManager.AppSettings.Set("RutaRemota", txtRutaRemota.Text);

        }
    }
}
