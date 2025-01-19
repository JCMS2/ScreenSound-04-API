using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
   try
   {
string respota = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
var musicas = JsonSerializer.Deserialize<List<Musica>>(respota)!;
LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
LinqOrder.ExibirOrden(musicas);
LinqFilter.FiltrarArtistasPorGenero(musicas, "pop");
LinqFilter.FiltrarMusicasPorArtistas(musicas, "U2");

   var MusicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
   MusicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[0]);
   MusicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
   MusicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[2]);
   MusicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[3]);
   MusicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
   MusicasPreferidasDoDaniel.ExibirMusicasFavoritas();

   MusicasPreferidasDoDaniel.GerarArquivoJson();



}
catch (Exception ex)
{
   Console.WriteLine($"Temos um problema: {ex.Message}");
}
}

using (HttpClient Client = new HttpClient())
{
    try
    {
        string url = await Client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        List<Musica> ListaMusica = JsonSerializer.Deserialize<List<Musica>>(url);
        //Musica.Exibir(ListaMusica);
        LinqFilter.FiltroPorTipo(ListaMusica,"C#");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Finalizado");
    }
}
