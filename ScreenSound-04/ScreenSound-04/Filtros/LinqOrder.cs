using ScreenSound_04.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_04.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirOrden(List<Musica>musicas)
        {
            var orden = musicas.Select(musicas => musicas.Artista).Distinct().OrderBy(musicas=>musicas).ToList();
            foreach (var a in orden)
            {
                Console.WriteLine($"Artistas: {a}");
            }
        }
    }
}
