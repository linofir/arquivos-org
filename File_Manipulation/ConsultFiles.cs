namespace arquivos_org.File_Manipulation;

class ConsultFiles
{
    public static void GetFileInfo()
    {
        var  downloadsPath = "C:/Users/lino/Downloads/";

        if(Directory.Exists(downloadsPath))
        {
            string[] files = Directory.GetFiles(downloadsPath);
            List<string> extentionList = new();

            Console.WriteLine($"Essa pasta foi encontrada, possui {files.Length} files");
            foreach( var file in files)
            {
                //Console.WriteLine("files loop");
                if(Path.HasExtension(file))
                {
                    var extention = Path.GetExtension(file);
                    var extentionPure = extention.Split('.');
                    if(!extentionList.Contains(extentionPure[1].ToLower()))
                    {
                        extentionList.Add(extentionPure[1]);
                    }
                    int counter = 0;
                    foreach (var item in extentionList)
                    {
                        counter +=1;
                        Console.WriteLine($"{counter}: {item}");
                    }
                    Console.WriteLine(extentionList.Count);
                    

                }else Console.WriteLine(file);
            }
        }
    }
    
}