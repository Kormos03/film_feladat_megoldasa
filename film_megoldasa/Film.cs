﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace film_megoldasa
{
    internal class Film
    {
        private int helyezes;
        private string cim;
        private int ev;
        private int hossz;
        private List<string> mufaj;
        public Film(string sor)
        {
            //1.;Négyszáz csapás;1959;99 min;Crime, drama
            string[] adatok = sor.Split(';');
            this.Helyezes = Convert.ToInt32(adatok[0].Substring(0, adatok[0].Length - 1));
            this.Cim = adatok[1];
            this.Ev = int.Parse(adatok[2]);
            this.Hossz = int.Parse(adatok[3].Split(' ')[0]);
            this.Mufaj = new List<string>();
            string[] mufajok = adatok[4].Split(',');
            foreach (var item in mufajok)
            {
                this.Mufaj.Add(item.Trim());
            }
            //this.mufaj = adatok[4].Split(", ").ToList();
        }

        public Film(int helyezes, string cim, int ev, int hossz, List<string> mufaj)
        {
            this.Helyezes = helyezes;
            this.Cim = cim;
            this.Ev = ev;
            this.Hossz = hossz;
            this.Mufaj = mufaj;
        }

        public int Helyezes { get => helyezes; set => helyezes = value; }
        public string Cim { get => cim; set => cim = value; }
        public int Ev { get => ev; set => ev = value; }
        public int Hossz { get => hossz; set => hossz = value; }
        public List<string> Mufaj { get => mufaj; set => mufaj = value; }
    }
}
