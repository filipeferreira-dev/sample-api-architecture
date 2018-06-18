using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductUuid",
                table: "Product",
                type: "varchar(36)",
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 36,
                oldDefaultValueSql: "newid()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductUuid",
                table: "Product",
                type: "varchar",
                maxLength: 36,
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(string),
                oldType: "varchar(36)",
                oldDefaultValueSql: "newid()");
        }
    }
}
