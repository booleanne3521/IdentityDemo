﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityDemo.Migrations
{
    /// <inheritdoc />
    public partial class Moneydatatype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PriceTotal",
                table: "Orders",
                type: "Money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PriceTotal",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Money");
        }
    }
}
