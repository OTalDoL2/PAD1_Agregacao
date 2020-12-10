using System;

namespace Atividade_PAD
{
    public class Dedos
    { 
        private bool dedosDaMao;
        private bool dedosDoPe;
        public Dedos() { }

        public Dedos(bool dedosDaMao, bool dedosDoPe)
        {
            this.dedosDaMao = dedosDaMao;
            this.dedosDoPe = dedosDoPe;
        }


        public void setdedosDaMao(bool dedosDaMao)
        {
            this.dedosDaMao = dedosDaMao;
        }
        public bool getdedosDaMao()
        {
            return dedosDaMao;
        }

        public void setdedosDoPe(bool dedosDoPe)
        {
            this.dedosDoPe = dedosDoPe;
        }
        public bool getdedosDoPe()
        {
            return dedosDoPe;
        }
    }
}
