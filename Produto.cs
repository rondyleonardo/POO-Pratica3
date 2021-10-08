using System;
using System.Globalization;

namespace OO_Exercicio3
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return( Preco * Quantidade);      
        }

        public void AdicionaProduto(int quantidade)
        {
           Quantidade  = Quantidade + quantidade;      

        }

        public void RetiraProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }


        public override string ToString()
        {
            return Nome + ", $ " +Preco.ToString("F2", CultureInfo.InvariantCulture) +", " 
            + Quantidade +" unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture) ; 
        }


        
    }
}