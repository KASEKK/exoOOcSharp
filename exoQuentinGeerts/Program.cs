//using System.Runtime.ConstrainedExecution;
//using System;

//Exercice Polymorphisme - Gestion d'une bibliothèque numérique

//1. Créer une classe "Publication" qui est caractérisée par :
//-Titre: string
//- Auteur: string
//- AnneePublication: int

//2. La classe possède une méthode "AfficherInformations()" pour afficher les informations de la publication.

//Créer les classes suivantes :
//-Livre(hérite de Publication)
//    - NombreDePages: int
//    - Redéfinir la méthode "Afficher Informations()" pour afficher les informations du livre
//- Magazin (hérite de Publication)
//    - NumeroEdition: int
//    - Redéfinir la méthode "Afficher Informations()" pour afficher les informations du magazine
//- Journal (hérite de Publication)
//    - DatePublication: Datetime
//    - Redéfinir la méthode "Afficher Informations()" pour afficher les informations du journal

//3. Créer une classe "Bibliotheque" qui contiendra un dictionnaire avec comme clef la publication et comme valeur le nombre d'exemplaires

//La classe possède une méthode pour ajouter une publication à la liste.
//La classe poss§de une méthode qui permet de lister toutes les publications avec leur nombre d'exemplaires en console.

//Bonus : créer un indexeur qui permet de récupérer toutes les publications qui possèdent dans leur titre une chaine de 
//caractères passée en paramètres

//4. Dans la classe Program, instancier les classes dérivées et la classe bibliothèque.
//Ajouter les différentes publications dans la liste de la bibliothèque.
//Appeler la méthode qui permet de lister toutes les publications.


namespace exoQuentinGeerts;


