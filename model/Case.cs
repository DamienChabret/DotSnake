using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Case
    {
        private TypeObject item; // Objet sur la classe, null d'origine
        private Coordinate coordinate;
        public TypeObject Item { get => item; set => item = value; }
        public Coordinate Coordinate { get => coordinate; set => coordinate = value; }

        public Case(int y, int x)
        {
            coordinate = new Coordinate(y, x);
            item = TypeObject.NO_OBJECT;
        }

        public void SetItem(TypeObject item)
        {
            this.Item = item;
        }
    }
}
