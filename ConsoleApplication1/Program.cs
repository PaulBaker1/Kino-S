using System;
using System.Collections;
using System.IO;

namespace ConsoleApplication1
{
    class Film
    {
        //Obiekt DTO
        
        // Pusta Kieszen
        public Film()
        {
            tytul = "Lancuch nie nazwany";
            rokProdukcji = 0;
            recenzja = "Lancuch znakow - brak recenzji";
        }
        // Dajemy zeczy do pustej kieszeni
        public Film(string tyt, int rok, string rec)
        {
            tytul = tyt;
            rokProdukcji = rok;
            recenzja = rec;
        }
        
        
        public string tytul = null;
        public int rokProdukcji;
        public string recenzja = null;
    }

    class Repertuar
    {
        public void dodaj(Film f)
        {
            Filmy.Add(f);
        }

        public void pokarzRepertuar()
        {
            foreach (Film f in Filmy)
            {
                Console.WriteLine(f.tytul);
            }
        }
        public ArrayList Filmy = new ArrayList();
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Lokalizacja obiektu za allokowanego w pamieci operatorem new. Operatorem przypisywnia wspatwiamy ta lokalizacje do zmiennej referncyjne o nazwie film
            
            Film film = new Film();
            string Tytul1 = film.tytul;
            film.tytul = "Top Gun Maverick";
            string Tytul = film.tytul;
            film.rokProdukcji = 2022;
            int Data = film.rokProdukcji;
            film.recenzja = "4.5";
            string Recenzja = film.recenzja;
            
Console.WriteLine("Tytul: " + Tytul + "\n" + "Inny Tytul: " + Tytul1 +  "\n" + "Data: " + Data + "\n" + "Recenzja: " + Recenzja + "\n");


            Repertuar rep = new Repertuar();
            
            rep.dodaj(film);
            rep.dodaj(new Film("Spiderman", 1984, "3.5"));
            rep.dodaj(new Film("Ab", 1999, "2.5"));
            rep.dodaj(new Film("Zad", 1978, "3.0"));
            rep.pokarzRepertuar();
            
            
            //Agregacja i Kompozycja
            
            // Zrobic Bilet i Seans na podsatwie tego co wyzej
            // numer sali
            // Repertuar dzienny z Seans
            // Bazie w relacyjnej
            
            // Myslec co jest w bilecie rodzk
            // Myslec o senasie, z czego sie sklada.
            
        }
    }
}