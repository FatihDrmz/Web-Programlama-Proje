using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProje.Migrations
{
    public partial class localDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eposta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Yetki = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Hakkimizda",
                columns: table => new
                {
                    HakkimizdaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkimizda", x => x.HakkimizdaId);
                });

            migrationBuilder.CreateTable(
                name: "Hizmet",
                columns: table => new
                {
                    HizmetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResimURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hizmet", x => x.HizmetId);
                });

            migrationBuilder.CreateTable(
                name: "Iletisim",
                columns: table => new
                {
                    IletisimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adres = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Whatsapp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisim", x => x.IletisimId);
                });

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Kimlik",
                columns: table => new
                {
                    KimlikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    LogoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unvan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kimlik", x => x.KimlikId);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResimURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.BlogId);
                    table.ForeignKey(
                        name: "FK_Blog_Kategori_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategori",
                        principalColumn: "KategoriId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
               name: "Slider",
               columns: table => new
               {
                   SliderId = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   Baslik = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                   Aciklama = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                   ResimURL = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Slider", x => x.SliderId);
               });

            migrationBuilder.CreateIndex(
                name: "IX_Blog_KategoriId",
                table: "Blog",
                column: "KategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "Hakkimizda");

            migrationBuilder.DropTable(
                name: "Hizmet");

            migrationBuilder.DropTable(
                name: "Iletisim");

            migrationBuilder.DropTable(
                name: "Kimlik");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
               name: "Slider");
        }
    }
}
