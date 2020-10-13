using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PPE3_LCA
{
    class Modele
    {
        private static LcaGsb maConnexion;
        private static Visiteur utilisateurConnecte;
        private static bool connexionValide = false;


        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new LcaGsb();
        }

        public static bool testConnexion(string unIdentifiant, string unMdp)
        {
            if (testIdentifiant(unIdentifiant))
            {
                if(testPassword(unMdp, unIdentifiant))
                {

                    utilisateurConnecte = getObjetVisiteurAvecIdentifiant(unIdentifiant);
                    connexionValide = true;

                }
                

            }
            return true;
        }

        public static bool testIdentifiant(string unIdentifiant)
        {

            bool test = false;
            
            if(getObjetVisiteurAvecIdentifiant(unIdentifiant) != null)
            {
                test = true;
            }

            return test;
        }

        public static Visiteur getObjetVisiteurAvecIdentifiant(string unIdentifiant)
        {
            List<Visiteur> listeVisiteur = new List<Visiteur>();
            listeVisiteur = maConnexion.Visiteur.ToList();

            Visiteur unVisiteur = null;

            for (int i = 0; i < listeVisiteur.Count(); i++)
            {
                if (listeVisiteur[i].identifiant == unIdentifiant)
                {

                    unVisiteur = listeVisiteur[i];

                }
            }

            return unVisiteur;

        }

        public static bool testPassword(string unMdp, string unIdentifiant)
        {
            GetMd5Hash(unMdp);
           
            bool test = false;
            
                if (getObjetVisiteurAvecIdentifiant(unIdentifiant).password == unMdp)
                {
                    test = true;
                }

            return test;
        }
        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        /* public static Object CompositeurParNationalite(int idNation)
         {
             var LQuery = maConnexion.COMPOSITEUR.ToList()
                            .Where(x => x.idNation == idNation)
                            .Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.STYLE.libStyle, x.anNais, x.anMort, x.remarque })
                            .OrderBy(x => x.nomCompositeur);
             return LQuery.ToList();

         }

         public static Object CompositeurTouteNation()
         {
             var LQuery = maConnexion.COMPOSITEUR.ToList()
                            .Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.STYLE.libStyle, x.anNais, x.anMort, x.remarque })
                            .OrderBy(x => x.nomCompositeur);
             return LQuery.ToList();

         }

         public static Object CompositeurParStyle(int idStyle)
         {
             var LQuery = maConnexion.COMPOSITEUR.ToList()
                            .Where(x => x.idStyle == idStyle)
                            .Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.STYLE.libStyle, x.anNais, x.anMort, x.remarque })
                            .OrderBy(x => x.nomCompositeur);
             return LQuery.ToList();

         }

         public static List<STYLE> ListeStyle()
         {
             return maConnexion.STYLE.ToList();
         }

         public static List<NATIONALITE> ListeNationalite()
         {
             return maConnexion.NATIONALITE.ToList();
         }
         */
    }
}
