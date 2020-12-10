using System;

namespace Atividade_PAD
{
    public class Boca
    {
        private String dentes;
        private String lingua;

        public Boca() { }

        public Boca(String dentes, String lingua)
        {
            this.dentes = dentes;
            this.lingua = lingua;
        }


        public void setDentes(String dentes)
        {
            this.dentes = dentes;
        }
        public string getDentes()
        {
            return dentes;
        }

        public void setLingua(String lingua)
        {
            this.lingua = lingua;
        }
        public string getLingua()
        {
            return lingua;
        }
    }
}