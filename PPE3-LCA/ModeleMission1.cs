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

            Visiteur unVisiteur = new Visiteur();
            unVisiteur.nom = unNom;
            unVisiteur.prenom = unPrenom;
            unVisiteur.identifiant = unIdentifiant;
            unVisiteur.rue = uneAdresse;
            unVisiteur.ville = uneVille;
            //unVisiteur

        }

    }
}
