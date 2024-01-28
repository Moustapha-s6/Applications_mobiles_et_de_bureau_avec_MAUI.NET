using System;

namespace Astronomy.Pages
{
    internal class AstroName
    {
        private string astroName;

        public string Name
        {
            get => astroName;
            set
            {
                astroName = value;

                // Appeler la méthode pour mettre à jour l'interface utilisateur si nécessaire
                 UpdateAstroBodyUI(astroName);
            }
        }

        // Si vous avez une méthode pour mettre à jour l'interface utilisateur, définissez-la ici
         private void UpdateAstroBodyUI(string name)
         {
             // Code pour mettre à jour l'interface utilisateur
         }
    }
}
