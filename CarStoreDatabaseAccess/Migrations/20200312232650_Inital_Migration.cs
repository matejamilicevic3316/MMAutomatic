using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreDatabaseAccess.Migrations
{
    public partial class Inital_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 176, DateTimeKind.Local).AddTicks(5922)),
                    ModifiedDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 176, DateTimeKind.Local).AddTicks(6737)),
                    DeleteDateTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    CountryName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 196, DateTimeKind.Local).AddTicks(3604)),
                    ModifiedDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 196, DateTimeKind.Local).AddTicks(4289)),
                    DeleteDateTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    FeatureName = table.Column<string>(nullable: true),
                    ValueType = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 200, DateTimeKind.Local).AddTicks(839)),
                    ModifiedDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 200, DateTimeKind.Local).AddTicks(1471)),
                    DeleteDateTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ProducerName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 207, DateTimeKind.Local).AddTicks(208)),
                    ModifiedDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 207, DateTimeKind.Local).AddTicks(763)),
                    DeleteDateTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    RoleName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehcileTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 232, DateTimeKind.Local).AddTicks(2219)),
                    ModifiedDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 232, DateTimeKind.Local).AddTicks(2758)),
                    DeleteDateTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    VehcileTypeName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehcileTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 203, DateTimeKind.Local).AddTicks(9434)),
                    ModifiedDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 204, DateTimeKind.Local).AddTicks(694)),
                    DeleteDateTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    RegionName = table.Column<string>(maxLength: 100, nullable: true),
                    IdCountry = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regions_Countries_IdCountry",
                        column: x => x.IdCountry,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehcileTypeAllowedFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 229, DateTimeKind.Local).AddTicks(5708)),
                    ModifiedDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 229, DateTimeKind.Local).AddTicks(6244)),
                    DeleteDateTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IdVehcileType = table.Column<int>(nullable: false),
                    IdFeature = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehcileTypeAllowedFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehcileTypeAllowedFeatures_Features_IdFeature",
                        column: x => x.IdFeature,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehcileTypeAllowedFeatures_VehcileTypes_IdVehcileType",
                        column: x => x.IdVehcileType,
                        principalTable: "VehcileTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehcileTypeProducers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 243, DateTimeKind.Local).AddTicks(6042)),
                    ModifiedDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 243, DateTimeKind.Local).AddTicks(6738)),
                    DeleteDateTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IdVehcileType = table.Column<int>(nullable: false),
                    IdProducer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehcileTypeProducers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehcileTypeProducers_Producers_IdProducer",
                        column: x => x.IdProducer,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehcileTypeProducers_VehcileTypes_IdVehcileType",
                        column: x => x.IdVehcileType,
                        principalTable: "VehcileTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 209, DateTimeKind.Local).AddTicks(9794)),
                    ModifiedDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 210, DateTimeKind.Local).AddTicks(327)),
                    DeleteDateTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    TownName = table.Column<string>(maxLength: 100, nullable: true),
                    IdRegion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Towns_Regions_IdRegion",
                        column: x => x.IdRegion,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehcileSeries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 226, DateTimeKind.Local).AddTicks(8226)),
                    ModifiedDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 226, DateTimeKind.Local).AddTicks(8806)),
                    DeleteDateTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    VehcileSeriesName = table.Column<string>(maxLength: 50, nullable: true),
                    VehcileDisplayPrefix = table.Column<string>(maxLength: 50, nullable: true),
                    IdVehcileTypeProducer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehcileSeries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehcileSeries_VehcileTypeProducers_IdVehcileTypeProducer",
                        column: x => x.IdVehcileTypeProducer,
                        principalTable: "VehcileTypeProducers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 214, DateTimeKind.Local).AddTicks(1598)),
                    ModifiedDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 214, DateTimeKind.Local).AddTicks(2258)),
                    DeleteDateTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    UserAddress = table.Column<string>(nullable: true),
                    IdRole = table.Column<int>(nullable: false),
                    IdTown = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_IdRole",
                        column: x => x.IdRole,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Towns_IdTown",
                        column: x => x.IdTown,
                        principalTable: "Towns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehcileModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 220, DateTimeKind.Local).AddTicks(276)),
                    ModifiedDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 220, DateTimeKind.Local).AddTicks(856)),
                    DeleteDateTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IdVehcileSeries = table.Column<int>(nullable: false),
                    VehcileNameSuffix = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehcileModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehcileModels_VehcileSeries_IdVehcileSeries",
                        column: x => x.IdVehcileSeries,
                        principalTable: "VehcileSeries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 116, DateTimeKind.Local).AddTicks(919)),
                    ModifiedDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 133, DateTimeKind.Local).AddTicks(1406)),
                    DeleteDateTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IdVehcileModel = table.Column<int>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Discount = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ads_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ads_VehcileModels_IdVehcileModel",
                        column: x => x.IdVehcileModel,
                        principalTable: "VehcileModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehcileModelFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 222, DateTimeKind.Local).AddTicks(9950)),
                    ModifiedDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 223, DateTimeKind.Local).AddTicks(576)),
                    DeleteDateTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IdFeature = table.Column<int>(nullable: false),
                    IdVehcileModel = table.Column<int>(nullable: false),
                    MinValue = table.Column<decimal>(nullable: true),
                    MaxValue = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehcileModelFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehcileModelFeatures_Features_IdFeature",
                        column: x => x.IdFeature,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehcileModelFeatures_VehcileModels_IdVehcileModel",
                        column: x => x.IdVehcileModel,
                        principalTable: "VehcileModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdFeatureValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 172, DateTimeKind.Local).AddTicks(952)),
                    ModifiedDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 172, DateTimeKind.Local).AddTicks(1657)),
                    DeleteDateTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IdAd = table.Column<int>(nullable: false),
                    IdFeature = table.Column<int>(nullable: false),
                    Value = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdFeatureValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdFeatureValues_Ads_IdAd",
                        column: x => x.IdAd,
                        principalTable: "Ads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdFeatureValues_Features_IdFeature",
                        column: x => x.IdFeature,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdFeatureValues_IdAd",
                table: "AdFeatureValues",
                column: "IdAd");

            migrationBuilder.CreateIndex(
                name: "IX_AdFeatureValues_IdFeature",
                table: "AdFeatureValues",
                column: "IdFeature");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_IdUser",
                table: "Ads",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_IdVehcileModel",
                table: "Ads",
                column: "IdVehcileModel");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CountryName",
                table: "Countries",
                column: "CountryName",
                unique: true,
                filter: "[CountryName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Regions_IdCountry",
                table: "Regions",
                column: "IdCountry");

            migrationBuilder.CreateIndex(
                name: "IX_Towns_IdRegion",
                table: "Towns",
                column: "IdRegion");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdRole",
                table: "Users",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdTown",
                table: "Users",
                column: "IdTown");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VehcileModelFeatures_IdFeature",
                table: "VehcileModelFeatures",
                column: "IdFeature");

            migrationBuilder.CreateIndex(
                name: "IX_VehcileModelFeatures_IdVehcileModel",
                table: "VehcileModelFeatures",
                column: "IdVehcileModel");

            migrationBuilder.CreateIndex(
                name: "IX_VehcileModels_IdVehcileSeries",
                table: "VehcileModels",
                column: "IdVehcileSeries");

            migrationBuilder.CreateIndex(
                name: "IX_VehcileSeries_IdVehcileTypeProducer",
                table: "VehcileSeries",
                column: "IdVehcileTypeProducer");

            migrationBuilder.CreateIndex(
                name: "IX_VehcileTypeAllowedFeatures_IdFeature",
                table: "VehcileTypeAllowedFeatures",
                column: "IdFeature");

            migrationBuilder.CreateIndex(
                name: "IX_VehcileTypeAllowedFeatures_IdVehcileType",
                table: "VehcileTypeAllowedFeatures",
                column: "IdVehcileType");

            migrationBuilder.CreateIndex(
                name: "IX_VehcileTypeProducers_IdProducer",
                table: "VehcileTypeProducers",
                column: "IdProducer");

            migrationBuilder.CreateIndex(
                name: "IX_VehcileTypeProducers_IdVehcileType",
                table: "VehcileTypeProducers",
                column: "IdVehcileType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdFeatureValues");

            migrationBuilder.DropTable(
                name: "VehcileModelFeatures");

            migrationBuilder.DropTable(
                name: "VehcileTypeAllowedFeatures");

            migrationBuilder.DropTable(
                name: "Ads");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VehcileModels");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DropTable(
                name: "VehcileSeries");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "VehcileTypeProducers");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Producers");

            migrationBuilder.DropTable(
                name: "VehcileTypes");
        }
    }
}
