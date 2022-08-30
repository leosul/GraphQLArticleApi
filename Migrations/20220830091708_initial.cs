using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQLApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrossValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("027dd28c-deaf-eb60-24a2-58510c3dacf9"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(377), false, "Célia Andrade", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(379) },
                    { new Guid("032c8f96-89df-993b-886e-bd1639ae9618"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(256), true, "Duarte Carvalho", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(258) },
                    { new Guid("034fef44-111a-a4e7-132d-6828b1d0e143"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(459), true, "Ângelo Marques", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(460) },
                    { new Guid("09f1414f-a259-5d89-9ec0-5b52367eb543"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(268), false, "Melissa Costa", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(269) },
                    { new Guid("0df694b2-cb21-1c3e-b1f8-81f5c42c64fd"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(629), false, "João Loureiro", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(630) },
                    { new Guid("16d16709-6fc9-aad6-ef9d-74519a69e8d7"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(319), true, "Francisca Sousa", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(320) },
                    { new Guid("177914f7-5534-4f8e-f1a8-e42fa8cf109c"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(330), false, "Maria Melo", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(331) },
                    { new Guid("23e8961b-746c-a834-d2f0-6c7604251a3a"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(437), true, "Salvador Ferreira", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(438) },
                    { new Guid("28e1d4fb-89d6-fa5b-d68e-2cf52ce3ddf7"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(366), false, "Vicente Raposo", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(367) },
                    { new Guid("2cebdaf2-f1fe-f6fc-fdbc-5d970d472462"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(706), false, "Camila Magalhães", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(707) },
                    { new Guid("2ffa2eba-2edb-4919-e263-f11d48f879e5"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(718), true, "Artur Monteiro", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(719) },
                    { new Guid("37f5b748-f1ff-a5a7-65c0-fe9bb309ca20"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(218), true, "Luana Oliveira", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(219) },
                    { new Guid("39d1e188-9439-3ce0-c150-9cf5314e3e04"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(125), true, "Matilde Ferreira", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(126) },
                    { new Guid("3dcadc4b-aa3d-b930-945f-1cf191625195"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(496), true, "Nicole Batista", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(497) },
                    { new Guid("3f20db10-024e-dfd6-a719-4857243a9889"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(412), false, "Tatiana Cruz", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(414) },
                    { new Guid("4460c200-355a-31bd-bcf2-22d03d10b82c"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(570), false, "Diogo Fonseca", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(571) },
                    { new Guid("44c45e62-9ca5-023b-9dc4-26bddc0231f7"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(447), true, "Débora Amaral", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(449) },
                    { new Guid("46c7bcb3-5575-5e07-a618-86b5fa4bc447"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(607), false, "Carlos Correia", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(608) },
                    { new Guid("510d7fc5-b00b-c557-f7b0-0592a28a38ae"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(485), true, "Hugo Simões", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(486) },
                    { new Guid("5bc6fee3-93b5-12c4-c219-a7691960251d"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(517), true, "Júlio Castro", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(519) },
                    { new Guid("5e0efbdb-f195-7a88-6b47-e1e412f96b26"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(245), false, "Rúben Saraiva", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(246) },
                    { new Guid("5e3d9486-02e2-94bf-aa3d-821c260dec27"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(596), true, "Rosa Amorim", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(597) },
                    { new Guid("6bbe50de-9d99-61d9-38e8-dd725bd7c5c8"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(282), false, "Gaspar Garcia", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(283) },
                    { new Guid("6c1c4534-be8c-c2a6-d116-3c19ae1f0b56"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(508), false, "Débora Carneiro", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(509) },
                    { new Guid("6fbc7d12-fdfd-1ae8-5d4e-961402bb912c"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(296), false, "Leonardo Martins", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(297) },
                    { new Guid("8a1f65ab-7a17-d95e-b9aa-d831079fb217"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(180), false, "Tomé Martins", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(182) },
                    { new Guid("8e29d7db-5630-29f6-ddca-60192f66ba8f"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(528), false, "Eduardo Cunha", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(529) },
                    { new Guid("8eaa7c51-4d3f-8130-b864-c56d66eaeee7"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(660), false, "Simão Campos", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(662) },
                    { new Guid("913a7460-5a92-caa7-b29b-5ae180d90411"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(390), true, "Francisco Brito", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(392) },
                    { new Guid("95284686-8903-a2ba-be4f-8b4596038776"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(582), true, "Vicente Pinto", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(583) },
                    { new Guid("952d30a2-933d-5484-726f-1a37ad2c4403"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(738), false, "Tomé Carvalho", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(739) },
                    { new Guid("9759376b-1507-6815-d284-0d039a760775"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(232), true, "Filipe Pinheiro", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(234) },
                    { new Guid("a11635a8-5bcf-e2e9-c02c-82cb4133e239"), new DateTime(2022, 8, 30, 10, 16, 15, 57, DateTimeKind.Local).AddTicks(9811), true, "Tatiana Carneiro", new DateTime(2022, 8, 30, 10, 16, 15, 57, DateTimeKind.Local).AddTicks(9843) },
                    { new Guid("a5fdccec-eebb-b72d-c19f-5047b9117b78"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(650), true, "Ângelo Gonçalves", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(651) },
                    { new Guid("a9f2f10f-c683-3431-54ac-ddbbccf48026"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(342), true, "Paulo Monteiro", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(344) },
                    { new Guid("b1e1a113-fdf7-7550-a220-17096d5c1e87"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(684), false, "Tomás Tavares", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(685) },
                    { new Guid("bc14ae4e-2faa-c21b-3d73-961df0ee18a2"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(307), true, "Catarina Assunção", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(308) },
                    { new Guid("bcf45a97-0fd6-07e3-6c56-d9696decfd6d"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(102), false, "Hugo Guerreiro", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(104) },
                    { new Guid("c2523d56-2fc5-5311-65e7-685102f00de0"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(728), true, "Juliana Cunha", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(729) },
                    { new Guid("c8538da7-2dc0-e0ce-aeb2-bf8976ad59d0"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(672), false, "Miguel Nobre", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(673) },
                    { new Guid("d148b4e6-ff76-32db-4fad-318146507d6f"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(539), true, "Clara Batista", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(540) },
                    { new Guid("d6d185fe-6c0f-445b-d270-c2b10b59cc53"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(354), true, "Carlos Monteiro", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(355) }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("d99c821e-13f9-9414-593d-fe4ef0ac1f39"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(140), true, "Elias Cruz", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(142) },
                    { new Guid("da9f0f06-19e1-c834-a985-e6f020743a60"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(402), true, "Tatiana Silva", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(403) },
                    { new Guid("e7ef71c1-d6db-c175-ab7a-f3e33457d7ee"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(618), true, "Ana Matias", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(619) },
                    { new Guid("e93353c7-75ae-d2ea-b3b1-cb974c4a126c"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(694), false, "Norberto Barbosa", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(696) },
                    { new Guid("f030ab10-5450-c1a1-8e70-9b71b3665e9d"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(165), false, "Ivo Teixeira", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(167) },
                    { new Guid("f3676bf8-b41a-3b21-9ca9-64ed7de04b03"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(640), false, "Nicole Pinheiro", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(641) },
                    { new Guid("fbf984cf-b37d-cbb1-6b3f-ce1a59433e37"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(471), true, "Mia Nascimento", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(472) },
                    { new Guid("fce495a4-0191-ecc7-7dd7-b36045a018e6"), new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(422), false, "Micael Lopes", new DateTime(2022, 8, 30, 10, 16, 15, 58, DateTimeKind.Local).AddTicks(424) }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerId", "GrossValue", "InvoiceDate", "InvoiceNumber", "NetValue" },
                values: new object[,]
                {
                    { new Guid("010b85b1-7c25-7ef8-afda-a9bd81890fa6"), new Guid("3dcadc4b-aa3d-b930-945f-1cf191625195"), 8.46m, new DateTime(2022, 1, 23, 14, 42, 39, 995, DateTimeKind.Local).AddTicks(8351), "6GGWCS3F", 2m },
                    { new Guid("0114c3f7-d8d4-8985-e0f6-0ebfab724053"), new Guid("fce495a4-0191-ecc7-7dd7-b36045a018e6"), 13.53m, new DateTime(2020, 9, 6, 14, 7, 27, 783, DateTimeKind.Local).AddTicks(6288), "F4O5YYOC", 8m },
                    { new Guid("025ab0cf-e2e1-5dd4-29f4-06cbbf53160c"), new Guid("16d16709-6fc9-aad6-ef9d-74519a69e8d7"), 5.88m, new DateTime(2022, 6, 30, 10, 8, 15, 407, DateTimeKind.Local).AddTicks(9213), "C3PILVG6", 2m },
                    { new Guid("025afba6-a056-8236-016d-3a0c2dd7692b"), new Guid("16d16709-6fc9-aad6-ef9d-74519a69e8d7"), 8.33m, new DateTime(2022, 8, 14, 23, 27, 38, 575, DateTimeKind.Local).AddTicks(8498), "HDQ3BIOP", 5m },
                    { new Guid("028c1be8-8a89-2162-d090-adc81810e6e2"), new Guid("46c7bcb3-5575-5e07-a618-86b5fa4bc447"), 2.86m, new DateTime(2021, 4, 12, 12, 43, 50, 371, DateTimeKind.Local).AddTicks(6706), "QFH1WU64", 3m },
                    { new Guid("0354f7c4-0c0c-0dfe-4258-9e383086ce36"), new Guid("d6d185fe-6c0f-445b-d270-c2b10b59cc53"), 7.37m, new DateTime(2019, 10, 26, 20, 37, 27, 720, DateTimeKind.Local).AddTicks(7860), "SA20YZDY", 7m },
                    { new Guid("0388e0d5-7d08-6054-f65f-cbd317978865"), new Guid("034fef44-111a-a4e7-132d-6828b1d0e143"), 11.21m, new DateTime(2022, 6, 11, 17, 44, 40, 223, DateTimeKind.Local).AddTicks(9417), "ZE0XPNSK", 4m },
                    { new Guid("044af690-4fad-a600-0429-2d11befcd99a"), new Guid("fce495a4-0191-ecc7-7dd7-b36045a018e6"), 2.96m, new DateTime(2019, 10, 10, 16, 59, 51, 484, DateTimeKind.Local).AddTicks(1440), "5LJVVXS2", 3m },
                    { new Guid("05798a92-43ad-4955-6e80-ac0cb79ddd6a"), new Guid("46c7bcb3-5575-5e07-a618-86b5fa4bc447"), 8.40m, new DateTime(2019, 12, 10, 22, 53, 56, 533, DateTimeKind.Local).AddTicks(9461), "RSKF2LS2", 3m },
                    { new Guid("05c26a78-9610-8150-7919-581354dc1f91"), new Guid("6c1c4534-be8c-c2a6-d116-3c19ae1f0b56"), 2.36m, new DateTime(2022, 8, 9, 21, 0, 5, 949, DateTimeKind.Local).AddTicks(8640), "1X047FFV", 4m },
                    { new Guid("0780c36f-0991-d147-41e9-935cfcbacda5"), new Guid("d99c821e-13f9-9414-593d-fe4ef0ac1f39"), 7.04m, new DateTime(2019, 10, 22, 1, 38, 26, 255, DateTimeKind.Local).AddTicks(1708), "L1Q4OOFS", 7m },
                    { new Guid("07afc7c5-16e9-7a09-6eee-9a00b2629dbf"), new Guid("44c45e62-9ca5-023b-9dc4-26bddc0231f7"), 8.03m, new DateTime(2020, 9, 11, 10, 11, 22, 284, DateTimeKind.Local).AddTicks(8960), "24VVRT03", 3m },
                    { new Guid("07c8b8d2-6596-804a-a447-d7e27a497146"), new Guid("510d7fc5-b00b-c557-f7b0-0592a28a38ae"), 5.95m, new DateTime(2022, 2, 22, 13, 3, 52, 69, DateTimeKind.Local).AddTicks(6325), "WSO4RRTC", 3m },
                    { new Guid("0959db13-b4b9-97c3-42ce-4a889462e4e5"), new Guid("fce495a4-0191-ecc7-7dd7-b36045a018e6"), 10.93m, new DateTime(2020, 10, 19, 14, 3, 13, 556, DateTimeKind.Local).AddTicks(1185), "22WP4VM0", 8m },
                    { new Guid("098c9759-69a2-bc24-94fe-375329d112d0"), new Guid("6fbc7d12-fdfd-1ae8-5d4e-961402bb912c"), 8.52m, new DateTime(2021, 9, 22, 17, 3, 57, 135, DateTimeKind.Local).AddTicks(3190), "KXKZ9QRA", 7m },
                    { new Guid("0c973b86-9894-602b-d1a8-12ef43b35b2e"), new Guid("46c7bcb3-5575-5e07-a618-86b5fa4bc447"), 1.44m, new DateTime(2021, 12, 10, 6, 31, 15, 266, DateTimeKind.Local).AddTicks(2862), "1MEWI0AU", 5m },
                    { new Guid("0cf560fd-8ecd-4796-fba9-2ce05148bc57"), new Guid("177914f7-5534-4f8e-f1a8-e42fa8cf109c"), 1.65m, new DateTime(2022, 4, 8, 12, 45, 39, 780, DateTimeKind.Local).AddTicks(9844), "08O11676", 2m },
                    { new Guid("0df10c71-d7f5-ecda-932e-c340e30f5dc8"), new Guid("2ffa2eba-2edb-4919-e263-f11d48f879e5"), 2.68m, new DateTime(2021, 9, 22, 16, 45, 1, 347, DateTimeKind.Local).AddTicks(3018), "ZZ4SLGSA", 7m },
                    { new Guid("0e01b7de-723e-6387-8548-98b37a9023bc"), new Guid("46c7bcb3-5575-5e07-a618-86b5fa4bc447"), 2.38m, new DateTime(2021, 7, 10, 18, 38, 52, 214, DateTimeKind.Local).AddTicks(9378), "H5EY58RW", 2m },
                    { new Guid("0f5610e3-1ec5-7a36-d7dc-7afe97e63a0c"), new Guid("f3676bf8-b41a-3b21-9ca9-64ed7de04b03"), 1.78m, new DateTime(2020, 10, 26, 20, 48, 45, 445, DateTimeKind.Local).AddTicks(190), "V46YSL79", 2m },
                    { new Guid("0f9d6504-42f1-34d7-290d-1481e08f3f71"), new Guid("5e3d9486-02e2-94bf-aa3d-821c260dec27"), 8.71m, new DateTime(2020, 5, 14, 20, 32, 8, 410, DateTimeKind.Local).AddTicks(5943), "NZPAUYUW", 3m },
                    { new Guid("1057f881-4fc6-c044-ec64-169484796823"), new Guid("3dcadc4b-aa3d-b930-945f-1cf191625195"), 9.17m, new DateTime(2022, 8, 14, 21, 20, 45, 329, DateTimeKind.Local).AddTicks(1604), "5TJCFL5Y", 6m },
                    { new Guid("10ccdbd4-b4ea-3492-e86b-ad8647a1fc78"), new Guid("44c45e62-9ca5-023b-9dc4-26bddc0231f7"), 2.32m, new DateTime(2022, 6, 28, 23, 11, 30, 949, DateTimeKind.Local).AddTicks(4976), "YUGBFFFT", 6m },
                    { new Guid("1222cf56-dcbf-4265-956e-f03861ff233d"), new Guid("8a1f65ab-7a17-d95e-b9aa-d831079fb217"), 10.72m, new DateTime(2021, 12, 15, 17, 46, 59, 249, DateTimeKind.Local).AddTicks(4797), "VVJ5ABEV", 8m },
                    { new Guid("132bc8f0-3bc8-0dcc-3c13-c01137dae686"), new Guid("3f20db10-024e-dfd6-a719-4857243a9889"), 4.03m, new DateTime(2020, 6, 11, 16, 40, 44, 762, DateTimeKind.Local).AddTicks(3637), "PK42KVQD", 4m },
                    { new Guid("1392e83c-e191-7a05-3ad0-6f507abc6ea3"), new Guid("fce495a4-0191-ecc7-7dd7-b36045a018e6"), 7.43m, new DateTime(2021, 11, 1, 15, 58, 53, 882, DateTimeKind.Local).AddTicks(2754), "ZVXSZLNS", 5m },
                    { new Guid("14908803-f711-9cfe-af5a-3c2c6c24993b"), new Guid("95284686-8903-a2ba-be4f-8b4596038776"), 13.70m, new DateTime(2020, 6, 23, 16, 52, 50, 119, DateTimeKind.Local).AddTicks(3643), "4CP4I4PL", 4m },
                    { new Guid("1492ea9c-9fe5-6fe7-bbdc-df7d06fe3fbb"), new Guid("44c45e62-9ca5-023b-9dc4-26bddc0231f7"), 14.77m, new DateTime(2020, 4, 16, 12, 16, 2, 937, DateTimeKind.Local).AddTicks(1638), "G97LMFOT", 5m },
                    { new Guid("14eb0cad-1846-8316-14e3-ec9a3c58fe9a"), new Guid("913a7460-5a92-caa7-b29b-5ae180d90411"), 3.48m, new DateTime(2021, 2, 13, 3, 59, 52, 211, DateTimeKind.Local).AddTicks(1392), "64P2OGT6", 6m },
                    { new Guid("15097e06-41b1-0f4e-1e36-3285bbf9fa96"), new Guid("a11635a8-5bcf-e2e9-c02c-82cb4133e239"), 8.59m, new DateTime(2020, 7, 22, 6, 7, 53, 571, DateTimeKind.Local).AddTicks(9072), "9HB7GKXS", 3m },
                    { new Guid("159ecb5a-8998-4e4d-7696-0285af064772"), new Guid("5bc6fee3-93b5-12c4-c219-a7691960251d"), 3.32m, new DateTime(2020, 11, 24, 0, 39, 30, 827, DateTimeKind.Local).AddTicks(5334), "QPS37JH5", 6m },
                    { new Guid("15c91500-229c-aa8e-925f-72dea73ca20e"), new Guid("8e29d7db-5630-29f6-ddca-60192f66ba8f"), 14.39m, new DateTime(2020, 2, 17, 1, 34, 3, 702, DateTimeKind.Local).AddTicks(1877), "HQ5XQ6CH", 3m },
                    { new Guid("174b7552-179d-589d-1baf-cbdf1deebe5c"), new Guid("952d30a2-933d-5484-726f-1a37ad2c4403"), 9.13m, new DateTime(2021, 7, 17, 21, 30, 20, 840, DateTimeKind.Local).AddTicks(229), "1K0EX7GT", 3m },
                    { new Guid("18201769-7798-eeae-7219-b0d9080e043a"), new Guid("f3676bf8-b41a-3b21-9ca9-64ed7de04b03"), 8.58m, new DateTime(2020, 1, 12, 15, 35, 53, 301, DateTimeKind.Local).AddTicks(4430), "4RVLPJ7V", 8m },
                    { new Guid("1957f0f7-9c1a-e8c4-eec1-d29b0bc07b01"), new Guid("c2523d56-2fc5-5311-65e7-685102f00de0"), 5.46m, new DateTime(2022, 7, 25, 17, 15, 14, 679, DateTimeKind.Local).AddTicks(8175), "397MX7K2", 7m },
                    { new Guid("1a300020-afc1-4c40-3e37-7755cfec4358"), new Guid("8e29d7db-5630-29f6-ddca-60192f66ba8f"), 9.78m, new DateTime(2021, 1, 10, 11, 51, 4, 778, DateTimeKind.Local).AddTicks(8965), "MTWZD5JX", 4m },
                    { new Guid("1b8fc657-9a8f-1ba5-6953-4457a181795b"), new Guid("fce495a4-0191-ecc7-7dd7-b36045a018e6"), 5.22m, new DateTime(2022, 3, 9, 8, 5, 20, 990, DateTimeKind.Local).AddTicks(9287), "L717Y0BY", 5m },
                    { new Guid("1bfcd0c9-e9bf-8247-d4a0-f3e0cc99397d"), new Guid("5e0efbdb-f195-7a88-6b47-e1e412f96b26"), 1.08m, new DateTime(2020, 10, 31, 16, 17, 20, 536, DateTimeKind.Local).AddTicks(7484), "CFJO1TIT", 6m },
                    { new Guid("1cf2febd-353d-1531-96d6-4a5758f17701"), new Guid("6fbc7d12-fdfd-1ae8-5d4e-961402bb912c"), 13.88m, new DateTime(2020, 1, 1, 16, 31, 27, 526, DateTimeKind.Local).AddTicks(7595), "704NN7ND", 7m },
                    { new Guid("1d9291c6-fba3-4bcc-e31f-db9ae53b8df1"), new Guid("c8538da7-2dc0-e0ce-aeb2-bf8976ad59d0"), 3.94m, new DateTime(2022, 7, 23, 11, 45, 56, 263, DateTimeKind.Local).AddTicks(4674), "FEF1A447", 5m },
                    { new Guid("1e83da40-bdfa-eb1a-28f1-85f6f89b4d92"), new Guid("3f20db10-024e-dfd6-a719-4857243a9889"), 9.94m, new DateTime(2021, 6, 2, 5, 11, 55, 181, DateTimeKind.Local).AddTicks(1958), "BUFQPEIX", 1m },
                    { new Guid("1fb6e8e9-d9d5-360a-3598-97e74fce5870"), new Guid("46c7bcb3-5575-5e07-a618-86b5fa4bc447"), 7.21m, new DateTime(2022, 2, 14, 10, 36, 14, 452, DateTimeKind.Local).AddTicks(925), "GKP8OFC0", 7m }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerId", "GrossValue", "InvoiceDate", "InvoiceNumber", "NetValue" },
                values: new object[,]
                {
                    { new Guid("1ff2f931-9cae-f89c-14ee-9fe40c9df2e0"), new Guid("bc14ae4e-2faa-c21b-3d73-961df0ee18a2"), 7.23m, new DateTime(2020, 8, 4, 12, 39, 20, 577, DateTimeKind.Local).AddTicks(713), "11LNSKNL", 8m },
                    { new Guid("20404830-e3a0-d607-5578-ac8061359425"), new Guid("e7ef71c1-d6db-c175-ab7a-f3e33457d7ee"), 11.23m, new DateTime(2020, 4, 14, 1, 16, 41, 233, DateTimeKind.Local).AddTicks(9862), "6ORV2NVK", 7m },
                    { new Guid("218cc2c4-c996-35c6-5056-90d4d53cdb0c"), new Guid("d148b4e6-ff76-32db-4fad-318146507d6f"), 3.28m, new DateTime(2020, 7, 27, 8, 28, 15, 408, DateTimeKind.Local).AddTicks(4688), "0B5DDXDP", 4m },
                    { new Guid("22f6082b-67a4-3e28-8be3-d1d35b9af912"), new Guid("8e29d7db-5630-29f6-ddca-60192f66ba8f"), 3.55m, new DateTime(2021, 11, 9, 5, 50, 14, 272, DateTimeKind.Local).AddTicks(5565), "SEWT1ZH7", 3m },
                    { new Guid("2405b6bd-3561-0513-6f67-7ad7731f54dd"), new Guid("177914f7-5534-4f8e-f1a8-e42fa8cf109c"), 8.41m, new DateTime(2022, 6, 8, 3, 4, 7, 618, DateTimeKind.Local).AddTicks(4517), "2DGXNUPL", 4m },
                    { new Guid("24b645c2-1a18-4fcc-af70-8d78f267b92c"), new Guid("e93353c7-75ae-d2ea-b3b1-cb974c4a126c"), 1.48m, new DateTime(2021, 6, 21, 5, 24, 27, 353, DateTimeKind.Local).AddTicks(9453), "HKJ9Z7E2", 5m },
                    { new Guid("251314fe-97a9-2b96-f2af-8bb172cbd84c"), new Guid("6bbe50de-9d99-61d9-38e8-dd725bd7c5c8"), 7.81m, new DateTime(2020, 4, 20, 12, 27, 29, 448, DateTimeKind.Local).AddTicks(866), "0PW1Y38E", 3m },
                    { new Guid("27be21c9-0f8c-2c8e-97a2-4220c7cca0b3"), new Guid("0df694b2-cb21-1c3e-b1f8-81f5c42c64fd"), 1.11m, new DateTime(2021, 11, 26, 3, 54, 30, 811, DateTimeKind.Local).AddTicks(1249), "0F9QOHXO", 7m },
                    { new Guid("27e6f63c-0d2f-1739-4a4c-9fad4c238771"), new Guid("28e1d4fb-89d6-fa5b-d68e-2cf52ce3ddf7"), 6.18m, new DateTime(2020, 12, 31, 23, 37, 17, 800, DateTimeKind.Local).AddTicks(4246), "YY6AF0HJ", 4m },
                    { new Guid("29e8e829-c81a-e3b5-48b1-c2ef4d16c6c0"), new Guid("a5fdccec-eebb-b72d-c19f-5047b9117b78"), 14.40m, new DateTime(2021, 5, 15, 5, 0, 24, 548, DateTimeKind.Local).AddTicks(3456), "JCI3TBF7", 1m },
                    { new Guid("2a004057-d003-fd40-19d6-9673ad17f308"), new Guid("d148b4e6-ff76-32db-4fad-318146507d6f"), 4.06m, new DateTime(2020, 9, 27, 12, 22, 23, 760, DateTimeKind.Local).AddTicks(1259), "5QRGKNSQ", 8m },
                    { new Guid("2ad36d58-221d-e803-7bda-b8bd91a3daba"), new Guid("510d7fc5-b00b-c557-f7b0-0592a28a38ae"), 1.59m, new DateTime(2021, 7, 1, 3, 28, 58, 964, DateTimeKind.Local).AddTicks(9089), "0OYHAO45", 2m },
                    { new Guid("2c84191a-7312-e264-074c-ba5d69e9fd29"), new Guid("6c1c4534-be8c-c2a6-d116-3c19ae1f0b56"), 2.03m, new DateTime(2021, 2, 19, 4, 5, 45, 351, DateTimeKind.Local).AddTicks(829), "N108UXZW", 6m },
                    { new Guid("2df79e33-619a-a65a-34b1-c624eed81ec7"), new Guid("5e3d9486-02e2-94bf-aa3d-821c260dec27"), 9.07m, new DateTime(2020, 8, 7, 15, 37, 40, 222, DateTimeKind.Local).AddTicks(3785), "6EZO5NPJ", 4m },
                    { new Guid("2e9c86a5-6deb-87b9-056e-6626d4b47533"), new Guid("0df694b2-cb21-1c3e-b1f8-81f5c42c64fd"), 1.10m, new DateTime(2022, 2, 15, 17, 4, 38, 722, DateTimeKind.Local).AddTicks(5336), "2AGTMD6V", 1m },
                    { new Guid("2fe9adb5-7020-6cd9-fe9c-a2bebc16e38f"), new Guid("6bbe50de-9d99-61d9-38e8-dd725bd7c5c8"), 7.12m, new DateTime(2022, 3, 11, 19, 23, 48, 609, DateTimeKind.Local).AddTicks(9980), "ZZG9KJ1L", 5m },
                    { new Guid("30427a9b-8709-b426-476f-10caf7f161e3"), new Guid("28e1d4fb-89d6-fa5b-d68e-2cf52ce3ddf7"), 9.26m, new DateTime(2022, 8, 7, 15, 33, 46, 365, DateTimeKind.Local).AddTicks(9681), "QT8KZYBE", 7m },
                    { new Guid("30a9b384-6d9e-587d-3dec-cc02a47c914d"), new Guid("95284686-8903-a2ba-be4f-8b4596038776"), 6.93m, new DateTime(2021, 3, 3, 23, 6, 35, 554, DateTimeKind.Local).AddTicks(8143), "53WNIS1P", 2m },
                    { new Guid("31cb6641-34a4-06c7-6ca6-0387c33c2e46"), new Guid("a9f2f10f-c683-3431-54ac-ddbbccf48026"), 5.45m, new DateTime(2022, 6, 22, 4, 22, 59, 711, DateTimeKind.Local).AddTicks(6600), "1J3C3FNZ", 2m },
                    { new Guid("322aeb7d-0fd7-b05b-68ad-d9c3f177bf16"), new Guid("37f5b748-f1ff-a5a7-65c0-fe9bb309ca20"), 10.22m, new DateTime(2021, 10, 16, 7, 28, 56, 357, DateTimeKind.Local).AddTicks(1503), "KN07J41R", 7m },
                    { new Guid("32a6cb6f-04e7-2361-a153-e34048a43182"), new Guid("8a1f65ab-7a17-d95e-b9aa-d831079fb217"), 5.96m, new DateTime(2021, 4, 26, 15, 2, 41, 969, DateTimeKind.Local).AddTicks(2085), "2OU749EB", 2m },
                    { new Guid("32ebe592-48c4-7405-9746-35bd1f6a1dbc"), new Guid("027dd28c-deaf-eb60-24a2-58510c3dacf9"), 6.12m, new DateTime(2022, 8, 7, 10, 46, 40, 742, DateTimeKind.Local).AddTicks(2096), "KV88Y6KE", 1m },
                    { new Guid("33d7545f-d4a0-f3e9-bb13-3f4f88274524"), new Guid("0df694b2-cb21-1c3e-b1f8-81f5c42c64fd"), 8.09m, new DateTime(2021, 1, 9, 18, 59, 10, 18, DateTimeKind.Local).AddTicks(8248), "AAFTMNOQ", 4m },
                    { new Guid("33e33894-6fe5-abef-c7ac-d461829bd750"), new Guid("fce495a4-0191-ecc7-7dd7-b36045a018e6"), 5.00m, new DateTime(2021, 8, 23, 8, 34, 16, 728, DateTimeKind.Local).AddTicks(4363), "FRLY5BUI", 2m },
                    { new Guid("33fbae5d-b8e1-9842-df23-ff2d20e5adc3"), new Guid("09f1414f-a259-5d89-9ec0-5b52367eb543"), 7.02m, new DateTime(2020, 12, 13, 21, 23, 24, 58, DateTimeKind.Local).AddTicks(5917), "510SQFBX", 3m },
                    { new Guid("34cb55d1-d300-dcb1-dca1-9ddbf1884201"), new Guid("28e1d4fb-89d6-fa5b-d68e-2cf52ce3ddf7"), 5.93m, new DateTime(2021, 1, 31, 4, 46, 0, 810, DateTimeKind.Local).AddTicks(519), "TB9RLVMC", 6m },
                    { new Guid("36c35176-096c-2bd0-f98b-eb553f1fc2a2"), new Guid("5e3d9486-02e2-94bf-aa3d-821c260dec27"), 1.96m, new DateTime(2020, 10, 4, 10, 14, 12, 848, DateTimeKind.Local).AddTicks(5864), "ITUC6YXA", 7m },
                    { new Guid("387fc194-739c-7936-b70f-2d697362d0fe"), new Guid("8a1f65ab-7a17-d95e-b9aa-d831079fb217"), 8.32m, new DateTime(2019, 11, 1, 16, 46, 26, 975, DateTimeKind.Local).AddTicks(6442), "43T8CZO3", 6m },
                    { new Guid("39f6d8cd-137e-2fce-7eb3-806bf73deb6a"), new Guid("8e29d7db-5630-29f6-ddca-60192f66ba8f"), 9.67m, new DateTime(2022, 5, 6, 14, 23, 20, 668, DateTimeKind.Local).AddTicks(2770), "8TF96XCY", 3m },
                    { new Guid("3ab5e4f6-f682-0151-3520-0284a6e0a7d9"), new Guid("3dcadc4b-aa3d-b930-945f-1cf191625195"), 6.89m, new DateTime(2019, 12, 10, 6, 14, 33, 728, DateTimeKind.Local).AddTicks(2360), "WQL49JPI", 8m },
                    { new Guid("3b9e6931-8dc7-a4bf-67ba-c5206d3dd5eb"), new Guid("6bbe50de-9d99-61d9-38e8-dd725bd7c5c8"), 11.80m, new DateTime(2021, 4, 1, 2, 15, 9, 529, DateTimeKind.Local).AddTicks(2403), "97MPI1CS", 3m },
                    { new Guid("3b9ea6f3-2019-7211-127b-9e6363aa1696"), new Guid("bc14ae4e-2faa-c21b-3d73-961df0ee18a2"), 4.89m, new DateTime(2020, 5, 22, 4, 41, 42, 104, DateTimeKind.Local).AddTicks(8157), "NS6T67BK", 6m },
                    { new Guid("3c68b667-55df-c9a3-ad00-063118966ce7"), new Guid("d148b4e6-ff76-32db-4fad-318146507d6f"), 9.67m, new DateTime(2022, 6, 29, 10, 53, 52, 51, DateTimeKind.Local).AddTicks(3990), "RYP20HXL", 3m },
                    { new Guid("3cfa1d42-c61f-d5ca-7f3c-6bf248121857"), new Guid("d6d185fe-6c0f-445b-d270-c2b10b59cc53"), 12.05m, new DateTime(2021, 7, 6, 23, 52, 3, 798, DateTimeKind.Local).AddTicks(2163), "TJ8T8B76", 5m },
                    { new Guid("3dfba048-011a-3d80-3d7d-c5193b1ebd21"), new Guid("034fef44-111a-a4e7-132d-6828b1d0e143"), 9.71m, new DateTime(2020, 4, 21, 10, 49, 38, 112, DateTimeKind.Local).AddTicks(4942), "KFUFYEH7", 5m },
                    { new Guid("3e6ae0f0-ab1e-f6f6-a98b-3c90884bca1b"), new Guid("177914f7-5534-4f8e-f1a8-e42fa8cf109c"), 3.49m, new DateTime(2021, 11, 22, 5, 18, 38, 783, DateTimeKind.Local).AddTicks(9752), "U80QNFT8", 4m },
                    { new Guid("3f1fbd32-de00-8b47-be7e-a1cc958293d1"), new Guid("5e0efbdb-f195-7a88-6b47-e1e412f96b26"), 4.49m, new DateTime(2020, 4, 7, 10, 57, 57, 182, DateTimeKind.Local).AddTicks(7439), "3XWRTBKF", 7m },
                    { new Guid("40989201-f228-589f-7c6e-a20bb8868ab8"), new Guid("032c8f96-89df-993b-886e-bd1639ae9618"), 14.69m, new DateTime(2022, 2, 23, 17, 0, 12, 756, DateTimeKind.Local).AddTicks(2106), "81MTM1NR", 2m },
                    { new Guid("40d03d36-66cc-9120-67d9-17dd3eaa8dc5"), new Guid("44c45e62-9ca5-023b-9dc4-26bddc0231f7"), 14.99m, new DateTime(2022, 3, 28, 0, 19, 57, 551, DateTimeKind.Local).AddTicks(4570), "4Z44TZS8", 4m },
                    { new Guid("41c240bf-1049-d34d-7d93-54563e9facd1"), new Guid("0df694b2-cb21-1c3e-b1f8-81f5c42c64fd"), 10.66m, new DateTime(2021, 12, 21, 0, 38, 45, 765, DateTimeKind.Local).AddTicks(412), "IIII8WV3", 7m },
                    { new Guid("42406a50-f74f-fbad-131e-654ace94d4d6"), new Guid("46c7bcb3-5575-5e07-a618-86b5fa4bc447"), 11.14m, new DateTime(2022, 8, 18, 4, 31, 43, 5, DateTimeKind.Local).AddTicks(7843), "VKJ3UKT9", 4m },
                    { new Guid("42cfee3f-2635-88ab-cf98-9ff95e165f5d"), new Guid("6c1c4534-be8c-c2a6-d116-3c19ae1f0b56"), 9.77m, new DateTime(2022, 3, 27, 11, 50, 11, 203, DateTimeKind.Local).AddTicks(4015), "FHI37NMT", 6m }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerId", "GrossValue", "InvoiceDate", "InvoiceNumber", "NetValue" },
                values: new object[,]
                {
                    { new Guid("45353773-f9f3-56cd-c172-79a384544a84"), new Guid("5e3d9486-02e2-94bf-aa3d-821c260dec27"), 5.12m, new DateTime(2022, 2, 24, 3, 29, 48, 654, DateTimeKind.Local).AddTicks(953), "9VY697E3", 6m },
                    { new Guid("459a4a9c-27a4-33a2-ffb0-72286d4fdefc"), new Guid("da9f0f06-19e1-c834-a985-e6f020743a60"), 8.09m, new DateTime(2019, 11, 23, 19, 0, 20, 529, DateTimeKind.Local).AddTicks(9756), "DL9UX8GO", 7m },
                    { new Guid("464bfce7-99d8-54cf-3c80-f3e5d09bdfd7"), new Guid("a11635a8-5bcf-e2e9-c02c-82cb4133e239"), 2.99m, new DateTime(2020, 10, 22, 5, 27, 21, 262, DateTimeKind.Local).AddTicks(7974), "EK3HPQ7E", 4m },
                    { new Guid("48f39e54-e0fb-5678-a7a4-2e2dffe84a41"), new Guid("5e3d9486-02e2-94bf-aa3d-821c260dec27"), 13.90m, new DateTime(2021, 4, 2, 0, 18, 35, 920, DateTimeKind.Local).AddTicks(5093), "AASB7B0P", 7m },
                    { new Guid("4955413a-aa11-ca1c-7227-558d477584ea"), new Guid("f030ab10-5450-c1a1-8e70-9b71b3665e9d"), 10.26m, new DateTime(2021, 2, 28, 19, 6, 16, 689, DateTimeKind.Local).AddTicks(8774), "X2YR7CJJ", 3m },
                    { new Guid("49c02bad-7f17-103d-6a79-e9960919e48e"), new Guid("3f20db10-024e-dfd6-a719-4857243a9889"), 5.74m, new DateTime(2021, 10, 6, 13, 53, 29, 406, DateTimeKind.Local).AddTicks(176), "FAVFRCXG", 6m },
                    { new Guid("49c5e446-f6f5-af58-5b55-3cd99914c22d"), new Guid("a5fdccec-eebb-b72d-c19f-5047b9117b78"), 4.77m, new DateTime(2020, 4, 23, 3, 29, 59, 668, DateTimeKind.Local).AddTicks(2132), "M8DLJ11P", 5m },
                    { new Guid("4a0f79f2-0022-abb9-a808-1a891fb8b414"), new Guid("032c8f96-89df-993b-886e-bd1639ae9618"), 1.27m, new DateTime(2021, 9, 21, 2, 11, 45, 635, DateTimeKind.Local).AddTicks(74), "OUKJUMB0", 3m },
                    { new Guid("4a6d0d4b-f521-c5f6-b4de-65dda2af26af"), new Guid("d6d185fe-6c0f-445b-d270-c2b10b59cc53"), 9.92m, new DateTime(2020, 9, 3, 13, 14, 19, 639, DateTimeKind.Local).AddTicks(1907), "GR9FATW2", 2m },
                    { new Guid("4b423872-33d4-6fd3-03b6-5b3f455c5045"), new Guid("5bc6fee3-93b5-12c4-c219-a7691960251d"), 12.27m, new DateTime(2020, 3, 10, 23, 50, 26, 836, DateTimeKind.Local).AddTicks(8880), "EJQ01579", 4m },
                    { new Guid("4e59817c-1a70-99a5-901b-65cac3933ebd"), new Guid("510d7fc5-b00b-c557-f7b0-0592a28a38ae"), 14.14m, new DateTime(2020, 1, 15, 20, 35, 17, 577, DateTimeKind.Local).AddTicks(2062), "JGH64V7Z", 6m },
                    { new Guid("4f2e7d60-b9d0-84da-04fe-c911b7fbad35"), new Guid("9759376b-1507-6815-d284-0d039a760775"), 2.57m, new DateTime(2020, 8, 27, 6, 43, 47, 964, DateTimeKind.Local).AddTicks(5684), "U69XZME2", 7m },
                    { new Guid("5350955f-19d0-bce8-25df-b76ede6f27bd"), new Guid("09f1414f-a259-5d89-9ec0-5b52367eb543"), 13.43m, new DateTime(2020, 8, 2, 7, 33, 53, 144, DateTimeKind.Local).AddTicks(8489), "HXZ1Z0NH", 3m },
                    { new Guid("536c1d8d-0cdf-a761-8e1a-14367609c354"), new Guid("2cebdaf2-f1fe-f6fc-fdbc-5d970d472462"), 14.42m, new DateTime(2021, 1, 22, 17, 18, 38, 965, DateTimeKind.Local).AddTicks(5360), "S0WG5BSM", 6m },
                    { new Guid("545f19db-61a5-8c25-64ce-7e0d9e8b93f1"), new Guid("027dd28c-deaf-eb60-24a2-58510c3dacf9"), 3.29m, new DateTime(2022, 5, 31, 23, 34, 52, 977, DateTimeKind.Local).AddTicks(8339), "NFHVI16I", 3m },
                    { new Guid("563084c8-7ca4-ea21-49ac-5799ba739c29"), new Guid("8e29d7db-5630-29f6-ddca-60192f66ba8f"), 6.40m, new DateTime(2022, 4, 20, 2, 18, 46, 276, DateTimeKind.Local).AddTicks(1145), "9MJD4M96", 3m },
                    { new Guid("5a4ef046-f3ba-50b4-0214-d4d7b8e1f679"), new Guid("d6d185fe-6c0f-445b-d270-c2b10b59cc53"), 14.07m, new DateTime(2020, 3, 28, 19, 11, 18, 632, DateTimeKind.Local).AddTicks(5038), "45G7WST9", 2m },
                    { new Guid("5b56258d-5f0a-2006-6dac-f19dcf36839d"), new Guid("5e0efbdb-f195-7a88-6b47-e1e412f96b26"), 2.87m, new DateTime(2019, 9, 17, 22, 22, 29, 555, DateTimeKind.Local).AddTicks(6731), "FCPU7QWY", 7m },
                    { new Guid("5bb6741f-1c75-4f3e-4b5f-a2ad5b1e40e9"), new Guid("c8538da7-2dc0-e0ce-aeb2-bf8976ad59d0"), 5.63m, new DateTime(2021, 6, 22, 23, 7, 11, 431, DateTimeKind.Local).AddTicks(1715), "6CWR2OM6", 6m },
                    { new Guid("5c279fdd-3237-9021-029d-20a0987e12e7"), new Guid("39d1e188-9439-3ce0-c150-9cf5314e3e04"), 10.61m, new DateTime(2020, 1, 1, 18, 18, 18, 67, DateTimeKind.Local).AddTicks(8396), "J24GXJS8", 4m },
                    { new Guid("5cbce579-9265-eb1c-a292-0ea813489413"), new Guid("d148b4e6-ff76-32db-4fad-318146507d6f"), 2.34m, new DateTime(2021, 4, 5, 17, 9, 13, 520, DateTimeKind.Local).AddTicks(3435), "FWBICGS7", 5m },
                    { new Guid("5d1574f5-d6a0-8588-810d-cd7889dff025"), new Guid("8e29d7db-5630-29f6-ddca-60192f66ba8f"), 8.42m, new DateTime(2022, 8, 19, 17, 26, 50, 850, DateTimeKind.Local).AddTicks(8740), "Q3V8ZA7L", 8m },
                    { new Guid("5d739161-443c-5909-1ed3-4b14f9784e41"), new Guid("034fef44-111a-a4e7-132d-6828b1d0e143"), 1.81m, new DateTime(2020, 1, 20, 0, 5, 42, 13, DateTimeKind.Local).AddTicks(3809), "XYE5RT02", 4m },
                    { new Guid("5dd1a47f-3a34-c1a9-a282-16ff65035ec2"), new Guid("a9f2f10f-c683-3431-54ac-ddbbccf48026"), 14.05m, new DateTime(2020, 11, 10, 6, 15, 45, 829, DateTimeKind.Local).AddTicks(7187), "R98BJ3XS", 1m },
                    { new Guid("5df36cfd-88d2-e545-7158-6e5863691e32"), new Guid("b1e1a113-fdf7-7550-a220-17096d5c1e87"), 8.39m, new DateTime(2021, 1, 30, 1, 26, 26, 317, DateTimeKind.Local).AddTicks(3740), "FPNTT9VE", 1m },
                    { new Guid("5e3f048a-6de8-3274-9072-468747416f6b"), new Guid("2ffa2eba-2edb-4919-e263-f11d48f879e5"), 4.31m, new DateTime(2022, 3, 31, 4, 14, 51, 656, DateTimeKind.Local).AddTicks(3813), "4TFFX1PI", 1m },
                    { new Guid("5eb11c47-abfa-fb26-34b2-9df54580c97f"), new Guid("39d1e188-9439-3ce0-c150-9cf5314e3e04"), 12.29m, new DateTime(2020, 6, 18, 0, 14, 32, 823, DateTimeKind.Local).AddTicks(8581), "L4L0BTOT", 1m },
                    { new Guid("5f90df0a-2c83-dc78-c719-dc5e95d16fa7"), new Guid("6fbc7d12-fdfd-1ae8-5d4e-961402bb912c"), 5.60m, new DateTime(2021, 5, 21, 8, 44, 37, 791, DateTimeKind.Local).AddTicks(7114), "AV5XL9CU", 7m },
                    { new Guid("5fc440fb-a1ea-bd6c-bb4c-32904fe69098"), new Guid("c2523d56-2fc5-5311-65e7-685102f00de0"), 3.78m, new DateTime(2020, 12, 22, 15, 39, 7, 969, DateTimeKind.Local).AddTicks(1558), "XV2T85H8", 5m },
                    { new Guid("617bbb35-8486-67fb-dbd9-70e86a39feb9"), new Guid("2ffa2eba-2edb-4919-e263-f11d48f879e5"), 2.17m, new DateTime(2021, 5, 20, 23, 53, 51, 34, DateTimeKind.Local).AddTicks(3589), "JNQPMQ7H", 4m },
                    { new Guid("6194aef4-6ee9-ec1b-2ee6-3201d6c191ea"), new Guid("37f5b748-f1ff-a5a7-65c0-fe9bb309ca20"), 6.38m, new DateTime(2019, 12, 12, 20, 16, 18, 439, DateTimeKind.Local).AddTicks(3796), "YWRUW205", 4m },
                    { new Guid("622c2b62-fa6a-3529-e413-ebd3409259eb"), new Guid("f030ab10-5450-c1a1-8e70-9b71b3665e9d"), 5.04m, new DateTime(2022, 3, 25, 0, 45, 10, 436, DateTimeKind.Local).AddTicks(1399), "F7GICLH6", 5m },
                    { new Guid("63083c1a-8e7d-3625-d1b1-d21ad3383325"), new Guid("6bbe50de-9d99-61d9-38e8-dd725bd7c5c8"), 3.92m, new DateTime(2020, 8, 23, 15, 19, 28, 694, DateTimeKind.Local).AddTicks(4389), "BEEHH2R0", 7m },
                    { new Guid("63706c64-ab8d-b56d-25c1-65c93571b6d7"), new Guid("bc14ae4e-2faa-c21b-3d73-961df0ee18a2"), 13.98m, new DateTime(2021, 1, 13, 16, 0, 45, 932, DateTimeKind.Local).AddTicks(9381), "UAY16OQZ", 5m },
                    { new Guid("675634f3-cd20-45b0-1be6-f7cda0fc69c4"), new Guid("952d30a2-933d-5484-726f-1a37ad2c4403"), 6.97m, new DateTime(2021, 10, 1, 5, 54, 54, 502, DateTimeKind.Local).AddTicks(7739), "VDH1XF6Y", 6m },
                    { new Guid("6818a473-28ca-3a4b-863c-8d140e7b42d8"), new Guid("c8538da7-2dc0-e0ce-aeb2-bf8976ad59d0"), 2.69m, new DateTime(2021, 7, 2, 23, 26, 23, 885, DateTimeKind.Local).AddTicks(596), "MFJZB1XK", 3m },
                    { new Guid("6838fadb-0a15-5489-7e7f-9b495df6a06e"), new Guid("510d7fc5-b00b-c557-f7b0-0592a28a38ae"), 11.54m, new DateTime(2022, 5, 18, 5, 37, 13, 564, DateTimeKind.Local).AddTicks(6581), "25DFGRLE", 4m },
                    { new Guid("6866c4e5-bf79-5ba2-37e3-85cec8e1bbd9"), new Guid("bc14ae4e-2faa-c21b-3d73-961df0ee18a2"), 1.15m, new DateTime(2020, 10, 5, 13, 42, 0, 875, DateTimeKind.Local).AddTicks(2241), "79FSAOC8", 5m },
                    { new Guid("691a4ff8-a2bc-99d7-6ef3-8726498dac54"), new Guid("a9f2f10f-c683-3431-54ac-ddbbccf48026"), 6.56m, new DateTime(2021, 3, 5, 23, 16, 8, 707, DateTimeKind.Local).AddTicks(6114), "2RD22O8D", 3m },
                    { new Guid("69238df9-5e75-ae04-36f9-debe5537bd84"), new Guid("f3676bf8-b41a-3b21-9ca9-64ed7de04b03"), 11.62m, new DateTime(2020, 3, 19, 10, 42, 27, 152, DateTimeKind.Local).AddTicks(1354), "JKA1FX77", 2m },
                    { new Guid("6b18aa0c-c751-24e6-d36f-8b61e9057a1d"), new Guid("3dcadc4b-aa3d-b930-945f-1cf191625195"), 6.46m, new DateTime(2020, 6, 29, 0, 4, 57, 969, DateTimeKind.Local).AddTicks(6669), "QEIFGPWR", 2m },
                    { new Guid("6b800ddb-dacf-0968-5a72-448a3c21b3b2"), new Guid("d6d185fe-6c0f-445b-d270-c2b10b59cc53"), 1.13m, new DateTime(2020, 6, 23, 16, 23, 8, 399, DateTimeKind.Local).AddTicks(5271), "GQVGQ80K", 8m }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerId", "GrossValue", "InvoiceDate", "InvoiceNumber", "NetValue" },
                values: new object[,]
                {
                    { new Guid("6c0b3110-f0b5-5827-abcc-994fa20b8713"), new Guid("bc14ae4e-2faa-c21b-3d73-961df0ee18a2"), 7.46m, new DateTime(2019, 12, 24, 12, 9, 11, 594, DateTimeKind.Local).AddTicks(7205), "NS6D7SVD", 6m },
                    { new Guid("6cad1812-300d-d7c3-d142-daa341a2c09c"), new Guid("5e3d9486-02e2-94bf-aa3d-821c260dec27"), 1.68m, new DateTime(2022, 4, 10, 10, 19, 33, 995, DateTimeKind.Local).AddTicks(7943), "S9P33HX0", 3m },
                    { new Guid("6d0269d5-d6d5-53ac-3bec-208eae2abcf3"), new Guid("510d7fc5-b00b-c557-f7b0-0592a28a38ae"), 7.14m, new DateTime(2021, 11, 22, 9, 16, 42, 41, DateTimeKind.Local).AddTicks(8662), "JAKWRCER", 7m },
                    { new Guid("6def6e62-ebed-ed38-1538-a1a3913401d2"), new Guid("e93353c7-75ae-d2ea-b3b1-cb974c4a126c"), 10.11m, new DateTime(2021, 6, 18, 23, 12, 6, 162, DateTimeKind.Local).AddTicks(5677), "33I6RBQV", 8m },
                    { new Guid("6e5b2046-2198-53e7-5994-328c93ce853e"), new Guid("913a7460-5a92-caa7-b29b-5ae180d90411"), 10.25m, new DateTime(2020, 5, 9, 18, 57, 17, 312, DateTimeKind.Local).AddTicks(3751), "FUPHXCX9", 8m },
                    { new Guid("6e7b60ff-c50e-c08f-bec9-fe68a156f61c"), new Guid("5bc6fee3-93b5-12c4-c219-a7691960251d"), 13.23m, new DateTime(2021, 11, 11, 11, 1, 51, 157, DateTimeKind.Local).AddTicks(2994), "H4INWEJV", 3m },
                    { new Guid("6fdf6db3-045d-cb61-c830-798eb31811de"), new Guid("4460c200-355a-31bd-bcf2-22d03d10b82c"), 14.90m, new DateTime(2020, 11, 27, 12, 39, 37, 36, DateTimeKind.Local).AddTicks(8751), "0HYQ16TE", 4m },
                    { new Guid("70362b41-fca0-1bf3-ac36-ad9c3c86234a"), new Guid("d6d185fe-6c0f-445b-d270-c2b10b59cc53"), 3.40m, new DateTime(2020, 3, 18, 9, 51, 2, 724, DateTimeKind.Local).AddTicks(5044), "XLQ1UUDP", 8m },
                    { new Guid("70de7055-c737-ea08-831e-c7a15ae58f72"), new Guid("37f5b748-f1ff-a5a7-65c0-fe9bb309ca20"), 10.20m, new DateTime(2020, 11, 18, 23, 34, 12, 815, DateTimeKind.Local).AddTicks(3626), "XJVYVIYE", 6m },
                    { new Guid("710259f6-a1a1-45a4-2da0-b8b869ea74c7"), new Guid("d6d185fe-6c0f-445b-d270-c2b10b59cc53"), 11.47m, new DateTime(2020, 12, 24, 11, 36, 33, 391, DateTimeKind.Local).AddTicks(6027), "TU7CL5G5", 3m },
                    { new Guid("7128e38f-ec16-bf2e-9fcd-40125467a7be"), new Guid("da9f0f06-19e1-c834-a985-e6f020743a60"), 3.12m, new DateTime(2022, 5, 14, 18, 2, 24, 85, DateTimeKind.Local).AddTicks(9280), "00RO5I49", 1m },
                    { new Guid("713e0ed4-7cc8-450e-3afa-297376c5bd8f"), new Guid("4460c200-355a-31bd-bcf2-22d03d10b82c"), 6.34m, new DateTime(2019, 12, 14, 12, 21, 31, 608, DateTimeKind.Local).AddTicks(9459), "P9VTNNLW", 7m },
                    { new Guid("71d53c0d-d735-a731-37c2-f054f290046e"), new Guid("e93353c7-75ae-d2ea-b3b1-cb974c4a126c"), 5.95m, new DateTime(2020, 3, 23, 20, 6, 49, 143, DateTimeKind.Local).AddTicks(8385), "9LG87GOK", 3m },
                    { new Guid("71f3b2c7-1fb5-679d-f9b7-1bd774b3cd6c"), new Guid("23e8961b-746c-a834-d2f0-6c7604251a3a"), 6.04m, new DateTime(2020, 8, 29, 16, 3, 6, 433, DateTimeKind.Local).AddTicks(9881), "9T2RX9GO", 7m },
                    { new Guid("71fbe1eb-3a13-49d0-1948-345ddef414cd"), new Guid("e93353c7-75ae-d2ea-b3b1-cb974c4a126c"), 8.27m, new DateTime(2020, 6, 4, 21, 14, 43, 395, DateTimeKind.Local).AddTicks(9416), "AZ9NUG3B", 5m },
                    { new Guid("7304680c-322b-6313-ac38-d53a596b4dac"), new Guid("5e0efbdb-f195-7a88-6b47-e1e412f96b26"), 3.45m, new DateTime(2020, 7, 27, 3, 32, 13, 470, DateTimeKind.Local).AddTicks(5794), "VQKE9CHP", 7m },
                    { new Guid("732e6439-5815-75a8-ab1f-9003ce02a615"), new Guid("3f20db10-024e-dfd6-a719-4857243a9889"), 10.23m, new DateTime(2020, 3, 15, 2, 51, 23, 152, DateTimeKind.Local).AddTicks(5941), "39ZGU9E2", 4m },
                    { new Guid("7376165e-8e46-d7de-42c7-7fa4313119ed"), new Guid("c2523d56-2fc5-5311-65e7-685102f00de0"), 8.59m, new DateTime(2021, 8, 31, 18, 50, 50, 27, DateTimeKind.Local).AddTicks(4097), "ACFUJ2WN", 7m },
                    { new Guid("74ce17c5-9fcc-5c8c-1d18-de01eaee3cfb"), new Guid("2cebdaf2-f1fe-f6fc-fdbc-5d970d472462"), 12.38m, new DateTime(2021, 6, 1, 12, 33, 21, 40, DateTimeKind.Local).AddTicks(8107), "5EA4XES0", 2m },
                    { new Guid("74fad5be-4e99-d24b-9179-f4a1dc47de59"), new Guid("a5fdccec-eebb-b72d-c19f-5047b9117b78"), 7.37m, new DateTime(2021, 12, 3, 8, 24, 47, 255, DateTimeKind.Local).AddTicks(4800), "6OJTOKPN", 7m },
                    { new Guid("75644898-66cf-dee0-8797-1036a9fe63fb"), new Guid("d6d185fe-6c0f-445b-d270-c2b10b59cc53"), 3.28m, new DateTime(2020, 2, 21, 5, 56, 30, 12, DateTimeKind.Local).AddTicks(2352), "42EZ49M8", 7m },
                    { new Guid("7772deb6-f9a2-f4d1-6d61-8a46b594f213"), new Guid("c8538da7-2dc0-e0ce-aeb2-bf8976ad59d0"), 9.44m, new DateTime(2020, 10, 13, 20, 44, 21, 496, DateTimeKind.Local).AddTicks(9440), "81TVR4DE", 3m },
                    { new Guid("77bf2c61-bfc2-c729-32fd-fe1ce0203696"), new Guid("46c7bcb3-5575-5e07-a618-86b5fa4bc447"), 1.51m, new DateTime(2021, 6, 10, 3, 9, 12, 839, DateTimeKind.Local).AddTicks(571), "XD6X9L3E", 2m },
                    { new Guid("78e65932-8832-c655-8007-5ad1d2f88c3d"), new Guid("b1e1a113-fdf7-7550-a220-17096d5c1e87"), 9.65m, new DateTime(2022, 4, 7, 21, 35, 29, 178, DateTimeKind.Local).AddTicks(6924), "GUG7BUHJ", 1m },
                    { new Guid("7a9141a2-bd53-139e-c27b-3881ccb67570"), new Guid("2ffa2eba-2edb-4919-e263-f11d48f879e5"), 2.50m, new DateTime(2021, 10, 15, 13, 3, 41, 620, DateTimeKind.Local).AddTicks(1318), "9WPVEM35", 7m },
                    { new Guid("7be6f180-7a65-fe57-0f03-e55cbb3c5d77"), new Guid("027dd28c-deaf-eb60-24a2-58510c3dacf9"), 4.24m, new DateTime(2020, 7, 4, 20, 1, 53, 672, DateTimeKind.Local).AddTicks(8429), "6BVKEDME", 7m },
                    { new Guid("7c1176e9-1456-4e84-b5f8-76177a31a823"), new Guid("5e0efbdb-f195-7a88-6b47-e1e412f96b26"), 3.97m, new DateTime(2020, 1, 17, 10, 43, 4, 181, DateTimeKind.Local).AddTicks(8712), "5OFNNVV6", 8m },
                    { new Guid("7d9e8552-dbd8-a2ce-ed1e-26ee5ed0475a"), new Guid("c8538da7-2dc0-e0ce-aeb2-bf8976ad59d0"), 4.48m, new DateTime(2021, 6, 11, 12, 38, 34, 823, DateTimeKind.Local).AddTicks(4496), "F3IMAZCZ", 6m },
                    { new Guid("7edcd35a-be71-d653-5f69-4185a18c35cc"), new Guid("37f5b748-f1ff-a5a7-65c0-fe9bb309ca20"), 2.20m, new DateTime(2022, 1, 27, 16, 39, 27, 466, DateTimeKind.Local).AddTicks(3066), "WHV7WQP9", 8m },
                    { new Guid("7eef7ee5-0813-8160-72c1-c72154908ceb"), new Guid("fce495a4-0191-ecc7-7dd7-b36045a018e6"), 7.30m, new DateTime(2021, 12, 13, 13, 18, 23, 758, DateTimeKind.Local).AddTicks(940), "H19UIS01", 4m },
                    { new Guid("7f3754e1-ebf3-4a96-06fa-504a23740dfb"), new Guid("8e29d7db-5630-29f6-ddca-60192f66ba8f"), 11.97m, new DateTime(2022, 8, 23, 17, 21, 40, 337, DateTimeKind.Local).AddTicks(1863), "ZTNN2EOK", 4m },
                    { new Guid("80b50ae6-82f3-c720-a268-d5069a0651b3"), new Guid("28e1d4fb-89d6-fa5b-d68e-2cf52ce3ddf7"), 2.70m, new DateTime(2021, 5, 29, 2, 37, 58, 981, DateTimeKind.Local).AddTicks(2374), "6JE3EO3I", 2m },
                    { new Guid("8139bc8f-01ba-0915-45c8-27d6c2ea0b9c"), new Guid("c8538da7-2dc0-e0ce-aeb2-bf8976ad59d0"), 13.87m, new DateTime(2020, 3, 18, 11, 42, 13, 796, DateTimeKind.Local).AddTicks(4916), "0PTJKVRV", 1m },
                    { new Guid("81683c58-9080-e222-fd0d-5677d620e7de"), new Guid("6bbe50de-9d99-61d9-38e8-dd725bd7c5c8"), 2.57m, new DateTime(2021, 5, 17, 8, 29, 54, 663, DateTimeKind.Local).AddTicks(3451), "3ZIE5OEK", 4m },
                    { new Guid("81d14aab-0667-0210-bb0c-3169c3ac7aac"), new Guid("5bc6fee3-93b5-12c4-c219-a7691960251d"), 10.17m, new DateTime(2019, 10, 26, 11, 27, 45, 602, DateTimeKind.Local).AddTicks(3299), "REAOXYOS", 6m },
                    { new Guid("8264afe0-0210-8ddb-c021-b16451b329aa"), new Guid("a9f2f10f-c683-3431-54ac-ddbbccf48026"), 11.77m, new DateTime(2022, 8, 5, 19, 26, 31, 450, DateTimeKind.Local).AddTicks(2862), "1IG02AK0", 6m },
                    { new Guid("8364affb-0415-9bc7-8ce0-be9fa47eb6aa"), new Guid("d6d185fe-6c0f-445b-d270-c2b10b59cc53"), 2.06m, new DateTime(2022, 8, 4, 14, 9, 41, 342, DateTimeKind.Local).AddTicks(4378), "4VRF0OAP", 3m },
                    { new Guid("843ce5bc-44da-4d50-9e47-55f4730c4790"), new Guid("3f20db10-024e-dfd6-a719-4857243a9889"), 13.96m, new DateTime(2020, 10, 17, 16, 1, 45, 68, DateTimeKind.Local).AddTicks(4828), "TAQ3Q24U", 7m },
                    { new Guid("85aa9e2e-a475-049c-89f1-56ec190ee8bc"), new Guid("39d1e188-9439-3ce0-c150-9cf5314e3e04"), 5.12m, new DateTime(2021, 12, 26, 13, 10, 1, 115, DateTimeKind.Local).AddTicks(6430), "24683WI4", 4m },
                    { new Guid("887182a3-416c-10ed-2767-405f7a447694"), new Guid("09f1414f-a259-5d89-9ec0-5b52367eb543"), 3.03m, new DateTime(2021, 7, 27, 13, 1, 38, 108, DateTimeKind.Local).AddTicks(1549), "C9FIHUQX", 6m },
                    { new Guid("89472268-20be-46cd-2a54-450c4b3ddde6"), new Guid("5e0efbdb-f195-7a88-6b47-e1e412f96b26"), 2.54m, new DateTime(2021, 10, 3, 22, 26, 22, 317, DateTimeKind.Local).AddTicks(8575), "Z8O6KSP8", 8m },
                    { new Guid("8ac271d9-3345-0ebe-eaaa-ebbec4f85b58"), new Guid("5e3d9486-02e2-94bf-aa3d-821c260dec27"), 6.25m, new DateTime(2020, 7, 27, 17, 41, 55, 143, DateTimeKind.Local).AddTicks(8744), "CO7EPSGV", 1m }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerId", "GrossValue", "InvoiceDate", "InvoiceNumber", "NetValue" },
                values: new object[,]
                {
                    { new Guid("8b3cd6fd-c3a8-330f-ff6b-a1148963d8cb"), new Guid("952d30a2-933d-5484-726f-1a37ad2c4403"), 13.13m, new DateTime(2021, 10, 13, 15, 54, 24, 18, DateTimeKind.Local).AddTicks(622), "ZPXNRXNB", 2m },
                    { new Guid("8c3c7618-4a51-3537-b19f-655650086035"), new Guid("a9f2f10f-c683-3431-54ac-ddbbccf48026"), 14.13m, new DateTime(2021, 9, 4, 1, 46, 16, 303, DateTimeKind.Local).AddTicks(7284), "VG1J65RL", 7m },
                    { new Guid("8dd89811-e469-d04c-2b41-c80d1093799e"), new Guid("46c7bcb3-5575-5e07-a618-86b5fa4bc447"), 4.82m, new DateTime(2021, 1, 31, 19, 53, 58, 536, DateTimeKind.Local).AddTicks(6313), "DT1VEU8V", 6m },
                    { new Guid("8e2fe2fb-bd45-8a0f-14f0-a597a0808f33"), new Guid("44c45e62-9ca5-023b-9dc4-26bddc0231f7"), 9.22m, new DateTime(2021, 10, 12, 5, 12, 23, 453, DateTimeKind.Local).AddTicks(200), "DLQNI9DL", 3m },
                    { new Guid("9034011e-78a6-d387-d697-e3468f4d3285"), new Guid("6fbc7d12-fdfd-1ae8-5d4e-961402bb912c"), 10.49m, new DateTime(2022, 4, 20, 17, 28, 24, 131, DateTimeKind.Local).AddTicks(5725), "YA0IT938", 5m },
                    { new Guid("903f5381-5eca-8c9f-6c2e-111b05029e0a"), new Guid("e7ef71c1-d6db-c175-ab7a-f3e33457d7ee"), 1.55m, new DateTime(2020, 12, 21, 2, 16, 21, 968, DateTimeKind.Local).AddTicks(806), "78QU8EPL", 4m },
                    { new Guid("911ef2e4-23b4-65f7-33d6-d802bcdfa266"), new Guid("510d7fc5-b00b-c557-f7b0-0592a28a38ae"), 10.69m, new DateTime(2021, 12, 7, 13, 22, 59, 978, DateTimeKind.Local).AddTicks(5251), "6ATUY8AF", 1m },
                    { new Guid("92bf9479-3976-52b7-8e2d-e045fa65ab06"), new Guid("d99c821e-13f9-9414-593d-fe4ef0ac1f39"), 3.00m, new DateTime(2022, 5, 8, 12, 46, 53, 235, DateTimeKind.Local).AddTicks(8233), "JQVGWNDR", 3m },
                    { new Guid("943bd0eb-d0ae-bdc9-795b-cf8991a1d967"), new Guid("fce495a4-0191-ecc7-7dd7-b36045a018e6"), 9.52m, new DateTime(2021, 8, 29, 13, 45, 38, 954, DateTimeKind.Local).AddTicks(644), "D11FTX0Q", 4m },
                    { new Guid("9534aad5-36d7-93e5-3122-a20b87738a67"), new Guid("9759376b-1507-6815-d284-0d039a760775"), 5.43m, new DateTime(2020, 1, 9, 22, 13, 27, 758, DateTimeKind.Local).AddTicks(337), "MESQES6Z", 2m },
                    { new Guid("953fae84-48df-1c17-41a1-9c45ef48434a"), new Guid("0df694b2-cb21-1c3e-b1f8-81f5c42c64fd"), 5.83m, new DateTime(2022, 7, 21, 10, 17, 15, 509, DateTimeKind.Local).AddTicks(5485), "Y5R784PN", 2m },
                    { new Guid("95f8b3da-98ef-4a17-2a9b-bd2fb4e2c869"), new Guid("5e0efbdb-f195-7a88-6b47-e1e412f96b26"), 14.03m, new DateTime(2019, 11, 2, 19, 20, 33, 513, DateTimeKind.Local).AddTicks(7300), "J0WRWHZV", 1m },
                    { new Guid("9749745b-2296-319d-7c4a-36bcb0679462"), new Guid("16d16709-6fc9-aad6-ef9d-74519a69e8d7"), 9.84m, new DateTime(2020, 6, 6, 12, 42, 40, 708, DateTimeKind.Local).AddTicks(2793), "4A26MTZF", 8m },
                    { new Guid("977e899a-7849-f638-534b-2a84513dbb4e"), new Guid("e93353c7-75ae-d2ea-b3b1-cb974c4a126c"), 7.66m, new DateTime(2021, 12, 9, 22, 51, 36, 623, DateTimeKind.Local).AddTicks(5273), "XIG9QUH6", 7m },
                    { new Guid("9891415c-f1ef-a82f-c035-052eae1ab234"), new Guid("952d30a2-933d-5484-726f-1a37ad2c4403"), 1.64m, new DateTime(2021, 9, 25, 22, 44, 31, 178, DateTimeKind.Local).AddTicks(9192), "DGCYYNTN", 2m },
                    { new Guid("98afec41-d928-90e9-f501-dc5c74ffceea"), new Guid("bc14ae4e-2faa-c21b-3d73-961df0ee18a2"), 1.08m, new DateTime(2021, 2, 25, 6, 43, 20, 181, DateTimeKind.Local).AddTicks(5676), "6Q9Y11JO", 3m },
                    { new Guid("9bd31fac-1d5e-1630-fd07-946607a40b72"), new Guid("0df694b2-cb21-1c3e-b1f8-81f5c42c64fd"), 1.23m, new DateTime(2020, 11, 8, 13, 58, 26, 245, DateTimeKind.Local).AddTicks(7517), "P61GPYIW", 6m },
                    { new Guid("9c2b5b3f-1238-1f09-86c3-80a24935c8ab"), new Guid("f3676bf8-b41a-3b21-9ca9-64ed7de04b03"), 5.08m, new DateTime(2022, 2, 19, 6, 33, 28, 644, DateTimeKind.Local).AddTicks(6377), "X8U06F4A", 5m },
                    { new Guid("9c83c74b-abf3-d923-d242-1f7587c51ca1"), new Guid("d99c821e-13f9-9414-593d-fe4ef0ac1f39"), 7.58m, new DateTime(2021, 11, 2, 4, 34, 23, 872, DateTimeKind.Local).AddTicks(3439), "5LUVR28W", 4m },
                    { new Guid("9e1dfc31-beae-15c2-3e9c-acf5cd03654d"), new Guid("95284686-8903-a2ba-be4f-8b4596038776"), 6.69m, new DateTime(2020, 8, 26, 5, 58, 25, 556, DateTimeKind.Local).AddTicks(3454), "QXFM1P8P", 3m },
                    { new Guid("9ee7739b-672f-ccb6-ad28-5fb04c4962b0"), new Guid("b1e1a113-fdf7-7550-a220-17096d5c1e87"), 7.64m, new DateTime(2020, 3, 7, 21, 30, 1, 915, DateTimeKind.Local).AddTicks(6414), "6VR3W23N", 7m },
                    { new Guid("9f5a45a1-e640-3b1e-7cea-9147ea003da2"), new Guid("da9f0f06-19e1-c834-a985-e6f020743a60"), 8.86m, new DateTime(2020, 11, 13, 8, 2, 50, 610, DateTimeKind.Local).AddTicks(7076), "8D63WR2T", 8m },
                    { new Guid("9fa76472-7ecf-0dfb-2c7e-493ba42aa4ed"), new Guid("09f1414f-a259-5d89-9ec0-5b52367eb543"), 10.67m, new DateTime(2020, 7, 8, 3, 34, 5, 785, DateTimeKind.Local).AddTicks(8153), "V9AVAQDG", 6m },
                    { new Guid("a048226e-4085-6918-7fc2-ec495733a6d8"), new Guid("510d7fc5-b00b-c557-f7b0-0592a28a38ae"), 9.46m, new DateTime(2021, 10, 1, 16, 37, 54, 77, DateTimeKind.Local).AddTicks(9727), "W3EBZBBH", 2m },
                    { new Guid("a10056b7-d97d-ee1f-21b6-f0d7de2a884d"), new Guid("6c1c4534-be8c-c2a6-d116-3c19ae1f0b56"), 14.03m, new DateTime(2019, 12, 29, 12, 53, 34, 929, DateTimeKind.Local).AddTicks(604), "5TQW6QXJ", 3m },
                    { new Guid("a22f3faa-4419-704f-4651-c65cd3ce139e"), new Guid("034fef44-111a-a4e7-132d-6828b1d0e143"), 14.40m, new DateTime(2021, 11, 12, 5, 55, 41, 675, DateTimeKind.Local).AddTicks(1033), "5KWAOYFM", 2m },
                    { new Guid("a4942200-68b9-63c4-38ed-68cc44264986"), new Guid("09f1414f-a259-5d89-9ec0-5b52367eb543"), 12.94m, new DateTime(2022, 3, 31, 2, 28, 24, 719, DateTimeKind.Local).AddTicks(5716), "ORDU9K9T", 3m },
                    { new Guid("a544bc79-ab66-29a0-1f2d-24c123f4f98d"), new Guid("bc14ae4e-2faa-c21b-3d73-961df0ee18a2"), 14.57m, new DateTime(2021, 9, 17, 6, 54, 54, 459, DateTimeKind.Local).AddTicks(5644), "7HYJHWNG", 5m },
                    { new Guid("a57de957-ba9d-3891-db1b-7f5ffd016fae"), new Guid("95284686-8903-a2ba-be4f-8b4596038776"), 4.08m, new DateTime(2021, 3, 10, 19, 2, 43, 982, DateTimeKind.Local).AddTicks(3653), "A6VMBLWT", 7m },
                    { new Guid("a59d8d2f-c8eb-fcdd-ed5c-0861fafc4c5d"), new Guid("44c45e62-9ca5-023b-9dc4-26bddc0231f7"), 14.76m, new DateTime(2021, 9, 18, 16, 57, 56, 57, DateTimeKind.Local).AddTicks(5365), "5HS1BLK1", 6m },
                    { new Guid("a61dc572-048f-2c19-b3d6-3aa0c888baac"), new Guid("952d30a2-933d-5484-726f-1a37ad2c4403"), 14.17m, new DateTime(2019, 9, 24, 13, 25, 11, 463, DateTimeKind.Local).AddTicks(4568), "DBEB531F", 3m },
                    { new Guid("a67eeecb-49bb-8395-3a3f-fe95d8dacf76"), new Guid("d148b4e6-ff76-32db-4fad-318146507d6f"), 10.42m, new DateTime(2022, 4, 20, 23, 19, 5, 892, DateTimeKind.Local).AddTicks(998), "YWUDR0V6", 5m },
                    { new Guid("a68d5a83-21c4-0592-105e-0f3e9393863e"), new Guid("a9f2f10f-c683-3431-54ac-ddbbccf48026"), 10.97m, new DateTime(2022, 5, 20, 21, 56, 54, 703, DateTimeKind.Local).AddTicks(8442), "PHY5D2PU", 1m },
                    { new Guid("a6f32710-ffc4-1214-de44-bcba0a8ea3e4"), new Guid("6bbe50de-9d99-61d9-38e8-dd725bd7c5c8"), 13.51m, new DateTime(2022, 1, 27, 7, 4, 48, 806, DateTimeKind.Local).AddTicks(4688), "X7GQ062L", 7m },
                    { new Guid("a75f4a96-bfd9-2131-5db9-cf53194b47c8"), new Guid("6c1c4534-be8c-c2a6-d116-3c19ae1f0b56"), 1.42m, new DateTime(2021, 5, 29, 0, 45, 58, 744, DateTimeKind.Local).AddTicks(8369), "O68Q0LO0", 4m },
                    { new Guid("a77bc264-da6a-e483-1553-0b784dccfe14"), new Guid("a11635a8-5bcf-e2e9-c02c-82cb4133e239"), 2.08m, new DateTime(2020, 12, 3, 18, 52, 38, 794, DateTimeKind.Local).AddTicks(689), "KIBSJ7AY", 5m },
                    { new Guid("a86753da-1bf6-a89d-e189-cf03cc8bbc6b"), new Guid("a11635a8-5bcf-e2e9-c02c-82cb4133e239"), 1.35m, new DateTime(2021, 7, 19, 10, 35, 51, 75, DateTimeKind.Local).AddTicks(9440), "B4BXMPCU", 2m },
                    { new Guid("aadb490d-5e69-e07b-6058-28345fcb2862"), new Guid("5e3d9486-02e2-94bf-aa3d-821c260dec27"), 5.88m, new DateTime(2021, 6, 7, 17, 11, 23, 790, DateTimeKind.Local).AddTicks(6056), "VPJVL2KP", 8m },
                    { new Guid("aae65957-87e6-62e0-6096-1f5372040847"), new Guid("a9f2f10f-c683-3431-54ac-ddbbccf48026"), 3.49m, new DateTime(2020, 12, 31, 13, 24, 4, 637, DateTimeKind.Local).AddTicks(2854), "1KCVUR24", 2m },
                    { new Guid("ab658c4d-3c49-bb28-fad3-3556599c18e9"), new Guid("39d1e188-9439-3ce0-c150-9cf5314e3e04"), 14.36m, new DateTime(2022, 2, 27, 18, 5, 14, 725, DateTimeKind.Local).AddTicks(1658), "W7PRS7BX", 3m },
                    { new Guid("abdbb6d6-1dba-6f92-69e1-b5a3b4ddee72"), new Guid("2ffa2eba-2edb-4919-e263-f11d48f879e5"), 12.58m, new DateTime(2019, 9, 15, 2, 24, 12, 463, DateTimeKind.Local).AddTicks(2312), "7V61JKPY", 6m },
                    { new Guid("ac131c3b-c0a1-f638-1b65-c552a7218015"), new Guid("8e29d7db-5630-29f6-ddca-60192f66ba8f"), 6.44m, new DateTime(2020, 6, 18, 18, 32, 10, 260, DateTimeKind.Local).AddTicks(5769), "DFHIXXEZ", 2m }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerId", "GrossValue", "InvoiceDate", "InvoiceNumber", "NetValue" },
                values: new object[,]
                {
                    { new Guid("aef8f74b-cc20-931e-31d2-1f3bc5e107fd"), new Guid("f3676bf8-b41a-3b21-9ca9-64ed7de04b03"), 11.80m, new DateTime(2021, 9, 1, 14, 43, 55, 329, DateTimeKind.Local).AddTicks(6588), "90UQP7VX", 4m },
                    { new Guid("af2df69f-7c86-7e9f-fe60-7e547d3d8445"), new Guid("034fef44-111a-a4e7-132d-6828b1d0e143"), 14.71m, new DateTime(2020, 10, 19, 22, 35, 32, 501, DateTimeKind.Local).AddTicks(4065), "Z89INVLH", 2m },
                    { new Guid("afdda2b1-e8d0-36fe-b11a-9cd84097bc6d"), new Guid("4460c200-355a-31bd-bcf2-22d03d10b82c"), 5.19m, new DateTime(2021, 4, 4, 4, 27, 37, 228, DateTimeKind.Local).AddTicks(7723), "XXAJSCJG", 2m },
                    { new Guid("b01e19bf-da41-c825-6a43-11874a57ef43"), new Guid("95284686-8903-a2ba-be4f-8b4596038776"), 1.87m, new DateTime(2022, 6, 28, 11, 55, 41, 405, DateTimeKind.Local).AddTicks(5967), "NT79M0VI", 3m },
                    { new Guid("b059e586-604b-67a4-30e1-c36a72829678"), new Guid("44c45e62-9ca5-023b-9dc4-26bddc0231f7"), 13.08m, new DateTime(2021, 9, 26, 19, 10, 14, 440, DateTimeKind.Local).AddTicks(5371), "6P11Z701", 4m },
                    { new Guid("b146cb9f-c114-2e97-ad57-6daebe5faa34"), new Guid("e93353c7-75ae-d2ea-b3b1-cb974c4a126c"), 3.95m, new DateTime(2022, 1, 11, 8, 51, 54, 261, DateTimeKind.Local).AddTicks(9843), "LGT3UWZI", 7m },
                    { new Guid("b23a3ecc-edf8-9b7d-dce5-186f3a2e3948"), new Guid("a9f2f10f-c683-3431-54ac-ddbbccf48026"), 8.31m, new DateTime(2020, 9, 13, 11, 45, 3, 444, DateTimeKind.Local).AddTicks(6161), "KDHX1Y6W", 5m },
                    { new Guid("b2680acc-7a55-ea75-a983-9f7b8e54a4e8"), new Guid("bc14ae4e-2faa-c21b-3d73-961df0ee18a2"), 13.02m, new DateTime(2021, 8, 31, 19, 47, 20, 329, DateTimeKind.Local).AddTicks(6820), "6YNXCRSJ", 3m },
                    { new Guid("b2fe8d65-cd03-05e3-18ae-3798af984bd1"), new Guid("23e8961b-746c-a834-d2f0-6c7604251a3a"), 1.99m, new DateTime(2020, 11, 28, 20, 36, 52, 827, DateTimeKind.Local).AddTicks(4854), "VHWHPATQ", 1m },
                    { new Guid("b4997f13-ab55-8f7a-8776-ad5bda7e270d"), new Guid("6bbe50de-9d99-61d9-38e8-dd725bd7c5c8"), 7.56m, new DateTime(2019, 10, 22, 22, 13, 6, 285, DateTimeKind.Local).AddTicks(1933), "UWCHRK6L", 3m },
                    { new Guid("b5723a2c-d2ee-71a7-73a4-a9ce537962ae"), new Guid("6fbc7d12-fdfd-1ae8-5d4e-961402bb912c"), 7.15m, new DateTime(2021, 9, 16, 1, 41, 20, 692, DateTimeKind.Local).AddTicks(8476), "5PQEQ7KA", 3m },
                    { new Guid("b6914962-30f5-3ac1-2f10-e082236e1486"), new Guid("3f20db10-024e-dfd6-a719-4857243a9889"), 11.09m, new DateTime(2021, 8, 11, 16, 8, 13, 631, DateTimeKind.Local).AddTicks(1566), "I2EOGCFN", 2m },
                    { new Guid("b8e0e3d9-0c37-f300-497c-3786de557df1"), new Guid("5e0efbdb-f195-7a88-6b47-e1e412f96b26"), 13.73m, new DateTime(2021, 12, 14, 13, 37, 22, 2, DateTimeKind.Local).AddTicks(466), "BKOJ5R3X", 6m },
                    { new Guid("ba6b4dd4-1ecf-713b-a308-1146903f3884"), new Guid("8a1f65ab-7a17-d95e-b9aa-d831079fb217"), 13.60m, new DateTime(2020, 12, 3, 19, 56, 51, 515, DateTimeKind.Local).AddTicks(3640), "WUW6LV83", 3m },
                    { new Guid("bab33930-ce4d-06b3-c686-cce86b3d0df7"), new Guid("a11635a8-5bcf-e2e9-c02c-82cb4133e239"), 4.88m, new DateTime(2021, 7, 31, 18, 24, 0, 812, DateTimeKind.Local).AddTicks(734), "6XUU5AIH", 8m },
                    { new Guid("bb3909d6-9015-a157-0483-f3c6e9f2a41d"), new Guid("44c45e62-9ca5-023b-9dc4-26bddc0231f7"), 3.44m, new DateTime(2021, 3, 31, 7, 37, 55, 405, DateTimeKind.Local).AddTicks(4779), "WXFUPC2J", 8m },
                    { new Guid("bbf4b5f9-3600-0574-b861-d7da5d6a655b"), new Guid("37f5b748-f1ff-a5a7-65c0-fe9bb309ca20"), 4.31m, new DateTime(2020, 2, 22, 7, 49, 50, 493, DateTimeKind.Local).AddTicks(1136), "2GBPMC4I", 1m },
                    { new Guid("bd35a3bb-86dd-64cc-e75d-731fd47921a8"), new Guid("bcf45a97-0fd6-07e3-6c56-d9696decfd6d"), 6.70m, new DateTime(2020, 2, 3, 7, 51, 26, 458, DateTimeKind.Local).AddTicks(1163), "FUZE2P7R", 4m },
                    { new Guid("bd5a4db6-5ce4-a8d6-751e-ea8e632be66e"), new Guid("28e1d4fb-89d6-fa5b-d68e-2cf52ce3ddf7"), 6.40m, new DateTime(2021, 9, 13, 20, 21, 4, 835, DateTimeKind.Local).AddTicks(4576), "TNYJHNHB", 5m },
                    { new Guid("bd8a7584-f9e9-ccab-84bc-c95d0528407e"), new Guid("95284686-8903-a2ba-be4f-8b4596038776"), 12.71m, new DateTime(2020, 6, 4, 9, 53, 45, 658, DateTimeKind.Local).AddTicks(1556), "AL23ADZR", 5m },
                    { new Guid("be4d4097-7f5a-63ad-7d7d-32d3b0057c19"), new Guid("034fef44-111a-a4e7-132d-6828b1d0e143"), 3.92m, new DateTime(2021, 1, 15, 9, 20, 49, 943, DateTimeKind.Local).AddTicks(7948), "16XT2CLD", 2m },
                    { new Guid("bf546b24-9d9e-7bb2-3d43-199c14564dad"), new Guid("23e8961b-746c-a834-d2f0-6c7604251a3a"), 11.86m, new DateTime(2019, 11, 26, 9, 45, 39, 31, DateTimeKind.Local).AddTicks(5147), "KV77030K", 4m },
                    { new Guid("c0432798-ca48-a858-916f-81fd82500e71"), new Guid("fce495a4-0191-ecc7-7dd7-b36045a018e6"), 8.07m, new DateTime(2022, 5, 12, 6, 36, 45, 79, DateTimeKind.Local).AddTicks(8493), "2DQS8I4O", 6m },
                    { new Guid("c0c5b4e5-aa6f-0ce6-7c8e-18b07fe76e40"), new Guid("0df694b2-cb21-1c3e-b1f8-81f5c42c64fd"), 13.01m, new DateTime(2022, 3, 28, 18, 18, 27, 916, DateTimeKind.Local).AddTicks(6923), "J9F6QUHA", 7m },
                    { new Guid("c3b58bb8-e049-bf2a-b80a-890532a2b490"), new Guid("3dcadc4b-aa3d-b930-945f-1cf191625195"), 12.43m, new DateTime(2021, 8, 14, 2, 46, 21, 597, DateTimeKind.Local).AddTicks(4919), "WN3IC9PN", 4m },
                    { new Guid("c40c0a1c-4968-71e5-9174-adb9b5dcc226"), new Guid("46c7bcb3-5575-5e07-a618-86b5fa4bc447"), 4.53m, new DateTime(2020, 10, 27, 15, 38, 55, 242, DateTimeKind.Local).AddTicks(6999), "ZZ1P4IML", 5m },
                    { new Guid("c4651b48-fa98-2b10-036e-0a56ba01b1c2"), new Guid("2ffa2eba-2edb-4919-e263-f11d48f879e5"), 2.90m, new DateTime(2021, 10, 27, 13, 17, 52, 193, DateTimeKind.Local).AddTicks(5067), "L8K3QTLH", 7m },
                    { new Guid("c4b57aaf-75df-3442-b4b7-1344dd5988d5"), new Guid("0df694b2-cb21-1c3e-b1f8-81f5c42c64fd"), 7.28m, new DateTime(2022, 8, 6, 12, 35, 25, 241, DateTimeKind.Local).AddTicks(8003), "GQ7M9VYZ", 7m },
                    { new Guid("c51ae4c8-3221-fcca-c1a3-2b2a652854b1"), new Guid("c2523d56-2fc5-5311-65e7-685102f00de0"), 4.49m, new DateTime(2021, 9, 7, 15, 44, 19, 192, DateTimeKind.Local).AddTicks(2192), "5K8XY9PE", 3m },
                    { new Guid("c711577e-b4a0-15a1-65e4-270d92f49a88"), new Guid("09f1414f-a259-5d89-9ec0-5b52367eb543"), 8.19m, new DateTime(2019, 10, 3, 1, 42, 35, 992, DateTimeKind.Local).AddTicks(2382), "27S15URF", 5m },
                    { new Guid("c7de99e9-32c7-81eb-5548-581156d234c5"), new Guid("952d30a2-933d-5484-726f-1a37ad2c4403"), 7.11m, new DateTime(2020, 11, 13, 11, 27, 36, 219, DateTimeKind.Local).AddTicks(3673), "THLPFN5T", 5m },
                    { new Guid("c9f1a73f-2c86-3976-96d9-5fc6f935e455"), new Guid("4460c200-355a-31bd-bcf2-22d03d10b82c"), 5.22m, new DateTime(2021, 5, 20, 14, 36, 4, 108, DateTimeKind.Local).AddTicks(8868), "GVC032VZ", 7m },
                    { new Guid("cb6b4cc0-1d3c-6a8f-727c-149b4efd345b"), new Guid("a9f2f10f-c683-3431-54ac-ddbbccf48026"), 7.98m, new DateTime(2020, 11, 23, 7, 24, 11, 520, DateTimeKind.Local).AddTicks(2831), "PB7KCE1I", 3m },
                    { new Guid("ceae8160-2de0-a0f9-7391-2263d57102d9"), new Guid("a11635a8-5bcf-e2e9-c02c-82cb4133e239"), 7.75m, new DateTime(2019, 12, 2, 9, 41, 17, 553, DateTimeKind.Local).AddTicks(7000), "NA861MYF", 4m },
                    { new Guid("cf849e5e-8a02-8566-a3e6-764c330047da"), new Guid("8a1f65ab-7a17-d95e-b9aa-d831079fb217"), 10.40m, new DateTime(2019, 10, 15, 20, 50, 29, 286, DateTimeKind.Local).AddTicks(603), "RUV7JQJ0", 6m },
                    { new Guid("cffa3cc6-f433-9f5d-90b8-9479e4ee3a36"), new Guid("c2523d56-2fc5-5311-65e7-685102f00de0"), 2.02m, new DateTime(2022, 2, 19, 9, 39, 13, 643, DateTimeKind.Local).AddTicks(7934), "MRKCTOKT", 6m },
                    { new Guid("d0e3195e-d3e0-83ab-6a8b-2806a7778bdb"), new Guid("09f1414f-a259-5d89-9ec0-5b52367eb543"), 9.95m, new DateTime(2020, 6, 15, 16, 41, 51, 933, DateTimeKind.Local).AddTicks(767), "SQMDDG2B", 2m },
                    { new Guid("d2f43847-b7e5-8049-c5d2-532344fe09e7"), new Guid("b1e1a113-fdf7-7550-a220-17096d5c1e87"), 3.78m, new DateTime(2020, 12, 17, 0, 47, 58, 493, DateTimeKind.Local).AddTicks(7122), "0H8PR0DO", 1m },
                    { new Guid("d30d905a-57b8-6949-e7d5-841bb438653f"), new Guid("e7ef71c1-d6db-c175-ab7a-f3e33457d7ee"), 3.72m, new DateTime(2021, 4, 11, 4, 55, 41, 472, DateTimeKind.Local).AddTicks(4912), "BXB3JZLD", 3m },
                    { new Guid("d495ebb6-ff73-b1bf-ef28-f0769d6a1c62"), new Guid("d99c821e-13f9-9414-593d-fe4ef0ac1f39"), 10.26m, new DateTime(2021, 11, 11, 17, 44, 0, 157, DateTimeKind.Local).AddTicks(4741), "Z7O0BVL1", 2m },
                    { new Guid("d4a6b833-5abb-a8d8-0269-5e3437692d68"), new Guid("8e29d7db-5630-29f6-ddca-60192f66ba8f"), 8.96m, new DateTime(2019, 9, 22, 11, 53, 45, 31, DateTimeKind.Local).AddTicks(6983), "PD9GBS2B", 4m },
                    { new Guid("d4da2903-a92f-21e1-5899-7aeb12d160d3"), new Guid("5bc6fee3-93b5-12c4-c219-a7691960251d"), 11.29m, new DateTime(2021, 6, 17, 0, 19, 48, 449, DateTimeKind.Local).AddTicks(5886), "6WE5HDQ1", 1m }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerId", "GrossValue", "InvoiceDate", "InvoiceNumber", "NetValue" },
                values: new object[,]
                {
                    { new Guid("d51b08ee-160f-8830-6431-dd4692f5be4c"), new Guid("28e1d4fb-89d6-fa5b-d68e-2cf52ce3ddf7"), 9.89m, new DateTime(2022, 8, 3, 9, 5, 47, 609, DateTimeKind.Local).AddTicks(4860), "QXG6PBT9", 6m },
                    { new Guid("d62e454a-6903-6c51-36d5-101baf1ada98"), new Guid("95284686-8903-a2ba-be4f-8b4596038776"), 3.76m, new DateTime(2022, 4, 23, 18, 5, 39, 196, DateTimeKind.Local).AddTicks(4149), "DDBW8OWV", 5m },
                    { new Guid("d6ba79c3-242e-81c4-54a1-69f3c2fdd5d3"), new Guid("8eaa7c51-4d3f-8130-b864-c56d66eaeee7"), 13.15m, new DateTime(2020, 9, 17, 22, 25, 25, 871, DateTimeKind.Local).AddTicks(9114), "DYZB6GB7", 6m },
                    { new Guid("d7569d94-3e3b-bc0e-4e7d-aaa9f8eb7ec0"), new Guid("c8538da7-2dc0-e0ce-aeb2-bf8976ad59d0"), 1.05m, new DateTime(2021, 4, 9, 12, 43, 42, 966, DateTimeKind.Local).AddTicks(4066), "IR0KC6VK", 4m },
                    { new Guid("d9506bbb-0170-b432-4b91-a67dffc2bd22"), new Guid("027dd28c-deaf-eb60-24a2-58510c3dacf9"), 6.69m, new DateTime(2020, 6, 10, 21, 27, 1, 183, DateTimeKind.Local).AddTicks(3859), "PM7MW9KR", 7m },
                    { new Guid("d99851ec-323b-e30c-2573-871ee43bf900"), new Guid("d99c821e-13f9-9414-593d-fe4ef0ac1f39"), 2.11m, new DateTime(2022, 3, 12, 3, 52, 58, 343, DateTimeKind.Local).AddTicks(8468), "ZYH0K5KG", 2m },
                    { new Guid("d9c266f4-ee9e-78cb-99a5-3d045b0cd0e1"), new Guid("5bc6fee3-93b5-12c4-c219-a7691960251d"), 13.71m, new DateTime(2021, 7, 22, 20, 16, 4, 986, DateTimeKind.Local).AddTicks(1056), "4DM3C1TS", 6m },
                    { new Guid("da53de56-cea4-eaf0-2d02-0949c7cf691c"), new Guid("8eaa7c51-4d3f-8130-b864-c56d66eaeee7"), 5.31m, new DateTime(2019, 9, 15, 5, 50, 4, 173, DateTimeKind.Local).AddTicks(3293), "EV4NSJ25", 7m },
                    { new Guid("dd4ec4a8-57c6-dc98-4e2c-831c20d9f789"), new Guid("09f1414f-a259-5d89-9ec0-5b52367eb543"), 6.48m, new DateTime(2020, 4, 10, 6, 22, 43, 475, DateTimeKind.Local).AddTicks(1914), "MPIOPNAU", 1m },
                    { new Guid("dd54fced-9971-4843-341b-5da762d8eae7"), new Guid("a11635a8-5bcf-e2e9-c02c-82cb4133e239"), 2.38m, new DateTime(2020, 7, 12, 7, 22, 43, 97, DateTimeKind.Local).AddTicks(895), "33MVS936", 5m },
                    { new Guid("ddc8b98a-8584-f1a8-93e9-bc21b6890eee"), new Guid("5e0efbdb-f195-7a88-6b47-e1e412f96b26"), 7.58m, new DateTime(2021, 5, 17, 19, 40, 28, 417, DateTimeKind.Local).AddTicks(4293), "09A88SNM", 7m },
                    { new Guid("ddf019a6-8922-8aa9-0c11-1139889ec5e8"), new Guid("034fef44-111a-a4e7-132d-6828b1d0e143"), 14.18m, new DateTime(2022, 7, 19, 18, 58, 43, 886, DateTimeKind.Local).AddTicks(697), "ORU5GJA5", 2m },
                    { new Guid("de6f65c2-7a88-eb93-ef4a-14a6268d8988"), new Guid("44c45e62-9ca5-023b-9dc4-26bddc0231f7"), 1.43m, new DateTime(2021, 12, 16, 0, 12, 40, 533, DateTimeKind.Local).AddTicks(1430), "425V2RF9", 2m },
                    { new Guid("df02f3cb-e223-f35e-c593-556aaf2e0452"), new Guid("a9f2f10f-c683-3431-54ac-ddbbccf48026"), 3.20m, new DateTime(2020, 3, 1, 22, 57, 54, 317, DateTimeKind.Local).AddTicks(4557), "37Z6KKCC", 3m },
                    { new Guid("df58e86c-2f76-f953-5a9f-54d2d9d61dc9"), new Guid("2ffa2eba-2edb-4919-e263-f11d48f879e5"), 6.04m, new DateTime(2020, 11, 1, 10, 3, 10, 574, DateTimeKind.Local).AddTicks(9799), "OUAAMGZK", 4m },
                    { new Guid("df72fdbe-0280-b018-0b4b-0f57dff6fa40"), new Guid("e93353c7-75ae-d2ea-b3b1-cb974c4a126c"), 6.27m, new DateTime(2022, 5, 8, 16, 59, 35, 3, DateTimeKind.Local).AddTicks(4810), "AF2BAKTH", 2m },
                    { new Guid("e0c20429-4c55-cf8b-3050-7383e932745b"), new Guid("5e3d9486-02e2-94bf-aa3d-821c260dec27"), 10.02m, new DateTime(2021, 5, 5, 17, 13, 52, 322, DateTimeKind.Local).AddTicks(5489), "PYKNDBLX", 5m },
                    { new Guid("e0c626b2-0a84-87b9-f8d8-516eef912c90"), new Guid("b1e1a113-fdf7-7550-a220-17096d5c1e87"), 5.66m, new DateTime(2022, 3, 13, 6, 49, 22, 0, DateTimeKind.Local).AddTicks(828), "IDY521DJ", 5m },
                    { new Guid("e19b2a55-18dd-c812-07ba-88fb93f54b92"), new Guid("5bc6fee3-93b5-12c4-c219-a7691960251d"), 8.45m, new DateTime(2020, 2, 29, 12, 29, 3, 568, DateTimeKind.Local).AddTicks(8338), "8VUW9RPM", 1m },
                    { new Guid("e30ee886-d60c-3472-e0c3-ba24b978ce3d"), new Guid("d148b4e6-ff76-32db-4fad-318146507d6f"), 2.44m, new DateTime(2021, 4, 30, 11, 57, 54, 846, DateTimeKind.Local).AddTicks(7086), "12KUD3C1", 5m },
                    { new Guid("e3129f11-28f2-eac8-d1c1-e731d8c31577"), new Guid("952d30a2-933d-5484-726f-1a37ad2c4403"), 14.04m, new DateTime(2020, 1, 16, 19, 12, 34, 152, DateTimeKind.Local).AddTicks(4758), "AAIALWOY", 2m },
                    { new Guid("e5d40199-5093-aa7b-b04f-bc46ba24b6e2"), new Guid("39d1e188-9439-3ce0-c150-9cf5314e3e04"), 2.26m, new DateTime(2022, 5, 29, 18, 22, 36, 101, DateTimeKind.Local).AddTicks(3998), "01KDCD9I", 5m },
                    { new Guid("e66c852d-01a6-9ad9-ceec-dfd0599dcec9"), new Guid("5bc6fee3-93b5-12c4-c219-a7691960251d"), 5.35m, new DateTime(2020, 1, 7, 22, 13, 29, 255, DateTimeKind.Local).AddTicks(5753), "EEWF11K1", 5m },
                    { new Guid("e72d6a46-1e87-e13f-116d-208061fd9c74"), new Guid("c8538da7-2dc0-e0ce-aeb2-bf8976ad59d0"), 10.57m, new DateTime(2021, 4, 5, 21, 20, 31, 964, DateTimeKind.Local).AddTicks(6895), "GSKRTUXK", 7m },
                    { new Guid("e88ffa90-afe6-cb09-09ee-a7e74e56a0fa"), new Guid("d6d185fe-6c0f-445b-d270-c2b10b59cc53"), 3.15m, new DateTime(2021, 6, 13, 19, 56, 32, 554, DateTimeKind.Local).AddTicks(1478), "KKOYCXT7", 4m },
                    { new Guid("e98fa702-59a6-0f61-7dc8-30fa96b5779d"), new Guid("d6d185fe-6c0f-445b-d270-c2b10b59cc53"), 10.31m, new DateTime(2022, 4, 26, 1, 40, 25, 916, DateTimeKind.Local).AddTicks(8082), "1Y37H1J0", 4m },
                    { new Guid("e9ad12e1-5100-1964-52d2-b30c565302bb"), new Guid("6c1c4534-be8c-c2a6-d116-3c19ae1f0b56"), 10.42m, new DateTime(2021, 4, 21, 3, 55, 17, 360, DateTimeKind.Local).AddTicks(8159), "FQ2WRABE", 7m },
                    { new Guid("ec37a201-b4ee-e2b8-ab3d-89aea56794a8"), new Guid("510d7fc5-b00b-c557-f7b0-0592a28a38ae"), 1.52m, new DateTime(2021, 6, 6, 3, 5, 45, 107, DateTimeKind.Local).AddTicks(6556), "1AJ827FM", 8m },
                    { new Guid("ed6e95e5-7e81-7f16-dcaa-936d5b89aa26"), new Guid("032c8f96-89df-993b-886e-bd1639ae9618"), 11.33m, new DateTime(2021, 2, 10, 1, 4, 22, 179, DateTimeKind.Local).AddTicks(8878), "AY0Y432Q", 4m },
                    { new Guid("ef756515-5ccd-38b1-47ed-ec981c790917"), new Guid("6fbc7d12-fdfd-1ae8-5d4e-961402bb912c"), 12.37m, new DateTime(2021, 11, 19, 22, 56, 47, 662, DateTimeKind.Local).AddTicks(4752), "E71Z1XFR", 5m },
                    { new Guid("f002bc39-375d-f9b8-ecfb-5f00cffa36bf"), new Guid("6bbe50de-9d99-61d9-38e8-dd725bd7c5c8"), 3.49m, new DateTime(2020, 7, 28, 15, 45, 10, 829, DateTimeKind.Local).AddTicks(3584), "NF0T88ZV", 6m },
                    { new Guid("f0d78713-2dc6-59b1-ea2a-4b718daeb44a"), new Guid("bc14ae4e-2faa-c21b-3d73-961df0ee18a2"), 6.87m, new DateTime(2021, 3, 13, 1, 26, 14, 586, DateTimeKind.Local).AddTicks(9116), "OJ44NQN0", 2m },
                    { new Guid("f1ed5e9f-b988-bff4-313f-26d3aaa3ee6e"), new Guid("510d7fc5-b00b-c557-f7b0-0592a28a38ae"), 2.39m, new DateTime(2022, 8, 24, 15, 21, 42, 741, DateTimeKind.Local).AddTicks(4761), "MLFF7Y4T", 3m },
                    { new Guid("f34ab4be-4068-ed77-e899-9c3b5c11cdb0"), new Guid("032c8f96-89df-993b-886e-bd1639ae9618"), 11.11m, new DateTime(2022, 2, 24, 20, 20, 59, 926, DateTimeKind.Local).AddTicks(48), "L00PK4KF", 7m },
                    { new Guid("f3cc053d-3283-ce26-f5b9-a5bee3e5c571"), new Guid("510d7fc5-b00b-c557-f7b0-0592a28a38ae"), 11.00m, new DateTime(2020, 8, 23, 6, 47, 33, 749, DateTimeKind.Local).AddTicks(7977), "29M7N5GS", 7m },
                    { new Guid("f580a18b-e105-d938-c696-443d70a68e54"), new Guid("95284686-8903-a2ba-be4f-8b4596038776"), 10.78m, new DateTime(2021, 12, 6, 22, 31, 10, 577, DateTimeKind.Local).AddTicks(7295), "EF8ZH3NN", 3m },
                    { new Guid("f5c037bd-070d-05be-91ae-67c324592285"), new Guid("09f1414f-a259-5d89-9ec0-5b52367eb543"), 7.53m, new DateTime(2020, 5, 5, 11, 57, 37, 274, DateTimeKind.Local).AddTicks(7607), "AAJOAFTZ", 7m },
                    { new Guid("f6ae208f-4928-ffe0-9302-8ef68567de7b"), new Guid("f030ab10-5450-c1a1-8e70-9b71b3665e9d"), 1.77m, new DateTime(2021, 2, 1, 2, 52, 7, 585, DateTimeKind.Local).AddTicks(3138), "ZAOEDRVG", 2m },
                    { new Guid("f77d3c67-13f1-e803-c1e9-2f4fe3ac268e"), new Guid("23e8961b-746c-a834-d2f0-6c7604251a3a"), 4.76m, new DateTime(2020, 3, 2, 7, 37, 20, 603, DateTimeKind.Local).AddTicks(7703), "0P95JSNR", 6m },
                    { new Guid("f82a84d5-63ec-0f0d-9901-0a8f70408670"), new Guid("f3676bf8-b41a-3b21-9ca9-64ed7de04b03"), 9.61m, new DateTime(2020, 11, 6, 5, 50, 30, 259, DateTimeKind.Local).AddTicks(5370), "IA2USCVU", 4m },
                    { new Guid("f9251e1b-bae5-8aaa-b219-d250d44d24b7"), new Guid("5e3d9486-02e2-94bf-aa3d-821c260dec27"), 7.01m, new DateTime(2022, 4, 9, 13, 14, 2, 261, DateTimeKind.Local).AddTicks(2085), "GHRGZUF6", 3m },
                    { new Guid("f93f6a95-3178-33ce-f417-30fe6c749e3e"), new Guid("032c8f96-89df-993b-886e-bd1639ae9618"), 6.10m, new DateTime(2021, 3, 13, 23, 55, 50, 851, DateTimeKind.Local).AddTicks(835), "U0MHYCLP", 7m }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerId", "GrossValue", "InvoiceDate", "InvoiceNumber", "NetValue" },
                values: new object[,]
                {
                    { new Guid("faa055aa-8c2f-d0d8-19c8-f171dea2a033"), new Guid("d99c821e-13f9-9414-593d-fe4ef0ac1f39"), 1.40m, new DateTime(2019, 12, 13, 5, 35, 29, 555, DateTimeKind.Local).AddTicks(6626), "W8UCJQGB", 7m },
                    { new Guid("fd4e7844-4ebb-d011-cdb2-d98b5f57c1c4"), new Guid("d148b4e6-ff76-32db-4fad-318146507d6f"), 2.42m, new DateTime(2019, 10, 12, 23, 50, 47, 740, DateTimeKind.Local).AddTicks(7576), "LQ2PGV65", 2m },
                    { new Guid("fd932e93-9f28-9066-7db1-42e5acbe3554"), new Guid("6bbe50de-9d99-61d9-38e8-dd725bd7c5c8"), 1.19m, new DateTime(2019, 9, 26, 8, 15, 39, 477, DateTimeKind.Local).AddTicks(4427), "RA5UMC6I", 6m },
                    { new Guid("fe4d2a4b-a72f-71b4-9479-ef5eafc53736"), new Guid("d6d185fe-6c0f-445b-d270-c2b10b59cc53"), 3.59m, new DateTime(2020, 5, 2, 12, 51, 12, 182, DateTimeKind.Local).AddTicks(4536), "IGMMC7Q4", 8m },
                    { new Guid("fe902837-d96a-2e51-77eb-8bacd52ea596"), new Guid("d148b4e6-ff76-32db-4fad-318146507d6f"), 4.63m, new DateTime(2020, 11, 18, 17, 10, 3, 579, DateTimeKind.Local).AddTicks(4202), "P6G1TH54", 3m },
                    { new Guid("ffbaf8a2-6097-0a50-d017-4045a5234794"), new Guid("952d30a2-933d-5484-726f-1a37ad2c4403"), 1.83m, new DateTime(2019, 10, 15, 14, 22, 16, 464, DateTimeKind.Local).AddTicks(6608), "VN1RXK0S", 2m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerId",
                table: "Invoices",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
