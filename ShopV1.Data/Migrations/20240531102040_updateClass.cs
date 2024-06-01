using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopV1.Data.Migrations
{
    public partial class updateClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6a3032d4-a9f6-403c-990e-64cd2e429529");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce5f0923-f738-4d16-a98d-c8f0e8fa5440", "AQAAAAEAACcQAAAAEHXoyEEkk9+0WxMChOhA+onneL+AySluC47a/Cq4Lws3nH9P6STSCBbggV/Dps5g7A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 17, 20, 39, 546, DateTimeKind.Local).AddTicks(9114));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "99fac2b3-f717-4a6b-8090-0ca738c58363");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "17de6a9d-9ec3-4044-be73-df680d7bc50d", "AQAAAAEAACcQAAAAEEiZI4v2uGoQ8iIMULGGqbFtJyJLbho3/RIdlNj8Oc/WYa4UJOvOUllpA8w2LCPrRQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 16, 3, 25, 567, DateTimeKind.Local).AddTicks(9914));
        }
    }
}
