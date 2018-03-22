/*
Feedback av Gergely Szabo:
Koden är nästa exakt kopia av Leos lösningsförslag så det är perfekt.
Det enda "felet", jag hittade var att du inte använde System.Threading.Tasks eller 
System.Linq. Du behöver inte implementera "using" direktiv för de namespaces.
Programmet uppfyller både de tekniska kraven och kraven på innehållet.
*/
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace uppgift3
{
    class Country
    {

        private string name;
        private int inhabitants;
        private int bnp_capita;
        private List<City> cities;

        public Country(string name, int inhabitants, int bnp_capita)
        {
            this.name = name;
            this.inhabitants = inhabitants;
            this.bnp_capita = bnp_capita;
            createList();
        }

        private void createList()
        {
            cities = new List<City>();
        }


        public string Name { get => name; set => name = value; }
        public int Inhabitants { get => inhabitants; set => inhabitants = value; }
        public int Bnp_capita { get => bnp_capita; set => bnp_capita = value; }
        internal List<City> Cities { get => cities; set => cities = value; }
    }
}
