using System;
using System.Collections.Generic;

class Album
{
  public string Title { get; set; }
  public List<Song> Songs = new List<Song>();

  public Album(string ntitle)
  {
    Title = ntitle;
  }

  public void AddSong(Song nsong)
  {
    Songs.Add(nsong);
    Console.WriteLine("Song titled " + nsong.Title + " has been added to the Album " + Title);
  }

  public void RemoveSong(int sId)
  {
    Song nsong = Songs.Find(b => b.Id == sId);
    Songs.Remove(nsong);
    Console.WriteLine("The song titled " + nsong.Title + " removed from list");
  }

  public void DisplaySongs()
  {
    Console.WriteLine("Here are the songs in album " + Title + ":");
    foreach (Song s in Songs)
    {
      Console.WriteLine(s.Title);
    }
  }
}