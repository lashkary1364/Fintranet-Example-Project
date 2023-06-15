using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace congestion_tax_calculator_net_core.Migrations
{
    /// <inheritdoc />
    public partial class mydtabaev1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleTollStation_City_CityId",
                table: "VehicleTollStation");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleTollStation_Vehicle_VehicleId",
                table: "VehicleTollStation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleTollStation",
                table: "VehicleTollStation");

            migrationBuilder.RenameTable(
                name: "VehicleTollStation",
                newName: "Toll");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleTollStation_VehicleId",
                table: "Toll",
                newName: "IX_Toll_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleTollStation_CityId",
                table: "Toll",
                newName: "IX_Toll_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Toll",
                table: "Toll",
                column: "TollId");

            migrationBuilder.AddForeignKey(
                name: "FK_Toll_City_CityId",
                table: "Toll",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Toll_Vehicle_VehicleId",
                table: "Toll",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Toll_City_CityId",
                table: "Toll");

            migrationBuilder.DropForeignKey(
                name: "FK_Toll_Vehicle_VehicleId",
                table: "Toll");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Toll",
                table: "Toll");

            migrationBuilder.RenameTable(
                name: "Toll",
                newName: "VehicleTollStation");

            migrationBuilder.RenameIndex(
                name: "IX_Toll_VehicleId",
                table: "VehicleTollStation",
                newName: "IX_VehicleTollStation_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Toll_CityId",
                table: "VehicleTollStation",
                newName: "IX_VehicleTollStation_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleTollStation",
                table: "VehicleTollStation",
                column: "TollId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleTollStation_City_CityId",
                table: "VehicleTollStation",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleTollStation_Vehicle_VehicleId",
                table: "VehicleTollStation",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
