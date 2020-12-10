using System;

namespace Atividade_PAD
{
    public class Corpo 
    {
        private bool cabeca;
        private bool braco;
        private bool perna;

        public Corpo() { }

        public Corpo(bool cabeca, bool braco, bool perna)
        {
            this.cabeca = cabeca;
            this.braco = braco;
            this.perna = perna;
        }

        public bool getCabeca()
        {
            return cabeca;
        }

        public bool getBraco()
        {
            return braco;
        }

        public bool getPerna()
        {
            return perna;
        }

        public void setCabeca(bool cabeca)
        {    
            this.cabeca = cabeca;
        }

        public void setBraco(bool braco) {
            this.braco = braco;
        }

        public void setPerna(bool perna)
        {    
            this.perna = perna;
        }
        
    }
}