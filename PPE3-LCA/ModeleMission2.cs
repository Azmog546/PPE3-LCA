using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;

namespace PPE3_LCA
{
    class ModeleMission2
    {
        private static LcaGsb maConnexion = Modele.getMaConnexion();
       /* public static object RapportParMedecin(int idMedecin)
        {
            var LQuery = maConnexion.RAPPORT.ToList()
               .Where(x => x.idMedecin == idMedecin )
               .Select(x => new { x.idRapport, x.dateRapport, x.idMedecin, x.idMotif, x.idVisiteur})
               .OrderBy(x => x.dateRapport);
            return LQuery.ToList();

        }*/
        public static Object RapportParMedecin(int idMedecin)
        {
            var LQuery = maConnexion.RAPPORT.ToList()
                           .Where(x => x.idMedecin == idMedecin)
                           .Select(x => new { x.idRapport, x.dateRapport, x.idMotif, x.bilan })
                           .OrderBy(x => x.dateRapport);
            return LQuery.ToList();

        }
        public static void init()
        {

        }
        public static Object listeMedecin()
        {
            return maConnexion.MEDECIN.ToList();
        }
        /*    public static List<MEDECIN> getLesMedecins()
            {
                return Modele.;
            } 
            */
        
     private void Button1_Click(object sender, EventArgs e)
     {
         FGestionVisite FGV = new FGestionVisite();
         FGV.Show();
     }
 

    }
}
