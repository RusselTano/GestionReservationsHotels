using GestionReservationsHotels.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransactionNS;

namespace GestionReservationsHotels
{
    public partial class GestionReservationsHotelsForm : Form
    {
        #region Déclaration
        private Transaction oTrans;
        #endregion
        public GestionReservationsHotelsForm()
        {
            InitializeComponent();
            oTrans = new Transaction();
        }

        private void GestionReservationsHotelsForm_Load(object sender, EventArgs e)
        {
        }

        #region Transmettre les données par les propriétés
        /// <summary>
        /// Gère l'événement de clic du bouton Enregistrer.
        /// Transmet les données du projet principal au projet Transaction en utilisant les propriétés.
        /// </summary>
        public void Enregistrer_Click()
        {
            try
            {
                oTrans.NomStr = nomTextBox.Text;
                oTrans.TypeChambreStr = typeChambreComboBox.SelectedItem.ToString();
                oTrans.ServiceStr = serviceComboBox.SelectedItem.ToString();
                oTrans.DateReservationDateTime = dateReservationDateTimePicker.Value;
                oTrans.PrixTotalDecimal = Decimal.Parse(prixLabel.Text.Replace("$", "").Trim());
                oTrans.Enregistrer();

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Methode privees

        #endregion

    }
}
