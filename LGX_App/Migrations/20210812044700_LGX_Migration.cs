using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LGX.Migrations
{
    public partial class LGX_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shelf_Movie_RelayRackId",
                table: "Shelf");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "RelayRack");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "RelayRack",
                newName: "RackNumber");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "RelayRack",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Isle",
                table: "RelayRack",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "RelayRack",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AddPrimaryKey(
                name: "PK_RelayRack",
                table: "RelayRack",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shelf_RelayRack_RelayRackId",
                table: "Shelf",
                column: "RelayRackId",
                principalTable: "RelayRack",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shelf_RelayRack_RelayRackId",
                table: "Shelf");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RelayRack",
                table: "RelayRack");

            migrationBuilder.RenameTable(
                name: "RelayRack",
                newName: "Movie");

            migrationBuilder.RenameColumn(
                name: "RackNumber",
                table: "Movie",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Movie",
                newName: "Genre");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Isle",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Comment",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shelf_Movie_RelayRackId",
                table: "Shelf",
                column: "RelayRackId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
