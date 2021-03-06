using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PostalRegistry.Projections.Legacy.Migrations
{
    public partial class AddSyndicationItemCreatedAt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // set value to UtcNow for all existing records
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "SyndicationItemCreatedAt",
                schema: "PostalRegistryLegacy",
                table: "PostalInformationSyndication",
                nullable: false,
                defaultValue: DateTimeOffset.UtcNow);

            // remove the default value
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "SyndicationItemCreatedAt",
                schema: "PostalRegistryLegacy",
                table: "PostalInformationSyndication",
                nullable: false,
                defaultValue: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SyndicationItemCreatedAt",
                schema: "PostalRegistryLegacy",
                table: "PostalInformationSyndication");
        }
    }
}
