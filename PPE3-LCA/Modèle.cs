﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_LCA
{
    class Modele
    {
        private static LcaGsb maConnexion;

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new LcaGsb();
        }
        public static bool testIdentifiant(string unIdentifiant)
        {
            List<Visiteur> listeVisiteur = new List<Visiteur>();
            listeVisiteur = maConnexion.Visiteur.ToList();
            bool test = false;
            for(int i=0; i< listeVisiteur.Count(); i++)
            {
                if(listeVisiteur[i].identifiant == unIdentifiant)
                {
                    test = true;
                }
            }
            return test;
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
