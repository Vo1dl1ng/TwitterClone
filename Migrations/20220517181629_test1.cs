using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwitterClone.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tweets",
                columns: new[] { "Id", "Likes", "Message", "PostedTime", "Shares", "TweetId", "UserId" },
                values: new object[] { 1, 3, "Hello World!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
