namespace arquivos_org.Info;

class BancoTeste
{
    public BancoTeste( int agencia, int conta, double saldo, string titular)
    {
        Agencia = agencia;
        Conta = conta;
        Saldo = saldo;
        Titular = titular;
    }
    public int Agencia { get; set; }
    public int Conta { get; set; }

    public double Saldo { get; set; }

    public string? Titular { get; set; }

    public string? Descricao { get => $"Titular: {Titular} \n Agencia: {Agencia} \n Conta: {Conta} \n Saldo {Saldo} ";}


}
