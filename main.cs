using System;

class Program {
  public static void Main (string[] args) {
    Album a1 = new Album("Test Album 1");
    
    Song s1 = new Song(12345, "Song 1");
    Song s2 = new Song(123456, "Song 2");
    Song s3 = new Song(1234567, "Song 3");

    a1.AddSong(s1);
    a1.AddSong(s2);
    a1.AddSong(s3);

    a1.DisplaySongs();
    a1.RemoveSong(123456);
    a1.DisplaySongs();

  }
}