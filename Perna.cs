using System;

namespace Atividade_PAD
{
    public class Perna
    {
        public Perna() { }
        private String pe;
        public Perna(String pe)
        {
            this.pe = pe;
        }


        public void setPerna(String pe)
        {
            this.pe = pe;
        }



        public string getPerna()
        {
            return pe;
        }
    }
}