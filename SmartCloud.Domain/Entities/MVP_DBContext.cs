using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SmartCloud.Domain.Entities
{
    public partial class MVP_DBContext : DbContext
    {
        public MVP_DBContext()
        {
        }

        public MVP_DBContext(DbContextOptions<MVP_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityType> ActivityType { get; set; }
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<AssetAttributes> AssetAttributes { get; set; }
        public virtual DbSet<AssetBeaconRel> AssetBeaconRel { get; set; }
        public virtual DbSet<AssetInformationRel> AssetInformationRel { get; set; }
        public virtual DbSet<AssetInspection> AssetInspection { get; set; }
        public virtual DbSet<AssetType> AssetType { get; set; }
        public virtual DbSet<Beacon> Beacon { get; set; }
        public virtual DbSet<CityLookup> CityLookup { get; set; }
        public virtual DbSet<CountryLookup> CountryLookup { get; set; }
        public virtual DbSet<Ctiotservice> Ctiotservice { get; set; }
        public virtual DbSet<CustomerInspection> CustomerInspection { get; set; }
        public virtual DbSet<Dvirmaster> Dvirmaster { get; set; }
        public virtual DbSet<FunctionType> FunctionType { get; set; }
        public virtual DbSet<IndustryGroup> IndustryGroup { get; set; }
        public virtual DbSet<IndustryType> IndustryType { get; set; }
        public virtual DbSet<InspectionManifest> InspectionManifest { get; set; }
        public virtual DbSet<InspectionProcess> InspectionProcess { get; set; }
        public virtual DbSet<InspectionResults> InspectionResults { get; set; }
        public virtual DbSet<InspectionResultsDvirrel> InspectionResultsDvirrel { get; set; }
        public virtual DbSet<InspectionType> InspectionType { get; set; }
        public virtual DbSet<IssueManagement> IssueManagement { get; set; }
        public virtual DbSet<LineOfBusiness> LineOfBusiness { get; set; }
        public virtual DbSet<LineOfBusinessUserRel> LineOfBusinessUserRel { get; set; }
        public virtual DbSet<LocationType> LocationType { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MessageType> MessageType { get; set; }
        public virtual DbSet<Metadata> Metadata { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<NotificationType> NotificationType { get; set; }
        public virtual DbSet<OperatorCertification> OperatorCertification { get; set; }
        public virtual DbSet<OperatorCertificationType> OperatorCertificationType { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<ProcessType> ProcessType { get; set; }
        public virtual DbSet<ProvinceLookup> ProvinceLookup { get; set; }
        public virtual DbSet<ResolutionDetail> ResolutionDetail { get; set; }
        public virtual DbSet<SeverityType> SeverityType { get; set; }
        public virtual DbSet<SiteLocation> SiteLocation { get; set; }
        public virtual DbSet<StepType> StepType { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserBehavior> UserBehavior { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }

        // Unable to generate entity type for table 'dbo.ClientCertification'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=mvp-server-1.database.windows.net;Database=MVP_DB_V2;Persist Security Info=False;User ID=TechTeamAdmin;Password=MarZorAlex2001;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityType>(entity =>
            {
                entity.Property(e => e.ActivitytypeId).HasColumnName("Activitytype_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.Property(e => e.AssetId)
                    .HasColumnName("Asset_ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AssetTypeId).HasColumnName("AssetType_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineOfBusinessId).HasColumnName("LineOfBusiness_ID");

                entity.HasOne(d => d.AssetType)
                    .WithMany(p => p.Asset)
                    .HasForeignKey(d => d.AssetTypeId)
                    .HasConstraintName("FK_Asset_AssetType");

                entity.HasOne(d => d.LineOfBusiness)
                    .WithMany(p => p.Asset)
                    .HasForeignKey(d => d.LineOfBusinessId)
                    .HasConstraintName("FK_Asset_LineOfBusiness");
            });

            modelBuilder.Entity<AssetAttributes>(entity =>
            {
                entity.Property(e => e.AssetAttributesId)
                    .HasColumnName("AssetAttributes_ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AssetId).HasColumnName("Asset_ID");

                entity.Property(e => e.Barcode).IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.IdentificationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicensePlate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Make)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetAttributes)
                    .HasForeignKey(d => d.AssetId)
                    .HasConstraintName("FK_AssetAttribute_Asset");
            });

            modelBuilder.Entity<AssetBeaconRel>(entity =>
            {
                entity.Property(e => e.AssetBeaconRelId)
                    .HasColumnName("AssetBeaconRel_ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AssetId).HasColumnName("Asset_ID");

                entity.Property(e => e.AttachedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeaconId).HasColumnName("Beacon_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAttached).HasColumnType("datetime2(0)");

                entity.Property(e => e.LocationTypeId).HasColumnName("LocationType_ID");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetBeaconRel)
                    .HasForeignKey(d => d.AssetId)
                    .HasConstraintName("FK_AssetBeaconRel_Asset");

                entity.HasOne(d => d.Beacon)
                    .WithMany(p => p.AssetBeaconRel)
                    .HasForeignKey(d => d.BeaconId)
                    .HasConstraintName("FK_AssetBeaconRel_Beacon");

                entity.HasOne(d => d.LocationType)
                    .WithMany(p => p.AssetBeaconRel)
                    .HasForeignKey(d => d.LocationTypeId)
                    .HasConstraintName("FK_AssetBeaconRel_LocationType");
            });

            modelBuilder.Entity<AssetInformationRel>(entity =>
            {
                entity.Property(e => e.AssetInformationRelId)
                    .HasColumnName("AssetInformationRel_ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AssetId).HasColumnName("Asset_ID");

                entity.Property(e => e.AssetInspectionId).HasColumnName("AssetInspection_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetInformationRel)
                    .HasForeignKey(d => d.AssetId)
                    .HasConstraintName("FK_AssetInformationRel_Asset");

                entity.HasOne(d => d.AssetInspection)
                    .WithMany(p => p.AssetInformationRel)
                    .HasForeignKey(d => d.AssetInspectionId)
                    .HasConstraintName("FK_AssetInformationRel_AssetInspection");
            });

            modelBuilder.Entity<AssetInspection>(entity =>
            {
                entity.Property(e => e.AssetInspectionId)
                    .HasColumnName("AssetInspection_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.InspectionStartTime).HasColumnType("time(0)");

                entity.Property(e => e.InspectionStopTime).HasColumnType("time(0)");

                entity.Property(e => e.InspectionTypeId).HasColumnName("InspectionType_ID");

                entity.Property(e => e.Lattitude).HasColumnType("numeric(8, 5)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(8, 5)");

                entity.Property(e => e.PercentagePass).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.UserSignature).HasColumnType("image");

                entity.HasOne(d => d.InspectionType)
                    .WithMany(p => p.AssetInspection)
                    .HasForeignKey(d => d.InspectionTypeId)
                    .HasConstraintName("FK_AssetInspection_InspectionType");
            });

            modelBuilder.Entity<AssetType>(entity =>
            {
                entity.Property(e => e.AssetTypeId).HasColumnName("AssetType_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Beacon>(entity =>
            {
                entity.Property(e => e.BeaconId)
                    .HasColumnName("Beacon_ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateReceived).HasColumnType("smalldatetime");

                entity.Property(e => e.DecomimissionDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerGuid).HasColumnName("ManufacturerGUID");

                entity.Property(e => e.ReOrderDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CityLookup>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CensusDivision)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude).HasColumnType("numeric(8, 5)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(8, 5)");

                entity.Property(e => e.MapReference)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MunicipalityType)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(73)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeArea)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceId).HasColumnName("Province_ID");

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.CityLookup)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_CityLookup_ProvinceLookup");
            });

            modelBuilder.Entity<CountryLookup>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<Ctiotservice>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.ToTable("CTIOTService");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineOfBusinessId).HasColumnName("LineOfBusiness_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LineOfBusiness)
                    .WithMany(p => p.Ctiotservice)
                    .HasForeignKey(d => d.LineOfBusinessId)
                    .HasConstraintName("FK_CTIOTService_LineOfBusiness");
            });

            modelBuilder.Entity<CustomerInspection>(entity =>
            {
                entity.Property(e => e.CustomerInspectionId).HasColumnName("CustomerInspection_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPayload).HasColumnType("xml");

                entity.Property(e => e.InspectionManifestId).HasColumnName("InspectionManifest_ID");

                entity.Property(e => e.InspectionTypeId).HasColumnName("InspectionType_ID");

                entity.Property(e => e.NextScheduleDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.Property(e => e.VersionNumber).HasColumnType("numeric(8, 2)");

                entity.HasOne(d => d.InspectionType)
                    .WithMany(p => p.CustomerInspection)
                    .HasForeignKey(d => d.InspectionTypeId)
                    .HasConstraintName("FK_CustomerInspection_InspectionType");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.CustomerInspection)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_CustomerInspection_CTIOTService");
            });

            modelBuilder.Entity<Dvirmaster>(entity =>
            {
                entity.ToTable("DVIRMaster");

                entity.Property(e => e.DvirmasterId)
                    .HasColumnName("DVIRMaster_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DvirmasterNumber)
                    .HasColumnName("DVIRMasterNumber")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ElementName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleTypeId).HasColumnName("VehicleType_ID");
            });

            modelBuilder.Entity<FunctionType>(entity =>
            {
                entity.Property(e => e.FunctionTypeId).HasColumnName("FunctionType_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.FunctionType)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_FunctionType_CTIOTService");
            });

            modelBuilder.Entity<IndustryGroup>(entity =>
            {
                entity.Property(e => e.IndustryGroupId).HasColumnName("IndustryGroup_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndustryGroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IndustryType>(entity =>
            {
                entity.Property(e => e.IndustryTypeId).HasColumnName("IndustryType_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndustryGroupId).HasColumnName("IndustryGroup_ID");

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IndustryGroup)
                    .WithMany(p => p.IndustryType)
                    .HasForeignKey(d => d.IndustryGroupId)
                    .HasConstraintName("FK_IndustryType_IndustryGroup");
            });

            modelBuilder.Entity<InspectionManifest>(entity =>
            {
                entity.Property(e => e.InspectionManifestId).HasColumnName("InspectionManifest_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionTypeId).HasColumnName("InspectionType_ID");

                entity.Property(e => e.MasterPayload).HasColumnType("xml");

                entity.Property(e => e.VersionNumber).HasColumnType("numeric(8, 2)");

                entity.HasOne(d => d.InspectionType)
                    .WithMany(p => p.InspectionManifest)
                    .HasForeignKey(d => d.InspectionTypeId)
                    .HasConstraintName("FK_InspectionManifest_InspectionType");
            });

            modelBuilder.Entity<InspectionProcess>(entity =>
            {
                entity.Property(e => e.InspectionProcessId)
                    .HasColumnName("InspectionProcess_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssetInspectionId).HasColumnName("AssetInspection_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessTypeId).HasColumnName("ProcessType_ID");

                entity.HasOne(d => d.AssetInspection)
                    .WithMany(p => p.InspectionProcess)
                    .HasForeignKey(d => d.AssetInspectionId)
                    .HasConstraintName("FK_InspectionProcess_AssetInspection");

                entity.HasOne(d => d.ProcessType)
                    .WithMany(p => p.InspectionProcess)
                    .HasForeignKey(d => d.ProcessTypeId)
                    .HasConstraintName("FK_InspectionProcess_ProcessType");
            });

            modelBuilder.Entity<InspectionResults>(entity =>
            {
                entity.Property(e => e.InspectionResultsId)
                    .HasColumnName("InspectionResults_ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityType_ID");

                entity.Property(e => e.Audio).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionProcessId).HasColumnName("InspectionProcess_ID");

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.SeverityTypeId).HasColumnName("SeverityType_ID");

                entity.Property(e => e.StepTypeId).HasColumnName("StepType_ID");

                entity.HasOne(d => d.ActivityType)
                    .WithMany(p => p.InspectionResults)
                    .HasForeignKey(d => d.ActivityTypeId)
                    .HasConstraintName("FK_InspectionResults_ActivityType");

                entity.HasOne(d => d.InspectionProcess)
                    .WithMany(p => p.InspectionResults)
                    .HasForeignKey(d => d.InspectionProcessId)
                    .HasConstraintName("FK_InspectionResults_InspectionProcess");

                entity.HasOne(d => d.SeverityType)
                    .WithMany(p => p.InspectionResults)
                    .HasForeignKey(d => d.SeverityTypeId)
                    .HasConstraintName("FK_InspectionResults_SeverityType");

                entity.HasOne(d => d.StepType)
                    .WithMany(p => p.InspectionResults)
                    .HasForeignKey(d => d.StepTypeId)
                    .HasConstraintName("FK_InspectionResults_StepType");
            });

            modelBuilder.Entity<InspectionResultsDvirrel>(entity =>
            {
                entity.ToTable("InspectionResultsDVIRRel");

                entity.Property(e => e.InspectionResultsDvirrelId)
                    .HasColumnName("InspectionResultsDVIRRel_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreateSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DvirmasterId).HasColumnName("DVIRMaster_ID");

                entity.Property(e => e.InspectionResultsId).HasColumnName("InspectionResults_ID");

                entity.Property(e => e.LastModDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dvirmaster)
                    .WithMany(p => p.InspectionResultsDvirrel)
                    .HasForeignKey(d => d.DvirmasterId)
                    .HasConstraintName("FK_InspectionResultsDVIRRel_DVIRMaster");
            });

            modelBuilder.Entity<InspectionType>(entity =>
            {
                entity.Property(e => e.InspectionTypeId).HasColumnName("InspectionType_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IssueManagement>(entity =>
            {
                entity.Property(e => e.IssueManagementId)
                    .HasColumnName("IssueManagement_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActualFixDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.AssetAssignDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.AssetInspectionId).HasColumnName("AssetInspection_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedFixDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MechanicId).HasColumnName("Mechanic_ID");

                entity.Property(e => e.ShopReceivalDate).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.AssetInspection)
                    .WithMany(p => p.IssueManagement)
                    .HasForeignKey(d => d.AssetInspectionId)
                    .HasConstraintName("FK_IssueManagement_AssetInspection");
            });

            modelBuilder.Entity<LineOfBusiness>(entity =>
            {
                entity.Property(e => e.LineOfBusinessId)
                    .HasColumnName("LineOfBusiness_ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OrganizationId).HasColumnName("Organization_ID");

                entity.Property(e => e.SiteLocationId).HasColumnName("SiteLocation_ID");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.LineOfBusiness)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_LineOfBusiness_Organization");

                entity.HasOne(d => d.SiteLocation)
                    .WithMany(p => p.LineOfBusiness)
                    .HasForeignKey(d => d.SiteLocationId)
                    .HasConstraintName("FK_LineOfBusiness_SiteLocation");
            });

            modelBuilder.Entity<LineOfBusinessUserRel>(entity =>
            {
                entity.Property(e => e.LineOfBusinessUserRelId)
                    .HasColumnName("LineOfBusinessUserRel_ID")
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineOfBusinessId).HasColumnName("LineOfBusiness_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.LineOfBusiness)
                    .WithMany(p => p.LineOfBusinessUserRel)
                    .HasForeignKey(d => d.LineOfBusinessId)
                    .HasConstraintName("FK_LineOfBusinessUserRel_LineOfBusiness");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LineOfBusinessUserRel)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_LineOfBusinessUserRel_User");
            });

            modelBuilder.Entity<LocationType>(entity =>
            {
                entity.Property(e => e.LocationTypeId).HasColumnName("LocationType_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.MessageId)
                    .HasColumnName("Message_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreateSystem).HasMaxLength(50);

                entity.Property(e => e.MessageTypeId).HasColumnName("MessageType_ID");

                entity.Property(e => e.NotificationId).HasColumnName("Notification_ID");

                entity.Property(e => e.Payload).IsUnicode(false);

                entity.HasOne(d => d.MessageType)
                    .WithMany(p => p.Message)
                    .HasForeignKey(d => d.MessageTypeId)
                    .HasConstraintName("FK_Message_MessageType");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.Message)
                    .HasForeignKey(d => d.NotificationId)
                    .HasConstraintName("FK_Message_Notification");
            });

            modelBuilder.Entity<MessageType>(entity =>
            {
                entity.Property(e => e.MessageTypeId).HasColumnName("MessageType_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Metadata>(entity =>
            {
                entity.Property(e => e.MetadataId)
                    .HasColumnName("Metadata_ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BeaconGuid).HasColumnName("BeaconGUID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionProcessId).HasColumnName("InspectionProcess_ID");

                entity.Property(e => e.WeatherTypeId).HasColumnName("WeatherType_ID");

                entity.HasOne(d => d.InspectionProcess)
                    .WithMany(p => p.Metadata)
                    .HasForeignKey(d => d.InspectionProcessId)
                    .HasConstraintName("FK_Metadata_InspectionProcess");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.Property(e => e.NotificationId)
                    .HasColumnName("Notification_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationType_ID");

                entity.Property(e => e.SentTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.NotificationType)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.NotificationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notifications_NotificationType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Notification_User");
            });

            modelBuilder.Entity<NotificationType>(entity =>
            {
                entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationType_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<OperatorCertification>(entity =>
            {
                entity.HasKey(e => e.OperaratorCertificationId);

                entity.Property(e => e.OperaratorCertificationId)
                    .HasColumnName("OperaratorCertification_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlertDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LegacyCertificationId)
                    .HasColumnName("LegacyCertification_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.OperatorCertificationTypeId).HasColumnName("OperatorCertificationType_ID");

                entity.Property(e => e.StartDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.OperatorCertificationType)
                    .WithMany(p => p.OperatorCertification)
                    .HasForeignKey(d => d.OperatorCertificationTypeId)
                    .HasConstraintName("FK_OperatorCertification_OperatorCertificationType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OperatorCertification)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserCertification_User");
            });

            modelBuilder.Entity<OperatorCertificationType>(entity =>
            {
                entity.Property(e => e.OperatorCertificationTypeId).HasColumnName("OperatorCertificationType_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.Property(e => e.OrganizationId)
                    .HasColumnName("Organization_ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndustryTypeId).HasColumnName("IndustryType_ID");

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteLocationId).HasColumnName("SiteLocation_ID");

                entity.HasOne(d => d.IndustryType)
                    .WithMany(p => p.Organization)
                    .HasForeignKey(d => d.IndustryTypeId)
                    .HasConstraintName("FK_Organization_IndustryType");

                entity.HasOne(d => d.SiteLocation)
                    .WithMany(p => p.Organization)
                    .HasForeignKey(d => d.SiteLocationId)
                    .HasConstraintName("FK_Organization_SiteLocation");
            });

            modelBuilder.Entity<ProcessType>(entity =>
            {
                entity.Property(e => e.ProcessTypeId).HasColumnName("ProcessType_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<ProvinceLookup>(entity =>
            {
                entity.HasKey(e => e.ProvinceId);

                entity.Property(e => e.ProvinceId).HasColumnName("Province_ID");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ProvinceLookup)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_ProvinceLookup_CountryLookup");
            });

            modelBuilder.Entity<ResolutionDetail>(entity =>
            {
                entity.Property(e => e.ResolutionDetailId)
                    .HasColumnName("ResolutionDetail_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnType("numeric(8, 2)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ErpsystemId)
                    .HasColumnName("ERPSystem_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("Invoice_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.IssueManagementId).HasColumnName("IssueManagement_ID");

                entity.Property(e => e.IssueTypeId).HasColumnName("IssueType_ID");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser).HasMaxLength(50);

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.ResolutionDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.ResolutionNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IssueManagement)
                    .WithMany(p => p.ResolutionDetail)
                    .HasForeignKey(d => d.IssueManagementId)
                    .HasConstraintName("FK_ResolutionDetail_IssueManagement");
            });

            modelBuilder.Entity<SeverityType>(entity =>
            {
                entity.Property(e => e.SeverityTypeId).HasColumnName("SeverityType_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<SiteLocation>(entity =>
            {
                entity.Property(e => e.SiteLocationId)
                    .HasColumnName("SiteLocation_ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude).HasColumnType("numeric(8, 5)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(8, 5)");

                entity.Property(e => e.ProvinceId).HasColumnName("Province_ID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.SiteLocation)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_SiteLocation_CityLookup");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.SiteLocation)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_SiteLocation_CountryLookup");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.SiteLocation)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_SiteLocation_ProvinceLookup");
            });

            modelBuilder.Entity<StepType>(entity =>
            {
                entity.Property(e => e.StepTypeId).HasColumnName("StepType_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineOfBusinessId).HasColumnName("LineOfBusiness_ID");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserConfig)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeId).HasColumnName("UserType_ID");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK_User_UserType");
            });

            modelBuilder.Entity<UserBehavior>(entity =>
            {
                entity.Property(e => e.UserBehaviorId)
                    .HasColumnName("UserBehavior_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AverageInspectionScore).HasColumnType("numeric(8, 2)");

                entity.Property(e => e.AverageInspectionTime).HasColumnType("numeric(8, 1)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstInspectionDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastInspectionDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserBehavior)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserBehavior_User");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.UserTypeId).HasColumnName("UserType_ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastModSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(20);
            });
        }
    }
}
