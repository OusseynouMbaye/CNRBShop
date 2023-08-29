using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CNRBShop.Migrations
{
    /// <inheritdoc />
    public partial class initiationMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: true),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    InStock = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsForMan = table.Column<bool>(type: "INTEGER", nullable: true),
                    IsFemale = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "InStock", "IsFemale", "IsForMan", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "vel", "https://picsum.photos/640/480/?image=180", false, null, null, "Incredible Rubber Gloves", 54m },
                    { 2, "expedita", "https://picsum.photos/640/480/?image=336", false, null, null, "Gorgeous Frozen Towels", 49m },
                    { 3, "Autem et iusto ipsa quod consequatur ut voluptatibus voluptatibus. Dolorum quidem minima nihil. Magni sit labore blanditiis nostrum.", "https://picsum.photos/640/480/?image=238", true, null, null, "Fantastic Rubber Computer", 50m },
                    { 4, "reiciendis", "https://picsum.photos/640/480/?image=237", false, null, null, "Generic Fresh Pizza", 49m },
                    { 5, "Reiciendis ea saepe maiores voluptatum nam est ut. Repudiandae sapiente nostrum aut earum vero aliquid exercitationem aliquid. Dignissimos distinctio voluptatem adipisci quis odit quo culpa assumenda libero. Aut unde corrupti non facere veniam. Delectus impedit accusamus doloribus molestias pariatur eaque. Odit delectus quaerat et ut aut.", "https://picsum.photos/640/480/?image=492", false, null, null, "Awesome Metal Keyboard", 53m },
                    { 6, "maiores", "https://picsum.photos/640/480/?image=68", false, null, null, "Incredible Soft Salad", 57m },
                    { 7, "Ut ut est consequatur praesentium molestiae qui cum hic.\nEum et ex cumque hic nisi id.\nVoluptas et quis eum.\nNisi est molestiae rerum ut et.\nVel aperiam autem velit illum quae aut aut quo fugiat.", "https://picsum.photos/640/480/?image=735", false, null, null, "Handmade Concrete Ball", 55m },
                    { 8, "Ut optio vel sequi est quia ut.\nAliquam enim aut fugiat ipsam sit at nulla.\nConsequatur eum quis.\nRepellat explicabo non dolore.\nVoluptates aut sed quia mollitia eum placeat.", "https://picsum.photos/640/480/?image=778", true, null, null, "Gorgeous Plastic Table", 56m },
                    { 9, "Voluptatibus et impedit.", "https://picsum.photos/640/480/?image=59", true, null, null, "Unbranded Cotton Bacon", 49m },
                    { 10, "Et illum ut nihil delectus non impedit et.", "https://picsum.photos/640/480/?image=265", false, null, null, "Rustic Cotton Cheese", 52m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
