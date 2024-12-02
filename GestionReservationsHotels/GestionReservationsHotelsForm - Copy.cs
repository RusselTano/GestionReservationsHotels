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

namespace GestionReservationsHotels
{
    public partial class GestionReservationsHotelsForm : Form
    {
        public GestionReservationsHotelsForm()
        {
            InitializeComponent();
        }

        private void GestionReservationsHotelsForm_Load(object sender, EventArgs e)
        {
           // ChargerPolicePersonnalisee();
        }


        #region Methode privees
        private void ChargerPolicePersonnalisee()
        {
            PrivateFontCollection fontCollection = new PrivateFontCollection();
            string cheminPolice = AppDomain.CurrentDomain.BaseDirectory + @"Roboto-Regular.ttf";
            fontCollection.AddFontFile(cheminPolice);
            this.Font = new Font(fontCollection.Families[0], 10);
        }
        #endregion

    }
}
