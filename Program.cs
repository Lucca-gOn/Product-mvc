using produtos_mvc.Controller;
using produtos_mvc.Model;

// INSTANCIA DO OBJETO PRODUTO
Produto p = new Produto();

// INSTANCIA O OBJETO DO PRODUTOCONTROLLER
ProdutoController controller = new ProdutoController();

// CHAMADA DO METODO CADASTRAR
controller.CadastrarProduto();

// CHAMADA DO METODO CONTROLLER
controller.ListarProdutos();