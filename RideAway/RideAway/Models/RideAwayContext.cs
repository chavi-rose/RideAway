using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RideAway.Models
{
    public partial class RideAwayContext : DbContext
    {
        public RideAwayContext()
        {
        }

        public RideAwayContext(DbContextOptions<RideAwayContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agency> Agency { get; set; }
        public virtual DbSet<Calendar> Calendar { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Passenger> Passenger { get; set; }
        public virtual DbSet<ReasonOfDelay> ReasonOfDelay { get; set; }
        public virtual DbSet<Routes> Routes { get; set; }
        public virtual DbSet<StopTimes> StopTimes { get; set; }
        public virtual DbSet<Stops> Stops { get; set; }
        public virtual DbSet<Trips> Trips { get; set; }
        public virtual DbSet<Trips1> Trips1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-IQUC79O;Database=RideAway;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agency>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("agency");

                entity.Property(e => e.AgencyFareUrl)
                    .HasColumnName("agency_fare_url")
                    .HasMaxLength(1);

                entity.Property(e => e.AgencyId).HasColumnName("agency_id");

                entity.Property(e => e.AgencyLang)
                    .IsRequired()
                    .HasColumnName("agency_lang")
                    .HasMaxLength(50);

                entity.Property(e => e.AgencyName)
                    .IsRequired()
                    .HasColumnName("agency_name")
                    .HasMaxLength(50);

                entity.Property(e => e.AgencyPhone)
                    .HasColumnName("agency_phone")
                    .HasMaxLength(1);

                entity.Property(e => e.AgencyTimezone)
                    .IsRequired()
                    .HasColumnName("agency_timezone")
                    .HasMaxLength(50);

                entity.Property(e => e.AgencyUrl)
                    .IsRequired()
                    .HasColumnName("agency_url")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("calendar");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.Friday).HasColumnName("friday");

                entity.Property(e => e.Monday).HasColumnName("monday");

                entity.Property(e => e.Saturday).HasColumnName("saturday");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Sunday).HasColumnName("sunday");

                entity.Property(e => e.Thursday).HasColumnName("thursday");

                entity.Property(e => e.Tuesday).HasColumnName("tuesday");

                entity.Property(e => e.Wednesday).HasColumnName("wednesday");
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.ToTable("comments");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.FromStopId).HasColumnName("from_stop_id");

                entity.Property(e => e.FromTime)
                    .HasColumnName("from_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.ToStopId).HasColumnName("to_stop_id");

                entity.Property(e => e.ToTime)
                    .HasColumnName("to_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Passenger>(entity =>
            {
                entity.ToTable("passenger");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DestinationRouteId).HasColumnName("destination_route_id");

                entity.Property(e => e.DestinationStationId).HasColumnName("destination_station_id");

                entity.Property(e => e.IdentityNumber).HasColumnName("identity_number");

                entity.Property(e => e.RavKavId)
                    .HasColumnName("rav_kav_id")
                    .IsUnicode(false);

                entity.Property(e => e.ReasonOfDelayId).HasColumnName("reason_of_delay_id");

                entity.Property(e => e.SourceStationId).HasColumnName("source_station_id");

                entity.Property(e => e.ValidationDate)
                    .HasColumnName("validation_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ReasonOfDelay>(entity =>
            {
                entity.HasKey(e => e.ReasonId);

                entity.ToTable("reason_of_delay");

                entity.Property(e => e.ReasonId).HasColumnName("reason_id");

                entity.Property(e => e.IsResetWaitingTime).HasColumnName("is_reset_waiting_time");

                entity.Property(e => e.ReasonDescription)
                    .IsRequired()
                    .HasColumnName("reason_description")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Routes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("routes");

                entity.Property(e => e.AgencyId).HasColumnName("agency_id");

                entity.Property(e => e.RouteColor)
                    .HasColumnName("route_color")
                    .HasMaxLength(50);

                entity.Property(e => e.RouteDesc)
                    .IsRequired()
                    .HasColumnName("route_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.RouteId).HasColumnName("route_id");

                entity.Property(e => e.RouteLongName)
                    .IsRequired()
                    .HasColumnName("route_long_name")
                    .HasMaxLength(100);

                entity.Property(e => e.RouteShortName)
                    .IsRequired()
                    .HasColumnName("route_short_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RouteType).HasColumnName("route_type");
            });

            modelBuilder.Entity<StopTimes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stop_times");

                entity.Property(e => e.ArrivalTime)
                    .IsRequired()
                    .HasColumnName("arrival_time")
                    .HasMaxLength(50);

                entity.Property(e => e.DepartureTime)
                    .IsRequired()
                    .HasColumnName("departure_time")
                    .HasMaxLength(50);

                entity.Property(e => e.DropOffType).HasColumnName("drop_off_type");

                entity.Property(e => e.PickupType).HasColumnName("pickup_type");

                entity.Property(e => e.ShapeDistTraveled).HasColumnName("shape_dist_traveled");

                entity.Property(e => e.StopId).HasColumnName("stop_id");

                entity.Property(e => e.StopSequence).HasColumnName("stop_sequence");

                entity.Property(e => e.TripId)
                    .IsRequired()
                    .HasColumnName("trip_id")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Stops>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stops");

                entity.Property(e => e.LocationType).HasColumnName("location_type");

                entity.Property(e => e.ParentStation)
                    .HasColumnName("parent_station")
                    .HasMaxLength(1);

                entity.Property(e => e.StopCode).HasColumnName("stop_code");

                entity.Property(e => e.StopDesc)
                    .IsRequired()
                    .HasColumnName("stop_desc")
                    .HasMaxLength(100);

                entity.Property(e => e.StopId).HasColumnName("stop_id");

                entity.Property(e => e.StopLat).HasColumnName("stop_lat");

                entity.Property(e => e.StopLon).HasColumnName("stop_lon");

                entity.Property(e => e.StopName)
                    .IsRequired()
                    .HasColumnName("stop_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ZoneId).HasColumnName("zone_id");
            });

            modelBuilder.Entity<Trips>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trips");

                entity.Property(e => e.DirectionId).HasColumnName("direction_id");

                entity.Property(e => e.RouteId).HasColumnName("route_id");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.ShapeId).HasColumnName("shape_id");

                entity.Property(e => e.TripHeadsign)
                    .IsRequired()
                    .HasColumnName("trip_headsign")
                    .HasMaxLength(50);

                entity.Property(e => e.TripId)
                    .IsRequired()
                    .HasColumnName("trip_id")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Trips1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trips1");

                entity.Property(e => e.DirectionId).HasColumnName("direction_id");

                entity.Property(e => e.RouteId).HasColumnName("route_id");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.ShapeId).HasColumnName("shape_id");

                entity.Property(e => e.TripHeadsign)
                    .IsRequired()
                    .HasColumnName("trip_headsign")
                    .HasMaxLength(50);

                entity.Property(e => e.TripId)
                    .IsRequired()
                    .HasColumnName("trip_id")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
