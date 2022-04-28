using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAppuntamenti
{
    class Appuntamento
    {

        private string nomeAppuntamento;
        private string localitaAppuntamento;
        private DateTime dataOrarioAppuntamento;

        public Appuntamento(string nomeAppuntamento, string localitaAppuntamento, DateTime daraOrarioAppuntamento)
        {
            this.nomeAppuntamento = nomeAppuntamento;
            this.localitaAppuntamento = localitaAppuntamento;

            if (daraOrarioAppuntamento < DateTime.Now)
            {
                throw new InvalidDataException("La data inserita non è corretta essendo già passata");
            }
            else
            {
                this.dataOrarioAppuntamento = daraOrarioAppuntamento;
            }
        }


        public void InserisciUnaNuovaData(DateTime nuovaData)
        {
            if (nuovaData < DateTime.Now)
            {
                throw new InvalidDataException("La data inserita non è corretta essendo già passata");
            }
            else
            {
                this.dataOrarioAppuntamento = nuovaData;
            }
        }

        //GETTERS E SETTERS

        public string GetnomeAppuntamento()
        {
            return nomeAppuntamento;
        }

        public string GetLocalitaAppuntamento()
        {
            return localitaAppuntamento;
        }

        public void SetnomeAppuntamento(string nuovoNome)
        {
            nomeAppuntamento = nuovoNome;
        }

        public void SetlocalitaAppuntamento(string nuovaLocalita)
        {
            localitaAppuntamento = nuovaLocalita;
        }

        public override string ToString()
        {
            string datiAppuntamento = "------------ \n Appuntamento: " + nomeAppuntamento + "\n Presso: " + localitaAppuntamento + "\n In data: " + dataOrarioAppuntamento;
            return datiAppuntamento;
        }
    }
}
