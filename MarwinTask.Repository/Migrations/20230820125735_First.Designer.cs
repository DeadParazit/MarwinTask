﻿// <auto-generated />
using MarwinTask.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MarwinTask.Repository.Migrations
{
    [DbContext(typeof(MarwinDbContext))]
    [Migration("20230820125735_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MarwinTask.Core.Entities.Company", b =>
                {
                    b.Property<string>("Iin")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Iin");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("MarwinTask.Core.Entities.Employee", b =>
                {
                    b.Property<string>("Iin")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyIin")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Iin");

                    b.HasIndex("CompanyIin");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MarwinTask.Core.Entities.Employee", b =>
                {
                    b.HasOne("MarwinTask.Core.Entities.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyIin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("MarwinTask.Core.Entities.Company", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
