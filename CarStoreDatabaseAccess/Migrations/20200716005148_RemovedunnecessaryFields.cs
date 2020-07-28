using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreDatabaseAccess.Migrations
{
    public partial class RemovedunnecessaryFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "CreationDateTime",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "VehcileTypes");

            migrationBuilder.DropColumn(
                name: "CreationDateTime",
                table: "VehcileTypes");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "VehcileTypes");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "VehcileTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "VehcileTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "VehcileTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "VehcileTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreationDateTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Towns");

            migrationBuilder.DropColumn(
                name: "CreationDateTime",
                table: "Towns");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "Towns");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Towns");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Towns");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Towns");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Towns");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreationDateTime",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "CreationDateTime",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "CreationDateTime",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Ads");

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "AdFeatureValues",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDateTime",
                table: "Vehicles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 202, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "Vehicles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Vehicles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Vehicles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 203, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "VehcileTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 204, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "VehcileTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "VehcileTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "VehcileTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 204, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 194, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 194, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Towns",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 192, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Towns",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Towns",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "Towns",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 192, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 189, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Roles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 189, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Features",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 188, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "Features",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Features",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Features",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "Features",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 188, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Ads",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 167, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Ads",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Ads",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "Ads",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 173, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "AdFeatureValues",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal));
        }
    }
}
