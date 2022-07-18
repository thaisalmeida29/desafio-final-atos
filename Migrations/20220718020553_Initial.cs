using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace desafio_final_atos.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemVenda",
                columns: table => new
                {
                    IdItemVenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    IdVenda = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    PrecoUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecoTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVenda", x => x.IdItemVenda);
                    table.ForeignKey(
                        name: "FK_ItemVenda_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemVenda_Venda_IdVenda",
                        column: x => x.IdVenda,
                        principalTable: "Venda",
                        principalColumn: "IdVenda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemVenda_IdProduto",
                table: "ItemVenda",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVenda_IdVenda",
                table: "ItemVenda",
                column: "IdVenda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemVenda");
        }
    }
}
