//1. Créer une classe "Publication" qui est caractérisée par :
//-Titre: string
//- Auteur: string
//- AnneePublication: int

//2. La classe possède une méthode "AfficherInformations()" pour afficher les informations de la publication.


namespace exoQuentinGeerts
{
    internal class publication
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int AnneePublication { get; set; }
   
        public virtual void AfficherInformations()
        {
            Console.WriteLine($"Titre: \"{Titre}\"");
            Console.WriteLine($"Auteur: {Auteur}");
            Console.WriteLine($"Annee de publication: {AnneePublication}");
        }
    }
}
