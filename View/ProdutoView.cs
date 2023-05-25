using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using produtos_mvc.Model;

namespace produtos_mvc.View
{
    public class ProdutoView
    {
        // MÉTODO PARA EXIBIR OS PRODUTOS NA LSITA
        public void Listar(List<Produto> produto)
        {
            Console.Clear();
            // FOREACH PARA LER A LISTA PASSADA COMO PARAMETRO DO METODO

            foreach (var item in produto)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}");
                
            }
        }
        
        public Produto Cadastrar()
        {
        Produto novoProduto = new Produto();

        Console.WriteLine($"Codigo do produto:");
        novoProduto.Codigo = int.Parse(Console.ReadLine());

        Console.WriteLine($"Nome do produto:");
        novoProduto.Nome = Console.ReadLine();

        Console.WriteLine($"Preço do produto:");
        novoProduto.Preco = float.Parse(Console.ReadLine());
        
        return novoProduto;

        }
    }

    
}