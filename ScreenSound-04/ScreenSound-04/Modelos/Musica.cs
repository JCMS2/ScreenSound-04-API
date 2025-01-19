using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScreenSound_04.Modelos
{
    internal  class Musica
    {
        
        [JsonPropertyName("song")]
        public string? Nome { get; set; }
        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
        
        [JsonPropertyName("key")]
        public int Tipo { get; set; }
        private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
        public string chave
        {
            get
            {
              return tonalidades[Tipo];
            }
        }

        public static void Exibir(List<Musica>musica)
        {
            foreach (var M in musica)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine($"Nome: {M.Nome}\nArtista: {M.Artista}\nDuração: {M.Duracao}\nGenero: {M.Genero}\nChave {M.Tipo}: {M.chave}");
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}
