using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwitterClone.Migrations
{
    public partial class tweets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Shares", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Tweets",
                columns: new[] { "Id", "Likes", "Message", "PostedTime", "Shares", "TweetId", "UserId" },
                values: new object[,]
                {
                    { 2, 2, "What website is this?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 2 },
                    { 3, 6, "It's sunny today", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, 3 },
                    { 4, 9, "aaaannd it started raining T_T", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, null, 3 },
                    { 5, 5, "went hiking today", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ImageURL", "TwitterHandle", "UserName" },
                values: new object[,]
                {
                    { 1, "ExampleUrl", "ExampleHandle", "ExampleName" },
                    { 2, "TesteUrl", "TestHandle", "TestName" },
                    { 3, "TesterUrl", "TesterHandle", "TesterName" },
                    { 4, "BetaUrl", "BetaHandle", "BetaName" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Shares", "UserId" },
                values: new object[] { 0, 0 });
        }
    }
}
