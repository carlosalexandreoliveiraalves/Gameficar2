// See https://aka.ms/new-console-template for more information

using System.IO;
using classeProduto;
using conjuntoMenu;

namespace gamificar2 {

    class Gamificar {
        static void Main() {

            //Declaração das listas
            List<Camiseta> listaCamiseta = new List<Camiseta>();
            List<Sapato> listaSapato = new List<Sapato>();
            List<Calca> listaCalca = new List<Calca>();
            List<Chapeu> listaChapeu = new List<Chapeu>();
            
            
            Carrinho carrinho = new Carrinho();

            

    int option = 0;

    while (option != 7) {

    menuOptions.exibirMenu(); //Chamda do Menu inicial.
    Console.WriteLine("Digite um valor: ");
    option = Convert.ToInt32(Console.ReadLine());

    //Switch para a escolha das ações principais
    switch (option) {

        case 1:
            int escolhaProduto = 0;

            while (escolhaProduto != 5) {
            
            menuOptions.produtoVenda(); //produtos que podem ser adicionados
            escolhaProduto = Convert.ToInt32(Console.ReadLine());
            
            //Switch para a escolha dos produtos a serem adicionados (ex: sapato, camiseta, chapeu e calça)
            switch (escolhaProduto) {
                        case 1:
                            Console.WriteLine("Informe a descrição do produto");
                            string descCamiseta = Console.ReadLine() ?? "Sem descricao";

                            Console.WriteLine("Informe o preço do produto");
                            decimal precoCamiseta = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Informe o desconto do produto em %");
                            decimal descontoCamiseta = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Informe a cor do produto");
                            string corCamiseta = Console.ReadLine() ?? "Sem descricao";

                            Console.WriteLine("Informe o ID do produto");
                            int idCamiseta = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe o tamanho do produto");
                            string tamanhoCamiseta = Console.ReadLine() ?? "Sem Info";

                            Camiseta produtoCamiseta = new Camiseta(descCamiseta, precoCamiseta, descontoCamiseta, corCamiseta, idCamiseta, tamanhoCamiseta, tipoRoupa.Camiseta);
                            listaCamiseta.Add(produtoCamiseta);

                        break;

                        case 2:
                            Console.WriteLine("Informe a descrição do produto");
                            string descSapato = Console.ReadLine() ?? "Sem descricao";

                            Console.WriteLine("Informe o preço do produto");
                            decimal precoSapato = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Informe o desconto do produto em %");
                            decimal descontoSapato = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Informe a cor do produto");
                            string corSapato = Console.ReadLine() ?? "Sem descricao";

                            Console.WriteLine("Informe o ID do produto");
                            int idSapato = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe o tamanho do produto");
                            int tamanhoSapato = Convert.ToInt32(Console.ReadLine());

                            Sapato produtoSapato = new Sapato(descSapato, precoSapato, descontoSapato, tamanhoSapato, corSapato, idSapato, tipoRoupa.Sapato);
                            listaSapato.Add(produtoSapato);

                        break;

                        case 3:
                            Console.WriteLine("Informe a descrição do produto");
                            string descCalca = Console.ReadLine() ?? "Sem descricao";

                            Console.WriteLine("Informe o preço do produto");
                            decimal precoCalca = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Informe o desconto do produto em %");
                            decimal descontoCalca = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Informe a cor do produto");
                            string corCalca = Console.ReadLine() ?? "Sem descricao";

                            Console.WriteLine("Informe o ID do produto");
                            int idCalca = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe o tecido do produto");
                            string tecidoCalca = Console.ReadLine() ?? "Sem descricao";

                            Console.WriteLine("Informe o tamanho do produto");
                            string tamanhoCalca = Console.ReadLine() ?? "Sem descricao";

                            Calca produtoCalca = new Calca(descCalca, precoCalca, descontoCalca, tamanhoCalca, corCalca, idCalca, tecidoCalca, tipoRoupa.Calca);
                            listaCalca.Add(produtoCalca);
                        break;

                        case 4:
                            Console.WriteLine("Informe a descrição do produto");
                            string descChapeu = Console.ReadLine() ?? "Sem descricao";

                            Console.WriteLine("Informe o preço do produto");
                            decimal precoChapeu = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Informe o desconto do produto em %");
                            decimal descontoChapeu = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Informe a cor do produto");
                            string corChapeu = Console.ReadLine() ?? "Sem descricao";

                            Console.WriteLine("Informe o ID do produto");
                            int idChapeu = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe o tamanho do produto");
                            string tamanhoChapeu = Console.ReadLine() ?? "Sem descricao";

                            Chapeu produtoChapeu = new Chapeu(descChapeu, precoChapeu, descontoChapeu, tamanhoChapeu, corChapeu, idChapeu, tipoRoupa.Calca);
                            listaChapeu.Add(produtoChapeu);
                        break;

                        case 5:
                            escolhaProduto = 5;
                        break;

                        default:
                            Console.WriteLine("Opção inválida - tente novamente");
                            escolhaProduto = 0;
                        break;
                    }
                }
        
        break;

        case 2:
            int escolhaVisual = 0;

            while (escolhaVisual != 6) {

            
            menuOptions.visualProdutos();
            escolhaVisual = Convert.ToInt32(Console.ReadLine());

            //Switch para visualizar os produtos que foram adicionados
            switch (escolhaVisual) {
                case 1:
                    Console.WriteLine("\n\nTodas as camisetas disponíveis: \n ");
                    foreach (Camiseta camiseta in listaCamiseta)
                    {
                        Console.WriteLine("Descrição: " + camiseta.Desc + " | Preço: " + camiseta.Preco + " | Cor: " + camiseta.Cor +  "| ID: " + camiseta.Id + "  | Tamanho: " + camiseta.Tamanho + "\n");
                    }

                    Console.WriteLine("\n\nTodos os sapatos disponíveis: \n");
                    foreach (Sapato sapato in listaSapato)
                    {
                        Console.WriteLine("Descrição: " + sapato.Desc + " | Preço: " + sapato.Preco + " | Cor: " + sapato.Cor + "| ID: " + sapato.Id + " | Tamanho: " + sapato.Tamanho + "\n");
                    }

                    Console.WriteLine("\n\nTodas as calças disponíveis: \n");
                    foreach (Calca calca in listaCalca)
                    {
                        Console.WriteLine("Descrição: " + calca.Desc + " | Preço: " + calca.Preco + " | Cor: " + calca.Cor + "| ID: " + calca.Id + " | Tamanho: " + calca.Tamanho + " | Tecido: " + calca.Tecido + "\n");
                    }

                    Console.WriteLine("\n\nTodos os chapéus disponíveis: \n");
                    foreach (Chapeu chapeu in listaChapeu)
                    {
                        Console.WriteLine("Descrição: " + chapeu.Desc + " | Preço: " + chapeu.Preco + " | Cor: " + chapeu.Cor + "| ID: " + chapeu.Id + " | Tamanho: " + chapeu.Tamanho + "\n");
                    }
                break;

                case 2:
                    Console.WriteLine("\n\nTodas as camisetas disponíveis: \n ");
                    foreach (Camiseta camiseta in listaCamiseta)
                    {
                        Console.WriteLine("Descrição: " + camiseta.Desc + " | Preço: " + camiseta.Preco + " | Cor: " + camiseta.Cor +  "| ID: " + camiseta.Id + "  | Tamanho: " + camiseta.Tamanho + "\n");
                    }
                break;

                case 3:
                    Console.WriteLine("\n\nTodos os sapatos disponíveis: \n");
                    foreach (Sapato sapato in listaSapato)
                    {
                        Console.WriteLine("Descrição: " + sapato.Desc + " | Preço: " + sapato.Preco + " | Cor: " + sapato.Cor + "| ID: " + sapato.Id + " | Tamanho: " + sapato.Tamanho + "\n");
                    }
                break;

                case 4:
                    Console.WriteLine("\n\nTodas as calças disponíveis: \n");
                    foreach (Calca calca in listaCalca)
                    {
                        Console.WriteLine("Descrição: " + calca.Desc + " | Preço: " + calca.Preco + " | Cor: " + calca.Cor + "| ID: " + calca.Id + " | Tamanho: " + calca.Tamanho + " | Tecido: " + calca.Tecido + "\n");
                    }
                break;

                case 5:
                    Console.WriteLine("\n\nTodos os chapéus disponíveis: \n");
                    foreach (Chapeu chapeu in listaChapeu)
                    {
                        Console.WriteLine("Descrição: " + chapeu.Desc + " | Preço: " + chapeu.Preco + " | Cor: " + chapeu.Cor + "| ID: " + chapeu.Id + " | Tamanho: " + chapeu.Tamanho + "\n");
                    }
                break;

                case 6:
                    escolhaVisual = 6;
                break;

                default:
                    Console.WriteLine("Opção inválida - tente novamente");
                break;
            }
            }
        break;

        case 3:
            int escolhaCarrinho = 0;

            while (escolhaCarrinho != 5) {

            
            menuOptions.carrinhoProdutos();
            escolhaCarrinho = Convert.ToInt32(Console.ReadLine());
            
            //Switch adcionar os produtos no carrinho
            switch (escolhaCarrinho) {

                case 1:
                    Console.WriteLine("\n\nTodas as camisetas disponíveis: \n ");
                    foreach (Camiseta camiseta in listaCamiseta)
                    {
                        Console.WriteLine("Descrição: " + camiseta.Desc + " | Preço: " + camiseta.Preco + " | Cor: " + camiseta.Cor +  "| ID: " + camiseta.Id + "  | Tamanho: " + camiseta.Tamanho + "\n");
                    }

                    Console.WriteLine("Qual item deseja adicionar? (Por ID)");
                    int itemId = Convert.ToInt32(Console.ReadLine());

                    foreach (Camiseta camiseta in listaCamiseta)
                    {
                        if (itemId == camiseta.Id) {
                            carrinho.Itens.Add(camiseta);
                            Console.WriteLine("Item adicionado");
                            break;
                        }
                    }
                    
                break;

                case 2:
                    Console.WriteLine("\n\nTodos os sapatos disponíveis: \n");
                    foreach (Sapato sapato in listaSapato)
                    {
                        Console.WriteLine("Descrição: " + sapato.Desc + " | Preço: " + sapato.Preco + " | Cor: " + sapato.Cor + "| ID: " + sapato.Id + " | Tamanho: " + sapato.Tamanho + "\n");
                    }

                    Console.WriteLine("Qual item deseja adicionar? (Por ID)");
                    itemId = Convert.ToInt32(Console.ReadLine());

                    foreach (Sapato sapato in listaSapato)
                    {
                        if (itemId == sapato.Id) {
                            carrinho.Itens.Add(sapato);
                            Console.WriteLine("Item adicionado");
                            break;
                        }
                    }

                break;

                case 3:
                    Console.WriteLine("\n\nTodas as calças disponíveis: \n");
                    foreach (Calca calca in listaCalca)
                    {
                        Console.WriteLine("Descrição: " + calca.Desc + " | Preço: " + calca.Preco + " | Cor: " + calca.Cor + "| ID: " + calca.Id + " | Tamanho: " + calca.Tamanho + " | Tecido: " + calca.Tecido + "\n");
                    }

                    Console.WriteLine("Qual item deseja adicionar? (Por ID)");
                    itemId = Convert.ToInt32(Console.ReadLine());
                    foreach (Calca calca in listaCalca)
                    {
                        if (itemId == calca.Id) {
                            carrinho.Itens.Add(calca);
                            Console.WriteLine("Item adicionado");
                            break;
                        }
                    }
                break;

                case 4:
                    Console.WriteLine("\n\nTodos os chapéus disponíveis: \n");
                    foreach (Chapeu chapeu in listaChapeu)
                    {
                        Console.WriteLine("Descrição: " + chapeu.Desc + " | Preço: " + chapeu.Preco + " | Cor: " + chapeu.Cor + "| ID: " + chapeu.Id + " | Tamanho: " + chapeu.Tamanho + "\n");
                    }

                    Console.WriteLine("Qual item deseja adicionar? (Por ID)");
                    itemId = Convert.ToInt32(Console.ReadLine());
                    foreach (Chapeu chapeu in listaChapeu)
                    {
                        if (itemId == chapeu.Id) {
                            carrinho.Itens.Add(chapeu);
                            Console.WriteLine("Item adicionado");
                            break;
                        }
                    }

                break;

                case 5:
                    escolhaCarrinho = 5;
                break;

                default:
                    Console.WriteLine("Opção inválida - tente novamente");
                break;
            }
            }
        break;

        case 4:
        decimal total = 0;
        Console.WriteLine("Todos os itens que estão no carrinho: \n");
        foreach (Produto itens in carrinho.Itens)
            {
                Console.WriteLine("Descrição: " + itens.Desc + " | Preço: " + itens.Preco + " | Cor: " + itens.Cor + "| ID: " + itens.Id + "\n");
                total = itens.Preco + total;
            }
        Console.WriteLine("Valor total no carrinho: " + total);
        break;

        case 5: 
        
        foreach (Produto itens in carrinho.Itens)
            {
            Console.WriteLine("Descrição: " + itens.Desc + " | Preço: " + itens.Preco + " | Cor: " + itens.Cor + "| ID: " + itens.Id + "\n");
            }

        Console.WriteLine("Qual item deseja remover? (Por ID)");
        int itemIdRemove = Convert.ToInt32(Console.ReadLine());

        foreach (Produto itens in carrinho.Itens)
            {
                if (itemIdRemove == itens.Id) {
                carrinho.Itens.Remove(itens);
                Console.WriteLine("Item removido");
                break;
                }
            }

        break;
        case 6:
        string arquivoTxt = "CompraFinalizada.txt";
        StreamWriter sw = new StreamWriter(arquivoTxt);

        sw.WriteLine("Compra finalizada!");
        sw.WriteLine("----------------------------------------------------");
        sw.WriteLine("Estes são os itens inclusos no carrinho:");
        sw.WriteLine("----------------------------------------------------");

        int totalFinal = 0;

        foreach (Produto itens in carrinho.Itens)
            {
                sw.WriteLine("Descrição: " + itens.Desc + " | Preço: " + itens.Preco + " | Cor: " + itens.Cor + "| ID: " + itens.Id);
                total = itens.Preco + totalFinal;
            }
        sw.WriteLine("\nValor total da compra: " + totalFinal + "\n");

        sw.WriteLine("----------------------------------------------------");
        sw.WriteLine("Obrigado pela preferência :D");
        sw.Close();

        break;


        case 7:
            Console.WriteLine("Encerrando o programa. ");
            option = 7; 
        break;

        default:
            Console.WriteLine("Opção invalída - tente novamente"); 
        break;
    }
}
        
        Console.WriteLine("Deu");
        } 
    }
}

