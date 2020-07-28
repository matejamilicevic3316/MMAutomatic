using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreDatabaseAccess.Migrations
{
    public partial class addedFieldForYearOfProduction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 943, DateTimeKind.Local).AddTicks(3271),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 905, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 943, DateTimeKind.Local).AddTicks(3020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 905, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 941, DateTimeKind.Local).AddTicks(9667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 904, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 941, DateTimeKind.Local).AddTicks(9377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 904, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 933, DateTimeKind.Local).AddTicks(4064),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 894, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 933, DateTimeKind.Local).AddTicks(3809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 894, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 931, DateTimeKind.Local).AddTicks(5884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 892, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 931, DateTimeKind.Local).AddTicks(5636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 892, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 929, DateTimeKind.Local).AddTicks(6129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 888, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 929, DateTimeKind.Local).AddTicks(5885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 888, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 928, DateTimeKind.Local).AddTicks(3704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 887, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 928, DateTimeKind.Local).AddTicks(3417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 887, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 913, DateTimeKind.Local).AddTicks(9308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 869, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 907, DateTimeKind.Local).AddTicks(9969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 863, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.AddColumn<int>(
                name: "YearProduced",
                table: "Ads",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearProduced",
                table: "Ads");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 905, DateTimeKind.Local).AddTicks(5903),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 943, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 905, DateTimeKind.Local).AddTicks(5628),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 943, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 904, DateTimeKind.Local).AddTicks(1666),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 941, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 904, DateTimeKind.Local).AddTicks(1302),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 941, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 894, DateTimeKind.Local).AddTicks(6983),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 933, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 894, DateTimeKind.Local).AddTicks(6677),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 933, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 892, DateTimeKind.Local).AddTicks(1821),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 931, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 892, DateTimeKind.Local).AddTicks(1266),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 931, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 888, DateTimeKind.Local).AddTicks(9522),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 929, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 888, DateTimeKind.Local).AddTicks(9255),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 929, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 887, DateTimeKind.Local).AddTicks(6416),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 928, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 887, DateTimeKind.Local).AddTicks(6086),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 928, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 869, DateTimeKind.Local).AddTicks(9600),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 913, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 2, 33, 39, 863, DateTimeKind.Local).AddTicks(2454),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 20, 54, 32, 907, DateTimeKind.Local).AddTicks(9969));
        }
    }
}
