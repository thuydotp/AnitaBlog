using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnitaBlog.Migrations
{
    public partial class SeedDatabase : Migration
    {
        public Guid sysAdminId = Guid.NewGuid();

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Accounts (ID, Username, DisplayedName) VALUES ('" + sysAdminId + "','thuydo' ,'Thuy Do Thi Phuong')");

            migrationBuilder.Sql("INSERT INTO Categories (ID, Name) VALUES('" + Guid.NewGuid() + "','Dotnet Core')");
            migrationBuilder.Sql("INSERT INTO Categories (ID, Name) VALUES('" + Guid.NewGuid() + "','VueJs')");
            migrationBuilder.Sql("INSERT INTO Categories (ID, Name) VALUES('" + Guid.NewGuid() + "','Angular')");
            migrationBuilder.Sql("INSERT INTO Categories (ID, Name) VALUES('" + Guid.NewGuid() + "','Others')");
            
            migrationBuilder.Sql("INSERT INTO Articles (ID, Title ,CreatedDate ,UpdatedDate ,MainContent ,AuthorId) VALUES ('" + Guid.NewGuid() + "','Welcome to Anita''s Blog' ,'"+ DateTime.UtcNow +"','"+ DateTime.UtcNow +"' ,'Hi Dear, <br/> Be the first one who write the story. <br/>Cheers,<br/>Anita' ,'"+ sysAdminId +"')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From Accounts where ID = '"+ sysAdminId +"'");
            migrationBuilder.Sql("Delete From Categories");
            migrationBuilder.Sql("Delete From Articles");
        }
    }
}
