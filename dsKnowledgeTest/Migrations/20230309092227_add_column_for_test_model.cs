using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dsKnowledgeTest.Migrations
{
    public partial class add_column_for_test_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MinThreshold",
                table: "Tests",
                type: "double precision",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinThreshold",
                table: "Tests");
        }
    }
}
