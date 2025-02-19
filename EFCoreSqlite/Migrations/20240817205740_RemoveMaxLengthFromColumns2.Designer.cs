﻿// <auto-generated />
using System;
using Echoglossian.EFCoreSqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Echoglossian.EFCoreSqlite.Migrations
{
  [DbContext(typeof(EchoglossianDbContext))]
  [Migration("20240817205740_RemoveMaxLengthFromColumns2")]
  partial class RemoveMaxLengthFromColumns2
  {
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

      modelBuilder.Entity("Echoglossian.EFCoreSqlite.Models.BattleTalkMessage", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER");

            b.Property<DateTime>("CreatedDate")
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalBattleTalkMessage")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalBattleTalkMessageLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalSenderNameLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<byte[]>("RowVersion")
                      .IsConcurrencyToken()
                      .ValueGeneratedOnAddOrUpdate()
                      .HasColumnType("BLOB");

            b.Property<string>("SenderName")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("TranslatedBattleTalkMessage")
                      .HasColumnType("TEXT");

            b.Property<string>("TranslatedSenderName")
                      .HasColumnType("TEXT");

            b.Property<int>("TranslationEngine")
                      .HasColumnType("INTEGER");

            b.Property<string>("TranslationLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<DateTime?>("UpdatedDate")
                      .HasColumnType("TEXT");

            b.HasKey("Id");

            b.ToTable("battletalkmessages", (string)null);
          });

      modelBuilder.Entity("Echoglossian.EFCoreSqlite.Models.GameWindow", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER");

            b.Property<DateTime>("CreatedDate")
                      .HasColumnType("TEXT");

            b.Property<string>("GameVersion")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalWindowStrings")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalWindowStringsLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<byte[]>("RowVersion")
                      .IsConcurrencyToken()
                      .ValueGeneratedOnAddOrUpdate()
                      .HasColumnType("BLOB");

            b.Property<string>("TranslatedWindowStrings")
                      .HasColumnType("TEXT");

            b.Property<int>("TranslationEngine")
                      .HasColumnType("INTEGER");

            b.Property<string>("TranslationLang")
                      .HasColumnType("TEXT");

            b.Property<DateTime?>("UpdatedDate")
                      .HasColumnType("TEXT");

            b.Property<string>("WindowAddonName")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.HasKey("Id");

            b.ToTable("gamewindows", (string)null);
          });

      modelBuilder.Entity("Echoglossian.EFCoreSqlite.Models.Journal.QuestPlate", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER");

            b.Property<DateTime>("CreatedDate")
                      .HasColumnType("TEXT");

            b.Property<string>("ObjectivesAsText")
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalQuestMessage")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("QuestId")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("QuestName")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<byte[]>("RowVersion")
                      .IsConcurrencyToken()
                      .ValueGeneratedOnAddOrUpdate()
                      .HasColumnType("BLOB");

            b.Property<string>("SummariesAsText")
                      .HasColumnType("TEXT");

            b.Property<string>("TranslatedQuestMessage")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("TranslatedQuestName")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<int>("TranslationEngine")
                      .HasColumnType("INTEGER");

            b.Property<string>("TranslationLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<DateTime?>("UpdatedDate")
                      .HasColumnType("TEXT");

            b.HasKey("Id");

            b.ToTable("questplates", (string)null);
          });

      modelBuilder.Entity("Echoglossian.EFCoreSqlite.Models.LocationName", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER");

            b.Property<DateTime>("CreatedDate")
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalLocationName")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalLocationNameLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<byte[]>("RowVersion")
                      .IsConcurrencyToken()
                      .ValueGeneratedOnAddOrUpdate()
                      .HasColumnType("BLOB");

            b.Property<string>("TranslatedLocationName")
                      .HasColumnType("TEXT");

            b.Property<int>("TranslationEngine")
                      .HasColumnType("INTEGER");

            b.Property<string>("TranslationLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<DateTime?>("UpdatedDate")
                      .HasColumnType("TEXT");

            b.HasKey("Id");

            b.ToTable("locationnames", (string)null);
          });

      modelBuilder.Entity("Echoglossian.EFCoreSqlite.Models.NpcNames", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER");

            b.Property<DateTime>("CreatedDate")
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalNpcName")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalNpcNameLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<byte[]>("RowVersion")
                      .IsConcurrencyToken()
                      .ValueGeneratedOnAddOrUpdate()
                      .HasColumnType("BLOB");

            b.Property<string>("TranslatedNpcName")
                      .HasColumnType("TEXT");

            b.Property<int>("TranslationEngine")
                      .HasColumnType("INTEGER");

            b.Property<string>("TranslationLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<DateTime?>("UpdatedDate")
                      .HasColumnType("TEXT");

            b.HasKey("Id");

            b.ToTable("npcnames", (string)null);
          });

      modelBuilder.Entity("Echoglossian.EFCoreSqlite.Models.TalkMessage", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER");

            b.Property<DateTime>("CreatedDate")
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalSenderNameLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalTalkMessage")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalTalkMessageLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<byte[]>("RowVersion")
                      .IsConcurrencyToken()
                      .ValueGeneratedOnAddOrUpdate()
                      .HasColumnType("BLOB");

            b.Property<string>("SenderName")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("TranslatedSenderName")
                      .HasColumnType("TEXT");

            b.Property<string>("TranslatedTalkMessage")
                      .HasColumnType("TEXT");

            b.Property<int>("TranslationEngine")
                      .HasColumnType("INTEGER");

            b.Property<string>("TranslationLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<DateTime?>("UpdatedDate")
                      .HasColumnType("TEXT");

            b.HasKey("Id");

            b.ToTable("talkmessages", (string)null);
          });

      modelBuilder.Entity("Echoglossian.EFCoreSqlite.Models.TalkSubtitleMessage", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER");

            b.Property<DateTime>("CreatedDate")
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalTalkSubtitleMessage")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalTalkSubtitleMessageLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<byte[]>("RowVersion")
                      .IsConcurrencyToken()
                      .ValueGeneratedOnAddOrUpdate()
                      .HasColumnType("BLOB");

            b.Property<string>("TranslatedTalkSubtitleMessage")
                      .HasColumnType("TEXT");

            b.Property<int>("TranslationEngine")
                      .HasColumnType("INTEGER");

            b.Property<string>("TranslationLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<DateTime?>("UpdatedDate")
                      .HasColumnType("TEXT");

            b.HasKey("Id");

            b.ToTable("talksubtitlemessages", (string)null);
          });

      modelBuilder.Entity("Echoglossian.EFCoreSqlite.Models.ToastMessage", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER");

            b.Property<DateTime>("CreatedDate")
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("OriginalToastMessage")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<byte[]>("RowVersion")
                      .IsConcurrencyToken()
                      .ValueGeneratedOnAddOrUpdate()
                      .HasColumnType("BLOB");

            b.Property<string>("ToastType")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("TranslatedToastMessage")
                      .HasColumnType("TEXT");

            b.Property<int>("TranslationEngine")
                      .HasColumnType("INTEGER");

            b.Property<string>("TranslationLang")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<DateTime?>("UpdatedDate")
                      .HasColumnType("TEXT");

            b.HasKey("Id");

            b.ToTable("toastmessages", (string)null);
          });
#pragma warning restore 612, 618
    }
  }
}
