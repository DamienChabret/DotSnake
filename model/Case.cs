using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Case
    {
        private IObject item; // Objet sur la classe, null d'origine

        public IObject Item { get => item; set => item = value; }

        public void SetItem(IObject item)
        {
            this.Item = item;
        }
    }
}
