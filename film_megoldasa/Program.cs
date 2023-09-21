using System;

namespace film_megoldasa
{
    internal class Film_megolddasa
    {

        static List<Film> filmek = new List<Film>();
        public static void Main()
        {
            Faljbeolvasas("filmadatbazis.csv");
            foreach(var item in filmek)
            { Console.WriteLine(item.Cim); }
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
    }
}