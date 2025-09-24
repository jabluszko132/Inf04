using System;

public class Album
{
	public string artist;
	public string album;
	public uint songsNumber;
	public int year;
	public uint downloadNumber;

	public Album(string artist, string album, uint songsNumber, int year, uint downloadNumber)
	{
		this.artist = artist;
		this.album = album;
		this.songsNumber = songsNumber;
		this.year = year;
		this.downloadNumber = downloadNumber;
	}

	public static List<Album> ReadAll(string path)
	{
		List<Album> list = new List<Album>();
		string[] data = File.ReadAllLines(path);
        for (int i = 0; i < data.Length; i+=6)
        {
			list.Add(new Album(
					data[i],
					data[i + 1],
					uint.Parse(data[i + 2]),
					int.Parse(data[i + 3]),
					uint.Parse(data[i + 4])
					));
        }
		return list;
    }

	public override string ToString()
	{
		return $"{this.artist}\n{this.album}\n{this.songsNumber}\n{this.year}\n{this.downloadNumber}";
	}

	public static void LogList(List<Album> list)
	{
		foreach (var item in list)
		{
			Console.WriteLine($"\n{item.ToString()}\n");
		}
	}
}
