 using static System.Console;
 //path que irá ser monitorado 
 var path = @"C:\temp";
 using var fs = new FileSystemWatcher(path);

//o que queremos monitorar
 fs.Created += OnCreated;
 fs.Deleted += OnDeleted;
 fs.Renamed += OnRenamed;

//queremos disparar os eventos
fs.EnableRaisingEvents = true;

//Queremos monitorar os subdiretórios
fs.IncludeSubdirectories = true;


 WriteLine("Pressione ENTER para finalizar");
 ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    WriteLine($"Arquivo criado {e.Name}");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    WriteLine($"O Arquivo foi deletado {e.Name}");
}

void OnRenamed(object sender, RenamedEventArgs e)
{
    WriteLine($"O Arquivo renomeado {e.OldName}");
    WriteLine($"Para {e.Name}");
}