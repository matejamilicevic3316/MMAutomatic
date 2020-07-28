using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreDatabaseAccess.Migrations
{
    public partial class ggs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeatureName",
                table: "Features");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 158, DateTimeKind.Local).AddTicks(7740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 86, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 158, DateTimeKind.Local).AddTicks(7469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 86, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 157, DateTimeKind.Local).AddTicks(5245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 85, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 157, DateTimeKind.Local).AddTicks(4959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 85, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 149, DateTimeKind.Local).AddTicks(9499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 76, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 149, DateTimeKind.Local).AddTicks(9210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 76, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 148, DateTimeKind.Local).AddTicks(1377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 74, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 148, DateTimeKind.Local).AddTicks(1106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 74, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 146, DateTimeKind.Local).AddTicks(2466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 72, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 146, DateTimeKind.Local).AddTicks(2198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 72, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 145, DateTimeKind.Local).AddTicks(827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 70, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 145, DateTimeKind.Local).AddTicks(439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 70, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Features",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 131, DateTimeKind.Local).AddTicks(5707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 54, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 125, DateTimeKind.Local).AddTicks(2058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 47, DateTimeKind.Local).AddTicks(7073));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Features");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 86, DateTimeKind.Local).AddTicks(8329),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 158, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 86, DateTimeKind.Local).AddTicks(8064),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 158, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 85, DateTimeKind.Local).AddTicks(4851),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 157, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 85, DateTimeKind.Local).AddTicks(4521),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 157, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 76, DateTimeKind.Local).AddTicks(3472),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 149, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 76, DateTimeKind.Local).AddTicks(3162),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 149, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 74, DateTimeKind.Local).AddTicks(4217),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 148, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 74, DateTimeKind.Local).AddTicks(3928),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 148, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 72, DateTimeKind.Local).AddTicks(2409),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 146, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 72, DateTimeKind.Local).AddTicks(2145),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 146, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 70, DateTimeKind.Local).AddTicks(9653),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 145, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 70, DateTimeKind.Local).AddTicks(9184),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 145, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.AddColumn<string>(
                name: "FeatureName",
                table: "Features",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 54, DateTimeKind.Local).AddTicks(4666),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 131, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 23, 6, 57, 47, DateTimeKind.Local).AddTicks(7073),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 125, DateTimeKind.Local).AddTicks(2058));
        }
    }
}
