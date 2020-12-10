using System;

namespace Atividade_PAD
{
    public class Braco
    {
        private String mao;
        public Braco() { }

        public Braco(String mao)
        {
            this.mao = mao;
        }


        public void setMao(String mao)
        {
            this.mao = mao;
        }
        public string getMao()
        {
            return mao;
        }
   }
}