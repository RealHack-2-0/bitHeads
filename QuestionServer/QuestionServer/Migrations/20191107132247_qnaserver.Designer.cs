﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductAPI.Models.Context;

namespace QuestionServer.Migrations
{
    [DbContext(typeof(APIContext))]
    [Migration("20191107132247_qnaserver")]
    partial class qnaserver
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuestionServer.Models.EntityModels.Answer", b =>
                {
                    b.Property<Guid>("AnswerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<Guid>("CreatedUserID");

                    b.Property<int>("DownvoteCount");

                    b.Property<Guid>("QuestionId");

                    b.Property<int>("UpvoteCount");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("QuestionServer.Models.EntityModels.Question", b =>
                {
                    b.Property<Guid>("QuestionId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AcceptedAnswerId");

                    b.Property<Guid?>("AnswerId");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<Guid>("CreatedUserID");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("isAnswered");

                    b.HasKey("QuestionId");

                    b.HasIndex("AnswerId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("QuestionServer.Models.EntityModels.Answer", b =>
                {
                    b.HasOne("QuestionServer.Models.EntityModels.Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuestionServer.Models.EntityModels.Question", b =>
                {
                    b.HasOne("QuestionServer.Models.EntityModels.Answer", "AcceptedAnswer")
                        .WithMany()
                        .HasForeignKey("AnswerId");
                });
#pragma warning restore 612, 618
        }
    }
}