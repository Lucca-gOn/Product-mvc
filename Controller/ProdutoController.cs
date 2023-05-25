using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using produtos_mvc.Model;
using produtos_mvc.View;

namespace produtos_mvc.Controller
{
    public class ProdutoController
    {
        // INSTANCIAR OBJETO PRODUTO E PRODUTOVIEW
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        // METODO CONTROLADOR PARA ACESSAR A LISTAGEM DE PRODUTOS
        public void ListarProdutos()
        {
            // LISTA DE PRODUTOS CHAMADA PELA MODEL
            List<Produto> produtos = produto.Ler();

            // CHAMADA DO METODO DE EXIBIÇÃO(VIEW) RECEBENDO COMO ARGUMENTO A LISTA
            produtoView.Listar(produtos);
        }

        public void CadastrarProduto()
        {
            // CHAMADA PARA VIEW QUE RECEBE CADA OBJETO A SER INSERIDO NO CSV
            Produto novoProduto = produtoView.Cadastrar();

            // CHAMADA PARA A MODEL PARA A MODEL PARA INSERIR ESSE OBJETO NA 
            produto.Inserir(novoProduto);
        }
    }
}