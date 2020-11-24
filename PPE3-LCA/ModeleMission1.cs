using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_LCA
{
    class ModeleMission1
    {

        public static void modifInfoUtilisateur(string unNom, string unPrenom, string unIdentifiant, string uneAdresse, string uneVille, string unCodePostal)
        {

            Visiteur unVisiteur = Modele.getUtilisateurConnected();
            unVisiteur.nom = unNom;
            unVisiteur.prenom = unPrenom;
            unVisiteur.identifiant = unIdentifiant;
            unVisiteur.rue = uneAdresse;
            unVisiteur.ville = uneVille;
            unVisiteur.cp = unCodePostal;
            Modele.setUtilisateurConnected(unVisiteur);

        }

        public static Object listRegionResponsable(string idVisiteur)
        {

            LcaGsb maConnexion = Modele.getConnexion();

            var LQuery = maConnexion.Region.ToList()
                .Where(x => x.idVisiteur == idVisiteur)
                .Select(x => new { x.libRegion })
                .OrderBy(x => x.libRegion);

            return LQuery.ToList();

        }

        public static Object listSecteurResponsable(string idVisiteur)
        {

            LcaGsb maConnexion = Modele.getConnexion();

            var LQuery = maConnexion.Region.ToList()
                .Where(x => x.idVisiteur == idVisiteur)
                .Select(x => new { x.libRegion })
                .OrderBy(x => x.libRegion);

            return LQuery.ToList();

        }

    }
}
