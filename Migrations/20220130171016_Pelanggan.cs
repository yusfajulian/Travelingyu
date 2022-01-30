using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Travelingyu.Migrations
{
    public partial class Pelanggan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Kelas",
                columns: table => new
                {
                    NamaKelas = table.Column<string>(type: "varchar(767)", nullable: false),
                    Chathring = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Kursi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Kelas", x => x.NamaKelas);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Pelanggan",
                columns: table => new
                {
                    KodePelanggan = table.Column<string>(type: "varchar(767)", nullable: false),
                    NamaPelanggan = table.Column<string>(type: "text", nullable: true),
                    JenisKelamin = table.Column<string>(type: "text", nullable: true),
                    DaerahAsal = table.Column<string>(type: "text", nullable: true),
                    NomorKtp = table.Column<string>(type: "text", nullable: true),
                    Propesi = table.Column<string>(type: "text", nullable: true),
                    NomorTelpon = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Pelanggan", x => x.KodePelanggan);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Pesawat",
                columns: table => new
                {
                    KodePesawat = table.Column<string>(type: "varchar(767)", nullable: false),
                    NamaMaskapai = table.Column<string>(type: "text", nullable: true),
                    JenisPesawat = table.Column<string>(type: "text", nullable: true),
                    WaktuKeberangkatan = table.Column<DateTime>(type: "datetime", nullable: false),
                    Tujuan = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Pesawat", x => x.KodePesawat);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Transaksi",
                columns: table => new
                {
                    KodeTiket = table.Column<string>(type: "varchar(767)", nullable: false),
                    KodePesawat = table.Column<string>(type: "varchar(767)", nullable: true),
                    KodePelanggan1 = table.Column<string>(type: "varchar(767)", nullable: true),
                    DaerahAsal = table.Column<string>(type: "text", nullable: true),
                    WaktuKeberangkatan = table.Column<DateTime>(type: "datetime", nullable: false),
                    Tujuan = table.Column<string>(type: "text", nullable: true),
                    NamaMaskapai = table.Column<string>(type: "text", nullable: true),
                    NamaKelas1 = table.Column<string>(type: "varchar(767)", nullable: true),
                    NamaPelanggan = table.Column<string>(type: "text", nullable: true),
                    NomorTelp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Transaksi", x => x.KodeTiket);
                    table.ForeignKey(
                        name: "FK_Tb_Transaksi_Tb_Kelas_NamaKelas1",
                        column: x => x.NamaKelas1,
                        principalTable: "Tb_Kelas",
                        principalColumn: "NamaKelas",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_Transaksi_Tb_Pelanggan_KodePelanggan1",
                        column: x => x.KodePelanggan1,
                        principalTable: "Tb_Pelanggan",
                        principalColumn: "KodePelanggan",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_Transaksi_Tb_Pesawat_KodePesawat",
                        column: x => x.KodePesawat,
                        principalTable: "Tb_Pesawat",
                        principalColumn: "KodePesawat",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Transaksi_KodePelanggan1",
                table: "Tb_Transaksi",
                column: "KodePelanggan1");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Transaksi_KodePesawat",
                table: "Tb_Transaksi",
                column: "KodePesawat");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Transaksi_NamaKelas1",
                table: "Tb_Transaksi",
                column: "NamaKelas1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Transaksi");

            migrationBuilder.DropTable(
                name: "Tb_Kelas");

            migrationBuilder.DropTable(
                name: "Tb_Pelanggan");

            migrationBuilder.DropTable(
                name: "Tb_Pesawat");
        }
    }
}
