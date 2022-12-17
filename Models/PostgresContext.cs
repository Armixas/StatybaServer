using Microsoft.EntityFrameworkCore;

namespace StatybaServer.Models;

public partial class PostgresContext : DbContext
{
    public PostgresContext()
    {
    }

    public PostgresContext(DbContextOptions<PostgresContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Algospriedas> Algospriedas { get; set; }

    public virtual DbSet<Asmuo> Asmuos { get; set; }

    public virtual DbSet<Atsiemimas> Atsiemimas { get; set; }

    public virtual DbSet<Atsiskaitymas> Atsiskaitymas { get; set; }

    public virtual DbSet<Darbuotojas> Darbuotojas { get; set; }

    public virtual DbSet<Klientas> Klientas { get; set; }

    public virtual DbSet<Pareigos> Pareigos { get; set; }

    public virtual DbSet<Pastomatas> Pastomatas { get; set; }

    public virtual DbSet<Preke> Prekes { get; set; }

    public virtual DbSet<Priskiriama> Priskiriamas { get; set; }

    public virtual DbSet<Sandelis> Sandelis { get; set; }

    public virtual DbSet<Skyrius> Skyrius { get; set; }

    public virtual DbSet<Statusas> Statusas { get; set; }

    public virtual DbSet<Turi> Turis { get; set; }

    public virtual DbSet<Uzsakymas> Uzsakymas { get; set; }

    public virtual DbSet<Uzsakymopreke> Uzsakymoprekes { get; set; }

    public virtual DbSet<Zyma> Zymas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=jamalas");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresExtension("pg_catalog", "adminpack")
            .HasPostgresExtension("pgagent", "pgagent");

        modelBuilder.Entity<Algospriedas>(entity =>
        {
            entity.HasKey(e => e.IdAlgosPriedas).HasName("algospriedas_pkey");

            entity.ToTable("algospriedas");

            entity.Property(e => e.IdAlgosPriedas)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_algos_priedas");
            entity.Property(e => e.Aprasymas)
                .HasMaxLength(255)
                .HasColumnName("aprasymas");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Dydis).HasColumnName("dydis");
            entity.Property(e => e.FkDarbuotojasidDarbuotojas).HasColumnName("fk_darbuotojasid_darbuotojas");
            entity.Property(e => e.Pavadinimas)
                .HasMaxLength(255)
                .HasColumnName("pavadinimas");

            entity.HasOne(d => d.FkDarbuotojasidDarbuotojasNavigation).WithMany(p => p.Algospriedas)
                .HasForeignKey(d => d.FkDarbuotojasidDarbuotojas)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("gauna");
        });

        modelBuilder.Entity<Asmuo>(entity =>
        {
            entity.HasKey(e => e.IdAsmuo).HasName("asmuo_pkey");

            entity.ToTable("asmuo");

            entity.Property(e => e.IdAsmuo)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_asmuo");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Atsiemimas>(entity =>
        {
            entity.HasKey(e => e.IdAtsiemimas).HasName("atsiemimas_pkey");

            entity.ToTable("atsiemimas");

            entity.Property(e => e.IdAtsiemimas)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_atsiemimas");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Atsiskaitymas>(entity =>
        {
            entity.HasKey(e => e.IdAtsiskaitymas).HasName("atsiskaitymas_pkey");

            entity.ToTable("atsiskaitymas");

            entity.Property(e => e.IdAtsiskaitymas)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_atsiskaitymas");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Darbuotojas>(entity =>
        {
            entity.HasKey(e => e.IdDarbuotojas).HasName("darbuotojas_pkey");

            entity.ToTable("darbuotojas");

            entity.Property(e => e.IdDarbuotojas)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_darbuotojas");
            entity.Property(e => e.FkPareigosidPareigos).HasColumnName("fk_pareigosid_pareigos");
            entity.Property(e => e.FkSkyriusidSkyrius).HasColumnName("fk_skyriusid_skyrius");
            entity.Property(e => e.IdarbinimoData).HasColumnName("idarbinimo_data");
            entity.Property(e => e.Kodas).HasColumnName("kodas");
            entity.Property(e => e.Nuotrauka)
                .HasMaxLength(255)
                .HasColumnName("nuotrauka");
            entity.Property(e => e.PakeitimaiSesijoje)
                .HasMaxLength(255)
                .HasColumnName("pakeitimai_sesijoje");
            entity.Property(e => e.Pavarde)
                .HasMaxLength(255)
                .HasColumnName("pavarde");
            entity.Property(e => e.PrisijungimoVardas)
                .HasMaxLength(255)
                .HasColumnName("prisijungimo_vardas");
            entity.Property(e => e.Slaptazodis)
                .HasMaxLength(255)
                .HasColumnName("slaptazodis");
            entity.Property(e => e.Stazas).HasColumnName("stazas");
            entity.Property(e => e.ValandinisUzdarbis).HasColumnName("valandinis_uzdarbis");
            entity.Property(e => e.Vardas)
                .HasMaxLength(255)
                .HasColumnName("vardas");
            entity.Property(e => e.Role)
                .HasMaxLength(30)
                .HasColumnName("role");

            entity.HasOne(d => d.FkPareigosidPareigosNavigation).WithMany(p => p.Darbuotojas)
                .HasForeignKey(d => d.FkPareigosidPareigos)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("uzima");

            entity.HasOne(d => d.FkSkyriusidSkyriusNavigation).WithMany(p => p.Darbuotojas)
                .HasForeignKey(d => d.FkSkyriusidSkyrius)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("dirba");
        });

        modelBuilder.Entity<Klientas>(entity =>
        {
            entity.HasKey(e => e.IdKlientas).HasName("klientas_pkey");

            entity.ToTable("klientas");

            entity.Property(e => e.IdKlientas)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_klientas");
            entity.Property(e => e.Aprasymas)
                .HasMaxLength(255)
                .HasColumnName("aprasymas");
            entity.Property(e => e.Nuotrauka)
                .HasMaxLength(255)
                .HasColumnName("nuotrauka");
            entity.Property(e => e.Pavarde)
                .HasMaxLength(255)
                .HasColumnName("pavarde");
            entity.Property(e => e.Vardas)
                .HasMaxLength(255)
                .HasColumnName("vardas");
        });

        modelBuilder.Entity<Pareigos>(entity =>
        {
            entity.HasKey(e => e.IdPareigos).HasName("pareigos_pkey");

            entity.ToTable("pareigos");

            entity.Property(e => e.IdPareigos)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_pareigos");
            entity.Property(e => e.Pavadinimas)
                .HasMaxLength(255)
                .HasColumnName("pavadinimas");
        });

        modelBuilder.Entity<Pastomatas>(entity =>
        {
            entity.HasKey(e => e.IdPastomatas).HasName("pastomatas_pkey");

            entity.ToTable("pastomatas");

            entity.Property(e => e.IdPastomatas)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_pastomatas");
            entity.Property(e => e.Adresas)
                .HasMaxLength(255)
                .HasColumnName("adresas");
            entity.Property(e => e.Imone)
                .HasMaxLength(255)
                .HasColumnName("imone");
            entity.Property(e => e.Miestas)
                .HasMaxLength(255)
                .HasColumnName("miestas");
            entity.Property(e => e.Salis)
                .HasMaxLength(255)
                .HasColumnName("salis");
        });

        modelBuilder.Entity<Preke>(entity =>
        {
            entity.HasKey(e => e.IdPreke).HasName("preke_pkey");

            entity.ToTable("preke");

            entity.Property(e => e.IdPreke)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_preke");
            entity.Property(e => e.Aprasymas)
                .HasMaxLength(255)
                .HasColumnName("aprasymas");
            entity.Property(e => e.Kategorija)
                .HasMaxLength(255)
                .HasColumnName("kategorija");
            entity.Property(e => e.Kiekis).HasColumnName("kiekis");
            entity.Property(e => e.Nuotrauka)
                .HasMaxLength(255)
                .HasColumnName("nuotrauka");
            entity.Property(e => e.Pavadinimas)
                .HasMaxLength(255)
                .HasColumnName("pavadinimas");
            entity.Property(e => e.TrumpasAprasymas)
                .HasMaxLength(255)
                .HasColumnName("trumpas_aprasymas");
            entity.Property(e => e.VienetoKaina).HasColumnName("vieneto_kaina");
        });

        modelBuilder.Entity<Priskiriama>(entity =>
        {
            entity.HasKey(e => new { e.FkZymaidZyma, e.FkPrekeidPreke }).HasName("priskiriama_pkey");

            entity.ToTable("priskiriama");

            entity.Property(e => e.FkZymaidZyma).HasColumnName("fk_zymaid_zyma");
            entity.Property(e => e.FkPrekeidPreke).HasColumnName("fk_prekeid_preke");

            entity.HasOne(d => d.FkZymaidZymaNavigation).WithMany(p => p.Priskiriamas)
                .HasForeignKey(d => d.FkZymaidZyma)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("priskiriama");
        });

        modelBuilder.Entity<Sandelis>(entity =>
        {
            entity.HasKey(e => e.IdSandelis).HasName("sandelis_pkey");

            entity.ToTable("sandelis");

            entity.Property(e => e.IdSandelis)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sandelis");
            entity.Property(e => e.Adresas)
                .HasMaxLength(255)
                .HasColumnName("adresas");
            entity.Property(e => e.Miestas)
                .HasMaxLength(255)
                .HasColumnName("miestas");
            entity.Property(e => e.Salis)
                .HasMaxLength(255)
                .HasColumnName("salis");
        });

        modelBuilder.Entity<Skyrius>(entity =>
        {
            entity.HasKey(e => e.IdSkyrius).HasName("skyrius_pkey");

            entity.ToTable("skyrius");

            entity.Property(e => e.IdSkyrius)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_skyrius");
            entity.Property(e => e.FkSandelisidSandelis).HasColumnName("fk_sandelisid_sandelis");
            entity.Property(e => e.Pavadinimas)
                .HasMaxLength(255)
                .HasColumnName("pavadinimas");

            entity.HasOne(d => d.FkSandelisidSandelisNavigation).WithMany(p => p.Skyrius)
                .HasForeignKey(d => d.FkSandelisidSandelis)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("priklauso");
        });

        modelBuilder.Entity<Statusas>(entity =>
        {
            entity.HasKey(e => e.IdStatusas).HasName("statusas_pkey");

            entity.ToTable("statusas");

            entity.Property(e => e.IdStatusas)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_statusas");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Turi>(entity =>
        {
            entity.HasKey(e => new { e.FkPrekeidPreke, e.FkSandelisidSandelis }).HasName("turi_pkey");

            entity.ToTable("turi");

            entity.Property(e => e.FkPrekeidPreke).HasColumnName("fk_prekeid_preke");
            entity.Property(e => e.FkSandelisidSandelis).HasColumnName("fk_sandelisid_sandelis");

            entity.HasOne(d => d.FkPrekeidPrekeNavigation).WithMany(p => p.Turis)
                .HasForeignKey(d => d.FkPrekeidPreke)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("turi");
        });

        modelBuilder.Entity<Uzsakymas>(entity =>
        {
            entity.HasKey(e => e.IdUzsakymas).HasName("uzsakymas_pkey");

            entity.ToTable("uzsakymas");

            entity.Property(e => e.IdUzsakymas)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_uzsakymas");
            entity.Property(e => e.Adresas)
                .HasMaxLength(255)
                .HasColumnName("adresas");
            entity.Property(e => e.Asmuo).HasColumnName("asmuo");
            entity.Property(e => e.Atsiemimas).HasColumnName("atsiemimas");
            entity.Property(e => e.Atsiskaitymas).HasColumnName("atsiskaitymas");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.FkKlientasidKlientas).HasColumnName("fk_klientasid_klientas");
            entity.Property(e => e.FkPastomatasidPastomatas).HasColumnName("fk_pastomatasid_pastomatas");
            entity.Property(e => e.ImonesKodas).HasColumnName("imones_kodas");
            entity.Property(e => e.ImonesPavadinimas)
                .HasMaxLength(255)
                .HasColumnName("imones_pavadinimas");
            entity.Property(e => e.ImonesPvmKodas)
                .HasMaxLength(255)
                .HasColumnName("imones_pvm_kodas");
            entity.Property(e => e.Kaina).HasColumnName("kaina");
            entity.Property(e => e.Miestas)
                .HasMaxLength(255)
                .HasColumnName("miestas");
            entity.Property(e => e.PapildomaInformacija)
                .HasMaxLength(255)
                .HasColumnName("papildoma_informacija");
            entity.Property(e => e.Pastas)
                .HasMaxLength(255)
                .HasColumnName("pastas");
            entity.Property(e => e.PastoKodas)
                .HasMaxLength(255)
                .HasColumnName("pasto_kodas");
            entity.Property(e => e.PristatymoData).HasColumnName("pristatymo_data");
            entity.Property(e => e.Salis)
                .HasMaxLength(255)
                .HasColumnName("salis");
            entity.Property(e => e.Statusas).HasColumnName("statusas");
            entity.Property(e => e.Telefonas).HasColumnName("telefonas");

            entity.HasOne(d => d.AsmuoNavigation).WithMany(p => p.Uzsakymas)
                .HasForeignKey(d => d.Asmuo)
                .HasConstraintName("uzsakymas_asmuo_fkey");

            entity.HasOne(d => d.AtsiemimasNavigation).WithMany(p => p.Uzsakymas)
                .HasForeignKey(d => d.Atsiemimas)
                .HasConstraintName("uzsakymas_atsiemimas_fkey");

            entity.HasOne(d => d.AtsiskaitymasNavigation).WithMany(p => p.Uzsakymas)
                .HasForeignKey(d => d.Atsiskaitymas)
                .HasConstraintName("uzsakymas_atsiskaitymas_fkey");

            entity.HasOne(d => d.FkKlientasidKlientasNavigation).WithMany(p => p.Uzsakymas)
                .HasForeignKey(d => d.FkKlientasidKlientas)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("sudaro");

            entity.HasOne(d => d.FkPastomatasidPastomatasNavigation).WithMany(p => p.Uzsakymas)
                .HasForeignKey(d => d.FkPastomatasidPastomatas)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("turi");

            entity.HasOne(d => d.StatusasNavigation).WithMany(p => p.Uzsakymas)
                .HasForeignKey(d => d.Statusas)
                .HasConstraintName("uzsakymas_statusas_fkey");
        });

        modelBuilder.Entity<Uzsakymopreke>(entity =>
        {
            entity.HasKey(e => e.IdUzsakymoPreke).HasName("uzsakymopreke_pkey");

            entity.ToTable("uzsakymopreke");

            entity.Property(e => e.IdUzsakymoPreke)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_uzsakymo_preke");
            entity.Property(e => e.Atsiemimas).HasColumnName("atsiemimas");
            entity.Property(e => e.FkPrekeidPreke).HasColumnName("fk_prekeid_preke");
            entity.Property(e => e.FkUzsakymasidUzsakymas).HasColumnName("fk_uzsakymasid_uzsakymas");
            entity.Property(e => e.Kiekis).HasColumnName("kiekis");
            entity.Property(e => e.Suma).HasColumnName("suma");

            entity.HasOne(d => d.AtsiemimasNavigation).WithMany(p => p.Uzsakymoprekes)
                .HasForeignKey(d => d.Atsiemimas)
                .HasConstraintName("uzsakymopreke_atsiemimas_fkey");

            entity.HasOne(d => d.FkPrekeidPrekeNavigation).WithMany(p => p.Uzsakymoprekes)
                .HasForeignKey(d => d.FkPrekeidPreke)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("susideda");

            entity.HasOne(d => d.FkUzsakymasidUzsakymasNavigation).WithMany(p => p.Uzsakymoprekes)
                .HasForeignKey(d => d.FkUzsakymasidUzsakymas)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("uzsakomas");
        });

        modelBuilder.Entity<Zyma>(entity =>
        {
            entity.HasKey(e => e.IdZyma).HasName("zyma_pkey");

            entity.ToTable("zyma");

            entity.Property(e => e.IdZyma)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_zyma");
            entity.Property(e => e.Pavadinimas)
                .HasMaxLength(255)
                .HasColumnName("pavadinimas");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
