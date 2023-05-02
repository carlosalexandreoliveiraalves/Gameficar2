namespace conjuntoMenu {
    public static class menuOptions {
        public static void exibirMenu() {

            Console.WriteLine(" \n Escolha qual operação deseja efetuar: \n");
            
            Console.WriteLine("1 - Adicionar produto para venda. ");
            Console.WriteLine("2 - Visualizar lista de produtos disponíveis à venda.");
            Console.WriteLine("3 - Adicionar produto ao carrinho.");
            Console.WriteLine("4 - Visualizar produtos inseridos no carrinho."); 
            Console.WriteLine("5 - Remover produto do carrinho. ");
            Console.WriteLine("6 - Efeturar compra. ");
            Console.WriteLine("7 - Fechar programa. ");
        }
        
        public static void produtoVenda() {
            Console.WriteLine("\n Escolha qual tipo de produto você deseja adicionar: \n");
            
            Console.WriteLine("1 - Camiseta. ");
            Console.WriteLine("2 - Sapato. ");
            Console.WriteLine("3 - Calça. ");
            Console.WriteLine("4 - Chapéu. ");
            Console.WriteLine("5 - Voltar. ");
        }

        public static void visualProdutos() {
            Console.WriteLine(" \n Escolha quais produtos deseja ver: \n");
            
            Console.WriteLine("1 - Todos os produtos. ");
            Console.WriteLine("2 - Camiseta. ");
            Console.WriteLine("3 - Sapato. ");
            Console.WriteLine("4 - Calça. ");
            Console.WriteLine("5 - Chapéu. ");
            Console.WriteLine("6 - Voltar. ");
        }

        public static void carrinhoProdutos() {
            Console.WriteLine(" \n Escolha qual produto deseja adicionar ao carrinho: \n");
            
            Console.WriteLine("1 - Camiseta. ");
            Console.WriteLine("2 - Sapato. ");
            Console.WriteLine("3 - Calça. ");
            Console.WriteLine("4 - Chapéu. ");
            Console.WriteLine("5 - Voltar. ");
        }

        public static void carrinhoRemova() {
            Console.WriteLine(" \n Escolha qual produto deseja remover do carrinho: \n");
            
            Console.WriteLine("1 - Camiseta. ");
            Console.WriteLine("2 - Sapato. ");
            Console.WriteLine("3 - Calça. ");
            Console.WriteLine("4 - Chapéu. ");
            Console.WriteLine("5 - Voltar. ");
        }

    }
}