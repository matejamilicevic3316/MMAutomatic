using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreDatabaseAccess.Migrations
{
    public partial class vehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ads_VehcileModels_VehicleId",
                table: "Ads");

            migrationBuilder.DropForeignKey(
                name: "FK_VehcileModels_VehcileTypes_VehicleTypeId",
                table: "VehcileModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehcileModels",
                table: "VehcileModels");

            migrationBuilder.RenameTable(
                name: "VehcileModels",
                newName: "Vehicles");

            migrationBuilder.RenameIndex(
                name: "IX_VehcileModels_VehicleTypeId",
                table: "Vehicles",
                newName: "IX_Vehicles_VehicleTypeId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 204, DateTimeKind.Local).AddTicks(3835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 943, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 204, DateTimeKind.Local).AddTicks(3570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 943, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 194, DateTimeKind.Local).AddTicks(3441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 933, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 194, DateTimeKind.Local).AddTicks(3167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 933, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 192, DateTimeKind.Local).AddTicks(1862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 931, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 192, DateTimeKind.Local).AddTicks(1418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 931, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 189, DateTimeKind.Local).AddTicks(6922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 929, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 189, DateTimeKind.Local).AddTicks(6657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 929, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 188, DateTimeKind.Local).AddTicks(4424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 928, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 188, DateTimeKind.Local).AddTicks(4090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 928, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 173, DateTimeKind.Local).AddTicks(6669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 913, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 167, DateTimeKind.Local).AddTicks(4963),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 907, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Vehicles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 203, DateTimeKind.Local).AddTicks(45),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 941, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Vehicles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 202, DateTimeKind.Local).AddTicks(9753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 941, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_Vehicles_VehicleId",
                table: "Ads",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehcileTypes_VehicleTypeId",
                table: "Vehicles",
                column: "VehicleTypeId",
                principalTable: "VehcileTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ads_Vehicles_VehicleId",
                table: "Ads");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehcileTypes_VehicleTypeId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "VehcileModels");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_VehicleTypeId",
                table: "VehcileModels",
                newName: "IX_VehcileModels_VehicleTypeId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 943, DateTimeKind.Local).AddTicks(3271),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 204, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 943, DateTimeKind.Local).AddTicks(3020),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 204, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 933, DateTimeKind.Local).AddTicks(4064),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 194, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 933, DateTimeKind.Local).AddTicks(3809),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 194, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 931, DateTimeKind.Local).AddTicks(5884),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 192, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 931, DateTimeKind.Local).AddTicks(5636),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 192, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 929, DateTimeKind.Local).AddTicks(6129),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 189, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 929, DateTimeKind.Local).AddTicks(5885),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 189, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 928, DateTimeKind.Local).AddTicks(3704),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 188, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 928, DateTimeKind.Local).AddTicks(3417),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 188, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 913, DateTimeKind.Local).AddTicks(9308),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 173, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 907, DateTimeKind.Local).AddTicks(9969),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 167, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 941, DateTimeKind.Local).AddTicks(9667),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 203, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 941, DateTimeKind.Local).AddTicks(9377),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 21, 12, 50, 202, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehcileModels",
                table: "VehcileModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_VehcileModels_VehicleId",
                table: "Ads",
                column: "VehicleId",
                principalTable: "VehcileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehcileModels_VehcileTypes_VehicleTypeId",
                table: "VehcileModels",
                column: "VehicleTypeId",
                principalTable: "VehcileTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
