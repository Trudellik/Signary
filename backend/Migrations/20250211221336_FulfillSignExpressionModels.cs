using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Signary.Migrations
{
    /// <inheritdoc />
    public partial class FulfillSignExpressionModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SignDefinitionTag_SignDefinitions_SignDefinitionId",
                table: "SignDefinitionTag");

            migrationBuilder.DropForeignKey(
                name: "FK_SignDefinitionTag_Tags_TagId",
                table: "SignDefinitionTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SignDefinitionTag",
                table: "SignDefinitionTag");

            migrationBuilder.RenameTable(
                name: "SignDefinitionTag",
                newName: "SignDefinitionTags");

            migrationBuilder.RenameIndex(
                name: "IX_SignDefinitionTag_TagId",
                table: "SignDefinitionTags",
                newName: "IX_SignDefinitionTags_TagId");

            migrationBuilder.AlterColumn<string>(
                name: "VideoUrl",
                table: "SignDefinitions",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignDefinitionTags",
                table: "SignDefinitionTags",
                columns: new[] { "SignDefinitionId", "TagId" });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_Name",
                table: "Tags",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SignDefinitionTags_SignDefinitions_SignDefinitionId",
                table: "SignDefinitionTags",
                column: "SignDefinitionId",
                principalTable: "SignDefinitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignDefinitionTags_Tags_TagId",
                table: "SignDefinitionTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SignDefinitionTags_SignDefinitions_SignDefinitionId",
                table: "SignDefinitionTags");

            migrationBuilder.DropForeignKey(
                name: "FK_SignDefinitionTags_Tags_TagId",
                table: "SignDefinitionTags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_Name",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SignDefinitionTags",
                table: "SignDefinitionTags");

            migrationBuilder.RenameTable(
                name: "SignDefinitionTags",
                newName: "SignDefinitionTag");

            migrationBuilder.RenameIndex(
                name: "IX_SignDefinitionTags_TagId",
                table: "SignDefinitionTag",
                newName: "IX_SignDefinitionTag_TagId");

            migrationBuilder.AlterColumn<string>(
                name: "VideoUrl",
                table: "SignDefinitions",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignDefinitionTag",
                table: "SignDefinitionTag",
                columns: new[] { "SignDefinitionId", "TagId" });

            migrationBuilder.AddForeignKey(
                name: "FK_SignDefinitionTag_SignDefinitions_SignDefinitionId",
                table: "SignDefinitionTag",
                column: "SignDefinitionId",
                principalTable: "SignDefinitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignDefinitionTag_Tags_TagId",
                table: "SignDefinitionTag",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
