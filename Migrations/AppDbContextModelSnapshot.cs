﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travelingyu.Data;

namespace Travelingyu.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Travelingyu.Models.Bus", b =>
                {
                    b.Property<string>("KodeBus")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Dari")
                        .HasColumnType("text");

                    b.Property<string>("Ke")
                        .HasColumnType("text");

                    b.Property<string>("NamaSup")
                        .HasColumnType("text");

                    b.Property<string>("tarif")
                        .HasColumnType("text");

                    b.HasKey("KodeBus");

                    b.ToTable("Tb_Bus");
                });

            modelBuilder.Entity("Travelingyu.Models.KelasKereta", b =>
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

                    b.ToTable("Tb_KelasKereta");
                });

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

            modelBuilder.Entity("Travelingyu.Models.Kereta", b =>
                {
                    b.Property<string>("IdKereta")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Berangkat")
                        .HasColumnType("text");

                    b.Property<string>("Dari")
                        .HasColumnType("text");

                    b.Property<int>("Harga")
                        .HasColumnType("int");

                    b.Property<string>("Ke")
                        .HasColumnType("text");

                    b.Property<string>("NamaKereta")
                        .HasColumnType("text");

                    b.Property<string>("Tiba")
                        .HasColumnType("text");

                    b.HasKey("IdKereta");

                    b.ToTable("Tb_Kereta");
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

            modelBuilder.Entity("Travelingyu.Models.Tiket", b =>
                {
                    b.Property<string>("IdTiket")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("IdIdKeretaIdKereta")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("Jumlah")
                        .HasColumnType("int");

                    b.Property<string>("KodeKodePelangganKodePelanggan")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("NamaKelas1")
                        .HasColumnType("varchar(767)");

                    b.HasKey("IdTiket");

                    b.HasIndex("IdIdKeretaIdKereta");

                    b.HasIndex("KodeKodePelangganKodePelanggan");

                    b.HasIndex("NamaKelas1");

                    b.ToTable("Tb_TiketKA");
                });

            modelBuilder.Entity("Travelingyu.Models.TransaksiBus", b =>
                {
                    b.Property<string>("NoTransaksi")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("Jumlah")
                        .HasColumnType("int");

                    b.Property<string>("KodeBus1")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("KodePelanggan1")
                        .HasColumnType("varchar(767)");

                    b.HasKey("NoTransaksi");

                    b.HasIndex("KodeBus1");

                    b.HasIndex("KodePelanggan1");

                    b.ToTable("Tb_TrBus");
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

            modelBuilder.Entity("Travelingyu.Models.Tiket", b =>
                {
                    b.HasOne("Travelingyu.Models.Kereta", "IdIdKereta")
                        .WithMany()
                        .HasForeignKey("IdIdKeretaIdKereta");

                    b.HasOne("Travelingyu.Models.Pelanggan", "KodeKodePelanggan")
                        .WithMany()
                        .HasForeignKey("KodeKodePelangganKodePelanggan");

                    b.HasOne("Travelingyu.Models.KelasKereta", "NamaKelas")
                        .WithMany()
                        .HasForeignKey("NamaKelas1");

                    b.Navigation("IdIdKereta");

                    b.Navigation("KodeKodePelanggan");

                    b.Navigation("NamaKelas");
                });

            modelBuilder.Entity("Travelingyu.Models.TransaksiBus", b =>
                {
                    b.HasOne("Travelingyu.Models.Bus", "KodeBus")
                        .WithMany()
                        .HasForeignKey("KodeBus1");

                    b.HasOne("Travelingyu.Models.Pelanggan", "KodePelanggan")
                        .WithMany()
                        .HasForeignKey("KodePelanggan1");

                    b.Navigation("KodeBus");

                    b.Navigation("KodePelanggan");
                });
#pragma warning restore 612, 618
        }
    }
}
