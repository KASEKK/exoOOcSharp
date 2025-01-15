using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoQuentinGeerts
{
    public class bibliotheque
    {
        private readonly Dictionary<publication, int> _publications = new();

        public publication[] this[string objet]
        {
            get
            {
                List<publication> publications = new();

                foreach (KeyValuePair<publication, int> keyValuePair in _publications)
                {
                    if (keyValuePair.Key.Titre.Contains(objet, StringComparison.OrdinalIgnoreCase))
                    {
                        publications.Add(keyValuePair.Key);
                    }
                }


                return publications.ToArray();
            }
        }

        void AjouterPublication(publication publication, int quantite)
        {
            if (_publications.ContainsKey(publication))
            {
                _publications[publication] += quantite;
            }
            else
            {
                _publications.Add(publication, quantite);
            }
        }
    }

    public void afficherPublications()
        {
            foreach (KeyValuePair< publication, int> keyValuePair in _publications)
            {
                keyValuePair.Key.AfficherInformations();
                Console.WriteLine($"Quantite: {keyValuePair.Value}");
            }
        }
    }
}
