using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLab_DataAccess.Migrations
{
    public partial class ManyToManyFluentBooksAndFluentAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fluent_AuthorFluent_Book",
                columns: table => new
                {
                    Fluent_AuthorsAuthor_Id = table.Column<int>(type: "int", nullable: false),
                    Fluent_BooksBook_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_AuthorFluent_Book", x => new { x.Fluent_AuthorsAuthor_Id, x.Fluent_BooksBook_Id });
                    table.ForeignKey(
                        name: "FK_Fluent_AuthorFluent_Book_Fluent_Authors_Fluent_AuthorsAuthor_Id",
                        column: x => x.Fluent_AuthorsAuthor_Id,
                        principalTable: "Fluent_Authors",
                        principalColumn: "Author_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fluent_AuthorFluent_Book_Fluent_Books_Fluent_BooksBook_Id",
                        column: x => x.Fluent_BooksBook_Id,
                        principalTable: "Fluent_Books",
                        principalColumn: "Book_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_AuthorFluent_Book_Fluent_BooksBook_Id",
                table: "Fluent_AuthorFluent_Book",
                column: "Fluent_BooksBook_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fluent_AuthorFluent_Book");
        }
    }
}
