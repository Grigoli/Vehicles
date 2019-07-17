﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using MitchellVehicleSolution.Models;
using System;

namespace MitchellVehicleSolution.Migrations
{
    [DbContext(typeof(MitchellContext))]
    [Migration("20180501081947_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("MitchellVehicleSolution.Models.Vehicle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.Property<int>("Year");

                    b.HasKey("ID");

                    b.ToTable("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}