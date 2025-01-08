using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationshipOnJobDatasAndItemsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobDataId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Items_JobDataId",
                table: "Items",
                column: "JobDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_JobDatas_JobDataId",
                table: "Items",
                column: "JobDataId",
                principalTable: "JobDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_JobDatas_JobDataId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_JobDataId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "JobDataId",
                table: "Items");
        }
    }
}
