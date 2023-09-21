using System;
using System.Diagnostics;

namespace film_megoldasa
{
    internal class Film_megolddasa
    {

        static List<Film> filmek = new List<Film>();
        public static void Main()
        {
            Faljbeolvasas("filmadatbazis.csv");
            foreach(var item in filmek)
            { Debug.WriteLine(item.Cim); }      //it writes into the debug console
            Feladat01();
            Feladat02();
        }
        
        private static void Faljbeolvasas(string faljNev)
        {
            using (var fileReader = new StreamReader(faljNev))      //this will closes the database automatically
            {
                fileReader.ReadLine();
                while (!fileReader.EndOfStream) 
                {
                    string sor = fileReader.ReadLine();
                    Film film = new Film(sor);
                    filmek.Add(film);
                }
            }
        }
        private static void Feladat01()
        {
            Console.WriteLine("1. Filmek átlagos hossza: " + GetAtlagosHossz() + " perc");
        }
        private static void Feladat02()
        {
            Console.WriteLine("A leghosszabb film: " + LegHosszabbFilm());
        }
        private static void Feladat03() 
        {
            Console.WriteLine("Film keresés: ");
            string cim = Console.ReadLine();
            Film film = FilmKeres(cim);
            if (film == null)
            {
                Console.WriteLine("Nincs ilyen film");
            }
            else { Console.WriteLine(); }
        }
        private static void Feladat04()
        {
            Console.WriteLine("Adja meg a keresendő részleteit:");
            string keresendo = Console.ReadLine();
            List<string> cimek = FilmReszKeres(keresendo);
            foreach (string item in cimek) { Console.WriteLine("\t" + item); }
        }
        private static object GetAtlagosHossz()
        {
            int osszhossz = 0;
            foreach (var film in filmek)
            {
                osszhossz += film.Hossz;
            }
            return osszhossz / filmek.Count;
        }
        private static Film LegHosszabbFilm()
        {
            Film leghosszabbfilm = filmek[0];
            for (int i = 1; i <filmek.Count; i++)
            {
                if (leghosszabbfilm < filmek[i])
                {
                    leghosszabbfilm = filmek[i];
                }
            }
            return leghosszabbfilm;
        }
        private static Film FilmKeres(string cim)
        {
            int i = 0;
            while (i < filmek.Count && filmek[i].Cim != cim) {i++ }
            if(i < filmek.Count)
            {
                return filmek[i];
            }
            else
            {
                return null;
            }
        }
        private static Film FilmReszKeres(string cim) 
        {

            return cim;
        }
        private static object GetLeggyakoribbMufaj()
        {
            Dictionary<string, int> mufajokgyakorisaga = new Dictionary<string, int>();
            foreach(var film in filmek)
            {
                foreach(var mufaj in film.Mufaj)
                {
                    if (!mufajokgyakorisaga.ContainsKey(mufaj))
                    {
                        mufajokgyakorisaga.Add(mufaj, 1);
                    }
                    else
                    {
                        mufajokgyakorisaga[mufaj] += 1;0
                    }
                }
            }
            /* foreach (KeyValuePair<string, int> mufajgyakorisag in mufajokgyakorisaga)
             {
                 Console.WriteLine(mufaj.Keys - mufaj.Value);
             }
            */
            int leggyakoribbDarab = int.MinValue;
            string leggyakoribbMufaj = "";
            foreach(var mufaj in mufajokgyakorisaga)
            {
                return leggyakoribbDarab; //Nem jó
            }
        }
    }
}