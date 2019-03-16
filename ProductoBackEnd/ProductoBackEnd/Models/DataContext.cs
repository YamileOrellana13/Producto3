namespace ProductoBackEnd.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnecction")
        {

        }

        public System.Data.Entity.DbSet<ProductoBackEnd.Models.Producto> Productoes { get; set; }
    }
}