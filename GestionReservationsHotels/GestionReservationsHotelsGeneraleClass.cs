using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ce = GestionReservationsHotels.GestionReservationsHotelsGeneraleClass.Erreurs;

namespace GestionReservationsHotels
{
    internal class GestionReservationsHotelsGeneraleClass
    {
        #region Enumeration
        public enum Erreurs
        {
            CEErreurIndeterminee,
            CEErreurArgumentException,
            CEErreurSurCodesTypes,
            ECEErreurPrix,
            ECEErreurtypeChambre,
            ECEErreurService,
            ECEErreurCourrielFormat,
            ECEErreurCourrielVide,
            ECEErreurCourrielNull
        }
        #endregion

        #region Declaration
        public static string[] tMessagesErreursStr = new string[15];
        #endregion

        #region Initialisation
        public static void InitMessagesErreurs()
        {
            tMessagesErreursStr[(int)ce.CEErreurArgumentException] = "Paramètre incorrect pour le type de chambre ou le service supplémentaire.";
            tMessagesErreursStr[(int)ce.CEErreurIndeterminee] = "Erreur indéterminée. Contactez la réception pour assistance.";
            tMessagesErreursStr[(int)ce.ECEErreurPrix] = "Le prix de la réservation ne peut être déterminé avec les indices fournis.";
            tMessagesErreursStr[(int)ce.ECEErreurtypeChambre] = "Le type de chambre sélectionné est invalide.";
            tMessagesErreursStr[(int)ce.ECEErreurService] = "Le service supplémentaire sélectionné est invalide.";
            tMessagesErreursStr[(int)ce.ECEErreurCourrielFormat] = "Le format de l'adresse e-mail est invalide.";
            tMessagesErreursStr[(int)ce.ECEErreurCourrielVide] = "Le champ de l'adresse e-mail est vide.";
            tMessagesErreursStr[(int)ce.ECEErreurCourrielNull] = "L'adresse e-mail est absente.";
        }
        #endregion
    }
}
