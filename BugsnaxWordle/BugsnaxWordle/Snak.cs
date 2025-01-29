using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugsnaxWordle
{
    public class Snak
    {
        public string Name { get; set; } //Name of the Snak
        public string Type { get; set; } //Sweet, Spicy, etc.
        public string Diet { get; set; } //What sauce they like
        public string Location { get; set; } //Where they can be found
        public bool Varients { get; set; } //If there are multiple varients of the Snak

        //Deafult Constructor for a Snak
        public Snak(string name, string type, string diet, string location, bool varients)
        {
            Name = name;
            Type = type;
            Diet = diet;
            Location = location;
            Varients = varients;
        }
    }
}
