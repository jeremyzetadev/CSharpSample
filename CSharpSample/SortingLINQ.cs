using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpSample {
    internal class SortingLINQ {
        List<Material> lstMats;

        void PopulateMats() {
            lstMats = new List<Material>();
            lstMats.Add(new Material("Wood", 50));
            lstMats.Add(new Material("Steel", 75));
        }

        List<Material> SortMats() {
            var sort1 = from x in lstMats orderby x.age select x;
            var sort2 = lstMats.OrderBy(s => s.age).Select(s => s);
            var sort3 = from x in lstMats where x.age > 50 && x.age < 100 select x;
            var sort4 = lstMats.Where(s => s.age > 50 && s.age < 100).Select(s => s);
            return sort1.ToList();
        }
    }

    class Material {
        public string name;
        public int age;
        public Material(string name, int age) {
            this.name = name;
            this.age = age;
        }
    }
}
