using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WMSWeb.Models
{
    public partial class ESSENTIALWMSContext : DbContext
    {
        public ESSENTIALWMSContext()
        {
        }

        public ESSENTIALWMSContext(DbContextOptions<ESSENTIALWMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Almacen> Almacen { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<DetalleDocEntrada> DetalleDocEntrada { get; set; }
        public virtual DbSet<DetalleDocSalida> DetalleDocSalida { get; set; }
        public virtual DbSet<DetalleInventario> DetalleInventario { get; set; }
        public virtual DbSet<DetalleLpn> DetalleLpn { get; set; }
        public virtual DbSet<DocumentoEntrada> DocumentoEntrada { get; set; }
        public virtual DbSet<DocumentoSalida> DocumentoSalida { get; set; }
        public virtual DbSet<EmpresaTransportista> EmpresaTransportista { get; set; }
        public virtual DbSet<InventarioAlmacen> InventarioAlmacen { get; set; }
        public virtual DbSet<Lpn> Lpn { get; set; }
        public virtual DbSet<MovtoDevolucion> MovtoDevolucion { get; set; }
        public virtual DbSet<MovtoEntrada> MovtoEntrada { get; set; }
        public virtual DbSet<MovtoSalida> MovtoSalida { get; set; }
        public virtual DbSet<MovtoTransaccional> MovtoTransaccional { get; set; }
        public virtual DbSet<MovtoTraspasoAlmacen> MovtoTraspasoAlmacen { get; set; }
        public virtual DbSet<PreparacionSalida> PreparacionSalida { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<SisAplicacion> SisAplicacion { get; set; }
        public virtual DbSet<SisMenu> SisMenu { get; set; }
        public virtual DbSet<SisPerfilPermisos> SisPerfilPermisos { get; set; }
        public virtual DbSet<SisPerfilesUsuario> SisPerfilesUsuario { get; set; }
        public virtual DbSet<SisPermisoMenu> SisPermisoMenu { get; set; }
        public virtual DbSet<SisTransaccion> SisTransaccion { get; set; }
        public virtual DbSet<TipoAjuste> TipoAjuste { get; set; }
        public virtual DbSet<TipoBloqueo> TipoBloqueo { get; set; }
        public virtual DbSet<TomaInventario> TomaInventario { get; set; }
        public virtual DbSet<UbicacionFisica> UbicacionFisica { get; set; }
        public virtual DbSet<UnidadMedida> UnidadMedida { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<VePermisosUsuario> VePermisosUsuario { get; set; }
        public virtual DbSet<VeSisParametros> VeSisParametros { get; set; }
        public virtual DbSet<VeSisPerfilesUsuario> VeSisPerfilesUsuario { get; set; }
        public virtual DbSet<ZonaUbicacion> ZonaUbicacion { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Almacen>(entity =>
            {
                entity.HasKey(e => e.CodAlmacen);

                entity.Property(e => e.CodAlmacen)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Fono)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomAlmacen)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Representante)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.CodCliente);

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comuna)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Fono)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NomCliente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ruta)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetalleDocEntrada>(entity =>
            {
                entity.HasKey(e => new { e.NroEntrada, e.NroLinea, e.CodAlmacen });

                entity.Property(e => e.NroEntrada).ValueGeneratedOnAdd();

                entity.Property(e => e.CodAlmacen)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Lote)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetalleDocEntrada)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_DetalleDocEntrada_Producto");

                entity.HasOne(d => d.DocumentoEntrada)
                    .WithMany(p => p.DetalleDocEntrada)
                    .HasForeignKey(d => new { d.NroEntrada, d.CodAlmacen })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleDocEntrada_DocEntrada");
            });

            modelBuilder.Entity<DetalleDocSalida>(entity =>
            {
                entity.HasKey(e => new { e.NroSalida, e.NroLinea, e.CodAlmacen });

                entity.Property(e => e.CodAlmacen)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FuePreparada).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lote)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetalleDocSalida)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_DetalleDocSalida_Producto");

                entity.HasOne(d => d.NroSalidaNavigation)
                    .WithMany(p => p.DetalleDocSalida)
                    .HasForeignKey(d => d.NroSalida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleDocSalida_DocumentoSalida");
            });

            modelBuilder.Entity<DetalleInventario>(entity =>
            {
                entity.HasKey(e => new { e.IdInventario, e.CodAlmacen });

                entity.Property(e => e.IdInventario).ValueGeneratedOnAdd();

                entity.Property(e => e.CodAlmacen)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodLpn)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaElaboracion).HasColumnType("datetime");

                entity.Property(e => e.Lote)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetalleLpn>(entity =>
            {
                entity.HasKey(e => new { e.CodAlmacen, e.CodLpn, e.CodProducto, e.FechaIngreso, e.FechaElaboracion, e.FechaExpiracion });

                entity.Property(e => e.CodAlmacen)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodLpn)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodProducto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaElaboracion)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaExpiracion)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CodEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('D')");

                entity.Property(e => e.FecAlmacenaje).HasColumnType("datetime");

                entity.Property(e => e.Lote)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.DetalleLpn)
                    .HasForeignKey(d => new { d.CodAlmacen, d.CodLpn })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleLpn_Lpn");
            });

            modelBuilder.Entity<DocumentoEntrada>(entity =>
            {
                entity.HasKey(e => new { e.NroEntrada, e.CodAlmacen });

                entity.HasIndex(e => new { e.NroEntrada, e.CodProveedor })
                    .HasName("UC_DocumentoEntrada_Proveedor")
                    .IsUnique();

                entity.Property(e => e.NroEntrada).ValueGeneratedOnAdd();

                entity.Property(e => e.CodAlmacen)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodAlmacenOrigen)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.CodProveedor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FecEstimadaRecepcion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NroDocEntrada)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NroDocReferencia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodAlmacenNavigation)
                    .WithMany(p => p.DocumentoEntrada)
                    .HasForeignKey(d => d.CodAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocEntrada_Almacen");

                entity.HasOne(d => d.CodProveedorNavigation)
                    .WithMany(p => p.DocumentoEntrada)
                    .HasForeignKey(d => d.CodProveedor)
                    .HasConstraintName("FK_DocumentoEntrada_Proveedor");
            });

            modelBuilder.Entity<DocumentoSalida>(entity =>
            {
                entity.HasKey(e => e.NroSalida);

                entity.Property(e => e.BackOrder)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadDestino)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodAlmacen)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodAlmacenDestino)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodDestinatario)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodEstadoSalida)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DireccionDestino)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEmpaque).HasColumnType("datetime");

                entity.Property(e => e.FechaEstimadaDespacho).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaPreparado).HasColumnType("datetime");

                entity.Property(e => e.FechaRealDespacho).HasColumnType("datetime");

                entity.Property(e => e.NomDestinatario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NroDocEntrada)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NroDocReferencia)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NroDocSalida)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NroPatente)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaisDestino)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpresaTransportista>(entity =>
            {
                entity.HasKey(e => e.CodTransportista);

                entity.Property(e => e.CodTransportista)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NomTransportista)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventarioAlmacen>(entity =>
            {
                entity.HasKey(e => new { e.CodAlmacen, e.CodUbicacion, e.CodProducto });

                entity.Property(e => e.CodAlmacen)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodUbicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodProducto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('D')");

                entity.Property(e => e.FechaElaboracion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaExpiracion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("smalldatetime");

                entity.Property(e => e.Lote)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NroSerie)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoInventario)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('STOCK')");

                entity.HasOne(d => d.CodAlmacenNavigation)
                    .WithMany(p => p.InventarioAlmacen)
                    .HasForeignKey(d => d.CodAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventarioAlmacen_Almacen");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.InventarioAlmacen)
                    .HasPrincipalKey(p => new { p.CodProducto, p.CodAlmacen })
                    .HasForeignKey(d => new { d.CodProducto, d.CodAlmacen })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventarioAlmacen_Producto");

                entity.HasOne(d => d.CodNavigation)
                    .WithMany(p => p.InventarioAlmacen)
                    .HasForeignKey(d => new { d.CodUbicacion, d.CodAlmacen })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventarioAlmacen_Ubicacion");
            });

            modelBuilder.Entity<Lpn>(entity =>
            {
                entity.HasKey(e => new { e.CodAlmacen, e.CodLpn });

                entity.HasIndex(e => new { e.CodAlmacen, e.CodUbicacion })
                    .HasName("UC_Lpn_Ubicacion")
                    .IsUnique();

                entity.Property(e => e.CodAlmacen)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodLpn)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodUserCreador)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FecAlmacenaje).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.NroDocEntrada)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaraLpn).HasColumnType("numeric(9, 3)");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.Lpn)
                    .HasForeignKey(d => new { d.CodUbicacion, d.CodAlmacen })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lpn_Ubicacion");
            });

            modelBuilder.Entity<MovtoDevolucion>(entity =>
            {
                entity.HasKey(e => e.IdMovtoDevolucion);

                entity.Property(e => e.CodAlmacen)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodLpn)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodProducto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaElaboracion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaMovto)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lote)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MovtoEntrada>(entity =>
            {
                entity.HasKey(e => e.IdMovtoEntrada);

                entity.HasIndex(e => new { e.CodAlmacen, e.NroEntrada })
                    .HasName("UC_MovtoEntrada_DocEntrada")
                    .IsUnique();

                entity.HasIndex(e => new { e.NroEntrada, e.NroLinea })
                    .HasName("IDX_MovtoEntradaNroEntNroLin");

                entity.Property(e => e.CodAlmacen)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodLpn)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaElaboracion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaMovto)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lote)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.DocumentoEntrada)
                    .WithMany(p => p.MovtoEntrada)
                    .HasForeignKey(d => new { d.NroEntrada, d.CodAlmacen })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovtoEntrada_DocEntrada");
            });

            modelBuilder.Entity<MovtoSalida>(entity =>
            {
                entity.HasKey(e => e.IdMovtoSalida);

                entity.HasIndex(e => e.NroSalida)
                    .HasName("IDX_MovtoSalida_NroSalida");

                entity.Property(e => e.CodAlmacen)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodLpn)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodProducto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaElaboracion).HasColumnType("datetime");

                entity.Property(e => e.FechaMovto)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lote)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MovtoTransaccional>(entity =>
            {
                entity.HasKey(e => e.IdMovtoTransaccional);

                entity.HasIndex(e => new { e.CodAlmacen, e.CodTransaccion, e.CodUbicacion, e.CodProducto, e.CodUsuario })
                    .HasName("UC_MovtotTransaccional")
                    .IsUnique();

                entity.Property(e => e.CodAlmacen)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodAlmacen2)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodLpn)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodLpn2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodTransaccion)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodUbicacion2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodUsuario)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dispositivo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaElaboracion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaHoraFinalTrx).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraInicioTrx).HasColumnType("datetime");

                entity.Property(e => e.Lote)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomTransaccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NroDocumento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NroDocumento2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodAlmacenNavigation)
                    .WithMany(p => p.MovtoTransaccional)
                    .HasForeignKey(d => d.CodAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovtoTransaccional_Almacen");

                entity.HasOne(d => d.CodTransaccionNavigation)
                    .WithMany(p => p.MovtoTransaccional)
                    .HasForeignKey(d => d.CodTransaccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovtoTransaccional_Transaccion");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.MovtoTransaccional)
                    .HasForeignKey(d => new { d.CodAlmacen, d.CodUsuario })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovtoTransaccional_Usuario");

                entity.HasOne(d => d.CodNavigation)
                    .WithMany(p => p.MovtoTransaccional)
                    .HasPrincipalKey(p => new { p.CodProducto, p.CodAlmacen })
                    .HasForeignKey(d => new { d.CodProducto, d.CodAlmacen })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovtoTransaccional_Producto");

                entity.HasOne(d => d.Cod1)
                    .WithMany(p => p.MovtoTransaccional)
                    .HasForeignKey(d => new { d.CodUbicacion, d.CodAlmacen })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovtoTransaccional_Ubicacion");
            });

            modelBuilder.Entity<MovtoTraspasoAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdTraspasoAlmacen);

                entity.HasIndex(e => e.CodTransporte)
                    .HasName("IDX_MTA_CodTransporte");

                entity.HasIndex(e => e.NroSalida)
                    .HasName("IDX_MTA_NroSalida");

                entity.Property(e => e.CodAlmacen)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodAlmacenDestino)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodLpn)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodProducto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodTransporte)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodUbicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodUsuario)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaElaboracion).HasColumnType("datetime");

                entity.Property(e => e.FechaMovto)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lote)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreparacionSalida>(entity =>
            {
                entity.HasKey(e => e.IdPreparaSalida);

                entity.Property(e => e.CodAlmacen)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodLpn)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodUbicacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaElaboracion).HasColumnType("smalldatetime");

                entity.Property(e => e.Lote)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.HasIndex(e => new { e.CodProducto, e.CodAlmacen })
                    .HasName("UC_Producto_Almacen")
                    .IsUnique();

                entity.Property(e => e.Alto)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ancho)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodAlmacen)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodUnidadMedida)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ControlLote)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ControlSerie)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DescripcionCorta)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionLarga)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DiasVencimiento).HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaUltimoConteo).HasColumnType("smalldatetime");

                entity.Property(e => e.Largo)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PesoTara).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PesoUnidad)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductoPeligroso)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Rotacion)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ValorReferencia).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Volumen)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodAlmacenNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.CodAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Producto_Almacen");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.CodProveedor);

                entity.Property(e => e.CodProveedor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Fono)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NomProveedor)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SisAplicacion>(entity =>
            {
                entity.HasKey(e => e.NomAplicacion)
                    .IsClustered(false);

                entity.Property(e => e.NomAplicacion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescAplicacion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SisMenu>(entity =>
            {
                entity.HasKey(e => new { e.NomAplicacion, e.NomMenu })
                    .IsClustered(false);

                entity.Property(e => e.NomAplicacion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NomMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescMenu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescNivel)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SisPerfilPermisos>(entity =>
            {
                entity.HasKey(e => e.CodPerfilPermisos)
                    .IsClustered(false);

                entity.Property(e => e.NomPerfilPermisos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SisPerfilesUsuario>(entity =>
            {
                entity.HasKey(e => new { e.CodUsuario, e.CodAlmacen, e.CodPerfilPermisos });

                entity.Property(e => e.CodUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodAlmacen)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodPerfilPermisosNavigation)
                    .WithMany(p => p.SisPerfilesUsuario)
                    .HasForeignKey(d => d.CodPerfilPermisos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SisPerfilesUsuario_SisPerfilPermisos");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.SisPerfilesUsuario)
                    .HasForeignKey(d => new { d.CodAlmacen, d.CodUsuario })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SisPerfilesUsuario_Usuario");
            });

            modelBuilder.Entity<SisPermisoMenu>(entity =>
            {
                entity.HasKey(e => new { e.CodPerfilPermisos, e.NomAplicacion, e.NomMenu })
                    .IsClustered(false);

                entity.Property(e => e.NomAplicacion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NomMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodPerfilPermisosNavigation)
                    .WithMany(p => p.SisPermisoMenu)
                    .HasForeignKey(d => d.CodPerfilPermisos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SisPermisoMenu_SisPerfilPermisos");

                entity.HasOne(d => d.NomAplicacionNavigation)
                    .WithMany(p => p.SisPermisoMenu)
                    .HasForeignKey(d => d.NomAplicacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SisPermisoMenu_SisAplicacion");

                entity.HasOne(d => d.Nom)
                    .WithMany(p => p.SisPermisoMenu)
                    .HasForeignKey(d => new { d.NomAplicacion, d.NomMenu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SisPermisosMenu_SisMenu");
            });

            modelBuilder.Entity<SisTransaccion>(entity =>
            {
                entity.HasKey(e => e.CodTransaccion)
                    .IsClustered(false);

                entity.Property(e => e.CodTransaccion)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NomTransaccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoAjuste>(entity =>
            {
                entity.HasKey(e => e.CodTipoAjuste);

                entity.Property(e => e.CodTipoAjuste).ValueGeneratedNever();

                entity.Property(e => e.NomTipoAjuste)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoBloqueo>(entity =>
            {
                entity.HasKey(e => e.CodTipoBloqueo);

                entity.Property(e => e.CodTipoBloqueo).ValueGeneratedNever();

                entity.Property(e => e.NomTipoBloqueo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TomaInventario>(entity =>
            {
                entity.HasKey(e => e.NroInventario);

                entity.Property(e => e.NroInventario).ValueGeneratedNever();

                entity.Property(e => e.CodAlmacen)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.CodProducto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodResponsable)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FecElaboracionDesde).HasColumnType("smalldatetime");

                entity.Property(e => e.FecElaboracionHasta).HasColumnType("smalldatetime");

                entity.Property(e => e.FecInventarioDesde).HasColumnType("smalldatetime");

                entity.Property(e => e.FecInventarioHasta).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UbicacionFisica>(entity =>
            {
                entity.HasKey(e => new { e.CodUbicacion, e.CodAlmacen });

                entity.HasIndex(e => new { e.CodAlmacen, e.Hilera, e.Columna, e.Nivel })
                    .HasName("idx_UbicacionFisica_");

                entity.Property(e => e.CodUbicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodAlmacen)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Alto).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Ancho).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.AreaPicking)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CapacidadUm).HasColumnName("CapacidadUM");

                entity.Property(e => e.CapacidadVolumen).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.CodEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.CodZona)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlujoPicking)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Largo).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TipoLpn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.TipoUbicacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoUm)
                    .HasColumnName("TipoUM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UbicacionReposicion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UltimaFechaConteo).HasColumnType("smalldatetime");

                entity.HasOne(d => d.CodAlmacenNavigation)
                    .WithMany(p => p.UbicacionFisica)
                    .HasForeignKey(d => d.CodAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UbicacionFisica_Almacen");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.UbicacionFisica)
                    .HasForeignKey(d => new { d.CodZona, d.CodAlmacen })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UbicacionFisica_Zona");
            });

            modelBuilder.Entity<UnidadMedida>(entity =>
            {
                entity.HasKey(e => e.IdUnidadMedida);

                entity.HasIndex(e => new { e.CodUnidadMedida, e.CodAlmacen, e.CodProducto })
                    .HasName("UC_UnidadMedida_Almacen")
                    .IsUnique();

                entity.Property(e => e.Alto)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ancho)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CapasPorLpn).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodAlmacen)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodBarra)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodUnidadMedida)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Conveyable)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DescUnidadMedida)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FactorConversion).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Largo)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Peso).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Pickiable)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.UnidadesPorCapas).HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.UnidadMedida)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnidadMedida_Producto");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => new { e.CodAlmacen, e.CodUsuario });

                entity.Property(e => e.CodAlmacen)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AreaPicking)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodZona)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dispositivo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rut)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodAlmacenNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.CodAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Almacen");
            });

            modelBuilder.Entity<VePermisosUsuario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Ve_PermisosUsuario");

                entity.Property(e => e.CodUsuario)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomAplicacion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NomMenu)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NomPerfilPermisos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomSubMenu)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VeSisParametros>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Ve_SisParametros");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecActualizacion).HasColumnType("datetime");

                entity.Property(e => e.NomParamTipo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomParametro)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequiereReIniciarApp)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDato)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValorActual)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValorMaximo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValorMinimo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VeSisPerfilesUsuario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Ve_SisPerfilesUsuario");

                entity.Property(e => e.CodAlmacen)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodUsuario)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomPerfilPermisos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZonaUbicacion>(entity =>
            {
                entity.HasKey(e => new { e.CodZona, e.CodAlmacen });

                entity.Property(e => e.CodZona)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodAlmacen)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DescZona)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoZona)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
