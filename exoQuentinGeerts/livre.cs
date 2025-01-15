using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoQuentinGeerts
{
    public class livre : publication
    {
        int nombreDePages { get; set; }

        public override void AfficherInformations()
        {
            Console.WriteLine($"Titre: \"{Titre}\"");
            Console.WriteLine($"Auteur: {Auteur}");
            Console.WriteLine($"Annee de publication: {AnneePublication}");
        }

    }
}
