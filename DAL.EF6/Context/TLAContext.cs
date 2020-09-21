namespace DAL.EF6.Context
{
    using DAL.EF6.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TLAContext : DbContext
    {
        // Your context has been configured to use a 'TLAContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.EF6.Context.TLAContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TLAContext' 
        // connection string in the application configuration file.
        public TLAContext()
            : base("name=TLAContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Galaxy> Galaxies { get; set; }
        public virtual DbSet<Planet> Planets { get; set; }
    }    
}