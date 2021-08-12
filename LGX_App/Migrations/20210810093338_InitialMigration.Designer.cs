﻿// <auto-Generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using LGX.Data;

namespace LGX.Migrations
{
    [DbContext(typeof(LGXContext))]
    [Migration("20210810093338_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LGX.Models.RelayRack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Genre");

                    b.Property<decimal>("Comment");

                    b.Property<DateTime>("Isle");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("LGX.Models.Shelf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeviceType");

                    b.Property<int>("RelayRackId");

                    b.HasKey("Id");

                    b.HasIndex("RelayRackId");

                    b.ToTable("Shelf");
                });

            modelBuilder.Entity("LGX.Models.Shelf", b =>
                {
                    b.HasOne("LGX.Models.RelayRack", "Movie")
                        .WithMany()
                        .HasForeignKey("RelayRackId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
