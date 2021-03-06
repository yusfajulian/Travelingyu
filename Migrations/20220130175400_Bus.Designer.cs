// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travelingyu.Data;

namespace Travelingyu.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220130175400_Bus")]
    partial class Bus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Travelingyu.Models.KelasPenerbangan", b =>
                {
                    b.Property<string>("NamaKelas")
                        .HasColumnType("varchar(767)");

                    b.Property<bool>("Chathring")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Harga")
                        .HasColumnType("int");

                    b.Property<int>("Kursi")
                        .HasColumnType("int");

                    b.HasKey("NamaKelas");

                    b.ToTable("Tb_Kelas");
                });

            modelBuilder.Entity("Travelingyu.Models.Pelanggan", b =>
                {
                    b.Property<string>("KodePelanggan")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("DaerahAsal")
                        .HasColumnType("text");

                    b.Property<string>("JenisKelamin")
                        .HasColumnType("text");

                    b.Property<string>("NamaPelanggan")
                        .HasColumnType("text");

                    b.Property<string>("NomorKtp")
                        .HasColumnType("text");

                    b.Property<string>("NomorTelpon")
                        .HasColumnType("text");

                    b.Property<string>("Propesi")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("KodePelanggan");

                    b.ToTable("Tb_Pelanggan");
                });

            modelBuilder.Entity("Travelingyu.Models.Pemesanan", b =>
                {
                    b.Property<string>("KodeTiket")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("DaerahAsal")
                        .HasColumnType("text");

                    b.Property<string>("KodePelanggan1")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("KodePesawat")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("NamaKelas1")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("NamaMaskapai")
                        .HasColumnType("text");

                    b.Property<string>("NamaPelanggan")
                        .HasColumnType("text");

                    b.Property<string>("NomorTelp")
                        .HasColumnType("text");

                    b.Property<string>("Tujuan")
                        .HasColumnType("text");

                    b.Property<DateTime>("WaktuKeberangkatan")
                        .HasColumnType("datetime");

                    b.HasKey("KodeTiket");

                    b.HasIndex("KodePelanggan1");

                    b.HasIndex("KodePesawat");

                    b.HasIndex("NamaKelas1");

                    b.ToTable("Tb_Transaksi");
                });

            modelBuilder.Entity("Travelingyu.Models.Pesawat", b =>
                {
                    b.Property<string>("KodePesawat")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("JenisPesawat")
                        .HasColumnType("text");

                    b.Property<string>("NamaMaskapai")
                        .HasColumnType("text");

                    b.Property<string>("Tujuan")
                        .HasColumnType("text");

                    b.Property<DateTime>("WaktuKeberangkatan")
                        .HasColumnType("datetime");

                    b.HasKey("KodePesawat");

                    b.ToTable("Tb_Pesawat");
                });

            modelBuilder.Entity("Travelingyu.Models.Pemesanan", b =>
                {
                    b.HasOne("Travelingyu.Models.Pelanggan", "KodePelanggan")
                        .WithMany()
                        .HasForeignKey("KodePelanggan1");

                    b.HasOne("Travelingyu.Models.Pesawat", "kodePesawat")
                        .WithMany()
                        .HasForeignKey("KodePesawat");

                    b.HasOne("Travelingyu.Models.KelasPenerbangan", "NamaKelas")
                        .WithMany()
                        .HasForeignKey("NamaKelas1");

                    b.Navigation("KodePelanggan");

                    b.Navigation("kodePesawat");

                    b.Navigation("NamaKelas");
                });
#pragma warning restore 612, 618
        }
    }
}
