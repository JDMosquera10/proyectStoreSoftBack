using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIBodega.Migrations
{
    /// <inheritdoc />
    public partial class CreateInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bdga",
                columns: table => new
                {
                    bo_cdgo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bo_dscrpcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bo_prpia = table.Column<int>(type: "int", nullable: false),
                    bo_plnta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bo_actva = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bdga", x => x.bo_cdgo);
                });

            migrationBuilder.CreateTable(
                name: "usrio_prmso",
                columns: table => new
                {
                    up_rowid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1000000000"),
                    up_adcnar = table.Column<int>(type: "int", nullable: false),
                    up_mdfcar = table.Column<int>(type: "int", nullable: false),
                    up_brrar = table.Column<int>(type: "int", nullable: false),
                    up_lstar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usrio_prmso", x => x.up_rowid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bdga");

            migrationBuilder.DropTable(
                name: "usrio_prmso");
        }
    }
}
