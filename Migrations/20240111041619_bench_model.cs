using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace benchTime.Migrations
{
    /// <inheritdoc />
    public partial class bench_model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "coordinates",
                table: "Benches",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "Benches",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "coordinates",
                table: "Benches");

            migrationBuilder.DropColumn(
                name: "image",
                table: "Benches");
        }
    }
}
