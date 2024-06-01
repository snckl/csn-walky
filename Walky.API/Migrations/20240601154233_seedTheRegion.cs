using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Walky.API.Migrations
{
    /// <inheritdoc />
    public partial class seedTheRegion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("0614d6cf-08e0-454d-b3d6-389bc8fc2484"), "NE", "Nebraska", "https://shorturl.at/adavG" },
                    { new Guid("107abc18-27b4-43a0-9e30-9700166fe666"), "ME", "Maine", "https://shorturl.at/adavG" },
                    { new Guid("14ecb970-570e-4fe6-9ce9-932abd541910"), "NC", "North Carolina", "https://shorturl.at/adavG" },
                    { new Guid("1d567ecd-6d15-4c68-ac99-3dc87a9a85a9"), "FL", "Florida", "https://shorturl.at/adavG" },
                    { new Guid("28618e54-5ff1-4734-abf3-c6364ebaaef9"), "LA", "Louisiana", "https://shorturl.at/adavG" },
                    { new Guid("35f5b11f-57b4-4878-9506-5c706e546f9b"), "CO", "Colorado", "https://shorturl.at/adavG" },
                    { new Guid("40d724b2-d596-4998-8ed2-34ae64d89303"), "OH", "Ohio", "https://shorturl.at/adavG" },
                    { new Guid("4439b703-74a0-4538-9d25-d4ddf3e8514f"), "NH", "New Hampshire", "https://shorturl.at/adavG" },
                    { new Guid("4545fe48-5ac3-4fcb-80c1-1a013ba2304a"), "MN", "Minnesota", "https://shorturl.at/adavG" },
                    { new Guid("4e95731d-6fc0-4eb6-b010-8044c066837e"), "AR", "Arkansas", "https://shorturl.at/adavG" },
                    { new Guid("5f5b1710-dad9-4ad7-ac72-77d6f44938c4"), "ID", "Idaho", "https://shorturl.at/adavG" },
                    { new Guid("649d1df5-18cf-4085-93a6-b753e1bf6884"), "MT", "Montana", "https://shorturl.at/adavG" },
                    { new Guid("779b9b3b-fbe6-4410-9a33-03285ae4a1bb"), "NY", "New York", "https://shorturl.at/adavG" },
                    { new Guid("78ba0ad0-ffe7-4046-89c2-1aeab8c08980"), "IL", "Illinois", "https://shorturl.at/adavG" },
                    { new Guid("800803e9-59e3-49f9-a8d1-00344181e8e8"), "MS", "Mississippi", "https://shorturl.at/adavG" },
                    { new Guid("86b724ff-7425-43e3-974f-f89e78615a14"), "IA", "Iowa", "https://shorturl.at/adavG" },
                    { new Guid("8d3275a1-0131-4ca1-90a8-67001f5922e0"), "NJ", "New Jersey", "https://shorturl.at/adavG" },
                    { new Guid("99e1b72b-f611-4881-ba01-5a3463dad76e"), "AZ", "Arizona", "https://shorturl.at/adavG" },
                    { new Guid("a00df190-3719-4cb4-9460-697a6fef18ce"), "KY", "Kentucky", "https://shorturl.at/adavG" },
                    { new Guid("a381f8f0-dedc-4c5f-bc4e-30a357247342"), "IN", "Indiana", "https://shorturl.at/adavG" },
                    { new Guid("a6521336-8469-4f0b-83bc-eef392d4fc07"), "NV", "Nevada", "https://shorturl.at/adavG" },
                    { new Guid("ad4d3bc9-3e98-4aed-8820-96fb90304546"), "OR", "Oregon", "https://shorturl.at/adavG" },
                    { new Guid("ae723d20-910c-48aa-9c31-1eb15d3098fe"), "AL", "Alabama", "https://shorturl.at/adavG" },
                    { new Guid("b1e65c0c-8acf-4133-b38e-e98e9a18691a"), "MI", "Michigan", "https://shorturl.at/adavG" },
                    { new Guid("bcd2ded6-59eb-4d41-8f8b-fce2ea5474a1"), "ND", "North Dakota", "https://shorturl.at/adavG" },
                    { new Guid("bfaf2b93-63f9-4912-84d5-8c3df9487c92"), "KS", "Kansas", "https://shorturl.at/adavG" },
                    { new Guid("cadabf03-cd65-4791-958f-4c72b9ab0eeb"), "MA", "Massachusetts", "https://shorturl.at/adavG" },
                    { new Guid("cf78e1b1-d0d1-4e32-a7b4-0d4e6a2fea5b"), "NM", "New Mexico", "https://shorturl.at/adavG" },
                    { new Guid("d40f63a5-cfe6-454f-97a6-9d67a820eccd"), "PA", "Pennsylvania", "https://shorturl.at/adavG" },
                    { new Guid("d472493e-8fd5-4bfd-9480-4f4d14ce96f2"), "DE", "Delaware", "https://shorturl.at/adavG" },
                    { new Guid("da8aa44f-ef79-457d-92fc-df4dfa4f7462"), "AK", "Alaska", "https://shorturl.at/adavG" },
                    { new Guid("db9b4f7e-677f-4a60-a523-4c87b46d411d"), "HI", "Hawaii", "https://shorturl.at/adavG" },
                    { new Guid("eabedb0c-181c-4087-8372-a19c089c172f"), "MO", "Missouri", "https://shorturl.at/adavG" },
                    { new Guid("ebcb489b-716b-4a5f-838b-4d442947c7fe"), "GA", "Georgia", "https://shorturl.at/adavG" },
                    { new Guid("f673abd3-c35e-43f9-ac8b-2ade09d106c1"), "CT", "Connecticut", "https://shorturl.at/adavG" },
                    { new Guid("f712bbf6-328f-4ffd-b7b3-cb043c65483e"), "OK", "Oklahoma", "https://shorturl.at/adavG" },
                    { new Guid("f9ac364a-3b36-4834-a26d-6ff92aaa9168"), "MD", "Maryland", "https://shorturl.at/adavG" },
                    { new Guid("fd35630c-31f5-4625-8523-eeebf6ae42f5"), "CA", "California", "https://shorturl.at/adavG" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("0614d6cf-08e0-454d-b3d6-389bc8fc2484"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("107abc18-27b4-43a0-9e30-9700166fe666"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("14ecb970-570e-4fe6-9ce9-932abd541910"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1d567ecd-6d15-4c68-ac99-3dc87a9a85a9"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("28618e54-5ff1-4734-abf3-c6364ebaaef9"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("35f5b11f-57b4-4878-9506-5c706e546f9b"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("40d724b2-d596-4998-8ed2-34ae64d89303"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("4439b703-74a0-4538-9d25-d4ddf3e8514f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("4545fe48-5ac3-4fcb-80c1-1a013ba2304a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("4e95731d-6fc0-4eb6-b010-8044c066837e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5f5b1710-dad9-4ad7-ac72-77d6f44938c4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("649d1df5-18cf-4085-93a6-b753e1bf6884"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("779b9b3b-fbe6-4410-9a33-03285ae4a1bb"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("78ba0ad0-ffe7-4046-89c2-1aeab8c08980"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("800803e9-59e3-49f9-a8d1-00344181e8e8"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("86b724ff-7425-43e3-974f-f89e78615a14"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8d3275a1-0131-4ca1-90a8-67001f5922e0"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("99e1b72b-f611-4881-ba01-5a3463dad76e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a00df190-3719-4cb4-9460-697a6fef18ce"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a381f8f0-dedc-4c5f-bc4e-30a357247342"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a6521336-8469-4f0b-83bc-eef392d4fc07"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ad4d3bc9-3e98-4aed-8820-96fb90304546"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ae723d20-910c-48aa-9c31-1eb15d3098fe"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("b1e65c0c-8acf-4133-b38e-e98e9a18691a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("bcd2ded6-59eb-4d41-8f8b-fce2ea5474a1"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("bfaf2b93-63f9-4912-84d5-8c3df9487c92"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cadabf03-cd65-4791-958f-4c72b9ab0eeb"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cf78e1b1-d0d1-4e32-a7b4-0d4e6a2fea5b"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d40f63a5-cfe6-454f-97a6-9d67a820eccd"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d472493e-8fd5-4bfd-9480-4f4d14ce96f2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("da8aa44f-ef79-457d-92fc-df4dfa4f7462"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("db9b4f7e-677f-4a60-a523-4c87b46d411d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("eabedb0c-181c-4087-8372-a19c089c172f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ebcb489b-716b-4a5f-838b-4d442947c7fe"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f673abd3-c35e-43f9-ac8b-2ade09d106c1"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f712bbf6-328f-4ffd-b7b3-cb043c65483e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f9ac364a-3b36-4834-a26d-6ff92aaa9168"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("fd35630c-31f5-4625-8523-eeebf6ae42f5"));
        }
    }
}
