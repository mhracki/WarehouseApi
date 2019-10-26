using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations.Warehouse
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("ae6b843c-f784-49dc-9ec8-e5e9f06d5e01"));

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: new Guid("a15d5759-1b4c-4d0d-911e-b73bf3e19001"));

            migrationBuilder.DeleteData(
                table: "Shelf",
                keyColumn: "Id",
                keyValue: new Guid("7d9276e3-514e-4cbc-9c73-cb131a2f8dc3"));

            migrationBuilder.DeleteData(
                table: "Rack",
                keyColumn: "Id",
                keyValue: new Guid("0c93db94-0862-4987-bb71-02d87e548c73"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("72465a96-36e7-4649-bc15-31da8250c7de"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("b374df7e-024c-4fb7-8919-5c0cbe41a4da"));

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "Id",
                keyValue: new Guid("55ec8da9-910f-4794-a142-aad7cc39d32f"));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
