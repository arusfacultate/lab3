﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lab2_web_api.Models;

namespace lab2_web_api.Migrations
{
    [DbContext(typeof(TasksDbContext))]
    [Migration("20190519064305_dateTimeToNullableDateTime")]
    partial class dateTimeToNullableDateTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("lab2_web_api.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Important");

                    b.Property<int?>("TaskkId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("TaskkId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("lab2_web_api.Models.Taskk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Added");

                    b.Property<DateTime?>("ClosedAt");

                    b.Property<DateTime?>("Deadline");

                    b.Property<string>("Description");

                    b.Property<int>("Importance");

                    b.Property<int>("State");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("lab2_web_api.Models.Comment", b =>
                {
                    b.HasOne("lab2_web_api.Models.Taskk")
                        .WithMany("Comments")
                        .HasForeignKey("TaskkId");
                });
#pragma warning restore 612, 618
        }
    }
}
