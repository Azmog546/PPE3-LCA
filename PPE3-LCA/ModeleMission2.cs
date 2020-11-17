using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_LCA
{
    class ModeleMission2
    {
        private static LcaGsb maConnexion;
        public static object RapportParMedecin(int idMedecin)
        {
            var LQuery = maConnexion.RAPPORT.ToList()
               .Where(x => x.idMedecin == idMedecin )
               .Select(x => new { x.idRapport, x.dateRapport, x.idMedecin, x.idMotif, x.idVisiteur})
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
    } 
}
