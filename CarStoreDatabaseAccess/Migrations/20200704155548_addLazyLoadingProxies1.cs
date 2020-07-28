using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreDatabaseAccess.Migrations
{
    public partial class addLazyLoadingProxies1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 990, DateTimeKind.Local).AddTicks(2465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 44, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 990, DateTimeKind.Local).AddTicks(2202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 43, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 988, DateTimeKind.Local).AddTicks(9223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 42, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 988, DateTimeKind.Local).AddTicks(8916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 42, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 981, DateTimeKind.Local).AddTicks(1434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 35, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 981, DateTimeKind.Local).AddTicks(1160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 35, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 979, DateTimeKind.Local).AddTicks(3182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 33, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 979, DateTimeKind.Local).AddTicks(2918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 33, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 977, DateTimeKind.Local).AddTicks(8975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 31, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 977, DateTimeKind.Local).AddTicks(8703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 31, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 976, DateTimeKind.Local).AddTicks(1738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 30, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 976, DateTimeKind.Local).AddTicks(1450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 30, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 966, DateTimeKind.Local).AddTicks(2652),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 21, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 960, DateTimeKind.Local).AddTicks(7187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 15, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "AdFeatureValues",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 974, DateTimeKind.Local).AddTicks(9319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 29, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "AdFeatureValues",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 974, DateTimeKind.Local).AddTicks(9034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 29, DateTimeKind.Local).AddTicks(1030));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 44, DateTimeKind.Local).AddTicks(91),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 990, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 43, DateTimeKind.Local).AddTicks(9846),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 990, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 42, DateTimeKind.Local).AddTicks(7986),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 988, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 42, DateTimeKind.Local).AddTicks(7689),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 988, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 35, DateTimeKind.Local).AddTicks(3965),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 981, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 35, DateTimeKind.Local).AddTicks(3659),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 981, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 33, DateTimeKind.Local).AddTicks(1288),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 979, DateTimeKind.Local).AddTicks(3182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 33, DateTimeKind.Local).AddTicks(1044),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 979, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 31, DateTimeKind.Local).AddTicks(8625),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 977, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 31, DateTimeKind.Local).AddTicks(8382),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 977, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 30, DateTimeKind.Local).AddTicks(3022),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 976, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 30, DateTimeKind.Local).AddTicks(2770),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 976, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 21, DateTimeKind.Local).AddTicks(737),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 966, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 15, DateTimeKind.Local).AddTicks(8196),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 960, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "AdFeatureValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 29, DateTimeKind.Local).AddTicks(1319),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 974, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "AdFeatureValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 41, 48, 29, DateTimeKind.Local).AddTicks(1030),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 974, DateTimeKind.Local).AddTicks(9034));
        }
    }
}
