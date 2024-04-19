using csharp_oop_shop;

namespace csharp_oop_shop
{

    public class Prodotto
    {
        public int codice;
        public string nome { get; set; }
        public string description { get; set; }
        public double prezzo { get; set; }
        public int iva { get; set; }


        Prodotto(string name, string description, double prezzo, int iva)
        {
            codice = rnd.Next(10,100);

            Name = nome;
            Description = description;
            Prezzo = prezzo;
            Iva = iva;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //cosi aseggno i valori 
            Prodotto Prodottodettagliato = new Prodotto("nome prodotto " , "descrizione del prodotto " , 10.50 , 22);
        //1 creare la classe Prodotto che gestisce i prodotti dello shop /
        //2 Usate opportunamente i livelli di accesso (public, private /
        //3 lla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
        //4 Il codice prodotto sia accessibile solo in lettura /
        //5 Gli altri attributi siano accessibili sia in lettura che in scrittura /
        //6 Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
        //7 Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
        //8 Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interargirci per testare tutti i metodi che avete previsto.

    }
}
}
