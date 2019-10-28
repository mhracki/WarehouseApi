using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations.Warehouse
{
    public partial class seed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Columns_Room_RoomId",
                table: "Columns");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Columns_ColumnModelId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Warehouse_WarehouseId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Place_Shelf_ShelfId",
                table: "Place");

            migrationBuilder.DropForeignKey(
                name: "FK_Rack_Columns_ColumnsId",
                table: "Rack");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Warehouse_WarehouseId",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_Shelf_Rack_RackId",
                table: "Shelf");

            migrationBuilder.DropIndex(
                name: "IX_Shelf_RackId",
                table: "Shelf");

            migrationBuilder.DropIndex(
                name: "IX_Room_WarehouseId",
                table: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Rack_ColumnsId",
                table: "Rack");

            migrationBuilder.DropIndex(
                name: "IX_Place_ShelfId",
                table: "Place");

            migrationBuilder.DropIndex(
                name: "IX_Item_ColumnModelId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Columns_RoomId",
                table: "Columns");

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

            migrationBuilder.DropColumn(
                name: "ColumnModelId",
                table: "Item");

            migrationBuilder.AlterColumn<Guid>(
                name: "RackId",
                table: "Shelf",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "WarehouseId",
                table: "Room",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ColumnsId",
                table: "Rack",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ShelfId",
                table: "Place",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "WarehouseId",
                table: "Item",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ColumnId",
                table: "Item",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PlaceId",
                table: "Item",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RackId",
                table: "Item",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "Item",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ShelfId",
                table: "Item",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomId",
                table: "Columns",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "RoomId" },
                values: new object[] { new Guid("98ea72f0-c968-49be-8b07-a6c853bf0f9f"), "glowna", new Guid("dd20f32a-8709-4880-99bb-c58b4c701c77") });

            migrationBuilder.InsertData(
                table: "Place",
                columns: new[] { "Id", "Name", "ShelfId" },
                values: new object[] { new Guid("b7ff0113-c7e4-4fe2-adee-6a5a9e458308"), "srodek", new Guid("d28945ac-cf12-4367-8a35-8ef57652e5aa") });

            migrationBuilder.InsertData(
                table: "Rack",
                columns: new[] { "Id", "ColumnsId", "Name", "Side" },
                values: new object[] { new Guid("30daa3f2-7c48-4ffb-8732-205e0f4b27d5"), new Guid("98ea72f0-c968-49be-8b07-a6c853bf0f9f"), "1", false });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Name", "WarehouseId" },
                values: new object[] { new Guid("dd20f32a-8709-4880-99bb-c58b4c701c77"), "duzy", new Guid("b553eb42-2f93-4482-9cac-0cbf4c788c17") });

            migrationBuilder.InsertData(
                table: "Shelf",
                columns: new[] { "Id", "Name", "RackId" },
                values: new object[] { new Guid("d28945ac-cf12-4367-8a35-8ef57652e5aa"), "2", new Guid("30daa3f2-7c48-4ffb-8732-205e0f4b27d5") });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("b553eb42-2f93-4482-9cac-0cbf4c788c17"), "Martyna" });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "ColumnId", "ItemName", "PlaceId", "Quantity", "RackId", "RoomId", "ShelfId", "WarehouseId" },
                values: new object[] { new Guid("a6af9684-9641-4301-b0e6-00f0731c034f"), new Guid("98ea72f0-c968-49be-8b07-a6c853bf0f9f"), "Przedmiot", new Guid("b7ff0113-c7e4-4fe2-adee-6a5a9e458308"), 20, new Guid("30daa3f2-7c48-4ffb-8732-205e0f4b27d5"), new Guid("dd20f32a-8709-4880-99bb-c58b4c701c77"), new Guid("d28945ac-cf12-4367-8a35-8ef57652e5aa"), new Guid("b553eb42-2f93-4482-9cac-0cbf4c788c17") });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Columns_ColumnId",
                table: "Item",
                column: "ColumnId",
                principalTable: "Columns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Place_PlaceId",
                table: "Item",
                column: "PlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Rack_RackId",
                table: "Item",
                column: "RackId",
                principalTable: "Rack",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Room_RoomId",
                table: "Item",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Shelf_ShelfId",
                table: "Item",
                column: "ShelfId",
                principalTable: "Shelf",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Warehouse_WarehouseId",
                table: "Item",
                column: "WarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Warehouse_WarehouseId",
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

            migrationBuilder.DropIndex(
                name: "IX_Item_ShelfId",
                table: "Item");

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("a6af9684-9641-4301-b0e6-00f0731c034f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("98ea72f0-c968-49be-8b07-a6c853bf0f9f"));

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: new Guid("b7ff0113-c7e4-4fe2-adee-6a5a9e458308"));

            migrationBuilder.DeleteData(
                table: "Rack",
                keyColumn: "Id",
                keyValue: new Guid("30daa3f2-7c48-4ffb-8732-205e0f4b27d5"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("dd20f32a-8709-4880-99bb-c58b4c701c77"));

            migrationBuilder.DeleteData(
                table: "Shelf",
                keyColumn: "Id",
                keyValue: new Guid("d28945ac-cf12-4367-8a35-8ef57652e5aa"));

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "Id",
                keyValue: new Guid("b553eb42-2f93-4482-9cac-0cbf4c788c17"));

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

            migrationBuilder.DropColumn(
                name: "ShelfId",
                table: "Item");

            migrationBuilder.AlterColumn<Guid>(
                name: "RackId",
                table: "Shelf",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "WarehouseId",
                table: "Room",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "ColumnsId",
                table: "Rack",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "ShelfId",
                table: "Place",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "WarehouseId",
                table: "Item",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "ColumnModelId",
                table: "Item",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomId",
                table: "Columns",
                nullable: true,
                oldClrType: typeof(Guid));

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

            migrationBuilder.CreateIndex(
                name: "IX_Shelf_RackId",
                table: "Shelf",
                column: "RackId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_WarehouseId",
                table: "Room",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Rack_ColumnsId",
                table: "Rack",
                column: "ColumnsId");

            migrationBuilder.CreateIndex(
                name: "IX_Place_ShelfId",
                table: "Place",
                column: "ShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ColumnModelId",
                table: "Item",
                column: "ColumnModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Columns_RoomId",
                table: "Columns",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Columns_Room_RoomId",
                table: "Columns",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Columns_ColumnModelId",
                table: "Item",
                column: "ColumnModelId",
                principalTable: "Columns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Warehouse_WarehouseId",
                table: "Item",
                column: "WarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Place_Shelf_ShelfId",
                table: "Place",
                column: "ShelfId",
                principalTable: "Shelf",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rack_Columns_ColumnsId",
                table: "Rack",
                column: "ColumnsId",
                principalTable: "Columns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Warehouse_WarehouseId",
                table: "Room",
                column: "WarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shelf_Rack_RackId",
                table: "Shelf",
                column: "RackId",
                principalTable: "Rack",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
