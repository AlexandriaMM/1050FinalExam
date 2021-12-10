using System;
using System.ComponentModel.DataAnnotations;

class Song
{
  [MaxLength(10)]
  public int Id { get; set; }
  public string Title { get; set; }
  public Artist ArtistInfo { get; set; }

  public Song()
  {
    Id = 0000000000;
    Title = "unknown";
  }

  public Song(int nId, string ntitle)
  {
    Id = nId;
    Title = ntitle;
    Console.WriteLine("Song " + Title + " has been added");
  }

  public void AddArtistInfo(Artist nartist)
  {
    ArtistInfo = nartist;
    Console.WriteLine("Artist " + ArtistInfo.FirstName + " " + ArtistInfo.LastName + " added to the song titled " + Title);
  }

  public void Display()
  {
    Console.WriteLine("Song info: " + Id + " " + Title + " by " + ArtistInfo.FirstName + " " + ArtistInfo.LastName);
  }

}