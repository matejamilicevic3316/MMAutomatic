using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreDatabaseAccess.Migrations
{
    public partial class jako : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "Roles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 7, DateTimeKind.Local).AddTicks(1319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 232, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 7, DateTimeKind.Local).AddTicks(1044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 232, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypeProducers",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 8, DateTimeKind.Local).AddTicks(7811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 243, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypeProducers",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 8, DateTimeKind.Local).AddTicks(7539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 243, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypeAllowedFeatures",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 5, DateTimeKind.Local).AddTicks(3489),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 229, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypeAllowedFeatures",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 5, DateTimeKind.Local).AddTicks(3177),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 229, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileSeries",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 3, DateTimeKind.Local).AddTicks(9987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 226, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileSeries",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 3, DateTimeKind.Local).AddTicks(9380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 226, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 0, DateTimeKind.Local).AddTicks(9552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 220, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 0, DateTimeKind.Local).AddTicks(9287),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 220, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModelFeatures",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 2, DateTimeKind.Local).AddTicks(4318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 223, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModelFeatures",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 2, DateTimeKind.Local).AddTicks(3897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 222, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 998, DateTimeKind.Local).AddTicks(2924),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 214, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 998, DateTimeKind.Local).AddTicks(2645),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 214, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 996, DateTimeKind.Local).AddTicks(4798),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 210, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 996, DateTimeKind.Local).AddTicks(4504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 209, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 994, DateTimeKind.Local).AddTicks(9548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 207, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 994, DateTimeKind.Local).AddTicks(9310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 207, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Roles",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Regions",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 994, DateTimeKind.Local).AddTicks(465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 204, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Regions",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 994, DateTimeKind.Local).AddTicks(216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 203, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Producers",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 992, DateTimeKind.Local).AddTicks(8042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 200, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Producers",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 992, DateTimeKind.Local).AddTicks(7795),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 200, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 991, DateTimeKind.Local).AddTicks(2590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 196, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 991, DateTimeKind.Local).AddTicks(2280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 196, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Countries",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 984, DateTimeKind.Local).AddTicks(6724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 176, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Countries",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 984, DateTimeKind.Local).AddTicks(6435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 176, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 970, DateTimeKind.Local).AddTicks(1934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 133, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 963, DateTimeKind.Local).AddTicks(5824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 116, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "AdFeatureValues",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 983, DateTimeKind.Local).AddTicks(2458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 172, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "AdFeatureValues",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 983, DateTimeKind.Local).AddTicks(2114),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 172, DateTimeKind.Local).AddTicks(952));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Roles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 232, DateTimeKind.Local).AddTicks(2758),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 7, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 232, DateTimeKind.Local).AddTicks(2219),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 7, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypeProducers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 243, DateTimeKind.Local).AddTicks(6738),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 8, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypeProducers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 243, DateTimeKind.Local).AddTicks(6042),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 8, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypeAllowedFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 229, DateTimeKind.Local).AddTicks(6244),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 5, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypeAllowedFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 229, DateTimeKind.Local).AddTicks(5708),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 5, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileSeries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 226, DateTimeKind.Local).AddTicks(8806),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 3, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileSeries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 226, DateTimeKind.Local).AddTicks(8226),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 3, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 220, DateTimeKind.Local).AddTicks(856),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 0, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 220, DateTimeKind.Local).AddTicks(276),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 0, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModelFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 223, DateTimeKind.Local).AddTicks(576),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 2, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModelFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 222, DateTimeKind.Local).AddTicks(9950),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 1, 2, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 214, DateTimeKind.Local).AddTicks(2258),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 998, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 214, DateTimeKind.Local).AddTicks(1598),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 998, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 210, DateTimeKind.Local).AddTicks(327),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 996, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 209, DateTimeKind.Local).AddTicks(9794),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 996, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 207, DateTimeKind.Local).AddTicks(763),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 994, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 207, DateTimeKind.Local).AddTicks(208),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 994, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                table: "Roles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Regions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 204, DateTimeKind.Local).AddTicks(694),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 994, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Regions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 203, DateTimeKind.Local).AddTicks(9434),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 994, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Producers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 200, DateTimeKind.Local).AddTicks(1471),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 992, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Producers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 200, DateTimeKind.Local).AddTicks(839),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 992, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 196, DateTimeKind.Local).AddTicks(4289),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 991, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 196, DateTimeKind.Local).AddTicks(3604),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 991, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 176, DateTimeKind.Local).AddTicks(6737),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 984, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 176, DateTimeKind.Local).AddTicks(5922),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 984, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 133, DateTimeKind.Local).AddTicks(1406),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 970, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 116, DateTimeKind.Local).AddTicks(919),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 963, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "AdFeatureValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 172, DateTimeKind.Local).AddTicks(1657),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 983, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "AdFeatureValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 13, 0, 26, 50, 172, DateTimeKind.Local).AddTicks(952),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 13, 22, 42, 0, 983, DateTimeKind.Local).AddTicks(2114));
        }
    }
}
