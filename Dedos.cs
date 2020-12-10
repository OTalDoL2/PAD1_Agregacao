using System;

namespace Atividade_PAD
{
    public class Dedos
    { 
        private bool dedom;
        private bool dedop;
        public Dedos() { }

        public Dedos(bool dedom, bool dedop)
        {
            this.dedom = dedom;
            this.dedop = dedop;
        }


        public void setDedom(bool dedom)
        {
            this.dedom = dedom;
        }
        public bool getDedom()
        {
            return dedom;
        }

        public void setDedop(bool dedop)
        {
            this.dedop = dedop;
        }
        public bool getDedop()
        {
            return dedop;
        }
    }
}
