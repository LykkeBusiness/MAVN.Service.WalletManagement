// <auto-generated />
using System;
using MAVN.Service.WalletManagement.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAVN.Service.WalletManagement.MsSqlRepositories.Migrations
{
    [DbContext(typeof(WalletManagementContext))]
    partial class WalletManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("wallet_management")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAVN.Service.WalletManagement.MsSqlRepositories.Entities.BonusIssuedEventDataEntity", b =>
                {
                    b.Property<Guid>("OperationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("operation_id");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnName("amount");

                    b.Property<string>("BonusType")
                        .HasColumnName("bonus_type");

                    b.Property<Guid>("CampaignId")
                        .HasColumnName("campaign_id");

                    b.Property<Guid>("ConditionId")
                        .HasColumnName("condition_id");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("customer_id");

                    b.Property<string>("LocationId")
                        .HasColumnName("location_id");

                    b.Property<string>("PartnerId")
                        .HasColumnName("partner_id");

                    b.Property<string>("ReferralId")
                        .HasColumnName("referral_id");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnName("timestamp");

                    b.Property<string>("UnitLocationCode")
                        .HasColumnName("location_code");

                    b.HasKey("OperationId");

                    b.ToTable("bonus_event_data");
                });

            modelBuilder.Entity("MAVN.Service.WalletManagement.MsSqlRepositories.Entities.TransferEventDataEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnName("amount");

                    b.Property<string>("AssetSymbol")
                        .IsRequired()
                        .HasColumnName("asset_symbol");

                    b.Property<string>("ExternalOperationId")
                        .HasColumnName("external_operation_id");

                    b.Property<string>("OperationId")
                        .IsRequired()
                        .HasColumnName("operation_id");

                    b.Property<string>("RecipientCustomerId")
                        .IsRequired()
                        .HasColumnName("recipient_customer_id");

                    b.Property<string>("SenderCustomerId")
                        .IsRequired()
                        .HasColumnName("sender_customer_id");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnName("timestamp");

                    b.HasKey("Id");

                    b.ToTable("transfer_event_data");
                });

            modelBuilder.Entity("MAVN.Service.WalletManagement.MsSqlRepositories.Entities.WalletFlagsEntity", b =>
                {
                    b.Property<string>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("customer_id");

                    b.Property<bool>("IsBlocked")
                        .HasColumnName("is_blocked");

                    b.HasKey("CustomerId");

                    b.ToTable("wallet_flags");
                });
#pragma warning restore 612, 618
        }
    }
}
