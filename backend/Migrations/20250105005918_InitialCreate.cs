using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Signary.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SignExpressions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    VideoUrl = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignExpressions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SignDefinitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SignExpressionId = table.Column<Guid>(type: "uuid", nullable: false),
                    VideoUrl = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignDefinitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignDefinitions_SignExpressions_SignExpressionId",
                        column: x => x.SignExpressionId,
                        principalTable: "SignExpressions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MouthingOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SignDefinitionId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MouthingOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MouthingOptions_SignDefinitions_SignDefinitionId",
                        column: x => x.SignDefinitionId,
                        principalTable: "SignDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SignDefinitionReferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SourceDefinitionId = table.Column<Guid>(type: "uuid", nullable: false),
                    TargetDefinitionId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignDefinitionReferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignDefinitionReferences_SignDefinitions_SourceDefinitionId",
                        column: x => x.SourceDefinitionId,
                        principalTable: "SignDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SignDefinitionReferences_SignDefinitions_TargetDefinitionId",
                        column: x => x.TargetDefinitionId,
                        principalTable: "SignDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SignDefinitionTag",
                columns: table => new
                {
                    SignDefinitionId = table.Column<Guid>(type: "uuid", nullable: false),
                    TagId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignDefinitionTag", x => new { x.SignDefinitionId, x.TagId });
                    table.ForeignKey(
                        name: "FK_SignDefinitionTag_SignDefinitions_SignDefinitionId",
                        column: x => x.SignDefinitionId,
                        principalTable: "SignDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SignDefinitionTag_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MouthingOptions_SignDefinitionId",
                table: "MouthingOptions",
                column: "SignDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_SignDefinitionReferences_SourceDefinitionId",
                table: "SignDefinitionReferences",
                column: "SourceDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_SignDefinitionReferences_TargetDefinitionId",
                table: "SignDefinitionReferences",
                column: "TargetDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_SignDefinitions_SignExpressionId",
                table: "SignDefinitions",
                column: "SignExpressionId");

            migrationBuilder.CreateIndex(
                name: "IX_SignDefinitionTag_TagId",
                table: "SignDefinitionTag",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MouthingOptions");

            migrationBuilder.DropTable(
                name: "SignDefinitionReferences");

            migrationBuilder.DropTable(
                name: "SignDefinitionTag");

            migrationBuilder.DropTable(
                name: "SignDefinitions");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "SignExpressions");
        }
    }
}
