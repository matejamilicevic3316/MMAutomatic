using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreDatabaseAccess.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ads_VehcileModels_IdVehcileModel",
                table: "Ads");

            migrationBuilder.DropIndex(
                name: "IX_Ads_IdVehcileModel",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "IdVehcileModel",
                table: "Ads");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 696, DateTimeKind.Local).AddTicks(7571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 709, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 696, DateTimeKind.Local).AddTicks(7284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 709, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 695, DateTimeKind.Local).AddTicks(3556),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 708, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 695, DateTimeKind.Local).AddTicks(3081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 708, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 686, DateTimeKind.Local).AddTicks(5525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 700, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 686, DateTimeKind.Local).AddTicks(5158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 700, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 684, DateTimeKind.Local).AddTicks(7207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 698, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 684, DateTimeKind.Local).AddTicks(6952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 698, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 683, DateTimeKind.Local).AddTicks(3607),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 697, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 683, DateTimeKind.Local).AddTicks(3342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 697, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 681, DateTimeKind.Local).AddTicks(7243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 695, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 681, DateTimeKind.Local).AddTicks(6981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 695, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 672, DateTimeKind.Local).AddTicks(660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 686, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 666, DateTimeKind.Local).AddTicks(4947),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 681, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Ads",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "AdFeatureValues",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 680, DateTimeKind.Local).AddTicks(5130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 694, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "AdFeatureValues",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 680, DateTimeKind.Local).AddTicks(4852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 694, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.CreateIndex(
                name: "IX_Ads_VehicleId",
                table: "Ads",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_VehcileModels_VehicleId",
                table: "Ads",
                column: "VehicleId",
                principalTable: "VehcileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ads_VehcileModels_VehicleId",
                table: "Ads");

            migrationBuilder.DropIndex(
                name: "IX_Ads_VehicleId",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Ads");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 709, DateTimeKind.Local).AddTicks(2055),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 696, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 709, DateTimeKind.Local).AddTicks(1821),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 696, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 708, DateTimeKind.Local).AddTicks(367),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 695, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 708, DateTimeKind.Local).AddTicks(79),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 695, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 700, DateTimeKind.Local).AddTicks(6261),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 686, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 700, DateTimeKind.Local).AddTicks(5951),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 686, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 698, DateTimeKind.Local).AddTicks(7510),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 684, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 698, DateTimeKind.Local).AddTicks(7245),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 684, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 697, DateTimeKind.Local).AddTicks(3513),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 683, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 697, DateTimeKind.Local).AddTicks(3245),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 683, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 695, DateTimeKind.Local).AddTicks(6302),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 681, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 695, DateTimeKind.Local).AddTicks(6060),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 681, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 686, DateTimeKind.Local).AddTicks(8054),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 672, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 681, DateTimeKind.Local).AddTicks(6171),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 666, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.AddColumn<int>(
                name: "IdVehcileModel",
                table: "Ads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "AdFeatureValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 694, DateTimeKind.Local).AddTicks(5533),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 680, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "AdFeatureValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 0, 32, 9, 694, DateTimeKind.Local).AddTicks(5276),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 2, 23, 37, 680, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.CreateIndex(
                name: "IX_Ads_IdVehcileModel",
                table: "Ads",
                column: "IdVehcileModel");

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_VehcileModels_IdVehcileModel",
                table: "Ads",
                column: "IdVehcileModel",
                principalTable: "VehcileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
