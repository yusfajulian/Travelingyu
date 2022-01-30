using Microsoft.EntityFrameworkCore.Migrations;

namespace Travelingyu.Migrations
{
    public partial class Tiket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Bus",
                columns: table => new
                {
                    KodeBus = table.Column<string>(type: "varchar(767)", nullable: false),
                    NamaSup = table.Column<string>(type: "text", nullable: true),
                    Dari = table.Column<string>(type: "text", nullable: true),
                    Ke = table.Column<string>(type: "text", nullable: true),
                    tarif = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Bus", x => x.KodeBus);
                });

            migrationBuilder.CreateTable(
                name: "Tb_KelasKereta",
                columns: table => new
                {
                    NamaKelas = table.Column<string>(type: "varchar(767)", nullable: false),
                    Chathring = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Kursi = table.Column<int>(type: "int", nullable: false),
                    Harga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_KelasKereta", x => x.NamaKelas);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Kereta",
                columns: table => new
                {
                    IdKereta = table.Column<string>(type: "varchar(767)", nullable: false),
                    NamaKereta = table.Column<string>(type: "text", nullable: true),
                    Berangkat = table.Column<string>(type: "text", nullable: true),
                    Tiba = table.Column<string>(type: "text", nullable: true),
                    Dari = table.Column<string>(type: "text", nullable: true),
                    Ke = table.Column<string>(type: "text", nullable: true),
                    Harga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Kereta", x => x.IdKereta);
                });

            migrationBuilder.CreateTable(
                name: "Tb_TrBus",
                columns: table => new
                {
                    NoTransaksi = table.Column<string>(type: "varchar(767)", nullable: false),
                    KodeBus1 = table.Column<string>(type: "varchar(767)", nullable: true),
                    KodePelanggan1 = table.Column<string>(type: "varchar(767)", nullable: true),
                    Jumlah = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_TrBus", x => x.NoTransaksi);
                    table.ForeignKey(
                        name: "FK_Tb_TrBus_Tb_Bus_KodeBus1",
                        column: x => x.KodeBus1,
                        principalTable: "Tb_Bus",
                        principalColumn: "KodeBus",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_TrBus_Tb_Pelanggan_KodePelanggan1",
                        column: x => x.KodePelanggan1,
                        principalTable: "Tb_Pelanggan",
                        principalColumn: "KodePelanggan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_TiketKA",
                columns: table => new
                {
                    IdTiket = table.Column<string>(type: "varchar(767)", nullable: false),
                    KodeKodePelangganKodePelanggan = table.Column<string>(type: "varchar(767)", nullable: true),
                    IdIdKeretaIdKereta = table.Column<string>(type: "varchar(767)", nullable: true),
                    NamaKelas1 = table.Column<string>(type: "varchar(767)", nullable: true),
                    Jumlah = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_TiketKA", x => x.IdTiket);
                    table.ForeignKey(
                        name: "FK_Tb_TiketKA_Tb_KelasKereta_NamaKelas1",
                        column: x => x.NamaKelas1,
                        principalTable: "Tb_KelasKereta",
                        principalColumn: "NamaKelas",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_TiketKA_Tb_Kereta_IdIdKeretaIdKereta",
                        column: x => x.IdIdKeretaIdKereta,
                        principalTable: "Tb_Kereta",
                        principalColumn: "IdKereta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_TiketKA_Tb_Pelanggan_KodeKodePelangganKodePelanggan",
                        column: x => x.KodeKodePelangganKodePelanggan,
                        principalTable: "Tb_Pelanggan",
                        principalColumn: "KodePelanggan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TiketKA_IdIdKeretaIdKereta",
                table: "Tb_TiketKA",
                column: "IdIdKeretaIdKereta");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TiketKA_KodeKodePelangganKodePelanggan",
                table: "Tb_TiketKA",
                column: "KodeKodePelangganKodePelanggan");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TiketKA_NamaKelas1",
                table: "Tb_TiketKA",
                column: "NamaKelas1");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TrBus_KodeBus1",
                table: "Tb_TrBus",
                column: "KodeBus1");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_TrBus_KodePelanggan1",
                table: "Tb_TrBus",
                column: "KodePelanggan1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_TiketKA");

            migrationBuilder.DropTable(
                name: "Tb_TrBus");

            migrationBuilder.DropTable(
                name: "Tb_KelasKereta");

            migrationBuilder.DropTable(
                name: "Tb_Kereta");

            migrationBuilder.DropTable(
                name: "Tb_Bus");
        }
    }
}
