using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make1')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make2')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make3')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make4')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make5')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make1-ModelA', (SELECT ID FROM Makes WHERE Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make1-ModelB', (SELECT ID FROM Makes WHERE Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make1-ModelC', (SELECT ID FROM Makes WHERE Name = 'Make1'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make2-ModelA', (SELECT ID FROM Makes WHERE Name = 'Make2'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make2-ModelB', (SELECT ID FROM Makes WHERE Name = 'Make2'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make2-ModelC', (SELECT ID FROM Makes WHERE Name = 'Make2'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make3-ModelA', (SELECT ID FROM Makes WHERE Name = 'Make3'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make3-ModelB', (SELECT ID FROM Makes WHERE Name = 'Make3'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make3-ModelC', (SELECT ID FROM Makes WHERE Name = 'Make3'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make4-ModelA', (SELECT ID FROM Makes WHERE Name = 'Make4'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make4-ModelB', (SELECT ID FROM Makes WHERE Name = 'Make4'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make4-ModelC', (SELECT ID FROM Makes WHERE Name = 'Make4'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make5-ModelA', (SELECT ID FROM Makes WHERE Name = 'Make5'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make5-ModelB', (SELECT ID FROM Makes WHERE Name = 'Make5'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make5-ModelC', (SELECT ID FROM Makes WHERE Name = 'Make5'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes");
        }
    }
}
