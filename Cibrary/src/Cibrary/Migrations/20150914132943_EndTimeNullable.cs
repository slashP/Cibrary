using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Cibrary.Migrations
{
    public partial class EndTimeNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Borrow",
                isNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Borrow",
                isNullable: false);
        }
    }
}
