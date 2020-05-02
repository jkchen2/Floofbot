﻿// <auto-generated />
using System;
using Floofbot.Services.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Floofbot.Migrations
{
    [DbContext(typeof(FloofDataContext))]
    [Migration("20200502011652_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("Floofbot.Services.Repository.Models.AdminConfig", b =>
                {
                    b.Property<ulong>("ServerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("MuteRoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ServerId");

                    b.ToTable("AdminConfig");
                });

            modelBuilder.Entity("Floofbot.Services.Repository.Models.LogConfig", b =>
                {
                    b.Property<ulong>("ServerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsOn")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("MemberUpdatesChannel")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("MessageDeletedChannel")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("MessageUpdatedChannel")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UserBannedChannel")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UserJoinedChannel")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UserKickedChannel")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UserLeftChannel")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UserMutedChannel")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UserUnbannedChannel")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UserUnmutedChannel")
                        .HasColumnType("INTEGER");

                    b.HasKey("ServerId");

                    b.ToTable("LogConfigs");
                });

            modelBuilder.Entity("Floofbot.Services.Repository.Models.Tag", b =>
                {
                    b.Property<ulong>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Floofbot.Services.Repository.Models.Warning", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Forgiven")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("ForgivenBy")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("GuildId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("Moderator")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Reason")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Warnings");
                });
#pragma warning restore 612, 618
        }
    }
}
