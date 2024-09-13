using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apiserie.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "Ano", "Foto", "Genero", "Nome", "Plataforma", "Sinopse" },
                values: new object[] { 1, 2005, "https://br.web.img3.acsta.net/pictures/210/609/21060989_20131126123652773.jpg", "Sitcom", "How I Met Your Mother", "Disney", "Ted se apaixonou. Tudo começou quando seu melhor amigo, Marshall, soltou a bomba de que planejava pedir em casamento a namorada de longa data, Lily, uma professora de jardim de infância. Ted percebeu que era melhor se mexer se esperava encontrar o verdadeiro amor. Para ajudá-lo na missão está Barney, um amigo com opiniões sem fim -- e às vezes absurdas --, uma queda por ternos e uma fórmula infalível para conhecer garotas. Quando Ted conhece Robin, tem certeza que é amor à primeira vista, mas o relacionamento esfria e se transforma em uma amizade." });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "Ano", "Foto", "Genero", "Nome", "Plataforma", "Sinopse" },
                values: new object[] { 2, 2013, "https://m.media-amazon.com/images/M/MV5BNzVkYWY4NzYtMWFlZi00YzkwLThhZDItZjcxYTU4ZTMzMDZmXkEyXkFqcGdeQXVyODUxOTU0OTg@._V1_FMjpg_UX1000_.jpg", "Sitcom Policial", "Brooklyn nine-nine", "Netflix", "Jake Peralta é um detetive brilhante e ao mesmo tempo imaturo, que nunca precisou se preocupar em respeitar as regras. Tudo muda quando um capitão exigente assume o comando de seu esquadrão e Jake deve aprender a trabalhar em equipe." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
