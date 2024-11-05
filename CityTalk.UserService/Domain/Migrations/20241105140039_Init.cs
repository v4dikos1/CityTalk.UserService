using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_business_information_account_account_id1",
                table: "business_information");

            migrationBuilder.DropForeignKey(
                name: "fk_chat_user_bind_chat_chat_id1",
                table: "chat_user_bind");

            migrationBuilder.DropForeignKey(
                name: "fk_organization_account_account_id",
                table: "organization");

            migrationBuilder.DropForeignKey(
                name: "fk_user_read_message_message_message_id1",
                table: "user_read_message");

            migrationBuilder.DropIndex(
                name: "ix_user_read_message_message_id1",
                table: "user_read_message");

            migrationBuilder.DropIndex(
                name: "ix_organization_account_id",
                table: "organization");

            migrationBuilder.DropIndex(
                name: "ix_chat_user_bind_chat_id1",
                table: "chat_user_bind");

            migrationBuilder.DropIndex(
                name: "ix_business_information_account_id1",
                table: "business_information");

            migrationBuilder.DropColumn(
                name: "message_id1",
                table: "user_read_message");

            migrationBuilder.DropColumn(
                name: "account_id",
                table: "organization");

            migrationBuilder.DropColumn(
                name: "chat_id1",
                table: "chat_user_bind");

            migrationBuilder.DropColumn(
                name: "account_id1",
                table: "business_information");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "message_id1",
                table: "user_read_message",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "account_id",
                table: "organization",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "chat_id1",
                table: "chat_user_bind",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "account_id1",
                table: "business_information",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_user_read_message_message_id1",
                table: "user_read_message",
                column: "message_id1");

            migrationBuilder.CreateIndex(
                name: "ix_organization_account_id",
                table: "organization",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "ix_chat_user_bind_chat_id1",
                table: "chat_user_bind",
                column: "chat_id1");

            migrationBuilder.CreateIndex(
                name: "ix_business_information_account_id1",
                table: "business_information",
                column: "account_id1",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_business_information_account_account_id1",
                table: "business_information",
                column: "account_id1",
                principalTable: "account",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_chat_user_bind_chat_chat_id1",
                table: "chat_user_bind",
                column: "chat_id1",
                principalTable: "chat",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_organization_account_account_id",
                table: "organization",
                column: "account_id",
                principalTable: "account",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_user_read_message_message_message_id1",
                table: "user_read_message",
                column: "message_id1",
                principalTable: "message",
                principalColumn: "id");
        }
    }
}
