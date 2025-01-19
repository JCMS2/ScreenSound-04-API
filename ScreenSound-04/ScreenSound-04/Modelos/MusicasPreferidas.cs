using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound_04.Modelos
{
    internal class MusicasPreferidas
    {
        public string? Nome { get; set; }
        public List<Musica> ListaDeMusicasFavoritas { get; }

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicasFavoritas= new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Musicas favoritas do {Nome}");
            foreach (var i in ListaDeMusicasFavoritas)
            {
                Console.WriteLine($"Musica: {i.Nome}, Artista: {i.Artista}");
            }
        }
        public void GerarArquivoJson()
        {
            Console.WriteLine();
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas=ListaDeMusicasFavoritas
            });
            string NomeDoArquivo = $"Musicas-favorita-{Nome}.json";

            File.WriteAllText(NomeDoArquivo,json);
            Console.WriteLine($"O arquivo Json foi criado com sucesso {Path.GetFullPath(NomeDoArquivo)}");
        }
    }
}


//[JsonPropertyName("song")]
//public string? Nome { get; set; }
//[JsonPropertyName("artist")]
//public string? Artista { get; set; }
//[JsonPropertyName("duration_ms")]
//public int Duracao { get; set; }
//[JsonPropertyName("genre")]
//public string? Genero { get; set; }


//public void ExibirDetalhesDaMusica()
//{
//    Console.WriteLine("------------------------");
//    Console.WriteLine($"Nome: {Nome}\nArtista: {Artista}\nDuração: {Duracao}\nGenero: {Genero}");
//    Console.WriteLine("------------------------");
//}
