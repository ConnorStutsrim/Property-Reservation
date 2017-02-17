using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PropertyReservation.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    IdentityID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(nullable: true),
                    WorkPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ReservationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<bool>(nullable: true),
                    Confirmed = table.Column<bool>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    NumberInParty = table.Column<int>(nullable: false),
                    Payed = table.Column<bool>(nullable: true),
                    PersonID = table.Column<int>(nullable: false),
                    PropertyID = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Type = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ReservationID);
                });

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonID",
                table: "AspNetUsers",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Person_PersonID",
                table: "AspNetUsers",
                column: "PersonID",
                principalTable: "Person",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Person_PersonID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PersonID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Reservation");
        }
    }
}
