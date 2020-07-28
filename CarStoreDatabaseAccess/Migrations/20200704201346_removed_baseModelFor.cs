using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreDatabaseAccess.Migrations
{
    public partial class removed_baseModelFor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AdFeatureValues",
                table: "AdFeatureValues");

            migrationBuilder.DropIndex(
                name: "IX_AdFeatureValues_IdAd",
                table: "AdFeatureValues");

            migrationBuilder.DropColumn(
                name: "ValueType",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AdFeatureValues");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AdFeatureValues");

            migrationBuilder.DropColumn(
                name: "CreationDateTime",
                table: "AdFeatureValues");

            migrationBuilder.DropColumn(
                name: "DeleteDateTime",
                table: "AdFeatureValues");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "AdFeatureValues");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AdFeatureValues");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "AdFeatureValues");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "AdFeatureValues");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 913, DateTimeKind.Local).AddTicks(3569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 547, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 913, DateTimeKind.Local).AddTicks(3279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 547, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 911, DateTimeKind.Local).AddTicks(9067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 546, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 911, DateTimeKind.Local).AddTicks(8709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 546, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 902, DateTimeKind.Local).AddTicks(4042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 538, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 902, DateTimeKind.Local).AddTicks(3735),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 538, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 900, DateTimeKind.Local).AddTicks(4572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 536, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 900, DateTimeKind.Local).AddTicks(4288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 536, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 898, DateTimeKind.Local).AddTicks(2637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 534, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 898, DateTimeKind.Local).AddTicks(2235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 534, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 896, DateTimeKind.Local).AddTicks(8332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 533, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 896, DateTimeKind.Local).AddTicks(7997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 533, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 879, DateTimeKind.Local).AddTicks(5742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 523, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 872, DateTimeKind.Local).AddTicks(9040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 517, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdFeatureValues",
                table: "AdFeatureValues",
                columns: new[] { "IdAd", "IdFeature" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AdFeatureValues",
                table: "AdFeatureValues");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 547, DateTimeKind.Local).AddTicks(5514),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 913, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 547, DateTimeKind.Local).AddTicks(5245),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 913, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 546, DateTimeKind.Local).AddTicks(2617),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 911, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "VehcileModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 546, DateTimeKind.Local).AddTicks(2294),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 911, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 538, DateTimeKind.Local).AddTicks(1709),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 902, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 538, DateTimeKind.Local).AddTicks(1397),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 902, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 536, DateTimeKind.Local).AddTicks(1704),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 900, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Towns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 536, DateTimeKind.Local).AddTicks(1433),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 900, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 534, DateTimeKind.Local).AddTicks(7581),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 898, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 534, DateTimeKind.Local).AddTicks(7295),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 898, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 533, DateTimeKind.Local).AddTicks(737),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 896, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 533, DateTimeKind.Local).AddTicks(462),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 896, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.AddColumn<string>(
                name: "ValueType",
                table: "Features",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 523, DateTimeKind.Local).AddTicks(440),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 879, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 517, DateTimeKind.Local).AddTicks(2177),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 4, 22, 13, 45, 872, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AdFeatureValues",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "AdFeatureValues",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDateTime",
                table: "AdFeatureValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 531, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDateTime",
                table: "AdFeatureValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "AdFeatureValues",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AdFeatureValues",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "AdFeatureValues",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "AdFeatureValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 4, 18, 5, 47, 531, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdFeatureValues",
                table: "AdFeatureValues",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AdFeatureValues_IdAd",
                table: "AdFeatureValues",
                column: "IdAd");
        }
    }
}
