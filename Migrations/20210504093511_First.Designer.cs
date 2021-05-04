﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ValueTypeExample.DataAccess;

namespace ValueTypeExample.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210504093511_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ValueTypeExample.Entities.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PnrNo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("ValueTypeExample.Entities.Ticket", b =>
                {
                    b.OwnsOne("ValueTypeExample.Entities.PnrDetail", "PnrDetail", b1 =>
                        {
                            b1.Property<Guid>("TicketId")
                                .HasColumnType("uuid");

                            b1.Property<string>("ArrivalCode")
                                .HasColumnType("text");

                            b1.Property<string>("ArrivalName")
                                .HasColumnType("text");

                            b1.Property<string>("DepartureCode")
                                .HasColumnType("text");

                            b1.Property<string>("DepartureName")
                                .HasColumnType("text");

                            b1.HasKey("TicketId");

                            b1.ToTable("Tickets");

                            b1.WithOwner()
                                .HasForeignKey("TicketId");
                        });

                    b.Navigation("PnrDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
