using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetCore21.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TS = table.Column<DateTime>(nullable: false),
                    Act = table.Column<string>(nullable: false),
                    Race = table.Column<int>(nullable: false),
                    Masculinity = table.Column<int>(nullable: false),
                    Femininity = table.Column<int>(nullable: false),
                    Fitness = table.Column<int>(nullable: false),
                    Fatness = table.Column<int>(nullable: false),
                    Agility = table.Column<int>(nullable: false),
                    Strength = table.Column<int>(nullable: false),
                    Vitality = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    Willpower = table.Column<int>(nullable: false),
                    Luck = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "A_Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TS = table.Column<DateTime>(nullable: false),
                    Act = table.Column<string>(nullable: false),
                    A_CharacterId = table.Column<int>(nullable: true),
                    A_CharacterId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_A_Item_Characters_A_CharacterId",
                        column: x => x.A_CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_A_Item_Characters_A_CharacterId1",
                        column: x => x.A_CharacterId1,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Arm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TS = table.Column<DateTime>(nullable: false),
                    Act = table.Column<string>(nullable: false),
                    Skin = table.Column<int>(nullable: false),
                    A_CharacterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arm_Characters_A_CharacterId",
                        column: x => x.A_CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Core",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TS = table.Column<DateTime>(nullable: false),
                    Act = table.Column<string>(nullable: false),
                    Skin = table.Column<int>(nullable: false),
                    A_CharacterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_Characters_A_CharacterId",
                        column: x => x.A_CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Foot",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TS = table.Column<DateTime>(nullable: false),
                    Act = table.Column<string>(nullable: false),
                    Skin = table.Column<int>(nullable: false),
                    A_CharacterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foot_Characters_A_CharacterId",
                        column: x => x.A_CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hand",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TS = table.Column<DateTime>(nullable: false),
                    Act = table.Column<string>(nullable: false),
                    Skin = table.Column<int>(nullable: false),
                    A_CharacterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hand_Characters_A_CharacterId",
                        column: x => x.A_CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Head",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TS = table.Column<DateTime>(nullable: false),
                    Act = table.Column<string>(nullable: false),
                    Skin = table.Column<int>(nullable: false),
                    A_CharacterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Head", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Head_Characters_A_CharacterId",
                        column: x => x.A_CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Leg",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TS = table.Column<DateTime>(nullable: false),
                    Act = table.Column<string>(nullable: false),
                    Skin = table.Column<int>(nullable: false),
                    A_CharacterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leg", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leg_Characters_A_CharacterId",
                        column: x => x.A_CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shoulder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TS = table.Column<DateTime>(nullable: false),
                    Act = table.Column<string>(nullable: false),
                    Skin = table.Column<int>(nullable: false),
                    A_CharacterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoulder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shoulder_Characters_A_CharacterId",
                        column: x => x.A_CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Waist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TS = table.Column<DateTime>(nullable: false),
                    Act = table.Column<string>(nullable: false),
                    Skin = table.Column<int>(nullable: false),
                    A_CharacterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Waist_Characters_A_CharacterId",
                        column: x => x.A_CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_A_Item_A_CharacterId",
                table: "A_Item",
                column: "A_CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_A_Item_A_CharacterId1",
                table: "A_Item",
                column: "A_CharacterId1");

            migrationBuilder.CreateIndex(
                name: "IX_Arm_A_CharacterId",
                table: "Arm",
                column: "A_CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_A_CharacterId",
                table: "Core",
                column: "A_CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Foot_A_CharacterId",
                table: "Foot",
                column: "A_CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Hand_A_CharacterId",
                table: "Hand",
                column: "A_CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Head_A_CharacterId",
                table: "Head",
                column: "A_CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Leg_A_CharacterId",
                table: "Leg",
                column: "A_CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Shoulder_A_CharacterId",
                table: "Shoulder",
                column: "A_CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Waist_A_CharacterId",
                table: "Waist",
                column: "A_CharacterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "A_Item");

            migrationBuilder.DropTable(
                name: "Arm");

            migrationBuilder.DropTable(
                name: "Core");

            migrationBuilder.DropTable(
                name: "Foot");

            migrationBuilder.DropTable(
                name: "Hand");

            migrationBuilder.DropTable(
                name: "Head");

            migrationBuilder.DropTable(
                name: "Leg");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Shoulder");

            migrationBuilder.DropTable(
                name: "Waist");

            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
