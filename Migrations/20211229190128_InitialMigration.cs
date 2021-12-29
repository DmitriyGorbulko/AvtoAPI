using Microsoft.EntityFrameworkCore.Migrations;

namespace AvtoAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "body_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_body_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "brand",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brand", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "color",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_color", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rudder",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rudder", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "brand_model",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brand_model", x => x.id);
                    table.ForeignKey(
                        name: "FK_brand_model_brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "brand",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "avto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number_avto = table.Column<int>(type: "int", nullable: false),
                    vin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brand_model_id = table.Column<int>(type: "int", nullable: false),
                    year = table.Column<int>(type: "int", nullable: false),
                    power = table.Column<int>(type: "int", nullable: false),
                    color_id = table.Column<int>(type: "int", nullable: false),
                    body_type_id = table.Column<int>(type: "int", nullable: false),
                    rudder_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_avto", x => x.id);
                    table.ForeignKey(
                        name: "FK_avto_body_type_body_type_id",
                        column: x => x.body_type_id,
                        principalTable: "body_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_avto_brand_model_brand_model_id",
                        column: x => x.brand_model_id,
                        principalTable: "brand_model",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_avto_color_color_id",
                        column: x => x.color_id,
                        principalTable: "color",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_avto_rudder_rudder_id",
                        column: x => x.rudder_id,
                        principalTable: "rudder",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "car_owner",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    person_id = table.Column<int>(type: "int", nullable: false),
                    avto_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car_owner", x => x.id);
                    table.ForeignKey(
                        name: "FK_car_owner_avto_avto_id",
                        column: x => x.avto_id,
                        principalTable: "avto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_avto_body_type_id",
                table: "avto",
                column: "body_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_avto_brand_model_id",
                table: "avto",
                column: "brand_model_id");

            migrationBuilder.CreateIndex(
                name: "IX_avto_color_id",
                table: "avto",
                column: "color_id");

            migrationBuilder.CreateIndex(
                name: "IX_avto_rudder_id",
                table: "avto",
                column: "rudder_id");

            migrationBuilder.CreateIndex(
                name: "IX_brand_model_BrandId",
                table: "brand_model",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_car_owner_avto_id",
                table: "car_owner",
                column: "avto_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "car_owner");

            migrationBuilder.DropTable(
                name: "avto");

            migrationBuilder.DropTable(
                name: "body_type");

            migrationBuilder.DropTable(
                name: "brand_model");

            migrationBuilder.DropTable(
                name: "color");

            migrationBuilder.DropTable(
                name: "rudder");

            migrationBuilder.DropTable(
                name: "brand");
        }
    }
}
