﻿// <auto-generated />
using System;
using Login_Paging.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Login_Paging.Migrations
{
    [DbContext(typeof(MyDbcontext))]
    [Migration("20220612023013_T")]
    partial class T
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Login_Paging.Common.Identification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Identification");
                });

            modelBuilder.Entity("Login_Paging.Data.HangHoaVM", b =>
                {
                    b.HasBaseType("Login_Paging.Common.Identification");

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<string>("TenHangHoa")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.ToTable("HangHoaVM");
                });

            modelBuilder.Entity("Login_Paging.Data.NguoiDung", b =>
                {
                    b.HasBaseType("Login_Paging.Common.Identification");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.ToTable("NguoiDung");
                });

            modelBuilder.Entity("Login_Paging.Data.HangHoaVM", b =>
                {
                    b.HasOne("Login_Paging.Common.Identification", null)
                        .WithOne()
                        .HasForeignKey("Login_Paging.Data.HangHoaVM", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Login_Paging.Data.NguoiDung", b =>
                {
                    b.HasOne("Login_Paging.Common.Identification", null)
                        .WithOne()
                        .HasForeignKey("Login_Paging.Data.NguoiDung", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}