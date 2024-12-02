using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

using ce = TransactionNS.Transaction.CodeErreurs;
namespace TransactionNS
{
    public class Transaction
    {
        #region Declaration des tableaux
        private string[] tTypeChambres = new String[20];
        private string[] tServices = new String[20];
        private decimal[,] tPrix = new decimal[20, 20];
        private CultureInfo anglaisCultureInfo = new CultureInfo("en-CA");
        #endregion

        #region Variables privees
        //private const string delimiter = ";";

        private string nomStr;
        private string courrielStr;
        private DateTime dateReservationnDateTime;
        string typeChambreStr;
        string serviceStr;
        private decimal prixDecimal;
        private decimal prixTotalDecimal;
        #endregion

        #region Enumeration et tableaux
        public enum CodeErreurs
        {
            NomObligatoire,
            PrenomObligatoire,
            courrielObligatoire,
            PrixInvalide,
            TypeChambreInvalide,
            ServiceInvalide,
            DateReservationInvalide,
            ErreurIndeterminee,
            ErreurFileNotFoundTypeChambre,
            ErreurFileNotFoundService,
            ErreurFileNotFoundPrix,
        }
        #endregion

        #region Declaration
        public static string[] tMessagesErreursStr = new string[50];
        #endregion

        #region Initialisation
        public static void InitMessagesErreurs()
        {
            tMessagesErreursStr[(int)ce.NomObligatoire] = "Le champ du nom est obligatoire.";
            tMessagesErreursStr[(int)ce.PrenomObligatoire] = "Le champ du prénom est obligatoire.";
            tMessagesErreursStr[(int)ce.PrixInvalide] = "Le prix de la réservation est invalide.";
            tMessagesErreursStr[(int)ce.TypeChambreInvalide] = "Le type de chambre sélectionné est invalide.";
            tMessagesErreursStr[(int)ce.ServiceInvalide] = "Le service supplémentaire sélectionné est invalide.";
            tMessagesErreursStr[(int)ce.DateReservationInvalide] = "La date de réservation est invalide.";
            tMessagesErreursStr[(int)ce.ErreurIndeterminee] = "Erreur indéterminée. Contactez la réception pour assistance.";
            tMessagesErreursStr[(int)ce.ErreurFileNotFoundTypeChambre] = "Le fichier contenant les types de chambres est introuvable.";
            tMessagesErreursStr[(int)ce.ErreurFileNotFoundService] = "Le fichier contenant les services supplémentaires est introuvable.";
            tMessagesErreursStr[(int)ce.ErreurFileNotFoundPrix] = "Le fichier contenant les prix est introuvable.";
        }
        #endregion

        #region Proprietes publiques
        public readonly int IdInt;
        public string NomStr
        {
            get { return nomStr; }
            set
            {
                if (value != null)
                {
                    value = value.Trim();

                    if (value != string.Empty)
                        nomStr = value;
                    else
                        throw new ArgumentException(tMessagesErreursStr[(int)ce.NomObligatoire]);
                }
                else
                    throw new ArgumentException(tMessagesErreursStr[(int)ce.NomObligatoire]);
            }
        }
        public string CourrielStr
        {
            get { return courrielStr; }
            set
            {
                if (value != null)
                {
                    value = value.Trim();

                    if (value != string.Empty)
                        courrielStr = value;
                    else
                        throw new ArgumentException(tMessagesErreursStr[(int)ce.courrielObligatoire]);
                }
                else
                    throw new ArgumentException(tMessagesErreursStr[(int)ce.courrielObligatoire]);
            }
        }
        public DateTime DateReservationDateTime
        {
            get { return dateReservationnDateTime; }
            set
            {
                if (value != null)
                {
                    if (value > DateTime.Now)
                        dateReservationnDateTime = value;
                    else
                        throw new ArgumentOutOfRangeException(tMessagesErreursStr[(int)ce.DateReservationInvalide]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreursStr[(int)ce.DateReservationInvalide]);
            }
        }
        public string TypeChambreStr
        {
            get { return typeChambreStr; }
            set
            {
                if (value != null && (value != string.Empty))
                {
                    if (Array.IndexOf(tTypeChambres, value.Trim()) != -1)
                        typeChambreStr = value.Trim();
                    else
                        throw new ArgumentOutOfRangeException(tMessagesErreursStr[(int)ce.TypeChambreInvalide]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreursStr[(int)ce.TypeChambreInvalide]);
            }
        }
        public string ServiceStr
        {
            get { return serviceStr; }
            set
            {
                if (value != null && !string.IsNullOrWhiteSpace(value))
                {
                    if (Array.IndexOf(tServices, value.Trim()) != -1)
                        serviceStr = value.Trim();
                    else
                        throw new ArgumentOutOfRangeException(tMessagesErreursStr[(int)ce.ServiceInvalide]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreursStr[(int)ce.ServiceInvalide]);
            }
        }
        public decimal PrixDecimal
        {
            get { return prixDecimal; }
            set
            {
                if (value > 0)
                {
                    if (!string.IsNullOrEmpty(typeChambreStr) && !string.IsNullOrEmpty(serviceStr))
                    {
                        // Exemple : Vérification des indices dans les tableaux
                        int indicetitre = Array.IndexOf(tTypeChambres, typeChambreStr);
                        int indicegenre = Array.IndexOf(tServices, serviceStr);

                        if (indicetitre != -1 && indicegenre != -1)
                        {
                            if (tPrix[indicetitre, indicegenre] == value)
                                prixDecimal = value;
                            else
                                throw new ArgumentException(tMessagesErreursStr[(int)ce.PrixInvalide]);
                        }
                        else
                            throw new ArgumentException(tMessagesErreursStr[(int)ce.ErreurIndeterminee]);
                    }
                    else
                        throw new ArgumentNullException(tMessagesErreursStr[(int)ce.ErreurIndeterminee]);
                }
                else
                    throw new ArgumentOutOfRangeException(tMessagesErreursStr[(int)ce.PrixInvalide]);
            }
        }

        public decimal PrixTotalDecimal
        {
            get { return prixTotalDecimal; }
            set { prixTotalDecimal = value; }
        }
        #endregion


        #region Constructeur        
        public Transaction()
        {
            //InitTypeChambres();
            //InitServices();
            //InitPrix();
        }
        #endregion

        #region Initialisation des tableaux
        /// <summary>
        /// methode pour initialiser les titres
        /// </summary>
        private void InitTypeChambres()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "TypeChambres.data");

            try
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
                {
                    // Lire le nombre d'éléments
                    string ligne = sr.ReadLine();
                    int nombre = int.Parse(ligne);

                    Array.Resize(ref tTypeChambres, nombre);
                    for (int i = 0; i < nombre; i++)
                        tTypeChambres[i] = sr.ReadLine().Trim();
                }
            }
            catch (Exception)
            {
                throw new Exception($"Erreur lors du chargement du fichier ");
            }
        }
        /// <summary>
        /// methode pour initialiser les genres
        /// </summary>
        private void InitServices()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Services.data");
            try
            {
                using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.UTF8))
                {
                    string ligne = sr.ReadLine();
                    int nombre = int.Parse(ligne);
                    Array.Resize(ref tServices, nombre);

                    for (int i = 0; i < nombre; i++)
                        tServices[i] = sr.ReadLine().Trim();
                }
            }
            catch (FileNotFoundException)
            {
                throw new Exception($"Fichier introuvable !");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors du chargement du fichier : {ex.Message}");
            }
        }
        /// <summary>
        /// methode pour initialiser les prix
        /// </summary>
        private void InitPrix()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Prix.data");

            try
            {
                using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.UTF8))
                {

                    int rangée = tTypeChambres.Length;
                    int colonne = tServices.Length;
                    ResizeArray(ref tPrix, rangée, colonne);
                    for (int i = 0; i < rangée; i++)
                    {
                        for (int j = 0; j < colonne; j++)
                        { tPrix[i, j] = Decimal.Parse(sr.ReadLine(), anglaisCultureInfo); }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw new Exception($"Fichier introuvable !");
            }
            catch (Exception)
            {
                throw new Exception($"Erreur lors du chargement du fichier ");
            }
        }
        #endregion

        #region Methode publique
        public void Enregistrer()
        {
        }
        #endregion

        #region Méthode privée ResizeArray
        private void ResizeArray(ref decimal[,] prix, int pRangé, int pColonne)
        {
            prix = new decimal[pRangé, pColonne];
        }
        #endregion
    }
}
