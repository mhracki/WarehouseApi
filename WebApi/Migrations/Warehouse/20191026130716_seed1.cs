using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations.Warehouse
{
    public partial class seed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Columns_ColumnId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Place_PlaceId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Rack_RackId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Room_RoomId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Shelf_ShelfId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_ColumnId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_PlaceId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_RackId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_RoomId",
                table: "Item");

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("2dbc8f7f-6c23-4e5c-aa43-1a3f8ca5efb7"));

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: new Guid("67d37856-b7d6-4c89-8443-67ce2f611e30"));

            migrationBuilder.DeleteData(
                table: "Shelf",
                keyColumn: "Id",
                keyValue: new Guid("5a26f4d0-e23f-4229-9499-ef92143831e3"));

            migrationBuilder.DeleteData(
                table: "Rack",
                keyColumn: "Id",
                keyValue: new Guid("0d1e4dad-5992-46c0-b315-5745e2134bb9"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b874ccf0-44b2-4219-a7c0-7921505e6d31"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("acead73b-468b-48c0-b11c-f7597da9f72a"));

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "Id",
                keyValue: new Guid("07312518-892a-4e07-8cd9-f3cf25f7d1c3"));

            migrationBuilder.DropColumn(
                name: "ColumnId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "PlaceId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "RackId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "ShelfId",
                table: "Item",
                newName: "ColumnModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_ShelfId",
                table: "Item",
                newName: "IX_Item_ColumnModelId");

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("30638fc5-bb6a-4605-aff8-9bce1c596c5c"), "Martyna" });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "ColumnModelId", "ItemName", "Quantity", "WarehouseId" },
                values: new object[] { new Guid("31bfa0c9-e1b9-43c6-91e0-fe6f86b6b504"), null, "Przedmiot", 20, new Guid("30638fc5-bb6a-4605-aff8-9bce1c596c5c") });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Name", "WarehouseId" },
                values: new object[] { new Guid("a3715067-98a1-443b-856d-3618c56379a2"), "duzy", new Guid("30638fc5-bb6a-4605-aff8-9bce1c596c5c") });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "RoomId" },
                values: new object[] { new Guid("3564fc79-9cb7-46e6-9772-c34f6a6c5903"), "glowna", new Guid("a3715067-98a1-443b-856d-3618c56379a2") });

            migrationBuilder.InsertData(
                table: "Rack",
                columns: new[] { "Id", "ColumnsId", "Name", "Side" },
                values: new object[] { new Guid("a12195de-0a15-42e3-becc-4748b0b56d88"), new Guid("3564fc79-9cb7-46e6-9772-c34f6a6c5903"), "1", false });

            migrationBuilder.InsertData(
                table: "Shelf",
                columns: new[] { "Id", "Name", "RackId" },
                values: new object[] { new Guid("9b0b9a80-80da-465a-930d-7d2e5d7ee30f"), "2", new Guid("a12195de-0a15-42e3-becc-4748b0b56d88") });

            migrationBuilder.InsertData(
                table: "Place",
                columns: new[] { "Id", "Name", "ShelfId" },
                values: new object[] { new Guid("30b9a620-64cf-4850-b5e3-152e6210265e"), "srodek", new Guid("9b0b9a80-80da-465a-930d-7d2e5d7ee30f") });

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Columns_ColumnModelId",
                table: "Item",
                column: "ColumnModelId",
                principalTable: "Columns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Columns_ColumnModelId",
                table: "Item");

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("31bfa0c9-e1b9-43c6-91e0-fe6f86b6b504"));

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: new Guid("30b9a620-64cf-4850-b5e3-152e6210265e"));

            migrationBuilder.DeleteData(
                table: "Shelf",
                keyColumn: "Id",
                keyValue: new Guid("9b0b9a80-80da-465a-930d-7d2e5d7ee30f"));

            migrationBuilder.DeleteData(
                table: "Rack",
                keyColumn: "Id",
                keyValue: new Guid("a12195de-0a15-42e3-becc-4748b0b56d88"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("3564fc79-9cb7-46e6-9772-c34f6a6c5903"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("a3715067-98a1-443b-856d-3618c56379a2"));

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "Id",
                keyValue: new Guid("30638fc5-bb6a-4605-aff8-9bce1c596c5c"));

            migrationBuilder.RenameColumn(
                name: "ColumnModelId",
                table: "Item",
                newName: "ShelfId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_ColumnModelId",
                table: "Item",
                newName: "IX_Item_ShelfId");

            migrationBuilder.AddColumn<Guid>(
                name: "ColumnId",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PlaceId",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RackId",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "Item",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("07312518-892a-4e07-8cd9-f3cf25f7d1c3"), "Martyna" });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Name", "WarehouseId" },
                values: new object[] { new Guid("acead73b-468b-48c0-b11c-f7597da9f72a"), "duzy", new Guid("07312518-892a-4e07-8cd9-f3cf25f7d1c3") });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "RoomId" },
                values: new object[] { new Guid("b874ccf0-44b2-4219-a7c0-7921505e6d31"), "glowna", new Guid("acead73b-468b-48c0-b11c-f7597da9f72a") });

            migrationBuilder.InsertData(
                table: "Rack",
                columns: new[] { "Id", "ColumnsId", "Name", "Side" },
                values: new object[] { new Guid("0d1e4dad-5992-46c0-b315-5745e2134bb9"), new Guid("b874ccf0-44b2-4219-a7c0-7921505e6d31"), "1", false });

            migrationBuilder.InsertData(
                table: "Shelf",
                columns: new[] { "Id", "Name", "RackId" },
                values: new object[] { new Guid("5a26f4d0-e23f-4229-9499-ef92143831e3"), "2", new Guid("0d1e4dad-5992-46c0-b315-5745e2134bb9") });

            migrationBuilder.InsertData(
                table: "Place",
                columns: new[] { "Id", "Name", "ShelfId" },
                values: new object[] { new Guid("67d37856-b7d6-4c89-8443-67ce2f611e30"), "srodek", new Guid("5a26f4d0-e23f-4229-9499-ef92143831e3") });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "ColumnId", "ItemName", "PlaceId", "Quantity", "RackId", "RoomId", "ShelfId", "WarehouseId" },
                values: new object[] { new Guid("2dbc8f7f-6c23-4e5c-aa43-1a3f8ca5efb7"), null, "Przedmiot", new Guid("67d37856-b7d6-4c89-8443-67ce2f611e30"), 20, new Guid("0d1e4dad-5992-46c0-b315-5745e2134bb9"), new Guid("acead73b-468b-48c0-b11c-f7597da9f72a"), new Guid("5a26f4d0-e23f-4229-9499-ef92143831e3"), new Guid("07312518-892a-4e07-8cd9-f3cf25f7d1c3") });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Columns_ColumnId",
                table: "Item",
                column: "ColumnId",
                principalTable: "Columns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Place_PlaceId",
                table: "Item",
                column: "PlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Rack_RackId",
                table: "Item",
                column: "RackId",
                principalTable: "Rack",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Room_RoomId",
                table: "Item",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Shelf_ShelfId",
                table: "Item",
                column: "ShelfId",
                principalTable: "Shelf",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
