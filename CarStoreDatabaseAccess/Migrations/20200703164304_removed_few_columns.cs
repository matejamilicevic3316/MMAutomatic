using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreDatabaseAccess.Migrations
{
    public partial class removed_few_columns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Towns_Regions_IdRegion",
                table: "Towns");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Towns_IdTown",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Towns_IdRegion",
                table: "Towns");

            migrationBuilder.DropColumn(
                name: "IdRegion",
                table: "Towns");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 678, DateTimeKind.Local).AddTicks(6949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 7, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 678, DateTimeKind.Local).AddTicks(6696),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 7, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypeProducers",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 680, DateTimeKind.Local).AddTicks(3460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 8, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypeProducers",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 680, DateTimeKind.Local).AddTicks(3192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 8, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypeAllowedFeatures",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 677, DateTimeKind.Local).AddTicks(3658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 5, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypeAllowedFeatures",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 677, DateTimeKind.Local).AddTicks(3386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 5, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileSeries",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 675, DateTimeKind.Local).AddTicks(9752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 3, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileSeries",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 675, DateTimeKind.Local).AddTicks(9488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 3, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 672, DateTimeKind.Local).AddTicks(8691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 0, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 672, DateTimeKind.Local).AddTicks(8407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 0, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModelFeatures",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 674, DateTimeKind.Local).AddTicks(3899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 2, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModelFeatures",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 674, DateTimeKind.Local).AddTicks(3637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 2, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 665, DateTimeKind.Local).AddTicks(2767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 998, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.AlterColumn<int>(
                name: "IdTown",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 665, DateTimeKind.Local).AddTicks(2245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 998, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 663, DateTimeKind.Local).AddTicks(4216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 996, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 663, DateTimeKind.Local).AddTicks(3960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 996, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 661, DateTimeKind.Local).AddTicks(9891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 994, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 661, DateTimeKind.Local).AddTicks(9611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 994, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Producers",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 660, DateTimeKind.Local).AddTicks(5583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 992, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Producers",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 660, DateTimeKind.Local).AddTicks(5329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 992, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 658, DateTimeKind.Local).AddTicks(4422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 991, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 658, DateTimeKind.Local).AddTicks(4148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 991, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 644, DateTimeKind.Local).AddTicks(6623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 970, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 639, DateTimeKind.Local).AddTicks(1946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 963, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "AdFeatureValues",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 657, DateTimeKind.Local).AddTicks(333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 983, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "AdFeatureValues",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 657, DateTimeKind.Local).AddTicks(39),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 983, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Towns_IdTown",
                table: "Users",
                column: "IdTown",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Towns_IdTown",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 7, DateTimeKind.Local).AddTicks(1319),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 678, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 7, DateTimeKind.Local).AddTicks(1044),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 678, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypeProducers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 8, DateTimeKind.Local).AddTicks(7811),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 680, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypeProducers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 8, DateTimeKind.Local).AddTicks(7539),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 680, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypeAllowedFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 5, DateTimeKind.Local).AddTicks(3489),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 677, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypeAllowedFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 5, DateTimeKind.Local).AddTicks(3177),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 677, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileSeries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 3, DateTimeKind.Local).AddTicks(9987),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 675, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileSeries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 3, DateTimeKind.Local).AddTicks(9380),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 675, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 0, DateTimeKind.Local).AddTicks(9552),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 672, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 0, DateTimeKind.Local).AddTicks(9287),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 672, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModelFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 2, DateTimeKind.Local).AddTicks(4318),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 674, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModelFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 2, DateTimeKind.Local).AddTicks(3897),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 674, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 998, DateTimeKind.Local).AddTicks(2924),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 665, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.AlterColumn<int>(
                name: "IdTown",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 998, DateTimeKind.Local).AddTicks(2645),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 665, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 996, DateTimeKind.Local).AddTicks(4798),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 663, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 996, DateTimeKind.Local).AddTicks(4504),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 663, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.AddColumn<int>(
                name: "IdRegion",
                table: "Towns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 994, DateTimeKind.Local).AddTicks(9548),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 661, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 994, DateTimeKind.Local).AddTicks(9310),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 661, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Producers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 992, DateTimeKind.Local).AddTicks(8042),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 660, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Producers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 992, DateTimeKind.Local).AddTicks(7795),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 660, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 991, DateTimeKind.Local).AddTicks(2590),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 658, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 991, DateTimeKind.Local).AddTicks(2280),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 658, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 970, DateTimeKind.Local).AddTicks(1934),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 644, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 963, DateTimeKind.Local).AddTicks(5824),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 639, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "AdFeatureValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 983, DateTimeKind.Local).AddTicks(2458),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 657, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "AdFeatureValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 983, DateTimeKind.Local).AddTicks(2114),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 3, 18, 43, 4, 657, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 984, DateTimeKind.Local).AddTicks(6435)),
                    DeleteDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 984, DateTimeKind.Local).AddTicks(6724))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 994, DateTimeKind.Local).AddTicks(216)),
                    DeleteDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    IdCountry = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 994, DateTimeKind.Local).AddTicks(465)),
                    RegionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_Towns_IdRegion",
                table: "Towns",
                column: "IdRegion");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Towns_Regions_IdRegion",
                table: "Towns",
                column: "IdRegion",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Towns_IdTown",
                table: "Users",
                column: "IdTown",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
