
namespace classeProduto {

public enum tipoRoupa {
    Camiseta = 1,
    Sapato = 2,
    Calca  = 3,
    Chapeu = 4
}
    public abstract class Produto {

        public string Desc { get; set; }
        public decimal Preco { get; set; }
        public string Cor { get; set; }
        public int Id { get; set; }
        public tipoRoupa Tipo {get; set; }

        public Produto(string desc, decimal preco, string cor, int id, tipoRoupa tipo) {
            Desc = desc;
            Preco = preco;
            Cor= cor;
            Tipo = tipo;
            Id = id;
        }

        public virtual string Descricao() {
            return "|  Descrição: " + Desc + "|  R$: " + Preco + "|  Tipo: " + Tipo + "|  ID: " + Id;  
        }

    }

    public class Promocao {
        public decimal Desconto { get; set; } = 32;
        

        public decimal valorDesconto(decimal desconto) {
            decimal Desconto = 40;
            return Desconto;
        }

        public string Descricao() {
            return "Desconto de" + Desconto + "% aplicado";
        }
    }


    public class Camiseta : Produto {
        public string Tamanho { get; set; }
        public Promocao Promocao {get; set; }

        public Camiseta(string desc, decimal preco, Promocao promocao, string cor, int id, string tamanho, tipoRoupa tipo) : base(desc, preco, cor, id, tipo) {
        Tamanho = tamanho;
        Promocao = promocao;
        }

        public override string Descricao()
        {
            return "|  Descrição: " + Desc + "|  R$: " + Preco + "|  Desconto: " + Promocao.Descricao() + "|  Tipo: " + Tipo + "|  ID: " + Id;
        }
    }


    public class Sapato : Produto {
        public int Tamanho { get; set; }

        public Sapato(string desc, decimal preco, int tamanho, string cor, int id, tipoRoupa tipo) : base(desc, preco, cor, id, tipo) {
        Tamanho = tamanho;
        }
    }


    public class Calca : Produto {
        public string Tamanho { get; set; }
        public string Tecido { get; set; }

        public Calca(string desc, decimal preco, string tamanho, string cor, int id, string tecido, tipoRoupa tipo) : base(desc, preco, cor, id, tipo) {
        Tamanho = tamanho;
        Tecido = tecido;
        }
    }

    public class Chapeu : Produto {
        public string Tamanho { get; set; }

        public Chapeu(string desc, decimal preco, string tamanho, string cor, int id, tipoRoupa tipo) : base(desc, preco, cor, id, tipo) {
        Tamanho = tamanho;
        }

    }


    public class Carrinho {
        public List<Produto> Itens { get; set; }

        public Carrinho() {
            Itens = new List<Produto>();
        }

    }

}
