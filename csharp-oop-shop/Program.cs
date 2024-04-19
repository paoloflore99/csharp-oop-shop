using csharp_oop_shop;
using System;
using System.Xml.Linq;

namespace csharp_oop_shop
{

    public class Prodotto
    {
        public int codice
        {
         private   get ; set;
        }
        public string nome { get; set; }
        public string description { get; set; }
        public double prezzo { get; set; }
        public double iva { get; set; }


        public Prodotto(string nome, string description, double prezzo, double iva)
        {
            codice = RandomCodice();
            this.nome = nome;
            this.description = description;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        public int RandomCodice()
        {
            Random rnd = new Random();
            return rnd.Next(10, 100);
        }
        public double GetPrezzo()
        {
            return prezzo;
        }
        

        public double PrezzoPIuIva()
        {
            return prezzo * (1 + (double)iva / 100);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {


            Prodotto Prodottodettagliato = new Prodotto(" lampada", " luminosa come la luce", 10, 22);
            int NumeroCasuale = Prodottodettagliato.RandomCodice();
 

            //stampo il numero casuale
            Console.WriteLine($"il numero casuale generato e {NumeroCasuale}");
            Console.WriteLine($"nome del prodotto{Prodottodettagliato.nome}");
            Console.WriteLine($"descrizione della {Prodottodettagliato.nome} {Prodottodettagliato.description}");
            Console.WriteLine($"il prezzo e di {Prodottodettagliato.prezzo}");
            Console.WriteLine($"il prezzo con iva e di {Prodottodettagliato.PrezzoPIuIva()}");


        }



    }
}

