using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreDatabaseAccess.Migrations
{
    public partial class ChangedDeleteBehavior : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdFeatureValues_Features_IdFeature",
                table: "AdFeatureValues");

            migrationBuilder.DropForeignKey(
                name: "FK_Ads_VehcileModels_VehicleId",
                table: "Ads");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_IdRole",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 633, DateTimeKind.Local).AddTicks(9946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 158, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 633, DateTimeKind.Local).AddTicks(9601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 158, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 632, DateTimeKind.Local).AddTicks(3214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 157, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 632, DateTimeKind.Local).AddTicks(2759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 157, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 623, DateTimeKind.Local).AddTicks(4630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 149, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 623, DateTimeKind.Local).AddTicks(4294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 149, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 621, DateTimeKind.Local).AddTicks(5020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 148, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 621, DateTimeKind.Local).AddTicks(4725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 148, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 619, DateTimeKind.Local).AddTicks(2750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 146, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 619, DateTimeKind.Local).AddTicks(2424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 146, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 617, DateTimeKind.Local).AddTicks(9724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 145, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 617, DateTimeKind.Local).AddTicks(9372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 145, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 601, DateTimeKind.Local).AddTicks(5254),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 131, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 595, DateTimeKind.Local).AddTicks(3243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 125, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.AddForeignKey(
                name: "FK_AdFeatureValues_Features_IdFeature",
                table: "AdFeatureValues",
                column: "IdFeature",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_VehcileModels_VehicleId",
                table: "Ads",
                column: "VehicleId",
                principalTable: "VehcileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_IdRole",
                table: "Users",
                column: "IdRole",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdFeatureValues_Features_IdFeature",
                table: "AdFeatureValues");

            migrationBuilder.DropForeignKey(
                name: "FK_Ads_VehcileModels_VehicleId",
                table: "Ads");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_IdRole",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 158, DateTimeKind.Local).AddTicks(7740),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 633, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 158, DateTimeKind.Local).AddTicks(7469),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 633, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 157, DateTimeKind.Local).AddTicks(5245),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 632, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 157, DateTimeKind.Local).AddTicks(4959),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 632, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 149, DateTimeKind.Local).AddTicks(9499),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 623, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 149, DateTimeKind.Local).AddTicks(9210),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 623, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 148, DateTimeKind.Local).AddTicks(1377),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 621, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 148, DateTimeKind.Local).AddTicks(1106),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 621, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 146, DateTimeKind.Local).AddTicks(2466),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 619, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 146, DateTimeKind.Local).AddTicks(2198),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 619, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 145, DateTimeKind.Local).AddTicks(827),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 617, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 145, DateTimeKind.Local).AddTicks(439),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 617, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 131, DateTimeKind.Local).AddTicks(5707),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 601, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 5, 15, 4, 29, 125, DateTimeKind.Local).AddTicks(2058),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 14, 1, 9, 22, 595, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.AddForeignKey(
                name: "FK_AdFeatureValues_Features_IdFeature",
                table: "AdFeatureValues",
                column: "IdFeature",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_VehcileModels_VehicleId",
                table: "Ads",
                column: "VehicleId",
                principalTable: "VehcileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_IdRole",
                table: "Users",
                column: "IdRole",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
