﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System_WebAPI.Data;

#nullable disable

namespace System_WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220604204832_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("System_WebAPI.Models.ItemAdicional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("ItemAdicional");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bacon",
                            Price = 2f
                        });
                });

            modelBuilder.Entity("System_WebAPI.Models.ItemCardapio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Desc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("ItemCardapio");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Burgers",
                            Desc = "Belíssima batata artesanal",
                            Name = "Batata Frita c/ cheddar",
                            Price = 30f
                        },
                        new
                        {
                            Id = 2,
                            Category = "Burgers",
                            Desc = "Belíssima batata artesanal",
                            Name = "Batata Frita",
                            Price = 25f
                        },
                        new
                        {
                            Id = 3,
                            Category = "Burgers",
                            Desc = "Belíssima batata artesanal",
                            Name = "Batata Frita c/ Bacon",
                            Price = 33f
                        },
                        new
                        {
                            Id = 4,
                            Category = "Burgers",
                            Desc = "Hamburguer 200g, artesanal",
                            Name = "Chicken Bacon",
                            Price = 50f
                        },
                        new
                        {
                            Id = 5,
                            Category = "Burgers",
                            Desc = "Hamburguer 200g, artesanal",
                            Name = "Tideco",
                            Price = 10f
                        },
                        new
                        {
                            Id = 6,
                            Category = "Burgers",
                            Desc = "Hamburguer 200g c/ queijo, artesanal",
                            Name = "Queijones",
                            Price = 14f
                        },
                        new
                        {
                            Id = 7,
                            Category = "Pizzas",
                            Desc = "Pizza show de bola",
                            Name = "ItemCardapioA",
                            Price = 10f
                        },
                        new
                        {
                            Id = 8,
                            Category = "Pizzas",
                            Desc = "Pizza de bacon",
                            Name = "ItemCardapioB",
                            Price = 20f
                        },
                        new
                        {
                            Id = 9,
                            Category = "Pizzas",
                            Desc = "Pizza de calabresa",
                            Name = "ItemCardapioC",
                            Price = 20f
                        },
                        new
                        {
                            Id = 10,
                            Category = "Pizzas",
                            Desc = "frango",
                            Name = "ItemCardapioD",
                            Price = 20f
                        },
                        new
                        {
                            Id = 11,
                            Category = "Bebidas",
                            Desc = "",
                            Name = "Agua c/gás",
                            Price = 3f
                        },
                        new
                        {
                            Id = 12,
                            Category = "Bebidas",
                            Desc = "",
                            Name = "Agua Mineral",
                            Price = 5f
                        },
                        new
                        {
                            Id = 13,
                            Category = "Bebidas",
                            Desc = "",
                            Name = "Agua s/gás",
                            Price = 2f
                        },
                        new
                        {
                            Id = 14,
                            Category = "Bebidas",
                            Desc = "",
                            Name = "Agua Desmineralizada",
                            Price = 6f
                        });
                });

            modelBuilder.Entity("System_WebAPI.Models.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Observation")
                        .HasColumnType("TEXT");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("ItemPedido");
                });

            modelBuilder.Entity("System_WebAPI.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Qtd")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UndMed")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Batata",
                            Qtd = 10,
                            UndMed = "Kg"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Alface",
                            Qtd = 9,
                            UndMed = "Kg"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cenoura",
                            Qtd = 8,
                            UndMed = "Kg"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tomate",
                            Qtd = 17,
                            UndMed = "Kg"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Pepino",
                            Qtd = 10,
                            UndMed = "Kg"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Feijão",
                            Qtd = 11,
                            UndMed = "Kg"
                        },
                        new
                        {
                            Id = 7,
                            Name = "ProdutoA",
                            Qtd = 11,
                            UndMed = "Und"
                        },
                        new
                        {
                            Id = 8,
                            Name = "ProdutoB",
                            Qtd = 13,
                            UndMed = "Und"
                        },
                        new
                        {
                            Id = 9,
                            Name = "ProdutoC",
                            Qtd = 11,
                            UndMed = "Und"
                        },
                        new
                        {
                            Id = 10,
                            Name = "ProdutoD",
                            Qtd = 41,
                            UndMed = "Und"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Agua c/gás",
                            Qtd = 61,
                            UndMed = "Litros"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Agua Mineral",
                            Qtd = 16,
                            UndMed = "Litros"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Agua s/gás",
                            Qtd = 13,
                            UndMed = "Litros"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Agua Desmineralizada",
                            Qtd = 14,
                            UndMed = "Litros"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}