using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Apple : IObject
    {
        private string name = "Apple";
        private Coordinate coordonee;
        public string Name { get => name; set => name = value; }
        public Coordinate Coordonnee { get => coordonee; set => coordonee = value; }

        public Apple( Coordinate coordonee)
        {
            this.coordonee = coordonee;
        }
    }
}
