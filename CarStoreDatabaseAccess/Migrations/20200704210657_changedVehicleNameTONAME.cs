using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreDatabaseAccess.Migrations
{
    public partial class changedVehicleNameTONAME : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehcileTypeName",
                table: "VehcileTypes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 86, DateTimeKind.Local).AddTicks(8329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 163, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 86, DateTimeKind.Local).AddTicks(8064),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 163, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "VehcileTypes",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 85, DateTimeKind.Local).AddTicks(4851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 162, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 85, DateTimeKind.Local).AddTicks(4521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 162, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 76, DateTimeKind.Local).AddTicks(3472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 153, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 76, DateTimeKind.Local).AddTicks(3162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 153, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 74, DateTimeKind.Local).AddTicks(4217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 151, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 74, DateTimeKind.Local).AddTicks(3928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 151, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 72, DateTimeKind.Local).AddTicks(2409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 148, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 72, DateTimeKind.Local).AddTicks(2145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 148, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 70, DateTimeKind.Local).AddTicks(9653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 147, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 70, DateTimeKind.Local).AddTicks(9184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 147, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 54, DateTimeKind.Local).AddTicks(4666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 132, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 47, DateTimeKind.Local).AddTicks(7073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 125, DateTimeKind.Local).AddTicks(7183));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "VehcileTypes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 163, DateTimeKind.Local).AddTicks(4880),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 86, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 163, DateTimeKind.Local).AddTicks(4611),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 86, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.AddColumn<string>(
                name: "VehcileTypeName",
                table: "VehcileTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 162, DateTimeKind.Local).AddTicks(964),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 85, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 162, DateTimeKind.Local).AddTicks(608),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 85, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 153, DateTimeKind.Local).AddTicks(2098),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 76, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 153, DateTimeKind.Local).AddTicks(1807),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 76, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 151, DateTimeKind.Local).AddTicks(1790),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 74, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 151, DateTimeKind.Local).AddTicks(1421),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 74, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 148, DateTimeKind.Local).AddTicks(8837),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 72, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 148, DateTimeKind.Local).AddTicks(8563),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 72, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 147, DateTimeKind.Local).AddTicks(6241),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 70, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 147, DateTimeKind.Local).AddTicks(5901),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 70, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 132, DateTimeKind.Local).AddTicks(1406),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 54, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 52, 1, 125, DateTimeKind.Local).AddTicks(7183),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 47, DateTimeKind.Local).AddTicks(7073));
        }
    }
}
