﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UsuariosApp.Infra.Data.Contexts;

#nullable disable

namespace UsuariosApp.Infra.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240906003556_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UsuariosApp.Domain.Models.Entities.Perfil", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NOME");

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("PERFIL", (string)null);
                });

            modelBuilder.Entity("UsuariosApp.Domain.Models.Entities.Usuario", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("NOME");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("SENHA");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("USUARIO", (string)null);
                });

            modelBuilder.Entity("UsuariosApp.Domain.Models.Entities.UsuarioPerfil", b =>
                {
                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("USUARIO_ID");

                    b.Property<Guid?>("PerfilId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PERFIL_ID");

                    b.HasKey("UsuarioId", "PerfilId");

                    b.HasIndex("PerfilId");

                    b.ToTable("USUARIO_PERFIL", (string)null);
                });

            modelBuilder.Entity("UsuariosApp.Domain.Models.Entities.UsuarioPerfil", b =>
                {
                    b.HasOne("UsuariosApp.Domain.Models.Entities.Perfil", "Perfil")
                        .WithMany("Usuarios")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("UsuariosApp.Domain.Models.Entities.Usuario", "Usuario")
                        .WithMany("Perfis")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Perfil");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("UsuariosApp.Domain.Models.Entities.Perfil", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("UsuariosApp.Domain.Models.Entities.Usuario", b =>
                {
                    b.Navigation("Perfis");
                });
#pragma warning restore 612, 618
        }
    }
}