using Microsoft.EntityFrameworkCore;
using Walky.API.Models.Domain;

namespace Walky.API.Data
{
    public class WalkyDbContext : DbContext
    {
        public WalkyDbContext(DbContextOptions<WalkyDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties

            var difficulties = new List<Difficulty>()
            { 
                new Difficulty()
                {
                    Id = Guid.Parse("39dbc1e0-2bf5-4c3e-8251-8ddf9e277a15"),
                    Name = "Easy"
                },
                                new Difficulty()
                {
                    Id = Guid.Parse("e93be645-6021-4e41-8ef0-31a36adf350d"),
                    Name = "Medium"
                },
                                new Difficulty()
                {
                    Id = Guid.Parse("ed18c14b-9732-4741-b245-2692e593d828"),
                    Name = "Hard"
                }
            };
            var regions = new List<Region>()
            {
                new Region() { Id = Guid.Parse("ae723d20-910c-48aa-9c31-1eb15d3098fe"), Code = "AL", Name = "Alabama", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("da8aa44f-ef79-457d-92fc-df4dfa4f7462"), Code = "AK", Name = "Alaska", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("99e1b72b-f611-4881-ba01-5a3463dad76e"), Code = "AZ", Name = "Arizona", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("4e95731d-6fc0-4eb6-b010-8044c066837e"), Code = "AR", Name = "Arkansas", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("fd35630c-31f5-4625-8523-eeebf6ae42f5"), Code = "CA", Name = "California", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("35f5b11f-57b4-4878-9506-5c706e546f9b"), Code = "CO", Name = "Colorado", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("f673abd3-c35e-43f9-ac8b-2ade09d106c1"), Code = "CT", Name = "Connecticut", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("d472493e-8fd5-4bfd-9480-4f4d14ce96f2"), Code = "DE", Name = "Delaware", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("1d567ecd-6d15-4c68-ac99-3dc87a9a85a9"), Code = "FL", Name = "Florida", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("ebcb489b-716b-4a5f-838b-4d442947c7fe"), Code = "GA", Name = "Georgia", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("db9b4f7e-677f-4a60-a523-4c87b46d411d"), Code = "HI", Name = "Hawaii", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("5f5b1710-dad9-4ad7-ac72-77d6f44938c4"), Code = "ID", Name = "Idaho", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("78ba0ad0-ffe7-4046-89c2-1aeab8c08980"), Code = "IL", Name = "Illinois", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("a381f8f0-dedc-4c5f-bc4e-30a357247342"), Code = "IN", Name = "Indiana", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("86b724ff-7425-43e3-974f-f89e78615a14"), Code = "IA", Name = "Iowa", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("bfaf2b93-63f9-4912-84d5-8c3df9487c92"), Code = "KS", Name = "Kansas", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("a00df190-3719-4cb4-9460-697a6fef18ce"), Code = "KY", Name = "Kentucky", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("28618e54-5ff1-4734-abf3-c6364ebaaef9"), Code = "LA", Name = "Louisiana", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("107abc18-27b4-43a0-9e30-9700166fe666"), Code = "ME", Name = "Maine", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("f9ac364a-3b36-4834-a26d-6ff92aaa9168"), Code = "MD", Name = "Maryland", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("cadabf03-cd65-4791-958f-4c72b9ab0eeb"), Code = "MA", Name = "Massachusetts", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("b1e65c0c-8acf-4133-b38e-e98e9a18691a"), Code = "MI", Name = "Michigan", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("4545fe48-5ac3-4fcb-80c1-1a013ba2304a"), Code = "MN", Name = "Minnesota", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("800803e9-59e3-49f9-a8d1-00344181e8e8"), Code = "MS", Name = "Mississippi", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("eabedb0c-181c-4087-8372-a19c089c172f"), Code = "MO", Name = "Missouri", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("649d1df5-18cf-4085-93a6-b753e1bf6884"), Code = "MT", Name = "Montana", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("0614d6cf-08e0-454d-b3d6-389bc8fc2484"), Code = "NE", Name = "Nebraska", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("a6521336-8469-4f0b-83bc-eef392d4fc07"), Code = "NV", Name = "Nevada", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("4439b703-74a0-4538-9d25-d4ddf3e8514f"), Code = "NH", Name = "New Hampshire", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("8d3275a1-0131-4ca1-90a8-67001f5922e0"), Code = "NJ", Name = "New Jersey", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("cf78e1b1-d0d1-4e32-a7b4-0d4e6a2fea5b"), Code = "NM", Name = "New Mexico", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("779b9b3b-fbe6-4410-9a33-03285ae4a1bb"), Code = "NY", Name = "New York", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("14ecb970-570e-4fe6-9ce9-932abd541910"), Code = "NC", Name = "North Carolina", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("bcd2ded6-59eb-4d41-8f8b-fce2ea5474a1"), Code = "ND", Name = "North Dakota", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("40d724b2-d596-4998-8ed2-34ae64d89303"), Code = "OH", Name = "Ohio", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("f712bbf6-328f-4ffd-b7b3-cb043c65483e"), Code = "OK", Name = "Oklahoma", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("ad4d3bc9-3e98-4aed-8820-96fb90304546"), Code = "OR", Name = "Oregon", RegionImageUrl = "https://shorturl.at/adavG" },
                new Region() { Id = Guid.Parse("d40f63a5-cfe6-454f-97a6-9d67a820eccd"), Code = "PA", Name = "Pennsylvania", RegionImageUrl = "https://shorturl.at/adavG" }
            };

            modelBuilder.Entity<Difficulty>().HasData(difficulties);
            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
