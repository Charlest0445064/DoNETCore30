using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCApp.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "NewsFiles",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Extension",
                table: "NewsFiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "NewsFilesId",
                table: "NewsFiles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                table: "News",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "News",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDateTime",
                table: "News",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDateTime",
                table: "News",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDateTime",
                table: "News",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "News",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<Guid>(
                name: "NewsId",
                table: "News",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newid())",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employee",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "Name" },
                values: new object[,]
                {
                    { 1, "交通局" },
                    { 2, "工務局" },
                    { 3, "農業局" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "王大明" },
                    { 2, 2, "林曉明" },
                    { 3, 3, "陳芸芸" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "NewsId", "Click", "Contents", "DepartmentId", "Enable", "EndDateTime", "InsertDateTime", "InsertEmployeeId", "StartDateTime", "Title", "UpdateDateTime", "UpdateEmployeeId" },
                values: new object[,]
                {
                    { new Guid("552d407d-f8bf-4ac7-908a-b05a8ada4538"), 1161, "高雄出產的新鮮紅心芭樂持續進入馬來西亞吉隆坡市場，今年度首次上架新開張的高端超市「Imby Greens」，該超市位於馬來西亞第二高樓、去年甫開幕的敦拉薩國際貿易中心（Tun Razak Exchange，簡稱「TRX」） 內，以販售世界各地頂級商品為主，高雄首選紅心芭樂除上架銷售外，還舉辦試吃推廣活動，受到當地消費者的熱烈迴響，直呼「又脆又好吃」，顯示高雄紅心芭樂不僅在品質上備受肯定，更展現了台灣農產品在國際市場上的競爭力和影響力。", 3, true, new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "台灣好芭 進軍大馬 紅心芭樂魅力席捲吉隆坡", new DateTime(2024, 7, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { new Guid("5f5721de-bd52-4974-81d0-2533c4c3e0b0"), 1561, "【高雄訊】近日高雄青年路(復興-林森)如火如荼進行道路重鋪工程，有眼尖民眾發現標線繪製線條與之前不一樣，高雄市交通局特別說明，因施工範圍長，道路兩側寬度不同處，在施工過程中依實地狀況做適時調整，並重新分配車道空間，為了交通安全，這都是必要的工作。", 1, true, new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "青年路家具街增設左轉車道及路面邊線，有效界定車流動線、安全再升級！", new DateTime(2024, 7, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("cb975c0b-ebdc-4969-a4cd-504845a6b538"), 61, "楠梓火車站是楠梓與周邊地區的運輸門戶，鄰近工業區、加工出口區、高雄科技大學、高雄都會公園等，形成機能豐富的生活圈。為提升楠梓區域旅運與民生往來品質，市府工務局道路養護工程處針對車站周邊人行道進行改善，已陸續整新楠梓新路東側（建楠路至楠梓區公所）、建楠路（全線）人行道，楠梓新路西側（建楠路至惠民捷道）人行道改善也接續於今（113）年6月底進場施做。", 2, true, new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "楠梓火車站周邊人行道改善 提升通行舒適度", new DateTime(2024, 7, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("dbeca09e-65b7-44f4-b24d-2f68b177f1d2"), 261, "翠亨路是前鎮、小港區的幹道之一，也是兩地居民往返高雄市區的重要道路，翠亨路早期原有台糖運送貨物鐵道，經市府工務局改造成自行車道後，逐步升級周邊街景，從日常的設施維護改善、綠美化到專案辦理鐵道意象改造設置觀機平台、花架綠廊與翠平公園旁閒置空地環境再造等，近期再接力完成翠亨南路（平和東路至崇安街）路面改善及高雄國際花卉市場南側空地景觀營造，以提升區域生活品質、優化高市迎賓門戶整體風貌。", 2, true, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "高雄國際花卉市場周邊道路景觀整建 營造舒適綠空間", new DateTime(2024, 7, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("e39e7e80-7fd6-4e55-94b0-20cce488064a"), 161, "【高雄訊】夏日日頭赤炎炎，機車族在停等沒有綠蔭的路口紅燈時，不免會有為何不能縮短秒數，減少停等曝曬時間的想法。高雄市交通局表示，7月起逐步於三民區以及苓雅區部分路段試辦縮短號誌週期秒數，可減少紅燈停等時的陽光曝曬時間，交通局也會持續觀察車流紓解狀況，適時檢討調整。", 1, true, new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "夏日氣溫炎熱！交通局研擬調整號誌秒數，縮短停等時間。", new DateTime(2024, 7, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("552d407d-f8bf-4ac7-908a-b05a8ada4538"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("5f5721de-bd52-4974-81d0-2533c4c3e0b0"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("cb975c0b-ebdc-4969-a4cd-504845a6b538"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("dbeca09e-65b7-44f4-b24d-2f68b177f1d2"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("e39e7e80-7fd6-4e55-94b0-20cce488064a"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "NewsFiles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Extension",
                table: "NewsFiles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<Guid>(
                name: "NewsFilesId",
                table: "NewsFiles",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newid())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                table: "News",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDateTime",
                table: "News",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDateTime",
                table: "News",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDateTime",
                table: "News",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                table: "News",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "NewsId",
                table: "News",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "(newid())");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
