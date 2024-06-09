class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Yeni mahnılar yaradırıq
        Song song1 = new Song("Imagine", "John Lennon", new TimeSpan(0, 3, 1), MusicGenre.Rock);
        Song song2 = new Song("Bohemian Rhapsody", "Queen", new TimeSpan(0, 5, 55), MusicGenre.Rock);
        Song song3 = new Song("My Favorite Things", "John Coltrane", new TimeSpan(0, 13, 41), MusicGenre.Jazz);
        Song song4 = new Song("Symphony No. 5", "Beethoven", new TimeSpan(0, 7, 0), MusicGenre.Classical);

        // Yeni bir playlist yaradırıq
        Playlist playlist = new Playlist();

        // Mahnıları playlistə əlavə edirik
        playlist.AddSong(song1);
        playlist.AddSong(song2);
        playlist.AddSong(song3);
        playlist.AddSong(song4);

        // Bütün mahnıları göstəririk
        List<Song> allSongs = playlist.GetAllSongsByGenre(MusicGenre.Rock);
        Console.WriteLine("Rock janrındakı bütün mahnılar:");
        foreach (Song song in allSongs)
        {
            Console.WriteLine($"Başlığı: {song.Title}, İfaçısı: {song.Artist}, Müddəti: {song.Duration}, Janrı: {song.Genre}");
        }
    }
}

public enum MusicGenre
{
    Pop,
    Rock,
    Jazz,
    Classical
}

public class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public TimeSpan Duration { get; set; }
    public MusicGenre Genre { get; set; }

    public Song(string title, string artist, TimeSpan duration, MusicGenre genre)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
        Genre = genre;
    }
}

public class Playlist
{
    private List<Song> songs = new List<Song>();

    public void AddSong(Song song)
    {
        songs.Add(song);
    }

    public List<Song> GetAllSongsByGenre(MusicGenre genre)
    {
        return songs.Where(s => s.Genre == genre).ToList();
    }
}
