﻿// <auto-generated />
using System;
using Bookmaker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bookmaker.Migrations
{
    [DbContext(typeof(BookmakerContext))]
    partial class BookmakerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bookmaker.Data.Models.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int?>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Coaches");
                });

            modelBuilder.Entity("Bookmaker.Data.Models.Injury", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("PlayerId");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Injuries");
                });

            modelBuilder.Entity("Bookmaker.Data.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GuestId");

                    b.Property<int?>("GuestTeamId");

                    b.Property<int>("HostId");

                    b.Property<int?>("HostTeamId");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ResultId");

                    b.HasKey("Id");

                    b.HasIndex("GuestTeamId");

                    b.HasIndex("HostTeamId");

                    b.HasIndex("ResultId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Bookmaker.Data.Models.MatchTeam", b =>
                {
                    b.Property<int>("MatchId");

                    b.Property<int>("TeamId");

                    b.HasKey("MatchId", "TeamId");

                    b.HasIndex("TeamId");

                    b.ToTable("MatchTeam");
                });

            modelBuilder.Entity("Bookmaker.Data.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsOnSale");

                    b.Property<string>("Name");

                    b.Property<int?>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Bookmaker.Data.Models.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GuestGoals");

                    b.Property<int>("HostGoals");

                    b.HasKey("Id");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("Bookmaker.Data.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Budget");

                    b.Property<int>("Division");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Bookmaker.Data.Models.Coach", b =>
                {
                    b.HasOne("Bookmaker.Data.Models.Team", "Team")
                        .WithMany("Coaches")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Bookmaker.Data.Models.Injury", b =>
                {
                    b.HasOne("Bookmaker.Data.Models.Player")
                        .WithMany("Injuries")
                        .HasForeignKey("PlayerId");
                });

            modelBuilder.Entity("Bookmaker.Data.Models.Match", b =>
                {
                    b.HasOne("Bookmaker.Data.Models.Team", "GuestTeam")
                        .WithMany()
                        .HasForeignKey("GuestTeamId");

                    b.HasOne("Bookmaker.Data.Models.Team", "HostTeam")
                        .WithMany()
                        .HasForeignKey("HostTeamId");

                    b.HasOne("Bookmaker.Data.Models.Result", "Result")
                        .WithMany()
                        .HasForeignKey("ResultId");
                });

            modelBuilder.Entity("Bookmaker.Data.Models.MatchTeam", b =>
                {
                    b.HasOne("Bookmaker.Data.Models.Team", "Team")
                        .WithMany("MatchTeams")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bookmaker.Data.Models.Match", "Match")
                        .WithMany("MatchTeams")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bookmaker.Data.Models.Player", b =>
                {
                    b.HasOne("Bookmaker.Data.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId");
                });
#pragma warning restore 612, 618
        }
    }
}
