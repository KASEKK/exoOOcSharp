using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoQuentinGeerts
{
    internal class magazin : publication
    {
        int numeroEdition { get; set; }

        public override void AfficherInformations()
        {
            Console.WriteLine($"Titre: \"{Titre}\"");
            Console.WriteLine($"Auteur: {Auteur}");
            Console.WriteLine($"Annee de publication: {AnneePublication}");
            Console.WriteLine($"Numero d'édition: {numeroEdition}");
        }
    }
}
