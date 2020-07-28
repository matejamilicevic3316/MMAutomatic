using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreDatabaseAccess.Migrations
{
    public partial class migrationJak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 547, DateTimeKind.Local).AddTicks(5514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 990, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 547, DateTimeKind.Local).AddTicks(5245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 990, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 546, DateTimeKind.Local).AddTicks(2617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 988, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 546, DateTimeKind.Local).AddTicks(2294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 988, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 538, DateTimeKind.Local).AddTicks(1709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 981, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 538, DateTimeKind.Local).AddTicks(1397),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 981, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 536, DateTimeKind.Local).AddTicks(1704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 979, DateTimeKind.Local).AddTicks(3182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 536, DateTimeKind.Local).AddTicks(1433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 979, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 534, DateTimeKind.Local).AddTicks(7581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 977, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 534, DateTimeKind.Local).AddTicks(7295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 977, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 533, DateTimeKind.Local).AddTicks(737),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 976, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 533, DateTimeKind.Local).AddTicks(462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 976, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 523, DateTimeKind.Local).AddTicks(440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 966, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 517, DateTimeKind.Local).AddTicks(2177),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 960, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "AdFeatureValues",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 531, DateTimeKind.Local).AddTicks(8041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 974, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "AdFeatureValues",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 531, DateTimeKind.Local).AddTicks(7713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 974, DateTimeKind.Local).AddTicks(9034));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 990, DateTimeKind.Local).AddTicks(2465),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 547, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 990, DateTimeKind.Local).AddTicks(2202),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 547, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 988, DateTimeKind.Local).AddTicks(9223),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 546, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 988, DateTimeKind.Local).AddTicks(8916),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 546, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 981, DateTimeKind.Local).AddTicks(1434),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 538, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 981, DateTimeKind.Local).AddTicks(1160),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 538, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 979, DateTimeKind.Local).AddTicks(3182),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 536, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 979, DateTimeKind.Local).AddTicks(2918),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 536, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 977, DateTimeKind.Local).AddTicks(8975),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 534, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 977, DateTimeKind.Local).AddTicks(8703),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 534, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 976, DateTimeKind.Local).AddTicks(1738),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 533, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 976, DateTimeKind.Local).AddTicks(1450),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 533, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 966, DateTimeKind.Local).AddTicks(2652),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 523, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 960, DateTimeKind.Local).AddTicks(7187),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 517, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "AdFeatureValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 974, DateTimeKind.Local).AddTicks(9319),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 531, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "AdFeatureValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 17, 55, 47, 974, DateTimeKind.Local).AddTicks(9034),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 531, DateTimeKind.Local).AddTicks(7713));
        }
    }
}
