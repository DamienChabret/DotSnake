using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    /// <summary>
    /// Représente un objet capable d'être sur le jeu
    /// </summary>
    public interface IObject
    {
        public string Name { get; set; }
        public Coordinate Coordonnee{ get; set; }
    }
}
