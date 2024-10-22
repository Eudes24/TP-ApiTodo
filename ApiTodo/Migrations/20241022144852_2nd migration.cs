using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTodo.Migrations
{
    /// <inheritdoc />
    public partial class _2ndmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgendaId",
                table: "Todos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AgendaId",
                table: "Todos",
                column: "AgendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Agenda_AgendaId",
                table: "Todos",
                column: "AgendaId",
                principalTable: "Agenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Agenda_AgendaId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AgendaId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "AgendaId",
                table: "Todos");
        }
    }
}
