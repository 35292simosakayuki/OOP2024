using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    internal class Program {
        static void Main(string[] args) {

            var songs = new Song[] {
                new Song("Let it be","The Beatles",243),
                new Song("Let it be","The Beatles",243),
                new Song("Let it be","The Beatles",243),
                new Song("Let it be","The Beatles",243),
                new Song("Let it be","The Beatles",243),
            };
            PrintSongs(songs);

        }
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) { 
            Console.WriteLine(@"{0},{1},{2:m\:ss}", song.Title, song.ArtistName, TimeSpan.FromSeconds(song.lenth));
        }
    }
    }
}
