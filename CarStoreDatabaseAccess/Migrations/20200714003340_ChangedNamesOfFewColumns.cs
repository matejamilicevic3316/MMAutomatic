using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreDatabaseAccess.Migrations
{
    public partial class ChangedNamesOfFewColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleName",
                table: "VehcileModels");

            migrationBuilder.DropColumn(
                name: "TownName",
                table: "Towns");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 905, DateTimeKind.Local).AddTicks(5903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 633, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 905, DateTimeKind.Local).AddTicks(5628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 633, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 904, DateTimeKind.Local).AddTicks(1666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 632, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 904, DateTimeKind.Local).AddTicks(1302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 632, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "VehcileModels",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 894, DateTimeKind.Local).AddTicks(6983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 623, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 894, DateTimeKind.Local).AddTicks(6677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 623, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 892, DateTimeKind.Local).AddTicks(1821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 621, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 892, DateTimeKind.Local).AddTicks(1266),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 621, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Towns",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 888, DateTimeKind.Local).AddTicks(9522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 619, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 888, DateTimeKind.Local).AddTicks(9255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 619, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 887, DateTimeKind.Local).AddTicks(6416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 617, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 887, DateTimeKind.Local).AddTicks(6086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 617, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 869, DateTimeKind.Local).AddTicks(9600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 601, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 863, DateTimeKind.Local).AddTicks(2454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 595, DateTimeKind.Local).AddTicks(3243));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "VehcileModels");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Towns");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 633, DateTimeKind.Local).AddTicks(9946),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 905, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 633, DateTimeKind.Local).AddTicks(9601),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 905, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 632, DateTimeKind.Local).AddTicks(3214),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 904, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 632, DateTimeKind.Local).AddTicks(2759),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 904, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.AddColumn<string>(
                name: "VehicleName",
                table: "VehcileModels",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 623, DateTimeKind.Local).AddTicks(4630),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 894, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 623, DateTimeKind.Local).AddTicks(4294),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 894, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 621, DateTimeKind.Local).AddTicks(5020),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 892, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 621, DateTimeKind.Local).AddTicks(4725),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 892, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.AddColumn<string>(
                name: "TownName",
                table: "Towns",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 619, DateTimeKind.Local).AddTicks(2750),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 888, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 619, DateTimeKind.Local).AddTicks(2424),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 888, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 617, DateTimeKind.Local).AddTicks(9724),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 887, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 617, DateTimeKind.Local).AddTicks(9372),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 887, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 601, DateTimeKind.Local).AddTicks(5254),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 869, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 595, DateTimeKind.Local).AddTicks(3243),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 863, DateTimeKind.Local).AddTicks(2454));
        }
    }
}
