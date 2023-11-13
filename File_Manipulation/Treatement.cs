namespace arquivos_org.File_Manipulation;
using arquivos_org.Info;


class Treatment
{
    public static BancoTeste GetInfo(string linha)
    {
        string[] infos = linha.Split(',');
        int agencia = int.Parse(infos[0]);
        int conta  = int.Parse(infos[1]);
        double saldo = double.Parse(infos[2]);
        string titular = infos[3];

        BancoTeste infoTreated = new(agencia, conta, saldo, titular);
        // foreach (var info in infos)
        // {
        //     Console.WriteLine(info, info.GetType());
        // }

        return infoTreated;
        
    }
}