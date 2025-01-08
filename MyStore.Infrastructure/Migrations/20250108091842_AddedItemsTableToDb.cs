using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedItemsTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteId = table.Column<int>(type: "int", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RetailCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccountDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CouponDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
