using Microsoft.EntityFrameworkCore.Migrations;

namespace JaMoin.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Kommentar = table.Column<string>(nullable: true),
                    GesamtBetrag = table.Column<double>(nullable: false),
                    GeldgeberEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SchuldenModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Betrag = table.Column<double>(nullable: false),
                    SchuldnerEmail = table.Column<string>(nullable: true),
                    TransactionModelId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchuldenModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchuldenModel_Transactions_TransactionModelId",
                        column: x => x.TransactionModelId,
                        principalTable: "Transactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SchuldenModel_TransactionModelId",
                table: "SchuldenModel",
                column: "TransactionModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchuldenModel");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
