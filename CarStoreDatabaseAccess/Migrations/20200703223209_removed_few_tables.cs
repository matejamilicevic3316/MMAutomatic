using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreDatabaseAccess.Migrations
{
    public partial class removed_few_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehcileModels_VehcileSeries_IdVehcileSeries",
                table: "VehcileModels");

            migrationBuilder.DropTable(
                name: "VehcileModelFeatures");

            migrationBuilder.DropTable(
                name: "VehcileSeries");

            migrationBuilder.DropTable(
                name: "VehcileTypeAllowedFeatures");

            migrationBuilder.DropTable(
                name: "VehcileTypeProducers");

            migrationBuilder.DropTable(
                name: "Producers");

            migrationBuilder.DropIndex(
                name: "IX_VehcileModels_IdVehcileSeries",
                table: "VehcileModels");

            migrationBuilder.DropColumn(
                name: "IdVehcileSeries",
                table: "VehcileModels");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 709, DateTimeKind.Local).AddTicks(2055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 678, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 709, DateTimeKind.Local).AddTicks(1821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 678, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 708, DateTimeKind.Local).AddTicks(367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 672, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 708, DateTimeKind.Local).AddTicks(79),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 672, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.AddColumn<int>(
                name: "VehicleTypeId",
                table: "VehcileModels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 700, DateTimeKind.Local).AddTicks(6261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 665, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 700, DateTimeKind.Local).AddTicks(5951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 665, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 698, DateTimeKind.Local).AddTicks(7510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 663, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 698, DateTimeKind.Local).AddTicks(7245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 663, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 697, DateTimeKind.Local).AddTicks(3513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 661, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 697, DateTimeKind.Local).AddTicks(3245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 661, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 695, DateTimeKind.Local).AddTicks(6302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 658, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 695, DateTimeKind.Local).AddTicks(6060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 658, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 686, DateTimeKind.Local).AddTicks(8054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 644, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 681, DateTimeKind.Local).AddTicks(6171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 639, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "AdFeatureValues",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 694, DateTimeKind.Local).AddTicks(5533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 657, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "AdFeatureValues",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 694, DateTimeKind.Local).AddTicks(5276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 657, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.CreateIndex(
                name: "IX_VehcileModels_VehicleTypeId",
                table: "VehcileModels",
                column: "VehicleTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehcileModels_VehcileTypes_VehicleTypeId",
                table: "VehcileModels",
                column: "VehicleTypeId",
                principalTable: "VehcileTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehcileModels_VehcileTypes_VehicleTypeId",
                table: "VehcileModels");

            migrationBuilder.DropIndex(
                name: "IX_VehcileModels_VehicleTypeId",
                table: "VehcileModels");

            migrationBuilder.DropColumn(
                name: "VehicleTypeId",
                table: "VehcileModels");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 678, DateTimeKind.Local).AddTicks(6949),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 709, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 678, DateTimeKind.Local).AddTicks(6696),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 709, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 672, DateTimeKind.Local).AddTicks(8691),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 708, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 672, DateTimeKind.Local).AddTicks(8407),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 708, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.AddColumn<int>(
                name: "IdVehcileSeries",
                table: "VehcileModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 665, DateTimeKind.Local).AddTicks(2767),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 700, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 665, DateTimeKind.Local).AddTicks(2245),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 700, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 663, DateTimeKind.Local).AddTicks(4216),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 698, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 663, DateTimeKind.Local).AddTicks(3960),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 698, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 661, DateTimeKind.Local).AddTicks(9891),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 697, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 661, DateTimeKind.Local).AddTicks(9611),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 697, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 658, DateTimeKind.Local).AddTicks(4422),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 695, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 658, DateTimeKind.Local).AddTicks(4148),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 695, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 644, DateTimeKind.Local).AddTicks(6623),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 686, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 639, DateTimeKind.Local).AddTicks(1946),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 681, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "AdFeatureValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 657, DateTimeKind.Local).AddTicks(333),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 694, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "AdFeatureValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 657, DateTimeKind.Local).AddTicks(39),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 694, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 660, DateTimeKind.Local).AddTicks(5329)),
                    DeleteDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 660, DateTimeKind.Local).AddTicks(5583)),
                    ProducerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehcileModelFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 674, DateTimeKind.Local).AddTicks(3637)),
                    DeleteDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    IdFeature = table.Column<int>(type: "int", nullable: false),
                    IdVehcileModel = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    MaxValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MinValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 674, DateTimeKind.Local).AddTicks(3899))
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
                name: "VehcileTypeAllowedFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 677, DateTimeKind.Local).AddTicks(3386)),
                    DeleteDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    IdFeature = table.Column<int>(type: "int", nullable: false),
                    IdVehcileType = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 677, DateTimeKind.Local).AddTicks(3658))
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 680, DateTimeKind.Local).AddTicks(3192)),
                    DeleteDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    IdProducer = table.Column<int>(type: "int", nullable: false),
                    IdVehcileType = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 680, DateTimeKind.Local).AddTicks(3460))
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
                name: "VehcileSeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 675, DateTimeKind.Local).AddTicks(9488)),
                    DeleteDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    IdVehcileTypeProducer = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 675, DateTimeKind.Local).AddTicks(9752)),
                    VehcileDisplayPrefix = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VehcileSeriesName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_VehcileModels_IdVehcileSeries",
                table: "VehcileModels",
                column: "IdVehcileSeries");

            migrationBuilder.CreateIndex(
                name: "IX_VehcileModelFeatures_IdFeature",
                table: "VehcileModelFeatures",
                column: "IdFeature");

            migrationBuilder.CreateIndex(
                name: "IX_VehcileModelFeatures_IdVehcileModel",
                table: "VehcileModelFeatures",
                column: "IdVehcileModel");

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

            migrationBuilder.AddForeignKey(
                name: "FK_VehcileModels_VehcileSeries_IdVehcileSeries",
                table: "VehcileModels",
                column: "IdVehcileSeries",
                principalTable: "VehcileSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
