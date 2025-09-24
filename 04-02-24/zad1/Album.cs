using System;

public class Ablum
{
	public string author;
	public string name;
	public uint songs;
	public int year;
	public uint downloads;

	public Album(string author, string name, uint songs, int year, uint downloads)
	{
		this.author = author;
		this.name = name;
		this.songs = songs;
		this.year = year;
		this.downloads = downloads;
	}


}
