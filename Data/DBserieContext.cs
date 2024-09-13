using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apiserie.Models;

namespace Apiserie.Data
{
    public class DBserieContext : DbContext
    {
        public DBserieContext (DbContextOptions<DBserieContext> options)
            : base(options)
        {
        }

        public DbSet<Apiserie.Models.serie> serie { get; set; } = default!;

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<serie>().HasData(
                new serie { Id = 1, Nome = "How I Met Your Mother", 
                    Genero = "Sitcom", 
                    Plataforma = "Disney", 
                    Ano = 2005, 
                    Sinopse= "Ted se apaixonou. Tudo começou quando seu melhor amigo, Marshall, soltou a bomba de que planejava pedir em casamento a namorada de longa data, Lily, uma professora de jardim de infância. Ted percebeu que era melhor se mexer se esperava encontrar o verdadeiro amor. Para ajudá-lo na missão está Barney, um amigo com opiniões sem fim -- e às vezes absurdas --, uma queda por ternos e uma fórmula infalível para conhecer garotas. Quando Ted conhece Robin, tem certeza que é amor à primeira vista, mas o relacionamento esfria e se transforma em uma amizade.", 
                    Foto= "https://br.web.img3.acsta.net/pictures/210/609/21060989_20131126123652773.jpg" },

                new serie
                {
                    Id = 2,
                    Nome = "Brooklyn nine-nine",
                    Genero = "Sitcom Policial",
                    Plataforma = "Netflix",
                    Ano = 2013,
                    Sinopse = "Jake Peralta é um detetive brilhante e ao mesmo tempo imaturo, que nunca precisou se preocupar em respeitar as regras. Tudo muda quando um capitão exigente assume o comando de seu esquadrão e Jake deve aprender a trabalhar em equipe.",
                    Foto = "https://m.media-amazon.com/images/M/MV5BNzVkYWY4NzYtMWFlZi00YzkwLThhZDItZjcxYTU4ZTMzMDZmXkEyXkFqcGdeQXVyODUxOTU0OTg@._V1_FMjpg_UX1000_.jpg" }
                );
        }
    }
}
