using System;

class Program
{
    static void Main()
    {
        FluxoDataBase fluxoDB = new FluxoDataBase();

        // Exemplo de uso:
        Estoque produto = new Estoque
        {
            IdProduto = 1,
            NomeProduto = "ProdutoTeste",
            ValorProduto = 10.99m,
            QuantidadeProduto = 50
        };

        fluxoDB.SaidaProduto(produto);
    }
}

 











// instânciar class = Criar objeto
// Aluno -> class aluno1 -> objeto

