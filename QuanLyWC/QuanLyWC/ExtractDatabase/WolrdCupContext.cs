using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QuanLyWC.ExtractDatabase
{
    public partial class WolrdCupContext : DbContext
    {
        public WolrdCupContext()
        {
        }

        public WolrdCupContext(DbContextOptions<WolrdCupContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bxh> Bxhs { get; set; } = null!;
        public virtual DbSet<CauThu> CauThus { get; set; } = null!;
        public virtual DbSet<DoiBong> DoiBongs { get; set; } = null!;
        public virtual DbSet<Hlv> Hlvs { get; set; } = null!;
        public virtual DbSet<SanBong> SanBongs { get; set; } = null!;
        public virtual DbSet<ThiDau> ThiDaus { get; set; } = null!;
        public virtual DbSet<TranDau> TranDaus { get; set; } = null!;
        public virtual DbSet<VongDau> VongDaus { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=THY;Initial Catalog=WolrdCup;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bxh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BXH");

                entity.Property(e => e.Banthang)
                    .HasMaxLength(10)
                    .HasColumnName("banthang")
                    .IsFixedLength();

                entity.Property(e => e.Banthua)
                    .HasMaxLength(10)
                    .HasColumnName("banthua")
                    .IsFixedLength();

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(10)
                    .HasColumnName("ghichu")
                    .IsFixedLength();

                entity.Property(e => e.Hieuso)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MaDoi)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_doi")
                    .IsFixedLength();

                entity.Property(e => e.Sotranchoi)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Stt)
                    .HasMaxLength(10)
                    .HasColumnName("STT")
                    .IsFixedLength();

                entity.Property(e => e.Thedo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Thevang)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Tongdiem)
                    .HasMaxLength(10)
                    .HasColumnName("tongdiem")
                    .IsFixedLength();

                entity.Property(e => e.VongDau)
                    .HasMaxLength(10)
                    .HasColumnName("Vong_dau")
                    .IsFixedLength();
            });

            modelBuilder.Entity<CauThu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cau_thu");

                entity.Property(e => e.DoiBong)
                    .HasMaxLength(10)
                    .HasColumnName("Doi_bong")
                    .IsFixedLength();

                entity.Property(e => e.Hlv)
                    .HasMaxLength(10)
                    .HasColumnName("HLV")
                    .IsFixedLength();

                entity.Property(e => e.MaCauthu)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_cauthu")
                    .IsFixedLength();

                entity.Property(e => e.MaDoi)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_doi")
                    .IsFixedLength();

                entity.Property(e => e.NgaySinh)
                    .HasMaxLength(10)
                    .HasColumnName("Ngay_sinh")
                    .IsFixedLength();

                entity.Property(e => e.QuocTich)
                    .HasMaxLength(10)
                    .HasColumnName("Quoc tich")
                    .IsFixedLength();

                entity.Property(e => e.SoAo)
                    .HasMaxLength(10)
                    .HasColumnName("So_ao")
                    .IsFixedLength();

                entity.Property(e => e.TenCauthu)
                    .HasMaxLength(10)
                    .HasColumnName("Ten_cauthu")
                    .IsFixedLength();

                entity.Property(e => e.ViTri)
                    .HasMaxLength(10)
                    .HasColumnName("Vi_tri")
                    .IsFixedLength();
            });

            modelBuilder.Entity<DoiBong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Doi_bong");

                entity.Property(e => e.DoiTruong)
                    .HasMaxLength(10)
                    .HasColumnName("Doi_truong")
                    .IsFixedLength();

                entity.Property(e => e.Hlv)
                    .HasMaxLength(10)
                    .HasColumnName("HLV")
                    .IsFixedLength();

                entity.Property(e => e.MaDoi)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_doi")
                    .IsFixedLength();

                entity.Property(e => e.SoCauthu)
                    .HasMaxLength(10)
                    .HasColumnName("So_cauthu")
                    .IsFixedLength();

                entity.Property(e => e.TenDoi)
                    .HasMaxLength(10)
                    .HasColumnName("Ten_doi")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Hlv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HLV");

                entity.Property(e => e.MaHlv)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_HLV")
                    .IsFixedLength();

                entity.Property(e => e.NgaySinh)
                    .HasMaxLength(10)
                    .HasColumnName("Ngay_sinh")
                    .IsFixedLength();

                entity.Property(e => e.QuocTich)
                    .HasMaxLength(10)
                    .HasColumnName("Quoc_tich")
                    .IsFixedLength();

                entity.Property(e => e.TenHlv)
                    .HasMaxLength(10)
                    .HasColumnName("Ten_HLV")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SanBong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("San_bong");

                entity.Property(e => e.Dkvc)
                    .HasMaxLength(10)
                    .HasColumnName("DKVC")
                    .IsFixedLength();

                entity.Property(e => e.MaSanbong)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_sanbong")
                    .IsFixedLength();

                entity.Property(e => e.SoGhe)
                    .HasMaxLength(10)
                    .HasColumnName("So_ghe")
                    .IsFixedLength();

                entity.Property(e => e.TenSanbong)
                    .HasMaxLength(10)
                    .HasColumnName("Ten_Sanbong")
                    .IsFixedLength();

                entity.Property(e => e.ThanhPho)
                    .HasMaxLength(10)
                    .HasColumnName("Thanh_pho")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ThiDau>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Thi_dau");

                entity.Property(e => e.DaSan1)
                    .HasMaxLength(10)
                    .HasColumnName("Da_san1")
                    .IsFixedLength();

                entity.Property(e => e.DaSan2)
                    .HasMaxLength(10)
                    .HasColumnName("Da_san2")
                    .IsFixedLength();

                entity.Property(e => e.Gio)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MaDoi1)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_doi1")
                    .IsFixedLength();

                entity.Property(e => e.MaDoi2)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_doi2")
                    .IsFixedLength();

                entity.Property(e => e.MaSanbong)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_sanbong")
                    .IsFixedLength();

                entity.Property(e => e.MaTrandau)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_trandau")
                    .IsFixedLength();

                entity.Property(e => e.MaVongdau)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_vongdau")
                    .IsFixedLength();

                entity.Property(e => e.Ngay)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Trongtai)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Trongtaibien1)
                    .HasMaxLength(10)
                    .HasColumnName("Trongtaibien_1")
                    .IsFixedLength();

                entity.Property(e => e.Trongtaibien2)
                    .HasMaxLength(10)
                    .HasColumnName("Trongtaibien_2")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TranDau>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tran_dau");

                entity.Property(e => e.MaTrandau)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_trandau")
                    .IsFixedLength();

                entity.Property(e => e.Sotran)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VongDau>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Vong_dau");

                entity.Property(e => e.MaVongdau)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_vongdau")
                    .IsFixedLength();

                entity.Property(e => e.TenVongdau)
                    .HasMaxLength(10)
                    .HasColumnName("Ten_vongdau")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
