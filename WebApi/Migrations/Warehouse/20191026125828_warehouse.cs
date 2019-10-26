using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations.Warehouse
{
    public partial class warehouse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    WarehouseId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_Warehouse_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Columns",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RoomId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Columns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Columns_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rack",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Side = table.Column<bool>(nullable: false),
                    ColumnsId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rack_Columns_ColumnsId",
                        column: x => x.ColumnsId,
                        principalTable: "Columns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shelf",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RackId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelf", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shelf_Rack_RackId",
                        column: x => x.RackId,
                        principalTable: "Rack",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Place",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ShelfId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Place", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Place_Shelf_ShelfId",
                        column: x => x.ShelfId,
                        principalTable: "Shelf",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    WarehouseId = table.Column<Guid>(nullable: true),
                    RoomId = table.Column<Guid>(nullable: true),
                    ColumnId = table.Column<Guid>(nullable: true),
                    RackId = table.Column<Guid>(nullable: true),
                    ShelfId = table.Column<Guid>(nullable: true),
                    PlaceId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Columns_ColumnId",
                        column: x => x.ColumnId,
                        principalTable: "Columns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Rack_RackId",
                        column: x => x.RackId,
                        principalTable: "Rack",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Shelf_ShelfId",
                        column: x => x.ShelfId,
                        principalTable: "Shelf",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Warehouse_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("55ec8da9-910f-4794-a142-aad7cc39d32f"), "Martyna" });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Name", "WarehouseId" },
                values: new object[] { new Guid("b374df7e-024c-4fb7-8919-5c0cbe41a4da"), "duzy", new Guid("55ec8da9-910f-4794-a142-aad7cc39d32f") });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "RoomId" },
                values: new object[] { new Guid("72465a96-36e7-4649-bc15-31da8250c7de"), "glowna", new Guid("b374df7e-024c-4fb7-8919-5c0cbe41a4da") });

            migrationBuilder.InsertData(
                table: "Rack",
                columns: new[] { "Id", "ColumnsId", "Name", "Side" },
                values: new object[] { new Guid("0c93db94-0862-4987-bb71-02d87e548c73"), new Guid("72465a96-36e7-4649-bc15-31da8250c7de"), "1", false });

            migrationBuilder.InsertData(
                table: "Shelf",
                columns: new[] { "Id", "Name", "RackId" },
                values: new object[] { new Guid("7d9276e3-514e-4cbc-9c73-cb131a2f8dc3"), "2", new Guid("0c93db94-0862-4987-bb71-02d87e548c73") });

            migrationBuilder.InsertData(
                table: "Place",
                columns: new[] { "Id", "Name", "ShelfId" },
                values: new object[] { new Guid("a15d5759-1b4c-4d0d-911e-b73bf3e19001"), "srodek", new Guid("7d9276e3-514e-4cbc-9c73-cb131a2f8dc3") });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "ColumnId", "ItemName", "PlaceId", "Quantity", "RackId", "RoomId", "ShelfId", "WarehouseId" },
                values: new object[] { new Guid("ae6b843c-f784-49dc-9ec8-e5e9f06d5e01"), null, "Przedmiot", new Guid("a15d5759-1b4c-4d0d-911e-b73bf3e19001"), 20, null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Columns_RoomId",
                table: "Columns",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ColumnId",
                table: "Item",
                column: "ColumnId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_PlaceId",
                table: "Item",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_RackId",
                table: "Item",
                column: "RackId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_RoomId",
                table: "Item",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ShelfId",
                table: "Item",
                column: "ShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_WarehouseId",
                table: "Item",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Place_ShelfId",
                table: "Place",
                column: "ShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_Rack_ColumnsId",
                table: "Rack",
                column: "ColumnsId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_WarehouseId",
                table: "Room",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Shelf_RackId",
                table: "Shelf",
                column: "RackId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Place");

            migrationBuilder.DropTable(
                name: "Shelf");

            migrationBuilder.DropTable(
                name: "Rack");

            migrationBuilder.DropTable(
                name: "Columns");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Warehouse");
        }
    }
}
