﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class soft : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    StreetAddress = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    ProductTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.ProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentType",
                columns: table => new
                {
                    PaymentTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Description = table.Column<string>(maxLength: 55, nullable: false),
                    AccountNumber = table.Column<string>(maxLength: 20, nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.PaymentTypeId);
                    table.ForeignKey(
                        name: "FK_PaymentType_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Title = table.Column<string>(maxLength: 55, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    DateCompleted = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<string>(nullable: false),
                    PaymentTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_PaymentType_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentType",
                        principalColumn: "PaymentTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrderProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => x.OrderProductId);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "7302ac71-7b15-43ce-a745-633d494588fc", "admin@admin.com", true, "Admina", "Straytor", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEC4nz0ptqERZof9x1037MTMbo1clHIMWHwZApkQBqaR1r82ilCKHni1aY1aMqA/Vaw==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", "123 Infinity Way", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "ProductTypeId", "Label" },
                values: new object[,]
                {
                    { 1, "Sporting Goods" },
                    { 2, "Appliances" },
                    { 3, "Tools" },
                    { 4, "Games" },
                    { 5, "Music" },
                    { 6, "Health" },
                    { 7, "Outdoors" },
                    { 8, "Beauty" },
                    { 9, "Shoes" },
                    { 10, "Automotive" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "DateCompleted", "PaymentTypeId", "UserId" },
                values: new object[] { 1, null, null, "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "PaymentType",
                columns: new[] { "PaymentTypeId", "AccountNumber", "Active", "Description", "UserId" },
                values: new object[] { 1, "86753095551212", true, "American Express", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "PaymentType",
                columns: new[] { "PaymentTypeId", "AccountNumber", "Active", "Description", "UserId" },
                values: new object[] { 2, "4102948572991", true, "Discover", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 19, true, null, "88 Keys digital piano", null, 1099.99, 5, 10, "Keyboard", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 22, true, null, "I play", null, 10.69, 4, 3, "Dungeon Crawler", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 18, true, null, "Learn words and have fun", null, 2.9900000000000002, 4, 50, "Scrabble", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 17, true, null, "Tie yourself in knots", null, 29.989999999999998, 4, 10, "Twister", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 16, true, null, "Fun for the whole family", null, 12.99, 4, 200, "Monopoly", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 15, true, null, "Jack up your car", null, 99.989999999999995, 3, 50, "Pump Jack", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 14, true, null, "Unclog a drin with this", null, 2.9900000000000002, 3, 100, "Plunger", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 13, true, null, "Smooth rough surfaces, orbitally", null, 39.990000000000002, 3, 50, "Orbital Sander", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 6, true, null, "It puts things together", null, 21.690000000000001, 3, 32, "Wrench", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 5, true, null, "It puts things together", null, 22.690000000000001, 3, 32, "Hammer", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 4, true, null, "It puts holes in things", null, 24.890000000000001, 3, 12, "Electric Drill", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 3, true, null, "It cuts things", null, 31.489999999999998, 3, 18, "Saw", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 12, true, null, "Clean your dirty duds", null, 299.99000000000001, 2, 10, "Washing Maching", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 11, true, null, "Cleans dirty dishes", null, 199.99000000000001, 2, 10, "Dishwasher", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 10, true, null, "Clothes get dry in it", null, 449.99000000000001, 2, 25, "Dryer", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 2, true, null, "It rolls fast", null, 29.989999999999998, 2, 5, "Wheelbarrow", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 9, true, null, "Catch fish with this", null, 2.9900000000000002, 1, 100, "Fishing Rod", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 8, true, null, "21 Speed Mountain bike", null, 499.99000000000001, 1, 50, "Bicycle", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 7, true, null, "Get on the river", null, 249.99000000000001, 1, 30, "Canoe", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 1, true, null, "It flies high", null, 2.9900000000000002, 1, 100, "Kite", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 20, true, null, "6 string acoustic", null, 299.99000000000001, 5, 20, "Guitar", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 21, true, null, "Plug in and practice your rhythm", null, 599.99000000000001, 5, 15, "Electric Drum Set", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "OrderProduct",
                columns: new[] { "OrderProductId", "OrderId", "ProductId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "OrderProduct",
                columns: new[] { "OrderProductId", "OrderId", "ProductId" },
                values: new object[] { 2, 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentTypeId",
                table: "Order",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_OrderId",
                table: "OrderProduct",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentType_UserId",
                table: "PaymentType",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductTypeId",
                table: "Product",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UserId",
                table: "Product",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "PaymentType");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
