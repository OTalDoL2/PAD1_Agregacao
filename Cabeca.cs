using System;

namespace Atividade_PAD
{
    public class Cabeca 
    {
            private bool boca;
            private String olhos;
            private String cabelo;
            private String orelhas;

            public bool getBoca()
            {return boca;}

            public string getOlhos()
            {return olhos;}

            public string getCabelo()
            {return cabelo;}

            public string getOrelhas()
            {return orelhas;}

            public void setBoca(bool boca)
            { this.boca = boca; }

            public void setOlhos(String olhos) 
            { this.olhos = olhos; }

            public void setCabelo(String cabelo)
            { this.cabelo = cabelo; }

            public void setOrelhas(String orelhas)
            { this.orelhas = orelhas; }
        
        
        
    }
}