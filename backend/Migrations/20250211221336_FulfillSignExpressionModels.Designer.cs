﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Signary.Infrastructure.Persistence;

#nullable disable

namespace Signary.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250211221336_FulfillSignExpressionModels")]
    partial class FulfillSignExpressionModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SignDefinitionTag", b =>
                {
                    b.Property<Guid>("SignDefinitionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uuid");

                    b.HasKey("SignDefinitionId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("SignDefinitionTags", (string)null);
                });

            modelBuilder.Entity("Signary.Domain.Entities.MouthingOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("SignDefinitionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SignDefinitionId");

                    b.ToTable("MouthingOptions");
                });

            modelBuilder.Entity("Signary.Domain.Entities.SignDefinition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("SignExpressionId")
                        .HasColumnType("uuid");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.HasKey("Id");

                    b.HasIndex("SignExpressionId");

                    b.ToTable("SignDefinitions");
                });

            modelBuilder.Entity("Signary.Domain.Entities.SignDefinitionReference", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("SourceDefinitionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TargetDefinitionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SourceDefinitionId");

                    b.HasIndex("TargetDefinitionId");

                    b.ToTable("SignDefinitionReferences");
                });

            modelBuilder.Entity("Signary.Domain.Entities.SignExpression", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SignExpressions");
                });

            modelBuilder.Entity("Signary.Domain.Entities.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("SignDefinitionTag", b =>
                {
                    b.HasOne("Signary.Domain.Entities.SignDefinition", null)
                        .WithMany()
                        .HasForeignKey("SignDefinitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Signary.Domain.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Signary.Domain.Entities.MouthingOption", b =>
                {
                    b.HasOne("Signary.Domain.Entities.SignDefinition", "SignDefinition")
                        .WithMany("Mouthings")
                        .HasForeignKey("SignDefinitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SignDefinition");
                });

            modelBuilder.Entity("Signary.Domain.Entities.SignDefinition", b =>
                {
                    b.HasOne("Signary.Domain.Entities.SignExpression", "SignExpression")
                        .WithMany("Definitions")
                        .HasForeignKey("SignExpressionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SignExpression");
                });

            modelBuilder.Entity("Signary.Domain.Entities.SignDefinitionReference", b =>
                {
                    b.HasOne("Signary.Domain.Entities.SignDefinition", "SourceDefinition")
                        .WithMany("SourceReferences")
                        .HasForeignKey("SourceDefinitionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Signary.Domain.Entities.SignDefinition", "TargetDefinition")
                        .WithMany("TargetReferences")
                        .HasForeignKey("TargetDefinitionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SourceDefinition");

                    b.Navigation("TargetDefinition");
                });

            modelBuilder.Entity("Signary.Domain.Entities.SignDefinition", b =>
                {
                    b.Navigation("Mouthings");

                    b.Navigation("SourceReferences");

                    b.Navigation("TargetReferences");
                });

            modelBuilder.Entity("Signary.Domain.Entities.SignExpression", b =>
                {
                    b.Navigation("Definitions");
                });
#pragma warning restore 612, 618
        }
    }
}
