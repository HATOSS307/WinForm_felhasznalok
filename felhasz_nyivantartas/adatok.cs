using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace felhasz_nyivantartas
{
    internal class adatok
    {
        int id;
        string nev;
        MySqlDateTime szuletesidatum;
        string profilkep_nev;    

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public MySqlDateTime Szuletesidatum { get => szuletesidatum; set => szuletesidatum = value; }
        public string Profilkep_nev { get => profilkep_nev; set => profilkep_nev = value; } 
        public adatok(int id, string nev, MySqlDateTime szuletesidatum, string profilkep_nev)
        {
            Id = id;
            Nev = nev;
            Szuletesidatum = szuletesidatum;
            Profilkep_nev = profilkep_nev;
        }
        public override string ToString()
        {
            return nev;
        }
    }
}
