using System.Text;
using Microsoft.VisualBasic;

namespace arquivos_org.File_Manipulation;

class CreateFile
{
    public static void NewFileStream()
    {
        var path = "C:/Users/lino/Projetos_Programação/arquivos-org/assats/novoArquivo.txt";

        using( var fileStream = new FileStream(path, FileMode.Create))
        {
            var textoTeste = "123, 1234, 1000.50, Nome Teste";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(textoTeste);

            fileStream.Write(bytes, 0, bytes.Length);
            Console.WriteLine("Arquivo Criado");

        }
    }

    public static void NewFile(string destinationPath)
    {
        var path = destinationPath;
        using( var fileStream = new FileStream(path, FileMode.Create))
        using( var creator = new StreamWriter(fileStream))
        {
            creator.Write("910, 8796, 2000,10, TEste 2");
            Console.WriteLine("Arquivo criado");
        }
    }

    public static void NewFileFlush(string destinationPath)
    {
        var path = destinationPath;
        using( var fileStream = new FileStream(path, FileMode.Create))
        using( var creator = new StreamWriter(fileStream))
        {
            for (int i = 0; i < 100000; i++)
            {
                creator.WriteLine($"Linha {i}");
                creator.Flush();
                Console.WriteLine($"A linha {i} foi escrita no arquivo");
                Console.ReadLine();
            }
        }
    }

    public static void NewFileBinary(string destinationPath)
    {
        var path = destinationPath;
        using( var fileStream = new FileStream(path, FileMode.Create))
        using( var creator = new BinaryWriter(fileStream))
        {
            long numero = 44545454545;
            creator.Write(false);
            creator.Write(33.33);
            creator.Write(numero);
            creator.Write("teste escrita");

            creator.Write(70.55);
        }

        Console.WriteLine(" Fim da aplicação");
        Console.ReadLine();

    }

    public static void UsarStreamDeEntrada(string file)
    {
        using (var fluxoDeEntrada = Console.OpenStandardInput())
        using (var fs = new FileStream(file, FileMode.Create))
        {
            var buffer = new byte[1024]; //1kb

            while(true)
            {
                var byteslidos = fluxoDeEntrada.Read(buffer, 0, 1024);

                fs.Write(buffer, 0, byteslidos);
                fs.Flush();

                Console.WriteLine($"Bytes lidos na console: {byteslidos}");
            }
        }
    }
}