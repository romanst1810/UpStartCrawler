using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebCrawler.Migrations
{
    public partial class CreateProductDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Price = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageList = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UrlContent",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    HtmlUrl = table.Column<string>(nullable: true),
                    WebhookUrl = table.Column<string>(nullable: true),
                    ResultHtml = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    QPath = table.Column<string>(nullable: true),
                    QMessage = table.Column<string>(nullable: true),
                    UrlContentStatus = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "UrlContent");
        }
    }
}
