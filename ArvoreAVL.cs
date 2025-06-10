using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace arvoreAVL
{
    public class ArvoreAVL
    {
        private No Raiz {  get; set; }

        public ArvoreAVL()
        {
            Raiz = null;
        }

        private int Altura(No no)
        {
            if(no == null)
            {
                return 0;
            }

            return no.altura;
        }

        public void Inserir(int valor)
        {
            Raiz = InserirRecursivo(Raiz, valor);
        }

        private No InserirRecursivo(No no, int valor)
        {
            if (no == null)
            {
                return new No(valor);
            }
            if (valor < no.valor) { 
                no.Esquerdo = InserirRecursivo(no.Esquerdo, valor);
            }
            else if(valor > no.valor){
                no.Direito = InserirRecursivo(no.Direito, valor);
            }
            else
            {
                return no;
            }

            no.altura = 1 + Math.Max(Altura(no.Esquerdo), Altura(no.Direito));

            int fb = FatorBalanceamento(no);

            //Conceito das rotações tirei desse arquivo enviado pelo professor "https://www.facom.ufu.br/~backes/gsi011/Aula11-ArvoreAVL.pdf"
            //Rotação LL
            if (fb > 1 && valor < no.Esquerdo.valor) {
                return RotacionarDireita(no);
            }

            //Rotação RR
            if (fb < -1 && valor > no.Direito.valor) { 
                return RotacionarEsquerda(no);
            }

            //Rotação LR
            if (fb > 1 && valor > no.Esquerdo.valor) {
                no.Esquerdo = RotacionarEsquerda(no.Esquerdo);
                return RotacionarDireita(no);
            }

            //Rotação RL
            if(fb < -1 && valor < no.Direito.valor)
            {
                no.Direito = RotacionarDireita(no.Direito);
                return RotacionarEsquerda(no);
            }

            return no;
        }

        private int FatorBalanceamento(No no)
        {
            if (no == null) 
            { 
                return 0; 
            }
            return Altura(no.Esquerdo) - Altura(no.Direito); 
        }

        private No RotacionarEsquerda(No x)
        {
            No y = x.Direito;
            No T2 = y.Esquerdo;

            y.Esquerdo = x;
            x.Direito = T2;

            x.altura = 1 + Math.Max(Altura(x.Esquerdo), Altura(x.Direito));
            y.altura = 1 + Math.Max(Altura(y.Esquerdo), Altura(y.Direito));

            return y;
        }
        private No RotacionarDireita(No y)
        {
            No x = y.Esquerdo;
            No T2 = x.Direito;

            x.Direito = y;
            y.Esquerdo = T2;

            y.altura = 1 + Math.Max(Altura(y.Esquerdo), Altura(y.Direito));
            x.altura = 1 + Math.Max(Altura(x.Esquerdo), Altura(x.Direito));

            return x;
        }


        public void Remover(int valor)
        {

        }

        public void Buscar(int valor)
        {
            
        }

        public void ImprimirPreOrdem()
        {
            PreOrdem(Raiz);
        }

        private void PreOrdem(No no)
        {
            if (no != null)
            {
                Console.Write(no.valor + " ");
                PreOrdem(no.Esquerdo);
                PreOrdem(no.Direito);
            }
        }
        public void ImprimirFatoresBalanceamento()
        {

        }

        public void ImprimirAltura()
        {

        }



    }
}
