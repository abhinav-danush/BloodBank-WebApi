// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bloodbank23.data;

#nullable disable

namespace BloodBank1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220113112240_AddTablesToDatabase")]
    partial class AddTablesToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BloodBank1.model.BloodDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BloodId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BloodRecived")
                        .HasColumnType("datetime2");

                    b.Property<int>("HemoglobinId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastVaccination")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("OrgId")
                        .HasColumnType("int");

                    b.Property<bool>("isVaccinate")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("BloodDetails");
                });

            modelBuilder.Entity("bloodbank23.model.BloodName", b =>
                {
                    b.Property<int>("BloodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BloodId"), 1L, 1);

                    b.Property<string>("BType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BloodId");

                    b.ToTable("BloodNames");
                });

            modelBuilder.Entity("bloodbank23.model.KindOfOrg", b =>
                {
                    b.Property<int>("OrgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrgId"), 1L, 1);

                    b.Property<string>("OrgName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrgId");

                    b.ToTable("Kindoforgi");
                });

            modelBuilder.Entity("BlooodBank.model.Hemoglobin", b =>
                {
                    b.Property<int>("HemoglobinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HemoglobinId"), 1L, 1);

                    b.Property<string>("HemoglobinLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HemoglobinId");

                    b.ToTable("Hemoglobins");
                });
#pragma warning restore 612, 618
        }
    }
}
