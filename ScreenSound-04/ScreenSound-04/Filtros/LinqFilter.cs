using ScreenSound_04.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_04.Filtros
{
    internal class LinqFilter
    {
        public static async void FiltrarTodosOsGenerosMusicais(List<Musica>musicas)
        {
            var TodosOsGenetosMusicais=musicas.Select(generos=>generos.Genero).Distinct().ToList();
            foreach (var g in TodosOsGenetosMusicais)
            {
                Console.WriteLine($"Generos: {g}");
            }
        }
        public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
        {
            var ArtistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine($"Artistas do Genero: {genero}");
            foreach (var g in ArtistasPorGeneroMusical)
            {
                Console.WriteLine($"Artistas: {g}");
            }
        }
        public static void FiltrarMusicasPorArtistas(List<Musica>musicas, string artista)
        {
            var MusicaPorArtista= musicas.Where(musica=>musica.Artista.Contains(artista)).Select(musica=>musica.Nome).Distinct().ToList();
            Console.WriteLine($"Exibindo Musica da Banda: {artista}");
            foreach (var a in MusicaPorArtista)
            {
                Console.WriteLine($"Musica: {a}");
            }
        }

        public static void FiltroPorTipo(List<Musica>ListaMusica,string chave)
        {
            var Escolha = ListaMusica.Where(musica => musica.chave == chave).OrderBy(musica => musica.Nome).Distinct().ToList();
            Console.WriteLine($"Musicas Do tipo {chave}");
            foreach (var i in Escolha)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine($"Nome: {i.Nome}\nArtista: {i.Artista}\nDuração: {i.Duracao}\nGenero: {i.Genero}\nChave {i.Tipo}: {i.chave}");
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}
