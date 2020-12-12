﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

#nullable disable

namespace ConsoleApp.Models
{
    public class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> entity)
        {
            entity.ToTable("Album");

            entity.HasComment("Album table");

            entity.HasIndex(e => e.ArtistId, "IFK_AlbumArtistId");

            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(160)
                .HasComment("Title of album");

            entity.HasOne(d => d.Artist)
                .WithMany(p => p.Albums)
                .HasForeignKey(d => d.ArtistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlbumArtistId");
        }
    }
}
