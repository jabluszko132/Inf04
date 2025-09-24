string? path;

do{
    path = Console.ReadLine();
}while(path is null);

List<Album> albums = Album.ReadAll(path);
Album.LogList(albums);