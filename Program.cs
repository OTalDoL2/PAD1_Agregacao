using System;

namespace Atividade_PAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Cabeca head = new Cabeca();
            Boca mouth = new Boca();
            Braco pulso = new Braco();
            Dedos ded = new Dedos();
            Perna perna = new Perna();


            Console.Write("Você tem Dentes? ");
            string dente = Console.ReadLine();
            mouth.setDentes(dente);

            Console.Write("\nVocê tem Línguas? ");
            string lingua = Console.ReadLine();
            mouth.setLingua(lingua);

            Console.Write("\nVocê tem olhos? ");
            string olho = Console.ReadLine();
            head.setOlhos(olho);

            Console.Write("\nVocê tem orelhas? ");
            string orelhas = Console.ReadLine();
            head.setOrelhas(orelhas);

            Console.Write("\nVocê tem cabelos? ");
            string cabelo = Console.ReadLine();
            head.setCabelo(cabelo);

            if(dente == "sim" && lingua == "sim" || dente == "Sim" && lingua == "Sim")
            { head.setBoca(true); }

            Console.Write("\nVocê tem mãos? ");
            string maos = Console.ReadLine();
            if(maos== "sim" || maos == "Sim"){ pulso.setMao(maos); ded.setDedom(true); }

            Console.Write("\nVocê tem pés? ");
            string pes = Console.ReadLine();
            if(pes== "sim" || pes == "Sim"){ perna.setPerna(pes); ded.setDedop(true); }

            Console.Clear();

            



        
        }
    }
}
