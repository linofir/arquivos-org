using System.Security.Cryptography.X509Certificates;
using System.Text;
using arquivos_org.Info;

namespace arquivos_org.File_Manipulation;

class ReadFile
{

    public void OpenFileStream(string file)
    {
        var testFile = file;
        using(var fileStream = new FileStream(testFile, FileMode.Open))
        {
            var buffer = new byte[1024];

            var numeroBytesLidos = -1;

            while (numeroBytesLidos != 0)
            {
                numeroBytesLidos = fileStream.Read(buffer, 0, 1024);
                Console.WriteLine($"\nNúmero de bytes lidos: {numeroBytesLidos}\n");
                ExibirBuffer(buffer, numeroBytesLidos);
                
            }

            static void ExibirBuffer(byte[] buffer, int bytesLidos)
            {
                var utf8 = new UTF8Encoding();
                var text = utf8.GetString(buffer, 0, bytesLidos);
                Console.Write(text);
            
            }

            fileStream.Close();
            Console.ReadLine();

        }
    }

    public static void  OpenFile(string file, BancoTeste bancoTeste)
    {
       using( var fileStream = new FileStream(file, FileMode.Open))
{
        var leitor = new StreamReader(fileStream);

        Console.WriteLine("Leitura");
        //var textoInteiro = leitor.ReadToEnd();

        while(!leitor.EndOfStream)
        {
            var linha = leitor.ReadLine();
            BancoTeste NovaConta = Treatment.GetInfo(linha!);
            Console.WriteLine(NovaConta.Descricao);
        }


}
    

    }

    public static void ReadBinary(string file)
    {
        using(var fileStream = new FileStream(file, FileMode.Open))
        using(var reader = new BinaryReader(fileStream))
        {

            var condicional = reader.ReadBoolean();
            var inteiro = reader.ReadDouble();
            var longa =  reader.ReadInt64();
            var frase = reader.ReadString();


            Console.WriteLine($"condicional: {condicional}\n");
            Console.WriteLine($"inteiro: {inteiro}\n ");
            Console.WriteLine($"longa: { longa}\n");
            Console.WriteLine($"frase: {frase} ");

        }

    }
}