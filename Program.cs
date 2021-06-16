using System;

namespace CRUD.Produtos
{
    class Program
    {
        static ProductRepository repository = new ProductRepository();
        static void Main(string[] args)
        {
            string optionUser = OptionUser();

            while (optionUser.ToUpper() != "X")
            {
                switch (optionUser)
                {
                    case "1":
                        ListarProdutos();
                        break;
                    case "2":
                        InserirProduto();
                        break;
                    case "3":
                        AtualizarProduto();
                        break;
                    case "4":
                        ExcluirProduto();
                        break;
                    case "5":
                        VisualizarProduto();
                        break;
                    case "C":
                        Console.Clear();
                        break;  
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                optionUser = OptionUser();
            }
            Console.WriteLine("Fui! :)");
            
        }

        private static void ListarProdutos()
        {
            Console.WriteLine("Lista dos Produtos");

            var list = repository.List();

            if (list.Count == 0)
            {
                Console.WriteLine("Nenhum Produto Cadastrado Ainda.");
                return;
            }
            foreach (var products in list)
            {
                var excluido = products.showDeleted();
                if(!excluido){
                    Console.WriteLine("#ID {0}: - {1}", products.showId(), products.showName());
                }
            }
        }
        private static void InserirProduto()
        {
            Console.WriteLine("Inserir Novo Produto");
            Console.WriteLine("Nome do Produto");
            string insertName = Console.ReadLine();
            Console.WriteLine("Descreva o Produto");
            string insertDescription = Console.ReadLine();
            Console.WriteLine("Preço do Produto");
            float insertPrice = float.Parse(Console.ReadLine());

            Products newProducts = new Products(
                id: repository.NextId(),
                name: insertName,
                description: insertDescription,
                price: insertPrice);

            repository.Insert(newProducts);
        }

        private static void AtualizarProduto()
        {
            Console.WriteLine("Digite o id do Produto que Deseja atualizar: ");
            int idProducts = int.Parse(Console.ReadLine());
            Console.WriteLine("Atualizar Nome do Produto");
            string insertName = Console.ReadLine();
            Console.WriteLine("Atualizar a Descrição do produto do Produto");
            string insertDescription = Console.ReadLine();
            Console.WriteLine("Atualizar o Preço do Produto");
            float insertPrice = float.Parse(Console.ReadLine());

            Products updateProducts = new Products(
                id: idProducts,
                name: insertName,
                description: insertDescription,
                price: insertPrice);

            repository.Update(idProducts, updateProducts);

        }

        private static void ExcluirProduto()
        {
            Console.WriteLine("Digite o id do Produto que Deseja Deletar: ");
            int idProducts = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Deseja mesmo excluir o id:{0} ? (S/N)", idProducts);
            string confirm = Console.ReadLine();            

            if(confirm.ToUpper() == "S"){
                repository.Delete(idProducts);
                Console.WriteLine("Produto deletado com sucesso");
            }else{
                Console.WriteLine("Produto Não deletado");
            }
            
        }
        private static void VisualizarProduto()
        {
            Console.WriteLine("Digite o id do Produto que Deseja Visualizar: ");
            int idProducts = int.Parse(Console.ReadLine());

            var produto = repository.ReturnId(idProducts);

            Console.WriteLine(produto);
        }

        private static string OptionUser()
        {
            Console.WriteLine("_________");
            Console.WriteLine("Informe a Opção Desejada: ");

            Console.WriteLine("1 - Listar Produtos");
            Console.WriteLine("2 - Inserir Produto");
            Console.WriteLine("3 - Atualizar produto");
            Console.WriteLine("4 - Excluir Produto");
            Console.WriteLine("5 - Visualizar Produto");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string optionUser = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return optionUser;
        }
    }
}
