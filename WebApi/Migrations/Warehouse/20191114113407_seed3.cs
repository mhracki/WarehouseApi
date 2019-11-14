using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations.Warehouse
{
    public partial class seed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Side",
                table: "Rack");

            migrationBuilder.RenameColumn(
                name: "RackId",
                table: "Shelf",
                newName: "SideId");

            migrationBuilder.AddColumn<Guid>(
                name: "SideId",
                table: "Item",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Side",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RackId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Side", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "RoomId" },
                values: new object[,]
                {
                    { new Guid("13206fd2-49e0-4221-8351-d84aea7f4aef"), "glowna", new Guid("1a00f373-fa09-448c-944c-ada6ab18af19") },
                    { new Guid("b4b59f14-f80b-4ceb-8373-d5c6a1aaaa0a"), "boczna", new Guid("1a00f373-fa09-448c-944c-ada6ab18af19") }
                });

            migrationBuilder.InsertData(
                table: "Place",
                columns: new[] { "Id", "Name", "ShelfId" },
                values: new object[,]
                {
                    { new Guid("3322ed60-de81-4b85-b4d6-26634c5bfcb8"), "srodek", new Guid("837e266f-a553-4ba2-8709-a8fd33d34ce1") },
                    { new Guid("3104557b-e8cd-4bcf-bae5-2013d447b9cc"), "srodek", new Guid("2d732ade-105e-4f58-a047-3eb86619044a") },
                    { new Guid("3bf832d4-90b4-469a-8932-b879cfb1485b"), "srodek", new Guid("2c39d693-7b6f-47ee-bde7-4f10ea8b5726") },
                    { new Guid("c68cb847-f9e0-4b2a-b570-f36f0938ce9a"), "srodek", new Guid("09b9ea1c-bb99-48ad-b8f1-caa323f0d4d4") },
                    { new Guid("23ef368b-c23c-4010-874d-5a80a5b74621"), "poczatek", new Guid("279cb11b-3056-4e30-b185-47964b851b69") },
                    { new Guid("a1db5294-7e66-4dc5-b2e7-8905500250b8"), "koniec", new Guid("279cb11b-3056-4e30-b185-47964b851b69") }
                });

            migrationBuilder.InsertData(
                table: "Rack",
                columns: new[] { "Id", "ColumnsId", "Name" },
                values: new object[,]
                {
                    { new Guid("ca243217-66de-497e-9af7-2085627a9e40"), new Guid("b4b59f14-f80b-4ceb-8373-d5c6a1aaaa0a"), "1" },
                    { new Guid("16f7c8e2-990e-4f64-9805-7cde202f32bf"), new Guid("b4b59f14-f80b-4ceb-8373-d5c6a1aaaa0a"), "2" },
                    { new Guid("f6a93814-cb11-4a99-8659-47a64b209d87"), new Guid("13206fd2-49e0-4221-8351-d84aea7f4aef"), "1" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Name", "WarehouseId" },
                values: new object[] { new Guid("1a00f373-fa09-448c-944c-ada6ab18af19"), "duzy", new Guid("4ee12178-18d2-4014-b07a-4e202c2dfa81") });

            migrationBuilder.InsertData(
                table: "Shelf",
                columns: new[] { "Id", "Name", "SideId" },
                values: new object[,]
                {
                    { new Guid("837e266f-a553-4ba2-8709-a8fd33d34ce1"), "2", new Guid("3747aa08-5b1c-489d-9de0-d651ef339384") },
                    { new Guid("2d732ade-105e-4f58-a047-3eb86619044a"), "2", new Guid("ab2231ef-660d-4288-801c-bf5afddc6646") },
                    { new Guid("2c39d693-7b6f-47ee-bde7-4f10ea8b5726"), "2", new Guid("b8d92626-9ec5-4979-8b00-3d868014bf9a") },
                    { new Guid("09b9ea1c-bb99-48ad-b8f1-caa323f0d4d4"), "2", new Guid("d7681aa0-372b-4d2e-a664-77d6734ae497") },
                    { new Guid("279cb11b-3056-4e30-b185-47964b851b69"), "3", new Guid("d7681aa0-372b-4d2e-a664-77d6734ae497") }
                });

            migrationBuilder.InsertData(
                table: "Side",
                columns: new[] { "Id", "Name", "RackId" },
                values: new object[,]
                {
                    { new Guid("d7681aa0-372b-4d2e-a664-77d6734ae497"), "2", new Guid("16f7c8e2-990e-4f64-9805-7cde202f32bf") },
                    { new Guid("3747aa08-5b1c-489d-9de0-d651ef339384"), "1", new Guid("f6a93814-cb11-4a99-8659-47a64b209d87") },
                    { new Guid("ab2231ef-660d-4288-801c-bf5afddc6646"), "1", new Guid("ca243217-66de-497e-9af7-2085627a9e40") },
                    { new Guid("b8d92626-9ec5-4979-8b00-3d868014bf9a"), "1", new Guid("16f7c8e2-990e-4f64-9805-7cde202f32bf") }
                });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("4ee12178-18d2-4014-b07a-4e202c2dfa81"), "Martyna" });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "ColumnId", "ItemName", "PlaceId", "Quantity", "RackId", "RoomId", "ShelfId", "SideId", "WarehouseId" },
                values: new object[,]
                {
                    { new Guid("323751b8-f1ae-4cb1-9a87-48297a73bc4a"), new Guid("13206fd2-49e0-4221-8351-d84aea7f4aef"), "Przedmiot", new Guid("3322ed60-de81-4b85-b4d6-26634c5bfcb8"), 20, new Guid("f6a93814-cb11-4a99-8659-47a64b209d87"), new Guid("1a00f373-fa09-448c-944c-ada6ab18af19"), new Guid("837e266f-a553-4ba2-8709-a8fd33d34ce1"), new Guid("3747aa08-5b1c-489d-9de0-d651ef339384"), new Guid("4ee12178-18d2-4014-b07a-4e202c2dfa81") },
                    { new Guid("14610eaf-c519-4751-abe9-3bd576548c89"), new Guid("b4b59f14-f80b-4ceb-8373-d5c6a1aaaa0a"), "Przedmiot", new Guid("3104557b-e8cd-4bcf-bae5-2013d447b9cc"), 20, new Guid("ca243217-66de-497e-9af7-2085627a9e40"), new Guid("1a00f373-fa09-448c-944c-ada6ab18af19"), new Guid("2d732ade-105e-4f58-a047-3eb86619044a"), new Guid("ab2231ef-660d-4288-801c-bf5afddc6646"), new Guid("4ee12178-18d2-4014-b07a-4e202c2dfa81") },
                    { new Guid("ed8fec3a-f6ac-47ae-93f6-59cf3dd4f7dd"), new Guid("b4b59f14-f80b-4ceb-8373-d5c6a1aaaa0a"), "Przedmiot", new Guid("3bf832d4-90b4-469a-8932-b879cfb1485b"), 20, new Guid("16f7c8e2-990e-4f64-9805-7cde202f32bf"), new Guid("1a00f373-fa09-448c-944c-ada6ab18af19"), new Guid("2c39d693-7b6f-47ee-bde7-4f10ea8b5726"), new Guid("b8d92626-9ec5-4979-8b00-3d868014bf9a"), new Guid("4ee12178-18d2-4014-b07a-4e202c2dfa81") },
                    { new Guid("63239988-86d3-494a-a3dc-6b6199dbd3cd"), new Guid("b4b59f14-f80b-4ceb-8373-d5c6a1aaaa0a"), "Przedmiot", new Guid("c68cb847-f9e0-4b2a-b570-f36f0938ce9a"), 20, new Guid("16f7c8e2-990e-4f64-9805-7cde202f32bf"), new Guid("1a00f373-fa09-448c-944c-ada6ab18af19"), new Guid("09b9ea1c-bb99-48ad-b8f1-caa323f0d4d4"), new Guid("d7681aa0-372b-4d2e-a664-77d6734ae497"), new Guid("4ee12178-18d2-4014-b07a-4e202c2dfa81") },
                    { new Guid("f0d09218-fc99-4b14-b7e7-63a50283130c"), new Guid("b4b59f14-f80b-4ceb-8373-d5c6a1aaaa0a"), "Przedmiot", new Guid("23ef368b-c23c-4010-874d-5a80a5b74621"), 20, new Guid("16f7c8e2-990e-4f64-9805-7cde202f32bf"), new Guid("1a00f373-fa09-448c-944c-ada6ab18af19"), new Guid("279cb11b-3056-4e30-b185-47964b851b69"), new Guid("d7681aa0-372b-4d2e-a664-77d6734ae497"), new Guid("4ee12178-18d2-4014-b07a-4e202c2dfa81") },
                    { new Guid("6ae171ed-6f86-4070-8f4a-3b8ca4215549"), new Guid("b4b59f14-f80b-4ceb-8373-d5c6a1aaaa0a"), "Przedmiot", new Guid("a1db5294-7e66-4dc5-b2e7-8905500250b8"), 20, new Guid("16f7c8e2-990e-4f64-9805-7cde202f32bf"), new Guid("1a00f373-fa09-448c-944c-ada6ab18af19"), new Guid("279cb11b-3056-4e30-b185-47964b851b69"), new Guid("d7681aa0-372b-4d2e-a664-77d6734ae497"), new Guid("4ee12178-18d2-4014-b07a-4e202c2dfa81") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_SideId",
                table: "Item",
                column: "SideId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Side_SideId",
                table: "Item",
                column: "SideId",
                principalTable: "Side",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Side_SideId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "Side");

            migrationBuilder.DropIndex(
                name: "IX_Item_SideId",
                table: "Item");

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("14610eaf-c519-4751-abe9-3bd576548c89"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("323751b8-f1ae-4cb1-9a87-48297a73bc4a"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("63239988-86d3-494a-a3dc-6b6199dbd3cd"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("6ae171ed-6f86-4070-8f4a-3b8ca4215549"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("ed8fec3a-f6ac-47ae-93f6-59cf3dd4f7dd"));

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: new Guid("f0d09218-fc99-4b14-b7e7-63a50283130c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("13206fd2-49e0-4221-8351-d84aea7f4aef"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b4b59f14-f80b-4ceb-8373-d5c6a1aaaa0a"));

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: new Guid("23ef368b-c23c-4010-874d-5a80a5b74621"));

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: new Guid("3104557b-e8cd-4bcf-bae5-2013d447b9cc"));

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: new Guid("3322ed60-de81-4b85-b4d6-26634c5bfcb8"));

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: new Guid("3bf832d4-90b4-469a-8932-b879cfb1485b"));

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: new Guid("a1db5294-7e66-4dc5-b2e7-8905500250b8"));

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: new Guid("c68cb847-f9e0-4b2a-b570-f36f0938ce9a"));

            migrationBuilder.DeleteData(
                table: "Rack",
                keyColumn: "Id",
                keyValue: new Guid("16f7c8e2-990e-4f64-9805-7cde202f32bf"));

            migrationBuilder.DeleteData(
                table: "Rack",
                keyColumn: "Id",
                keyValue: new Guid("ca243217-66de-497e-9af7-2085627a9e40"));

            migrationBuilder.DeleteData(
                table: "Rack",
                keyColumn: "Id",
                keyValue: new Guid("f6a93814-cb11-4a99-8659-47a64b209d87"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: new Guid("1a00f373-fa09-448c-944c-ada6ab18af19"));

            migrationBuilder.DeleteData(
                table: "Shelf",
                keyColumn: "Id",
                keyValue: new Guid("09b9ea1c-bb99-48ad-b8f1-caa323f0d4d4"));

            migrationBuilder.DeleteData(
                table: "Shelf",
                keyColumn: "Id",
                keyValue: new Guid("279cb11b-3056-4e30-b185-47964b851b69"));

            migrationBuilder.DeleteData(
                table: "Shelf",
                keyColumn: "Id",
                keyValue: new Guid("2c39d693-7b6f-47ee-bde7-4f10ea8b5726"));

            migrationBuilder.DeleteData(
                table: "Shelf",
                keyColumn: "Id",
                keyValue: new Guid("2d732ade-105e-4f58-a047-3eb86619044a"));

            migrationBuilder.DeleteData(
                table: "Shelf",
                keyColumn: "Id",
                keyValue: new Guid("837e266f-a553-4ba2-8709-a8fd33d34ce1"));

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "Id",
                keyValue: new Guid("4ee12178-18d2-4014-b07a-4e202c2dfa81"));

            migrationBuilder.DropColumn(
                name: "SideId",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "SideId",
                table: "Shelf",
                newName: "RackId");

            migrationBuilder.AddColumn<bool>(
                name: "Side",
                table: "Rack",
                nullable: false,
                defaultValue: false);

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
        }
    }
}
