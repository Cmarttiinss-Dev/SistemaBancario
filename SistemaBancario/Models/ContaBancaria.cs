namespace SistemaBancario.Models
{
    // Classe abstrata aplicando o pilar de abstração
    // Uma Classe abstrata não pode ser instanciada somente Herdada
    public abstract class ContaBancaria
    {
        // Pilar encapsulamento: campos privados protegidos por propriedades públicas
        private string _numeroConta;
        private decimal _saldo;
        
        // Propriedade pública numero conta
        public string NumeroConta
        {
            get => _numeroConta;
            protected set => _numeroConta = value;
        }
        // Propriedade pública saldo
        public decimal Saldo
        {
            get => _saldo;
            protected set => _saldo = value < 0 ? 0 : value;
        }

        public string NomeTitular { get; set; }

        public List<string> ExtratoTransacoes { get; set; } = new List<string>();

        // Construtor da classe base 
        protected ContaBancaria(string numeroConta, decimal saldoInicial, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldoInicial;
            ExtratoTransacoes.Add($"Conta criado com o saldo de R${saldoInicial:f2}");
        }

        // Método Virtual (Polimorfismo na classe filhas)
        public virtual void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                ExtratoTransacoes.Add($"Depósito: +R${valor:f2} | Saldo Atual: {Saldo:F2}")
            }
        }

        // Método abstrato: Obriga as classe filhas a implementarem sua 
        // Propria regra de saque

        public abstract bool Sacar(decimal valor);
            
    }
}
