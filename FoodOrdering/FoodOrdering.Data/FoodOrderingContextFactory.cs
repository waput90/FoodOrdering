using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FoodOrdering.Data
{
    public class FoodOrderingContextFactory: IDesignTimeDbContextFactory<FoodOrderingDbContext>
    {
        FoodOrderingDbContext IDesignTimeDbContextFactory<FoodOrderingDbContext>.CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FoodOrderingDbContext>();
            builder.UseMySQL("Server=localhost;Port=3308;Database=foodordering;Uid=root;");
            // builder.UseSqlServer("Server=sql6009.site4now.net;uid=DB_A4D3D9_pFarmersDb_admin;pwd=Pr0f1tF@rm3r5p@s;Initial Catalog=DB_A4D3D9_pFarmersDb");
            // builder.UseSqlServer("Server=sql6007.site4now.net;uid=DB_A4D3D9_staging_admin;pwd=Pr0f1tF@rm3r5p@s;Initial Catalog=DB_A4D3D9_staging");
            return new FoodOrderingDbContext(builder.Options);
        }
    }
}